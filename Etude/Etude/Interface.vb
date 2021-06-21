Public Class Form2

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
        GunaPanel2.Controls.Clear()
        fileManager.TopLevel = False
        GunaPanel2.Controls.Add(fileManager)
        fileManager.Show()
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        GunaPanel2.Controls.Clear()
        Notes.TopLevel = False
        GunaPanel2.Controls.Add(Notes)
        Notes.Show()
    End Sub
End Class