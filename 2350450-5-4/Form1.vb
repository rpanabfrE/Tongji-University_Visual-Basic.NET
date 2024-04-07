Imports System.Math
Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a = Val(TextBox1.Text)
        Dim b = Val(TextBox2.Text)
        Dim c = Val(TextBox3.Text)
        Dim delta = b ^ 2 - 4 * a * c

        If delta < 0 Then
            MsgBox("无实根")
        Else
            Dim X1 = (-b + Sqrt(delta)) / (2 * a)
            Dim X2 = (-b - Sqrt(delta)) / (2 * a)
            Label6.Text = Format(X1, "0.00")
            Label7.Text = Format(X2, "0.00")
        End If
    End Sub
End Class
