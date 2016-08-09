Imports MySql.Data
Imports MySql.Data.MySqlClient
Module module1
    '===========database variables====================================
    Public cn As New MySqlConnection
    Public dr As MySqlDataReader
    Public cmd As New MySqlCommand
    '===========user access========================
    Public usertype As String
    Public uid As String
    Public uname As String
    '==============connection==============================================================================
    Sub main()
        If cn.State = 1 Then cn.Close()
        cn.ConnectionString = "server=localhost; user id=root; password=; database=dbemployee"
        Try
            cn.Open()
        Catch myerror As MySqlException
            MsgBox("Database is not connected.", MsgBoxStyle.Critical)
            End
        End Try
    End Sub
End Module