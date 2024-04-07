Public Class Form1

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        Dim M% = Val(TextBox1.Text)                             'M为头数
        Dim N% = Val(TextBox2.Text)                             'N为脚数

        If N Mod 2 <> 0 Then
            MsgBox("输入的总脚数N必须是偶数")
        End If

        Dim x$, y$                                              '鸡为x只，兔为y只
        y = Str(N / 2 - M)
        x = Str(M - y)

        If x < 0 Or y < 0 Then
            MsgBox("荒唐解，请重新输入")
        Else
            Label2.Text = "            " & x & "       " & y
        End If
    End Sub
End Class
