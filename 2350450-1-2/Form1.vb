Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click                      '自动
        Timer1.Interval = 200
        Timer1.Enabled += 1                      '每按一次按钮，Enabled值取反
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Call Mymove()
    End Sub
    Sub Mymove()
        Label1.Left = Label1.Left + 10
        If Label1.Left > Me.Width Then
            Label1.Left = 0
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click                      '手动
        Timer1.Enabled = False
        Call Mymove()
    End Sub

End Class
