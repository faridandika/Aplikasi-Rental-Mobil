
Public Class frmKendaraan

    Public modeSimpan As String

    Private Sub Bersih()
        txtKode_obat.Text = ""
        txtNama_obat.Text = ""
        txtSatuan.Text = ""
        txtHarga.Text = ""
        txtDosis.Text = ""
        btnBaru.Focus()

    End Sub
    Sub AturTampilan()
        With DataGridView1
            .Columns(0).Width = 100
            .Columns(0).HeaderText = "Kode Kendaraan"
            .Columns(1).Width = 100
            .Columns(1).HeaderText = "Nama Kendaraan"
            .Columns(2).Width = 100
            .Columns(2).HeaderText = "Nama Pelanggan"
            .Columns(3).Width = 100
            .Columns(3).HeaderText = "Harga"
            .Columns(4).Width = 100
            .Columns(4).HeaderText = "Durasi Sewa"

        End With
    End Sub
    Sub TampilObat()
        Try
            bukaDB()
            Dim mDA As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM Kendaraan", konek)
            Dim dt As New DataTable
            mDA.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub CariDataObat()
        Try
            bukaDB()
            Dim mDA As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM Kendaraan where Kode_Kendaraan like '%" & txtKode_obat.Text & "'", konek)

            Dim dt As New DataTable
            mDA.Fill(dt)
            DataGridView1.DataSource = dt
            If DataGridView1.Item(0, 0).Value <> "" Then
                txtNama_obat.Text = DataGridView1.Item(1, 0).Value
                txtSatuan.Text = DataGridView1.Item(2, 0).Value
                txtHarga.Text = DataGridView1.Item(3, 0).Value
                txtDosis.Text = DataGridView1.Item(4, 0).Value
                modeSimpan = "Modifikasi"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TampilObat()
        AturTampilan()
        txtNama_obat.Focus()
    End Sub
    Private Sub frmObat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtKode_obat_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtKode_obat.KeyPress
        If (e.KeyChar = Chr(13)) Then
            'txtnama.Focus()
            CariDataObat()
        End If
    End Sub

    Private Sub btnBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBaru.Click
        Bersih()
        modeSimpan = "Baru"
    End Sub

    Private Sub btnBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatal.Click
        Bersih()
    End Sub

    Private Sub btnSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSimpan.Click
        Dim sqlSimpan As String
        If modeSimpan = "Baru" Then
            sqlSimpan = "INSERT INTO Kendaraan(Kode_Kendaraan, Nama_Kendaraan, Satuan, Harga, Dosis)" & "VALUE('" & txtKode_obat.Text & "','" & txtNama_obat.Text & "','" & txtSatuan.Text & "','" & txtHarga.Text & "','" & txtDosis.Text & "')"
        Else
            sqlSimpan = "UPDATE Kendaraan SET Nama Kendaraan = '" & txtNama_obat.Text & "',Satuan ='" & txtSatuan.Text & "',Harga ='" & txtHarga.Text & "',Dosis ='" & txtDosis.Text & "', WHERE Kode Kendaraan ='" & txtKode_obat.Text & "'"
        End If
        Try
            With sqlCommand
                .CommandText = sqlSimpan
                .Connection = sqlConnection
                .ExecuteNonQuery()
                TampilObat()
                AturTampilan()
                Bersih()
                MsgBox("Data Registrasi Rental Mobil Berhasil Di Simpan", vbInformation, "Terimakasih")
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            sqlCommand.Dispose()
            TutupDB()
        End Try
    End Sub

    Private Sub btnHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHapus.Click
        Dim sqlHapus As String = "DELETE FORM Kendaraan WHERE " & "Kode Kendaraan ='" & txtKode_obat.Text & "'"
        Try
            With sqlCommand
                .CommandText = sqlHapus
                .Connection = sqlConnection
                .ExecuteNonQuery()
                TampilObat()
                AturTampilan()
                Bersih()
                MsgBox("Data Kendaraan Rental Berhasil Di Hapus", vbInformation, "Terimakasih")
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            sqlCommand.Dispose()
            TutupDB()
        End Try
    End Sub

    Private Sub frmObat_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        TampilObat()
        AturTampilan()
    End Sub

    Private Sub btnTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTutup.Click
        End
    End Sub

    Private Sub kode_obat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kode_obat.Click

    End Sub
End Class