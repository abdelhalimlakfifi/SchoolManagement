Public Class Classes
    Public abidou As String = "test"
    Sub switchPanel(ByVal panel As Form)
        GunaPanel1.Controls.Clear()
        panel.TopLevel = False
        GunaPanel1.Controls.Add(panel)
        panel.Show()
    End Sub
    Private Sub Classes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BranchRadioButton1.Checked = True
        switchPanel(Branches)
    End Sub

    Private Sub GunaRadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles BranchRadioButton1.CheckedChanged
        If BranchRadioButton1.Checked = True Then
            switchPanel(Branches)
        Else
            switchPanel(Modules)
        End If
    End Sub

    Private Sub GunaRadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles CoursesRadioButton2.CheckedChanged
        If CoursesRadioButton2.Checked = True Then
            switchPanel(Modules)
        Else
            switchPanel(Branches)
        End If
    End Sub
End Class