Imports Microsoft

Public Class Form8
    Dim LRMovement As Integer = 10
    Dim gravity As Integer = 5
    Dim isfalling As Boolean
    Dim jumpspeed As Integer = 20
    Dim currentjumpspeed As Integer
    Dim isJumping As Boolean = False
    Dim isOnPlatform As Boolean = False
    Dim canJump As Boolean = True
    Dim score As Integer = 0
    Dim highscore As Integer = My.Settings.SkyHopperHighScore
    Dim Cspeed As Integer
    Dim Pspeed As Integer
    Dim rand As New Random()
    Dim Platforms() As PictureBox

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblHighScore.Text = "HighScore: " & My.Settings.SkyHopperHighScore
        CaptainHop.Location = New Point(380, 560)

        Platform0.Location = New Point(340, 630)
        Platform1.Location = New Point(150, 470)
        Platform2.Location = New Point(480, 320)
        Platform3.Location = New Point(140, 180)
        Platform4.Location = New Point(420, 40)
        Platform5.Location = New Point(230, -100)
        PanelGameover.Location = New Point(200, 120)
        LblPause.Location = New Point(200, 250)

        Platforms = {Platform0, Platform1, Platform2, Platform3, Platform4, Platform5}
    End Sub

    Private Sub Form8_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If PanelGameover.Visible = False Then
            If e.KeyCode = Keys.Space AndAlso isOnPlatform AndAlso canJump Then
                currentjumpspeed = jumpspeed
                isJumping = True
                canJump = False
                Jumpmover.Start()
            End If
            If (LblGameStart.Visible = True Or LblPause.Visible = True) Then
                If e.KeyCode = Keys.Enter Then
                    Platformmover.Start()
                    Gravitytimer.Start()
                    scrtimer.Start()
                    LblGameStart.Visible = False
                    LblPause.Visible = False
                End If
            Else
                If e.KeyCode = Keys.Enter Then
                    Platformmover.Stop()
                    Gravitytimer.Stop()
                    scrtimer.Stop()
                    LblPause.Visible = True
                End If
            End If
            If e.KeyCode = Keys.Right Then Rightmover.Start()
            If e.KeyCode = Keys.Left Then Leftmover.Start()
        End If

    End Sub

    Private Sub Form8_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.Left Then Leftmover.Stop()
        If e.KeyCode = Keys.Right Then Rightmover.Stop()
    End Sub

    ' Jump timer
    Private Sub Upmover_Tick(sender As Object, e As EventArgs) Handles Jumpmover.Tick
        CaptainHop.Top -= currentjumpspeed
        currentjumpspeed -= 1

        If currentjumpspeed <= 0 Then       'first  jumping state 0 pr aane ke baad gravity state start hogi jisme check hoga  
            'ki kya woh platform ke bounds ke contact pr hai ya nahi,if yes then gravity mover stops

            isJumping = False
            Jumpmover.Stop()
            Gravitytimer.Start()
        End If
    End Sub

    ' Gravity timer
    Private Sub Gravitymover_Tick(sender As Object, e As EventArgs) Handles Gravitytimer.Tick
        CaptainHop.Top += gravity
        isOnPlatform = False
        isfalling = True
        For Each platform As PictureBox In Platforms
            If CaptainHop.Bounds.IntersectsWith(platform.Bounds) Then
                CaptainHop.Top = platform.Top - CaptainHop.Height
                isOnPlatform = True
                canJump = True
                Gravitytimer.Stop()
                isfalling = False
                Exit For
            End If
        Next
    End Sub

    Private Sub PlatformMover_Tick(sender As Object, e As EventArgs) Handles Platformmover.Tick
        Adjustspeed()
        CaptainHop.Top += Cspeed
        For Each platform As PictureBox In Platforms
            platform.Top += Pspeed
            If platform.Top >= Me.Height Then
                platform.Top = -150
                platform.Left = rand.Next(0, PanelGameScreen.Width - 110)
            End If
        Next
        If CaptainHop.Bottom > PanelGameScreen.Height Then
            gameover()
        End If
    End Sub

    ' Move left
    Private Sub Leftmover_Tick(sender As Object, e As EventArgs) Handles Leftmover.Tick
        If CaptainHop.Left > -30 And isJumping = True Or isfalling = True Then
            CaptainHop.Left -= LRMovement
        End If
        If CaptainHop.Left < -30 Then
            CaptainHop.Left = PanelGameScreen.Width - 5
        End If

    End Sub

    ' Move right
    Private Sub Rightmover_Tick(sender As Object, e As EventArgs) Handles Rightmover.Tick
        If CaptainHop.Left < PanelGameScreen.Width + 5 And isJumping = True Or isfalling = True Then
            CaptainHop.Left += LRMovement
        End If
        If CaptainHop.Left > PanelGameScreen.Width Then
            CaptainHop.Left = 5
        End If
    End Sub

    Private Sub Scrtimer_Tick(sender As Object, e As EventArgs) Handles scrtimer.Tick
        score += 1
        Score_count.Text = "Score: " & score
        Final_Score.Text = "Your " & Score_count.Text
        If score > highscore Then
            LblHighScore.Text = "HighScore: " & score
            My.Settings.SkyHopperHighScore = score
            My.Settings.Save()
        End If
    End Sub
    Private Sub Adjustspeed()
        Select Case score
            Case 0 To 19
                Cspeed = 1
                Pspeed = 1
            Case 20 To 40
                Cspeed = 2
                Pspeed = 2
            Case 41 To 70
                Cspeed = 3
                Pspeed = 3
            Case 71 To 200
                Cspeed = 4
                Pspeed = 4
            Case 201 To 500
                Cspeed = 5
                Pspeed = 5
        End Select
    End Sub
    Private Sub gameover()
        Leftmover.Stop()
        Rightmover.Stop()
        scrtimer.Stop()
        Platformmover.Stop()
        Jumpmover.Stop()
        Gravitytimer.Stop()
        PanelGameover.Visible = True
        LblGameOver.Visible = True
        Final_Score.Text = "Your Score: " & score
        Final_Score.Visible = True
        BtnRestart.Focus()
    End Sub
    Private Sub ResetGame()
        If score > highscore Then
            highscore = score
            My.Settings.SkyHopperHighScore = highscore
            My.Settings.Save()
        End If

        score = 0
        Score_count.Text = "Score: 0"
        Final_Score.Text = "Your Score: 0"
        LblHighScore.Text = "HighScore: " & My.Settings.SkyHopperHighScore
        isOnPlatform = False
        canJump = True
        isJumping = False
        isfalling = False

        LblGameOver.Visible = False
        PanelGameover.Visible = False
        CaptainHop.Location = New Point(380, 600)
        PanelGameover.Location = New Point(200, 120)
        LblPause.Location = New Point(200, 250)

        Platform0.Location = New Point(340, 630)
        Platform1.Location = New Point(150, 470)
        Platform2.Location = New Point(480, 320)
        Platform3.Location = New Point(140, 180)
        Platform4.Location = New Point(420, 40)
        Platform5.Location = New Point(230, -100)
        Platformmover.Stop()
        Platformmover.Stop()
        scrtimer.Stop()
        Gravitytimer.Stop()
        Jumpmover.Stop()
        LblGameStart.Visible = True
        Me.Focus()
        CaptainHop.Focus()
    End Sub
    Private Sub BtnRestart1_Click(sender As Object, e As EventArgs) Handles BtnRestart.Click
        ResetGame()
    End Sub

    Private Sub BtnExit1_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub BtnMainMenu1_Click(sender As Object, e As EventArgs) Handles BtnMainMenu.Click

    End Sub


End Class
