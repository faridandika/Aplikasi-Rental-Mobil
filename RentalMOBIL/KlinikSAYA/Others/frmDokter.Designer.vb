<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDokter
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CmdTutup = New System.Windows.Forms.Button
        Me.CmdHapus = New System.Windows.Forms.Button
        Me.CmdSimpan = New System.Windows.Forms.Button
        Me.CmdBatal = New System.Windows.Forms.Button
        Me.CmdBaru = New System.Windows.Forms.Button
        Me.txtAlamat = New System.Windows.Forms.TextBox
        Me.No_Telp = New System.Windows.Forms.TextBox
        Me.Spesialis = New System.Windows.Forms.TextBox
        Me.Nama_Dokter = New System.Windows.Forms.TextBox
        Me.No_Induk = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(32, 379)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(987, 264)
        Me.DataGridView1.TabIndex = 31
        '
        'CmdTutup
        '
        Me.CmdTutup.Location = New System.Drawing.Point(745, 312)
        Me.CmdTutup.Name = "CmdTutup"
        Me.CmdTutup.Size = New System.Drawing.Size(176, 48)
        Me.CmdTutup.TabIndex = 30
        Me.CmdTutup.Text = "Tutup"
        Me.CmdTutup.UseVisualStyleBackColor = True
        '
        'CmdHapus
        '
        Me.CmdHapus.Location = New System.Drawing.Point(745, 200)
        Me.CmdHapus.Name = "CmdHapus"
        Me.CmdHapus.Size = New System.Drawing.Size(176, 48)
        Me.CmdHapus.TabIndex = 29
        Me.CmdHapus.Text = "Hapus"
        Me.CmdHapus.UseVisualStyleBackColor = True
        '
        'CmdSimpan
        '
        Me.CmdSimpan.Location = New System.Drawing.Point(745, 113)
        Me.CmdSimpan.Name = "CmdSimpan"
        Me.CmdSimpan.Size = New System.Drawing.Size(176, 48)
        Me.CmdSimpan.TabIndex = 28
        Me.CmdSimpan.Text = "Simpan"
        Me.CmdSimpan.UseVisualStyleBackColor = True
        '
        'CmdBatal
        '
        Me.CmdBatal.Location = New System.Drawing.Point(504, 314)
        Me.CmdBatal.Name = "CmdBatal"
        Me.CmdBatal.Size = New System.Drawing.Size(178, 48)
        Me.CmdBatal.TabIndex = 27
        Me.CmdBatal.Text = "Batal"
        Me.CmdBatal.UseVisualStyleBackColor = True
        '
        'CmdBaru
        '
        Me.CmdBaru.Location = New System.Drawing.Point(320, 312)
        Me.CmdBaru.Name = "CmdBaru"
        Me.CmdBaru.Size = New System.Drawing.Size(178, 48)
        Me.CmdBaru.TabIndex = 26
        Me.CmdBaru.Text = "Baru"
        Me.CmdBaru.UseVisualStyleBackColor = True
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(389, 254)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(293, 26)
        Me.txtAlamat.TabIndex = 25
        '
        'No_Telp
        '
        Me.No_Telp.Location = New System.Drawing.Point(389, 222)
        Me.No_Telp.Name = "No_Telp"
        Me.No_Telp.Size = New System.Drawing.Size(293, 26)
        Me.No_Telp.TabIndex = 24
        '
        'Spesialis
        '
        Me.Spesialis.Location = New System.Drawing.Point(389, 187)
        Me.Spesialis.Name = "Spesialis"
        Me.Spesialis.Size = New System.Drawing.Size(293, 26)
        Me.Spesialis.TabIndex = 23
        '
        'Nama_Dokter
        '
        Me.Nama_Dokter.Location = New System.Drawing.Point(389, 152)
        Me.Nama_Dokter.Name = "Nama_Dokter"
        Me.Nama_Dokter.Size = New System.Drawing.Size(293, 26)
        Me.Nama_Dokter.TabIndex = 22
        '
        'No_Induk
        '
        Me.No_Induk.Location = New System.Drawing.Point(389, 113)
        Me.No_Induk.Name = "No_Induk"
        Me.No_Induk.Size = New System.Drawing.Size(293, 26)
        Me.No_Induk.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(240, 254)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(240, 222)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "No. Telpon / HP"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(240, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 20)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Spesialis"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(240, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Nama Dokter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(240, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 20)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "No. Induk"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Crimson
        Me.Label8.Location = New System.Drawing.Point(379, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(304, 34)
        Me.Label8.TabIndex = 98
        Me.Label8.Text = "private hospital of farid"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Crimson
        Me.Label7.Location = New System.Drawing.Point(420, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(199, 34)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "KLINIK SAYA" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmDokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1057, 672)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CmdTutup)
        Me.Controls.Add(Me.CmdHapus)
        Me.Controls.Add(Me.CmdSimpan)
        Me.Controls.Add(Me.CmdBatal)
        Me.Controls.Add(Me.CmdBaru)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.No_Telp)
        Me.Controls.Add(Me.Spesialis)
        Me.Controls.Add(Me.Nama_Dokter)
        Me.Controls.Add(Me.No_Induk)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmDokter"
        Me.Text = "frmDokter"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CmdTutup As System.Windows.Forms.Button
    Friend WithEvents CmdHapus As System.Windows.Forms.Button
    Friend WithEvents CmdSimpan As System.Windows.Forms.Button
    Friend WithEvents CmdBatal As System.Windows.Forms.Button
    Friend WithEvents CmdBaru As System.Windows.Forms.Button
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents No_Telp As System.Windows.Forms.TextBox
    Friend WithEvents Spesialis As System.Windows.Forms.TextBox
    Friend WithEvents Nama_Dokter As System.Windows.Forms.TextBox
    Friend WithEvents No_Induk As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
