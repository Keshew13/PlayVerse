Public Class Form9
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Form8.Show()
        Me.Close()

    End Sub

    Private Sub BtnExit2_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub BtnControls_Click(sender As Object, e As EventArgs) Handles BtnControls.Click
        PanelControl.Visible = True
        PanelControl.Location = New Point(0, 0)
    End Sub

    Private Sub BtnMainMenu2_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click
        PanelControl.Visible = False
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class