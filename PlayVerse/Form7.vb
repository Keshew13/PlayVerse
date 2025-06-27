Public Class Form7
    Private Sub BtnXtremeRider_Click(sender As Object, e As EventArgs) Handles BtnXtremeRider.Click
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub BtnPong_Click(sender As Object, e As EventArgs) Handles BtnPong.Click
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub BtnMineSweeper_Click(sender As Object, e As EventArgs) Handles BtnMineSweeper.Click
        Form6.Show()
        Me.Hide()
    End Sub

    Private Sub QuitGame_Click(sender As Object, e As EventArgs) Handles QuitGame.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSkyHopper.Click
        Form9.Show()
        Me.Hide()
    End Sub

    Private Sub BtnAbout_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        PanelAbout.Visible = True
        PanelAbout.Location = New Point(0, 0)
    End Sub

    Private Sub BtnMainMenu_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click
        PanelAbout.Visible = False
    End Sub
End Class