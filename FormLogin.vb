Public Class FormLogin
    Sub OpenLocked()
        FormUtama.LoginToolStripMenuItem.Enabled = False
        FormUtama.LogoutToolStripMenuItem.Enabled = True
        FormUtama.MasterToolStripMenuItem.Enabled = True
        FormUtama.ProfileToolStripMenuItem.Enabled = True
    End Sub
    Private Sub BtnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        If txbUsername.Text = "" Or txbPassword.Text = "" Then
            MsgBox("Username dan password tidak boleh kosong", vbCritical, "Warning")
            txbUsername.Clear()
            txbPassword.Clear()
            txbUsername.Focus()
        Else
            If txbUsername.Text = "admin" And txbPassword.Text = "admin" Then
                MsgBox("Login Berhasil", MsgBoxStyle.Information, "Informasi")
                Me.Close()
                Call OpenLocked()
            Else
                MsgBox("Username atau Password anda salah", vbCritical, "Warning")
                txbUsername.Clear()
                txbPassword.Clear()
                txbUsername.Focus()
            End If
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txbPassword.PasswordChar = ""
        Else
            txbPassword.PasswordChar = "*"
        End If
    End Sub

    Private Sub BtnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Me.Close()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txbUsername.Text = "admin"
        txbPassword.Text = "admin"
    End Sub
End Class