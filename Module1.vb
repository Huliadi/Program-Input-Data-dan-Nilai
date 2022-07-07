Imports MySql.Data.MySqlClient
Module Module1
    Public conn As MySqlConnection
    Public da As MySqlDataAdapter
    Public ds As DataSet
    Public cmd As MySqlCommand
    Public rd As MySqlDataReader
    Public MyDB As String
    Sub OpenConn()
        MyDB = ("server = localhost; user id = root; password =; database = db_input")
        conn = New MySqlConnection(MyDB)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub
End Module
