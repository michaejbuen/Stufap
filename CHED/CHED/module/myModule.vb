Imports MySql.Data.MySqlClient

Module myModule
    Public dbConn As New MySqlConnection
    Public ds As New DataSet
    Public dr As MySqlDataReader
    Public cmd As New MySqlCommand
    Public StudID As String
    'Private strConn = "server=192.168.0.2; userid=test; password=test;database=ched_stufap"
    'Private strConn = "server=localhost; userid=root; password=;database=ched_stufap"
    Private strConn = "server=localhost; userid=root; password=;database=test_db"
    Public Sub dbConnect()
        Try
            dbConn = New MySqlConnection(strConn)
            dbConn.Open()
            'MessageBox.Show("Connection Successful!")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Close()
        End Try

    End Sub
    Public Function date_today()
        Dim now As DateTime = DateTime.Now
        Dim today As String = now.ToLongDateString()
        Return today
    End Function
    Public Function time()
        Dim t As String = TimeOfDay.ToString("h:mm:ss tt")
        Return t
    End Function
    Public Function time_only()
        Dim t As String = TimeOfDay.ToString("h:mm:ss")
        Return t
    End Function
    Public Function time_AmPm()
        Dim t As String = TimeOfDay.ToString("tt")
        Return t
    End Function
    Public Sub MyNonQuery(ByVal SQCommand As String)
        Dim SQLCMD As New MySqlCommand(SQCommand, dbConn)
        Try
            dbConn.Open()
            SQLCMD.ExecuteNonQuery()
            dbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub getStudID()
        Try
            Dim id As Integer
            dbConn.Open()
            Dim cmd As New MySqlCommand("SELECT stud_id FROM student ORDER BY stud_id DESC LIMIT 1", dbConn)
            Dim reader As MySqlDataReader
            reader = cmd.ExecuteReader
            While reader.Read
                id = reader.GetInt32("stud_id")
                StudID = (id + 1).ToString
            End While
            dbConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Sub
End Module
