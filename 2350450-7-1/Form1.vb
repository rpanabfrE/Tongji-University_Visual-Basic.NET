Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ans1# = 2
        Dim ans2# = 2

        For i = 1 To 50
            ans1 *= ((2 * i) ^ 2) / ((2 * i - 1) * (2 * i + 1))
        Next
        Label4.Text = ans1

        For i = 1 To 1000
            ans2 *= ((2 * i) ^ 2) / ((2 * i - 1) * (2 * i + 1))
        Next
        Label5.Text = ans2

    End Sub
End Class
