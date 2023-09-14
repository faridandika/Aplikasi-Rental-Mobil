<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeriksa
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnTutup = New System.Windows.Forms.Button
        Me.btnBatal = New System.Windows.Forms.Button
        Me.btnHapus = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.btnTambah = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Tindakan = New System.Windows.Forms.TextBox
        Me.Diagnosa = New System.Windows.Forms.TextBox
        Me.cmbNama_pasien = New System.Windows.Forms.ComboBox
        Me.cmbNama_Dokter = New System.Windows.Forms.ComboBox
        Me.Tgl_Periksa = New System.Windows.Forms.DateTimePicker
        Me.Berat_Badan = New System.Windows.Forms.TextBox
        Me.Umur = New System.Windows.Forms.TextBox
        Me.No_RM = New System.Windows.Forms.TextBox
        Me.No_Induk = New System.Windows.Forms.TextBox
        Me.No_Daftar = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lvresep = New System.Windows.Forms.ListView
        Me.btnHapusSemua = New System.Windows.Forms.Button
        Me.btnHapusItem = New System.Windows.Forms.Button
        Me.btnResep = New System.Windows.Forms.Button
        Me.Jumlah = New System.Windows.Forms.TextBox
        Me.Dosis = New System.Windows.Forms.TextBox
        Me.Nama_Obat = New System.Windows.Forms.TextBox
        Me.cmbKode_Obat = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnTutup)
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Tindakan)
        Me.GroupBox1.Controls.Add(Me.Diagnosa)
        Me.GroupBox1.Controls.Add(Me.cmbNama_pasien)
        Me.GroupBox1.Controls.Add(Me.cmbNama_Dokter)
        Me.GroupBox1.Controls.Add(Me.Tgl_Periksa)
        Me.GroupBox1.Controls.Add(Me.Berat_Badan)
        Me.GroupBox1.Controls.Add(Me.Umur)
        Me.GroupBox1.Controls.Add(Me.No_RM)
        Me.GroupBox1.Controls.Add(Me.No_Induk)
        Me.GroupBox1.Controls.Add(Me.No_Daftar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(93, 144)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1160, 452)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "[ Riwayat Periksa ]"
        '
        'btnTutup
        '
        Me.btnTutup.Location = New System.Drawing.Point(978, 306)
        Me.btnTutup.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTutup.Name = "btnTutup"
        Me.btnTutup.Size = New System.Drawing.Size(159, 49)
        Me.btnTutup.TabIndex = 25
        Me.btnTutup.Text = "Tutup"
        Me.btnTutup.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Location = New System.Drawing.Point(978, 249)
        Me.btnBatal.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(159, 46)
        Me.btnBatal.TabIndex = 24
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(978, 169)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(159, 46)
        Me.btnHapus.TabIndex = 23
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(978, 117)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(159, 43)
        Me.btnSimpan.TabIndex = 22
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(978, 32)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(159, 46)
        Me.btnTambah.TabIndex = 21
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(554, 211)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 20)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Tindakan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(554, 32)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(77, 20)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "Diagnosa"
        '
        'Tindakan
        '
        Me.Tindakan.Location = New System.Drawing.Point(558, 243)
        Me.Tindakan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tindakan.Multiline = True
        Me.Tindakan.Name = "Tindakan"
        Me.Tindakan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Tindakan.Size = New System.Drawing.Size(356, 110)
        Me.Tindakan.TabIndex = 18
        '
        'Diagnosa
        '
        Me.Diagnosa.Location = New System.Drawing.Point(558, 65)
        Me.Diagnosa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Diagnosa.Multiline = True
        Me.Diagnosa.Name = "Diagnosa"
        Me.Diagnosa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Diagnosa.Size = New System.Drawing.Size(356, 113)
        Me.Diagnosa.TabIndex = 17
        '
        'cmbNama_pasien
        '
        Me.cmbNama_pasien.FormattingEnabled = True
        Me.cmbNama_pasien.Location = New System.Drawing.Point(160, 235)
        Me.cmbNama_pasien.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbNama_pasien.Name = "cmbNama_pasien"
        Me.cmbNama_pasien.Size = New System.Drawing.Size(346, 28)
        Me.cmbNama_pasien.TabIndex = 16
        '
        'cmbNama_Dokter
        '
        Me.cmbNama_Dokter.FormattingEnabled = True
        Me.cmbNama_Dokter.Location = New System.Drawing.Point(159, 157)
        Me.cmbNama_Dokter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbNama_Dokter.Name = "cmbNama_Dokter"
        Me.cmbNama_Dokter.Size = New System.Drawing.Size(346, 28)
        Me.cmbNama_Dokter.TabIndex = 15
        '
        'Tgl_Periksa
        '
        Me.Tgl_Periksa.Location = New System.Drawing.Point(159, 74)
        Me.Tgl_Periksa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Tgl_Periksa.Name = "Tgl_Periksa"
        Me.Tgl_Periksa.Size = New System.Drawing.Size(348, 26)
        Me.Tgl_Periksa.TabIndex = 14
        '
        'Berat_Badan
        '
        Me.Berat_Badan.Location = New System.Drawing.Point(159, 320)
        Me.Berat_Badan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Berat_Badan.Name = "Berat_Badan"
        Me.Berat_Badan.Size = New System.Drawing.Size(348, 26)
        Me.Berat_Badan.TabIndex = 13
        '
        'Umur
        '
        Me.Umur.Location = New System.Drawing.Point(159, 278)
        Me.Umur.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Umur.Name = "Umur"
        Me.Umur.Size = New System.Drawing.Size(241, 26)
        Me.Umur.TabIndex = 12
        '
        'No_RM
        '
        Me.No_RM.Location = New System.Drawing.Point(159, 197)
        Me.No_RM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.No_RM.Name = "No_RM"
        Me.No_RM.Size = New System.Drawing.Size(348, 26)
        Me.No_RM.TabIndex = 11
        '
        'No_Induk
        '
        Me.No_Induk.Location = New System.Drawing.Point(159, 117)
        Me.No_Induk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.No_Induk.Name = "No_Induk"
        Me.No_Induk.Size = New System.Drawing.Size(348, 26)
        Me.No_Induk.TabIndex = 10
        '
        'No_Daftar
        '
        Me.No_Daftar.Location = New System.Drawing.Point(159, 32)
        Me.No_Daftar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.No_Daftar.Name = "No_Daftar"
        Me.No_Daftar.Size = New System.Drawing.Size(348, 26)
        Me.No_Daftar.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(27, 325)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Berat Badan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(450, 283)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tahun"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 283)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Umur"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 243)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nama Pasien"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 202)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No.Rekam Medik"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 160)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Dokter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 122)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No. Induk Dokter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal Daftar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Daftar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lvresep)
        Me.GroupBox2.Controls.Add(Me.btnHapusSemua)
        Me.GroupBox2.Controls.Add(Me.btnHapusItem)
        Me.GroupBox2.Controls.Add(Me.btnResep)
        Me.GroupBox2.Controls.Add(Me.Jumlah)
        Me.GroupBox2.Controls.Add(Me.Dosis)
        Me.GroupBox2.Controls.Add(Me.Nama_Obat)
        Me.GroupBox2.Controls.Add(Me.cmbKode_Obat)
        Me.GroupBox2.Location = New System.Drawing.Point(93, 606)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(1158, 255)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "[ Resep Dokter ]"
        '
        'lvresep
        '
        Me.lvresep.Location = New System.Drawing.Point(28, 78)
        Me.lvresep.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lvresep.Name = "lvresep"
        Me.lvresep.Size = New System.Drawing.Size(895, 149)
        Me.lvresep.TabIndex = 33
        Me.lvresep.UseCompatibleStateImageBehavior = False
        Me.lvresep.View = System.Windows.Forms.View.List
        '
        'btnHapusSemua
        '
        Me.btnHapusSemua.Location = New System.Drawing.Point(974, 182)
        Me.btnHapusSemua.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHapusSemua.Name = "btnHapusSemua"
        Me.btnHapusSemua.Size = New System.Drawing.Size(159, 49)
        Me.btnHapusSemua.TabIndex = 32
        Me.btnHapusSemua.Text = "Hapus Semua"
        Me.btnHapusSemua.UseVisualStyleBackColor = True
        '
        'btnHapusItem
        '
        Me.btnHapusItem.Location = New System.Drawing.Point(974, 108)
        Me.btnHapusItem.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnHapusItem.Name = "btnHapusItem"
        Me.btnHapusItem.Size = New System.Drawing.Size(159, 49)
        Me.btnHapusItem.TabIndex = 31
        Me.btnHapusItem.Text = "Hapus Item"
        Me.btnHapusItem.UseVisualStyleBackColor = True
        '
        'btnResep
        '
        Me.btnResep.Location = New System.Drawing.Point(974, 22)
        Me.btnResep.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnResep.Name = "btnResep"
        Me.btnResep.Size = New System.Drawing.Size(159, 49)
        Me.btnResep.TabIndex = 26
        Me.btnResep.Text = "Resep"
        Me.btnResep.UseVisualStyleBackColor = True
        '
        'Jumlah
        '
        Me.Jumlah.Location = New System.Drawing.Point(768, 22)
        Me.Jumlah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Size = New System.Drawing.Size(157, 26)
        Me.Jumlah.TabIndex = 29
        '
        'Dosis
        '
        Me.Dosis.Location = New System.Drawing.Point(586, 22)
        Me.Dosis.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dosis.Name = "Dosis"
        Me.Dosis.Size = New System.Drawing.Size(157, 26)
        Me.Dosis.TabIndex = 28
        '
        'Nama_Obat
        '
        Me.Nama_Obat.Location = New System.Drawing.Point(255, 22)
        Me.Nama_Obat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Nama_Obat.Name = "Nama_Obat"
        Me.Nama_Obat.Size = New System.Drawing.Size(296, 26)
        Me.Nama_Obat.TabIndex = 26
        '
        'cmbKode_Obat
        '
        Me.cmbKode_Obat.FormattingEnabled = True
        Me.cmbKode_Obat.Location = New System.Drawing.Point(27, 20)
        Me.cmbKode_Obat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmbKode_Obat.Name = "cmbKode_Obat"
        Me.cmbKode_Obat.Size = New System.Drawing.Size(196, 28)
        Me.cmbKode_Obat.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Crimson
        Me.Label12.Location = New System.Drawing.Point(545, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(304, 34)
        Me.Label12.TabIndex = 98
        Me.Label12.Text = "private hospital of farid"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Crimson
        Me.Label13.Location = New System.Drawing.Point(586, 57)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(199, 34)
        Me.Label13.TabIndex = 97
        Me.Label13.Text = "KLINIK SAYA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmPeriksa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1355, 928)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPeriksa"
        Me.Text = "Pemeriksaan"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnTutup As System.Windows.Forms.Button
    Friend WithEvents btnBatal As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Tindakan As System.Windows.Forms.TextBox
    Friend WithEvents Diagnosa As System.Windows.Forms.TextBox
    Friend WithEvents cmbNama_pasien As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNama_Dokter As System.Windows.Forms.ComboBox
    Friend WithEvents Tgl_Periksa As System.Windows.Forms.DateTimePicker
    Friend WithEvents Berat_Badan As System.Windows.Forms.TextBox
    Friend WithEvents Umur As System.Windows.Forms.TextBox
    Friend WithEvents No_RM As System.Windows.Forms.TextBox
    Friend WithEvents No_Induk As System.Windows.Forms.TextBox
    Friend WithEvents No_Daftar As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lvresep As System.Windows.Forms.ListView
    Friend WithEvents btnHapusSemua As System.Windows.Forms.Button
    Friend WithEvents btnHapusItem As System.Windows.Forms.Button
    Friend WithEvents btnResep As System.Windows.Forms.Button
    Friend WithEvents Jumlah As System.Windows.Forms.TextBox
    Friend WithEvents Dosis As System.Windows.Forms.TextBox
    Friend WithEvents Nama_Obat As System.Windows.Forms.TextBox
    Friend WithEvents cmbKode_Obat As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
