Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x! = Val(TextBox1.Text)

        If x < 0 Then
            MsgBox("荒唐！请重新输入价格")
        ElseIf x < 1000 Then
            TextBox2.Text = x
        ElseIf x < 2000 Then
            TextBox2.Text = 0.9 * x
        ElseIf x < 3000 Then
            TextBox2.Text = 0.8 * x
        Else
            TextBox2.Text = 0.7 * x
        End If
    End Sub
End Class
