Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 1 To 8
            Label1.Text &= StrDup(18 - 2 * i, Chr(64 + i)) & vbCrLf
        Next
    End Sub
End Class
