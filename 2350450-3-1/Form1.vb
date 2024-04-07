Public Class Form1

    Sub Mynumber()
        Randomize()
        TextBox1.Text = Int(Rnd() * (999 - 100 + 1) + 100)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Mynumber()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Then
            MsgBox("请先随机产生一个三位正整数")
        End If
        Dim a% = TextBox1.Text \ 100
        Dim b% = TextBox1.Text \ 10 Mod 10
        Dim c% = TextBox1.Text Mod 10
        TextBox2.Text = c & b & a
    End Sub
End Class
