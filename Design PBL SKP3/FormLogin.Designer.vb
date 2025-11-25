<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        Button1 = New Button()
        ProgressBar1 = New ProgressBar()
        Button2 = New Button()
        CheckBox1 = New CheckBox()
        Label4 = New Label()
        Label5 = New Label()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label1 = New Label()
        LinkLabel1 = New LinkLabel()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(443, 321)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 1
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(229, 251)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(306, 29)
        ProgressBar1.TabIndex = 2
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(343, 321)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 6
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(406, 291)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(129, 24)
        CheckBox1.TabIndex = 7
        CheckBox1.Text = "Remember Me"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(218, 94)
        Label4.Name = "Label4"
        Label4.Size = New Size(336, 20)
        Label4.TabIndex = 9
        Label4.Text = "Lakukan registrasi jika anda belum memiliki akun!"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F)
        Label5.Location = New Point(344, 41)
        Label5.Name = "Label5"
        Label5.Size = New Size(92, 41)
        Label5.TabIndex = 10
        Label5.Text = "Login"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(229, 209)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(306, 27)
        TextBox2.TabIndex = 20
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(229, 186)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 19
        Label2.Text = "Password:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(229, 150)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(306, 27)
        TextBox1.TabIndex = 18
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(229, 127)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 20)
        Label1.TabIndex = 17
        Label1.Text = "NIP:"
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.Location = New Point(229, 325)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(73, 20)
        LinkLabel1.TabIndex = 21
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "Registrasi"
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(LinkLabel1)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(CheckBox1)
        Controls.Add(Button2)
        Controls.Add(ProgressBar1)
        Controls.Add(Button1)
        Name = "FormLogin"
        Text = " "
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button2 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLabel1 As LinkLabel

End Class
