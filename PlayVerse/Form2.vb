Public Class Form2
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles BtnStart.Click
        Form1.Show()
        Me.Hide()
        Form1.Focus()

    End Sub

    Private Sub BtnExit2_Click(sender As Object, e As EventArgs) Handles BtnExit2.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub BtnControls_Click(sender As Object, e As EventArgs) Handles BtnControls.Click
        PanelControl.Visible = True
        PanelControl.Location = New Point(0, 0)
        BtnMainMenu.Focus()

    End Sub

    Private Sub BtnMainMenu1_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click
        PanelControl.Visible = False
        BtnStart.Focus()


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(1300, 740)
        Me.MaximumSize = New Size(1920, 1080)

    End Sub
End Class