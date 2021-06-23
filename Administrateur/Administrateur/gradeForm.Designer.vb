<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gradeForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuCustomDataGrid1 = New ns1.BunifuCustomDataGrid()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaComboBox2 = New Guna.UI.WinForms.GunaComboBox()
        Me.gradesTextBox = New ns1.BunifuMaterialTextbox()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.StudentTextbox = New ns1.BunifuMaterialTextbox()
        Me.ClassComboBox1 = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.remarqueTextbox1 = New ns1.BunifuMaterialTextbox()
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCustomDataGrid1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.BunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.LightGoldenrodYellow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.BunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.BunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BunifuCustomDataGrid1.DoubleBuffered = True
        Me.BunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.BunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.BunifuCustomDataGrid1.Location = New System.Drawing.Point(288, 102)
        Me.BunifuCustomDataGrid1.Name = "BunifuCustomDataGrid1"
        Me.BunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.BunifuCustomDataGrid1.Size = New System.Drawing.Size(602, 263)
        Me.BunifuCustomDataGrid1.TabIndex = 0
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(44, 136)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(48, 15)
        Me.GunaLabel2.TabIndex = 4
        Me.GunaLabel2.Text = "Module"
        '
        'GunaComboBox2
        '
        Me.GunaComboBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaComboBox2.BaseColor = System.Drawing.Color.White
        Me.GunaComboBox2.BorderColor = System.Drawing.Color.Silver
        Me.GunaComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GunaComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GunaComboBox2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaComboBox2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaComboBox2.ForeColor = System.Drawing.Color.Black
        Me.GunaComboBox2.FormattingEnabled = True
        Me.GunaComboBox2.Location = New System.Drawing.Point(47, 158)
        Me.GunaComboBox2.Name = "GunaComboBox2"
        Me.GunaComboBox2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaComboBox2.OnHoverItemForeColor = System.Drawing.Color.White
        Me.GunaComboBox2.Size = New System.Drawing.Size(211, 26)
        Me.GunaComboBox2.TabIndex = 3
        '
        'gradesTextBox
        '
        Me.gradesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.gradesTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.gradesTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.gradesTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.gradesTextBox.HintText = "La note"
        Me.gradesTextBox.isPassword = False
        Me.gradesTextBox.LineFocusedColor = System.Drawing.Color.Blue
        Me.gradesTextBox.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.gradesTextBox.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.gradesTextBox.LineThickness = 3
        Me.gradesTextBox.Location = New System.Drawing.Point(47, 252)
        Me.gradesTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.gradesTextBox.Name = "gradesTextBox"
        Me.gradesTextBox.Size = New System.Drawing.Size(211, 41)
        Me.gradesTextBox.TabIndex = 6
        Me.gradesTextBox.Text = "Grades"
        Me.gradesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaButton3
        '
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaButton3.BorderColor = System.Drawing.Color.Black
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton3.ForeColor = System.Drawing.Color.White
        Me.GunaButton3.Image = Nothing
        Me.GunaButton3.ImageSize = New System.Drawing.Size(15, 15)
        Me.GunaButton3.Location = New System.Drawing.Point(47, 372)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Size = New System.Drawing.Size(82, 38)
        Me.GunaButton3.TabIndex = 53
        Me.GunaButton3.Text = "Ajouter"
        Me.GunaButton3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'StudentTextbox
        '
        Me.StudentTextbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StudentTextbox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.StudentTextbox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StudentTextbox.HintForeColor = System.Drawing.Color.Empty
        Me.StudentTextbox.HintText = "Etudiant"
        Me.StudentTextbox.isPassword = False
        Me.StudentTextbox.LineFocusedColor = System.Drawing.Color.Blue
        Me.StudentTextbox.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.StudentTextbox.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.StudentTextbox.LineThickness = 3
        Me.StudentTextbox.Location = New System.Drawing.Point(47, 195)
        Me.StudentTextbox.Margin = New System.Windows.Forms.Padding(4)
        Me.StudentTextbox.Name = "StudentTextbox"
        Me.StudentTextbox.Size = New System.Drawing.Size(211, 41)
        Me.StudentTextbox.TabIndex = 54
        Me.StudentTextbox.Text = "Students"
        Me.StudentTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'ClassComboBox1
        '
        Me.ClassComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.ClassComboBox1.BaseColor = System.Drawing.Color.White
        Me.ClassComboBox1.BorderColor = System.Drawing.Color.Silver
        Me.ClassComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ClassComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ClassComboBox1.FocusedColor = System.Drawing.Color.Empty
        Me.ClassComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ClassComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ClassComboBox1.FormattingEnabled = True
        Me.ClassComboBox1.Location = New System.Drawing.Point(288, 59)
        Me.ClassComboBox1.Name = "ClassComboBox1"
        Me.ClassComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClassComboBox1.OnHoverItemForeColor = System.Drawing.Color.White
        Me.ClassComboBox1.Size = New System.Drawing.Size(211, 26)
        Me.ClassComboBox1.TabIndex = 55
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(285, 41)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(37, 15)
        Me.GunaLabel1.TabIndex = 56
        Me.GunaLabel1.Text = "Class:"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(505, 64)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(10, 15)
        Me.GunaLabel3.TabIndex = 57
        Me.GunaLabel3.Text = "."
        '
        'remarqueTextbox1
        '
        Me.remarqueTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.remarqueTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.remarqueTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.remarqueTextbox1.HintForeColor = System.Drawing.Color.Empty
        Me.remarqueTextbox1.HintText = "Remarque"
        Me.remarqueTextbox1.isPassword = False
        Me.remarqueTextbox1.LineFocusedColor = System.Drawing.Color.Blue
        Me.remarqueTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.remarqueTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.remarqueTextbox1.LineThickness = 3
        Me.remarqueTextbox1.Location = New System.Drawing.Point(47, 310)
        Me.remarqueTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.remarqueTextbox1.Name = "remarqueTextbox1"
        Me.remarqueTextbox1.Size = New System.Drawing.Size(211, 41)
        Me.remarqueTextbox1.TabIndex = 58
        Me.remarqueTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'gradeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 505)
        Me.Controls.Add(Me.remarqueTextbox1)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.ClassComboBox1)
        Me.Controls.Add(Me.StudentTextbox)
        Me.Controls.Add(Me.GunaButton3)
        Me.Controls.Add(Me.gradesTextBox)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaComboBox2)
        Me.Controls.Add(Me.BunifuCustomDataGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "gradeForm"
        Me.Text = "gradeForm"
        CType(Me.BunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BunifuCustomDataGrid1 As ns1.BunifuCustomDataGrid
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaComboBox2 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents gradesTextBox As ns1.BunifuMaterialTextbox
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents StudentTextbox As ns1.BunifuMaterialTextbox
    Friend WithEvents ClassComboBox1 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents remarqueTextbox1 As ns1.BunifuMaterialTextbox
End Class
