<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPembayaran
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
        Me.txtTglPeriksa = New System.Windows.Forms.DateTimePicker
        Me.Cmdhapus = New System.Windows.Forms.Button
        Me.btnSimpan = New System.Windows.Forms.Button
        Me.btnTambah = New System.Windows.Forms.Button
        Me.txtTotalBayar = New System.Windows.Forms.TextBox
        Me.txtBiayaTindakan = New System.Windows.Forms.TextBox
        Me.txtBiayaDiagnosa = New System.Windows.Forms.TextBox
        Me.txtBiayaObat = New System.Windows.Forms.TextBox
        Me.txtBeratBadan = New System.Windows.Forms.TextBox
        Me.txtUmur = New System.Windows.Forms.TextBox
        Me.txtNamaPasien = New System.Windows.Forms.TextBox
        Me.txtNoRM = New System.Windows.Forms.TextBox
        Me.txtNamaDokter = New System.Windows.Forms.TextBox
        Me.txtNoInduk = New System.Windows.Forms.TextBox
        Me.txtNoDaftar = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTglPeriksa)
        Me.GroupBox1.Controls.Add(Me.Cmdhapus)
        Me.GroupBox1.Controls.Add(Me.btnSimpan)
        Me.GroupBox1.Controls.Add(Me.btnTambah)
        Me.GroupBox1.Controls.Add(Me.txtTotalBayar)
        Me.GroupBox1.Controls.Add(Me.txtBiayaTindakan)
        Me.GroupBox1.Controls.Add(Me.txtBiayaDiagnosa)
        Me.GroupBox1.Controls.Add(Me.txtBiayaObat)
        Me.GroupBox1.Controls.Add(Me.txtBeratBadan)
        Me.GroupBox1.Controls.Add(Me.txtUmur)
        Me.GroupBox1.Controls.Add(Me.txtNamaPasien)
        Me.GroupBox1.Controls.Add(Me.txtNoRM)
        Me.GroupBox1.Controls.Add(Me.txtNamaDokter)
        Me.GroupBox1.Controls.Add(Me.txtNoInduk)
        Me.GroupBox1.Controls.Add(Me.txtNoDaftar)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(114, 14)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(1257, 383)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "[Riwayat Periksa]"
        '
        'txtTglPeriksa
        '
        Me.txtTglPeriksa.Location = New System.Drawing.Point(154, 86)
        Me.txtTglPeriksa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTglPeriksa.Name = "txtTglPeriksa"
        Me.txtTglPeriksa.Size = New System.Drawing.Size(301, 26)
        Me.txtTglPeriksa.TabIndex = 34
        '
        'Cmdhapus
        '
        Me.Cmdhapus.Location = New System.Drawing.Point(1064, 288)
        Me.Cmdhapus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Cmdhapus.Name = "Cmdhapus"
        Me.Cmdhapus.Size = New System.Drawing.Size(171, 65)
        Me.Cmdhapus.TabIndex = 31
        Me.Cmdhapus.Text = "hapus"
        Me.Cmdhapus.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(1064, 169)
        Me.btnSimpan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(171, 65)
        Me.btnSimpan.TabIndex = 30
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(1064, 57)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(171, 65)
        Me.btnTambah.TabIndex = 29
        Me.btnTambah.Text = "Cari Data Pasien"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'txtTotalBayar
        '
        Me.txtTotalBayar.Location = New System.Drawing.Point(718, 302)
        Me.txtTotalBayar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtTotalBayar.Name = "txtTotalBayar"
        Me.txtTotalBayar.Size = New System.Drawing.Size(283, 26)
        Me.txtTotalBayar.TabIndex = 27
        '
        'txtBiayaTindakan
        '
        Me.txtBiayaTindakan.Location = New System.Drawing.Point(718, 228)
        Me.txtBiayaTindakan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBiayaTindakan.Name = "txtBiayaTindakan"
        Me.txtBiayaTindakan.Size = New System.Drawing.Size(283, 26)
        Me.txtBiayaTindakan.TabIndex = 26
        '
        'txtBiayaDiagnosa
        '
        Me.txtBiayaDiagnosa.Location = New System.Drawing.Point(718, 151)
        Me.txtBiayaDiagnosa.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBiayaDiagnosa.Name = "txtBiayaDiagnosa"
        Me.txtBiayaDiagnosa.Size = New System.Drawing.Size(283, 26)
        Me.txtBiayaDiagnosa.TabIndex = 25
        '
        'txtBiayaObat
        '
        Me.txtBiayaObat.Location = New System.Drawing.Point(718, 80)
        Me.txtBiayaObat.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBiayaObat.Name = "txtBiayaObat"
        Me.txtBiayaObat.Size = New System.Drawing.Size(283, 26)
        Me.txtBiayaObat.TabIndex = 24
        '
        'txtBeratBadan
        '
        Me.txtBeratBadan.Location = New System.Drawing.Point(140, 322)
        Me.txtBeratBadan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtBeratBadan.Name = "txtBeratBadan"
        Me.txtBeratBadan.Size = New System.Drawing.Size(316, 26)
        Me.txtBeratBadan.TabIndex = 23
        '
        'txtUmur
        '
        Me.txtUmur.Location = New System.Drawing.Point(99, 283)
        Me.txtUmur.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.Size = New System.Drawing.Size(283, 26)
        Me.txtUmur.TabIndex = 22
        '
        'txtNamaPasien
        '
        Me.txtNamaPasien.Location = New System.Drawing.Point(146, 243)
        Me.txtNamaPasien.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNamaPasien.Name = "txtNamaPasien"
        Me.txtNamaPasien.Size = New System.Drawing.Size(310, 26)
        Me.txtNamaPasien.TabIndex = 21
        '
        'txtNoRM
        '
        Me.txtNoRM.Location = New System.Drawing.Point(170, 203)
        Me.txtNoRM.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNoRM.Name = "txtNoRM"
        Me.txtNoRM.Size = New System.Drawing.Size(286, 26)
        Me.txtNoRM.TabIndex = 20
        '
        'txtNamaDokter
        '
        Me.txtNamaDokter.Location = New System.Drawing.Point(147, 163)
        Me.txtNamaDokter.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNamaDokter.Name = "txtNamaDokter"
        Me.txtNamaDokter.Size = New System.Drawing.Size(308, 26)
        Me.txtNamaDokter.TabIndex = 19
        '
        'txtNoInduk
        '
        Me.txtNoInduk.Location = New System.Drawing.Point(170, 123)
        Me.txtNoInduk.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNoInduk.Name = "txtNoInduk"
        Me.txtNoInduk.Size = New System.Drawing.Size(286, 26)
        Me.txtNoInduk.TabIndex = 18
        '
        'txtNoDaftar
        '
        Me.txtNoDaftar.Location = New System.Drawing.Point(124, 46)
        Me.txtNoDaftar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtNoDaftar.Name = "txtNoDaftar"
        Me.txtNoDaftar.Size = New System.Drawing.Size(331, 26)
        Me.txtNoDaftar.TabIndex = 17
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(658, 306)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 20)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "Rp."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(549, 266)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(143, 20)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Total Yang diBayar"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(660, 232)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 20)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Rp."
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(549, 192)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(117, 20)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "Biaya Tindakan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(660, 155)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 20)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Rp."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(549, 122)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 20)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Biaya Diagnosa"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(660, 85)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 20)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Rp."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(549, 51)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(128, 20)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Total Bayar Obat"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(32, 326)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 20)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Berat Badan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(399, 283)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 20)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Tahun"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(33, 288)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Umur"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 248)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nama Pasien"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 208)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "No.Rekam Medis"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(33, 168)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Dokter"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 128)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "No.Induk Dokter"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 91)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal Bayar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(32, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No.Dokter"
        '
        'frmPembayaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1485, 914)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmPembayaran"
        Me.Text = "frmPembayaran"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTglPeriksa As System.Windows.Forms.DateTimePicker
    Friend WithEvents Cmdhapus As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents txtTotalBayar As System.Windows.Forms.TextBox
    Friend WithEvents txtBiayaTindakan As System.Windows.Forms.TextBox
    Friend WithEvents txtBiayaDiagnosa As System.Windows.Forms.TextBox
    Friend WithEvents txtBiayaObat As System.Windows.Forms.TextBox
    Friend WithEvents txtBeratBadan As System.Windows.Forms.TextBox
    Friend WithEvents txtUmur As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaPasien As System.Windows.Forms.TextBox
    Friend WithEvents txtNoRM As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaDokter As System.Windows.Forms.TextBox
    Friend WithEvents txtNoInduk As System.Windows.Forms.TextBox
    Friend WithEvents txtNoDaftar As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
