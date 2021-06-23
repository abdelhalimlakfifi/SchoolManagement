<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.FileList = New System.Windows.Forms.ListBox()
        Me.DriveList = New System.Windows.Forms.ListBox()
        Me.FoldersList = New System.Windows.Forms.ListBox()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'FileList
        '
        Me.FileList.FormattingEnabled = True
        Me.FileList.Location = New System.Drawing.Point(300, 0)
        Me.FileList.Name = "FileList"
        Me.FileList.Size = New System.Drawing.Size(289, 537)
        Me.FileList.TabIndex = 2
        '
        'DriveList
        '
        Me.DriveList.FormattingEnabled = True
        Me.DriveList.Location = New System.Drawing.Point(0, 0)
        Me.DriveList.Name = "DriveList"
        Me.DriveList.Size = New System.Drawing.Size(60, 69)
        Me.DriveList.TabIndex = 0
        '
        'FoldersList
        '
        Me.FoldersList.FormattingEnabled = True
        Me.FoldersList.Location = New System.Drawing.Point(59, 0)
        Me.FoldersList.Name = "FoldersList"
        Me.FoldersList.Size = New System.Drawing.Size(243, 537)
        Me.FoldersList.TabIndex = 1
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Controls.Add(Me.DriveList)
        Me.GunaPanel2.Controls.Add(Me.FileList)
        Me.GunaPanel2.Controls.Add(Me.FoldersList)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(589, 528)
        Me.GunaPanel2.TabIndex = 31
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 528)
        Me.Controls.Add(Me.GunaPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "home"
        Me.Text = "home"
        Me.GunaPanel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private Sub FolderList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FoldersList.SelectedIndexChanged

    End Sub

    Private Sub DriveList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DriveList.SelectedIndexChanged

    End Sub

    Private Sub FileList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FileList.SelectedIndexChanged

    End Sub
    Friend WithEvents FoldersList As System.Windows.Forms.ListBox
    Friend WithEvents DriveList As System.Windows.Forms.ListBox
    Friend WithEvents FileList As System.Windows.Forms.ListBox
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel

    Private Sub GunaPanel2_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel2.Paint

    End Sub
End Class
