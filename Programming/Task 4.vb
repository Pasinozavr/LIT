Public Class Form1
    Dim s As String
    Dim s1 As String
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim a As String
        a = ""
        ListBox1.Items.Clear()
        FileOpen(1, "textfile.txt", OpenMode.Input)
        s = FreeFile()
        Do While Not EOF(1)
            Input(1, s1)
            ListBox1.Items.Add(s1)
            If s1.Length > a.Length Then
                a = s1
            End If
        Loop
        FileClose(1)
        MessageBox.Show("Самое длинное слово это  " & a)
    End Sub

End Class
