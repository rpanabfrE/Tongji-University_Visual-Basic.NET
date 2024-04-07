Public Class Form1

    Sub Mydate()
        If Len(TextBox1.Text) <> 18 Then
            MsgBox("身份证位数不是18位，请重新输入")
        Else
            Dim y$ = Str(Mid(TextBox1.Text, 7, 4))
            Dim m$ = Str(Mid(TextBox1.Text, 11, 2))
            Dim d$ = Str(Mid(TextBox1.Text, 13, 2))
            Label2.Text = "你的出生年月为：" & y & " 年" & m & " 月" & d & " 日"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Mydate()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call Mydate()
        End If
    End Sub
End Class
