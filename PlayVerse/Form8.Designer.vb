<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.PanelGameScreen = New System.Windows.Forms.Panel()
        Me.PanelGameover = New System.Windows.Forms.Panel()
        Me.Final_Score = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnMainMenu = New System.Windows.Forms.Button()
        Me.BtnRestart = New System.Windows.Forms.Button()
        Me.LblGameOver = New System.Windows.Forms.Label()
        Me.PanelBorder2 = New System.Windows.Forms.PictureBox()
        Me.LblPause = New System.Windows.Forms.Label()
        Me.LblGameStart = New System.Windows.Forms.Label()
        Me.Platform5 = New System.Windows.Forms.PictureBox()
        Me.Platform4 = New System.Windows.Forms.PictureBox()
        Me.Platform3 = New System.Windows.Forms.PictureBox()
        Me.Platform2 = New System.Windows.Forms.PictureBox()
        Me.Platform1 = New System.Windows.Forms.PictureBox()
        Me.CaptainHop = New System.Windows.Forms.PictureBox()
        Me.Platform0 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Leftmover = New System.Windows.Forms.Timer(Me.components)
        Me.Rightmover = New System.Windows.Forms.Timer(Me.components)
        Me.Gravitytimer = New System.Windows.Forms.Timer(Me.components)
        Me.Jumpmover = New System.Windows.Forms.Timer(Me.components)
        Me.Platformmover = New System.Windows.Forms.Timer(Me.components)
        Me.scrtimer = New System.Windows.Forms.Timer(Me.components)
        Me.Score_count = New System.Windows.Forms.Label()
        Me.LblHighScore = New System.Windows.Forms.Label()
        Me.PanelGameScreen.SuspendLayout()
        Me.PanelGameover.SuspendLayout()
        CType(Me.PanelBorder2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Platform5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Platform4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Platform3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Platform2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Platform1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CaptainHop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Platform0, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelGameScreen
        '
        Me.PanelGameScreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelGameScreen.Controls.Add(Me.PanelGameover)
        Me.PanelGameScreen.Controls.Add(Me.LblPause)
        Me.PanelGameScreen.Controls.Add(Me.LblGameStart)
        Me.PanelGameScreen.Controls.Add(Me.Platform5)
        Me.PanelGameScreen.Controls.Add(Me.Platform4)
        Me.PanelGameScreen.Controls.Add(Me.Platform3)
        Me.PanelGameScreen.Controls.Add(Me.Platform2)
        Me.PanelGameScreen.Controls.Add(Me.Platform1)
        Me.PanelGameScreen.Controls.Add(Me.CaptainHop)
        Me.PanelGameScreen.Controls.Add(Me.Platform0)
        Me.PanelGameScreen.Controls.Add(Me.PictureBox1)
        Me.PanelGameScreen.Location = New System.Drawing.Point(255, 0)
        Me.PanelGameScreen.Name = "PanelGameScreen"
        Me.PanelGameScreen.Size = New System.Drawing.Size(800, 700)
        Me.PanelGameScreen.TabIndex = 0
        '
        'PanelGameover
        '
        Me.PanelGameover.AutoSize = True
        Me.PanelGameover.BackColor = System.Drawing.Color.White
        Me.PanelGameover.Controls.Add(Me.Final_Score)
        Me.PanelGameover.Controls.Add(Me.BtnExit)
        Me.PanelGameover.Controls.Add(Me.BtnMainMenu)
        Me.PanelGameover.Controls.Add(Me.BtnRestart)
        Me.PanelGameover.Controls.Add(Me.LblGameOver)
        Me.PanelGameover.Controls.Add(Me.PanelBorder2)
        Me.PanelGameover.Location = New System.Drawing.Point(770, 118)
        Me.PanelGameover.Name = "PanelGameover"
        Me.PanelGameover.Size = New System.Drawing.Size(406, 306)
        Me.PanelGameover.TabIndex = 9
        Me.PanelGameover.Visible = False
        '
        'Final_Score
        '
        Me.Final_Score.AutoSize = True
        Me.Final_Score.BackColor = System.Drawing.Color.Black
        Me.Final_Score.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Final_Score.ForeColor = System.Drawing.Color.White
        Me.Final_Score.Location = New System.Drawing.Point(130, 110)
        Me.Final_Score.Name = "Final_Score"
        Me.Final_Score.Size = New System.Drawing.Size(101, 23)
        Me.Final_Score.TabIndex = 3
        Me.Final_Score.Text = "Your Score :"
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.White
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExit.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Black
        Me.BtnExit.Location = New System.Drawing.Point(121, 242)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(170, 40)
        Me.BtnExit.TabIndex = 2
        Me.BtnExit.Text = "&Exit Game"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnMainMenu
        '
        Me.BtnMainMenu.BackColor = System.Drawing.Color.White
        Me.BtnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnMainMenu.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMainMenu.ForeColor = System.Drawing.Color.Black
        Me.BtnMainMenu.Location = New System.Drawing.Point(121, 194)
        Me.BtnMainMenu.Name = "BtnMainMenu"
        Me.BtnMainMenu.Size = New System.Drawing.Size(170, 40)
        Me.BtnMainMenu.TabIndex = 1
        Me.BtnMainMenu.Text = "&Main Menu"
        Me.BtnMainMenu.UseVisualStyleBackColor = False
        '
        'BtnRestart
        '
        Me.BtnRestart.BackColor = System.Drawing.Color.White
        Me.BtnRestart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRestart.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRestart.ForeColor = System.Drawing.Color.Black
        Me.BtnRestart.Location = New System.Drawing.Point(121, 147)
        Me.BtnRestart.Name = "BtnRestart"
        Me.BtnRestart.Size = New System.Drawing.Size(170, 40)
        Me.BtnRestart.TabIndex = 0
        Me.BtnRestart.Text = "&Restart"
        Me.BtnRestart.UseVisualStyleBackColor = False
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
        'PanelBorder2
        '
        Me.PanelBorder2.BackColor = System.Drawing.Color.Black
        Me.PanelBorder2.Location = New System.Drawing.Point(3, 3)
        Me.PanelBorder2.Name = "PanelBorder2"
        Me.PanelBorder2.Size = New System.Drawing.Size(400, 300)
        Me.PanelBorder2.TabIndex = 8
        Me.PanelBorder2.TabStop = False
        '
        'LblPause
        '
        Me.LblPause.AutoSize = True
        Me.LblPause.BackColor = System.Drawing.SystemColors.InfoText
        Me.LblPause.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LblPause.Font = New System.Drawing.Font("Impact", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPause.ForeColor = System.Drawing.Color.Red
        Me.LblPause.Location = New System.Drawing.Point(200, 250)
        Me.LblPause.Name = "LblPause"
        Me.LblPause.Size = New System.Drawing.Size(379, 82)
        Me.LblPause.TabIndex = 10
        Me.LblPause.Text = "GAME PAUSED"
        Me.LblPause.Visible = False
        '
        'LblGameStart
        '
        Me.LblGameStart.AutoSize = True
        Me.LblGameStart.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblGameStart.ForeColor = System.Drawing.Color.White
        Me.LblGameStart.Location = New System.Drawing.Point(234, 384)
        Me.LblGameStart.Name = "LblGameStart"
        Me.LblGameStart.Size = New System.Drawing.Size(348, 40)
        Me.LblGameStart.TabIndex = 8
        Me.LblGameStart.Text = "Press Enter Key to Start!"
        '
        'Platform5
        '
        Me.Platform5.BackColor = System.Drawing.Color.Magenta
        Me.Platform5.Location = New System.Drawing.Point(230, -40)
        Me.Platform5.Name = "Platform5"
        Me.Platform5.Size = New System.Drawing.Size(110, 15)
        Me.Platform5.TabIndex = 7
        Me.Platform5.TabStop = False
        '
        'Platform4
        '
        Me.Platform4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Platform4.Location = New System.Drawing.Point(420, 80)
        Me.Platform4.Name = "Platform4"
        Me.Platform4.Size = New System.Drawing.Size(110, 15)
        Me.Platform4.TabIndex = 6
        Me.Platform4.TabStop = False
        '
        'Platform3
        '
        Me.Platform3.BackColor = System.Drawing.Color.Lime
        Me.Platform3.Location = New System.Drawing.Point(140, 220)
        Me.Platform3.Name = "Platform3"
        Me.Platform3.Size = New System.Drawing.Size(110, 15)
        Me.Platform3.TabIndex = 5
        Me.Platform3.TabStop = False
        '
        'Platform2
        '
        Me.Platform2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Platform2.Location = New System.Drawing.Point(454, 320)
        Me.Platform2.Name = "Platform2"
        Me.Platform2.Size = New System.Drawing.Size(110, 15)
        Me.Platform2.TabIndex = 4
        Me.Platform2.TabStop = False
        '
        'Platform1
        '
        Me.Platform1.BackColor = System.Drawing.Color.Red
        Me.Platform1.Location = New System.Drawing.Point(150, 460)
        Me.Platform1.Name = "Platform1"
        Me.Platform1.Size = New System.Drawing.Size(110, 15)
        Me.Platform1.TabIndex = 3
        Me.Platform1.TabStop = False
        '
        'CaptainHop
        '
        Me.CaptainHop.BackColor = System.Drawing.Color.White
        Me.CaptainHop.Image = Global.PlayVerse.My.Resources.Resources.CaptainHop
        Me.CaptainHop.Location = New System.Drawing.Point(383, 571)
        Me.CaptainHop.Name = "CaptainHop"
        Me.CaptainHop.Size = New System.Drawing.Size(30, 30)
        Me.CaptainHop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.CaptainHop.TabIndex = 2
        Me.CaptainHop.TabStop = False
        '
        'Platform0
        '
        Me.Platform0.BackColor = System.Drawing.Color.Yellow
        Me.Platform0.Location = New System.Drawing.Point(340, 600)
        Me.Platform0.Name = "Platform0"
        Me.Platform0.Size = New System.Drawing.Size(110, 15)
        Me.Platform0.TabIndex = 1
        Me.Platform0.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Location = New System.Drawing.Point(0, 688)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(799, 15)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Leftmover
        '
        Me.Leftmover.Interval = 8
        '
        'Rightmover
        '
        Me.Rightmover.Interval = 8
        '
        'Gravitytimer
        '
        Me.Gravitytimer.Enabled = True
        Me.Gravitytimer.Interval = 20
        '
        'Jumpmover
        '
        Me.Jumpmover.Interval = 15
        '
        'Platformmover
        '
        Me.Platformmover.Interval = 30
        '
        'scrtimer
        '
        Me.scrtimer.Interval = 1000
        '
        'Score_count
        '
        Me.Score_count.AutoSize = True
        Me.Score_count.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.Score_count.ForeColor = System.Drawing.Color.White
        Me.Score_count.Location = New System.Drawing.Point(1, 0)
        Me.Score_count.Name = "Score_count"
        Me.Score_count.Size = New System.Drawing.Size(125, 37)
        Me.Score_count.TabIndex = 1
        Me.Score_count.Text = "Score : 0"
        '
        'LblHighScore
        '
        Me.LblHighScore.AutoSize = True
        Me.LblHighScore.BackColor = System.Drawing.Color.Transparent
        Me.LblHighScore.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold)
        Me.LblHighScore.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblHighScore.Location = New System.Drawing.Point(0, 37)
        Me.LblHighScore.Name = "LblHighScore"
        Me.LblHighScore.Size = New System.Drawing.Size(180, 37)
        Me.LblHighScore.TabIndex = 6
        Me.LblHighScore.Text = "HighScore: 0"
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1284, 701)
        Me.Controls.Add(Me.LblHighScore)
        Me.Controls.Add(Me.Score_count)
        Me.Controls.Add(Me.PanelGameScreen)
        Me.KeyPreview = True
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.Name = "Form8"
        Me.Text = "SkyHopper"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelGameScreen.ResumeLayout(False)
        Me.PanelGameScreen.PerformLayout()
        Me.PanelGameover.ResumeLayout(False)
        Me.PanelGameover.PerformLayout()
        CType(Me.PanelBorder2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Platform5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Platform4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Platform3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Platform2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Platform1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CaptainHop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Platform0, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelGameScreen As Panel
    Friend WithEvents Platform0 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CaptainHop As PictureBox
    Friend WithEvents Platform3 As PictureBox
    Friend WithEvents Platform2 As PictureBox
    Friend WithEvents Platform1 As PictureBox
    Friend WithEvents Platform4 As PictureBox
    Friend WithEvents Platform5 As PictureBox
    Friend WithEvents Leftmover As Timer
    Friend WithEvents Rightmover As Timer
    Friend WithEvents Gravitytimer As Timer
    Friend WithEvents Jumpmover As Timer
    Friend WithEvents Platformmover As Timer
    Friend WithEvents scrtimer As Timer
    Friend WithEvents LblGameStart As Label
    Friend WithEvents Score_count As Label
    Friend WithEvents PanelGameover As Panel
    Friend WithEvents Final_Score As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnMainMenu As Button
    Friend WithEvents BtnRestart As Button
    Friend WithEvents LblGameOver As Label
    Friend WithEvents PanelBorder2 As PictureBox
    Friend WithEvents LblHighScore As Label
    Friend WithEvents LblPause As Label
End Class
