Public Class Form1
    Dim s, m, s1 As String
    Dim t, d As Integer
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        End
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim c As Integer
        d = 0
        RichTextBox1.Clear()
        ListBox1.Items.Clear()
        RichTextBox1.SaveFile("textfile.rtf")
        t = InputBox("Сколько строк вставить?")
        FileOpen(1, "textfile.rtf", OpenMode.Output)
        For i = 1 To t
            c = 1
            s1 = InputBox("")
            Write(1, s1)
            For j = 0 To s1.Length - 1
                If s1.Chars(j) = " " Then
                    c += 1
                End If
            Next
            d += c
            RichTextBox1.Text = RichTextBox1.Text & "слов в строке - " & c & "; "
        Next
        FileClose(1)
        FileOpen(1, "textfile.rtf", OpenMode.Input)
        Do While Not EOF(1)
            Input(1, s1)
            ListBox1.Items.Add(s1)
        Loop
        FileClose(1)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim otv As Single
        otv = d / ListBox1.Items.Count
        RichTextBox1.Text = RichTextBox1.Text & "среднее кол-во слов в строках - " & otv & "; "
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim dl, k As Integer
        k = 0
        dl = CInt(TextBox1.Text)
        FileOpen(1, "textfile.rtf", OpenMode.Input)
        Input(1, s1)
        If dl = s1.Length Then
            k = k + 1
        End If
        FileClose(1)

        If k = 0 Then
            MessageBox.Show("Нет, таких строк нет")
        Else
            MessageBox.Show("Да, такие строки есть")
        End If
    End Sub
End Class
