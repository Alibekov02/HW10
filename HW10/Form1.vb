Public Class Form1
    Private Sub ComboBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComboBoxToolStripMenuItem.Click
        Dim i As Form2 = New Form2
        i.MdiParent = Me
        i.Show()
    End Sub

    Private Sub ChekedListBoxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChekedListBoxToolStripMenuItem.Click
        Dim i As Form3 = New Form3
        i.MdiParent = Me
        i.Show()
    End Sub

    Private Sub NumericUpDownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NumericUpDownToolStripMenuItem.Click
        Dim i As Form4 = New Form4
        i.MdiParent = Me
        i.Show()
    End Sub
End Class
