Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        While Not CheckedListBox1.CheckedItems.Count = 0
            CheckedListBox1.Items.Remove(CheckedListBox1.CheckedItems(0))
        End While
    End Sub

End Class