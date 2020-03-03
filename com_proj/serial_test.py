import serial
import serial.tools.list_ports
import time
import threading

test_list = []

class SerThread:
    def __init__(self, port="COM2"):
        self.com_obj = serial.Serial()
        self.com_obj.port = port
        self.com_obj.baudrate = 9600
        self.com_obj.timeout = 1
        self.alive = False
        self.waitEnd = None
        fname = time.strftime('%Y%m%d')
        self.rfname = 'r' + fname
        self.sfname = 's' + fname
        self.thread_read = None
        self.thread_send = None
        self.a = 1
    
    def waiting(self):
        if not self.waitEnd is None:
            self.waitEnd.wait()
    
    def start(self):
        self.rfile = open(self.rfname, 'w')
        self.sfile = open(self.sfname, 'w')
        self.com_obj.open()

        if self.com_obj.isOpen():
            self.waitEnd = threading.Event()
            self.alive = True

            self.thread_read = threading.Thread(target=self.Reader)
            self.thread_read.setDaemon(True)

            self.thread_send = threading.Thread(target=self.func1)
            self.thread_send.setDaemon(True)

            self.thread_read.start()
            self.thread_send.start()
            return True
        else:
            return False
    
    def Reader(self):
        while self.alive:
            try:
                n = self.com_obj.inWaiting()
                data = ''
                if n:
                    data = self.com_obj.read(n).decode('gbk')
                    print ('recv'+' '+time.strftime("%Y-%m-%d %X")+' '+data.strip())
                    test_list.append('recv'+' '+time.strftime("%Y-%m-%d %X")+' '+data.strip())
                    print (time.strftime("%Y-%m-%d %X:")+data.strip(),file=self.rfile)
                    if len(data) == 1 and ord(data[len(data) - 1]) == 113:
                        break
            except Exception as ex:
                print(ex)
        
    def func1(self):
        #Do something
        # if len(test_list) > 0:
            # for index in range(len(test_list)):
            #     time.sleep(3)
            #     print("已接受到以下数据(数据总数: %s)：" % len(test_list))
            #     print("已读取到的com口数据：" + test_list[index])
            #     test_list.pop(index)
        while len(test_list) > 0:
            for item in test_list:
                time.sleep(5)
                print("已接受到以下数据(数据总数: %s)：" % len(test_list))
                print("已读取到的com口数据：" + item)
                test_list.remove(item)
        # print('Do something:' + str(len(test_list)))
        # test_list.clear()
        print('当前线程数为{}'.format(threading.activeCount()))
        t=threading.Timer(1,self.func1)
        t.start()

    def Sender(self):
        while self.alive:
            try:
                snddata = input("input data:\n")
                self.com_obj.write(snddata.encode('gbk'))
                print('sent' + time.strftime("%Y-%m-%d %X"))
                print(snddata, file=self.sfile)
            except Exception as ex:
                print(ex)
        
        self.waitEnd.set()
        self.alive = False
    
    def stop(self):
        self.alive = False
        if self.com_obj.isOpen():
            self.com_obj.close()
        self.rfile.close()
        self.sfile.close()


if __name__ == "__main__":
    ser = SerThread('COM2')
    try:
        if ser.start():
            ser.waiting()
            ser.stop()
        else:
            pass
    except Exception as ex:
        print(ex)
    
    if ser.alive:
        ser.stop()

    print('End OK.')
    del ser