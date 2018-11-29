Public Class Willpower
    Public groupbox_questions() As GroupBox
    Public n As Integer = 15
    Public сombobox_questions() As ComboBox
    Dim quest(), answ() As String
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        GeneralTests.Show()
    End Sub

    Private Sub Willpower_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 2000
        Timer1.Start()
        ReDim answ(n)
        ReDim сombobox_questions(n)
        ReDim groupbox_questions(n)
        ReDim quest(n)
        Dim F As Long
        Dim y As Integer = 1
        F = FreeFile()
        FileOpen(F, "willpower.txt", OpenMode.Input)
        Do Until EOF(F)
            For y = 1 To n
                quest(y) = LineInput(F)
            Next
        Loop
        FileClose(F)
       
        For i = 1 To n
            groupbox_questions(i) = New GroupBox
            With groupbox_questions(i)
                .Text = "Питання № " & i & "/15. " & quest(i)
                .BackColor = Color.Gold
                .Width = 965
                .Height = 150
                .Tag = Str(i)
                .Visible = False
                .Location = New Point(10, 10)
            End With
            сombobox_questions(i) = New ComboBox
            With сombobox_questions(i)
                .Items.Add("так")
                .Items.Add("буває")
                .Items.Add("не знаю")
                .Items.Add("іноді")
                .Items.Add("ні")
                .SelectedIndex = 0
                If GeneralTests.CheckBox1.Checked = True Then
                    Randomize()
                    .SelectedIndex = 0 + Fix((4 - 0) * Rnd())
                End If
                .Tag = Str(i)
                .Visible = False
                .Location = New Point(20, 100)
            End With

            Me.Controls.Add(сombobox_questions(i))
            Me.Controls.Add(groupbox_questions(i))
        Next
        сombobox_questions(0) = New ComboBox
    End Sub
    Dim counter As Int16 = 0
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If counter > -1 Then
            Button2.Text = "Перейти до наступного питання"
        End If
        If counter = n Then
            GeneralTests.Button3.Enabled = False
            groupbox_questions(counter).Visible = False
            MsgBox("Тест закінчено")
            answers.Button4.Visible = True
            Me.Hide()
            GeneralTests.Show()


            For i = 1 To 15
                answers.RichTextBox2.Text = answers.RichTextBox2.Text & quest(i) & " - " & answ(i) & ControlChars.Lf
                If answ(i) = "так" Then
                    GeneralTests.volya += 2
                ElseIf answ(i) = "буває" Or answ(i) = "не знаю" Or answ(i) = "іноді" Then
                    GeneralTests.volya += 1
                ElseIf answ(i) = "ні" Then
                    GeneralTests.volya += 0
                End If
            Next

            If GeneralTests.volya <= 12 Then
                MessageBox.Show(" Сила волі слабка. З силою волі у Вас справи йдуть неважливо. Ви робите те, що легше і цікавіше. До обов'язків ставитеся абияк, що буває причиною різних неприємностей.")

                GeneralTests.Label4.Text = "Сила волі слабка"
                GeneralTests.odinokop += 2
                GeneralTests.Label6.Text = GeneralTests.odinokop & " %"
            ElseIf GeneralTests.volya > 13 And GeneralTests.volya <= 21 Then
                MessageBox.Show("Сила волі середня. Коли стикаєтеся з перешкодою, то починаєте діяти, щоб подолати його. Але якщо побачите обхідний шлях, скористаєтеся ним. Неприємну роботу постараєтеся виконати, хоча побурчіте. З доброї волі зайві зобов'язання на себе не візьмете.")
                GeneralTests.Label4.Text = "Сила волі середня"
                GeneralTests.odinokop += 1
            ElseIf GeneralTests.volya > 21 Then
                MessageBox.Show("Сила волі велика. На Вас можна покластися - Ви не підведете. Вас не лякають ні нові доручення, ні справи, які інших лякають.")
                GeneralTests.Label4.Text = "Сила волі велика"
                GeneralTests.odinokop -= 5
                GeneralTests.Label6.Text = GeneralTests.odinokop & " %"
            End If
            GeneralTests.Label4.Visible = True
        Else
            counter += 1
            сombobox_questions(counter).Visible = True
            If counter > 1 Then
                сombobox_questions(counter - 1).Visible = False
            End If
            groupbox_questions(counter).Visible = True
            If counter > 1 Then
                groupbox_questions(counter - 1).Visible = False
            End If
            answ(counter - 1) = сombobox_questions(counter - 1).SelectedItem
        End If
    End Sub


End Class