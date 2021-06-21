<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notes
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Notes))
        Me.TestlistBunifuCustomDataGrid1 = New ns1.BunifuCustomDataGrid()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.MiageDataSet = New Etude.MiageDataSet()
        Me.NOTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NOTESTableAdapter = New Etude.MiageDataSetTableAdapters.NOTESTableAdapter()
        Me.GunaComboBox1 = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.IDNOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDMODULEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPROFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDETUDIANTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LANOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REMARQUEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.TestlistBunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiageDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NOTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TestlistBunifuCustomDataGrid1
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.TestlistBunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.TestlistBunifuCustomDataGrid1.AutoGenerateColumns = False
        Me.TestlistBunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.TestlistBunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TestlistBunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TestlistBunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.TestlistBunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TestlistBunifuCustomDataGrid1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDNOTEDataGridViewTextBoxColumn, Me.IDMODULEDataGridViewTextBoxColumn, Me.IDPROFDataGridViewTextBoxColumn, Me.IDETUDIANTDataGridViewTextBoxColumn, Me.LANOTEDataGridViewTextBoxColumn, Me.REMARQUEDataGridViewTextBoxColumn})
        Me.TestlistBunifuCustomDataGrid1.DataSource = Me.NOTESBindingSource
        Me.TestlistBunifuCustomDataGrid1.DoubleBuffered = True
        Me.TestlistBunifuCustomDataGrid1.EnableHeadersVisualStyles = False
        Me.TestlistBunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.Silver
        Me.TestlistBunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Black
        Me.TestlistBunifuCustomDataGrid1.Location = New System.Drawing.Point(-35, 168)
        Me.TestlistBunifuCustomDataGrid1.Name = "TestlistBunifuCustomDataGrid1"
        Me.TestlistBunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TestlistBunifuCustomDataGrid1.Size = New System.Drawing.Size(616, 248)
        Me.TestlistBunifuCustomDataGrid1.TabIndex = 0
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(335, 93)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(38, 15)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "Filiere"
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=DESKTOP-I0GV1H2;Initial Catalog=miage;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'MiageDataSet
        '
        Me.MiageDataSet.DataSetName = "MiageDataSet"
        Me.MiageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NOTESBindingSource
        '
        Me.NOTESBindingSource.DataMember = "NOTES"
        Me.NOTESBindingSource.DataSource = Me.MiageDataSet
        '
        'NOTESTableAdapter
        '
        Me.NOTESTableAdapter.ClearBeforeFill = True
        '
        'GunaComboBox1
        '
        Me.GunaComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaComboBox1.BaseColor = System.Drawing.Color.White
        Me.GunaComboBox1.BorderColor = System.Drawing.Color.Silver
        Me.GunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GunaComboBox1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GunaComboBox1.ForeColor = System.Drawing.Color.Black
        Me.GunaComboBox1.FormattingEnabled = True
        Me.GunaComboBox1.Items.AddRange(New Object() {"Development Informatique", "Réseau Informatique"})
        Me.GunaComboBox1.Location = New System.Drawing.Point(394, 88)
        Me.GunaComboBox1.Name = "GunaComboBox1"
        Me.GunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White
        Me.GunaComboBox1.Size = New System.Drawing.Size(187, 26)
        Me.GunaComboBox1.TabIndex = 6
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = CType(resources.GetObject("GunaButton1.Image"), System.Drawing.Image)
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(75, 475)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 20
        Me.GunaButton1.Size = New System.Drawing.Size(160, 42)
        Me.GunaButton1.TabIndex = 8
        Me.GunaButton1.Text = "Refrech"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaElipse1
        '
        Me.GunaElipse1.Radius = 30
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(536, -2)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox1.TabIndex = 9
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = CType(resources.GetObject("GunaButton2.Image"), System.Drawing.Image)
        Me.GunaButton2.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton2.Location = New System.Drawing.Point(362, 475)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Radius = 20
        Me.GunaButton2.Size = New System.Drawing.Size(160, 42)
        Me.GunaButton2.TabIndex = 10
        Me.GunaButton2.Text = "Export"
        Me.GunaButton2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox2.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(485, -2)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox2.TabIndex = 11
        '
        'IDNOTEDataGridViewTextBoxColumn
        '
        Me.IDNOTEDataGridViewTextBoxColumn.DataPropertyName = "ID_NOTE"
        Me.IDNOTEDataGridViewTextBoxColumn.HeaderText = "ID_NOTE"
        Me.IDNOTEDataGridViewTextBoxColumn.Name = "IDNOTEDataGridViewTextBoxColumn"
        Me.IDNOTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IDMODULEDataGridViewTextBoxColumn
        '
        Me.IDMODULEDataGridViewTextBoxColumn.DataPropertyName = "ID_MODULE"
        Me.IDMODULEDataGridViewTextBoxColumn.HeaderText = "ID_MODULE"
        Me.IDMODULEDataGridViewTextBoxColumn.Name = "IDMODULEDataGridViewTextBoxColumn"
        '
        'IDPROFDataGridViewTextBoxColumn
        '
        Me.IDPROFDataGridViewTextBoxColumn.DataPropertyName = "ID_PROF"
        Me.IDPROFDataGridViewTextBoxColumn.HeaderText = "ID_PROF"
        Me.IDPROFDataGridViewTextBoxColumn.Name = "IDPROFDataGridViewTextBoxColumn"
        '
        'IDETUDIANTDataGridViewTextBoxColumn
        '
        Me.IDETUDIANTDataGridViewTextBoxColumn.DataPropertyName = "ID_ETUDIANT"
        Me.IDETUDIANTDataGridViewTextBoxColumn.HeaderText = "ID_ETUDIANT"
        Me.IDETUDIANTDataGridViewTextBoxColumn.Name = "IDETUDIANTDataGridViewTextBoxColumn"
        '
        'LANOTEDataGridViewTextBoxColumn
        '
        Me.LANOTEDataGridViewTextBoxColumn.DataPropertyName = "LA_NOTE"
        Me.LANOTEDataGridViewTextBoxColumn.HeaderText = "LA_NOTE"
        Me.LANOTEDataGridViewTextBoxColumn.Name = "LANOTEDataGridViewTextBoxColumn"
        '
        'REMARQUEDataGridViewTextBoxColumn
        '
        Me.REMARQUEDataGridViewTextBoxColumn.DataPropertyName = "REMARQUE"
        Me.REMARQUEDataGridViewTextBoxColumn.HeaderText = "REMARQUE"
        Me.REMARQUEDataGridViewTextBoxColumn.Name = "REMARQUEDataGridViewTextBoxColumn"
        '
        'Notes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 552)
        Me.Controls.Add(Me.GunaControlBox2)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.GunaControlBox1)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.GunaComboBox1)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.TestlistBunifuCustomDataGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Notes"
        Me.Text = "Form1"
        CType(Me.TestlistBunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiageDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NOTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TestlistBunifuCustomDataGrid1 As ns1.BunifuCustomDataGrid
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents MiageDataSet As Etude.MiageDataSet
    Friend WithEvents NOTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NOTESTableAdapter As Etude.MiageDataSetTableAdapters.NOTESTableAdapter
    Friend WithEvents GunaComboBox1 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents IDNOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDMODULEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPROFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDETUDIANTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LANOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REMARQUEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
