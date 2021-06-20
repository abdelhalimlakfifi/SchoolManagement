<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Classes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Classes))
        Me.BranchRadioButton1 = New Guna.UI.WinForms.GunaRadioButton()
        Me.CoursesRadioButton2 = New Guna.UI.WinForms.GunaRadioButton()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BranchRadioButton1
        '
        Me.BranchRadioButton1.BaseColor = System.Drawing.SystemColors.Control
        Me.BranchRadioButton1.CheckedOffColor = System.Drawing.Color.Gray
        Me.BranchRadioButton1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BranchRadioButton1.FillColor = System.Drawing.Color.White
        Me.BranchRadioButton1.Location = New System.Drawing.Point(62, 178)
        Me.BranchRadioButton1.Name = "BranchRadioButton1"
        Me.BranchRadioButton1.Size = New System.Drawing.Size(72, 20)
        Me.BranchRadioButton1.TabIndex = 0
        Me.BranchRadioButton1.Text = "Branche"
        '
        'CoursesRadioButton2
        '
        Me.CoursesRadioButton2.BaseColor = System.Drawing.SystemColors.Control
        Me.CoursesRadioButton2.CheckedOffColor = System.Drawing.Color.Gray
        Me.CoursesRadioButton2.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CoursesRadioButton2.FillColor = System.Drawing.Color.White
        Me.CoursesRadioButton2.Location = New System.Drawing.Point(61, 235)
        Me.CoursesRadioButton2.Name = "CoursesRadioButton2"
        Me.CoursesRadioButton2.Size = New System.Drawing.Size(72, 20)
        Me.CoursesRadioButton2.TabIndex = 1
        Me.CoursesRadioButton2.Text = "Courses"
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel12.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaLabel12.Location = New System.Drawing.Point(73, 10)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(201, 47)
        Me.GunaLabel12.TabIndex = 24
        Me.GunaLabel12.Text = "𝐂𝐨𝐝𝐢𝐒𝐜𝐡𝐨𝐨𝐥"
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Location = New System.Drawing.Point(140, 83)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(726, 463)
        Me.GunaPanel1.TabIndex = 27
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(-24, -23)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 23
        Me.GunaPictureBox1.TabStop = False
        '
        'Classes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(878, 573)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.GunaLabel12)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.Controls.Add(Me.CoursesRadioButton2)
        Me.Controls.Add(Me.BranchRadioButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Classes"
        Me.Text = "Classes"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BranchRadioButton1 As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents CoursesRadioButton2 As Guna.UI.WinForms.GunaRadioButton
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
End Class
