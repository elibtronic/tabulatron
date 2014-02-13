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
import serial

# on linux probably something like serial.Serial("ttyACM0")
# on windows some thing like serial.Serial("COM4",9600,timeout=1)
#ser = serial.Serial("COM4",9600,timeout=1)

def checkForSignal():
        pass
        #line = ser.read()
        #ser.flush()
        #print type(line)


root = Tk()
root.title("Tabulatron")
root.geometry("500x500")
mFrame = Frame(root, width=150, height=150)
mFrame.pack()
root.after(pollInterval,checkForSignal)
root.mainloop()
