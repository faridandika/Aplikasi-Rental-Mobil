Public Class frmDokter

    Public modeSimpan As String

    Private Sub Bersih()
        No_Induk.Text = ""
        Nama_Dokter.Text = ""
        Spesialis.Text = ""
        No_Telp.Text = ""
        txtAlamat.Text = ""
        CmdBaru.Focus()

    End Sub

    Sub AturTampilan()
        With DataGridView1
            .Columns(0).Width = 150
            .Columns(0).HeaderText = "No.Induk"
            .Columns(1).Width = 100
            .Columns(1).HeaderText = "Nama Dokter"
            .Columns(2).Width = 100
            .Columns(2).HeaderText = "Spesialis"
            .Columns(3).Width = 100
            .Columns(3).HeaderText = "No. Telpon/HP"
            .Columns(4).Width = 100
            .Columns(4).HeaderText = "Alamat"

        End With
    End Sub

    Sub TampilDokter()
        Try
            bukaDB()
            Dim mDA As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM dokter", konek)
            Dim dt As New DataTable
            mDA.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CariDataDokter()
        Try
            bukaDB()
            Dim mDA As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM pasien where No_Induk like '%" & No_Induk.Text & "'", konek)

            Dim dt As New DataTable
            mDA.Fill(dt)
            DataGridView1.DataSource = dt
            If DataGridView1.Item(0, 0).Value <> "" Then
                Nama_Dokter.Text = DataGridView1.Item(1, 0).Value
                Spesialis.Text = DataGridView1.Item(2, 0).Value
                No_Telp.Text = DataGridView1.Item(3, 0).Value
                txtAlamat.Text = DataGridView1.Item(4, 0).Value
                modeSimpan = "Modifikasi"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TampilDokter()
        AturTampilan()
        Nama_Dokter.Focus()
    End Sub

    Private Sub CmdTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTutup.Click
        End
    End Sub

    Private Sub CmdBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBaru.Click
        Bersih()
        modeSimpan = "Baru"
        No_Induk.Focus()
    End Sub

    Private Sub CmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSimpan.Click
        Dim sqlSimpan As String
        If modeSimpan = "Baru" Then
            sqlSimpan = "INSERT INTO dokter(No_Induk, Nama_Dokter, Spesialis, No_Telp, Alamat)" & "VALUE('" & No_Induk.Text & "','" & Nama_Dokter.Text & "','" & Spesialis.Text & "','" & No_Telp.Text & "','" & txtAlamat.Text & "')"
        Else
            sqlSimpan = "UPDATE dokter SET Nama_Dokter = '" & Nama_Dokter.Text & "',spesialis ='" & Spesialis.Text & "',No_telp ='" & No_Telp.Text & "',alamat ='" & txtAlamat.Text & "', WHERE No_Induk ='" & No_Induk.Text & "'"
        End If
        Try
            With sqlCommand
                .CommandText = sqlSimpan
                .Connection = sqlConnection
                .ExecuteNonQuery()
                TampilDokter()
                AturTampilan()
                Bersih()
                MsgBox("Data Registrasi Dokter Berhasil Di Simpan", vbInformation, "Terimakasih")
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            sqlCommand.Dispose()
            TutupDB()
        End Try
    End Sub

    Private Sub frmDokter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdHapus.Click
        Dim sqlHapus As String = "DELETE FORM dokter WHERE " & "No_Induk ='" & No_Induk.Text & "'"
        Try
            With sqlCommand
                .CommandText = sqlHapus
                .Connection = sqlConnection
                .ExecuteNonQuery()
                TampilDokter()
                AturTampilan()
                Bersih()
                MsgBox("Data Dokter Berhasil Di Hapus", vbInformation, "Terimakasih")
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            sqlCommand.Dispose()
            TutupDB()
        End Try
    End Sub

    Private Sub frmDokter_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        TampilDokter()
        AturTampilan()
    End Sub

    Private Sub txtNo_Induk_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (e.KeyChar = Chr(13)) Then
            CariDataDokter()
        End If
    End Sub

End Class