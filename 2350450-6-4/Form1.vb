Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ans! = 0                             '求和结果
        Dim wheel = 1
        Dim x = 1                                '数列第i项的分母
        Dim y = 1 / x                            '数列第i项

        Do Until y < 10 ^ (-5)
            ans += y : Label3.Text = ans & Space(5) & Str(wheel) & "项"
            x += wheel : wheel += 1 : y = 1 / x
        Loop

        ans += y : Label3.Text = ans & Space(5) & Str(wheel - 1) & "项"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ans! = 0                             '求和结果
        Dim x = 1                                '数列第i项的分母
        Dim y = 1 / x                            '数列第i项

        For i = 1 To 447
            ans += y : Label4.Text = ans & Space(5) & Str(i) & "项"
            x += i : y = 1 / x
        Next
    End Sub
End Class
