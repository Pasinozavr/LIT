Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim k, c, m As Integer
        k = TextBox1.Text
        c = RectangleShape1.Size.Height
        m = RectangleShape1.Size.Width
        RectangleShape1.Size = New Point(m + k, c)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim l, v, n As Integer
        l = TextBox2.Text
        v = RectangleShape1.Size.Height
        n = RectangleShape1.Size.Width
        RectangleShape1.Size = New Point(n, v + l)
    End Sub
End Class
