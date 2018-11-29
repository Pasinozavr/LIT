Public Class authorization
    Public na, fa As String
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click
        Label6.Visible = True
        TextBox1.Visible = True
        Label4.Visible = False
        Label5.Visible = False
        Label7.Visible = False
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox2.Visible = False
        Button6.Visible = True
        Label8.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Label6.Visible = False
        TextBox1.Visible = False
        Label4.Visible = True
        Label5.Visible = True
        Label7.Visible = False
        TextBox3.Visible = True
        TextBox4.Visible = True
        TextBox2.Visible = False
        Button6.Visible = True
        Label8.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Label6.Visible = False
        TextBox1.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label7.Visible = True
        TextBox3.Visible = False
        TextBox4.Visible = False
        TextBox2.Visible = True
        Button6.Visible = True
        Label8.Visible = False
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If TextBox1.Visible = True And TextBox1.Text = "123456" Then
            GeneralTests.CheckBox1.Visible = True
            MsgBox("Чіт ON/OFF включено")
            GeneralTests.CheckBox1.Checked = True
            Label8.Visible = False
            fa = "Автор"
            na = "Проекту"
            Me.Hide()
            GeneralTests.Show()
        ElseIf TextBox1.Visible = True And TextBox1.Text <> "123456" Then
            Label8.Visible = True
        End If
        If TextBox2.Visible = True And TextBox2.Text = "12345" Then
            PsychologistStart.Show()
            Me.Hide()
            Label8.Visible = False
        ElseIf TextBox2.Visible = True And TextBox2.Text <> "12345" Then
            Label8.Visible = True
        End If
        If TextBox3.Visible = True And TextBox3.Text <> "" And TextBox4.Text <> "" Then
            GeneralTests.CheckBox1.Checked = False
            GeneralTests.CheckBox1.Visible = False
            na = TextBox3.Text
            fa = TextBox4.Text
            PupiLStart.Show()
            Me.Hide()
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Help.Show()
    End Sub

    Private Sub authorization_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class