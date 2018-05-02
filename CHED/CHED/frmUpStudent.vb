Public Class frmUpStudent
    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Close()
    End Sub

    Private Sub frmUpStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub add_stpi_Click(sender As Object, e As EventArgs) Handles add_stpi.Click
        tab.Height = add_stpi.Height
        tab.Top = add_stpi.Top
        'Panel1.Enabled = True
        pi_panel.Show()
        'Panel2.Enabled = False
        fb_panel.Hide()
    End Sub

    Private Sub add_stfb_Click(sender As Object, e As EventArgs) Handles add_stfb.Click
        tab.Height = add_stfb.Height
        tab.Top = add_stfb.Top
        'Panel1.Enabled = False
        pi_panel.Hide()
        fb_panel.Enabled = True
        fb_panel.Show()
    End Sub
End Class