Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x = TextBox1.Text
        Dim y = TextBox2.Text

        If RadioButton1.Checked = True Then
            TextBox3.Text = Val(x) + Val(y)
        ElseIf RadioButton2.Checked = True Then
            TextBox3.Text = Val(x) - Val(y)
        ElseIf RadioButton3.Checked = True Then
            TextBox3.Text = Val(x) * Val(y)
        Else
            If Val(y) = 0 Then
                MsgBox("分母为0", MsgBoxStyle.RetryCancel, "sy3-6")
                TextBox2.Text = "" : TextBox2.Focus()
            Else
                TextBox3.Text = Val(x) / Val(y)
            End If
        End If

        If CheckBox1.Checked = True Then TextBox3.ForeColor = Color.Red
        If CheckBox2.Checked = True Then TextBox3.BackColor = Color.Yellow
    End Sub
End Class
