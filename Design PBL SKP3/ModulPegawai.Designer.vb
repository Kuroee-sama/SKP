<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModulPegawai
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
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        TextBox1 = New TextBox()
        Button1 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        Button2 = New Button()
        Button3 = New Button()
        Label4 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(776, 309)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 341)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 20)
        Label1.TabIndex = 1
        Label1.Text = "Nama:"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(81, 338)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(241, 27)
        TextBox1.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(694, 492)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 3
        Button1.Text = "Insert"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 376)
        Label2.Name = "Label2"
        Label2.Size = New Size(35, 20)
        Label2.TabIndex = 4
        Label2.Text = "NIP:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 423)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 20)
        Label3.TabIndex = 5
        Label3.Text = "Jabatan:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(81, 377)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(241, 27)
        TextBox2.TabIndex = 6
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(81, 420)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(241, 27)
        TextBox3.TabIndex = 7
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(558, 492)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 8
        Button2.Text = "Update"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(425, 492)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 9
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(256, 142)
        Label4.Name = "Label4"
        Label4.Size = New Size(289, 20)
        Label4.TabIndex = 10
        Label4.Text = "menampilkan data pegawai dari database"
        ' 
        ' ModulPegawai
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 533)
        Controls.Add(Label4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "ModulPegawai"
        Text = "ModulPegawai"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
End Class
