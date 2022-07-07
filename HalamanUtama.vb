Imports MySql.Data.MySqlClient
Public Class HalamanUtama
    Sub ReloadData()
        txtNamaMHS.Text = ""
        txtNIM.Text = ""
        cmbJK.Text = ""
        cmbFakultas.Text = ""
        cmbProdi.Text = ""
        txtHP.Text = ""
        Call Tampil()
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Call OpenConn()
        Dim InputData As String = "Insert into tb_input_data values ('" & txtNamaMHS.Text & "','" & txtNIM.Text & "','" & cmbJK.Text & "','" & cmbFakultas.Text & "','" & cmbProdi.Text & "','" & txtHP.Text & "')"
        cmd = New MySqlCommand(InputData, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Input Data Berhasil", MsgBoxStyle.Information, "Informasi")
        Call ReloadData()
    End Sub

    Private Sub HalamanUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ReloadData()
    End Sub
    Sub Tampil()
        Call OpenConn()
        da = New MySqlDataAdapter("select * from tb_input_data", conn)
        ds = New DataSet
        da.Fill(ds, "tb_input_data")
        dgvData.DataSource = ds.Tables("tb_input_data")
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call OpenConn()
        Dim Edit As String = "Update tb_input_data set Nama_Mahasiswa = '" & txtNamaMHS.Text & "',Jenis_kelamin ='" & cmbJK.Text & "',Fakultas ='" & cmbFakultas.Text & "',Prodi ='" & cmbProdi.Text & "',Telepon ='" & txtHP.Text & "'where NIM ='" & txtNIM.Text & "'"
        cmd = New MySqlCommand(Edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Edit Data Berhasil", MsgBoxStyle.Information, "Informasi")
        Call ReloadData()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call OpenConn()
        Dim Hapus As String = "Delete from tb_input_data where NIM = '" & txtNIM.Text & "'"
        cmd = New MySqlCommand(Hapus, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Informasi")
        Call ReloadData()
    End Sub

    Private Sub BtnKembali_Click(sender As Object, e As EventArgs) Handles btnKembali.Click
        Me.Close()
    End Sub
    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            cmd = New MySqlCommand("select * from tb_input_data where NIM='" & txtNIM.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                MsgBox("Data Tidak Ditemukan", MsgBoxStyle.Information, "Informasi")
            Else
                txtNIM.Text = rd.Item("NIM")
                txtNamaMHS.Text = rd.Item("Nama_Mahasiswa")
                cmbFakultas.Text = rd.Item("Fakultas")
                cmbProdi.Text = rd.Item("Prodi")
                cmbJK.Text = rd.Item("Jenis_Kelamin")
                txtHP.Text = rd.Item("Telepon")
            End If
        End If
    End Sub
End Class