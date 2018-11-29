Public Class Form1
    Dim s As String
    Dim s1 As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim i As Integer
        ListBox1.Items.Clear()
        FileOpen(1, "textfile.txt", OpenMode.Output)
        For i = 1 To InputBox("Сколько слов вставить?")
            s1 = InputBox("")
            Print(1, s1)
        Next
        
        FileClose(1)
        FileOpen(1, "textfile.txt", OpenMode.Input)
        Do While Not EOF(1)
            Input(1, s1)
            ListBox1.Items.Add(s1)
        Loop
        FileClose(1)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, kol, a As Integer
        a = 0
        kol = ListBox1.Items.Count
        For i = 2 To kol
            If ListBox1.Items.Item(i) <> ListBox1.Items.Item(i - 1) Then
                a += 1
            End If
        Next
        If a > 0 Then
            MessageBox.Show("Не все слова одинаковы..")
        Else
            MessageBox.Show("Все слова одинаковы!")
        End If

    End Sub
End Class
