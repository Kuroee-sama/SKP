Imports System.Text
Imports System.Threading
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Public Class FormLogin
    Private ReadOnly connStr As String =
        "Server=127.0.0.1;Uid=root;Pwd=;Database=perpustakaan;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.PasswordChar = "*"c
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrWhiteSpace(TextBox1.Text) OrElse String.IsNullOrWhiteSpace(TextBox2.Text) Then
            MessageBox.Show("Username dan password wajib diisi.")
            Exit Sub
        End If

        ' Simulasi loading
        For i As Integer = 0 To 100 Step 10
            Thread.Sleep(30)
            ProgressBar1.Value = i
            Application.DoEvents()
        Next

        Try
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Const sql As String = "SELECT pass_hash FROM login WHERE username=@u LIMIT 1"
                Using cmd As New MySqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@u", TextBox1.Text.Trim())
                    Dim dbHashObj As Object = cmd.ExecuteScalar()
                    If dbHashObj Is Nothing Then
                        MessageBox.Show("Username tidak ditemukan.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    Dim dbHash As String = Convert.ToString(dbHashObj)
                    Dim inputHash As String = ComputeSha256Hash(TextBox2.Text)

                    If String.Equals(dbHash, inputHash, StringComparison.OrdinalIgnoreCase) Then
                        MessageBox.Show("Login berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Dim frm As New Home()
                        frm.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Username atau password salah!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan: " & ex.Message)
        End Try
    End Sub

    Private Function ComputeSha256Hash(raw As String) As String
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(raw)
        Dim hash As Byte() = SHA256.HashData(bytes) ' versi static
        Dim sb As New StringBuilder()
        For Each b As Byte In hash
            sb.Append(b.ToString("x2"))
        Next
        Return sb.ToString()
    End Function


    Private Function GetConnection() As MySqlConnection
        Return New MySqlConnection(connStr)
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
