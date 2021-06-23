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

    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GunaPanel2.Controls.Clear()
        fileManager.TopLevel = False
        GunaPanel2.Controls.Add(fileManager)
        fileManager.Show()
    End Sub
End Class