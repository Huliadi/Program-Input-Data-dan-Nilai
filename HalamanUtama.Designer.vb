<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HalamanUtama
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtHP = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblHP = New System.Windows.Forms.Label()
        Me.cmbProdi = New System.Windows.Forms.ComboBox()
        Me.cmbFakultas = New System.Windows.Forms.ComboBox()
        Me.cmbJK = New System.Windows.Forms.ComboBox()
        Me.txtNIM = New System.Windows.Forms.TextBox()
        Me.txtNamaMHS = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblProdi = New System.Windows.Forms.Label()
        Me.lblFakultas = New System.Windows.Forms.Label()
        Me.lblJK = New System.Windows.Forms.Label()
        Me.lblNIM = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.dgvData = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtHP)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.lblHP)
        Me.GroupBox1.Controls.Add(Me.cmbProdi)
        Me.GroupBox1.Controls.Add(Me.cmbFakultas)
        Me.GroupBox1.Controls.Add(Me.cmbJK)
        Me.GroupBox1.Controls.Add(Me.txtNIM)
        Me.GroupBox1.Controls.Add(Me.txtNamaMHS)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lblProdi)
        Me.GroupBox1.Controls.Add(Me.lblFakultas)
        Me.GroupBox1.Controls.Add(Me.lblJK)
        Me.GroupBox1.Controls.Add(Me.lblNIM)
        Me.GroupBox1.Controls.Add(Me.lblNama)
        Me.GroupBox1.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(314, 287)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Mahasiswa"
        '
        'txtHP
        '
        Me.txtHP.Location = New System.Drawing.Point(135, 256)
        Me.txtHP.Name = "txtHP"
        Me.txtHP.Size = New System.Drawing.Size(150, 23)
        Me.txtHP.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(110, 259)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(12, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = ":"
        '
        'lblHP
        '
        Me.lblHP.AutoSize = True
        Me.lblHP.Location = New System.Drawing.Point(4, 259)
        Me.lblHP.Name = "lblHP"
        Me.lblHP.Size = New System.Drawing.Size(55, 16)
        Me.lblHP.TabIndex = 20
        Me.lblHP.Text = "Telepon"
        '
        'cmbProdi
        '
        Me.cmbProdi.FormattingEnabled = True
        Me.cmbProdi.Items.AddRange(New Object() {"Sistem Informasi", "Teknik Lingkungan", "PGSD", "PJKR", "Sosiologi", "Sendratasik", "Farmasi", "Ilmu Gizi", "Rekam Medik", "Ekonomi Islam"})
        Me.cmbProdi.Location = New System.Drawing.Point(135, 209)
        Me.cmbProdi.Name = "cmbProdi"
        Me.cmbProdi.Size = New System.Drawing.Size(150, 24)
        Me.cmbProdi.TabIndex = 6
        '
        'cmbFakultas
        '
        Me.cmbFakultas.FormattingEnabled = True
        Me.cmbFakultas.Items.AddRange(New Object() {"Teknik", "Pendidikan", "Kesehatan", "Ekonomi"})
        Me.cmbFakultas.Location = New System.Drawing.Point(135, 164)
        Me.cmbFakultas.Name = "cmbFakultas"
        Me.cmbFakultas.Size = New System.Drawing.Size(150, 24)
        Me.cmbFakultas.TabIndex = 5
        '
        'cmbJK
        '
        Me.cmbJK.FormattingEnabled = True
        Me.cmbJK.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cmbJK.Location = New System.Drawing.Point(135, 118)
        Me.cmbJK.Name = "cmbJK"
        Me.cmbJK.Size = New System.Drawing.Size(150, 24)
        Me.cmbJK.TabIndex = 4
        '
        'txtNIM
        '
        Me.txtNIM.Location = New System.Drawing.Point(135, 77)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New System.Drawing.Size(150, 23)
        Me.txtNIM.TabIndex = 3
        '
        'txtNamaMHS
        '
        Me.txtNamaMHS.Location = New System.Drawing.Point(135, 30)
        Me.txtNamaMHS.Name = "txtNamaMHS"
        Me.txtNamaMHS.Size = New System.Drawing.Size(150, 23)
        Me.txtNamaMHS.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(110, 212)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(12, 16)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(110, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(110, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(110, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(12, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(110, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(12, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = ":"
        '
        'lblProdi
        '
        Me.lblProdi.AutoSize = True
        Me.lblProdi.Location = New System.Drawing.Point(4, 212)
        Me.lblProdi.Name = "lblProdi"
        Me.lblProdi.Size = New System.Drawing.Size(40, 16)
        Me.lblProdi.TabIndex = 5
        Me.lblProdi.Text = "Prodi"
        '
        'lblFakultas
        '
        Me.lblFakultas.AutoSize = True
        Me.lblFakultas.Location = New System.Drawing.Point(2, 167)
        Me.lblFakultas.Name = "lblFakultas"
        Me.lblFakultas.Size = New System.Drawing.Size(55, 16)
        Me.lblFakultas.TabIndex = 4
        Me.lblFakultas.Text = "Fakultas"
        '
        'lblJK
        '
        Me.lblJK.AutoSize = True
        Me.lblJK.Location = New System.Drawing.Point(2, 121)
        Me.lblJK.Name = "lblJK"
        Me.lblJK.Size = New System.Drawing.Size(87, 16)
        Me.lblJK.TabIndex = 3
        Me.lblJK.Text = "Jenis Kelamin"
        '
        'lblNIM
        '
        Me.lblNIM.AutoSize = True
        Me.lblNIM.Location = New System.Drawing.Point(2, 80)
        Me.lblNIM.Name = "lblNIM"
        Me.lblNIM.Size = New System.Drawing.Size(33, 16)
        Me.lblNIM.TabIndex = 2
        Me.lblNIM.Text = "NIM"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(2, 33)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(104, 16)
        Me.lblNama.TabIndex = 1
        Me.lblNama.Text = "Nama Mahasiswa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(451, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "INPUT DATA"
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(14, 34)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(85, 38)
        Me.btnTambah.TabIndex = 10
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(120, 34)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(85, 38)
        Me.btnEdit.TabIndex = 11
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(221, 33)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(85, 38)
        Me.btnHapus.TabIndex = 12
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(331, 34)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(85, 38)
        Me.btnKembali.TabIndex = 13
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'dgvData
        '
        Me.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvData.Location = New System.Drawing.Point(376, 85)
        Me.dgvData.Name = "dgvData"
        Me.dgvData.Size = New System.Drawing.Size(646, 287)
        Me.dgvData.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnTambah)
        Me.GroupBox2.Controls.Add(Me.btnKembali)
        Me.GroupBox2.Controls.Add(Me.btnEdit)
        Me.GroupBox2.Controls.Add(Me.btnHapus)
        Me.GroupBox2.Font = New System.Drawing.Font("Sylfaen", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(587, 378)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(435, 87)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Proses"
        '
        'HalamanUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 497)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "HalamanUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Halaman Utama"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmbFakultas As ComboBox
    Friend WithEvents cmbJK As ComboBox
    Friend WithEvents txtNIM As TextBox
    Friend WithEvents txtNamaMHS As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblProdi As Label
    Friend WithEvents lblFakultas As Label
    Friend WithEvents lblJK As Label
    Friend WithEvents lblNIM As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtHP As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents lblHP As Label
    Friend WithEvents cmbProdi As ComboBox
    Friend WithEvents btnKembali As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnTambah As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
End Class
