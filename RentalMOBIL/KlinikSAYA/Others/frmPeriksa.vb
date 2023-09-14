
Imports MySql.Data.MySqlClient
Imports System.Data
Public Class frmPeriksa
    Public ModeSimpan As String
    Sub Bersih()
        No_Daftar.Text = ""
        Tgl_Periksa.Refresh()
        No_Induk.Text = ""
        cmbNama_Dokter.Text = ""
        No_RM.Text = ""
        cmbNama_pasien.Text = ""
        Umur.Text = ""
        Berat_Badan.Text = ""
        Diagnosa.Text = ""
        Tindakan.Text = ""
        cmbKode_Obat.Text = ""
        Nama_Obat.Text = ""
        Dosis.Text = ""
        Jumlah.Text = ""
        lvresep.Items.Clear()
        btnTambah.Focus()
    End Sub
    Sub Tampilcombopasien()
        Try
            bukaDB()
            Dim mDA As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM pasien", konek)
            Dim dt As New DataTable
            mDA.Fill(dt)
            cmbNama_pasien.DataSource = dt
            cmbNama_pasien.ValueMember = "Nama_pasien"
            cmbNama_pasien.DisplayMember = "description"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Tampilcombodokter()
        Try
            bukaDB()
            Dim mDA As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM dokter", konek)
            Dim dt As New DataTable
            mDA.Fill(dt)
            cmbNama_Dokter.DataSource = dt
            cmbNama_Dokter.ValueMember = "Nama_Dokter"
            cmbNama_Dokter.DisplayMember = "description"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Tampilcombokode_obat()
        Try
            bukaDB()
            Dim mDA As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM obat", konek)
            Dim dt As New DataTable
            mDA.Fill(dt)
            'DataGridView1.DataSource = td
            cmbKode_Obat.DataSource = dt
            cmbKode_Obat.ValueMember = "Kode_obat"
            cmbKode_Obat.DisplayMember = "description"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Caridataperiksa()
        Try
            bukaDB()
            Dim mDA As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM priksa where No. Daftar like '%" & No_Daftar.Text & "'", konek)
            Dim dt As New DataTable
            Dim ds As New DataSet
            mDA.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                Tgl_Periksa.Value = CType(ds.Tables(0).Rows(0).Item("Tgl_Priksa"), MySql.Data.Types.MySqlDateTime)
                No_RM.Text = ds.Tables(0).Rows(0).Item("no_rm")
                Berat_Badan.Text = ds.Tables(0).Rows(0).Item("berat_badan")
                No_Induk.Text = ds.Tables(0).Rows(0).Item("no_induk")
                Diagnosa.Text = ds.Tables(0).Rows(0).Item("diagnosa")
                Tindakan.Text = ds.Tables(0).Rows(0).Item("tindakan")
                lvresep.View = View.Details
                lvresep.FullRowSelect = True
                lvresep.Columns.Add("kode_obat", 125, HorizontalAlignment.Left)
                lvresep.Columns.Add("nama_obat", 280, HorizontalAlignment.Left)
                lvresep.Columns.Add("dosis", 105, HorizontalAlignment.Left)
                lvresep.Columns.Add("jumlah", 100, HorizontalAlignment.Left)
                Dim List(5) As String
                Dim itemlist As ListViewItem
                Dim i As Int16
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    List(0) = Trim(ds.Tables(0).Rows(i).Item("Kode_Obat"))
                    List(1) = Trim(ds.Tables(0).Rows(i).Item("Nama_Obat"))
                    List(2) = Trim(ds.Tables(0).Rows(i).Item("Dosis"))
                    List(3) = Trim(ds.Tables(0).Rows(i).Item("Jumlah"))
                    itemlist = New ListViewItem(List)
                    lvresep.Items.Add(itemlist)
                Next i
            End If
            ModeSimpan = "Modifikasi"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub Hapusperiksa()
        Dim sqlHapus As String = "DELETE FROM priksa WHERE " & "No_Daftar = '" & No_Daftar.Text & "'"
        Try
            With sqlCommand
                .CommandText = sqlHapus
                .Connection = sqlConnection
                .ExecuteNonQuery()
                'TampilPasien()
                'AturTampilan()
                Bersih()
                MsgBox("Data pemeriksaan pasien berhasil di hapus", vbInformation, "Emer Support System")
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            sqlCommand.Dispose()
            TutupDB()
        End Try
    End Sub
    Sub SimpanPeriksa()
        Dim sqlSimpan As String
        Dim i As Int16
        If ModeSimpan = "Tambah" Then
            sqlSimpan = "INSERT INTO periksa(No_Daftar,Tgl_Periksa,No_RM,Berat_Badan,No_Induk,Diagnosa,Tindakan,Kode_Obat,Nama_Obat,Dosis,Jumlah)" & "VALUES('" & No_Daftar.Text & "','" & Format(Tgl_Periksa.Value, "yyyy-MM-dd") & "','" & No_RM.Text & "','" & Berat_Badan.Text & "','" & No_Induk.Text & "','" & Diagnosa.Text & "','" & Tindakan.Text & "')"
        End If
        sqlSimpan = "UPDATE periksa SET Tgl_Daftar = '" & Format(Tgl_Periksa.Value, "yyyy-MM-dd") & "', No_RM = '" & No_RM.Text & "', Berat_Badan = '" & Berat_Badan.Text & "', No_Induk = '" & No_Induk.Text & "', diagnosa = '" & Diagnosa.Text & "', tindakan = '" & Tindakan.Text & "', WHERE No_Daftar = '" & No_Daftar.Text & "'"
        With lvresep
            For i = 0 To lvresep.Items.Count - 1
                Try
                    With sqlCommand
                        .CommandText = sqlSimpan
                        .Connection = sqlConnection
                        .ExecuteNonQuery()
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message)
                    sqlCommand.Dispose()
                    TutupDB()
                End Try
            Next i
            Bersih()
            MsgBox("Data hasil pemeriksaan pasien berhasil di simpan", vbInformation, "MANTAP BOSKU")
        End With
    End Sub

    Private Sub Nama_pasien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNama_pasien.Click

    End Sub

    Private Sub Nama_pasien_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNama_pasien.SelectedIndexChanged
        Try
            bukaDB()
            Dim mDA As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM pasien where nama_pasien like '%" & cmbNama_pasien.Text & "' ORDER BY nama_pasien", konek)
            Dim dt As New DataTable
            Dim ds As New DataSet
            mDA.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                No_RM.Text = ds.Tables(0).Rows(0).Item("No_Rm")
                Dim strtanggal As String = ds.Tables(0).Rows(0).Item("tanggal_lahir").ToString()
                Dim dttanggal As Date = Date.Parse(strtanggal)
                Dim intTahun As Integer = Year(Now()) - Integer.Parse(Year(dttanggal))
                Dim strTahun As String = intTahun.ToString
                Umur.Text = strTahun
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Kode_Obat_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKode_Obat.SelectedValueChanged
        Try
            bukaDB()
            Dim mDA As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM obat where kode_obat like '%" & cmbKode_Obat.Text & "' ORDER BY kode_obat", konek)
            Dim dt As New DataTable
            Dim ds As New DataSet
            mDA.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                Nama_Obat.Text = ds.Tables(0).Rows(0).Item("nama_obat")
                Dosis.Text = ds.Tables(0).Rows(0).Item("dosis")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Nama_pasien_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbNama_pasien.SelectedValueChanged

    End Sub

    Private Sub Nama_Dokter_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbNama_Dokter.SelectedValueChanged
        Try
            bukaDB()
            Dim mDA As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM dokter where Nama_dokter like '%" & cmbNama_Dokter.Text & "' ORDER BY Nama_dokter", konek)
            Dim dt As New DataTable
            Dim ds As New DataSet
            mDA.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                No_Induk.Text = ds.Tables(0).Rows(0).Item("no_induk")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub No_Daftar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles No_Daftar.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Caridataperiksa()
        End If
    End Sub

    Private Sub Jumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Jumlah.KeyPress
        If (e.KeyChar = Chr(13)) Then
            Dim list(5) As String
            Dim itemlist As ListViewItem
            list(0) = Trim(cmbKode_Obat.Text)
            list(1) = Trim(Nama_Obat.Text)
            list(2) = Trim(Dosis.Text)
            list(3) = Trim(Jumlah.Text)
            itemlist = New ListViewItem(list)
            lvresep.Items.Add(itemlist)
            Jumlah.Text = ""
            cmbKode_Obat.Focus()
        End If
    End Sub

    Private Sub btnTambah_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Bersih()
        Tampilcombopasien()
        Tampilcombodokter()
        No_Daftar.Text = "Umum-" & DateTime.Now.ToString("ddyy") & DateTime.Now.ToString("HHmmss")
        Tgl_Periksa.Text = Now
        ModeSimpan = "Baru"
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        If ModeSimpan = "Baru" Then
            SimpanPeriksa()
        Else
            Hapusperiksa()
        End If
    End Sub

    Private Sub btnHapus_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Hapusperiksa()
    End Sub

    Private Sub btnBatal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Bersih()
    End Sub

    Private Sub btnTutup_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        End
    End Sub

    Private Sub btnHapusItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHapusItem.Click
        lvresep.Items.Remove(lvresep.SelectedItems(0))
    End Sub

    Private Sub btnHapusSemua_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnHapusSemua.Click
        lvresep.Items.Clear()
    End Sub

    Private Sub btnResep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnResep.Click
        Tampilcombokode_obat()
        lvresep.View = View.Details
        lvresep.FullRowSelect = True
        lvresep.Columns.Add("kode_obat", 125, HorizontalAlignment.Left)
        lvresep.Columns.Add("nama_obat", 280, HorizontalAlignment.Left)
        lvresep.Columns.Add("dosis", 105, HorizontalAlignment.Left)
        lvresep.Columns.Add("jumlah", 100, HorizontalAlignment.Left)
    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label12.Click

    End Sub
End Class