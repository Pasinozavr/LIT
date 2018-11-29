Public Class PsychologistStart

    Private Sub PictureBox2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        authorization.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Help.Show()
    End Sub

    Private Sub PictureBox3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        BonusVideos.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim F As Long
        ListBox1.Visible = True
        ListBox1.Items.Clear()

        F = FreeFile()
        FileOpen(F, "results.txt", OpenMode.Input)
        Do Until EOF(F)
            ListBox1.Items.Add(LineInput(F))
        Loop
        FileClose(F)
        Button9.Visible = True
    End Sub
    Dim cu As Integer = 0
    Dim cs As Integer = 0
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        cu += 1
        If cu Mod 2 <> 0 Then
            Button3.Visible = True
            Button4.Visible = True
            Button5.Visible = True
            Button7.Visible = True
            Button8.Visible = True
        Else
            Button3.Visible = False
            Button4.Visible = False
            Button5.Visible = False
            Button7.Visible = False
            Button8.Visible = False

            Label1.Visible = False
            Label2.Visible = False
            Label3.Visible = False
            Label4.Visible = False
            Label6.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            Label10.Visible = False
            Label11.Visible = False
            Label5.Visible = False
            Label12.Visible = False
            Label13.Visible = False

            Label14.Visible = False
            Label15.Visible = False
            Label16.Visible = False
            Label17.Visible = False
            Label18.Visible = False
            Label19.Visible = False
            Label20.Visible = False
            Label21.Visible = False

            PictureBox4.Visible = False

            Label22.Visible = False
            Label23.Visible = False
            Label24.Visible = False
            Label25.Visible = False
            Label26.Visible = False
            Label27.Visible = False
            Label28.Visible = False
            Label29.Visible = False
            Label30.Visible = False
            Label31.Visible = False
            Label32.Visible = False
            Label33.Visible = False
            Label34.Visible = False
            Label35.Visible = False

            Label36.Visible = False
            Label37.Visible = False
            Label38.Visible = False
            Label39.Visible = False
            Label40.Visible = False
            Label41.Visible = False
            Label42.Visible = False

            Label43.Visible = False
            Label44.Visible = False
            Label45.Visible = False
            Label46.Visible = False
            Label47.Visible = False
            Label48.Visible = False
            Label49.Visible = False
        End If
        
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        PictureBox5.Visible = False
        Label1.Visible = True
        Label2.Visible = True
        Label3.Visible = True
        Label4.Visible = True
        Label6.Visible = True
        Label7.Visible = True
        Label8.Visible = True
        Label9.Visible = True
        Label10.Visible = True
        Label11.Visible = True
        Label5.Visible = True
        Label12.Visible = True
        Label13.Visible = True

        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label17.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        Label21.Visible = False

        PictureBox4.Visible = False

        Label22.Visible = False
        Label23.Visible = False
        Label24.Visible = False
        Label25.Visible = False
        Label26.Visible = False
        Label27.Visible = False
        Label28.Visible = False
        Label29.Visible = False
        Label30.Visible = False
        Label31.Visible = False
        Label32.Visible = False
        Label33.Visible = False
        Label34.Visible = False
        Label35.Visible = False

        Label36.Visible = False
        Label37.Visible = False
        Label38.Visible = False
        Label39.Visible = False
        Label40.Visible = False
        Label41.Visible = False
        Label42.Visible = False

        Label43.Visible = False
        Label44.Visible = False
        Label45.Visible = False
        Label46.Visible = False
        Label47.Visible = False
        Label48.Visible = False
        Label49.Visible = False

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        PictureBox5.Visible = False
        Label14.Visible = True
        Label15.Visible = True
        Label16.Visible = True
        Label17.Visible = True
        Label18.Visible = True
        Label19.Visible = True
        Label20.Visible = True
        Label21.Visible = True
        PictureBox4.Visible = True

        Label22.Visible = False
        Label23.Visible = False
        Label24.Visible = False
        Label25.Visible = False
        Label26.Visible = False
        Label27.Visible = False
        Label28.Visible = False
        Label29.Visible = False
        Label30.Visible = False
        Label31.Visible = False
        Label32.Visible = False
        Label33.Visible = False
        Label34.Visible = False
        Label35.Visible = False

        Label36.Visible = False
        Label37.Visible = False
        Label38.Visible = False
        Label39.Visible = False
        Label40.Visible = False
        Label41.Visible = False
        Label42.Visible = False

        Label43.Visible = False
        Label44.Visible = False
        Label45.Visible = False
        Label46.Visible = False
        Label47.Visible = False
        Label48.Visible = False

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label5.Visible = False
        Label12.Visible = False
        Label13.Visible = False
        Label49.Visible = False
    End Sub


    Private Sub PictureBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox4.Click
        cs += 1
        If cs Mod 2 <> 0 Then
            Label14.Visible = False
            Label15.Visible = False
            Label16.Visible = False
            Label17.Visible = False
            Label18.Visible = False
            Label19.Visible = False
            Label20.Visible = False
            Label21.Visible = False
            PictureBox4.Left = 415
            PictureBox4.Top = 13
            PictureBox4.Size = New Point(450, 350)
        Else
            Label14.Visible = True
            Label15.Visible = True
            Label16.Visible = True
            Label17.Visible = True
            Label18.Visible = True
            Label19.Visible = True
            Label20.Visible = True
            Label21.Visible = True
            PictureBox4.Left = 687
            PictureBox4.Top = 312
            PictureBox4.Size = New Point(190, 145)
        End If

       
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        PictureBox5.Visible = False
        Label22.Visible = True
        Label23.Visible = True
        Label24.Visible = True
        Label25.Visible = True
        Label26.Visible = True
        Label27.Visible = True
        Label28.Visible = True
        Label29.Visible = True
        Label30.Visible = True
        Label31.Visible = True
        Label32.Visible = True
        Label33.Visible = True
        Label34.Visible = True
        Label35.Visible = True


        Label36.Visible = False
        Label37.Visible = False
        Label38.Visible = False
        Label39.Visible = False
        Label40.Visible = False
        Label41.Visible = False
        Label42.Visible = False

        Label43.Visible = False
        Label44.Visible = False
        Label45.Visible = False
        Label46.Visible = False
        Label47.Visible = False
        Label48.Visible = False
        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label5.Visible = False
        Label12.Visible = False
        Label13.Visible = False

        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label17.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        Label21.Visible = False
        Label49.Visible = False
        PictureBox4.Visible = False
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        PictureBox5.Visible = False
        Label36.Visible = True
        Label37.Visible = True
        Label38.Visible = True
        Label39.Visible = True
        Label40.Visible = True
        Label41.Visible = True
        Label42.Visible = True

        Label43.Visible = False
        Label44.Visible = False
        Label45.Visible = False
        Label46.Visible = False
        Label47.Visible = False
        Label48.Visible = False

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label5.Visible = False
        Label12.Visible = False
        Label13.Visible = False

        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label17.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        Label21.Visible = False

        PictureBox4.Visible = False

        Label22.Visible = False
        Label23.Visible = False
        Label24.Visible = False
        Label25.Visible = False
        Label26.Visible = False
        Label27.Visible = False
        Label28.Visible = False
        Label29.Visible = False
        Label30.Visible = False
        Label31.Visible = False
        Label32.Visible = False
        Label33.Visible = False
        Label34.Visible = False
        Label35.Visible = False
        Label49.Visible = False
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        PictureBox5.Visible = False
        Label43.Visible = True
        Label44.Visible = True
        Label45.Visible = True
        Label46.Visible = True
        Label47.Visible = True
        Label48.Visible = True
        Label49.Visible = True

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label5.Visible = False
        Label12.Visible = False
        Label13.Visible = False

        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label17.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        Label21.Visible = False

        PictureBox4.Visible = False

        Label22.Visible = False
        Label23.Visible = False
        Label24.Visible = False
        Label25.Visible = False
        Label26.Visible = False
        Label27.Visible = False
        Label28.Visible = False
        Label29.Visible = False
        Label30.Visible = False
        Label31.Visible = False
        Label32.Visible = False
        Label33.Visible = False
        Label34.Visible = False
        Label35.Visible = False

        Label36.Visible = False
        Label37.Visible = False
        Label38.Visible = False
        Label39.Visible = False
        Label40.Visible = False
        Label41.Visible = False
        Label42.Visible = False
    End Sub
    Dim sd As Integer = 0
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Button3.Visible = False
        Button4.Visible = False
        Button5.Visible = False
        Button7.Visible = False
        Button8.Visible = False

        Label1.Visible = False
        Label2.Visible = False
        Label3.Visible = False
        Label4.Visible = False
        Label6.Visible = False
        Label7.Visible = False
        Label8.Visible = False
        Label9.Visible = False
        Label10.Visible = False
        Label11.Visible = False
        Label5.Visible = False
        Label12.Visible = False
        Label13.Visible = False

        Label14.Visible = False
        Label15.Visible = False
        Label16.Visible = False
        Label17.Visible = False
        Label18.Visible = False
        Label19.Visible = False
        Label20.Visible = False
        Label21.Visible = False
        Label49.Visible = False
        PictureBox4.Visible = False

        Label22.Visible = False
        Label23.Visible = False
        Label24.Visible = False
        Label25.Visible = False
        Label26.Visible = False
        Label27.Visible = False
        Label28.Visible = False
        Label29.Visible = False
        Label30.Visible = False
        Label31.Visible = False
        Label32.Visible = False
        Label33.Visible = False
        Label34.Visible = False
        Label35.Visible = False

        Label36.Visible = False
        Label37.Visible = False
        Label38.Visible = False
        Label39.Visible = False
        Label40.Visible = False
        Label41.Visible = False
        Label42.Visible = False

        Label43.Visible = False
        Label44.Visible = False
        Label45.Visible = False
        Label46.Visible = False
        Label47.Visible = False
        Label48.Visible = False
        sd += 1
        If sd Mod 2 <> 0 Then
            PictureBox5.Visible = True
        Else
            PictureBox5.Visible = False
        End If

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox6.Click
        Application.Restart()
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        Search.Show()
        Me.Hide()
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        info.Show()
        Me.Hide()
    End Sub
End Class

