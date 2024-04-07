Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load            '启动时，Label2的默认Text值
        Label2.Text = Button1.Text & "函数的结果"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = Len(TextBox1.Text)
        Label2.Text = Button1.Text & "函数的结果"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Text = Chr(TextBox1.Text)
        Label2.Text = Button2.Text & "函数的结果"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox2.Text = LCase(TextBox1.Text)
        Label2.Text = Button3.Text & "函数的结果"
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim N%
        N = InputBox("请输入您想要该字符重复的次数N")

        TextBox2.Text = StrDup(N, TextBox1.Text)
        Label2.Text = Button4.Text & "函数的结果"
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim s1$
        s1 = InputBox("请输入您想要查找的字符子串s1")

        TextBox2.Text = InStr(TextBox1.Text, s1)
        Label2.Text = Button5.Text & "函数的结果"
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim N1%, N2%
        N1 = InputBox("请输入字符子串开取位N1")
        N2 = InputBox("请输入字符子串长度N2")

        TextBox2.Text = Mid(TextBox1.Text, N1, N2)
        Label2.Text = Button6.Text & "函数的结果"
    End Sub
End Class
