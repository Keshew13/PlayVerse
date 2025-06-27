<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Roadmover = New System.Windows.Forms.Timer(Me.components)
        Me.Leftmover = New System.Windows.Forms.Timer(Me.components)
        Me.Rightmover = New System.Windows.Forms.Timer(Me.components)
        Me.enemymover = New System.Windows.Forms.Timer(Me.components)
        Me.LblGameOver = New System.Windows.Forms.Label()
        Me.Score_count = New System.Windows.Forms.Label()
        Me.Scr = New System.Windows.Forms.Timer(Me.components)
        Me.BtnRestart1 = New System.Windows.Forms.Button()
        Me.BtnExit1 = New System.Windows.Forms.Button()
        Me.Speed_test = New System.Windows.Forms.Label()
        Me.slow_left = New System.Windows.Forms.Timer(Me.components)
        Me.slow_right = New System.Windows.Forms.Timer(Me.components)
        Me.Upmover = New System.Windows.Forms.Timer(Me.components)
        Me.Downmover = New System.Windows.Forms.Timer(Me.components)
        Me.PanelGameover = New System.Windows.Forms.Panel()
        Me.Final_Score1 = New System.Windows.Forms.Label()
        Me.BtnMainMenu1 = New System.Windows.Forms.Button()
        Me.PanelBorder2 = New System.Windows.Forms.PictureBox()
        Me.PanelDashBoard = New System.Windows.Forms.Panel()
        Me.LblHighScore = New System.Windows.Forms.Label()
        Me.PanelGameScreen = New System.Windows.Forms.Panel()
        Me.PanelPause = New System.Windows.Forms.Panel()
        Me.Final_Score2 = New System.Windows.Forms.Label()
        Me.LblPause = New System.Windows.Forms.Label()
        Me.BtnMainMenu2 = New System.Windows.Forms.Button()
        Me.BtnRestart2 = New System.Windows.Forms.Button()
        Me.BtnResume = New System.Windows.Forms.Button()
        Me.PanelBorder1 = New System.Windows.Forms.PictureBox()
        Me.bike = New System.Windows.Forms.PictureBox()
        Me.Enemy1 = New System.Windows.Forms.PictureBox()
        Me.enemy2 = New System.Windows.Forms.PictureBox()
        Me.enemy3 = New System.Windows.Forms.PictureBox()
        Me.enemy4 = New System.Windows.Forms.PictureBox()
        Me.grass2 = New System.Windows.Forms.PictureBox()
        Me.grass1 = New System.Windows.Forms.PictureBox()
        Me.Hitbox2 = New System.Windows.Forms.PictureBox()
        Me.Hitbox1 = New System.Windows.Forms.PictureBox()
        Me.Hitbox3 = New System.Windows.Forms.PictureBox()
        Me.Hitbox4 = New System.Windows.Forms.PictureBox()
        Me.Roadline9 = New System.Windows.Forms.PictureBox()
        Me.Roadline7 = New System.Windows.Forms.PictureBox()
        Me.Roadline5 = New System.Windows.Forms.PictureBox()
        Me.Roadline3 = New System.Windows.Forms.PictureBox()
        Me.Roadline1 = New System.Windows.Forms.PictureBox()
        Me.Roadline6 = New System.Windows.Forms.PictureBox()
        Me.Roadline8 = New System.Windows.Forms.PictureBox()
        Me.Roadline2 = New System.Windows.Forms.PictureBox()
        Me.Roadline4 = New System.Windows.Forms.PictureBox()
        Me.Roadline10 = New System.Windows.Forms.PictureBox()
        Me.Lstrip = New System.Windows.Forms.PictureBox()
        Me.Rstrip = New System.Windows.Forms.PictureBox()
        Me.MidStrip = New System.Windows.Forms.PictureBox()
        Me.BikeHitbox1 = New System.Windows.Forms.PictureBox()
        Me.BikeHitbox2 = New System.Windows.Forms.PictureBox()
        Me.PanelGameover.SuspendLayout()
        CType(Me.PanelBorder2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDashBoard.SuspendLayout()
        Me.PanelGameScreen.SuspendLayout()
        Me.PanelPause.SuspendLayout()
        CType(Me.PanelBorder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bike, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemy4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grass2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grass1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hitbox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hitbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hitbox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hitbox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Roadline9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Roadline7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Roadline5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Roadline3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Roadline1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Roadline6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Roadline8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Roadline2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Roadline4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Roadline10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Lstrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Rstrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MidStrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BikeHitbox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BikeHitbox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Roadmover
        '
        Me.Roadmover.Enabled = True
        Me.Roadmover.Interval = 10
        '
        'Leftmover
        '
        Me.Leftmover.Interval = 10
        '
        'Rightmover
        '
        Me.Rightmover.Interval = 10
        '
        'enemymover
        '
        Me.enemymover.Enabled = True
        Me.enemymover.Interval = 10
        '
        'LblGameOver
        '
        Me.LblGameOver.AutoSize = True
        Me.LblGameOver.BackColor = System.Drawing.SystemColors.InfoText
        Me.LblGameOver.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGameOver.ForeColor = System.Drawing.Color.Red
        Me.LblGameOver.Location = New System.Drawing.Point(44, 30)
        Me.LblGameOver.Name = "LblGameOver"
        Me.LblGameOver.Size = New System.Drawing.Size(315, 80)
        Me.LblGameOver.TabIndex = 4
        Me.LblGameOver.Text = "GAME OVER"
        Me.LblGameOver.Visible = False
        '
        'Score_count
        '
        Me.Score_count.AutoSize = True
        Me.Score_count.BackColor = System.Drawing.Color.Transparent
        Me.Score_count.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score_count.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Score_count.Location = New System.Drawing.Point(12, 39)
        Me.Score_count.Name = "Score_count"
        Me.Score_count.Size = New System.Drawing.Size(91, 30)
        Me.Score_count.TabIndex = 4
        Me.Score_count.Text = "Score: 1"
        '
        'Scr
        '
        Me.Scr.Enabled = True
        Me.Scr.Interval = 1000
        '
        'BtnRestart1
        '
        Me.BtnRestart1.BackColor = System.Drawing.Color.White
        Me.BtnRestart1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestart1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRestart1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestart1.ForeColor = System.Drawing.Color.Black
        Me.BtnRestart1.Location = New System.Drawing.Point(121, 147)
        Me.BtnRestart1.Name = "BtnRestart1"
        Me.BtnRestart1.Size = New System.Drawing.Size(170, 40)
        Me.BtnRestart1.TabIndex = 0
        Me.BtnRestart1.Text = "&Restart"
        Me.BtnRestart1.UseVisualStyleBackColor = False
        '
        'BtnExit1
        '
        Me.BtnExit1.BackColor = System.Drawing.Color.White
        Me.BtnExit1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExit1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit1.ForeColor = System.Drawing.Color.Black
        Me.BtnExit1.Location = New System.Drawing.Point(121, 242)
        Me.BtnExit1.Name = "BtnExit1"
        Me.BtnExit1.Size = New System.Drawing.Size(170, 40)
        Me.BtnExit1.TabIndex = 2
        Me.BtnExit1.Text = "&Exit Game"
        Me.BtnExit1.UseVisualStyleBackColor = False
        '
        'Speed_test
        '
        Me.Speed_test.AutoSize = True
        Me.Speed_test.BackColor = System.Drawing.Color.Transparent
        Me.Speed_test.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Speed_test.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Speed_test.Location = New System.Drawing.Point(12, 11)
        Me.Speed_test.Name = "Speed_test"
        Me.Speed_test.Size = New System.Drawing.Size(156, 30)
        Me.Speed_test.TabIndex = 4
        Me.Speed_test.Text = "Speed:10km/h"
        '
        'slow_left
        '
        Me.slow_left.Interval = 10
        '
        'slow_right
        '
        Me.slow_right.Interval = 10
        '
        'Upmover
        '
        Me.Upmover.Interval = 10
        '
        'Downmover
        '
        Me.Downmover.Interval = 10
        '
        'PanelGameover
        '
        Me.PanelGameover.AutoSize = True
        Me.PanelGameover.BackColor = System.Drawing.Color.White
        Me.PanelGameover.Controls.Add(Me.Final_Score1)
        Me.PanelGameover.Controls.Add(Me.BtnExit1)
        Me.PanelGameover.Controls.Add(Me.BtnMainMenu1)
        Me.PanelGameover.Controls.Add(Me.BtnRestart1)
        Me.PanelGameover.Controls.Add(Me.LblGameOver)
        Me.PanelGameover.Controls.Add(Me.PanelBorder2)
        Me.PanelGameover.Location = New System.Drawing.Point(573, 654)
        Me.PanelGameover.Name = "PanelGameover"
        Me.PanelGameover.Size = New System.Drawing.Size(406, 306)
        Me.PanelGameover.TabIndex = 0
        Me.PanelGameover.Visible = False
        '
        'Final_Score1
        '
        Me.Final_Score1.AutoSize = True
        Me.Final_Score1.BackColor = System.Drawing.Color.Black
        Me.Final_Score1.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Final_Score1.ForeColor = System.Drawing.Color.White
        Me.Final_Score1.Location = New System.Drawing.Point(130, 110)
        Me.Final_Score1.Name = "Final_Score1"
        Me.Final_Score1.Size = New System.Drawing.Size(101, 23)
        Me.Final_Score1.TabIndex = 3
        Me.Final_Score1.Text = "Your Score :"
        '
        'BtnMainMenu1
        '
        Me.BtnMainMenu1.BackColor = System.Drawing.Color.White
        Me.BtnMainMenu1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMainMenu1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnMainMenu1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMainMenu1.ForeColor = System.Drawing.Color.Black
        Me.BtnMainMenu1.Location = New System.Drawing.Point(121, 194)
        Me.BtnMainMenu1.Name = "BtnMainMenu1"
        Me.BtnMainMenu1.Size = New System.Drawing.Size(170, 40)
        Me.BtnMainMenu1.TabIndex = 1
        Me.BtnMainMenu1.Text = "&Main Menu"
        Me.BtnMainMenu1.UseVisualStyleBackColor = False
        '
        'PanelBorder2
        '
        Me.PanelBorder2.BackColor = System.Drawing.Color.Black
        Me.PanelBorder2.Location = New System.Drawing.Point(3, 3)
        Me.PanelBorder2.Name = "PanelBorder2"
        Me.PanelBorder2.Size = New System.Drawing.Size(400, 300)
        Me.PanelBorder2.TabIndex = 8
        Me.PanelBorder2.TabStop = False
        '
        'PanelDashBoard
        '
        Me.PanelDashBoard.BackColor = System.Drawing.Color.Black
        Me.PanelDashBoard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelDashBoard.Controls.Add(Me.Score_count)
        Me.PanelDashBoard.Controls.Add(Me.LblHighScore)
        Me.PanelDashBoard.Controls.Add(Me.Speed_test)
        Me.PanelDashBoard.Location = New System.Drawing.Point(-1, 0)
        Me.PanelDashBoard.Name = "PanelDashBoard"
        Me.PanelDashBoard.Size = New System.Drawing.Size(213, 126)
        Me.PanelDashBoard.TabIndex = 8
        '
        'LblHighScore
        '
        Me.LblHighScore.AutoSize = True
        Me.LblHighScore.BackColor = System.Drawing.Color.Transparent
        Me.LblHighScore.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHighScore.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblHighScore.Location = New System.Drawing.Point(11, 69)
        Me.LblHighScore.Name = "LblHighScore"
        Me.LblHighScore.Size = New System.Drawing.Size(139, 30)
        Me.LblHighScore.TabIndex = 5
        Me.LblHighScore.Text = "HighScore: 0"
        '
        'PanelGameScreen
        '
        Me.PanelGameScreen.BackColor = System.Drawing.Color.Gray
        Me.PanelGameScreen.Controls.Add(Me.PanelPause)
        Me.PanelGameScreen.Controls.Add(Me.PanelGameover)
        Me.PanelGameScreen.Controls.Add(Me.bike)
        Me.PanelGameScreen.Controls.Add(Me.Enemy1)
        Me.PanelGameScreen.Controls.Add(Me.enemy2)
        Me.PanelGameScreen.Controls.Add(Me.enemy3)
        Me.PanelGameScreen.Controls.Add(Me.enemy4)
        Me.PanelGameScreen.Controls.Add(Me.grass2)
        Me.PanelGameScreen.Controls.Add(Me.grass1)
        Me.PanelGameScreen.Controls.Add(Me.Hitbox2)
        Me.PanelGameScreen.Controls.Add(Me.Hitbox1)
        Me.PanelGameScreen.Controls.Add(Me.Hitbox3)
        Me.PanelGameScreen.Controls.Add(Me.Hitbox4)
        Me.PanelGameScreen.Controls.Add(Me.Roadline9)
        Me.PanelGameScreen.Controls.Add(Me.Roadline7)
        Me.PanelGameScreen.Controls.Add(Me.Roadline5)
        Me.PanelGameScreen.Controls.Add(Me.Roadline3)
        Me.PanelGameScreen.Controls.Add(Me.Roadline1)
        Me.PanelGameScreen.Controls.Add(Me.Roadline6)
        Me.PanelGameScreen.Controls.Add(Me.Roadline8)
        Me.PanelGameScreen.Controls.Add(Me.Roadline2)
        Me.PanelGameScreen.Controls.Add(Me.Roadline4)
        Me.PanelGameScreen.Controls.Add(Me.Roadline10)
        Me.PanelGameScreen.Controls.Add(Me.Lstrip)
        Me.PanelGameScreen.Controls.Add(Me.Rstrip)
        Me.PanelGameScreen.Controls.Add(Me.MidStrip)
        Me.PanelGameScreen.Controls.Add(Me.BikeHitbox1)
        Me.PanelGameScreen.Controls.Add(Me.BikeHitbox2)
        Me.PanelGameScreen.Location = New System.Drawing.Point(355, 0)
        Me.PanelGameScreen.Name = "PanelGameScreen"
        Me.PanelGameScreen.Size = New System.Drawing.Size(600, 700)
        Me.PanelGameScreen.TabIndex = 9
        '
        'PanelPause
        '
        Me.PanelPause.AutoSize = True
        Me.PanelPause.BackColor = System.Drawing.Color.White
        Me.PanelPause.Controls.Add(Me.Final_Score2)
        Me.PanelPause.Controls.Add(Me.LblPause)
        Me.PanelPause.Controls.Add(Me.BtnMainMenu2)
        Me.PanelPause.Controls.Add(Me.BtnRestart2)
        Me.PanelPause.Controls.Add(Me.BtnResume)
        Me.PanelPause.Controls.Add(Me.PanelBorder1)
        Me.PanelPause.Location = New System.Drawing.Point(576, 135)
        Me.PanelPause.Name = "PanelPause"
        Me.PanelPause.Size = New System.Drawing.Size(406, 306)
        Me.PanelPause.TabIndex = 1
        Me.PanelPause.Visible = False
        '
        'Final_Score2
        '
        Me.Final_Score2.AutoSize = True
        Me.Final_Score2.BackColor = System.Drawing.Color.Black
        Me.Final_Score2.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Final_Score2.ForeColor = System.Drawing.Color.White
        Me.Final_Score2.Location = New System.Drawing.Point(127, 118)
        Me.Final_Score2.Name = "Final_Score2"
        Me.Final_Score2.Size = New System.Drawing.Size(101, 23)
        Me.Final_Score2.TabIndex = 4
        Me.Final_Score2.Text = "Your Score :"
        '
        'LblPause
        '
        Me.LblPause.AutoSize = True
        Me.LblPause.BackColor = System.Drawing.SystemColors.InfoText
        Me.LblPause.Font = New System.Drawing.Font("Impact", 60.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPause.ForeColor = System.Drawing.Color.Red
        Me.LblPause.Location = New System.Drawing.Point(67, 23)
        Me.LblPause.Name = "LblPause"
        Me.LblPause.Size = New System.Drawing.Size(282, 98)
        Me.LblPause.TabIndex = 5
        Me.LblPause.Text = "PAUSED"
        Me.LblPause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BtnMainMenu2
        '
        Me.BtnMainMenu2.BackColor = System.Drawing.Color.White
        Me.BtnMainMenu2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMainMenu2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnMainMenu2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMainMenu2.ForeColor = System.Drawing.Color.Black
        Me.BtnMainMenu2.Location = New System.Drawing.Point(118, 243)
        Me.BtnMainMenu2.Name = "BtnMainMenu2"
        Me.BtnMainMenu2.Size = New System.Drawing.Size(170, 40)
        Me.BtnMainMenu2.TabIndex = 2
        Me.BtnMainMenu2.Text = "&Main Menu"
        Me.BtnMainMenu2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnMainMenu2.UseVisualStyleBackColor = False
        '
        'BtnRestart2
        '
        Me.BtnRestart2.BackColor = System.Drawing.Color.White
        Me.BtnRestart2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestart2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRestart2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestart2.ForeColor = System.Drawing.Color.Black
        Me.BtnRestart2.Location = New System.Drawing.Point(118, 197)
        Me.BtnRestart2.Name = "BtnRestart2"
        Me.BtnRestart2.Size = New System.Drawing.Size(170, 40)
        Me.BtnRestart2.TabIndex = 1
        Me.BtnRestart2.Text = "&Restart"
        Me.BtnRestart2.UseVisualStyleBackColor = False
        '
        'BtnResume
        '
        Me.BtnResume.BackColor = System.Drawing.Color.White
        Me.BtnResume.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnResume.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnResume.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnResume.ForeColor = System.Drawing.Color.Black
        Me.BtnResume.Location = New System.Drawing.Point(118, 151)
        Me.BtnResume.Name = "BtnResume"
        Me.BtnResume.Size = New System.Drawing.Size(170, 40)
        Me.BtnResume.TabIndex = 0
        Me.BtnResume.Text = "&Resume"
        Me.BtnResume.UseVisualStyleBackColor = False
        '
        'PanelBorder1
        '
        Me.PanelBorder1.BackColor = System.Drawing.Color.Black
        Me.PanelBorder1.Location = New System.Drawing.Point(3, 3)
        Me.PanelBorder1.Name = "PanelBorder1"
        Me.PanelBorder1.Size = New System.Drawing.Size(400, 300)
        Me.PanelBorder1.TabIndex = 7
        Me.PanelBorder1.TabStop = False
        '
        'bike
        '
        Me.bike.BackColor = System.Drawing.Color.Transparent
        Me.bike.Image = CType(resources.GetObject("bike.Image"), System.Drawing.Image)
        Me.bike.Location = New System.Drawing.Point(324, 582)
        Me.bike.Name = "bike"
        Me.bike.Size = New System.Drawing.Size(30, 80)
        Me.bike.TabIndex = 1
        Me.bike.TabStop = False
        '
        'Enemy1
        '
        Me.Enemy1.BackColor = System.Drawing.Color.Transparent
        Me.Enemy1.Image = Global.PlayVerse.My.Resources.Resources.Enemy1
        Me.Enemy1.Location = New System.Drawing.Point(106, 176)
        Me.Enemy1.Name = "Enemy1"
        Me.Enemy1.Size = New System.Drawing.Size(55, 110)
        Me.Enemy1.TabIndex = 2
        Me.Enemy1.TabStop = False
        '
        'enemy2
        '
        Me.enemy2.BackColor = System.Drawing.Color.Transparent
        Me.enemy2.Image = Global.PlayVerse.My.Resources.Resources.Enemy2
        Me.enemy2.Location = New System.Drawing.Point(221, 71)
        Me.enemy2.Name = "enemy2"
        Me.enemy2.Size = New System.Drawing.Size(55, 110)
        Me.enemy2.TabIndex = 2
        Me.enemy2.TabStop = False
        '
        'enemy3
        '
        Me.enemy3.BackColor = System.Drawing.Color.Transparent
        Me.enemy3.Image = Global.PlayVerse.My.Resources.Resources.Enemy3
        Me.enemy3.Location = New System.Drawing.Point(324, 94)
        Me.enemy3.Name = "enemy3"
        Me.enemy3.Size = New System.Drawing.Size(55, 110)
        Me.enemy3.TabIndex = 2
        Me.enemy3.TabStop = False
        '
        'enemy4
        '
        Me.enemy4.BackColor = System.Drawing.Color.Transparent
        Me.enemy4.Image = Global.PlayVerse.My.Resources.Resources.Enemy4
        Me.enemy4.Location = New System.Drawing.Point(421, 105)
        Me.enemy4.Name = "enemy4"
        Me.enemy4.Size = New System.Drawing.Size(55, 110)
        Me.enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.enemy4.TabIndex = 7
        Me.enemy4.TabStop = False
        '
        'grass2
        '
        Me.grass2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grass2.Location = New System.Drawing.Point(545, 0)
        Me.grass2.Name = "grass2"
        Me.grass2.Size = New System.Drawing.Size(55, 700)
        Me.grass2.TabIndex = 5
        Me.grass2.TabStop = False
        '
        'grass1
        '
        Me.grass1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.grass1.Location = New System.Drawing.Point(0, 0)
        Me.grass1.Name = "grass1"
        Me.grass1.Size = New System.Drawing.Size(50, 700)
        Me.grass1.TabIndex = 0
        Me.grass1.TabStop = False
        '
        'Hitbox2
        '
        Me.Hitbox2.BackColor = System.Drawing.Color.White
        Me.Hitbox2.Location = New System.Drawing.Point(227, 77)
        Me.Hitbox2.Name = "Hitbox2"
        Me.Hitbox2.Size = New System.Drawing.Size(43, 97)
        Me.Hitbox2.TabIndex = 9
        Me.Hitbox2.TabStop = False
        '
        'Hitbox1
        '
        Me.Hitbox1.BackColor = System.Drawing.Color.White
        Me.Hitbox1.Location = New System.Drawing.Point(112, 182)
        Me.Hitbox1.Name = "Hitbox1"
        Me.Hitbox1.Size = New System.Drawing.Size(43, 97)
        Me.Hitbox1.TabIndex = 8
        Me.Hitbox1.TabStop = False
        '
        'Hitbox3
        '
        Me.Hitbox3.BackColor = System.Drawing.Color.White
        Me.Hitbox3.Location = New System.Drawing.Point(330, 101)
        Me.Hitbox3.Name = "Hitbox3"
        Me.Hitbox3.Size = New System.Drawing.Size(44, 100)
        Me.Hitbox3.TabIndex = 10
        Me.Hitbox3.TabStop = False
        '
        'Hitbox4
        '
        Me.Hitbox4.BackColor = System.Drawing.Color.White
        Me.Hitbox4.Location = New System.Drawing.Point(428, 113)
        Me.Hitbox4.Name = "Hitbox4"
        Me.Hitbox4.Size = New System.Drawing.Size(43, 97)
        Me.Hitbox4.TabIndex = 11
        Me.Hitbox4.TabStop = False
        '
        'Roadline9
        '
        Me.Roadline9.BackColor = System.Drawing.Color.White
        Me.Roadline9.Location = New System.Drawing.Point(186, 680)
        Me.Roadline9.Name = "Roadline9"
        Me.Roadline9.Size = New System.Drawing.Size(10, 90)
        Me.Roadline9.TabIndex = 0
        Me.Roadline9.TabStop = False
        '
        'Roadline7
        '
        Me.Roadline7.BackColor = System.Drawing.Color.White
        Me.Roadline7.Location = New System.Drawing.Point(186, 510)
        Me.Roadline7.Name = "Roadline7"
        Me.Roadline7.Size = New System.Drawing.Size(10, 90)
        Me.Roadline7.TabIndex = 0
        Me.Roadline7.TabStop = False
        '
        'Roadline5
        '
        Me.Roadline5.BackColor = System.Drawing.Color.White
        Me.Roadline5.Location = New System.Drawing.Point(186, 340)
        Me.Roadline5.Name = "Roadline5"
        Me.Roadline5.Size = New System.Drawing.Size(10, 90)
        Me.Roadline5.TabIndex = 0
        Me.Roadline5.TabStop = False
        '
        'Roadline3
        '
        Me.Roadline3.BackColor = System.Drawing.Color.White
        Me.Roadline3.Location = New System.Drawing.Point(186, 170)
        Me.Roadline3.Name = "Roadline3"
        Me.Roadline3.Size = New System.Drawing.Size(10, 90)
        Me.Roadline3.TabIndex = 0
        Me.Roadline3.TabStop = False
        '
        'Roadline1
        '
        Me.Roadline1.BackColor = System.Drawing.Color.White
        Me.Roadline1.Location = New System.Drawing.Point(186, 0)
        Me.Roadline1.Name = "Roadline1"
        Me.Roadline1.Size = New System.Drawing.Size(10, 90)
        Me.Roadline1.TabIndex = 0
        Me.Roadline1.TabStop = False
        '
        'Roadline6
        '
        Me.Roadline6.BackColor = System.Drawing.Color.White
        Me.Roadline6.Location = New System.Drawing.Point(404, 340)
        Me.Roadline6.Name = "Roadline6"
        Me.Roadline6.Size = New System.Drawing.Size(10, 90)
        Me.Roadline6.TabIndex = 0
        Me.Roadline6.TabStop = False
        '
        'Roadline8
        '
        Me.Roadline8.BackColor = System.Drawing.Color.White
        Me.Roadline8.Location = New System.Drawing.Point(404, 510)
        Me.Roadline8.Name = "Roadline8"
        Me.Roadline8.Size = New System.Drawing.Size(10, 90)
        Me.Roadline8.TabIndex = 0
        Me.Roadline8.TabStop = False
        '
        'Roadline2
        '
        Me.Roadline2.BackColor = System.Drawing.Color.White
        Me.Roadline2.Location = New System.Drawing.Point(404, 0)
        Me.Roadline2.Name = "Roadline2"
        Me.Roadline2.Size = New System.Drawing.Size(10, 90)
        Me.Roadline2.TabIndex = 0
        Me.Roadline2.TabStop = False
        '
        'Roadline4
        '
        Me.Roadline4.BackColor = System.Drawing.Color.White
        Me.Roadline4.Location = New System.Drawing.Point(404, 170)
        Me.Roadline4.Name = "Roadline4"
        Me.Roadline4.Size = New System.Drawing.Size(10, 90)
        Me.Roadline4.TabIndex = 0
        Me.Roadline4.TabStop = False
        '
        'Roadline10
        '
        Me.Roadline10.BackColor = System.Drawing.Color.White
        Me.Roadline10.Location = New System.Drawing.Point(404, 680)
        Me.Roadline10.Name = "Roadline10"
        Me.Roadline10.Size = New System.Drawing.Size(10, 90)
        Me.Roadline10.TabIndex = 0
        Me.Roadline10.TabStop = False
        '
        'Lstrip
        '
        Me.Lstrip.BackColor = System.Drawing.Color.White
        Me.Lstrip.Location = New System.Drawing.Point(70, 0)
        Me.Lstrip.Name = "Lstrip"
        Me.Lstrip.Size = New System.Drawing.Size(18, 700)
        Me.Lstrip.TabIndex = 0
        Me.Lstrip.TabStop = False
        '
        'Rstrip
        '
        Me.Rstrip.BackColor = System.Drawing.Color.White
        Me.Rstrip.Location = New System.Drawing.Point(507, 0)
        Me.Rstrip.Name = "Rstrip"
        Me.Rstrip.Size = New System.Drawing.Size(18, 700)
        Me.Rstrip.TabIndex = 0
        Me.Rstrip.TabStop = False
        '
        'MidStrip
        '
        Me.MidStrip.BackColor = System.Drawing.Color.White
        Me.MidStrip.Location = New System.Drawing.Point(294, 0)
        Me.MidStrip.Name = "MidStrip"
        Me.MidStrip.Size = New System.Drawing.Size(10, 750)
        Me.MidStrip.TabIndex = 0
        Me.MidStrip.TabStop = False
        '
        'BikeHitbox1
        '
        Me.BikeHitbox1.BackColor = System.Drawing.Color.Black
        Me.BikeHitbox1.Location = New System.Drawing.Point(333, 584)
        Me.BikeHitbox1.Name = "BikeHitbox1"
        Me.BikeHitbox1.Size = New System.Drawing.Size(14, 77)
        Me.BikeHitbox1.TabIndex = 12
        Me.BikeHitbox1.TabStop = False
        '
        'BikeHitbox2
        '
        Me.BikeHitbox2.BackColor = System.Drawing.Color.Brown
        Me.BikeHitbox2.Location = New System.Drawing.Point(326, 601)
        Me.BikeHitbox2.Name = "BikeHitbox2"
        Me.BikeHitbox2.Size = New System.Drawing.Size(26, 20)
        Me.BikeHitbox2.TabIndex = 13
        Me.BikeHitbox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1284, 701)
        Me.Controls.Add(Me.PanelDashBoard)
        Me.Controls.Add(Me.PanelGameScreen)
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xtreme Rider"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelGameover.ResumeLayout(False)
        Me.PanelGameover.PerformLayout()
        CType(Me.PanelBorder2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDashBoard.ResumeLayout(False)
        Me.PanelDashBoard.PerformLayout()
        Me.PanelGameScreen.ResumeLayout(False)
        Me.PanelGameScreen.PerformLayout()
        Me.PanelPause.ResumeLayout(False)
        Me.PanelPause.PerformLayout()
        CType(Me.PanelBorder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bike, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemy4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grass2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grass1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hitbox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hitbox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hitbox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hitbox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Roadline9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Roadline7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Roadline5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Roadline3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Roadline1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Roadline6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Roadline8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Roadline2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Roadline4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Roadline10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Lstrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Rstrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MidStrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BikeHitbox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BikeHitbox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Roadmover As System.Windows.Forms.Timer
    Friend WithEvents Leftmover As System.Windows.Forms.Timer
    Friend WithEvents Rightmover As System.Windows.Forms.Timer
    Friend WithEvents enemymover As System.Windows.Forms.Timer
    Friend WithEvents LblGameOver As System.Windows.Forms.Label
    Friend WithEvents Score_count As System.Windows.Forms.Label
    Friend WithEvents Scr As System.Windows.Forms.Timer
    Friend WithEvents BtnRestart1 As System.Windows.Forms.Button
    Friend WithEvents BtnExit1 As System.Windows.Forms.Button
    Friend WithEvents Speed_test As System.Windows.Forms.Label
    Friend WithEvents slow_left As System.Windows.Forms.Timer
    Friend WithEvents slow_right As System.Windows.Forms.Timer
    Friend WithEvents Upmover As System.Windows.Forms.Timer
    Friend WithEvents Downmover As System.Windows.Forms.Timer
    Friend WithEvents PanelGameover As System.Windows.Forms.Panel
    Friend WithEvents PanelDashBoard As System.Windows.Forms.Panel
    Friend WithEvents PanelGameScreen As System.Windows.Forms.Panel
    Friend WithEvents Final_Score1 As System.Windows.Forms.Label
    Friend WithEvents PanelPause As System.Windows.Forms.Panel
    Friend WithEvents LblPause As System.Windows.Forms.Label
    Friend WithEvents BtnMainMenu2 As System.Windows.Forms.Button
    Friend WithEvents BtnResume As System.Windows.Forms.Button
    Friend WithEvents BtnRestart2 As System.Windows.Forms.Button
    Friend WithEvents BtnMainMenu1 As Button
    Friend WithEvents Final_Score2 As Label
    Friend WithEvents PanelBorder2 As PictureBox
    Friend WithEvents BikeHitbox1 As PictureBox
    Friend WithEvents bike As PictureBox
    Friend WithEvents PanelBorder1 As PictureBox
    Friend WithEvents grass2 As PictureBox
    Friend WithEvents grass1 As PictureBox
    Friend WithEvents enemy2 As PictureBox
    Friend WithEvents Hitbox2 As PictureBox
    Friend WithEvents Enemy1 As PictureBox
    Friend WithEvents Hitbox1 As PictureBox
    Friend WithEvents enemy3 As PictureBox
    Friend WithEvents Hitbox3 As PictureBox
    Friend WithEvents enemy4 As PictureBox
    Friend WithEvents Hitbox4 As PictureBox
    Friend WithEvents Roadline9 As PictureBox
    Friend WithEvents Roadline7 As PictureBox
    Friend WithEvents Roadline5 As PictureBox
    Friend WithEvents Roadline3 As PictureBox
    Friend WithEvents Roadline1 As PictureBox
    Friend WithEvents Roadline6 As PictureBox
    Friend WithEvents Roadline8 As PictureBox
    Friend WithEvents Roadline2 As PictureBox
    Friend WithEvents Roadline4 As PictureBox
    Friend WithEvents Roadline10 As PictureBox
    Friend WithEvents Lstrip As PictureBox
    Friend WithEvents Rstrip As PictureBox
    Friend WithEvents MidStrip As PictureBox
    Friend WithEvents BikeHitbox2 As PictureBox
    Friend WithEvents LblHighScore As Label
End Class
