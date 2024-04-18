Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For ans = 301 To 400
            If ans Mod 3 = 2 Then
                If ans Mod 5 = 3 Then
                    If ans Mod 7 = 2 Then
                        Label2.Text &= "答案为" & ans
                        Exit For
                    End If
                End If
            End If
        Next
    End Sub
End Class
