Public Class Form6
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub BtnHowto_Click(sender As Object, e As EventArgs) Handles BtnHowto.Click
        PanelHowto.Visible = True
        PanelHowto.Location = New Point(0, 0)
    End Sub

    Private Sub BtnMainMenu_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click
        PanelHowto.Visible = False
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class