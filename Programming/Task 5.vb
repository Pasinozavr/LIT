Public Class Form1
    Dim pt(7) As Point
    Private Sub ToolStripButton2_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton2.Click
        End
    End Sub
    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Dim draw As Graphics = Panel1.CreateGraphics
        For i = 0 To 6
            pt(i) = New Point(100 + Fix(500 * Rnd()), 100 + Fix(500 * Rnd()))
        Next
        draw.FillPolygon(Brushes.Blue, pt)
    End Sub

    Private Sub ToolStripButton3_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton3.Click
        Dim draw As Graphics = Panel1.CreateGraphics
        draw.FillPolygon(Brushes.Red, pt)
    End Sub

    Private Sub ToolStripButton4_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton4.Click
        Dim draw As Graphics = Panel1.CreateGraphics
        draw.FillPolygon(Brushes.Yellow, pt)
    End Sub

    Private Sub ToolStripButton5_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton5.Click
        Dim draw As Graphics = Panel1.CreateGraphics
        draw.FillPolygon(Brushes.Green, pt)
    End Sub

    Private Sub ToolStripButton6_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton6.Click
        Dim draw As Graphics = Panel1.CreateGraphics
        draw.FillPolygon(Brushes.Black, pt)
    End Sub
End Class
