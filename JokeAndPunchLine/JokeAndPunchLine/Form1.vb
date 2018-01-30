Public Class Form1
    Private Sub btnSetup_Click(sender As Object, e As EventArgs) Handles btnSetup.Click
        lblMessage.Text = "How many programmers does it take to change a light bulb?"
    End Sub

    Private Sub btnPunchLine_Click(sender As Object, e As EventArgs) Handles btnPunchLine.Click
        lblMessage.Text = "None. That’s a hardware problem."

    End Sub
End Class
