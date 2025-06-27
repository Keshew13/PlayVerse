<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.BtnHowto = New System.Windows.Forms.Button()
        Me.PanelHowto = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.BtnMainMenu = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHowto.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(182, 123)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(900, 150)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Red
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnExit.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.White
        Me.BtnExit.Location = New System.Drawing.Point(508, 527)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(250, 60)
        Me.BtnExit.TabIndex = 9
        Me.BtnExit.Text = "&Exit Game"
        Me.BtnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnStart
        '
        Me.BtnStart.BackColor = System.Drawing.Color.White
        Me.BtnStart.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnStart.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.ForeColor = System.Drawing.Color.Black
        Me.BtnStart.Location = New System.Drawing.Point(508, 370)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(250, 60)
        Me.BtnStart.TabIndex = 7
        Me.BtnStart.Text = "&Start Game"
        Me.BtnStart.UseVisualStyleBackColor = False
        '
        'BtnHowto
        '
        Me.BtnHowto.BackColor = System.Drawing.Color.White
        Me.BtnHowto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnHowto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnHowto.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHowto.ForeColor = System.Drawing.Color.Black
        Me.BtnHowto.Location = New System.Drawing.Point(508, 449)
        Me.BtnHowto.Name = "BtnHowto"
        Me.BtnHowto.Size = New System.Drawing.Size(250, 60)
        Me.BtnHowto.TabIndex = 8
        Me.BtnHowto.Text = "&How to play?"
        Me.BtnHowto.UseVisualStyleBackColor = False
        '
        'PanelHowto
        '
        Me.PanelHowto.BackColor = System.Drawing.Color.White
        Me.PanelHowto.Controls.Add(Me.Label1)
        Me.PanelHowto.Controls.Add(Me.Label26)
        Me.PanelHowto.Controls.Add(Me.BtnMainMenu)
        Me.PanelHowto.Controls.Add(Me.Label2)
        Me.PanelHowto.Controls.Add(Me.PictureBox2)
        Me.PanelHowto.Location = New System.Drawing.Point(1174, -1)
        Me.PanelHowto.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelHowto.Name = "PanelHowto"
        Me.PanelHowto.Size = New System.Drawing.Size(1285, 703)
        Me.PanelHowto.TabIndex = 10
        Me.PanelHowto.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(253, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(694, 224)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = resources.GetString("Label1.Text")
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Black
        Me.Label26.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.Label26.Location = New System.Drawing.Point(26, 643)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(255, 21)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "(Click or Press Enter to go back!)"
        '
        'BtnMainMenu
        '
        Me.BtnMainMenu.BackColor = System.Drawing.Color.White
        Me.BtnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnMainMenu.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnMainMenu.ForeColor = System.Drawing.Color.Black
        Me.BtnMainMenu.Location = New System.Drawing.Point(61, 600)
        Me.BtnMainMenu.Name = "BtnMainMenu"
        Me.BtnMainMenu.Size = New System.Drawing.Size(170, 40)
        Me.BtnMainMenu.TabIndex = 0
        Me.BtnMainMenu.Text = "&Main Menu"
        Me.BtnMainMenu.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 80.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(407, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(476, 142)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "How to?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(7, 8)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(1270, 685)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1284, 701)
        Me.Controls.Add(Me.PanelHowto)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnHowto)
        Me.Controls.Add(Me.BtnStart)
        Me.Controls.Add(Me.PictureBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.MaximumSize = New System.Drawing.Size(1900, 1080)
        Me.Name = "Form6"
        Me.Text = "Minesweeper"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHowto.ResumeLayout(False)
        Me.PanelHowto.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnStart As Button
    Friend WithEvents BtnHowto As Button
    Friend WithEvents PanelHowto As Panel
    Friend WithEvents Label26 As Label
    Friend WithEvents BtnMainMenu As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
End Class
