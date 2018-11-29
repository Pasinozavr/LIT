Public Class Temperament
    Public groupbox_questions() As GroupBox
    Public n As Integer = 57
    Public combobox_questions() As ComboBox
    Dim quest(), a() As String
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
            GeneralTests.Button1.Enabled = False
            groupbox_questions(counter).Visible = False
            MsgBox("Тест закінчено")
            answers.Button5.Visible = True

            Me.Hide()
            GeneralTests.Show()
            If a(6) = "так" Then
                GeneralTests.dost += 1
            End If
            If a(24) = "так" Then
                GeneralTests.dost += 1
            End If
            If a(36) = "так" Then
                GeneralTests.dost += 1
            End If
            If a(12) = "ні" Then
                GeneralTests.dost += 1
            End If
            If a(18) = "ні" Then
                GeneralTests.dost += 1
            End If
            If a(30) = "ні" Then
                GeneralTests.dost += 1
            End If
            If a(42) = "ні" Then
                GeneralTests.dost += 1
            End If
            If a(48) = "ні" Then
                GeneralTests.dost += 1
            End If
            If a(54) = "ні" Then
                GeneralTests.dost += 1
            End If
            If GeneralTests.dost >= 5 Then
                MessageBox.Show("Ви відповідали не так, як є насправді, а так як Вам хотілось би чи так, как прийнято в суспільстві. Іншими словами, Ваші відповіді не достовірні.")
            End If


            If a(1) = "так" Then
                GeneralTests.ekstra += 1
            End If
            If a(3) = "так" Then
                GeneralTests.ekstra += 1
            End If
            If a(8) = "так" Then
                GeneralTests.ekstra += 1
            End If
            If a(10) = "так" Then
                GeneralTests.ekstra += 1
            End If
            If a(13) = "так" Then
                GeneralTests.ekstra += 1
            End If
            If a(17) = "так" Then
                GeneralTests.ekstra += 1
            End If
            If a(22) = "так" Then
                GeneralTests.ekstra += 1
            End If
            If a(52) = "так" Then
                GeneralTests.ekstra += 1
            End If
            If a(27) = "так" Then
                GeneralTests.ekstra += 1
            End If
            If a(37) = "так" Then
                GeneralTests.ekstra += 1
            End If
            If a(39) = "так" Then
                GeneralTests.ekstra += 1
            End If
            If a(44) = "так" Then
                GeneralTests.ekstra += 1
            End If
            If a(46) = "так" Then
                GeneralTests.ekstra += 1
            End If
            If a(49) = "так" Then
                GeneralTests.ekstra += 1
            End If
            If a(53) = "так" Then
                GeneralTests.ekstra += 1
            End If
            If a(56) = "так" Then
                GeneralTests.ekstra += 1
            End If

            If a(5) = "ні" Then
                GeneralTests.ekstra += 1
            End If
            If a(15) = "ні" Then
                GeneralTests.ekstra += 1
            End If
            If a(20) = "ні" Then
                GeneralTests.ekstra += 1
            End If
            If a(29) = "ні" Then
                GeneralTests.ekstra += 1
            End If
            If a(32) = "ні" Then
                GeneralTests.ekstra += 1
            End If
            If a(34) = "ні" Then
                GeneralTests.ekstra += 1
            End If
            If a(41) = "ні" Then
                GeneralTests.ekstra += 1
            End If
            If a(51) = "ні" Then
                GeneralTests.ekstra += 1
            End If

            If a(2) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(4) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(7) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(9) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(11) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(14) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(16) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(19) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(21) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(23) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(26) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(28) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(31) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(33) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(35) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(38) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(40) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(43) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(45) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(47) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(50) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(52) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(55) = "так" Then
                GeneralTests.emust += 1
            End If
            If a(57) = "так" Then
                GeneralTests.emust += 1
            End If


            If GeneralTests.ekstra >= 1 And GeneralTests.ekstra <= 12 And GeneralTests.emust >= 12 And GeneralTests.emust >= 24 Then
                GeneralTests.temp = "Меланхолік"
                GeneralTests.odinokop += 2
                GeneralTests.Label6.Text = (GeneralTests.odinokop) & " %"
            ElseIf GeneralTests.ekstra >= 12 And GeneralTests.ekstra <= 24 And GeneralTests.emust >= 12 And GeneralTests.emust <= 24 Then
                GeneralTests.temp = "Холерик"
                GeneralTests.odinokop += 2
                GeneralTests.Label6.Text = (GeneralTests.odinokop) & " %"
            ElseIf GeneralTests.ekstra >= 1 And GeneralTests.ekstra <= 12 And GeneralTests.emust >= 1 And GeneralTests.emust <= 12 Then
                    GeneralTests.temp = "Флегматик"
                    GeneralTests.odinokop += 2
                GeneralTests.Label6.Text = (GeneralTests.odinokop) & " %"
            ElseIf GeneralTests.ekstra >= 12 And GeneralTests.ekstra <= 24 And GeneralTests.emust >= 12 And GeneralTests.emust >= 24 Then
                GeneralTests.temp = "Сангвінік"
                GeneralTests.odinokop -= 5
                GeneralTests.Label6.Text = (GeneralTests.odinokop) & " %"
            Else
                GeneralTests.temp = "Сангвінік"
                GeneralTests.odinokop -= 5
                GeneralTests.Label6.Text = (GeneralTests.odinokop) & " %"
            End If


                GeneralTests.Label2.Text = GeneralTests.temp
            GeneralTests.Label2.Visible = True

                If GeneralTests.temp = "Меланхолік" Then
                    MessageBox.Show("Людина легко ранима, схильна до постійного переживання різних подій, вона гостро реагує на зовнішні фактори. Меланхолік підвищено вразливий, легко емоційно ранимий, уразливий, але при цьому чутливий і чуйний, легко уживається з різними людьми, неконфліктний. У нього слабка нервова система, підвищена стомлюваність, низька психічна активність, повільність. Він високо емоційний, але схильний переживати проблеми всередині себе, що призводить до саморуйнування. Його почуття глибокі, постійні, стійкі, але при цьому слабко виражені. Йому важко зосереджуватися на чомусь протягом довгого часу. Меланхолік важко і гостро переживає невдачі (часто опускаються руки), він боязкий, сором'язливий, тривожний, нерішучий, нестійкий до стресів, мова тиха, повільна. Він замкнутий, нетовариський, тихий, песимістичний, у нього легко змінюється настрій, але при цьому меланхолік розсудливий. У здоровій обстановці працездатний, може виконувати монотонну роботу, що вимагає уваги, посидючості, терпіння, зосередженості. Людина глибока, змістовна. А ось за несприятливих обставин стає тривожною, замкнутою, боязкою, вразливою.")
                End If
                If GeneralTests.temp = "Холерик" Then
                    MessageBox.Show("Швидкий, пристрасний, поривчастий, відкритий, з швидкими змінами настрою. Холерик активний, рухливий, оптимістичний, імпульсивний, але при цьому легко збуджуваний і неспокійний. У холерика теж сильна нервова система, але він неврівноважений, вибуховий, дратівливий, нетерплячий, уразливий. У нього можливі емоційні зриви. Через конфліктності погано уживається з іншими людьми. Холерик легко переключається з однієї справи/теми розмови на іншу справу/тему, йому властиві різкі зміни настрою. У нього яскраво виражені емоційні переживання, він не здатний контролювати свої емоції. Рухи і мова у холерика швидкі, переривчасті, різкі, стрімкі, імпульсивні. Схильний до виснаження, так як при захопленості справою діє з усіх сил. В інтересах суспільства ініціативний, принциповий, активний, енергійний. За відсутності духовного та особистісного зростання аффективен, дратівливий, запальний, агресивний, нестриманий, конфліктний.")
                End If
                If GeneralTests.temp = "Флегматик" Then
                    MessageBox.Show("Неквапливий, незворушний, має стійкі прагнення і настрій, зовні скупий на прояв емоцій і почуттів. Володіє логічністю суджень. Він володіє сильною, врівноваженою, працездатною нервовою системою, завзятий, наполегливий трудівник, справи доводить до кінця. Найчастіше спокійний, стриманий і постійний в почуттях, настрій рівний, рідко виходить з себе. Здатний на глибокі, стабільні та постійні почуття. Флегматик миролюбний, уважний, турботливий. У міру балакучий, не любить базікати по дурницях. Заощаджує енергію, не витрачає її даремно. Міміка, мова, жести і дії повільні і спокійні, стримані, емоційно невиразні. Грунтовний, надійний, відрізняється глибиною і постійністю думок. Але флегматик насилу перемикається з однієї роботи на іншу, довго 'розгойдується', погано адаптується в новій обстановці, пасивний (низький рівень активності), складно виробляє нові звички і моделі поведінки, але вони при цьому стають стійкими. Йому властиві млявість, лінь, байдужість до оточуючих, безвольність. Схильний виконувати звичну роботу у звичній, знайомій обстановці")
                End If
                If GeneralTests.temp = "Сангвінік" Then
                    MessageBox.Show("Жива, гаряча, рухлива людина, з частою зміною настрою, вражень, з швидкою реакцією на всі події, що відбуваються навколо нього, досить легко примиряється зі своїми невдачами і неприємностями. Сангвінік веселий, доброзичливий, балакучий, поступливий, чуйний. У нього сильна, врівноважена нервова система, висока працездатність, при цьому він активний і рухливий, легко переживає невдачі. Він легко спілкується з людьми, швидко сходиться з людьми, легко переключається, легко і швидко реагує на те, що відбувається навколо. При цьому він прагне до новизни, зміни вражень, непосидючий, недостатньо регулює свої імпульси. У нього багата, рухлива міміка, швидка, виразна мова. Сангвінік не може виконувати справи, що вимагають зосередженості, уваги, посидючості, терпіння. У нього відбувається швидка зміна почуттів, але почуття неглибокі, схильний до непостійності, поверховості.")
                End If


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
                a(counter - 1) = combobox_questions(counter - 1).SelectedItem
            End If
    End Sub
    Dim counter1488 As Integer = 1
    Private Sub Temperament_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 2000
        Timer1.Start()
        ReDim a(n)
        ReDim combobox_questions(n)
        ReDim groupbox_questions(n)
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
        For i = 1 To n
            groupbox_questions(i) = New GroupBox
            With groupbox_questions(i)
                .Text = "Питання № " & i & "/57. " & quest(i)
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
                .SelectedIndex = 0
                .Tag = Str(i)
                .Visible = False
                .Location = New Point(20, 100)
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

End Class