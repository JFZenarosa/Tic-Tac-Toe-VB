Public Class TTTform

    Dim turn As Boolean = True
    Dim turn_count As Integer = 0

    Private Sub TTTform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            btnA1.BackColor = System.Drawing.Color.AliceBlue
            btnA2.BackColor = System.Drawing.Color.AliceBlue
            btnA3.BackColor = System.Drawing.Color.AliceBlue
        ElseIf btnB1.Text = btnB2.Text And btnB2.Text = btnB3.Text And Not btnB1.Enabled Then
            theWinner = True
            btnB1.BackColor = System.Drawing.Color.AliceBlue
            btnB2.BackColor = System.Drawing.Color.AliceBlue
            btnB3.BackColor = System.Drawing.Color.AliceBlue
        ElseIf btnC1.Text = btnC2.Text And btnC2.Text = btnC3.Text And Not btnC1.Enabled Then
            theWinner = True
            btnC1.BackColor = System.Drawing.Color.AliceBlue
            btnC2.BackColor = System.Drawing.Color.AliceBlue
            btnC3.BackColor = System.Drawing.Color.AliceBlue
        ElseIf btnA1.Text = btnB2.Text And btnB2.Text = btnC3.Text And Not btnA1.Enabled Then
            theWinner = True
            btnA1.BackColor = System.Drawing.Color.AliceBlue
            btnB2.BackColor = System.Drawing.Color.AliceBlue
            btnC3.BackColor = System.Drawing.Color.AliceBlue
        ElseIf btnC1.Text = btnB2.Text And btnB2.Text = btnA3.Text And Not btnC1.Enabled Then
            theWinner = True
            btnC1.BackColor = System.Drawing.Color.AliceBlue
            btnB2.BackColor = System.Drawing.Color.AliceBlue
            btnA3.BackColor = System.Drawing.Color.AliceBlue
        ElseIf btnA1.Text = btnB1.Text And btnB1.Text = btnC1.Text And Not btnA1.Enabled Then
            theWinner = True
            btnA1.BackColor = System.Drawing.Color.AliceBlue
            btnB1.BackColor = System.Drawing.Color.AliceBlue
            btnC1.BackColor = System.Drawing.Color.AliceBlue
        ElseIf btnA2.Text = btnB2.Text And btnB2.Text = btnC2.Text And Not btnA2.Enabled Then
            theWinner = True
            btnA2.BackColor = System.Drawing.Color.AliceBlue
            btnB2.BackColor = System.Drawing.Color.AliceBlue
            btnC2.BackColor = System.Drawing.Color.AliceBlue
        ElseIf btnA3.Text = btnB3.Text And btnB3.Text = btnC3.Text And Not btnA3.Enabled Then
            theWinner = True
            btnA3.BackColor = System.Drawing.Color.AliceBlue
            btnB3.BackColor = System.Drawing.Color.AliceBlue
            btnC3.BackColor = System.Drawing.Color.AliceBlue
        End If

        If theWinner Then
            disableBtn()
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

    Private Sub disableBtn()
        Dim c As Control
        Try
            For Each c In Controls
                Dim a As Button = c
                a.Enabled = False
            Next
        Catch ex As Exception

        End Try
    End Sub



    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub NewGameToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewGameToolStripMenuItem.Click
        turn = True
        turn_count = 0
        Dim c As Control
        Try
            For Each c In Controls
                Dim a As Button = c
                a.Enabled = True
                a.Text = ""
                a.BackColor = System.Drawing.Color.Gainsboro
                a.TabStop = False
            Next

        Catch ex As Exception

        End Try

    End Sub
End Class
