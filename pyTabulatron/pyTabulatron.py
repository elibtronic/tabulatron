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
import serial,time,datetime,os,urllib2,sys
import serial.tools.list_ports
import re

uname = ""
#Set to current user
try:
        uname = os.environ["USERNAME"]
except:
        uname = "USERNAME"

#Try to find Arduino automatically
try:
        for p in serial.tools.list_ports.comports():
                if re.search('Arduino Uno',str(p[1])):
                        portString = str(p[0])
        #print portString       
        ser = serial.Serial(portString,9600,timeout=0)
except:
        print "Could not open port!"
        sys.exit()


def checkForSignal():
        global isChecking
        line = ser.read()
        if str(line) == "0":
                sig0()
        elif str(line) == "1":
                sig1()
        elif str(line) == "2":
                sig2()
        elif str(line) == "3":
                sig3()
        root.after(pollInterval,checkForSignal)

def sig0():
        b1.config(bg="green")
        b2.config(bg="grey")
        b3.config(bg="grey")
        b4.config(bg="grey")
        lastTab.config(text="Last: " + datetime.datetime.now().strftime('%H:%M:%S'))
        #print b1URL+uname
        req = urllib2.Request(b1URL+uname)
        res = urllib2.urlopen(req)

def sig1():
        b1.config(bg="grey")
        b2.config(bg="green")
        b3.config(bg="grey")
        b4.config(bg="grey")
        lastTab.config(text="Last: " + datetime.datetime.now().strftime('%H:%M:%S'))
        #print b2URL+uname
        req = urllib2.Request(b2URL+uname)
        res = urllib2.urlopen(req)

def sig2():
        b1.config(bg="grey")
        b2.config(bg="grey")
        b3.config(bg="green")
        b4.config(bg="grey")
        lastTab.config(text="Last: " + datetime.datetime.now().strftime('%H:%M:%S'))
        #print b3URL+uname
        req = urllib2.Request(b3URL+uname)
        res = urllib2.urlopen(req)
        
def sig3():
        b1.config(bg="grey")
        b2.config(bg="grey")
        b3.config(bg="grey")
        b4.config(bg="green")
        lastTab.config(text="Last: " + datetime.datetime.now().strftime('%H:%M:%S'))
        #print b4URL+uname
        req = urllib2.Request(b4URL+uname)
        res = urllib2.urlopen(req)

#Juicy bits
root = Tk()
root.title(tabTitle)
root.resizable(width=FALSE,height=FALSE)
root.geometry("500x225")
root.iconbitmap("pencil.ico")
b0 = Label(root, width=40)
b1 = Label(root, text=b1Text,bg="grey",font=("Arial",16),width=40,pady=5)
b2 = Label(root, text=b2Text,bg="grey",font=("Arial",16),width=40,pady=5)
b3 = Label(root, text=b3Text,bg="grey",font=("Arial",16),width=40,pady=5)
b4 = Label(root, text=b4Text,bg="grey",font=("Arial",16),width=40,pady=5)

userLabel = Label(root,text=uname,font=("Arial",8),width=90,anchor="e")
lastTab = Label(root,text="Last:",font=("Arial",8),width=90,anchor="e")

b0.pack()
b1.pack()
b2.pack()
b3.pack()
b4.pack()
userLabel.pack()
lastTab.pack()

root.after(pollInterval,checkForSignal)
root.mainloop()
