<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Home
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
        MenuStrip1 = New MenuStrip()
        DashboardToolStripMenuItem = New ToolStripMenuItem()
        ModulPegawaiToolStripMenuItem = New ToolStripMenuItem()
        ModulSKPToolStripMenuItem = New ToolStripMenuItem()
        ProfileToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {DashboardToolStripMenuItem, ModulPegawaiToolStripMenuItem, ModulSKPToolStripMenuItem, ProfileToolStripMenuItem, LogoutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1078, 28)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' DashboardToolStripMenuItem
        ' 
        DashboardToolStripMenuItem.Name = "DashboardToolStripMenuItem"
        DashboardToolStripMenuItem.Size = New Size(96, 24)
        DashboardToolStripMenuItem.Text = "Dashboard"
        ' 
        ' ModulPegawaiToolStripMenuItem
        ' 
        ModulPegawaiToolStripMenuItem.Name = "ModulPegawaiToolStripMenuItem"
        ModulPegawaiToolStripMenuItem.Size = New Size(125, 24)
        ModulPegawaiToolStripMenuItem.Text = "Modul Pegawai"
        ' 
        ' ModulSKPToolStripMenuItem
        ' 
        ModulSKPToolStripMenuItem.Name = "ModulSKPToolStripMenuItem"
        ModulSKPToolStripMenuItem.Size = New Size(95, 24)
        ModulSKPToolStripMenuItem.Text = "Modul SKP"
        ' 
        ' ProfileToolStripMenuItem
        ' 
        ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        ProfileToolStripMenuItem.Size = New Size(66, 24)
        ProfileToolStripMenuItem.Text = "Profile"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(70, 24)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' Home
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1078, 590)
        Controls.Add(MenuStrip1)
        IsMdiContainer = True
        MainMenuStrip = MenuStrip1
        Name = "Home"
        Text = "Home"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DashboardToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModulPegawaiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModulSKPToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
End Class
