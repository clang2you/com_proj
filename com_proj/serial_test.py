import serial
import serial.tools.list_ports
import time
import threading
import configparser
import pymysql
import zmq
import os
from datetime import datetime
from colorama import Fore, Back, Style

test_list = []

class MQService:
    def __init__(self):
        self.port = "5556"
        self.context = zmq.Context()
        self.socket = self.context.socket(zmq.PUB)
        self.socket.bind("tcp://*:%s" % self.port)

    def WhenDataComesSendMessage(self):
        topic = "Updated@"
        messagedata = datetime.now().strftime("%Y/%m/%d %H:%M:%S")
        print(Back.GREEN + Fore.BLACK + "%s%s" % (topic, messagedata) + Style.RESET_ALL)
        self.socket.send_string("%s%s" % (topic, messagedata))

class Cfg:
    def __init__(self):
        self.config = configparser.ConfigParser()
        self.ReadConfigINI()
    
    def ReadConfigINI(self):
        self.config.read('configuration.ini')
        self.db_config = self.config["MySQL"]
        self.line_config = self.config["Line"]
        self.db_ip = self.db_config["IP"]
        self.db_user = self.db_config["USER"]
        self.db_passwd = self.db_config["PASSWORD"]
        self.db_name = self.db_config["DB"]
        self.line_name = self.line_config["NAME"]
        self.com_config = self.config["COM"]
        self.data_com = self.com_config["DATA"]
        self.disp1_com = self.com_config["DISPLAY1"]
        self.disp2_com = self.com_config["DISPLAY2"]
        self.disp3_com = self.com_config["DISPLAY3"]
        

class SerThread:
    def __init__(self):
        self.cfg = Cfg()
        self.data_com = serial.Serial()
        self.data_com.port = self.cfg.data_com
        self.data_com.baudrate = 9600
        self.data_com.timeout = 1
        self.alive = False
        self.waitEnd = None
        fname = time.strftime('%Y%m%d')
        self.rfname = 'r' + fname
        self.sfname = 's' + fname
        self.thread_read = None
        self.thread_send = None
        self.a = 1

        self.dbHandler = DbHandler()
        self.mq_service = MQService()
    
    def waiting(self):
        if not self.waitEnd is None:
            self.waitEnd.wait()
    
    def start(self):
        # self.rfile = open(self.rfname, 'w')
        # self.sfile = open(self.sfname, 'w')
        self.data_com.open()

        if self.data_com.isOpen():
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
                time.sleep(0.05)
                n = self.data_com.inWaiting()
                data = ''
                if n:
                    data = self.data_com.read(n).decode('gbk')
                    print ('recv'+' '+time.strftime("%Y-%m-%d %X")+' '+data.strip())
                    test_list.append('Pin:'+data.strip())
                    # print (time.strftime("%Y-%m-%d %X:")+data.strip(),file=self.rfile)
                    if len(data) == 1 and ord(data[len(data) - 1]) == 113:
                        break
            except Exception as ex:
                print(ex)
        
    def func1(self):
        while len(test_list) > 0:
            time.sleep(1)
            for item in test_list:
                # time.sleep(1)
                print("\n" + Back.YELLOW + Fore.BLACK + "===========START===========" + Style.RESET_ALL)
                print(Style.RESET_ALL + "已接收到的数据总条数: " + Fore.RED +  "%s"  % len(test_list))
                print(Style.RESET_ALL + "正在处理数据：" + Fore.MAGENTA + item.replace('Pin:', '针脚=>'))
                self.dbHandler.InsertDataToDb("01")
                # print(Fore.BLUE + "数据库写入完成")
                self.mq_service.WhenDataComesSendMessage()
                test_list.remove(item)
                leftCountStr = Style.RESET_ALL + "剩余"  + Fore.BLUE + "%s"  % len(test_list) +  Style.RESET_ALL + "条数据未处理。"
                finishCountStr = Style.RESET_ALL +  Fore.BLUE + "所有数据已写入数据库。" +  Style.RESET_ALL 
                print(finishCountStr if len(test_list) == 0 else leftCountStr)
                print(Back.LIGHTCYAN_EX + Fore.BLACK  + "===========STOP============" + Style.RESET_ALL + "\n")
        # print('当前线程数为{}'.format(threading.activeCount()))
        t=threading.Timer(1,self.func1)
        t.start()

    def Sender(self):
        while self.alive:
            try:
                snddata = input("input data:\n")
                self.data_com.write(snddata.encode('gbk'))
                print('sent' + time.strftime("%Y-%m-%d %X"))
                print(snddata, file=self.sfile)
            except Exception as ex:
                print(ex)
        
        self.waitEnd.set()
        self.alive = False
    
    def stop(self):
        self.alive = False
        if self.data_com.isOpen():
            self.data_com.close()
        self.rfile.close()
        self.sfile.close()

class DbHandler():
    def __init__(self):
        self.cfg = Cfg()
        self.db_add = self.cfg.db_ip
        self.db_user = self.cfg.db_user
        self.db_password = self.cfg.db_passwd
        self.db_port = 3306
        self.db_name = self.cfg.db_name
        
    def connectToDb(self):
        if self.db_name != None:
            return pymysql.connect(
                host=self.db_add,
                port=self.db_port,
                user=self.db_user,
                password=self.db_password
            )
    
        def runQuerySql(self, sql):
            db_conn = self.connectToDb()
            cursor = db_conn.cursor()
            results = []
            try:
                cursor.execute('use %s' % self.db_name)
                cursor.execute(sql)
                results = cursor.fetchall()
            finally:
                cursor.close()
                db_conn.close()
            return results

    def runNonQuerySql(self, sql):
        db_conn = self.connectToDb()
        cursor = db_conn.cursor()
        try:
            cursor.execute('use %s' % self.db_name)
            cursor.execute(sql)
            db_conn.commit()
        except Exception as ex:
            print(ex)
            db_conn.rollback()
        finally:
            cursor.close()
            db_conn.close()
    
    def InsertDataToDb(self, btn_pos):
        sql = "INSERT INTO com_input(btn_pos, line) values('{}', '{}')".format(btn_pos, self.cfg.line_name)
        self.runNonQuerySql(sql)
    
    def GetTapCountAtRealtime(self):
        sql = "select target from daily_target where dep ='{}' and date = '{}'".format(self.cfg.line_name, datetime.now().strftime('%Y-%m-%d'))
        


if __name__ == "__main__":
    # dbHandler = DbHandler()
    # dbHandler.GetTapCountAtRealtime()
    # ser = SerThread()
    # try:
    #     if ser.start():
    #         ser.waiting()
    #         ser.stop()
    #     else:
    #         pass
    # except Exception as ex:
    #     print(ex)
    
    # if ser.alive:
    #     ser.stop()

    # print('End OK.')
    # del ser
    main = "pycsharp.exe"
    r_v = os.system(main)
    print(r_v)