Public Class Home
    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' biar MDI aktif
        Me.IsMdiContainer = True
        Me.WindowState = FormWindowState.Maximized
    End Sub

    ' === buka form Dashboard ===
    Private Sub DashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DashboardToolStripMenuItem.Click
        Dim f As DashboardKPS = Nothing
        For Each child As Form In MdiChildren
            If TypeOf child Is DashboardKPS Then
                f = DirectCast(child, DashboardKPS)
                Exit For
            End If
        Next

        If f Is Nothing Then
            f = New DashboardKPS With {
                .MdiParent = Me,
                .WindowState = FormWindowState.Maximized
            }
            f.Show()
        Else
            f.Activate()
        End If
    End Sub

    ' === buka form modul pegawai ===
    Private Sub ModulPegawaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModulPegawaiToolStripMenuItem.Click
        Dim f As ModulPegawai = Nothing
        For Each child As Form In MdiChildren
            If TypeOf child Is ModulPegawai Then
                f = DirectCast(child, ModulPegawai)
                Exit For
            End If
        Next

        If f Is Nothing Then
            f = New ModulPegawai With {
                .MdiParent = Me,
                .WindowState = FormWindowState.Maximized
            }
            f.Show()
        Else
            f.Activate()
        End If
    End Sub

    ' === buka form modul skp ===
    Private Sub ModulSKPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModulSKPToolStripMenuItem.Click
        Dim f As ModulSKP = Nothing
        For Each child As Form In MdiChildren
            If TypeOf child Is ModulSKP Then
                f = DirectCast(child, ModulSKP)
                Exit For
            End If
        Next

        If f Is Nothing Then
            f = New ModulSKP With {
                .MdiParent = Me,
                .WindowState = FormWindowState.Maximized
            }
            f.Show()
        Else
            f.Activate()
        End If
    End Sub

    ' === buka form profile ===
    Private Sub ProfileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProfileToolStripMenuItem.Click
        Dim f As Profile = Nothing
        For Each child As Form In MdiChildren
            If TypeOf child Is Profile Then
                f = DirectCast(child, Profile)
                Exit For
            End If
        Next

        If f Is Nothing Then
            f = New Profile With {
                .MdiParent = Me,
                .WindowState = FormWindowState.Maximized
            }
            f.Show()
        Else
            f.Activate()
        End If
    End Sub

    ' === logout kembali ke form login ===
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim confirm = MessageBox.Show("Yakin mau logout?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If confirm = DialogResult.Yes Then
            Dim loginForm As New FormLogin()
            loginForm.Show()
            Me.Close()
        End If
    End Sub
End Class