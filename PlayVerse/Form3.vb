
Public Class Form3
    Dim rand As New Random()
    Dim ballX As Integer
    Dim ballY As Integer
    Dim Hitcount As Integer = 0
    Dim speedX As Integer = 10
    Dim speedY1 As Integer = 2
    Dim speedY2 As Integer = 8
    Dim Highscore As Integer = My.Settings.PongLegendsHighscore
    Private Sub Upmover1_Tick(sender As Object, e As EventArgs) Handles Upmover1.Tick
        If (Paddle1.Location.Y >= 10) Then Paddle1.Top -= 8
    End Sub

    Private Sub Downmover1_Tick(sender As Object, e As EventArgs) Handles Downmover1.Tick
        If (Paddle1.Location.Y <= 565) Then Paddle1.Top += 8
    End Sub

    Private Sub Upmover2_Tick(sender As Object, e As EventArgs) Handles Upmover2.Tick
        If (Paddle2.Location.Y >= 10) Then Paddle2.Top -= 8
    End Sub

    Private Sub Downmover2_Tick(sender As Object, e As EventArgs) Handles Downmover2.Tick
        If (Paddle2.Location.Y <= 565) Then Paddle2.Top += 8
    End Sub
    Private Sub StopMovers()
        Upmover1.Stop()
        Upmover2.Stop()
        Downmover1.Stop()
        Downmover2.Stop()
        Ballmover.Stop()
    End Sub
    Private Sub StartMovers()
        Upmover1.Start()
        Downmover1.Start()
        Upmover2.Start()
        Downmover2.Start()
    End Sub
    Private Sub Form3_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If (PanelGameover.Visible = False) Then
            If (e.KeyCode = Keys.W) Then Upmover1.Start()
            If (e.KeyCode = Keys.S) Then Downmover1.Start()
            If (e.KeyCode = Keys.Up) Then Upmover2.Start()
            If (e.KeyCode = Keys.Down) Then Downmover2.Start()

            If LblGameStart.Visible = False Then
                If (e.KeyCode = Keys.Space) Then
                    PauseGame()
                End If
            End If
            If (LblGameStart.Visible = True) Then
                If e.KeyCode = Keys.Enter Then
                    Ballmover.Start()
                    LblGameStart.Visible = False
                End If
            End If
        End If
    End Sub

    Private Sub Form3_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        ' stop player 1 movement only if W or S is released

        If e.KeyCode = Keys.W Then Upmover1.Stop()
        If e.KeyCode = Keys.S Then Downmover1.Stop()
        If e.KeyCode = Keys.Up Then Upmover2.Stop()
        If e.KeyCode = Keys.Down Then Downmover2.Stop()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblHighscore.Text = "Highscore : " & Highscore
        '  ballX = rand.Next(6, 8) * If(rand.Next(0, 2) = 0, 1, -1)
        ballX = speedX * If(rand.Next(0, 2) = 0, 1, -1) 'speed =10
        ballY = rand.Next(speedY1, speedY2) * If(rand.Next(0, 2) = 0, 1, -1)
        Ball.Location = New Point(640, 350)

    End Sub


    Private Sub Ballmover_Tick(sender As Object, e As EventArgs) Handles Ballmover.Tick
        ' Ball movement
        Ball.Left += ballX
        Ball.Top += ballY

        ' Collision with top & bottom walls
        If Ball.Top <= 5 Or Ball.Top >= 680 Then
            ballY *= -1
        End If

        AdjustSpeed() 'ball ki speed adjust krne ke liye according to hitcount
        ' Collision with Paddle1
        If Ball.Bounds.IntersectsWith(Paddle1.Bounds) Then
            Hitcount += 1
            Score.Text = "Score: " & Hitcount
            ballX = speedX
            ballY = rand.Next(speedY1, speedY2) * Math.Sign(ballY)  ' Randomize Y axis speed + same Y direction mein jayegi
            '  prevents ball from sticking to the paddle1
            Ball.Left = Paddle1.Right + 15  'quick fix of ball stickig  to paddle1
        End If

        ' Collision with Paddle2 (right paddle)
        If Ball.Bounds.IntersectsWith(Paddle2.Bounds) Then
            Hitcount += 1
            Score.Text = "Score: " & Hitcount
            ballX = speedX
            ballX *= -1 'paddle2 se collide krne ke baad left mein move kregi
            ballY = rand.Next(speedY1, speedY2) * Math.Sign(ballY) ' Randomize Y axis speed + same Y direction mein jayegi

            'prevents ball from sticking to paddle2
            Ball.Left = Paddle2.Left - 20   'quick  fix of ball sticking to paddle2

        End If

        ' Check if ball went out of bounds (gameover condition)
        If Ball.Left <= 2 Or Ball.Left >= 1275 Then
            Gameover()
            Ballmover.Stop()
        End If
    End Sub

    Private Sub AdjustSpeed()
        Select Case Hitcount
            Case 0 To 6
                speedX = 10
                speedY1 = 3
                speedY2 = 6
            Case 7 To 13
                speedX = 12
                speedY1 = 3
                speedY2 = 7
            Case 14 To 20
                speedX = 14
                speedY1 = 4
                speedY2 = 8
            Case 21 To 27
                speedX = 16
                speedY1 = 6
                speedY2 = 9
            Case 28 To 34
                speedX = 18
                speedY1 = 8
                speedY2 = 11
            Case 35 To 41
                speedX = 20
                speedY1 = 9
                speedY2 = 12
            Case 42 To 48
                speedX = 22
                speedY1 = 10
                speedY2 = 13
            Case 49 To 55
                speedX = 24
                speedY1 = 11
                speedY2 = 14
            Case 56 To 62
                speedX = 26
                speedY1 = 13
                speedY2 = 16
            Case 63 To 70
                speedX = 28
                speedY1 = 16
                speedY2 = 20
        End Select
    End Sub
    Private Sub CheckHighscore()
        If Hitcount > Highscore Then
            Highscore = Hitcount
            LblHighscore.Text = "Highscore : " & Highscore
            My.Settings.PongLegendsHighscore = Highscore
            My.Settings.Save()
        End If
    End Sub
    Private Sub Gameover()
        CheckHighscore()
        PanelGameover.Visible = True
        PanelGameover.Location = New Point(490, 230)
        BtnRestart1.Focus()
        If (Ball.Left <= 2) Then
            WinState.Text = "Player 2 Wins!"
        ElseIf (Ball.Left >= 1275) Then
            WinState.Text = "Player 1 Wins!"
        End If
        StopMovers()
    End Sub
    Private Sub BtnExit1_Click(sender As Object, e As EventArgs) Handles BtnExit1.Click
        CheckHighscore()
        Form7.Show()
        Me.Close()
    End Sub

    Private Sub BtnMainMenu1_Click(sender As Object, e As EventArgs) Handles BtnMainMenu1.Click, BtnMainMenu2.Click
        CheckHighscore()
        Form4.Show()
        Me.Close()
    End Sub
    Private Sub PauseGame()

        PanelPause.Visible = Not PanelPause.Visible
            If (PanelPause.Visible = True) Then
                PanelPause.Location = New Point(490, 230)
                BtnResume.Focus()
                StopMovers()
                Ballmover.Stop()
            ElseIf (PanelPause.Visible = False) Then
                ResumeGame()
            End If

    End Sub
    Private Sub BtnResume_Click(sender As Object, e As EventArgs) Handles BtnResume.Click
        ResumeGame()
    End Sub
    Private Sub ResumeGame()
        PanelPause.Visible = False
        Ballmover.Start()
        Me.Focus()
    End Sub
    Private Sub BtnRestart_Click(sender As Object, e As EventArgs) Handles BtnRestart1.Click, BtnRestart2.Click
        'RELOADS WHOLE GAME FROM FORM LOAD 
        CheckHighscore()
        Hitcount = 0
        LblGameStart.Visible = True
        Me.Controls.Clear() 'form ke jo controls hai unko clear krega. why?-becuz jitne bhi controls ..
        '                    mein dynamic changes aaye such as picturebox movements or score label..
        '                   unko remove krna neccessary becuz jb restart krenge to vo sb apni last position 
        '                   pr bhi dikhenge and jidhar design mode mein place kiya tha udhar bhi dikhenge
        InitializeComponent() 'calling initializecomponent procedure
        'when u start designing a form, Visual Studio automatically makes a procedure of 
        'initializecomponents and stores every design codes in form1.designer.vb

        Form3_Load(e, e) ' it will load the events of form , for instance , array of roadlines pictureboxes..
        ' they are inside form1_load procedure and only works when the form is loaded
        Me.Focus()

    End Sub

    Private Sub PanelPongScreen_Paint(sender As Object, e As PaintEventArgs) Handles PanelPongScreen.Paint

    End Sub
End Class