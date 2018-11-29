Public Class Form1
    Dim a(), b() As String
    Dim na, nb As Integer
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        na = CInt(InputBox("Введите кол-во слов массиве А"))
        nb = CInt(InputBox("Введите кол-во слов массиве В"))
        ReDim a(na)
        ReDim b(nb)
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        For i = 1 To na
            a(i) = InputBox("Введите элемент массива А")
            ListBox1.Items.Add(a(i))
        Next
        For i = 1 To nb
            b(i) = InputBox("Введите элемент массива B")
            ListBox2.Items.Add(b(i))
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim l, k As Integer
        If nb > na Then
            Label1.Text = "Массив B не входит в массив А, т.к. первый больше второго"
        Else
            Do While a(k) <> b(l)
                For l = 1 To nb
                    For k = 1 To na
                    Next
                Next
            Loop

            Do While a(k) = b(l)
                For l = nb To l Step -1
                    For k = na To k Step -1
                        If a(k) <> b(l) Then
                            Label1.Text = "Массив B не входит полностью в массив А"
                        End If
                    Next
                Next
            Loop
            Label1.Text = "Массив В входит в массив А"
        End If
    End Sub
End Class
