'好一个Visual Basic.Net！一学起来就发狠了！忘情了！没命了！百十个奇形怪状的语句块，如百十块被强震不断击起的石头，
'狂舞在你的面前。骤雨一样，是急促的ddl；旋风一样，是飞扬的知识点；乱蛙一样，是蹦跳的心理防线；火花一样，是互评的分数；
'斗虎一样，是无穷的作业。MOOC平台上，爆出一场多么壮阔、多么豪放、多么火烈的课程哇——Visual Basic.Net！

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "π的近似值是：" & vbCrLf
        Dim ans# = 0                                    'ans是π/4的值
        Dim i = 1
        Dim x% = 1                                      'x是第i项的分母
        Dim y# = 1 / x                                  'y是第i项的绝对值

        Do Until y < 10 ^ (-5)
            ans += y * ((-1) ^ (i + 1))
            i += 1 : x = 2 * i - 1 : y = 1 / x
        Loop

        Label1.Text &= 4 * ans
    End Sub
End Class
