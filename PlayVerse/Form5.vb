Public Class Form5

    Dim Boxes(5, 14) As PictureBox
    Dim Bombs(14) As Integer
    Dim CurrentColumn As Integer = 0
    Dim BetAmount As Integer = 1
    Dim Reward As Double = 0
    Dim rand As New Random()

    Dim Multipliers() As Double = {
        1.15, 1.35, 1.59, 1.87, 2.21,
        2.61, 3.09, 3.66, 4.34, 5.14,
        6.09, 7.21, 8.52, 10.06, 15
    }

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupBoxes()
        RestartGame()
    End Sub

    Private Sub SetupBoxes()
        Dim count As Integer = 1
        For col As Integer = 0 To 14
            For row As Integer = 0 To 5
                Dim box As PictureBox = CType(Panel1.Controls("Box" & count.ToString()), PictureBox)
                If box IsNot Nothing Then
                    Boxes(row, col) = box
                    box.Image = My.Resources.grass
                    box.Tag = New Point(row, col)
                    AddHandler box.Click, AddressOf Box_Click
                End If
                count += 1
            Next
        Next
    End Sub

    Private Sub PlaceBombs()
        For i As Integer = 0 To 14
            Bombs(i) = rand.Next(0, 6)
        Next
    End Sub

    Private Sub Box_Click(sender As Object, e As EventArgs)
        Dim box As PictureBox = CType(sender, PictureBox)
        Dim pos As Point = CType(box.Tag, Point)
        Dim row As Integer = pos.X
        Dim col As Integer = pos.Y

        If col <> CurrentColumn Then
            Beep()
            Return
        End If

        If row = Bombs(col) Then
            box.Image = My.Resources.Bomb
            MessageBox.Show("💥 Bomb! You lost ₹" & BetAmount)
            RestartGame()
        Else
            box.Image = My.Resources.Flag
            Boxes(Bombs(col), col).Image = My.Resources.Bomb

            CurrentColumn += 1
            If CurrentColumn > 14 Then
                MessageBox.Show("🏆 You survived all and win ₹" & 15)
                My.Settings.MinesweeperBalance += 15
                My.Settings.Save()
                RestartGame()
            Else
                UpdateIndicators()
                UpdateLabels()
            End If
        End If
    End Sub

    Private Sub BtnCashOut_Click(sender As Object, e As EventArgs) Handles BtnCashOut.Click
        If CurrentColumn = 0 Then
            MessageBox.Show("❌ You need to pass at least 1 column.")
        Else
            MessageBox.Show("✅ Cashed out ₹" & Math.Round(Reward, 2))
            My.Settings.MinesweeperBalance += Math.Round(Reward)
            My.Settings.Save()
            RestartGame()
        End If
    End Sub

    Private Sub RestartGame()
        If My.Settings.MinesweeperBalance < BetAmount Then
            MessageBox.Show("❌ Not enough balance to play again.adding ₹1000")
            My.Settings.MinesweeperBalance = 1000
            BtnCashOut.Enabled = False
            Exit Sub
        End If

        My.Settings.MinesweeperBalance -= BetAmount
        My.Settings.Save()

        CurrentColumn = 0
        PlaceBombs()

        For Each box In Boxes
            If box IsNot Nothing Then box.Image = My.Resources.grass
        Next

        UpdateIndicators()
        UpdateLabels()
        UpdateBalanceLabel()
    End Sub

    Private Sub UpdateIndicators()
        Dim x = Boxes(0, CurrentColumn).Left
        Current1.Left = x
        Current2.Left = x
    End Sub

    Private Sub UpdateLabels()
        If CurrentColumn = 0 Then
            Reward = BetAmount
        Else
            Reward = BetAmount * Multipliers(CurrentColumn - 1)
        End If

        LblBetAmount.Text = "Bet: ₹" & BetAmount
        LblCashOut.Text = "CashOut: ₹" & Math.Round(Reward, 2)
    End Sub

    Private Sub UpdateBalanceLabel()
        LblBalance.Text = "Balance: ₹" & My.Settings.MinesweeperBalance
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Form6.Show()
        Me.Close()
    End Sub

End Class