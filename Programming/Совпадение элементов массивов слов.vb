Public Class Form1
    Dim a(), b() As String
    Dim n As Integer
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        n = CInt(InputBox("Введите кол-во слов массивах"))
        ReDim a(n)
        ReDim b(n)
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        For i = 1 To n
            a(i) = InputBox("Введите элемент массива А")
            b(i) = InputBox("Введите элемент массива B")
            ListBox1.Items.Add(a(i))
            ListBox2.Items.Add(b(i))
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Label2.Text = "Массивы совпадают в элементах: "
        For l = 1 To n
            For k = 1 To n
                If a(l) = b(k) Then
                    Label2.Text = Label2.Text & a(l) & "; "
                End If
            Next
        Next
    End Sub
End Class
