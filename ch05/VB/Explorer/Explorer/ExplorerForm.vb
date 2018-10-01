Imports System.IO

Public Class ExplorerForm
    Private Sub ExplorerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewToolStripComboBox.SelectedIndex = 0

        ListView1.Columns.Add("Name", 250)
        ListView1.Columns.Add("Date Modified", 150)
        ListView1.Columns.Add("Size", 75, HorizontalAlignment.Right)

        Dim docs As New TreeNode("Raz Family")
        docs.Tag = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)
        TreeView1.Nodes.Add(docs)

        GetFolders(docs)
        docs.Expand()
    End Sub

    Private Sub GetFolders(node As TreeNode)
        Dim dir As New DirectoryInfo(node.Tag)

        Try
            For Each childDir In dir.GetDirectories()
                If childDir.Attributes.HasFlag(FileAttributes.Hidden) Then
                    Continue For
                End If

                Dim childNode As New TreeNode(childDir.Name)
                childNode.Tag = childDir.FullName
                node.Nodes.Add(childNode)

                GetFolders(childNode)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim dir As New DirectoryInfo(e.Node.Tag)

        ListView1.Items.Clear()
        SmallImageList.Images.RemoveByKey(".exe")
        LargeImageList.Images.RemoveByKey(".exe")
        For Each thisFile In dir.GetFiles()
            Dim item As New ListViewItem(thisFile.Name)
            Dim lastWrite = thisFile.LastWriteTime
            item.SubItems.Add(lastWrite.ToShortDateString & " " & lastWrite.ToShortTimeString)
            item.SubItems.Add(Math.Ceiling(thisFile.Length / 1024) & " KB")

            If Not LargeImageList.Images.ContainsKey(thisFile.Extension) Then
                Dim thisIcon = Icon.ExtractAssociatedIcon(thisFile.FullName)
                SmallImageList.Images.Add(thisFile.Extension, thisIcon)
                LargeImageList.Images.Add(thisFile.Extension, thisIcon)
            End If

            item.ImageKey = thisFile.Extension
            ListView1.Items.Add(item)
        Next
    End Sub

    Private Sub ViewToolStripComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ViewToolStripComboBox.SelectedIndexChanged
        Select Case ViewToolStripComboBox.Text
            Case "Large Icons"
                ListView1.View = View.LargeIcon
            Case "Small Icons"
                ListView1.View = View.SmallIcon
            Case "Details"
                ListView1.View = View.Details
        End Select
    End Sub
End Class
