Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As String
        Dim i, k As Integer
        x = ComboBox1.Text
        For i = 0 To ComboBox1.Items.Count - 1 Step 1
            If ComboBox1.Items(i) = x Then
                k = i
                Exit For
            End If
        Next
        ComboBox2.Text = ComboBox2.Items(k)
        ComboBox3.Text = ComboBox3.Items(k)

    End Sub
End Class