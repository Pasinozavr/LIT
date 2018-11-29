Public Class Search

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Help.Show()
    End Sub

    Private Sub Search_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim F As Long
        ListBox1.Items.Clear()
        F = FreeFile()
        FileOpen(F, "results.txt", OpenMode.Input)
        Do Until EOF(F)
            ListBox1.Items.Add(LineInput(F))
        Loop
        FileClose(F)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        PsychologistStart.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Dim F As Long
        ListBox1.Items.Clear()
        F = FreeFile()
        FileOpen(F, "results.txt", OpenMode.Input)
        Do Until EOF(F)
            ListBox1.Items.Add(LineInput(F))
        Loop
        FileClose(F)
    End Sub
    Dim uz As Integer = 0
    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click
        uz += 1
        If uz Mod 2 <> 0 Then
            Label1.Visible = True
            Label49.Visible = True
            TextBox1.Visible = True
            TextBox2.Visible = True
            Label2.ForeColor = Color.DarkBlue
            
            Label4.Visible = True



            Label6.ForeColor = Color.Black
            TextBox4.Visible = False
        Else
            Label1.Visible = False
            Label49.Visible = False
            TextBox1.Visible = False
            TextBox2.Visible = False

            Label2.ForeColor = Color.Black
            Label4.Visible = False
        End If
       
    End Sub
    Dim uf As Integer = 0

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim F As Long
        Dim min, max, strok, s1, s2 As String

        Dim l1, l2, i, s As Integer


        ListBox1.Items.Clear()
        F = FreeFile()
        FileOpen(F, "results.txt", OpenMode.Input)
        If Label2.ForeColor = Color.DarkBlue Then
            If TextBox2.Text = "" Or TextBox1.Text = "" Or TextBox2.Text = "" And TextBox1.Text = "" Then
                MsgBox("Неправильно введений критерій пошуку")
            Else
                min = TextBox1.Text
                max = TextBox2.Text
                Do Until EOF(F)
                    strok = LineInput(F)
                    If Val(strok.Chars(strok.Length - 4) + strok.Chars(strok.Length - 3)) >= min And Val(strok.Chars(strok.Length - 4) + strok.Chars(strok.Length - 3)) <= max Then
                        ListBox1.Items.Add(strok)
                    End If
                Loop
            End If
        End If
        If Label6.ForeColor = Color.DarkBlue Then
            If TextBox4.Text = "" Then
                MsgBox("Неправильно введений критерій пошуку")
            Else
                s2 = TextBox4.Text
                l2 = s2.Length
                Do Until EOF(F)
                    s1 = LineInput(F)
                    l1 = s1.Length
                    If l1 < l2 Then
                    Else
                        i = 0
                        s = 0
                        Do While l1 - l2 > i
                            If s2 = Mid(s1, i + 1, l2) Then
                                ListBox1.Items.Add(s1)
                                s += 1
                                i = i + l2
                            Else
                                i += 1
                            End If
                        Loop
                    End If
                Loop
            End If
        End If

        FileClose(F)
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click
        Label6.ForeColor = Color.DarkBlue
        TextBox4.Visible = True

        Label1.Visible = False
        Label49.Visible = False
        TextBox1.Visible = False
        TextBox2.Visible = False
        Label2.ForeColor = Color.Black
        
        Label4.Visible = False

    End Sub
End Class