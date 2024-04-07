Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click            '计算圆周长
        Const PI = 3.1415
        Dim r# = Val(TextBox1.Text)
        Dim c# = Val(2 * PI * r)
        Label2.Text = Format(c, "0.00")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click            '计算圆半径
        Const PI = 3.141
        Dim r# = Val(TextBox1.Text)
        Dim s# = Val(PI * r * r)
        Label3.Text = Format(s, "0.00")
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Asc(e.KeyChar) = 13 Then                                       'Asc(e.KeyChar) = 13代表按下回车键
            If IsNumeric(TextBox1.Text) = False Then
                TextBox1.Text = ""
                TextBox1.Focus()

                Dim Msg, Title, Response
                Msg = "您的输入含有非数字字符，请重新输入"                '定义消息文本
                Title = "数据检验"                                        '定义标题文本
                Response = MsgBox(Msg, , Title)
            End If
        End If
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        If IsNumeric(TextBox1.Text) = False Then
            TextBox1.Text = ""
            TextBox1.Focus()

            Dim Msg, Title, Response
            Msg = "您的输入有非数字字符，请重新输入"
            Title = "数据检验"
            Response = MsgBox(Msg, , Title)
        End If
    End Sub
End Class