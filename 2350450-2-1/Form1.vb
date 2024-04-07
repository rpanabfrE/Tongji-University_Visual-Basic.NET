Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Text = "装入窗体"
        Me.Size = New Size(320, 340)
        MaximizeBox = False
        MinimizeBox = True
        FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        Me.Icon = New Icon("misc34.ico")
        Me.BackgroundImage = Image.FromFile("1.jpg")
        Me.Cursor = New Cursor("key04.ico")                      '改变鼠标指针
    End Sub

    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Size = New Size(320, 340)
    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click
        Me.Text = "单击窗体"
        Me.BackgroundImage = Image.FromFile("2.jpg")
        Me.Cursor = New Cursor("key04.ico")                      '改变鼠标指针
    End Sub

    Private Sub Form1_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Me.Text = "双击窗体"
        Me.BackgroundImage = Nothing
        Me.Cursor = Cursors.Default                              '恢复鼠标指针
    End Sub

End Class
