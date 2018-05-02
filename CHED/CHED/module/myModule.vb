Imports MySql.Data.MySqlClient

Module myModule
    Public dbConn As New MySqlConnection
    Public ds As New DataSet
    Public dr As MySqlDataReader
    Public cmd As New MySqlCommand
    'Private strConn = "server=192.168.0.2; userid=test; password=test;database=ched_stufap"
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
End Module
