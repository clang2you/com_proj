import serial
import serial.tools.list_ports
import socket
import time
import threading
import configparser
import pymysql
import zmq
import os
import traceback
from datetime import datetime
from colorama import Fore, Back, Style

tcp_socket_client = socket.socket()
test_list = []
# lastRecord_1 = ""
# lastRecord_2 = ""
# lastRecord_3 = ""
# lastRecord_4 = ""
pin_list  = ('08', '07', '06', '05', '04', '03', '02', '01')
pin_list_2 = ('16', '15', '14', '13', '12', '11','10','09')
pin_list_3 = ('24', '23', '22', '21', '20', '19','18', '17')
pin_list_4 = ('32', '31', '30', '29', '28', '27', '26', '25')

class MQService:
    def __init__(self):
        self.port = "5556"
        self.context = zmq.Context()
        self.socket = self.context.socket(zmq.PUB)
        self.socket.bind("tcp://*:%s" % self.port)

    def WhenDataComesSendMessage(self):
        topic = "Updated@"
        messagedata = datetime.now().strftime("%Y/%m/%d %H:%M:%S")
        print(Back.GREEN + Fore.BLACK + "%s%s" %
              (topic, messagedata) + Style.RESET_ALL)
        self.socket.send_string("%s%s" % (topic, messagedata))


class Cfg:
    def __init__(self):
        self.config = configparser.ConfigParser()
        self.ReadConfigINI()

    def ReadConfigINI(self):
        self.config.read('configuration.ini', encoding="utf-8")
        self.db_config = self.config["MySQL"]
        self.line_config = self.config["Line"]
        self.db_ip = self.db_config["IP"]
        self.db_user = self.db_config["USER"]
        self.db_passwd = self.db_config["PASSWORD"]
        self.db_name = self.db_config["DB"]
        self.line_name = self.line_config["NAME"]
        self.com_config = self.config["COM"]
        self.data_com = self.com_config["DATA"]
        self.paraType = self.config["TYPE"]
        self.tcp = self.config["TCP"]
        self.tcp_ip = self.tcp["IP"]
        self.tcp_port = self.tcp["PORT"]


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
        global tcp_socket_client
        tcp_ip = self.cfg.tcp_ip
        tcp_port = self.cfg.tcp_port
        print((tcp_ip, int(tcp_port)))
        try:
            isOnline = False
            while not isOnline:
                pingResult  = os.system("ping " + self.cfg.tcp_ip)
                if pingResult == 0:
                    isOnline = True
            tcp_socket_client.setsockopt(socket.SOL_SOCKET, socket.SO_KEEPALIVE, 1)
            tcp_socket_client.settimeout(5.0)
            tcp_socket_client.connect((tcp_ip, int(tcp_port)))
            tcp_socket_client.settimeout(None)
        # self.data_com.open()

            # if True:
            self.waitEnd = threading.Event()
            self.alive = True

            self.thread_read = threading.Thread(target=self.Reader)
            self.thread_read.setDaemon(True)

            self.thread_insert_to_db = threading.Thread(target=self.func1)
            self.thread_insert_to_db.setDaemon(True)

            self.thread_sender = threading.Thread(target=self.Sender)
            self.thread_sender.setDaemon(True)

            self.thread_read.start()
            self.thread_insert_to_db.start()
        # self.thread_sender.start()

            return True
        
        except:
            print("Error")
            
        
        # else:
        #     return False

    def GetPinNo(self,filterData):
        # if filterData == 1 or filterData == 2:
        #     data = pinList[filterData - 1]
        #     return data
        # elif filterData <= 10:
        #     index = filterData // 2
        #     index = index if index == 2 else index -1
        #     data = pinList[index]
        #     return data
        # else:
        #     if filterData == 20:
        #         data = pinList[5]
        #         return data
        #     elif filterData == 40:
        #         data = pinList[6]
        #         return data
        #     else:
        #         data = pinList[7]
        #         return data
        # print(isFirst)
        signalList = []
        filterData = int("0x" + filterData, 16)
        filterData = '{:08b}'.format(filterData)
        # print(filterData)
        for index in range(8):
            # print(index)
        
            if filterData[index] !='0':
                signalList.append(index)
        return signalList

    
    # def InitialLastRecord(self, strData):
    #     strData = int("0x" + strData, 16)
    #     return '{:08b}'.format(strData)

    def GetResultList(self, data , pinList):
        result = []
        dataIndex = self.GetPinNo(data)
        print(dataIndex)
        for index in dataIndex:
            result.append(pinList[index])
        return result
    
    def cut(self, obj, sec):
        return [obj[i:i+sec] for i in range(0,len(obj),sec)]

    def Reader(self):
        global tcp_socket_client, test_list
        # isTimeout = False
        while True:
            try:
                time.sleep(0.5)
                # lastRecord_1 =""
                # lastRecord_2 =""
                # lastRecord_3 =""
                # lastRecord_4 = ""
                print(Fore.GREEN + "开始接收 TCP 数据" + Style.RESET_ALL)
                tcp_socket_client.settimeout(1.0)
                data = tcp_socket_client.recv(1024).hex()
                tcp_socket_client.settimeout(None)
                print(data)
                if len(data) > 0:
                    print("缓冲区大小：" + str(len(data)))
                    # resultList = []
                    data = str(data)
                    # print(data)
                    dataList = []
                    print("数据大小" + str(len(data)))
                    if len(data) > 32:
                        dataList.extend(self.cut(data, 32))
                    else:
                        dataList.append(data)
                    print(dataList)
                    lastRecord = []
                    for item in dataList:
                        data = item[8:22]
                        print(data)
                        if data[0:2] != "00":
                            # ifFirst = False
                            # if len(lastRecord_1) == 0:
                                # lastRecord_1 = self.InitialLastRecord(data[0:2])
                            #     ifFirst = True
                            print(data[0:2])
                            # if len(lastRecord_1) == 0:
                            #     lastRecord_1 = self.InitialLastRecord(data[0:2])
                            # lastRecord_1, dataIndex = self.GetPinNo(lastRecord_1, int(data[0:2]))
                            # for index in dataIndex:
                            #     result.append(pin_list[index])
                            result = self.GetResultList(data[0:2], pin_list)
                            result = self.deleteDuplicatedElementFromList3(result)
                            for item in result:
                                if item in lastRecord:
                                    result.remove(item)
                            lastRecord = result
                            # print(result)
                            test_list.extend(result)
                        elif data[4:6] != "00":
                            # print(data[4:6])
                            # ifFirst = False
                            # if len(lastRecord_2) == 0:
                            #     lastRecord_2 = self.InitialLastRecord(data[4:6])
                            #     ifFirst = True
                            print(data[0:2])
                            # if len(lastRecord_2) == 0:
                            #     lastRecord_2 = self.InitialLastRecord(data[4:6])
                            # lastRecord_2, dataIndex = self.GetPinNo(lastRecord_2, int(data[4:6]))
                            # for index in dataIndex:
                            #     result.append(pin_list_2[index])
                            result = self.GetResultList(data[4:6], pin_list_2)
                            result = self.deleteDuplicatedElementFromList3(result)
                            for item in result:
                                if item in lastRecord:
                                    result.remove(item)
                            lastRecord = result
                            test_list.extend(result)
                        elif data[8:10] != "00":
                            # print(data[8:10])
                            # ifFirst = False
                            # if len(lastRecord_3) == 0:
                            #     lastRecord_3 = self.InitialLastRecord(data[8:10])
                            #     ifFirst = True
                            # if len(lastRecord_3) == 0:
                            #     lastRecord_3 = self.InitialLastRecord(data[8:10])
                            # lastRecord_3, dataIndex = self.GetPinNo(lastRecord_3, int(data[8:10]))
                            # for index in dataIndex:
                            #     result.append(pin_list_3[index])
                            result = self.GetResultList(data[8:10], pin_list_3)
                            result = self.deleteDuplicatedElementFromList3(result)
                            for item in result:
                                if item in lastRecord:
                                    result.remove(item)
                            lastRecord = result
                            test_list.extend(result)
                        else:
                            # print(data[12:])
                            # ifFirst = False
                            # if len(lastRecord_2) == 0:
                            #     lastRecord_4 = self.InitialLastRecord(data[12:])
                            #     ifFirst = True
                            # if len(lastRecord_4) == 0:
                            #     lastRecord_4 = self.InitialLastRecord(data[12:])
                            # lastRecord_4, dataIndex = self.GetPinNo(lastRecord_4, int(data[12:]))
                            # for index in dataIndex:
                            #     result.append(pin_list_4[index])
                            result = self.GetResultList(data[12:], pin_list_4)
                            result = self.deleteDuplicatedElementFromList3(result)
                            for item in result:
                                if item in lastRecord:
                                    result.remove(item)
                            lastRecord = result
                            test_list.extend(result)
                        print('recv'+' '+time.strftime("%Y-%m-%d %X")+' '+ data)
                        print(test_list)
                        # test_list.extend(result)
                        # print (time.strftime("%Y-%m-%d %X:")+data.strip(),file=self.rfile)
                        if len(data) == 1 and ord(data[len(data) - 1]) == 113:
                            break
                # else:
            except socket.timeout:
                notConnected = True
                while notConnected:
                    try:
                        print(Fore.RED + "读取超时" + Style.RESET_ALL)  
                        msg = b'test'
                        tcp_socket_client.settimeout(1)
                        tcp_socket_client.send(msg)
                        tcp_socket_client.recv(1024)
                        notConnected = False
                    except socket.timeout:
                        # traceback.print_exc()
                        notConnected = False          
            except ConnectionResetError:
                traceback.print_exc()
                time.sleep(3)
                notConnected = False
                while not notConnected:
                    tcp_socket_client, notConnected = self.TryReconnectTcpServer(notConnected)
                    
            # except socket.error as ex:
                # if type(ex) == type(socket.error) or type(ex) == type(socket.TimeoutError):
                #     tcp_socket_client.connect((self.cfg.tcp_ip, int(self.cfg.tcp_port)))
                # if type(ex) == type(socket.ConnectionResetError):
                #     print("OK")
                # notConnected = True
                # while notConnected:
                #     # try:
                #     try:
                #         notConnected = self.ReconnectTCPServer()
                #     except socket.error:
                #         notConnected = self.ReconnectTCPServer()
                    # except:
                        # isConnected = False
    
    def TryReconnectTcpServer(self, isConnected):
        tcp_socket_client = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        try :
            tcp_socket_client.connect((self.cfg.tcp_ip,int(self.cfg.tcp_port)))
            isConnected = True
        except :
            isConnected = False
        return tcp_socket_client, isConnected
        # notConnected = True
        # while notConnected:
        # tcp_socket_client.close()
        
            # notConnected = False

    def ReconnectTCPServer(self):
        print(Fore.RED + "网络中断，尝试重新连接" + Style.RESET_ALL)    
        tcp_socket_client.connect((self.cfg.tcp_ip,int(self.cfg.tcp_port)))
        return True

    def deleteDuplicatedElementFromList3(self,listA):
        return sorted(set(listA), key = listA.index)

    def func1(self):
        while len(test_list) > 0:
            time.sleep(1)
            for item in test_list:
                # time.sleep(1)
                print("\n" + Back.YELLOW + Fore.BLACK +
                      "===========START===========" + Style.RESET_ALL)
                print(Style.RESET_ALL + "已接收到的数据总条数: " +
                      Fore.RED + "%s" % len(test_list))
                print(Style.RESET_ALL + "正在处理数据：" +
                      Fore.MAGENTA + item.replace('Pin:', '针脚=>'))
                self.dbHandler.InsertDataToDb(item)
                print(item)
                # print(Fore.BLUE + "数据库写入完成")
                self.mq_service.WhenDataComesSendMessage()
                test_list.remove(item)
                leftCountStr = Style.RESET_ALL + "剩余" + Fore.BLUE + \
                    "%s" % len(test_list) + Style.RESET_ALL + "条数据未处理。"
                finishCountStr = Style.RESET_ALL + Fore.BLUE + "所有数据已写入数据库。" + Style.RESET_ALL
                print(finishCountStr if len(test_list) == 0 else leftCountStr)
                print(Back.LIGHTCYAN_EX + Fore.BLACK +
                      "===========STOP============" + Style.RESET_ALL + "\n")
        # print('当前线程数为{}'.format(threading.activeCount()))
        t = threading.Timer(0.5, self.func1)
        t.start()

    def Sender(self):
        while self.alive:
            try:
                if len(test_list) == 0:
                    runCmd = "ledcontrol.exe -r {} {} {} {} {} {} {} {} {}".format(
                        *self.dbHandler.GetRealtimDatasFromDb())
                    print(runCmd)
                    os.system(runCmd)
            except Exception as ex:
                print(ex)

        t = threading.Timer(1, self.Sender)
        t.start()

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
        self.paraType = self.cfg.paraType

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

    def InsertDataToDb(self, btn_pos):
        sql = "INSERT INTO com_input(btn_pos, line) values('{}', '{}')".format(
            btn_pos, self.cfg.line_name)
        self.runNonQuerySql(sql)

    def GetTargetAtRealtime(self):
        sql = "select target from daily_target where dep ='{}' and date = '{}'".format(
            self.cfg.line_name, datetime.now().strftime('%Y-%m-%d'))
        self.target = 0
        for row in self.runQuerySql(sql):
            self.target = int(row[0])
        return self.target

    def GetTapAtRealtime(self):
        self.GetTargetAtRealtime()
        if self.target == 0:
            return 0
        sql = "select amStartTime, amStopTime, pmStartTime, pmStopTime, amWorkHours, totalWorkHours from workingtimeperiod where line = '{}'".format(
            self.cfg.line_name)
        for row in self.runQuerySql(sql):
            self.amStartTime = datetime.strptime(
                datetime.now().strftime("%y-%m-%d ") + row[0], "%y-%m-%d %H:%M")
            self.amStopTime = datetime.strptime(
                datetime.now().strftime("%y-%m-%d ") + row[1], "%y-%m-%d %H:%M")
            self.pmStartTime = datetime.strptime(
                datetime.now().strftime("%y-%m-%d ") + row[2], "%y-%m-%d %H:%M")
            self.pmStopTime = datetime.strptime(
                datetime.now().strftime("%y-%m-%d ") + row[3], "%y-%m-%d %H:%M")
            self.amWorkHours = row[4]
            self.totalWorkHours = row[5]
        # print(self.amStopTime.strftime("%y-%m-%d %H:%M"))
        if datetime.now() > self.pmStopTime:
            self.currentHours = self.totalWorkHours
        elif datetime.now() > self.pmStartTime:
            self.currentHours = round(
                (datetime.now() - self.pmStartTime).seconds / 3600, 2) + self.amWorkHours
        elif datetime.now() < self.amStopTime and datetime.now() > self.amStartTime:
            self.currentHours = round(
                (datetime.now() - self.amStartTime).seconds / 3600, 2)
        elif datetime.now() > self.amStopTime and datetime.now() < self.pmStartTime:
            self.currentHours = self.amWorkHours
        tapOutput = int(
            self.target * (self.currentHours / self.totalWorkHours))
        return tapOutput

    def GetRealtimDatasFromDb(self):
        paraList = []
        sql = """select sum(if(type = '{0}', qty, 0)) as {0},
        sum(if(type = '{1}', qty, 0)) as {1},
        sum(if(type = '{2}', qty, 0)) as {2},
        sum(if(type = '{3}', qty, 0)) as {3},
        sum(if(type = '{4}', qty, 0)) as {4},
        sum(if(type = '{5}', qty, 0)) as {5},
        sum(if(defType is not NULL, qty, 0)) as {6}
        from realtime_input WHERE TO_DAYS(NOW()) = TO_DAYS(time)""".format(self.paraType["1"],
                                                                           self.paraType["2"], self.paraType["3"], self.paraType["4"], self.paraType["5"], self.paraType["6"], self.paraType["7"])
        for row in self.runQuerySql(sql):
            for item in row:
                paraList.append(str(item) if item != None else str(0))
        self.target = self.GetTargetAtRealtime()
        self.currentTap = self.GetTapAtRealtime()
        paraList.append(self.target)
        paraList.append(self.currentTap)
        return paraList

    def CallMySQLProcedure(self, procedureName):
        db_conn = self.connectToDb()
        cursor = db_conn.cursor()
        data = ""
        try:
            cursor.execute('use %s' % self.db_name)
            cursor.callproc(procedureName)
            db_conn.commit()
            data = cursor.fetchall()
        except Exception as ex:
            print(ex)
            db_conn.rollback()
        finally:
            cursor.close()
            db_conn.close()
            return data


if __name__ == "__main__":
    # os.system("ledcontrol.exe -i")
    dbHandler = DbHandler()
    dbHandler.GetTapAtRealtime()
    dbHandler.CallMySQLProcedure("move_data_to_history")
    ser = SerThread()
    
    try:
        if ser.start():
            ser.waiting()
            ser.stop()
        else:
            pass
    except Exception as ex:
        traceback.print_exc()
        print(ex)

    if ser.alive:
        ser.stop()

    print('End OK.')
    del ser
