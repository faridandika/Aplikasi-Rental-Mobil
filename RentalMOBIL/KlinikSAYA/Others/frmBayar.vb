Imports MySql.Data.MySqlClient
Imports System.Data
Public Class FrmBayar
    '----------------MENDEFINISIKAN VARIABEL PUBLIC----------'
    Public modeSimpan As String
    Sub Bersih()
        txtNoDaftar.Text = ""
        txtTglPeriksa.Refresh()
        txtNoInduk.Text = ""
        txtNamaDokter.Text = ""
        txtNoRM.Text = ""
        txtNamaPasien.Text = ""
        txtUmur.Text = ""
        txtBeratBadan.Text = ""
        txtBiayaObat.Text = ""
        txtBiayaDiagnosa.Text = ""
        txtBiayaTindakan.Text = ""
        txtTotalBayar.Text = ""
        lvResep.Items.Clear()

    End Sub

    '----------------MENDEFINISIKAN PROSEDUR PENCARIAN DATA PERIKSA----------------'
    Sub caridataperiksa()
        '------bagian kode untuk mencari data di tabel bayar-----'
        Try
            bukaDB()
            Dim mDAc As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM bayar where No_daftar like '%" & txtNoDaftar.Text & "' ORDER BY No_daftar", konek)
            Dim dtc As New DataTable
            Dim dsc As New DataSet
            mDAc.Fill(dsc)
            If dsc.Tables(0).Rows.Count > 0 Then
                txtBiayaDiagnosa.Text = dsc.Tables(0).Rows(0).Item("biaya_diagnosa")
                txtBiayaTindakan.Text = dsc.Tables(0).Rows(0).Item("biaya_tindakan")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        '-------------------------------------------------------------------'
        lvResep.Items.Clear()
        Try
            bukaDB()
            Dim mDA As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM periksa where no_daftar like '%" & txtNoDaftar.Text & "' ORDER BY No_Daftar", konek)
            Dim dt As New DataTable
            Dim ds As New DataSet
            mDA.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                txtTglPeriksa.Value = CType(ds.Tables(0).Rows(0).Item("tgl_periksa"), MySql.Data.Types.MySqlDateTime)
                txtNoRM.Text = ds.Tables(0).Rows(0).Item("no_rm")
                'carinamapasien()
                txtBeratBadan.Text = ds.Tables(0).Rows(0).Item("berat_badan")
                txtNoInduk.Text = ds.Tables(0).Rows(0).Item("no_induk")
                'carinamadokter()
                '--------------bagian untuk menampilkan daftar obat pada listview--------'
                lvResep.View = View.Details
                lvResep.FullRowSelect = True
                lvresep.Columns.Add("Kode_Obat", 100, HorizontalAlignment.Left)
                lvresep.Columns.Add("Nama_Obat", 180, HorizontalAlignment.Left)
                lvresep.Columns.Add("Dosis", 100, HorizontalAlignment.Left)
                lvresep.Columns.Add("Jumlah", 100, HorizontalAlignment.Left)
                Dim list(5) As String
                Dim itemlist As ListViewItem
                Dim i As Int16
                Dim totalharga As Integer

                For i = 0 To ds.Tables(0).Rows.Count - 1
                    list(0) = Trim(ds.Tables(0).Rows(i).Item("Kode_Obat"))
                    list(1) = Trim(ds.Tables(0).Rows(i).Item("Nama_Obat"))
                    list(2) = Trim(ds.Tables(0).Rows(i).Item("Dosis"))
                    list(3) = Trim(ds.Tables(0).Rows(i).Item("Jumlah"))

                    itemlist = New ListViewItem(list)
                    lvResep.Items.Add(itemlist)
                    '----------bagian untuk mencari data harga obat dalam resep-------'
                    Try
                        bukaDB()
                        Dim nharga As Integer
                        Dim mDAA As New MySql.Data.MySqlClient.MySqlDataAdapter(" SELECT * FROM obat where kode_obat like '%" & list(0) & "' ORDER BY kode_obat", konek)
                        Dim dtt As New DataTable
                        Dim dss As New DataSet
                        mDAA.Fill(dss)
                        If dss.Tables(0).Rows.Count > 0 Then
                            nharga = dss.Tables(0).Rows(0).Item("harga") * ds.Tables(0).Rows(0).Item("jumlah")
                        End If
                        totalharga = nharga
                        'totalharga += nharga
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                Next i
                txtBiayaObat.Text = totalharga
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        txtTotalBayar.Text = Val(txtBiayaObat.Text)

    End Sub

    '--------------mendefinisikan prosedur pencarian nama pasien---------------'
    Private Sub carinamapasien()
        Try
            bukaDB()
            Dim mDA As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM pasien where No_Rm like '%" & txtNoRM.Text & "' ORDER BY No_Rm", konek)
            Dim dt As New DataTable
            Dim ds As New DataSet
            mDA.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                txtNamaPasien.Text = ds.Tables(0).Rows(0).Item("nama_pasien")
                Dim strtanggal As String = ds.Tables(0).Rows(0).Item("tanggal_lahir").ToString()
                Dim dttanggal As Date = Date.Parse(strtanggal)
                Dim intTahun As Integer = Year(Now()) - Integer.Parse(Year(dttanggal))
                Dim strTahun As String = intTahun.ToString
                txtUmur.Text = strTahun

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '--------------------mendefinisikan prosedur pencarian nama dokter--------------------------'
    Private Sub carinamadokter()
        Try
            bukaDB()
            Dim mDA As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM dokter where no_induk like '%" & txtNoInduk.Text & "' ORDER BY no_induk", konek)
            Dim dt As New DataTable
            Dim ds As New DataSet
            mDA.Fill(ds)
            If ds.Tables(0).Rows.Count > 0 Then
                txtNamaDokter.Text = ds.Tables(0).Rows(0).Item("Nama_dokter")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    '-----------------mendefinisikan prosedur simpan pembayaran---------------------'
    Private Sub simpanbayar()
        Dim sqlSimpan As String = ""
        If modeSimpan = "Baru" Then
            MsgBox("berjalan")
            sqlSimpan = "INSERT INTO Bayar(no_daftar,tgl_bayar,biaya_diagnosa,biaya_tindakan,biaya_obat) VALUES('" & txtNoDaftar.Text & "','" & Format(txtTglPeriksa.Value, "yyyy-MM-dd") & "','" & txtBiayaDiagnosa.Text & "','" & txtBiayaTindakan.Text & "','" & txtBiayaObat.Text & "')"
            'Else
            ' sqlSimpan = "UPDATE pasien SET nama_pasien='" & txtNamaPasien.Text & "' WHERE No_RM='" & txtNoRM.Text & "'"

        End If
        Try
            With sqlCommand
                .CommandText = sqlSimpan
                .Connection = sqlConnection
                .ExecuteNonQuery()
                Bersih()
                MsgBox("Data transaksi pembayaran pasien berhasil di simpan", vbInformation, "Perhatian")

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            sqlCommand.Dispose()
            TutupDB()

        End Try
    End Sub
    '----mendefinisikan prosedur textbox no_daftar ketika diisi----------'
    Private Sub txtNoDaftar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNoDaftar.KeyPress
        If (e.KeyChar = Chr(13)) Then
            caridataperiksa()
            carinamadokter()
            carinamapasien()

        End If

    End Sub
    '--------------mendefinisikan prosedur textbox biaya diagnosa ketika diisi-----------'
    Private Sub txtBiaya_Diagnosa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBiayaDiagnosa.TextChanged
        txtTotalBayar.Text = Val(txtBiayaObat.Text) + Val(txtBiayaDiagnosa.Text)

    End Sub
    '--------------mendefinisikan prosedur textbox biaya tindakan ketika diisi-----------'
    Private Sub txtBiaya_Tindakan_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBiayaTindakan.TextChanged
        txtTotalBayar.Text = Val(txtBiayaObat.Text) + Val(txtBiayaDiagnosa.Text) + Val(txtBiayaTindakan.Text)

    End Sub
    '-----mendefiniskan prosedur tombol tambah ketika diklik-------'

    Private Sub btnTambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTambah.Click
        Bersih()
        modeSimpan = "Baru"

    End Sub
    '-----mendefiniskan prosedur tombol batal ketika diklik-------'
    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Bersih()

    End Sub
    '-----mendefiniskan prosedur tombol simpan ketika diklik-------'
    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        simpanbayar()
        Bersih()

    End Sub
    '-----mendefiniskan prosedur tombol hapus ketika diklik-------'
    Private Sub btnhapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmdhapus.Click
        Dim sqlHapus As String = "DELETE FROM bayar WHERE " & "No_Daftar = '" & txtNoDaftar.Text & "'"
        Try
            With sqlCommand
                .CommandText = sqlHapus
                .Connection = sqlConnection
                .ExecuteNonQuery()
                'TampilPasien()
                'AturTampilan()
                Bersih()
                MsgBox("data pembayaran pasien berhasil di hapus", vbInformation, "Perhatian !")

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            sqlCommand.Dispose()
            TutupDB()


        End Try
    End Sub
    '-----mendefiniskan prosedur tombol tutup ketika diklik-------'
    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        End
    End Sub

    Private Sub txtTotalBayar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTotalBayar.TextChanged

    End Sub

    Private Sub txtNoDaftar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNoDaftar.TextChanged

    End Sub
End Class

