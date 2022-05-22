Public Class TTTform

    Dim turn As Boolean = True
    Dim turn_count As Integer = 0

    Private Sub TTTform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNewgame_Click(sender As Object, e As EventArgs) Handles btnNewgame.Click

    End Sub

    Private Sub buttonClick(sender As Object, e As EventArgs) Handles btnC3.Click, btnC2.Click, btnC1.Click, btnB3.Click, btnB2.Click, btnB1.Click, btnA3.Click, btnA2.Click, btnA1.Click
        Dim btnClick As Button = sender
        If turn Then
            btnClick.Text = "X"
        Else
            btnClick.Text = "O"
        End If

        turn = Not turn
        btnClick.Enabled = False
        turn_count += 1
        winnerChecker()

    End Sub

    Private Sub winnerChecker()
        Dim theWinner As Boolean = False

        If btnA1.Text = btnA2.Text And btnA2.Text = btnA3.Text And Not btnA1.Enabled Then
            theWinner = True

        ElseIf btnB1.Text = btnB2.Text And btnB2.Text = btnB3.Text And Not btnB1.Enabled Then
            theWinner = True

        ElseIf btnC1.Text = btnC2.Text And btnC2.Text = btnC3.Text And Not btnC1.Enabled Then
            theWinner = True

        ElseIf btnA1.Text = btnB2.Text And btnB2.Text = btnC3.Text And Not btnA1.Enabled Then
            theWinner = True

        ElseIf btnC1.Text = btnB2.Text And btnB2.Text = btnA3.Text And Not btnC1.Enabled Then
            theWinner = True

        ElseIf btnA1.Text = btnB1.Text And btnB1.Text = btnC1.Text And Not btnA1.Enabled Then
            theWinner = True

        ElseIf btnA2.Text = btnB2.Text And btnB2.Text = btnC2.Text And Not btnA2.Enabled Then
            theWinner = True

        ElseIf btnA3.Text = btnB3.Text And btnB3.Text = btnC3.Text And Not btnA3.Enabled Then
            theWinner = True
        End If

        If theWinner Then
            Dim winner As String = ""

            If turn Then
                winner = "O"
            Else
                winner = "X"
            End If
            MessageBox.Show(winner + " Wins the Game!", "Congratulations!")
        Else
            If turn_count = 9 Then
                MessageBox.Show("DRAW!", "Try Again!")
            End If

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
