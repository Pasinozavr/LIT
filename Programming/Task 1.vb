Public Class Form1
    Dim s As String
    Dim s1 As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ListBox1.Items.Clear()
        FileOpen(1, "textfile.txt", OpenMode.Input)
        Do While Not EOF(1)
            Input(1, s1)
            ListBox1.Items.Add(s1)
        Loop
        FileClose(1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim sl1, sl2 As String
        sl1 = TextBox1.Text
        sl2 = TextBox2.Text
        If ListBox1.Items.Contains(sl1) And ListBox1.Items.Contains(sl2) Then
            MessageBox.Show("Оба слова найдены!")
        Else
            MessageBox.Show("Оба слова, к сожалению, не найдены...")
        End If
    End Sub
End Class
