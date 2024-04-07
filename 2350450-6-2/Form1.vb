Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tail = Len(TextBox1.Text)
        For i = tail To 1 Step -1
            Dim wheel = Mid(TextBox1.Text, i, 1)
            If wheel >= "A" And wheel <= "Z" Or wheel >= "a" And wheel <= "z" Then TextBox2.Text &= wheel
        Next
    End Sub
End Class
