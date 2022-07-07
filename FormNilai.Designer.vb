<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNilai
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbTA = New System.Windows.Forms.ComboBox()
        Me.lblTA = New System.Windows.Forms.Label()
        Me.txtNIM = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblNIM = New System.Windows.Forms.Label()
        Me.lblKET = New System.Windows.Forms.Label()
        Me.lblNH = New System.Windows.Forms.Label()
        Me.lblNIANG = New System.Windows.Forms.Label()
        Me.txtNilai_UAS = New System.Windows.Forms.TextBox()
        Me.txtNilai_UTS = New System.Windows.Forms.TextBox()
        Me.txtNilai_Tugas = New System.Windows.Forms.TextBox()
        Me.txtNilai_Absen = New System.Windows.Forms.TextBox()
        Me.txtIDN = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblNUAS = New System.Windows.Forms.Label()
        Me.lblNU = New System.Windows.Forms.Label()
        Me.lblNTU = New System.Windows.Forms.Label()
        Me.lblNA = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblIDNilai = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.dgvNilai = New System.Windows.Forms.DataGridView()
        Me.lblNilai_Angka = New System.Windows.Forms.Label()
        Me.lblNilai_Huruf = New System.Windows.Forms.Label()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvNilai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(347, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT NILAI"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblKeterangan)
        Me.GroupBox1.Controls.Add(Me.lblNilai_Huruf)
        Me.GroupBox1.Controls.Add(Me.lblNilai_Angka)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbTA)
        Me.GroupBox1.Controls.Add(Me.lblTA)
        Me.GroupBox1.Controls.Add(Me.txtNIM)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.lblNIM)
        Me.GroupBox1.Controls.Add(Me.lblKET)
        Me.GroupBox1.Controls.Add(Me.lblNH)
        Me.GroupBox1.Controls.Add(Me.lblNIANG)
        Me.GroupBox1.Controls.Add(Me.txtNilai_UAS)
        Me.GroupBox1.Controls.Add(Me.txtNilai_UTS)
        Me.GroupBox1.Controls.Add(Me.txtNilai_Tugas)
        Me.GroupBox1.Controls.Add(Me.txtNilai_Absen)
        Me.GroupBox1.Controls.Add(Me.txtIDN)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblNUAS)
        Me.GroupBox1.Controls.Add(Me.lblNU)
        Me.GroupBox1.Controls.Add(Me.lblNTU)
        Me.GroupBox1.Controls.Add(Me.lblNA)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblIDNilai)
        Me.GroupBox1.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 303)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Nilai"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(99, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(12, 16)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = ":"
        '
        'cmbTA
        '
        Me.cmbTA.FormattingEnabled = True
        Me.cmbTA.Items.AddRange(New Object() {"2020", "2021", "2022", "2023"})
        Me.cmbTA.Location = New System.Drawing.Point(129, 76)
        Me.cmbTA.Name = "cmbTA"
        Me.cmbTA.Size = New System.Drawing.Size(150, 24)
        Me.cmbTA.TabIndex = 2
        '
        'lblTA
        '
        Me.lblTA.AutoSize = True
        Me.lblTA.Location = New System.Drawing.Point(6, 79)
        Me.lblTA.Name = "lblTA"
        Me.lblTA.Size = New System.Drawing.Size(86, 16)
        Me.lblTA.TabIndex = 24
        Me.lblTA.Text = "Tahun Ajaran"
        '
        'txtNIM
        '
        Me.txtNIM.Location = New System.Drawing.Point(423, 40)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New System.Drawing.Size(150, 23)
        Me.txtNIM.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(396, 168)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(396, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(12, 16)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(396, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(12, 16)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(396, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = ":"
        '
        'lblNIM
        '
        Me.lblNIM.AutoSize = True
        Me.lblNIM.Location = New System.Drawing.Point(317, 43)
        Me.lblNIM.Name = "lblNIM"
        Me.lblNIM.Size = New System.Drawing.Size(33, 16)
        Me.lblNIM.TabIndex = 19
        Me.lblNIM.Text = "NIM"
        '
        'lblKET
        '
        Me.lblKET.AutoSize = True
        Me.lblKET.Location = New System.Drawing.Point(317, 168)
        Me.lblKET.Name = "lblKET"
        Me.lblKET.Size = New System.Drawing.Size(75, 16)
        Me.lblKET.TabIndex = 18
        Me.lblKET.Text = "Keterangan"
        '
        'lblNH
        '
        Me.lblNH.AutoSize = True
        Me.lblNH.Location = New System.Drawing.Point(317, 121)
        Me.lblNH.Name = "lblNH"
        Me.lblNH.Size = New System.Drawing.Size(76, 16)
        Me.lblNH.TabIndex = 17
        Me.lblNH.Text = "Nilai_Huruf"
        '
        'lblNIANG
        '
        Me.lblNIANG.AutoSize = True
        Me.lblNIANG.Location = New System.Drawing.Point(317, 82)
        Me.lblNIANG.Name = "lblNIANG"
        Me.lblNIANG.Size = New System.Drawing.Size(79, 16)
        Me.lblNIANG.TabIndex = 16
        Me.lblNIANG.Text = "Nilai_Angka"
        '
        'txtNilai_UAS
        '
        Me.txtNilai_UAS.Location = New System.Drawing.Point(129, 235)
        Me.txtNilai_UAS.Name = "txtNilai_UAS"
        Me.txtNilai_UAS.Size = New System.Drawing.Size(150, 23)
        Me.txtNilai_UAS.TabIndex = 5
        '
        'txtNilai_UTS
        '
        Me.txtNilai_UTS.Location = New System.Drawing.Point(129, 193)
        Me.txtNilai_UTS.Name = "txtNilai_UTS"
        Me.txtNilai_UTS.Size = New System.Drawing.Size(150, 23)
        Me.txtNilai_UTS.TabIndex = 4
        '
        'txtNilai_Tugas
        '
        Me.txtNilai_Tugas.Location = New System.Drawing.Point(129, 146)
        Me.txtNilai_Tugas.Name = "txtNilai_Tugas"
        Me.txtNilai_Tugas.Size = New System.Drawing.Size(150, 23)
        Me.txtNilai_Tugas.TabIndex = 3
        '
        'txtNilai_Absen
        '
        Me.txtNilai_Absen.Location = New System.Drawing.Point(129, 107)
        Me.txtNilai_Absen.Name = "txtNilai_Absen"
        Me.txtNilai_Absen.Size = New System.Drawing.Size(150, 23)
        Me.txtNilai_Absen.TabIndex = 2
        '
        'txtIDN
        '
        Me.txtIDN.Location = New System.Drawing.Point(129, 40)
        Me.txtIDN.Name = "txtIDN"
        Me.txtIDN.Size = New System.Drawing.Size(150, 23)
        Me.txtIDN.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(99, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(99, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(99, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(99, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(12, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = ":"
        '
        'lblNUAS
        '
        Me.lblNUAS.AutoSize = True
        Me.lblNUAS.Location = New System.Drawing.Point(6, 238)
        Me.lblNUAS.Name = "lblNUAS"
        Me.lblNUAS.Size = New System.Drawing.Size(68, 16)
        Me.lblNUAS.TabIndex = 5
        Me.lblNUAS.Text = "NIlai_UAS"
        '
        'lblNU
        '
        Me.lblNU.AutoSize = True
        Me.lblNU.Location = New System.Drawing.Point(6, 196)
        Me.lblNU.Name = "lblNU"
        Me.lblNU.Size = New System.Drawing.Size(66, 16)
        Me.lblNU.TabIndex = 4
        Me.lblNU.Text = "NIlai_UTS"
        '
        'lblNTU
        '
        Me.lblNTU.AutoSize = True
        Me.lblNTU.Location = New System.Drawing.Point(6, 149)
        Me.lblNTU.Name = "lblNTU"
        Me.lblNTU.Size = New System.Drawing.Size(75, 16)
        Me.lblNTU.TabIndex = 3
        Me.lblNTU.Text = "Nilai_Tugas"
        '
        'lblNA
        '
        Me.lblNA.AutoSize = True
        Me.lblNA.Location = New System.Drawing.Point(6, 110)
        Me.lblNA.Name = "lblNA"
        Me.lblNA.Size = New System.Drawing.Size(78, 16)
        Me.lblNA.TabIndex = 2
        Me.lblNA.Text = "Nilai_Absen"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = ":"
        '
        'lblIDNilai
        '
        Me.lblIDNilai.AutoSize = True
        Me.lblIDNilai.Location = New System.Drawing.Point(6, 43)
        Me.lblIDNilai.Name = "lblIDNilai"
        Me.lblIDNilai.Size = New System.Drawing.Size(56, 16)
        Me.lblIDNilai.TabIndex = 0
        Me.lblIDNilai.Text = "ID_Nilai"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnKembali)
        Me.GroupBox2.Controls.Add(Me.btnHapus)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.btnTambah)
        Me.GroupBox2.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(653, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(96, 259)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proses"
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(5, 208)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(85, 38)
        Me.btnKembali.TabIndex = 13
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(5, 154)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(85, 38)
        Me.btnHapus.TabIndex = 12
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(6, 97)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(85, 38)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(5, 29)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(85, 38)
        Me.btnTambah.TabIndex = 10
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'dgvNilai
        '
        Me.dgvNilai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNilai.Location = New System.Drawing.Point(12, 406)
        Me.dgvNilai.Name = "dgvNilai"
        Me.dgvNilai.Size = New System.Drawing.Size(891, 110)
        Me.dgvNilai.TabIndex = 3
        '
        'lblNilai_Angka
        '
        Me.lblNilai_Angka.Location = New System.Drawing.Point(423, 84)
        Me.lblNilai_Angka.Name = "lblNilai_Angka"
        Me.lblNilai_Angka.Size = New System.Drawing.Size(147, 16)
        Me.lblNilai_Angka.TabIndex = 27
        Me.lblNilai_Angka.Text = "-"
        '
        'lblNilai_Huruf
        '
        Me.lblNilai_Huruf.Location = New System.Drawing.Point(423, 121)
        Me.lblNilai_Huruf.Name = "lblNilai_Huruf"
        Me.lblNilai_Huruf.Size = New System.Drawing.Size(147, 16)
        Me.lblNilai_Huruf.TabIndex = 28
        Me.lblNilai_Huruf.Text = "-"
        '
        'lblKeterangan
        '
        Me.lblKeterangan.Location = New System.Drawing.Point(423, 168)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(147, 16)
        Me.lblKeterangan.TabIndex = 29
        Me.lblKeterangan.Text = "-"
        '
        'FormNilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 542)
        Me.Controls.Add(Me.dgvNilai)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormNilai"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Nilai"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvNilai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblNUAS As Label
    Friend WithEvents lblNU As Label
    Friend WithEvents lblNTU As Label
    Friend WithEvents lblNA As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblIDNilai As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblNIM As Label
    Friend WithEvents lblKET As Label
    Friend WithEvents lblNH As Label
    Friend WithEvents lblNIANG As Label
    Friend WithEvents txtNilai_UAS As TextBox
    Friend WithEvents txtNilai_UTS As TextBox
    Friend WithEvents txtNilai_Tugas As TextBox
    Friend WithEvents txtNilai_Absen As TextBox
    Friend WithEvents txtIDN As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvNilai As DataGridView
    Friend WithEvents cmbTA As ComboBox
    Friend WithEvents lblTA As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblKeterangan As Label
    Friend WithEvents lblNilai_Huruf As Label
    Friend WithEvents lblNilai_Angka As Label
End Class
