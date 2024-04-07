Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Randomize()
        TextBox1.Text = Int(Rnd() * (9 - 1 + 1) + 1)
        TextBox2.Text = Int(Rnd() * (99 - 10 + 1) + 10)
        TextBox3.Text = Int(Rnd() * (999 - 100 + 1) + 100)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a, b, c As Integer
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        c = Val(TextBox3.Text)

        Dim avg! = (a + b + c) / 3
        avg = Str(Format(avg, "0.00"))
        Label4.Text = "三个数的平均值为：" & avg
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
