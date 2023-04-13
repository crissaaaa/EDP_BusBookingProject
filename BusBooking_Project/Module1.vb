Imports MySql.Data.MySqlClient

Module BusBooking_Module
    Public myconn As MySqlConnection = New MySqlConnection
    Public dataset As New DataSet
    Public mycmd As MySqlCommand = New MySqlCommand
    Public myreader As MySqlDataReader
    Public strsql As String
    Public myConnectionString As String

    Public Sub connect()

        mycmd.CommandText = strsql
        mycmd.CommandType = CommandType.Text
        mycmd.Connection = myconn
        myconn.Open()
        myreader = mycmd.ExecuteReader

    End Sub

    Public Sub ConnectToDB()
        myconn.ConnectionString = "server=localhost; user id=root;port=3306;password=Y1012Jqkhkpcrissa;database=bus_bookingdb"

        Try
            myconn.Open()
            'MessageBox.Show("Connection to MySQL bus_bookingdb is successful!", "TESTING MySQL CONNECT TO DB")
            'myconn.Close()

        Catch ex As MySqlException
            Select Case ex.Number
                Case 0
                    MsgBox("Cannot Connect to Server")
                Case 1045
                    MsgBox("Invalid Username or password")
            End Select

        End Try

    End Sub

    Public Sub DisconnectToDB()
        myconn.Close()
        myconn.Dispose()
    End Sub

End Module
