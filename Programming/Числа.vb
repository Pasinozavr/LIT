Public Class Form1
    Dim a() As String
    Dim na As Integer
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Integer
        na = CInt(InputBox("Введите кол-во элементов в массиве"))
        ReDim a(na)
        ListBox1.Items.Clear()
        For i = 1 To na
            a(i) = CInt(34 + Fix(61 * Rnd()))
            ListBox1.Items.Add(a(i))
        Next

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        ListBox2.Items.Clear()
        Dim i, c As Integer
        c = CInt(TextBox1.Text)
        If c < 0 Or c > 9 Then
            MsgBox("Последнее ЧИСЛО должно состоять из одного положительного числа")
        Else
            For i = 1 To na
                If a(i) Mod 10 = c Then
                    ListBox2.Items.Add(a(i))
                End If
            Next
        End If
        

    End Sub
End Class
