Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "三位数的水仙花数有：" & vbCrLf & vbCrLf
        For x = 100 To 999
            Dim a = Val(Mid(x, 1, 1))
            Dim b = Val(Mid(x, 2, 1))
            Dim c = Val(Mid(x, 3, 1))

            If x = a ^ 3 + b ^ 3 + c ^ 3 Then
                Label1.Text &= x & vbCrLf & vbCrLf
            End If
        Next
    End Sub
End Class
