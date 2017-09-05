
Imports System.IO.Ports
Imports System.Net.WebRequest
Imports System.Net.WebResponse


Public Class Tabulatron

    Dim WithEvents ardSerial As New IO.Ports.SerialPort

    'This is the URL you want to post to
    Dim formkey As String = "dHdaS1NkdEtHY2Y5YkNjaDVfNGFpSkE6MQ"

    'These are the labels of the 4 buttons that you want on your tabulatron
    Dim b1Text As String = "Reference"
    Dim b2Text As String = "Technical"
    Dim b3Text As String = "Directional"
    Dim b4Text As String = "Referral"

    Dim b1URL As String = "https://docs.google.com/spreadsheet/formResponse?formkey=" + formkey + "&amp;ifq&entry.1.single=" + b1Text
    Dim b2URL As String = "https://docs.google.com/spreadsheet/formResponse?formkey=" + formkey + "&amp;ifq&entry.1.single=" + b2Text
    Dim b3URL As String = "https://docs.google.com/spreadsheet/formResponse?formkey=" + formkey + "&amp;ifq&entry.1.single=" + b3Text
    Dim b4URL As String = "https://docs.google.com/spreadsheet/formResponse?formkey=" + formkey + "&amp;ifq&entry.1.single=" + b4Text

    Dim defaultCOMport As String = "4"

    'You can add username to the url string by using userName.text to it as a parameter
    ' The Function GetUserName() tries to grab it from the environment
    ' if you don't want/need this get rid of the label in the form as well


    Function GetUserName() As String
        If TypeOf My.User.CurrentPrincipal Is
      Security.Principal.WindowsPrincipal Then
            ' The application is using Windows authentication.
            ' The name format is DOMAIN\USERNAME.
            Dim parts() As String = Split(My.User.Name, "\")
            Dim username As String = parts(1)
            Return username
        Else
            ' The application is using custom authentication.
            Return My.User.Name
        End If
    End Function


    Sub b0Pressed()
        Dim fTabReq = b1URL
        Debug.Print(fTabReq)

        Dim tReq As Net.WebRequest = Create(fTabReq)
        Dim tRes As Net.WebResponse = tReq.GetResponse()

        Dim newFont As New Font(button0.Font, FontStyle.Bold)
        Dim oldFont As New Font(button0.Font, FontStyle.Regular)
        lastTimeStamp.Text = DateTime.Now.ToString()
        button0.Font = newFont
        button0.Select()
        button1.Font = oldFont
        button2.Font = oldFont
        button3.Font = oldFont
    End Sub

    Sub b1Pressed()

        Dim fTabReq = b2URL

        Debug.Print(fTabReq)
        Dim tReq As Net.WebRequest = Create(fTabReq)
        Dim tRes As Net.WebResponse = tReq.GetResponse()


        Dim newFont As New Font(button0.Font, FontStyle.Bold)
        Dim oldFont As New Font(button0.Font, FontStyle.Regular)
        lastTimeStamp.Text = DateTime.Now.ToString()
        button1.Font = newFont
        button0.Font = oldFont
        button2.Font = oldFont
        button3.Font = oldFont
    End Sub

    Sub b2Pressed()

        Dim fTabReq = b3URL
        Debug.Print(fTabReq)
        Dim tReq As Net.WebRequest = Create(fTabReq)
        Dim tRes As Net.WebResponse = tReq.GetResponse()

        Dim newFont As New Font(button0.Font, FontStyle.Bold)
        Dim oldFont As New Font(button0.Font, FontStyle.Regular)
        lastTimeStamp.Text = DateTime.Now.ToString()
        button2.Font = newFont
        button0.Font = oldFont
        button1.Font = oldFont
        button3.Font = oldFont
    End Sub

    Sub b3Pressed()
        Dim fTabReq = b4URL

        Debug.Print(fTabReq)
        Dim tReq As Net.WebRequest = Create(fTabReq)
        Dim tRes As Net.WebResponse = tReq.GetResponse()

        Dim newFont As New Font(button0.Font, FontStyle.Bold)
        Dim oldFont As New Font(button0.Font, FontStyle.Regular)
        lastTimeStamp.Text = DateTime.Now.ToString()
        button3.Font = newFont
        button0.Font = oldFont
        button1.Font = oldFont
        button2.Font = oldFont
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Baddest of all the hacks
        System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False
        userName.Text = GetUserName()

        'Try to set config file if not there
        Dim pToUse As String = ""

        Try
            Dim pConfig As System.IO.StreamReader = My.Computer.FileSystem.OpenTextFileReader("COM.txt")
            pToUse = pConfig.ReadLine()
            pConfig.Close()
        Catch
            Dim pConfig As System.IO.StreamWriter = My.Computer.FileSystem.OpenTextFileWriter("COM.txt", False)
            pConfig.WriteLine(defaultCOMport)
            pConfig.Close()
            pToUse = defaultCOMport
        End Try

        'Debug.Print(pToUse)


        Try
            ardSerial.PortName = "COM" + pToUse
            ardSerial.BaudRate = 9600
            ardSerial.RtsEnable = True
            ardSerial.Open()
        Catch
            'ardSerial.Close()
            MsgBox("Could not connect to Tabulatron!")
        End Try



    End Sub

    Private Sub ardSerial_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles ardSerial.DataReceived
        Dim DataFromPort As String = ardSerial.ReadExisting()
        Select Case CInt(DataFromPort)
            Case 0
                b0Pressed()
            Case 1
                b1Pressed()
            Case 2
                b2Pressed()
            Case 3
                b3Pressed()
        End Select

    End Sub

    Private Sub but0_Click(sender As Object, e As EventArgs) Handles but0.Click
        b0Pressed()
    End Sub

    Private Sub but1_Click(sender As Object, e As EventArgs) Handles but1.Click
        b1Pressed()
    End Sub

    Private Sub but2_Click(sender As Object, e As EventArgs) Handles but2.Click
        b2Pressed()
    End Sub

    Private Sub but3_Click(sender As Object, e As EventArgs) Handles but3.Click
        b3Pressed()
    End Sub

    Private Sub button0_Click(sender As Object, e As EventArgs) Handles button0.Click

    End Sub
End Class

