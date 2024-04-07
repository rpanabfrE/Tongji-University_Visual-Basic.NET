Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "☆" & vbCrLf

        For i = 2 To 10
            If i Mod 2 = 0 Then
                Label1.Text &= StrDup(2 * i - 1, "★") & vbCrLf
            Else
                Label1.Text &= StrDup(2 * i - 1, "☆") & vbCrLf
            End If
        Next
    End Sub
End Class
