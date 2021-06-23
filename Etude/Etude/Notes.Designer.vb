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
        Me.IDNOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDMODULEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDPROFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDETUDIANTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LANOTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REMARQUEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MiageDataSet = New Etude.MiageDataSet()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.NOTESTableAdapter = New Etude.MiageDataSetTableAdapters.NOTESTableAdapter()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        CType(Me.TestlistBunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NOTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MiageDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.TestlistBunifuCustomDataGrid1.Location = New System.Drawing.Point(90, 30)
        Me.TestlistBunifuCustomDataGrid1.Name = "TestlistBunifuCustomDataGrid1"
        Me.TestlistBunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.TestlistBunifuCustomDataGrid1.Size = New System.Drawing.Size(616, 248)
        Me.TestlistBunifuCustomDataGrid1.TabIndex = 0
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
        'NOTESBindingSource
        '
        Me.NOTESBindingSource.DataMember = "NOTES"
        Me.NOTESBindingSource.DataSource = Me.MiageDataSet
        '
        'MiageDataSet
        '
        Me.MiageDataSet.DataSetName = "MiageDataSet"
        Me.MiageDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=DESKTOP-I0GV1H2;Initial Catalog=miage;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'NOTESTableAdapter
        '
        Me.NOTESTableAdapter.ClearBeforeFill = True
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
        Me.GunaButton1.Location = New System.Drawing.Point(330, 284)
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
        'Notes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 350)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.TestlistBunifuCustomDataGrid1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Notes"
        Me.Text = "Form1"
        CType(Me.TestlistBunifuCustomDataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NOTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MiageDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TestlistBunifuCustomDataGrid1 As ns1.BunifuCustomDataGrid
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents MiageDataSet As Etude.MiageDataSet
    Friend WithEvents NOTESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents NOTESTableAdapter As Etude.MiageDataSetTableAdapters.NOTESTableAdapter
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents IDNOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDMODULEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDPROFDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IDETUDIANTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LANOTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REMARQUEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
