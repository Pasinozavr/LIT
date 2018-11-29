Public Class BonusVideos


    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        AxWindowsMediaPlayer1.close()
        RichTextBox1.LoadFile("самотність.rtf")
        RichTextBox1.Visible = True
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        AxWindowsMediaPlayer1.close()
        RichTextBox1.LoadFile("депресія.rtf")
        RichTextBox1.Visible = True
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        AxWindowsMediaPlayer1.close()
        RichTextBox1.LoadFile("воля.rtf")
        RichTextBox1.Visible = True
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        AxWindowsMediaPlayer1.close()
        RichTextBox1.LoadFile("самооцінка.rtf")
        RichTextBox1.Visible = True
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        AxWindowsMediaPlayer1.close()
        RichTextBox1.LoadFile("сила волі.rtf")
        RichTextBox1.Visible = True
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        RichTextBox1.Visible = False
        AxWindowsMediaPlayer1.Visible = True
        AxWindowsMediaPlayer1.URL = "1.mp4"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        RichTextBox1.Visible = False
        AxWindowsMediaPlayer1.Visible = True
        AxWindowsMediaPlayer1.URL = "2.mp4"
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        RichTextBox1.Visible = False
        AxWindowsMediaPlayer1.Visible = True
        AxWindowsMediaPlayer1.URL = "3.mp4"
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        RichTextBox1.Visible = False
        AxWindowsMediaPlayer1.Visible = True
        AxWindowsMediaPlayer1.URL = "4.mp4"
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        RichTextBox1.Visible = False
        AxWindowsMediaPlayer1.Visible = True
        AxWindowsMediaPlayer1.URL = "5.mp4"
    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        AxWindowsMediaPlayer1.close()
        RichTextBox1.LoadFile("залежність.rtf")
        RichTextBox1.Visible = True
        AxWindowsMediaPlayer1.Visible = False
    End Sub

    Private Sub Button11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        AxWindowsMediaPlayer1.close()
        PupiLStart.Show()
        Me.Hide()
    End Sub
End Class