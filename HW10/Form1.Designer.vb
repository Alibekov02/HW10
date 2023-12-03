<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComboBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChekedListBoxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NumericUpDownToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComboBoxToolStripMenuItem, Me.ChekedListBoxToolStripMenuItem, Me.NumericUpDownToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(60, 24)
        Me.MenuToolStripMenuItem.Text = "menu"
        '
        'ComboBoxToolStripMenuItem
        '
        Me.ComboBoxToolStripMenuItem.Name = "ComboBoxToolStripMenuItem"
        Me.ComboBoxToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ComboBoxToolStripMenuItem.Text = "ComboBox"
        '
        'ChekedListBoxToolStripMenuItem
        '
        Me.ChekedListBoxToolStripMenuItem.Name = "ChekedListBoxToolStripMenuItem"
        Me.ChekedListBoxToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ChekedListBoxToolStripMenuItem.Text = "ChekedListBox"
        '
        'NumericUpDownToolStripMenuItem
        '
        Me.NumericUpDownToolStripMenuItem.Name = "NumericUpDownToolStripMenuItem"
        Me.NumericUpDownToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.NumericUpDownToolStripMenuItem.Text = "NumericUpDown"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Alibekov Nurtilek 2004.01013"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ComboBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChekedListBoxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NumericUpDownToolStripMenuItem As ToolStripMenuItem
End Class
