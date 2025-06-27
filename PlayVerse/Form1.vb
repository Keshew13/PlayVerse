Public Class Form1
    Dim speed As Single
    Dim C_speed As Single
    Dim Roadlines() As PictureBox
    Dim rand As New Random()
    Dim score As Integer
    Dim highscore As Integer = My.Settings.XtremeHighScore
    Dim showspeed As Integer
    Dim minX1 As Integer = 88
    Dim maxX1 As Integer = 132
    Dim minY1 As Integer = -1500
    Dim maxY1 As Integer = -600

    Dim minX2 As Integer = 197
    Dim maxX2 As Integer = 240
    Dim minY2 As Integer = -1500
    Dim maxY2 As Integer = -500

    Dim minX3 As Integer = 303
    Dim maxX3 As Integer = 349
    Dim minY3 As Integer = -900
    Dim maxY3 As Integer = -300

    Dim minX4 As Integer = 414
    Dim maxX4 As Integer = 453
    Dim minY4 As Integer = -1000
    Dim maxY4 As Integer = -300

    Dim bikeHitboxes() As PictureBox

    'Dim tf_esc As Boolean = False

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LblHighScore.Text = "HighScore: " & My.Settings.XtremeHighScore

        Me.Location = New Point(0, 0)
        Me.Size = New Size(1300, 740)
        Me.MaximumSize = New Size(1920, 1080)

        'array of roadlines
        Roadlines = {Roadline1, Roadline2, Roadline3, Roadline4, Roadline5, Roadline6,
             Roadline7, Roadline8, Roadline9, Roadline10}
        'array of bikehitboxes 
        bikeHitboxes = {BikeHitbox1, BikeHitbox2}

        Enemy1.Location = New Point(rand.Next(minX1, maxX1), rand.Next(-1350, -1100))
        Hitbox1.Location = Enemy1.Location + New Point(6, 6)
        enemy2.Location = New Point(rand.Next(minX2, maxX2), rand.Next(-1700, -1600))
        Hitbox2.Location = enemy2.Location + New Point(6, 6)
        enemy3.Location = New Point(rand.Next(minX3, maxX3), rand.Next(-350, -160))
        Hitbox3.Location = enemy3.Location + New Point(6, 6)
        enemy4.Location = New Point(rand.Next(minX4, maxX4), rand.Next(-850, -500))
        Hitbox4.Location = enemy4.Location + New Point(6, 6)
        bike.Location = New Point(324, 582)             'bike position and hitboxes pos.
        BikeHitbox1.Location = bike.Location + New Point(9, 2)
        BikeHitbox2.Location = bike.Location + New Point(2, 18)
        LblGameOver.Visible = False
        ' PanelPause.Visible = False
        PanelGameover.Location = New Point(94, 90)
        PanelGameover.Size = New Size(406, 306)
        PanelPause.Location = New Point(94, 90)
        PanelPause.Size = New Size(406, 306)
        PanelGameScreen.Location = New Point(340, 0)
    End Sub

    Private Sub Scr_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Scr.Tick
        score += 1
        Score_count.Text = "Score: " & score
        Final_Score2.Text = "Your " & Score_count.Text
        If score > highscore Then
            LblHighScore.Text = "HighScore: " & score
            My.Settings.XtremeHighScore = score
            My.Settings.Save()
        End If
    End Sub

    Private Sub Roadmover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Roadmover.Tick

        speed = 2 + (score \ 20)
        C_speed = 1 + (score / 50)

        If (score <= 5) Then
            Speed_test.Text = "Speed:10km/h"
        Else
            Select Case (score)
                Case 5 To 20
                    showspeed = 20
                Case 21 To 40
                    showspeed = 30
                Case 41 To 60
                    showspeed = 40
                Case 61 To 80
                    showspeed = 50
                Case 81 To 100
                    showspeed = 60
                Case 101 To 120
                    showspeed = 70
                Case 121 To 140
                    showspeed = 80
                Case 141 To 160
                    showspeed = 90
                Case 161 To 190
                    showspeed = 100
                Case 191 To 220
                    showspeed = 110
                Case 221 To 250
                    showspeed = 120

            End Select
            Speed_test.Text = "Speed:" & showspeed & "km/h"  'speed-o-meter
        End If

        For Each road As PictureBox In Roadlines
            'speed of road
            road.Top += speed * 0.8
            If road.Top >= Me.Height Then
                road.Top = -road.Height
                'picturebox aka roadline height is 84 and if roadline crosses the height of form then...
                'roadline.top will be set as -84 in location of form which makes a loop as road is never ending
            End If
        Next

        Collision()

    End Sub
    Private Sub StartTimers()
        Roadmover.Start()
        enemymover.Start()
        Scr.Start()

    End Sub

    Private Sub StopTimers()
        Roadmover.Stop()     'road broken lines strip move krna bnd krdegi
        enemymover.Stop()   'enemycars ki movement stop ho jayegi 
        Scr.Stop()          'score counting stop hogi
        StopMovers()        'left,right,up,down,sleft,sright stop hoga
    End Sub
    Private Sub StopMovers()
        Leftmover.Stop()
        Rightmover.Stop()
        Upmover.Stop()
        Downmover.Stop()
        slow_left.Stop()
        slow_right.Stop()
    End Sub

    Private Sub GameOver()
        LblGameOver.Visible = True      'gameover wala text
        PanelGameover.Visible = True
        StopTimers()        'road,scr,enemymover stop hoga
        Final_Score1.Text = "Your " & Score_count.Text
        BtnRestart1.Focus()
        'me.opacity += 0.1  fade in effect
        'me.opacity -= 0.1 fade out effect

    End Sub

    Private Sub Collision()
        For Each hitbox As PictureBox In bikeHitboxes
            If (hitbox.Bounds.IntersectsWith(Hitbox1.Bounds)) OrElse    'orElse ka use,becuz agr koi bhi condition true hogi , to vo immidiately statement run krega without checking all condition
       hitbox.Bounds.IntersectsWith(Hitbox2.Bounds) OrElse
       hitbox.Bounds.IntersectsWith(Hitbox3.Bounds) OrElse
       hitbox.Bounds.IntersectsWith(Hitbox4.Bounds) Then
                GameOver()
                Exit For
            End If
        Next
    End Sub
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Resize
        If (Me.WindowState = FormWindowState.Minimized) Then
            StopTimers()
        ElseIf (Me.WindowState = FormWindowState.Normal Or Me.WindowState = FormWindowState.Maximized) Then
            StartTimers()
        End If
    End Sub
    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (PanelPause.Visible = False And PanelGameover.Visible = False) Then
            If (e.KeyCode = Keys.Oemcomma Or e.KeyCode = Keys.Q) Then slow_left.Start()
            If (e.KeyCode = Keys.OemPeriod Or e.KeyCode = Keys.E) Then slow_right.Start()
            If (e.KeyCode = Keys.Up Or e.KeyCode = Keys.W) Then Upmover.Start()
            If (e.KeyCode = Keys.Down Or e.KeyCode = Keys.S) Then Downmover.Start()
            If (e.KeyCode = Keys.Right Or e.KeyCode = Keys.D) Then Rightmover.Start()
            If (e.KeyCode = Keys.Left Or e.KeyCode = Keys.A) Then Leftmover.Start()
        End If
        If (e.KeyCode = Keys.Space) Then 'pause game
            PanelPause.Visible = Not PanelPause.Visible
            If (PanelPause.Visible = True) Then
                BtnResume.Focus()
                StopTimers()

            ElseIf (PanelPause.Visible = False) Then
                StartTimers()
                Me.Focus()
            End If
        End If

    End Sub

    Private Sub Form1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        StopMovers()
    End Sub

    '___________________________________________________________________________________________
    'Bike Movers

    Private Sub Upmover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Upmover.Tick
        If (bike.Location.Y > 20) Then
            bike.Top -= 5
            BikeHitbox1.Top -= 5
            BikeHitbox2.Top -= 5
        End If
    End Sub
    Private Sub Downmover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Downmover.Tick
        If (bike.Location.Y < 580) Then
            bike.Top += 5
            BikeHitbox1.Top += 5
            BikeHitbox2.Top += 5
        End If
    End Sub
    Private Sub Leftmover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Leftmover.Tick
        If (bike.Location.X > 92) Then
            bike.Left -= 5
            BikeHitbox1.Left -= 5
            BikeHitbox2.Left -= 5
        End If
    End Sub
    Private Sub Rightmover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Rightmover.Tick
        If (bike.Location.X < 470) Then
            bike.Left += 5
            BikeHitbox1.Left += 5
            BikeHitbox2.Left += 5

        End If
    End Sub
    Private Sub Slow_left_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slow_left.Tick
        If (bike.Location.X > 92) Then
            bike.Left -= 1
            BikeHitbox1.Left -= 1
            BikeHitbox2.Left -= 1
        End If
    End Sub
    Private Sub Slow_right_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slow_right.Tick
        If (bike.Location.X < 470) Then
            bike.Left += 1
            BikeHitbox1.Left += 1
            BikeHitbox2.Left += 1
        End If
    End Sub

    '____________________________________________________________________________________________
    'enemy movers

    Private Sub Enemymover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles enemymover.Tick
        Enemy1.Top += C_speed * 2.2
        Hitbox1.Top += C_speed * 2.2
        If (Enemy1.Top >= Me.Height) Then
            Enemy1.Location = New Point(rand.Next(minX1, maxX1), rand.Next(minY1, maxY1))
            Hitbox1.Location = Enemy1.Location + New Point(6, 6)
        End If

        enemy2.Top += C_speed * 2
        Hitbox2.Top += C_speed * 2
        If (enemy2.Top >= Me.Height) Then
            enemy2.Location = New Point(rand.Next(minX2, maxX2), rand.Next(minY2, maxY2))
            Hitbox2.Location = enemy2.Location + New Point(6, 6)
        End If

        enemy3.Top += C_speed * 0.7
        Hitbox3.Top += C_speed * 0.7
        If (enemy3.Top >= Me.Height) Then
            enemy3.Location = New Point(rand.Next(minX3, maxX3), rand.Next(minY3, maxY3))
            Hitbox3.Location = enemy3.Location + New Point(6, 6)
        End If

        enemy4.Top += C_speed * 0.8
        Hitbox4.Top += C_speed * 0.8
        If (enemy4.Top >= Me.Height) Then
            enemy4.Location = New Point(rand.Next(minX4, maxX4), rand.Next(minY4, maxY4))
            Hitbox4.Location = enemy4.Location + New Point(7, 6)
        End If
    End Sub

    '___________________________________________________________________________________________
    'Button Restart,Exit,Resume,MainMenu
    Private Sub ResetGame()
        ' Check and save high score
        If score > highscore Then
            highscore = score
            My.Settings.XtremeHighScore = highscore
            LblHighScore.Text = "HighScore: " & My.Settings.XtremeHighScore
            My.Settings.Save()
        End If

        ' Reset score and UI
        score = 0
        Score_count.Text = "Score: 0"
        Final_Score1.Text = ""
        Final_Score2.Text = ""
        LblGameOver.Visible = False
        PanelGameover.Visible = False
        PanelPause.Visible = False

        ' Reset player and enemy positions
        bike.Location = New Point(324, 582)
        BikeHitbox1.Location = bike.Location + New Point(9, 2)
        BikeHitbox2.Location = bike.Location + New Point(2, 18)

        Enemy1.Location = New Point(rand.Next(minX1, maxX1), rand.Next(minY1, maxY1))
        Hitbox1.Location = Enemy1.Location + New Point(6, 6)

        enemy2.Location = New Point(rand.Next(minX2, maxX2), rand.Next(minY2, maxY2))
        Hitbox2.Location = enemy2.Location + New Point(6, 6)

        enemy3.Location = New Point(rand.Next(minX3, maxX3), rand.Next(minY3, maxY3))
        Hitbox3.Location = enemy3.Location + New Point(6, 6)

        enemy4.Location = New Point(rand.Next(minX4, maxX4), rand.Next(minY4, maxY4))
        Hitbox4.Location = enemy4.Location + New Point(7, 6)

        ' Restart timers
        StartTimers()
        Me.Focus()
    End Sub

    Private Sub Restart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRestart1.Click, BtnRestart2.Click
        ResetGame()
    End Sub
    Private Sub Exit_btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit1.Click
        Form7.Show()
        Me.Close()
    End Sub


    Private Sub BtnResume_Click(sender As Object, e As EventArgs) Handles BtnResume.Click
        PanelPause.Visible = False
        StartTimers()
        Me.Focus()
    End Sub

    Private Sub BtnMainMenu_Click(sender As Object, e As EventArgs) Handles BtnMainMenu1.Click, BtnMainMenu2.Click
        Form2.Show()
        Me.Close()
    End Sub

End Class