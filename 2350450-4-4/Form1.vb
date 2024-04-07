Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Label2.Text = "Val函数的结果"                          '设置标签文本默认值
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = "Val函数的结果"
        TextBox2.Text = Val(TextBox1.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = "Str函数的结果"

        If IsNumeric(TextBox1.Text) = False Then
            MsgBox("请在文本框1中输入数字")
        Else
            TextBox2.Text = Str(TextBox1.Text)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = "Chr函数的结果"
        TextBox2.Text = Chr(TextBox1.Text)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Label2.Text = "Asc函数的结果"
        TextBox2.Text = Asc(TextBox1.Text)
    End Sub
End Class
