Public Class Form1

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll, HScrollBar2.Scroll
        Label1.Text = "a=" & HScrollBar1.Value
        Label2.Text = "n=" & HScrollBar2.Value

        Dim a = HScrollBar1.Value
        Dim n = HScrollBar2.Value

        Dim ans As Long = 0
        Dim temp As Long = 0
        Dim detail As String = ""
        For i = 1 To n
            temp = temp * 10 + a
            ans += temp
            detail &= temp & "+"              '不要用Str(temp)，会产生额外空格。如果要这么用，为排版美观，建议写成detail &= Str(temp) & " +"
        Next

        detail = Mid(detail, 1, Len(detail) - 1)
        Label3.Text = "sum=" & detail & "=" & ans

    End Sub
End Class
