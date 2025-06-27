Public Class Form4
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub BtnControls_Click(sender As Object, e As EventArgs) Handles BtnControls.Click
        PanelControl2.Visible = True
        PanelControl2.Location = New Point(0, 0)
        BtnMainMenu2.Focus()
    End Sub

    Private Sub BtnExit2_Click(sender As Object, e As EventArgs) Handles BtnExit2.Click
        Form7.Show()
        Me.Hide()
    End Sub

    Private Sub BtnMainMenu2_Click(sender As Object, e As EventArgs) Handles BtnMainMenu2.Click
        PanelControl2.Visible = False
        BtnStart.Focus()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class