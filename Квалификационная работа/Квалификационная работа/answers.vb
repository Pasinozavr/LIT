Public Class answers

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        PupiLStart.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GeneralTests.Show()
        Me.Hide()
    End Sub

 
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        RichTextBox1.Visible = True
        RichTextBox2.Visible = False
        RichTextBox1.ResetText()
        For i = 1 To 20
            RichTextBox1.Text = RichTextBox1.Text & Loneliness.label_questions(i).Text & " - " & Loneliness.combobox_questions(i).SelectedItem & ControlChars.Lf
        Next
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        RichTextBox1.Visible = True
        RichTextBox2.Visible = False
        Dim quest() As String
        Dim n As Integer = 57
        ReDim quest(n)
        Dim F As Long
        Dim y As Integer = 1
        F = FreeFile()
        FileOpen(F, "temperament.txt", OpenMode.Input)
        Do Until EOF(F)
            For y = 1 To n
                quest(y) = LineInput(F)
            Next
        Loop
        FileClose(F)

        RichTextBox1.ResetText()
        For i = 1 To 57
            RichTextBox1.Text = RichTextBox1.Text & quest(i) & " - " & Temperament.combobox_questions(i).SelectedItem & ControlChars.Lf
        Next
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        RichTextBox1.Visible = True
        RichTextBox2.Visible = False
        Dim quest() As String
        Dim n As Integer = 10
        ReDim quest(n)
        Dim F As Long
        Dim y As Integer = 1
        F = FreeFile()
        FileOpen(F, "self-concept.txt", OpenMode.Input)
        Do Until EOF(F)
            For y = 1 To n
                quest(y) = LineInput(F)
            Next
        Loop
        FileClose(F)

        RichTextBox1.ResetText()
        For i = 1 To 10
            RichTextBox1.Text = RichTextBox1.Text & quest(i) & " - " & Self_concept.combobox_questions(i).SelectedItem & ControlChars.Lf
        Next
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        RichTextBox2.Visible = True
        RichTextBox1.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim quest() As String
        Dim n As Integer = 20
        ReDim quest(n)
        Dim F As Long
        Dim y As Integer = 1
        RichTextBox1.Visible = True
        RichTextBox2.Visible = False
        F = FreeFile()
        FileOpen(F, "motivation.txt", OpenMode.Input)
        Do Until EOF(F)
            For y = 1 To n
                quest(y) = LineInput(F)
            Next
        Loop
        FileClose(F)

        RichTextBox1.ResetText()
        For i = 1 To 20
            RichTextBox1.Text = RichTextBox1.Text & quest(i) & " - " & Motivation.combobox_questions(i).SelectedItem & ControlChars.Lf
        Next
    End Sub
End Class