Public Class DocForm
    Private Shared _counter As Integer = 0

    Public Shared Function CreateForm() As DocForm
        Dim form As New DocForm()
        _counter += 1
        form.Text = "New Document" & _counter
        My.Application.ApplicationContext.MainForm = form
        form.Show()

        Return form
    End Function

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click
        CreateForm()
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        Me.DocumentTextBox.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        Me.DocumentTextBox.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click, CutToolStripButton.Click
        Me.DocumentTextBox.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click, CopyToolStripButton.Click
        Me.DocumentTextBox.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click, PasteToolStripButton.Click
        Me.DocumentTextBox.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        Me.DocumentTextBox.SelectAll()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click, SaveToolStripButton.Click
        Dim dialog As New SaveFileDialog()
        dialog.Filter = "Rich text files|*.rtf"
        dialog.AddExtension = True
        Dim result = dialog.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            Me.DocumentTextBox.SaveFile(dialog.FileName)
            Me.Text = dialog.FileName
        End If
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim dialog As New OpenFileDialog()
        dialog.Filter = "Rich text files|*.rtf"
        Dim result = dialog.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            Me.DocumentTextBox.LoadFile(dialog.FileName)
            Me.Text = dialog.FileName
        End If
    End Sub

    Private Sub WindowToolStripMenuItem_DropDownOpening(sender As Object, e As EventArgs) Handles WindowToolStripMenuItem.DropDownOpening
        If WindowToolStripMenuItem.DropDownItems.Count > 0 Then
            WindowToolStripMenuItem.DropDown.Dispose()
        End If

        WindowToolStripMenuItem.DropDown = New ToolStripDropDown()
        For Each openForm As Form In My.Application.OpenForms
            Dim childItem As New ToolStripMenuItem()
            childItem.Text = openForm.Text
            childItem.Tag = openForm
            WindowToolStripMenuItem.DropDownItems.Add(childItem)
            AddHandler childItem.Click, AddressOf WindowMenuItemClick
        Next
    End Sub

    Private Sub WindowMenuItemClick(sender As Object, e As EventArgs)
        Dim menuItem = CType(sender, ToolStripMenuItem)
        Dim form = CType(menuItem.Tag, Form)
        form.Activate()

    End Sub
End Class
