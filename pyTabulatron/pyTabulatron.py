#
#  Tabulatron Tkinter style
#
#
#
#
#
#
from settings import *
from Tkinter import *
import serial,time

# on linux probably something like serial.Serial("ttyACM0")
# on windows some thing like serial.Serial("COM5",9600,timeout=1)
ser = serial.Serial("COM5",9600,timeout=1)

def checkForSignal():
        while 1:
                line = ser.read()
                ser.flush()
                if str(line) == "0":
                        sig_0()
                elif str(line) == "1":
                        sig_1()
                elif str(line) == "2":
                        sig_2()
                elif str(line) == "3":
                        sig_3()
                time.sleep(1)
                        
def sig_0():
        b1.config(text="red")
        print "0"

def sig_1():
        print "1"

def sig_2():
        print "2"

def sig_3():
        print "3"

root = Tk()
root.title("Tabulatron")
root.geometry("500x500")

b1 = Label(root, text=b1Text)
b2 = Label(root, text=b2Text)
b3 = Label(root, text=b3Text)
b4 = Label(root, text=b4Text)
b1.pack()
b2.pack()
b3.pack()
b4.pack()

root.after(pollInterval,checkForSignal)
root.mainloop()
