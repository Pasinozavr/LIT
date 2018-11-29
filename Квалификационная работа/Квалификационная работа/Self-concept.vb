Public Class Self_concept
    Public groupbox_questions() As GroupBox
    Public n As Integer = 10
    Public combobox_questions() As ComboBox
    Dim quest(), answ() As String
    Private Sub Self_concept_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 2000
        Timer1.Start()
        ReDim answ(n)
        ReDim combobox_questions(n)
        ReDim groupbox_questions(n)
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
        For i = 1 To n
            groupbox_questions(i) = New GroupBox
            With groupbox_questions(i)
                .Text = "Питання № " & i & "/10. " & quest(i)
                .BackColor = Color.Gold
                .Width = 965
                .Height = 150
                .Tag = Str(i)
                .Visible = False
                .Location = New Point(10, 10)
            End With
            combobox_questions(i) = New ComboBox
            With combobox_questions(i)
                .Items.Add("1")
                .Items.Add("2")
                .Items.Add("3")
                .Tag = Str(i)
                .SelectedIndex = 0
                .Visible = False
                .Location = New Point(20, 100)
            End With
            If GeneralTests.CheckBox1.Checked = True Then
                Randomize()
                combobox_questions(i).SelectedIndex = 0 + Fix((2 - 0) * Rnd())
            End If
            Me.Controls.Add(combobox_questions(i))
            Me.Controls.Add(groupbox_questions(i))
        Next
        combobox_questions(0) = New ComboBox
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        GeneralTests.Show()
    End Sub
    Dim counter As Int16 = 0
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If counter > -1 Then
            Button2.Text = "Перейти до наступного питання"
        End If
        If counter = n Then
            GeneralTests.Button5.Enabled = False
            groupbox_questions(counter).Visible = False
            MsgBox("Тест закінчено")
            answers.Button6.Visible = True
            Me.Hide()
            GeneralTests.Show()
            If answ(1) = 1 Then
                GeneralTests.bal += 1
            ElseIf answ(1) = 2 Then
                GeneralTests.bal += 3
            End If
            If answ(2) = 1 Then
                GeneralTests.bal += 5
            ElseIf answ(2) = 2 Then
                GeneralTests.bal += 1
            End If
            If answ(3) = 1 Then
                GeneralTests.bal += 5
            ElseIf answ(3) = 2 Then
                GeneralTests.bal += 1
            ElseIf answ(3) = 3 Then
                GeneralTests.bal += 3
            End If
            If answ(4) = 1 Then
                GeneralTests.bal += 3
            ElseIf answ(4) = 2 Then
                GeneralTests.bal += 4
            ElseIf answ(4) = 3 Then
                GeneralTests.bal += 1
            End If
            If answ(5) = 1 Then
                GeneralTests.bal += 1
            ElseIf answ(5) = 2 Then
                GeneralTests.bal += 5
            ElseIf answ(5) = 3 Then
                GeneralTests.bal += 3
            End If
            If answ(6) = 1 Then
                GeneralTests.bal += 5
            ElseIf answ(6) = 2 Then
                GeneralTests.bal += 3
            ElseIf answ(6) = 3 Then
                GeneralTests.bal += 1
            End If
            If answ(7) = 1 Then
                GeneralTests.bal += 1
            ElseIf answ(7) = 2 Then
                GeneralTests.bal += 5
            ElseIf answ(7) = 3 Then
                GeneralTests.bal += 3
            End If
            If answ(8) = 1 Then
                GeneralTests.bal += 1
            ElseIf answ(8) = 2 Then
                GeneralTests.bal += 5
            ElseIf answ(8) = 3 Then
                GeneralTests.bal += 3
            End If
            If answ(9) = 1 Then
                GeneralTests.bal += 5
            ElseIf answ(9) = 2 Then
                GeneralTests.bal += 1
            ElseIf answ(9) = 3 Then
                GeneralTests.bal += 3
            End If
            If answ(10) = 1 Then
                GeneralTests.bal += 1
            ElseIf answ(10) = 2 Then
                GeneralTests.bal += 3
            ElseIf answ(10) = 3 Then
                GeneralTests.bal += 5
            End If

            If GeneralTests.bal >= 10 And GeneralTests.bal <= 23 Then
                MessageBox.Show("Вочевидь, ви незадоволені собою, вас мучать сумніви і незадоволеність своїм інтелектом, здібностями, досягненнями, своєю зовнішністю, віком, статтю... Зупиніться! Хто сказав, що любити себе погано? Хто надоумив, що думаюча людина повинна бути постійно собою незадоволеною? Зрозуміло, ніхто не вимагає від вас самовдоволення, але ви повинні приймати себе, поважати себе, підтримувати в собі цей вогник.")
                GeneralTests.Label3.Text = "Низька самооцінка"
                GeneralTests.odinokop += 2
                GeneralTests.Label6.Text = (GeneralTests.odinokop) & " %"
            ElseIf GeneralTests.bal >= 24 And GeneralTests.bal <= 37 Then
                MessageBox.Show("Ви живете у злагоді з собою, знаєте себе і можете собі довіряти. Маєте дорогоцінне вміння знаходити вихід з важких ситуацій як особистого характеру, так і у взаєминах з людьми. Формулу вашого ставлення до себе і оточуючих можна виразити словами: «Задоволений собою , задоволений іншими». У вас нормальна здорова самооцінка, ви вмієте бути для себе підтримкою і джерелом сили і, що найголовніше, не за рахунок інших.")
                GeneralTests.Label3.Text = "Середня самооцінка"
            ElseIf GeneralTests.bal >= 38 And GeneralTests.bal <= 50 Then
                MessageBox.Show("Ви задоволені собою й упевнені в собі. У вас велика потреба домінувати над людьми, любите підкреслювати своє «я», виділяти свою думку. Вам байдуже те, що про вас говорять, але самі ви маєте схильність критикувати інших. Чим більше у вас балів, тим більше вам підходить визначення : «Ви любите себе, але не любите інших ».  Але у вас є один недолік: занадто серйозно до себе ставитеся, чи не приймаєте ніякої критичної інформації. І навіть якщо результати тесту вам не сподобаються, швидше за все, ви « захиститеся » твердженням « всі брешуть календарі ».  А шкода...")
                GeneralTests.Label3.Text = "Висока самооцінка"
                GeneralTests.odinokop -= 3
                GeneralTests.Label6.Text = (GeneralTests.odinokop) & " %"
            End If
            GeneralTests.Label3.Visible = True
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
            answ(counter - 1) = (combobox_questions(counter - 1).SelectedIndex + 1)
        End If
    End Sub
End Class