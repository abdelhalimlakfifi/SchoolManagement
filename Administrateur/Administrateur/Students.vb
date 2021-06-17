Imports System.IO.File
Imports System.IO.FileStream

Public Class Students

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        OpenFileDialog1.ShowDialog()
        BunifuMaterialTextbox11.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub BunifuMaterialTextbox11_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox11.OnValueChanged
        If (System.IO.File.Exists(BunifuMaterialTextbox11.Text)) Then
            GunaPictureBox2.Image = Image.FromFile(BunifuMaterialTextbox11.Text)
        End If
        If BunifuMaterialTextbox11.Text = "" Then
            GunaPictureBox2.Hide()
        Else
            GunaPictureBox2.Show()
        End If
    End Sub

    Private Sub BunifuMaterialTextbox10_OnValueChanged(sender As Object, e As EventArgs) Handles BunifuMaterialTextbox10.OnValueChanged

    End Sub
End Class