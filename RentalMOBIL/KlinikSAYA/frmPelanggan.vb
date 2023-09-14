Public Class FORMPELANNGAN

    Public modeSimpan As String
    Private Sub Bersih()
        txtno.Text = ""
        txtnama.Text = ""
        txtalamat.Text = ""
        txttempat.Text = ""
        txttanggal.Refresh()
        txtKelaminPria.Checked = False
        txtKlaminPerempuan.Checked = False
        CmdBaru.Focus()
    End Sub

    Sub AturTampilan()
        With DataGridView1
            .Columns(0).Width = 150
            .Columns(0).HeaderText = "No.Pelanggan"
            .Columns(1).Width = 100
            .Columns(1).HeaderText = "Nama Pelanggan"
            .Columns(2).Width = 100
            .Columns(2).HeaderText = "Alamat"
            .Columns(3).Width = 100
            .Columns(3).HeaderText = "Tempat Lahir"
            .Columns(4).Width = 100
            .Columns(4).HeaderText = "Tanggal Lahir"
            .Columns(5).Width = 100
            .Columns(5).HeaderText = "Jenis kelamin"
        End With
    End Sub

    Sub TampilPasien()
        Try
            bukaDB()
            Dim mDA As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM pelanggan", konek)
            Dim dt As New DataTable
            mDA.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub CariDataPasien()
        Try
            bukaDB()
            Dim mDA As New MySql.Data.MySqlClient.MySqlDataAdapter("SELECT * FROM pelanggan where No_RP like '%" & txtno.Text & "'", konek)

            Dim dt As New DataTable
            mDA.Fill(dt)
            DataGridView1.DataSource = dt
            If DataGridView1.Item(0, 0).Value <> "" Then
                txtnama.Text = DataGridView1.Item(1, 0).Value
                txtalamat.Text = DataGridView1.Item(2, 0).Value
                txttempat.Text = DataGridView1.Item(3, 0).Value
                If DataGridView1.Item(5, 0).Value = "laki-Laki" Then
                    txtKelaminPria.Checked = True
                    txtKlaminPerempuan.Checked = False
                Else
                    txtKelaminPria.Checked = False
                    txtKlaminPerempuan.Checked = True
                End If
                modeSimpan = "Modifikasi"
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        TampilPasien()
        AturTampilan()
        txtnama.Focus()
    End Sub

    Private Sub Frmpasien_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        TampilPasien()
        AturTampilan()
    End Sub



    Private Sub CmdBaru_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBaru.Click
        Bersih()
        modeSimpan = "Baru"
    End Sub


    Private Sub CmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSimpan.Click
        Dim txtKelamin As String
        Dim sqlSimpan As String
        If txtKelaminPria.Checked = True Then
            txtKelamin = "Laki-Laki"
        Else
            txtKelamin = "perempuan"
        End If
        If modeSimpan = "Baru" Then
            sqlSimpan = "INSERT INTO pelanggan(No_RP, Nama_Pelanggan,Alamat,Tempat_Lahir,Tanggal_Lahir,Jenis_Kelamin)" & "VALUES ('" & txtno.Text & "','" & txtnama.Text & "','" & txtalamat.Text & "','" & txttempat.Text & "','" & Format(txttanggal.Value, "yyyy-MM-dd") & "','" & txtKelamin & "')"
        Else
            sqlSimpan = "UPDATE pelanggan SET Nama_Pelanggan='" & txtnama.Text & "', Alamat='" & txtalamat.Text & "', Tempat_Lahir='" & txttempat.Text & "', Tanggal_Lahir='" & Format(txttanggal.Value, "yyyy-MM-dd") & "', Jenis_Kelamin='" & txtKelamin & "' WHERE No_RP='" & txtno.Text & "'"

        End If
        Try
            With sqlCommand
                .CommandText = sqlSimpan
                .Connection = sqlConnection
                .ExecuteNonQuery()
                TampilPasien()
                AturTampilan()
                Bersih()
                MsgBox("Data Registrasi Pelanggan berhasil disimpan", vbInformation, "Selamat!")

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            sqlCommand.Dispose()
            TutupDB()
        End Try
    End Sub



    Private Sub CmdTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdTutup.Click
        End
    End Sub

    Private Sub CmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdHapus.Click
        Dim sqlHapus As String = "DELETE FROM pelanggan WHERE " & "No_RP= '" & txtno.Text & "'"
        Try
            With sqlCommand

                .CommandText = sqlHapus
                .Connection = sqlConnection
                .ExecuteNonQuery()
                TampilPasien()
                AturTampilan()
                Bersih()
                MsgBox("Data Registrasi Pelanggan berhasil dihapus", vbInformation, "Terimakasih")

            End With
        Catch ex As Exception
            MsgBox(ex.Message)
            sqlCommand.Dispose()
            TutupDB()
        End Try
    End Sub

    Private Sub CmdBatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdBatal.Click
        Bersih()
    End Sub

    Private Sub t1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtno.KeyPress
        If (e.KeyChar = Chr(13)) Then
            CariDataPasien()
        End If
    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub FORMPELANNGAN_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
