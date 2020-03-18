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
        self.data_com.open()

        if self.data_com.isOpen():
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
            self.thread_sender.start()

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
                    print('recv'+' '+time.strftime("%Y-%m-%d %X")+' '+data.strip())
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
                print("\n" + Back.YELLOW + Fore.BLACK +
                      "===========START===========" + Style.RESET_ALL)
                print(Style.RESET_ALL + "已接收到的数据总条数: " +
                      Fore.RED + "%s" % len(test_list))
                print(Style.RESET_ALL + "正在处理数据：" +
                      Fore.MAGENTA + item.replace('Pin:', '针脚=>'))
                self.dbHandler.InsertDataToDb("01")
                # print(Fore.BLUE + "数据库写入完成")
                main = "pycsharp.exe"
                r_v = os.system(main)
                print(r_v)
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
    os.system("ledcontrol.exe -i")
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
        print(ex)

    if ser.alive:
        ser.stop()

    print('End OK.')
    del ser
