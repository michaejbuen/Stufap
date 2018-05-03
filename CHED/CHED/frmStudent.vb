Public Class frmStudent
    Dim sex, civstat, fliving, mliving, prio, solo, senior, disabled, ethnic, type, gwa, sql As String
    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblDate.Text = date_today()
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = time_only()
        lblAMPM.Text = time_AmPm()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tab.Height = Button3.Height
        tab.Top = Button3.Top
        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        tab.Height = Button5.Height
        tab.Top = Button5.Top
        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        tab.Height = Button6.Height
        tab.Top = Button6.Top
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True
        Panel4.Visible = False
    End Sub
    Private Sub setSex()
        If rbMale.Checked Then
            sex = "Male"
        ElseIf rbFemale.Checked Then
            sex = "Female"
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        tab.Height = Button7.Height
        tab.Top = Button7.Top
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmMain.Show()
    End Sub

    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        frmSchoolList.show = "highschool"
        frmSchoolList.ShowDialog()
    End Sub

    Private Sub setCivStat()
        If rbSingle.Checked Then
            civstat = "Single"
        ElseIf rbMarried.Checked Then
            civstat = "Married"
        End If
    End Sub

    Private Sub rbIncoming_CheckedChanged(sender As Object, e As EventArgs) Handles rbIncoming.CheckedChanged
        lblGWA.Visible = False
        txtGrade1.Focus()
        txtGrade1.Visible = True
        txtGrade2.Visible = False
        lblG.Visible = False
        lblGWA.Visible = False
    End Sub

    Private Sub rbALS_CheckedChanged(sender As Object, e As EventArgs) Handles rbALS.CheckedChanged
        lblGWA.Visible = False
        txtGrade1.Focus()
        txtGrade1.Visible = True
        txtGrade2.Visible = False
        lblG.Visible = False
        lblGWA.Visible = False
    End Sub

    Private Sub txtGrade1_TextChanged(sender As Object, e As EventArgs) Handles txtGrade1.TextChanged
        lblGWA.Visible = True
        If txtGrade1.Text = Nothing And txtGrade2.Text IsNot Nothing Then
            txtGrade1.Text = "0"
            lblGWA.Text = ((Convert.ToDecimal(txtGrade1.Text) + Convert.ToDecimal(txtGrade2.Text)) / 2).ToString
        ElseIf txtGrade2.Text = Nothing And txtGrade1.Text IsNot Nothing Then
            txtGrade2.Text = "0"
            lblGWA.Text = ((Convert.ToDecimal(txtGrade1.Text) + Convert.ToDecimal(txtGrade2.Text)) / 2).ToString
        ElseIf txtGrade1.Text = Nothing And txtGrade2.Text = Nothing Then
            lblGWA.Text = "0.00"
        Else
            lblGWA.Text = ((Convert.ToDecimal(txtGrade1.Text) + Convert.ToDecimal(txtGrade2.Text)) / 2).ToString
        End If
    End Sub

    Private Sub txtGrade2_TextChanged(sender As Object, e As EventArgs) Handles txtGrade2.TextChanged
        lblGWA.Visible = True
        If txtGrade1.Text = Nothing And txtGrade2.Text IsNot Nothing Then
            txtGrade1.Text = "0"
            lblGWA.Text = ((Convert.ToDecimal(txtGrade1.Text) + Convert.ToDecimal(txtGrade2.Text)) / 2).ToString
        ElseIf txtGrade2.Text = Nothing And txtGrade1.Text IsNot Nothing Then
            txtGrade2.Text = "0"
            lblGWA.Text = ((Convert.ToDecimal(txtGrade1.Text) + Convert.ToDecimal(txtGrade2.Text)) / 2).ToString
        ElseIf txtGrade1.Text = Nothing And txtGrade2.Text = Nothing Then
            lblGWA.Text = "0.00"
        Else
            lblGWA.Text = ((Convert.ToDecimal(txtGrade1.Text) + Convert.ToDecimal(txtGrade2.Text)) / 2).ToString
        End If
    End Sub

    Private Sub btnSelect2_Click(sender As Object, e As EventArgs) Handles btnSelect2.Click
        frmSchoolList.show = "college"
        frmSchoolList.ShowDialog()
    End Sub

    Private Sub btnSelect3_Click(sender As Object, e As EventArgs) Handles btnSelect3.Click
        frmCourseList.ShowDialog()
    End Sub

    Private Sub rbOngoing_CheckedChanged(sender As Object, e As EventArgs) Handles rbOngoing.CheckedChanged
        lblGWA.Visible = True
        txtGrade1.Focus()
        txtGrade1.Visible = True
        txtGrade2.Visible = True
        lblG.Visible = True

    End Sub
    Private Sub setPrio()
        If rbPrio.Checked Then
            prio = "Yes"
        ElseIf rbNPrio.Checked Then
            prio = "No"
        End If
    End Sub
    Private Sub settype()
        If rbIncoming.Checked Then
            type = "Incoming"
            gwa = txtGrade1.Text
        ElseIf rbALS.Checked Then
            type = "ALS"
            gwa = txtGrade1.Text
        ElseIf rbOngoing.Checked Then
            type = "Ongoing"
            gwa = Convert.ToDecimal(lblGWA.Text)
        End If
    End Sub
    Private Sub setFLiving()
        If rbFL.Checked Then
            fliving = "Yes"
        ElseIf rbFD.Checked Then
            fliving = "No"
        End If
    End Sub
    Private Sub setMLiving()
        If rbML.Checked Then
            mliving = "Yes"
        ElseIf rbMD.Checked Then
            mliving = "No"
        End If
    End Sub
    Private Sub setGroup()
        solo = "No"
        senior = "No"
        disabled = "No"
        ethnic = "No"
        If cbSolo.Checked = True Then
            solo = "Yes"
        End If
        If cbSenior.Checked = True Then
            senior = "Yes"
        End If
        If cbDisable.Checked = True Then
            disabled = "Yes"
        End If
        If cbEthnic.Checked = True Then
            ethnic = "Yes"
        End If
    End Sub
    Private Sub generateGrade()
        Dim grade As Decimal = Convert.ToDecimal(lblGWA.Text)
        If grade >= 99.376 Then
            lblGrade.Text = "100"
        ElseIf grade >= 98.751 Then
            lblGrade.Text = "99"
        ElseIf grade >= 98.126 Then
            lblGrade.Text = "98"
        ElseIf grade >= 97.501 Then
            lblGrade.Text = "97"
        ElseIf grade >= 96.876 Then
            lblGrade.Text = "96"
        ElseIf grade >= 96.251 Then
            lblGrade.Text = "95"
        ElseIf grade >= 95.626 Then
            lblGrade.Text = "94"
        ElseIf grade >= 95.001 Then
            lblGrade.Text = "93"
        ElseIf grade >= 94.376 Then
            lblGrade.Text = "92"
        End If
        'IF(AVERAGE(T18:W18)>=94.376,"92",IF(AVERAGE(T18:W18)>=93.751,"91",IF(AVERAGE(T18:W18)>=93.126,"90",IF(AVERAGE(T18:W18)>=92.501,"89",IF(AVERAGE(T18:W18)>=91.876,"88",IF(AVERAGE(T18:W18)>=91.251,"87",IF(AVERAGE(T18:W18)>=90.626,"86",IF(AVERAGE(T18:W18)>=90.001,"85",IF(AVERAGE(T18:W18)>=89.376,"84",IF(AVERAGE(T18:W18)>=88.751,"83",IF(AVERAGE(T18:W18)>=88.126,"82",IF(AVERAGE(T18:W18)>=87.501,"81",IF(AVERAGE(T18:W18)>=86.876,"80",IF(AVERAGE(T18:W18)>=86.251,"79",IF(AVERAGE(T18:W18)>=85.626,"78",IF(AVERAGE(T18:W18)>=85.001,"77",IF(AVERAGE(T18:W18)>=84.376,"76",IF(AVERAGE(T18:W18)>=83.751,"75",IF(AVERAGE(T18:W18)>=83.126,"74",IF(AVERAGE(T18:W18)>=82.501,"73",IF(AVERAGE(T18:W18)>=81.876,"72",IF(AVERAGE(T18:W18)>=81.251,"71",IF(AVERAGE(T18:W18)>=80.626,"70",IF(AVERAGE(T18:W18)>=80.001,"69",IF(AVERAGE(T18:W18)>=79.376,"68",IF(AVERAGE(T18:W18)>=78.751,"67",IF(AVERAGE(T18:W18)>=78.126,"66",IF(AVERAGE(T18:W18)>=77.501,"65",IF(AVERAGE(T18:W18)>=76.876,"64",IF(AVERAGE(T18:W18)>=76.251,"63",IF(AVERAGE(T18:W18)>=75.626,"62",IF(AVERAGE(T18:W18)>=75.001,"61","60"))))))))))))))))))))))))))))))))))))))))
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        getStudID()
        setSex()
        setCivStat()
        sql = "INSERT INTO student (stud_id, fam_id, educ_id, c_id , lname, fname, mname, ext_name, dob, bplace, sex, civ_stat, citizenship, mob_num, email, home_street, home_town, home_province, home_dist, zip_code, disability, group_id, lacking, remarks) VALUES" &
                        " ('" & StudID & "', " &
                        " '" & StudID & "', " &
                        " '" & StudID & "', " &
                        " '" & StudID & "', " &
                        " '" & txtLName.Text & "', " &
                        " '" & txtFName.Text & "', " &
                        " '" & txtMName.Text & "', " &
                        " '" & txtExtName.Text & "', " &
                        " '" & dtpDOB.Value.ToString("yyyy-M-d") & "', " &
                        " '" & txtBPlace.Text & "', " &
                        " '" & sex & "', " &
                        " '" & civstat & "', " &
                        " '" & txtCtzn.Text & "', " &
                        " '" & txtMobile.Text & "', " &
                        " '" & txtEmail.Text & "', " &
                        " '" & txtAdd1.Text & "', " &
                        " '" & txtAdd2.Text & "', " &
                        " '" & txtAdd3.Text & "', " &
                        " '" & txtDist.Text & "', " &
                        " '" & txtZip.Text & "', " &
                        " '" & txtDisability.Text & "', " &
                        " '" & StudID & "', " &
                        " '" & txtReq.Text & "', " &
                        " '" & txtRemarks.Text & "')"
        MyNonQuery(sql)

        'setGroup()
        'sql = "INSERT INTO group (group_id, solo_parent, senior, disabled, ethnic) VALUES" &
        '                " ('" & StudID & "', " &
        '                " '" & solo & "', " &
        '                " '" & senior & "', " &
        '                " '" & disabled & "', " &
        '                " '" & ethnic & "')"
        'MyNonQuery(sql)

        setFLiving()
        setMLiving()
        sql = "INSERT INTO fam_background (fam_id, father_name, father_add, father_occupation, father_education, isFatherAlive, mother_name, mother_add, mother_occupation, mother_education, isMotherAlive, tot_gross_income, no_of_siblings) VALUES" &
                        " ('" & StudID & "', " &
                        " '" & txtFaName.Text & "', " &
                        " '" & txtFAdd.Text & "', " &
                        " '" & txtFOccu.Text & "', " &
                        " '" & txtFEduc.Text & "', " &
                        " '" & fliving & "', " &
                        " '" & txtMoName.Text & "', " &
                        " '" & txtMAdd.Text & "', " &
                        " '" & txtMOccu.Text & "', " &
                        " '" & txtMEduc.Text & "', " &
                        " '" & mliving & "', " &
                        " '" & txtGIncome.Text & "', " &
                        " '" & txtSiblings.Text & "')"
        MyNonQuery(sql)

        settype()
        sql = "INSERT INTO educ_background (educ_id, school_id, highest_attainment, type, grade) VALUES" &
                        " ('" & StudID & "', " &
                        " '" & lblSID1.Text & "', " &
                        " '" & txtGradeYr.Text & "', " &
                        " '" & type & "', " &
                        " '" & gwa & "')"
        MyNonQuery(sql)

        setPrio()
        sql = "INSERT INTO college_info (c_id, college_id, course_id, isPriority) VALUES" &
                        " ('" & StudID & "', " &
                        " '" & lblSID2.Text & "', " &
                        " '" & lblCID.Text & "', " &
                        " '" & prio & "')"
        MyNonQuery(sql)

        MessageBox.Show("Added successfully.")
        'MsgBox("Student Added Successfully.")


    End Sub
End Class