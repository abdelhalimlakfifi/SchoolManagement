Public Class fileManager
    Dim path As String
    Dim nextpath As String
    Private Sub fileManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        path = "E:"
        For Each i In My.Computer.FileSystem.GetDirectories(path)
            ListView1.Items.Add(i, ImageList1.Images.Count() - 2)
        Next
        For Each i In My.Computer.FileSystem.GetDirectories(path)
            ListView1.Items.Add(i, ImageList1.Images.Count() - 1)
        Next
    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged
        nextpath = path + "\" + e.Item.Text
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        On Error Resume Next
        If (My.Computer.FileSystem.DirectoryExists(nextpath)) Then
            path = nextpath
            ListView1.Clear()
            For Each i In My.Computer.FileSystem.GetDirectories(path)
                ListView1.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count() - 2)
            Next
            For Each i In My.Computer.FileSystem.GetDirectories(path)
                ListView1.Items.Add(i.Substring(i.LastIndexOf("\") + 1), ImageList1.Images.Count() - 1)
            Next
        Else
            MsgBox("cannot open file")
        End If
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class