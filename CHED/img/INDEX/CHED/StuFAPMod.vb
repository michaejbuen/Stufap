Imports MySql.Data.MySqlClient
Module StuFAPMod
    Public dbConn As New MySqlConnection
    Public ds As New DataSet
    Public dr As MySqlDataReader
    Public cmd As New MySqlCommand
    Private strConn = "server=192.168.0.2; userid=root; password=; database=ched_stufap"
    Public strQuery = ""
    Public dbMsg = ""
    Public Sub dbConnect()
        Try
            dbConn = New MySqlConnection(strConn)
            dbConn.Open()
            'MessageBox.Show("Connection Successful!")
            dbMsg = "Connected to Database"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dbConn.Close()
        End Try
    End Sub



    Public Sub addStudent(lname, fname, mname, dob, bplace, sex, civ_stat, ctzn, mob_num, email, mail_ad, zip, sch_at, dis, col, prio)
        Try
            dbConn.Open()

            strQuery = "INSERT INTO student (lname, fname, mname, dob, bplace, sex, civ_stat, citizenship, mob_num, email, mail_address, zip_code, school_id, school_attainment, disability, college, isActive, date_encoded, course_id, isPriority) VALUES" &
                " ('" & lname.Text & "', '" & fname.Text & "', '" & mname.Text & "' , '" & mname.Text & "', '" & dob.Text & "', '" & bplace.Text & "', '" & sex.Text & "', '" & civ_stat.Text & "', '" & ctzn.Text & "'" &
                ", '" & mob_num.Text & "', '" & email.Text & "', '" & mail_ad.Text & "', '" & zip.Text & "', '" & sch_at.Text & "', '" & dis.Text & "', '" & col.Text & "', '1', '" & prio & "')"


            Dim com = New MySqlCommand(strQuery, dbConn)
            dr = com.ExecuteReader
            dbConn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Sub

    Public Sub addFam(faname, faad, faoc, faeduc, ifa, moname, moad, mooc, moeduc, ima, totinc, totsib)
        Try
            dbConn.Open()

            strQuery = "INSERT INTO student (father_name, father_add, father_occupation, father_education, isFatherAlive, mother_name, mother_add, mother_occupation, mother_education, isMotherAlive, tot_gross_income, no_of_siblings) VALUES" &
                " ('" & faname.Text & "', '" & faad.Text & "', '" & faoc.Text & "', '" & faeduc.Text & "', '" & ifa & "', '" & moname.Text & "', '" & moad.Text & "', '" & mooc.Text & "'" &
                ", '" & moeduc.Text & "', '" & ima & "', '" & totinc.Text & "', '" & totsib.Text & "')"


            Dim com = New MySqlCommand(strQuery, dbConn)
            dr = com.ExecuteReader
            dbConn.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            dbConn.Dispose()
        End Try
    End Sub
End Module
