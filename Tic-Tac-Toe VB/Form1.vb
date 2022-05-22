Public Class TTTform

    Dim turn As Boolean = True
    Dim turn_count As Integer = 0

    Private Sub TTTform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnNewgame_Click(sender As Object, e As EventArgs) Handles btnNewgame.Click

    End Sub

    Private Sub buttonClick(sender As Object, e As EventArgs) Handles btnC3.Click, btnC2.Click, btnC1.Click, btnB3.Click, btnB2.Click, btnB1.Click, btnA3.Click, btnA2.Click, btnA1.Click
        Dim a As Button = sender
        If turn Then
            a.Text = "X"
        Else
            a.Text = "O"
        End If



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
