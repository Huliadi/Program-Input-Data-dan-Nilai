Public Class FormUtama
    Sub Locked()
        LoginToolStripMenuItem.Enabled = True
        LogoutToolStripMenuItem.Enabled = False
        MasterToolStripMenuItem.Enabled = False
        ProfileToolStripMenuItem.Enabled = False
    End Sub
    Private Sub FormUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Locked()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        FormLogin.ShowDialog()
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Call Locked()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub HalamanUtamaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MasterToolStripMenuItem.Click
        HalamanUtama.ShowDialog()
    End Sub

    Private Sub FormNilaiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormNilaiToolStripMenuItem.Click
        FormNilai.ShowDialog()
    End Sub
End Class
