<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelPongScreen = New System.Windows.Forms.Panel()
        Me.Ball = New System.Windows.Forms.PictureBox()
        Me.PanelPause = New System.Windows.Forms.Panel()
        Me.LblPause = New System.Windows.Forms.Label()
        Me.BtnMainMenu2 = New System.Windows.Forms.Button()
        Me.BtnRestart2 = New System.Windows.Forms.Button()
        Me.BtnResume = New System.Windows.Forms.Button()
        Me.PanelBorder1 = New System.Windows.Forms.PictureBox()
        Me.Paddle1 = New System.Windows.Forms.PictureBox()
        Me.Paddle2 = New System.Windows.Forms.PictureBox()
        Me.PanelGameover = New System.Windows.Forms.Panel()
        Me.WinState = New System.Windows.Forms.Label()
        Me.LblGameOver = New System.Windows.Forms.Label()
        Me.BtnRestart1 = New System.Windows.Forms.Button()
        Me.BtnExit1 = New System.Windows.Forms.Button()
        Me.BtnMainMenu1 = New System.Windows.Forms.Button()
        Me.GameOverBG = New System.Windows.Forms.PictureBox()
        Me.LblGameStart = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblHighscore = New System.Windows.Forms.Label()
        Me.Score = New System.Windows.Forms.Label()
        Me.Upmover1 = New System.Windows.Forms.Timer(Me.components)
        Me.Downmover1 = New System.Windows.Forms.Timer(Me.components)
        Me.Upmover2 = New System.Windows.Forms.Timer(Me.components)
        Me.Downmover2 = New System.Windows.Forms.Timer(Me.components)
        Me.Ballmover = New System.Windows.Forms.Timer(Me.components)
        Me.Restart = New System.Windows.Forms.Timer(Me.components)
        Me.Delay = New System.Windows.Forms.Timer(Me.components)
        Me.PanelPongScreen.SuspendLayout()
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPause.SuspendLayout()
        CType(Me.PanelBorder1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Paddle1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Paddle2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelGameover.SuspendLayout()
        CType(Me.GameOverBG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelPongScreen
        '
        Me.PanelPongScreen.BackColor = System.Drawing.Color.Black
        Me.PanelPongScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelPongScreen.Controls.Add(Me.Ball)
        Me.PanelPongScreen.Controls.Add(Me.PanelPause)
        Me.PanelPongScreen.Controls.Add(Me.Paddle1)
        Me.PanelPongScreen.Controls.Add(Me.Paddle2)
        Me.PanelPongScreen.Controls.Add(Me.PanelGameover)
        Me.PanelPongScreen.Controls.Add(Me.LblGameStart)
        Me.PanelPongScreen.Controls.Add(Me.Panel1)
        Me.PanelPongScreen.Location = New System.Drawing.Point(-2, -2)
        Me.PanelPongScreen.Name = "PanelPongScreen"
        Me.PanelPongScreen.Size = New System.Drawing.Size(1290, 705)
        Me.PanelPongScreen.TabIndex = 0
        '
        'Ball
        '
        Me.Ball.BackColor = System.Drawing.Color.White
        Me.Ball.Location = New System.Drawing.Point(574, 519)
        Me.Ball.Name = "Ball"
        Me.Ball.Size = New System.Drawing.Size(17, 17)
        Me.Ball.TabIndex = 3
        Me.Ball.TabStop = False
        '
        'PanelPause
        '
        Me.PanelPause.AutoSize = True
        Me.PanelPause.BackColor = System.Drawing.Color.White
        Me.PanelPause.Controls.Add(Me.LblPause)
        Me.PanelPause.Controls.Add(Me.BtnMainMenu2)
        Me.PanelPause.Controls.Add(Me.BtnRestart2)
        Me.PanelPause.Controls.Add(Me.BtnResume)
        Me.PanelPause.Controls.Add(Me.PanelBorder1)
        Me.PanelPause.Location = New System.Drawing.Point(33, 645)
        Me.PanelPause.Name = "PanelPause"
        Me.PanelPause.Size = New System.Drawing.Size(406, 306)
        Me.PanelPause.TabIndex = 5
        Me.PanelPause.Visible = False
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
        Me.BtnMainMenu2.Location = New System.Drawing.Point(118, 230)
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
        Me.BtnRestart2.Location = New System.Drawing.Point(118, 184)
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
        Me.BtnResume.Location = New System.Drawing.Point(118, 138)
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
        'Paddle1
        '
        Me.Paddle1.BackColor = System.Drawing.Color.White
        Me.Paddle1.Location = New System.Drawing.Point(33, 283)
        Me.Paddle1.Name = "Paddle1"
        Me.Paddle1.Size = New System.Drawing.Size(15, 125)
        Me.Paddle1.TabIndex = 1
        Me.Paddle1.TabStop = False
        '
        'Paddle2
        '
        Me.Paddle2.BackColor = System.Drawing.Color.White
        Me.Paddle2.Location = New System.Drawing.Point(1235, 277)
        Me.Paddle2.Name = "Paddle2"
        Me.Paddle2.Size = New System.Drawing.Size(15, 125)
        Me.Paddle2.TabIndex = 2
        Me.Paddle2.TabStop = False
        '
        'PanelGameover
        '
        Me.PanelGameover.AutoSize = True
        Me.PanelGameover.BackColor = System.Drawing.Color.White
        Me.PanelGameover.Controls.Add(Me.WinState)
        Me.PanelGameover.Controls.Add(Me.LblGameOver)
        Me.PanelGameover.Controls.Add(Me.BtnRestart1)
        Me.PanelGameover.Controls.Add(Me.BtnExit1)
        Me.PanelGameover.Controls.Add(Me.BtnMainMenu1)
        Me.PanelGameover.Controls.Add(Me.GameOverBG)
        Me.PanelGameover.Location = New System.Drawing.Point(805, 633)
        Me.PanelGameover.Name = "PanelGameover"
        Me.PanelGameover.Size = New System.Drawing.Size(406, 306)
        Me.PanelGameover.TabIndex = 0
        Me.PanelGameover.TabStop = True
        Me.PanelGameover.Visible = False
        '
        'WinState
        '
        Me.WinState.AutoSize = True
        Me.WinState.BackColor = System.Drawing.Color.Black
        Me.WinState.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WinState.ForeColor = System.Drawing.Color.White
        Me.WinState.Location = New System.Drawing.Point(130, 108)
        Me.WinState.Name = "WinState"
        Me.WinState.Size = New System.Drawing.Size(102, 23)
        Me.WinState.TabIndex = 3
        Me.WinState.Text = "Player  Won"
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
        '
        'BtnRestart1
        '
        Me.BtnRestart1.BackColor = System.Drawing.Color.White
        Me.BtnRestart1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestart1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRestart1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestart1.ForeColor = System.Drawing.Color.Black
        Me.BtnRestart1.Location = New System.Drawing.Point(121, 148)
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
        'GameOverBG
        '
        Me.GameOverBG.BackColor = System.Drawing.Color.Black
        Me.GameOverBG.Location = New System.Drawing.Point(3, 3)
        Me.GameOverBG.Name = "GameOverBG"
        Me.GameOverBG.Size = New System.Drawing.Size(400, 300)
        Me.GameOverBG.TabIndex = 8
        Me.GameOverBG.TabStop = False
        '
        'LblGameStart
        '
        Me.LblGameStart.AutoSize = True
        Me.LblGameStart.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGameStart.ForeColor = System.Drawing.Color.White
        Me.LblGameStart.Location = New System.Drawing.Point(483, 577)
        Me.LblGameStart.Name = "LblGameStart"
        Me.LblGameStart.Size = New System.Drawing.Size(348, 40)
        Me.LblGameStart.TabIndex = 6
        Me.LblGameStart.Text = "Press Enter Key to Start!"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LblHighscore)
        Me.Panel1.Controls.Add(Me.Score)
        Me.Panel1.Location = New System.Drawing.Point(436, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 67)
        Me.Panel1.TabIndex = 9
        '
        'LblHighscore
        '
        Me.LblHighscore.AutoSize = True
        Me.LblHighscore.BackColor = System.Drawing.Color.Black
        Me.LblHighscore.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LblHighscore.Font = New System.Drawing.Font("Segoe UI", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHighscore.ForeColor = System.Drawing.Color.White
        Me.LblHighscore.Location = New System.Drawing.Point(252, -3)
        Me.LblHighscore.Margin = New System.Windows.Forms.Padding(0)
        Me.LblHighscore.Name = "LblHighscore"
        Me.LblHighscore.Size = New System.Drawing.Size(269, 54)
        Me.LblHighscore.TabIndex = 8
        Me.LblHighscore.Text = "Highscore : 0"
        '
        'Score
        '
        Me.Score.AutoSize = True
        Me.Score.BackColor = System.Drawing.Color.Black
        Me.Score.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Score.Font = New System.Drawing.Font("Segoe UI", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Score.ForeColor = System.Drawing.Color.White
        Me.Score.Location = New System.Drawing.Point(0, 0)
        Me.Score.Margin = New System.Windows.Forms.Padding(0)
        Me.Score.Name = "Score"
        Me.Score.Size = New System.Drawing.Size(182, 54)
        Me.Score.TabIndex = 7
        Me.Score.Text = "Score : 0"
        '
        'Upmover1
        '
        Me.Upmover1.Interval = 10
        '
        'Downmover1
        '
        Me.Downmover1.Interval = 10
        '
        'Upmover2
        '
        Me.Upmover2.Interval = 10
        '
        'Downmover2
        '
        Me.Downmover2.Interval = 10
        '
        'Ballmover
        '
        Me.Ballmover.Interval = 20
        '
        'Restart
        '
        Me.Restart.Interval = 2000
        '
        'Delay
        '
        Me.Delay.Interval = 3000
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1284, 701)
        Me.Controls.Add(Me.PanelPongScreen)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "PongLegends"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelPongScreen.ResumeLayout(False)
        Me.PanelPongScreen.PerformLayout()
        CType(Me.Ball, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPause.ResumeLayout(False)
        Me.PanelPause.PerformLayout()
        CType(Me.PanelBorder1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Paddle1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Paddle2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelGameover.ResumeLayout(False)
        Me.PanelGameover.PerformLayout()
        CType(Me.GameOverBG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelPongScreen As Panel
    Friend WithEvents Paddle1 As PictureBox
    Friend WithEvents Ball As PictureBox
    Friend WithEvents Paddle2 As PictureBox
    Friend WithEvents Upmover1 As Timer
    Friend WithEvents Downmover1 As Timer
    Friend WithEvents Upmover2 As Timer
    Friend WithEvents Downmover2 As Timer
    Friend WithEvents Ballmover As Timer
    Friend WithEvents Restart As Timer
    Friend WithEvents Delay As Timer
    Friend WithEvents BtnRestart1 As Button
    Friend WithEvents PanelGameover As Panel
    Friend WithEvents WinState As Label
    Friend WithEvents BtnExit1 As Button
    Friend WithEvents BtnMainMenu1 As Button
    Friend WithEvents LblGameOver As Label
    Friend WithEvents GameOverBG As PictureBox
    Friend WithEvents PanelPause As Panel
    Friend WithEvents LblPause As Label
    Friend WithEvents BtnMainMenu2 As Button
    Friend WithEvents BtnRestart2 As Button
    Friend WithEvents BtnResume As Button
    Friend WithEvents PanelBorder1 As PictureBox
    Friend WithEvents LblGameStart As Label
    Friend WithEvents Score As Label
    Friend WithEvents LblHighscore As Label
    Friend WithEvents Panel1 As Panel
End Class
