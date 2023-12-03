Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As String
        Dim i, k, baa As Integer
        x = ListBox1.Text
        For i = 0 To ListBox1.Items.Count - 1 Step 1
            If ListBox1.Items(i) = x Then
                k = i
                Exit For
            End If
        Next
        Select Case k
            Case 0
                baa = 25
            Case 1
                baa = 15
            Case 2
                baa = 50
            Case 3
                baa = 30
        End Select
        TextBox1.Text = baa * NumericUpDown1.Value
    End Sub
End Class