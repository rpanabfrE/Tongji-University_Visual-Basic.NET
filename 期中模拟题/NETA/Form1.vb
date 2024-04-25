Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a = Val(TextBox1.Text)    '期中
        Dim b = Val(TextBox2.Text)    '期末
        Dim c = Val(TextBox3.Text)    '平时

        Dim higher = b, lower = a    '默认更高的是期末
        If a > b Then
            higher = a : lower = b
        End If

        Dim sum = higher * 0.45 + lower * 0.4 + c * 0.15

        If sum >= 90 Then
            Label4.Text = "优秀！"
        ElseIf sum < 60 Then
            Label4.Text = "不及格！"
        Else
            Label4.Text = "及格"
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim chara$
        Label5.Text = "" : Label5.TextAlign = ContentAlignment.MiddleCenter
        For i = 1 To 15
            chara = Chr(64 + i)
            Label5.Text &= StrDup(2 * i - 1, chara) & vbCrLf
        Next
    End Sub
End Class
