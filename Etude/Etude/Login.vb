Public Class Login

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        If BunifuMaterialTextbox1.Text = "admin" And BunifuMaterialTextbox2.Text = "admin" Then
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("please put your information", MsgBoxStyle.Information)
        End If
    End Sub
End Class