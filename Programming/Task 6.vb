Public Class Form1
    Dim n As Integer = 3
    Dim pt(3) As Point
    Dim l() As Double
    Dim sum As Double
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim draw As Graphics = Panel1.CreateGraphics
        draw.FillPolygon(Brushes.Blue, pt)
    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        pt(0) = New Point(100, 100)
        pt(1) = New Point(200, 100)
        pt(2) = New Point(200, 200)
        pt(3) = New Point(100, 200)
        ReDim Preserve l(n)
    End Sub
    Dim bulx(3), buly(3) As Boolean
    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        For i = 0 To n
            If e.X > pt(i).X - 8 And e.X < pt(i).X + 8 Then
                bulx(i) = True
            Else
                bulx(i) = False
            End If

            If e.Y > pt(i).Y - 8 And e.Y < pt(i).Y + 8 Then
                buly(i) = True
            Else
                buly(i) = False
            End If
        Next
        sum = 0
    End Sub
    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseMove
        Dim draw As Graphics = Panel1.CreateGraphics
        For i = 0 To n
            If bulx(i) And buly(i) Then
                draw.FillPolygon(Brushes.White, pt)
                pt(i) = New Point(e.X, e.Y)
                draw.FillPolygon(Brushes.Blue, pt)
            End If
        Next
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp
        ListBox1.Items.Clear()
        For i = 0 To n
            bulx(i) = False
            buly(i) = False
        Next

        For i = 0 To n - 1
            l(i) = Math.Round(Math.Sqrt(Math.Abs((pt(i).X - pt(i + 1).X) ^ 2 + (pt(i).Y - pt(i + 1).Y) ^ 2)), 2)
            ListBox1.Items.Add(l(i))
        Next
        l(n) = Math.Round(Math.Sqrt(Math.Abs((pt(n).X - pt(0).X) ^ 2 + (pt(n).Y - pt(0).Y) ^ 2)), 2)
        ListBox1.Items.Add(Math.Round(l(n)))
        For i = 0 To n
            sum = sum + l(i)
        Next
        Label1.Text = "Периметр равен - " & sum
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Dim draw As Graphics = Panel1.CreateGraphics

        n = n + 1
        ReDim Preserve pt(n)
        ReDim Preserve l(n)
        pt(n) = New Point(10, 10)
        ReDim Preserve bulx(n)
        ReDim Preserve buly(n)
        draw.FillPolygon(Brushes.Blue, pt)

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        End
    End Sub
End Class
