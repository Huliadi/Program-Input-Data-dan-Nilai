Imports MySql.Data.MySqlClient
Public Class FormNilai
    Sub ReloadData()
        txtIDN.Text = ""
        txtNilai_Absen.Text = ""
        txtNilai_Tugas.Text = ""
        txtNilai_UTS.Text = ""
        txtNilai_UAS.Text = ""
        txtNIM.Text = ""
        Call Tampil()
    End Sub
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Call OpenConn()
        Dim InputData As String = "Insert into tb_nilai values ('" & txtIDN.Text & "','" & txtNIM.Text & "','" & cmbTA.Text & "','" & txtNilai_Absen.Text & "','" & txtNilai_Tugas.Text & "','" & txtNilai_UTS.Text & "','" & txtNilai_UAS.Text & "')"
        cmd = New MySqlCommand(InputData, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Input Data Berhasil", MsgBoxStyle.Information, "Informasi")
        Call ReloadData()
        Call Tambah()
    End Sub
    Private Sub FormNilai_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ReloadData()
    End Sub
    Sub Tampil()
        Call OpenConn()
        da = New MySqlDataAdapter("select * from tb_nilai", conn)
        ds = New DataSet
        da.Fill(ds, "tb_nilai")
        dgvNilai.DataSource = ds.Tables("tb_nilai")
    End Sub
    Sub Tambah()
        lblNilai_Angka.Text = Val(txtNilai_Absen.Text) * 0.2 + Val(txtNilai_Tugas.Text) * 0.2 + Val(txtNilai_UTS.Text) * 0.3 + Val(txtNilai_UAS.Text) * 0.3
        If lblNilai_Angka.Text >= 90 Then
            lblNilai_Huruf.Text = "A"
            lblKeterangan.Text = "Sangat Memuaskan"
        ElseIf lblNilai_Angka.Text >= 80 Then
            lblNilai_Huruf.Text = "B"
            lblKeterangan.Text = "Baik"
        ElseIf lblNilai_Angka.Text >= 65 Then
            lblNilai_Huruf.Text = "C"
            lblKeterangan.Text = "Cukup"
        Else
            lblNilai_Huruf.Text = "E"
            lblKeterangan.Text = "Tidak Lulus"
        End If
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Call OpenConn()
        Dim Edit As String = "Update tb_nilai set NIM = '" & txtNIM.Text & "',Tahun_Ajaran ='" & cmbTA.Text & "',Nilai_Absen ='" & txtNilai_Absen.Text & "',Nilai_Tugas ='" & txtNilai_Tugas.Text & "',Nilai_UTS ='" & txtNilai_UTS.Text & "',Nilai_UAS ='" & txtNilai_UAS.Text & "'where ID_Nilai ='" & txtIDN.Text & "'"
        cmd = New MySqlCommand(Edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Edit Data Berhasil", MsgBoxStyle.Information, "Informasi")
        Call ReloadData()
    End Sub

    Private Sub BtnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        Call OpenConn()
        Dim Hapus As String = "Delete from tb_nilai where ID_Nilai = '" & txtIDN.Text & "'"
        cmd = New MySqlCommand(Hapus, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil Dihapus", MsgBoxStyle.Information, "Informasi")
        Call ReloadData()
    End Sub
    Private Sub txtIDN_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDN.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            cmd = New MySqlCommand("select * from tb_nilai where ID_Nilai='" & txtIDN.Text & "'", conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If Not rd.HasRows Then
                MsgBox("Data Tidak Ditemukan", MsgBoxStyle.Information, "Informasi")
            Else
                txtIDN.Text = rd.Item("ID_Nilai")
                cmbTA.Text = rd.Item("Tahun_Ajaran")
                txtNilai_Absen.Text = rd.Item("Nilai_Absen")
                txtNilai_Tugas.Text = rd.Item("Nilai_Tugas")
                txtNilai_UTS.Text = rd.Item("Nilai_UTS")
                txtNilai_UAS.Text = rd.Item("Nilai_UAS")
                txtNIM.Text = rd.Item("NIM")
            End If
        End If
    End Sub
End Class