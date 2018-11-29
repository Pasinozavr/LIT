Public Class Help
    Dim f(17) As Boolean


    Private Sub Help_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox4.Visible = False
        PictureBox2.Image = Image.FromFile("Скрины\скрин1.png")
        RichTextBox1.LoadFile("Помощь\помощь1.rtf")
        f(1) = True
        f(2) = False
        f(3) = False
        f(4) = False
        f(5) = False
        f(6) = False
        f(7) = False
        f(8) = False
        f(9) = False
        f(10) = False
        f(11) = False
        f(12) = False
        f(13) = False
        f(14) = False
        f(15) = False
        f(16) = False
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        If f(1) = True Then
            PictureBox2.Image = Image.FromFile("Скрины\скрин2.png")
            RichTextBox1.LoadFile("Помощь\помощь2.rtf")
            f(2) = True
            f(1) = False
            PictureBox4.Visible = True
        ElseIf f(2) = True Then
            PictureBox2.Image = Image.FromFile("Скрины\скрин3.png")
            RichTextBox1.LoadFile("Помощь\помощь3.rtf")
            f(3) = True
            f(2) = False
            PictureBox4.Visible = True
            PictureBox3.Visible = True
        ElseIf f(3) = True Then
            PictureBox2.Image = Image.FromFile("Скрины\скрин4.png")
            RichTextBox1.LoadFile("Помощь\помощь4.rtf")
            f(4) = True
            f(3) = False
            PictureBox4.Visible = True
            PictureBox3.Visible = True
        ElseIf f(4) = True Then
            PictureBox2.Image = Image.FromFile("Скрины\скрин5.png")
            RichTextBox1.LoadFile("Помощь\помощь5.rtf")
            f(5) = True
            f(4) = False
            PictureBox4.Visible = True
            PictureBox3.Visible = True
        ElseIf f(5) = True Then
            PictureBox2.Image = Image.FromFile("Скрины\скрин6.png")
            RichTextBox1.LoadFile("Помощь\помощь6.rtf")
            f(6) = True
            f(5) = False
            PictureBox4.Visible = True
            PictureBox3.Visible = True
        ElseIf f(6) = True Then
            PictureBox2.Image = Image.FromFile("Скрины\скрин7.png")
            RichTextBox1.LoadFile("Помощь\помощь7.rtf")
            f(7) = True
            f(6) = False
            PictureBox4.Visible = True
            PictureBox3.Visible = True
        ElseIf f(7) = True Then
            PictureBox2.Image = Image.FromFile("Скрины\скрин8.png")
            RichTextBox1.LoadFile("Помощь\помощь8.rtf")
            f(8) = True
            f(7) = False
            PictureBox4.Visible = True
            PictureBox3.Visible = True
        ElseIf f(8) = True Then
            PictureBox2.Image = Image.FromFile("Скрины\скрин9.png")
            RichTextBox1.LoadFile("Помощь\помощь9.rtf")
            f(9) = True
            f(8) = False
            PictureBox4.Visible = True
            PictureBox3.Visible = True
        ElseIf f(9) = True Then
            RichTextBox1.LoadFile("Помощь\помощь10.rtf")
            PictureBox2.Image = Image.FromFile("Скрины\скрин10.png")
            f(10) = True
            f(9) = False
            PictureBox4.Visible = True
            PictureBox3.Visible = True
        ElseIf f(10) = True Then
            PictureBox2.Image = Image.FromFile("Скрины\скрин11.png")
            RichTextBox1.LoadFile("Помощь\помощь11.rtf")
            f(11) = True
            f(10) = False
            PictureBox4.Visible = True
            PictureBox3.Visible = True
        ElseIf f(11) = True Then
            PictureBox2.Image = Image.FromFile("Скрины\скрин12.png")
            RichTextBox1.LoadFile("Помощь\помощь12.rtf")
            f(12) = True
            f(11) = False
            PictureBox4.Visible = True
            PictureBox3.Visible = True
        ElseIf f(12) = True Then
            RichTextBox1.LoadFile("Помощь\помощь13.rtf")
            PictureBox2.Image = Image.FromFile("Скрины\скрин13.png")
            f(13) = True
            f(12) = False
            PictureBox4.Visible = True
            PictureBox3.Visible = True
        ElseIf f(13) = True Then
            PictureBox2.Image = Image.FromFile("Скрины\скрин14.png")
            RichTextBox1.LoadFile("Помощь\помощь14.rtf")
            f(14) = True
            f(13) = False
            PictureBox4.Visible = True
            PictureBox3.Visible = True
        ElseIf f(14) = True Then
            PictureBox2.Image = Image.FromFile("Скрины\скрин15.png")
            RichTextBox1.LoadFile("Помощь\помощь15.rtf")
            f(15) = True
            f(14) = False
            PictureBox4.Visible = True
            PictureBox3.Visible = True
        ElseIf f(15) = True Then
            PictureBox2.Image = Image.FromFile("Скрины\скрин16.png")
            RichTextBox1.LoadFile("Помощь\помощь16.rtf")
            f(16) = True
            f(15) = False
            PictureBox4.Visible = True
            PictureBox3.Visible = False
        End If
    End Sub

    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        If f(16) = True Then
            f(16) = False
            f(15) = True
            PictureBox2.Image = Image.FromFile("Скрины\скрин15.png")
            RichTextBox1.LoadFile("Помощь\помощь15.rtf")
            PictureBox4.Visible = True
            PictureBox3.Visible = True
        ElseIf f(15) = True Then
            f(15) = False
            f(14) = True
            PictureBox2.Image = Image.FromFile("Скрины\скрин14.png")
            RichTextBox1.LoadFile("Помощь\помощь14.rtf")
            PictureBox4.Visible = True
            PictureBox3.Visible = True
        ElseIf f(14) = True Then
            f(14) = False
            f(13) = True
            PictureBox2.Image = Image.FromFile("Скрины\скрин13.png")
            RichTextBox1.LoadFile("Помощь\помощь13.rtf")
            PictureBox4.Visible = True
            PictureBox3.Visible = True
        ElseIf f(13) = True Then
            f(13) = False
            f(12) = True
            PictureBox2.Image = Image.FromFile("Скрины\скрин12.png")
            RichTextBox1.LoadFile("Помощь\помощь12.rtf")
            PictureBox3.Visible = True
            PictureBox4.Visible = True
        ElseIf f(12) = True Then
            f(12) = False
            f(11) = True
            PictureBox2.Image = Image.FromFile("Скрины\скрин11.png")
            RichTextBox1.LoadFile("Помощь\помощь11.rtf")
            PictureBox3.Visible = True
            PictureBox4.Visible = True
        ElseIf f(11) = True Then
            f(11) = False
            f(10) = True
            PictureBox2.Image = Image.FromFile("Скрины\скрин10.png")
            RichTextBox1.LoadFile("Помощь\помощь10.rtf")
            PictureBox3.Visible = True
            PictureBox4.Visible = True
        ElseIf f(10) = True Then
            f(10) = False
            f(9) = True
            PictureBox2.Image = Image.FromFile("Скрины\скрин9.png")
            RichTextBox1.LoadFile("Помощь\помощь9.rtf")
            PictureBox3.Visible = True
            PictureBox4.Visible = True
        ElseIf f(9) = True Then
            f(9) = False
            f(8) = True
            PictureBox2.Image = Image.FromFile("Скрины\скрин8.png")
            RichTextBox1.LoadFile("Помощь\помощь8.rtf")
            PictureBox3.Visible = True
            PictureBox4.Visible = True
        ElseIf f(8) = True Then
            f(8) = False
            f(7) = True
            PictureBox2.Image = Image.FromFile("Скрины\скрин7.png")
            RichTextBox1.LoadFile("Помощь\помощь7.rtf")
            PictureBox3.Visible = True
            PictureBox4.Visible = True
        ElseIf f(7) = True Then
            f(7) = False
            f(6) = True
            PictureBox2.Image = Image.FromFile("Скрины\скрин6.png")
            RichTextBox1.LoadFile("Помощь\помощь6.rtf")
            PictureBox3.Visible = True
            PictureBox4.Visible = True
        ElseIf f(6) = True Then
            f(6) = False
            f(5) = True
            PictureBox2.Image = Image.FromFile("Скрины\скрин5.png")
            RichTextBox1.LoadFile("Помощь\помощь5.rtf")
            PictureBox3.Visible = True
            PictureBox4.Visible = True
        ElseIf f(5) = True Then
            f(5) = False
            f(4) = True
            PictureBox2.Image = Image.FromFile("Скрины\скрин4.png")
            RichTextBox1.LoadFile("Помощь\помощь4.rtf")
            PictureBox3.Visible = True
            PictureBox4.Visible = True
        ElseIf f(4) = True Then
            f(4) = False
            f(3) = True
            PictureBox2.Image = Image.FromFile("Скрины\скрин3.png")
            RichTextBox1.LoadFile("Помощь\помощь3.rtf")
            PictureBox3.Visible = True
            PictureBox4.Visible = True
        ElseIf f(3) = True Then
            f(3) = False
            f(2) = True
            PictureBox2.Image = Image.FromFile("Скрины\скрин2.png")
            RichTextBox1.LoadFile("Помощь\помощь2.rtf")
            PictureBox3.Visible = True
            PictureBox4.Visible = True
        ElseIf f(2) = True Then
            f(2) = False
            f(1) = True
            PictureBox2.Image = Image.FromFile("Скрины\скрин1.png")
            RichTextBox1.LoadFile("Помощь\помощь1.rtf")
            PictureBox3.Visible = True
            PictureBox4.Visible = False
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
End Class