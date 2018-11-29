Public Class PupiLStart

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Help.Show()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        authorization.Show()
        Me.Hide()
        PictureBox4.Visible = False
        Timer1.Stop()
    End Sub

    Private Sub PupiLStart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label6.Text = Label6.Text & " " & authorization.fa & " " & authorization.na
        Label6.Visible = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        BonusVideos.Show()
        Me.Hide()
        PictureBox4.Visible = False
        Timer1.Stop()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        GeneralTests.Show()
        PictureBox4.Visible = False
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ch += 1
        Timer1.Interval = 2000
        Timer1.Start()
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label7.Visible = False
    End Sub
    Dim con As Integer = 0
    Dim ch As Integer = 0
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim nam As String
        If ch Mod 2 <> 0 Then
            PictureBox4.Visible = True
            con += 1
            nam = "Зависимость\" & con & ".jpg"
            If con = 23 Then
                con = 0
            End If
            PictureBox4.ImageLocation = nam
        Else
            Timer1.Stop()
            PictureBox4.Visible = False
            If Label1.Text <> "Ваша схильність до І-залежності:" Then
                Label2.Visible = True
                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label7.Visible = True
            End If
        End If
    End Sub

    Private Sub PictureBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox5.Click
        Application.Restart()
    End Sub
End Class