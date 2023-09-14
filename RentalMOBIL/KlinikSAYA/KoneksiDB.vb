Imports MySql.Data.MySqlClient
Imports MySql.Data

Module KoneksiDB
    Public konek As String = "SERVER = Localhost; USERID = root; PASSWORD = ; DATABASE = rentalmobil; Convert Zero Datetime =true;  Allow Zero Datetime =true; "
    Public sqlConnection As New MySqlConnection
    Public sqlCommand As New MySqlCommand
    Public sqlAdapter As New MySqlDataAdapter
    Public konfirmasi As New MsgBoxResult
    Public sqlReader As MySqlDataReader
    Public cur As New Form

    Public Sub bukaDB()
        If sqlConnection.State = ConnectionState.Closed Then
            sqlConnection.ConnectionString = konek
            sqlConnection.Open()
        End If
    End Sub
    Public Sub TutupDB()
        With sqlConnection
            .Dispose()
            .Close()

        End With
    End Sub

End Module
