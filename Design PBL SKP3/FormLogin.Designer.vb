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
        Label1 = New Label()
        Button1 = New Button()
        ProgressBar1 = New ProgressBar()
        TextBox1 = New TextBox()
        Label2 = New Label()
        TextBox2 = New TextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(228, 144)
        Label1.Name = "Label1"
        Label1.Size = New Size(35, 20)
        Label1.TabIndex = 0
        Label1.Text = "NIP:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(440, 242)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 1
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Location = New Point(228, 207)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(306, 29)
        ProgressBar1.TabIndex = 2
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(307, 141)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(227, 27)
        TextBox1.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(228, 177)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 20)
        Label2.TabIndex = 4
        Label2.Text = "Password:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(307, 174)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(227, 27)
        TextBox2.TabIndex = 5
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(340, 242)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 6
        Button2.Text = "Exit"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(TextBox2)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(ProgressBar1)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "FormLogin"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button

End Class
