Public Class GeneralTests
    Public dost, ekstra, emust, volya, odinoko, motiva, odinokop As Integer
    Public bal As Integer
    Public im, vos, temp, podtemp As String
    Dim predrasp As Integer
    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Loneliness.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Self_concept.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Temperament.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Willpower.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Motivation.Show()
        Me.Hide()
    End Sub

    Private Sub GeneralTests_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Show()
        MessageBox.Show("Для виявлення Вашої схильності до інтернет-залежності, Вам треба пройти 5 тестів. Спочатку перший, а потім у довільному порядку ще чотири. Кожен тест можна пройти лише один раз, тому будьте уважними при виборі відповідей.")
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Hide()
        PupiLStart.Show()
        PupiLStart.Label1.Text = "Ваша схильність до І-залежності:" & " " & Label6.Text

        If odinokop >= 80 Then
            PupiLStart.Label1.Visible = True
            PupiLStart.Label2.Visible = True
            PupiLStart.Label3.Visible = True
            PupiLStart.Label4.Visible = True
            PupiLStart.Label5.Visible = True
            PupiLStart.Label7.Visible = True
            PupiLStart.Label2.Text = "Ви занадто сильно залежите від Інтернету."
            PupiLStart.Label3.Text = "Буквально не можете без нього жити."
            PupiLStart.Label4.Text = "Ви не здатні самі контролювати, скільки часу йому віддаєте."
            PupiLStart.Label5.Text = "Вам обов'язково потрібно порадитися із психологом."
            PupiLStart.Label7.Text = "І як можна скоріше."
        ElseIf odinokop < 80 And odinokop > 50 Then
            PupiLStart.Label1.Visible = True
            PupiLStart.Label2.Visible = True
            PupiLStart.Label3.Visible = True
            PupiLStart.Label4.Visible = True
            PupiLStart.Label5.Visible = True
            PupiLStart.Label7.Visible = True
            PupiLStart.Label2.Text = "Вам все частіше доводиться стикатися з проблемами через надмірне використання Інтернету."
            PupiLStart.Label3.Text = "Ці проблеми на даному етапі можуть виникати час від часу або досить часто."
            PupiLStart.Label4.Text = "Ви все глибше занурюєтеся в залежність від комп'ютера."
            PupiLStart.Label5.Text = "Обов'язково зверніть свою увагу на вплив цього на ваше життя і виправте існуючий стан."
            PupiLStart.Label7.Text = "Поки ви ще можете зупинити свою залежність від інтернету власними силами."
        ElseIf odinokop >= 20 And odinokop <= 50 Then
            PupiLStart.Label1.Visible = True
            PupiLStart.Label2.Visible = True
            PupiLStart.Label3.Visible = True
            PupiLStart.Label4.Visible = True
            PupiLStart.Label5.Visible = True
            PupiLStart.Label7.Visible = True
            PupiLStart.Label2.Text = "Вам нема про що турбуватися."
            PupiLStart.Label3.Text = "Ви - самий звичайний інтернет-користувач."
            PupiLStart.Label4.Text = "Ви можете іноді витрачати на Інтернет більше часу, ніж потрібно..."
            PupiLStart.Label5.Text = "Але ви цілком взмозі контролювати самостійно використання Інтернету."
            PupiLStart.Label7.Text = "У вас немає залежності від Інтернету"
        ElseIf odinokop < 20 Then

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        answers.Show()
        Me.Hide()
    End Sub


    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        MsgBox("Пробачте, але Ви чи хтось інший вже пройшли цей тест. Щоб пройти його ще раз перезавантажте програму. Це робиться відповідним значком на головній формі.")
    End Sub

End Class