Public Class Form1

    Sub Myorder()
        Dim a% = Val(TextBox1.Text)
        Dim b% = Val(TextBox2.Text)
        Dim c% = Val(TextBox3.Text)

        If a > b And a > c Then
            Dim max1$ = Str(a)
            If b > c Then
                Dim mid2$ = Str(b)
                Dim min3$ = Str(c)
                Label2.Text = max1 & " >" & mid2 & " >" & min3
            Else
                Dim mid2$ = Str(c)
                Dim min3$ = Str(b)
                Label2.Text = max1 & " >" & mid2 & " >" & min3
            End If

        ElseIf b > a And b > c Then
            Dim max1$ = Str(b)
            If b > c Then
                Dim mid2$ = Str(a)
                Dim min3$ = Str(c)
                Label2.Text = max1 & " >" & mid2 & " >" & min3
            Else
                Dim mid2$ = Str(c)
                Dim min3$ = Str(a)
                Label2.Text = max1 & " >" & mid2 & " >" & min3
            End If

        Else
            Dim max1$ = Str(c)
            If b > c Then
                Dim mid2$ = Str(a)
                Dim min3$ = Str(b)
                Label2.Text = max1 & " >" & mid2 & " >" & min3
            Else
                Dim mid2$ = Str(b)
                Dim min3$ = Str(a)
                Label2.Text = max1 & " >" & mid2 & " >" & min3
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Myorder()
    End Sub

    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call Myorder()
        End If
    End Sub
End Class
