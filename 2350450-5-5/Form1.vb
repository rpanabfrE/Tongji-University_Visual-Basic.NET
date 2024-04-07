Public Class Form1

    Sub Myresume()
        Label3.Text = "简历" & vbCrLf
        Label3.Text &= "姓名：" & TextBox1.Text & vbCrLf
        Label3.Text &= "年龄：" & TextBox2.Text & vbCrLf

        If RadioButton1.Checked = True Then
            Label3.Text &= "性别：" & RadioButton1.Text & vbCrLf
        ElseIf RadioButton2.Checked = True Then
            Label3.Text &= "性别：" & RadioButton2.Text & vbCrLf
        Else
            Label3.Text &= "性别：" & vbCrLf
        End If

        If RadioButton3.Checked = True Then
            Label3.Text &= "学历：" & RadioButton3.Text & vbCrLf
        ElseIf RadioButton4.Checked = True Then
            Label3.Text &= "学历：" & RadioButton4.Text & vbCrLf
        ElseIf RadioButton5.Checked = True Then
            Label3.Text &= "学历：" & RadioButton5.Text & vbCrLf
        Else
            Label3.Text &= "学历：" & vbCrLf
        End If

        If RadioButton6.Checked = True Then
            Label3.Text &= "职业：" & RadioButton6.Text & vbCrLf
        ElseIf RadioButton7.Checked = True Then
            Label3.Text &= "职业：" & RadioButton7.Text & vbCrLf
        ElseIf RadioButton8.Checked = True Then
            Label3.Text &= "职业：" & RadioButton8.Text & vbCrLf
        Else
            Label3.Text &= "职业：" & vbCrLf
        End If

        Label3.Text &= "爱好："
        If CheckBox1.Checked = True Then Label3.Text &= CheckBox1.Text & Space(2)
        If CheckBox2.Checked = True Then Label3.Text &= CheckBox2.Text & Space(2)
        If CheckBox3.Checked = True Then Label3.Text &= CheckBox3.Text & Space(2)
        If CheckBox4.Checked = True Then Label3.Text &= CheckBox4.Text & Space(2)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Myresume()
    End Sub

    Sub Myclear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False
        RadioButton8.Checked = False
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        Label3.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call Myclear()
    End Sub
End Class
