Public Class Form1
    Dim ms(,), b1(,), a, b As Integer

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, j As Byte
        a = CInt(InputBox("Введите кол-во строк"))
        b = CInt(InputBox("Введите кол-во столбцов"))
        ReDim ms(a, b)
        DataGridView1.ColumnCount = a + 1
        DataGridView1.RowCount = b + 1


        For i = 1 To a
            Randomize()
            For j = 1 To b
                ms(i, j) = 100 + Fix(999 - 100 + 1) * Rnd()
                DataGridView1.Rows(j).Cells(i).Value = ms(i, j)
            Next
        Next
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim c, c1, c2, d As Integer
        ListBox1.Items.Clear()
        c = CInt(TextBox1.Text)
        For i = 1 To a
            For j = 1 To b
                d = DataGridView1.Rows(j).Cells(i).Value
                c1 = d Mod 100
                c2 = c1 Mod 10
                If c2 = c Then
                    ListBox1.Items.Add(ms(i, j))
                End If
            Next
        Next
    End Sub
End Class
