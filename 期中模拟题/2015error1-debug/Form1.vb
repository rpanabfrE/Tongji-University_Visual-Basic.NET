Public Class Form1
    '改错题1，2个错误
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a%, b%, k%, x$
        x = TextBox1.Text    '赋值语句使用错误，已改正
        k = InStr(x, ",")
        a = Mid(x, 1, k - 1)    'mid参数使用错误，中间的“开始位数”参数应当为1，随后是所取字符长度，已改正
        b = Mid(x, k + 1)
        Label1.Text = a & vbCrLf & b
    End Sub
    '改错题2，3个错误
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fsell, fpay As Single    '数据类型应当使用单精度浮点数
        fsell = Val(TextBox2.Text)
        If fsell > 2000 Then
            fpay = fsell * 0.8
        ElseIf 2000 >= fsell And fsell > 1000 Then    '不能使用连续比较
            fpay = fsell * 0.9
        Else
            fpay = fsell
        End If
        Label2.Text = "应付(元):" & fpay    '变量放在说明字符串内，已改正
    End Sub
    '改错题3，3个错误
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim n, i As Integer
        Dim sum, xi As Double
        sum = 0    '初始值应当设为0，已改正
        n = Val(TextBox3.Text)
        i = 1
        Do While i <= n    '循环条件，不等号方向写错了
            If i Mod 2 = 0 Then
                xi = Math.Exp(i)
            Else
                xi = Math.Exp(-i)
            End If
            sum += xi / i    '应当为sum = sum + xi / i，已改正
            i = i + 1
        Loop
        Label3.Text = sum
    End Sub

End Class
