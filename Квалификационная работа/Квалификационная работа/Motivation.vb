Public Class Motivation
    Public groupbox_questions() As GroupBox
    Public n As Integer = 20
    Public combobox_questions() As ComboBox
    Dim quest() As String
    Dim answ() As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        GeneralTests.Show()
    End Sub

    Private Sub Motivation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 2000
        Timer1.Start()
        ReDim answ(n)
        ReDim combobox_questions(n)
        ReDim groupbox_questions(n)
        ReDim quest(n)
        Dim F As Long
        Dim y As Integer = 1
        F = FreeFile()
        FileOpen(F, "motivation.txt", OpenMode.Input)
        Do Until EOF(F)
            For y = 1 To n
                quest(y) = LineInput(F)
            Next
        Loop
        FileClose(F)
        For i = 1 To n
            groupbox_questions(i) = New GroupBox
            With groupbox_questions(i)
                .Text = "Питання № " & i & "/20. " & quest(i)
                .BackColor = Color.Gold
                .Width = 965
                .Height = 150
                .Tag = Str(i)
                .Visible = False
                .Location = New Point(10, 10)
            End With
            combobox_questions(i) = New ComboBox
            With combobox_questions(i)
                .Items.Add("так")
                .Items.Add("ні")
                .Tag = Str(i)
                .SelectedIndex = 0
                .Visible = False
                .Location = New Point(20, 70)
            End With
            If GeneralTests.CheckBox1.Checked = True Then
                Randomize()
                combobox_questions(i).SelectedIndex = Rnd()
            End If
            Me.Controls.Add(combobox_questions(i))
            Me.Controls.Add(groupbox_questions(i))
        Next
        combobox_questions(0) = New ComboBox
    End Sub
    Dim counter As Int16 = 0
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If counter > -1 Then
            Button2.Text = "Перейти до наступного питання"
        End If
        If counter = n Then
            GeneralTests.Button2.Enabled = False
            groupbox_questions(counter).Visible = False
            MsgBox("Тест закінчено")
            answers.Button3.Visible = True
            Me.Hide()
            GeneralTests.Show()

            If answ(1) = 0 Then
                GeneralTests.motiva += 1
            End If
            If answ(2) = 0 Then
                GeneralTests.motiva += 1
            End If
            If answ(3) = 0 Then
                GeneralTests.motiva += 1
            End If
            If answ(6) = 0 Then
                GeneralTests.motiva += 1
            End If
            If answ(8) = 0 Then
                GeneralTests.motiva += 1
            End If
            If answ(10) = 0 Then
                GeneralTests.motiva += 1
            End If
            If answ(11) = 0 Then
                GeneralTests.motiva += 1
            End If
            If answ(12) = 0 Then
                GeneralTests.motiva += 1
            End If
            If answ(14) = 0 Then
                GeneralTests.motiva += 1
            End If
            If answ(16) = 0 Then
                GeneralTests.motiva += 1
            End If
            If answ(18) = 0 Then
                GeneralTests.motiva += 1
            End If
            If answ(19) = 0 Then
                GeneralTests.motiva += 1
            End If
            If answ(20) = 0 Then
                GeneralTests.motiva += 1
            End If
            If answ(4) = 1 Then
                GeneralTests.motiva += 1
            End If
            If answ(5) = 1 Then
                GeneralTests.motiva += 1
            End If
            If answ(7) = 1 Then
                GeneralTests.motiva += 1
            End If
            If answ(9) = 1 Then
                GeneralTests.motiva += 1
            End If
            If answ(13) = 1 Then
                GeneralTests.motiva += 1
            End If
            If answ(15) = 1 Then
                GeneralTests.motiva += 1
            End If
            If answ(17) = 1 Then
                GeneralTests.motiva += 1
            End If


            If GeneralTests.motiva <= 7 Then
                MessageBox.Show("У вас діагностується мотивація на невдачу (боязнь невдачі)")
                MessageBox.Show("Мотивації на невдачу відноситься до негативної мотивації. При даному типі мотивації активність людини пов'язана з потребою уникнути зриву, осудження, покарання, невдачі. Взагалі в основі цієї мотивації лежить ідея уникнення і ідея негативних очікувань. Починаючи справу, людина вже заздалегідь боїться можливої невдачі, думає про шляхи уникнення цієї гіпотетичної невдачі, а не про способи досягнення успіху. Люди, мотивовані на невдачу, звичайно відрізняються підвищеною тривожністю, низькою впевненістю у своїх силах. Намагаються уникати відповідальних завдань, а при необхідності вирішення надміру відповідальні завдань можуть впадати в стан близький до панічного. Принаймні, ситуативна тривожність у них в цих випадках стає надзвичайно високою. Все це, разом з тим, може поєднуватися з досить відповідальним ставленням до справи.")
                GeneralTests.Label5.Text = "Боязнь невдачі"
                GeneralTests.odinokop += 2
                GeneralTests.Label6.Text = (GeneralTests.odinokop) & " %"

            ElseIf GeneralTests.motiva >= 14 And GeneralTests.motiva <= 20 Then
                MessageBox.Show("У вас діагностується мотивація на невдачу (надія на успіх)")
                MessageBox.Show("Мотивація на успіх відноситься до позитивної мотивації. При такій мотивації людина, починаючи справу, має на увазі досягнення чогось конструктивного, позитивного. В основі активності людини лежить надія на успіх і потреба в досягненні успіху. Такі люди зазвичай впевнені в собі, у своїх силах, відповідальні, ініціативні та активні. Їх відрізняє наполегливість у досягненні мети. цілеспрямованість.")
                GeneralTests.Label5.Text = "Надія на успіх"
                GeneralTests.odinokop -= 5
                GeneralTests.Label6.Text = (GeneralTests.odinokop) & " %"
            ElseIf GeneralTests.motiva >= 8 And GeneralTests.motiva <= 13 Then
                MessageBox.Show("Мотиваційний полюс яскраво не виражений")
                GeneralTests.Label5.Text = "Мотиваційний полюс яскраво не виражений"
            End If
            GeneralTests.Label5.Visible = True
        Else
            counter += 1
            combobox_questions(counter).Visible = True
            If counter > 1 Then
                combobox_questions(counter - 1).Visible = False
            End If
            groupbox_questions(counter).Visible = True
            If counter > 1 Then
                groupbox_questions(counter - 1).Visible = False
            End If
            answ(counter - 1) = combobox_questions(counter - 1).SelectedIndex
        End If
    End Sub
End Class