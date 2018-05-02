Public Class frmStudent
    Private Sub frmStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
        lblDate.Text = date_today()
        pi_panel.Enabled = True
        pi_panel.Visible = True
        fb_panel.Enabled = False
        fb_panel.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = time_only()
        lblAMPM.Text = time_AmPm()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles add_stpi.Click
        tab.Height = add_stpi.Height
        tab.Top = add_stpi.Top
        'Panel1.Enabled = True
        pi_panel.Show()
        'Panel2.Enabled = False
        fb_panel.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles add_stfb.Click
        tab.Height = add_stfb.Height
        tab.Top = add_stfb.Top
        'Panel1.Enabled = False
        pi_panel.Hide()
        fb_panel.Enabled = True
        fb_panel.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Close()
        'frmMain.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub
End Class