Public Class Loneliness
    Public groupbox_questions() As GroupBox
    Public n As Integer = 20
    Public label_questions() As Label
    Public combobox_questions() As ComboBox
    Dim quest(), answ() As String
    Dim a As Integer = 0
    Dim b As Integer = 0
    Dim c As Integer = 0
    Dim d As Integer = 0
    Dim counter As Int16 = 0
    Private Sub Loneliness_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ReDim answ(n)
        ReDim combobox_questions(n)
        ReDim groupbox_questions(n)
        ReDim label_questions(n)
        ReDim quest(n)
        Dim F As Long
        Dim y As Integer = 1
        F = FreeFile()
        FileOpen(F, "loneliness.txt", OpenMode.Input)
        Do Until EOF(F)
            For y = 1 To n
                quest(y) = LineInput(F)
            Next
        Loop
        FileClose(F)
        For i = 1 To n
            groupbox_questions(i) = New GroupBox
            With groupbox_questions(i)
                .Text = "Питання № " & i & "/20."
                .BackColor = Color.Gold
                .Width = 965
                .Font = New Font("white", 15)
                .Height = 100
                .Tag = Str(i)
                .Visible = False
                .Location = New Point(10, 10)
            End With
            label_questions(i) = New Label
            With label_questions(i)
                .BackColor = Color.Gold
                .AutoSize = True
                .Text = quest(i)
                .Visible = False
                .Tag = Str(i)
                .Location = New Point(20, 40)
            End With
            combobox_questions(i) = New ComboBox
            With combobox_questions(i)
                .Items.Add("часто")
                .Items.Add("іноді")
                .Items.Add("рідко")
                .Items.Add("ніколи")
                .Tag = Str(i)
                .SelectedIndex = 1
                .Visible = False
                .Location = New Point(20, 70)
            End With
            If GeneralTests.CheckBox1.Checked = True Then
                Randomize()
                combobox_questions(i).SelectedIndex = 0 + Fix((3 - 0) * Rnd())
            End If
            Me.Controls.Add(combobox_questions(i))
            Me.Controls.Add(label_questions(i))
            Me.Controls.Add(groupbox_questions(i))
        Next
        combobox_questions(0) = New ComboBox
    End Sub
    Dim F As Long
    Dim ua As Integer = 0
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If counter > -1 Then
            Button1.Text = "Перейти до наступного питання"
        End If
        If counter = n Then
            GeneralTests.Button6.Enabled = False
            groupbox_questions(counter).Visible = False
            MsgBox("Тест закінчено")
            answers.Button7.Visible = True
            Me.Hide()
            timer1.interval = 1000
            timer1.start()

            GeneralTests.Button4.Visible = True
            GeneralTests.Show()
            a = a * 3
            b = b * 2
            c = c * 1
            d = d * 0
            GeneralTests.odinoko = a + b + c + d
            GeneralTests.odinokop = GeneralTests.odinoko * 4 / 3
            If GeneralTests.odinoko < 20 Then
                MessageBox.Show("Низький рівень самотності")
                GeneralTests.Label1.Text = "Низький рівень самотності"
                GeneralTests.Label6.Text = (GeneralTests.odinokop) & " %"
                GeneralTests.Label6.Visible = True

            ElseIf GeneralTests.odinoko >= 20 And GeneralTests.odinoko < 40 Then
                MessageBox.Show("Середній рівень самотності")
                GeneralTests.Label1.Text = "Середній рівень самотності"
                GeneralTests.Label6.Text = (GeneralTests.odinokop) & " %"
                GeneralTests.Label6.Visible = True

            ElseIf GeneralTests.odinoko >= 40 Then
                MessageBox.Show("Високий рівень самотності")
                GeneralTests.Label1.Text = "Високий рівень самотності"
                GeneralTests.Label6.Text = (GeneralTests.odinokop) & " %"
                GeneralTests.Label6.Visible = True
            End If
            GeneralTests.Label1.Visible = True

            F = FreeFile()
            FileOpen(F, "results.txt", OpenMode.Append)
            PrintLine(F, authorization.fa & " " & authorization.na & " - " & GeneralTests.odinokop & " %")
            FileClose(F)

        Else
            counter += 1
            combobox_questions(counter).Visible = True
            If counter > 1 Then
                combobox_questions(counter - 1).Visible = False
            End If
            label_questions(counter).Visible = True
            If counter > 1 Then
                label_questions(counter - 1).Visible = False
            End If
            groupbox_questions(counter).Visible = True
            If counter > 1 Then
                groupbox_questions(counter - 1).Visible = False
            End If

            If combobox_questions(counter - 1).SelectedIndex = 0 Then
                a += 1
            ElseIf combobox_questions(counter - 1).SelectedIndex = 1 Then
                b += 1
            ElseIf combobox_questions(counter - 1).SelectedIndex = 2 Then
                c += 1
            ElseIf combobox_questions(counter - 1).SelectedIndex = 3 Then
                d += 0
            End If
        End If
        GeneralTests.Button1.Enabled = True
        GeneralTests.Button5.Enabled = True
        GeneralTests.Button3.Enabled = True
        GeneralTests.Button2.Enabled = True

        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        GeneralTests.Show()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ua += 1
        If ua Mod 2 <> 0 Then
            GeneralTests.Button7.Visible = True
            GeneralTests.Button6.Visible = False
        Else
            GeneralTests.Button7.Visible = False
            GeneralTests.Button6.Visible = True
        End If
    End Sub
End Class