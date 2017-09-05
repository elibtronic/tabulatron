<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tabulatron
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.button0 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Label()
        Me.button2 = New System.Windows.Forms.Label()
        Me.button3 = New System.Windows.Forms.Label()
        Me.userName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lastTimeStamp = New System.Windows.Forms.Label()
        Me.but0 = New System.Windows.Forms.Button()
        Me.but1 = New System.Windows.Forms.Button()
        Me.but2 = New System.Windows.Forms.Button()
        Me.but3 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'button0
        '
        Me.button0.AutoSize = True
        Me.button0.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button0.Location = New System.Drawing.Point(47, 6)
        Me.button0.Name = "button0"
        Me.button0.Size = New System.Drawing.Size(111, 25)
        Me.button0.TabIndex = 0
        Me.button0.Text = "Reference"
        '
        'button1
        '
        Me.button1.AutoSize = True
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(47, 40)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(105, 25)
        Me.button1.TabIndex = 1
        Me.button1.Text = "Technical"
        '
        'button2
        '
        Me.button2.AutoSize = True
        Me.button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button2.Location = New System.Drawing.Point(47, 71)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(114, 25)
        Me.button2.TabIndex = 2
        Me.button2.Text = "Directional" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'button3
        '
        Me.button3.AutoSize = True
        Me.button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button3.Location = New System.Drawing.Point(47, 102)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(88, 25)
        Me.button3.TabIndex = 3
        Me.button3.Text = "Referral"
        '
        'userName
        '
        Me.userName.AutoSize = True
        Me.userName.Location = New System.Drawing.Point(173, 21)
        Me.userName.Name = "userName"
        Me.userName.Size = New System.Drawing.Size(53, 13)
        Me.userName.TabIndex = 0
        Me.userName.Text = "username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(173, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last Press:"
        '
        'lastTimeStamp
        '
        Me.lastTimeStamp.AutoSize = True
        Me.lastTimeStamp.Location = New System.Drawing.Point(173, 67)
        Me.lastTimeStamp.Name = "lastTimeStamp"
        Me.lastTimeStamp.Size = New System.Drawing.Size(23, 13)
        Me.lastTimeStamp.TabIndex = 6
        Me.lastTimeStamp.Text = "last"
        '
        'but0
        '
        Me.but0.Location = New System.Drawing.Point(13, 9)
        Me.but0.Name = "but0"
        Me.but0.Size = New System.Drawing.Size(28, 25)
        Me.but0.TabIndex = 0
        Me.but0.Text = "✓"
        Me.but0.UseVisualStyleBackColor = True
        '
        'but1
        '
        Me.but1.Location = New System.Drawing.Point(13, 40)
        Me.but1.Name = "but1"
        Me.but1.Size = New System.Drawing.Size(28, 25)
        Me.but1.TabIndex = 1
        Me.but1.Text = "✓"
        Me.but1.UseVisualStyleBackColor = True
        '
        'but2
        '
        Me.but2.Location = New System.Drawing.Point(13, 71)
        Me.but2.Name = "but2"
        Me.but2.Size = New System.Drawing.Size(28, 25)
        Me.but2.TabIndex = 2
        Me.but2.Text = "✓"
        Me.but2.UseVisualStyleBackColor = True
        '
        'but3
        '
        Me.but3.Location = New System.Drawing.Point(13, 102)
        Me.but3.Name = "but3"
        Me.but3.Size = New System.Drawing.Size(28, 25)
        Me.but3.TabIndex = 3
        Me.but3.Text = "✓"
        Me.but3.UseVisualStyleBackColor = True
        '
        'Tabulatron
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(324, 135)
        Me.Controls.Add(Me.but3)
        Me.Controls.Add(Me.but2)
        Me.Controls.Add(Me.but1)
        Me.Controls.Add(Me.but0)
        Me.Controls.Add(Me.lastTimeStamp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.userName)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.button0)
        Me.MaximizeBox = False
        Me.Name = "Tabulatron"
        Me.Text = "Tabulatron v.3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents button0 As Label
    Friend WithEvents button1 As Label
    Friend WithEvents button2 As Label
    Friend WithEvents button3 As Label
    Friend WithEvents userName As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lastTimeStamp As Label
    Friend WithEvents but0 As Button
    Friend WithEvents but1 As Button
    Friend WithEvents but2 As Button
    Friend WithEvents but3 As Button
    Friend WithEvents Timer1 As Timer
End Class
