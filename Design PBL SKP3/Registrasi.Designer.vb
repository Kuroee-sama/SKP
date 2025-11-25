<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registrasi
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label5 = New Label()
        Button2 = New Button()
        TextBox2 = New TextBox()
        Label2 = New Label()
        TextBox1 = New TextBox()
        ProgressBar1 = New ProgressBar()
        Button1 = New Button()
        Label1 = New Label()
        Button3 = New Button()
        TextBox3 = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 18F)
        Label5.Location = New Point(336, 24)
        Label5.Name = "Label5"
        Label5.Size = New Size(144, 41)
        Label5.TabIndex = 21
        Label5.Text = "Registrasi"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(244, 337)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 17
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(244, 197)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(306, 27)
        TextBox2.TabIndex = 16
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(244, 174)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 15
        Label2.Text = "Password:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(244, 138)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(306, 27)
        TextBox1.TabIndex = 14
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(244, 302)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(306, 29)
        ProgressBar1.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(456, 337)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 12
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(244, 115)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 20)
        Label1.TabIndex = 11
        Label1.Text = "NIP:"
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(356, 337)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 22
        Button3.Text = "Back"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(244, 259)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(306, 27)
        TextBox3.TabIndex = 24
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(244, 236)
        Label3.Name = "Label3"
        Label3.Size = New Size(148, 20)
        Label3.TabIndex = 23
        Label3.Text = "Konfirmasi Password:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(231, 78)
        Label4.Name = "Label4"
        Label4.Size = New Size(336, 20)
        Label4.TabIndex = 25
        Label4.Text = "Lakukan registrasi jika anda belum memiliki akun!"
        ' 
        ' Registrasi
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(TextBox3)
        Controls.Add(Label3)
        Controls.Add(Button3)
        Controls.Add(Label5)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(ProgressBar1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Registrasi"
        Text = "Registrasi"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
