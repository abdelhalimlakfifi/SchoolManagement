<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaymentForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PaymentForm))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaLabel12 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.StudentsPaymentsDataGrid = New ns1.BunifuCustomDataGrid()
        Me.GunaComboBox1 = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaComboBox2 = New Guna.UI.WinForms.GunaComboBox()
        Me.LastNameTextBox = New ns1.BunifuMaterialTextbox()
        Me.OtherPhoneTextBox = New ns1.BunifuMaterialTextbox()
        Me.PhoneTextBoxt = New ns1.BunifuMaterialTextbox()
        Me.AdressTextBox = New ns1.BunifuMaterialTextbox()
        Me.FirstNameTextBox = New ns1.BunifuMaterialTextbox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        Me.UsernameTextBox = New ns1.BunifuMaterialTextbox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.amountTextBox = New ns1.BunifuMetroTextbox()
        Me.BunifuTextbox1 = New ns1.BunifuTextbox()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsPaymentsDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaLabel12
        '
        Me.GunaLabel12.AutoSize = True
        Me.GunaLabel12.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel12.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaLabel12.Location = New System.Drawing.Point(94, 35)
        Me.GunaLabel12.Name = "GunaLabel12"
        Me.GunaLabel12.Size = New System.Drawing.Size(201, 47)
        Me.GunaLabel12.TabIndex = 24
        Me.GunaLabel12.Text = "𝐂𝐨𝐝𝐢𝐒𝐜𝐡𝐨𝐨𝐥"
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(-3, 2)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(120, 120)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 23
        Me.GunaPictureBox1.TabStop = False
        '
        'StudentsPaymentsDataGrid
        '
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.StudentsPaymentsDataGrid.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.StudentsPaymentsDataGrid.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.StudentsPaymentsDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StudentsPaymentsDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(86, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentsPaymentsDataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.StudentsPaymentsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.StudentsPaymentsDataGrid.DoubleBuffered = True
        Me.StudentsPaymentsDataGrid.EnableHeadersVisualStyles = False
        Me.StudentsPaymentsDataGrid.HeaderBgColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(23, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.StudentsPaymentsDataGrid.HeaderForeColor = System.Drawing.Color.White
        Me.StudentsPaymentsDataGrid.Location = New System.Drawing.Point(342, 168)
        Me.StudentsPaymentsDataGrid.Name = "StudentsPaymentsDataGrid"
        Me.StudentsPaymentsDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.StudentsPaymentsDataGrid.Size = New System.Drawing.Size(592, 215)
        Me.StudentsPaymentsDataGrid.TabIndex = 25
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
        Me.GunaComboBox1.Location = New System.Drawing.Point(342, 136)
        Me.GunaComboBox1.Name = "GunaComboBox1"
        Me.GunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White
        Me.GunaComboBox1.Size = New System.Drawing.Size(130, 26)
        Me.GunaComboBox1.TabIndex = 26
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(766, 395)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(67, 15)
        Me.GunaLabel1.TabIndex = 27
        Me.GunaLabel1.Text = "Added By : "
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel2.Location = New System.Drawing.Point(839, 395)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(10, 15)
        Me.GunaLabel2.TabIndex = 28
        Me.GunaLabel2.Text = "."
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel3.Location = New System.Drawing.Point(430, 434)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(72, 15)
        Me.GunaLabel3.TabIndex = 29
        Me.GunaLabel3.Text = "Month Paid:"
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
        Me.GunaComboBox2.Items.AddRange(New Object() {" 1- January", " 2- February", " 3- March", " 4- April", " 5- May", " 6- June", " 7- July", " 8- August", " 9- Septembre", "10- October", "11- November", "12- December"})
        Me.GunaComboBox2.Location = New System.Drawing.Point(505, 429)
        Me.GunaComboBox2.Name = "GunaComboBox2"
        Me.GunaComboBox2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaComboBox2.OnHoverItemForeColor = System.Drawing.Color.White
        Me.GunaComboBox2.Size = New System.Drawing.Size(145, 26)
        Me.GunaComboBox2.TabIndex = 30
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LastNameTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.LastNameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LastNameTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.LastNameTextBox.HintText = ""
        Me.LastNameTextBox.isPassword = False
        Me.LastNameTextBox.LineFocusedColor = System.Drawing.Color.Blue
        Me.LastNameTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.LastNameTextBox.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.LastNameTextBox.LineThickness = 3
        Me.LastNameTextBox.Location = New System.Drawing.Point(118, 166)
        Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(168, 32)
        Me.LastNameTextBox.TabIndex = 40
        Me.LastNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'OtherPhoneTextBox
        '
        Me.OtherPhoneTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OtherPhoneTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.OtherPhoneTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.OtherPhoneTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.OtherPhoneTextBox.HintText = ""
        Me.OtherPhoneTextBox.isPassword = False
        Me.OtherPhoneTextBox.LineFocusedColor = System.Drawing.Color.Blue
        Me.OtherPhoneTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.OtherPhoneTextBox.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.OtherPhoneTextBox.LineThickness = 3
        Me.OtherPhoneTextBox.Location = New System.Drawing.Point(118, 286)
        Me.OtherPhoneTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OtherPhoneTextBox.Name = "OtherPhoneTextBox"
        Me.OtherPhoneTextBox.Size = New System.Drawing.Size(168, 32)
        Me.OtherPhoneTextBox.TabIndex = 39
        Me.OtherPhoneTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PhoneTextBoxt
        '
        Me.PhoneTextBoxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PhoneTextBoxt.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.PhoneTextBoxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PhoneTextBoxt.HintForeColor = System.Drawing.Color.Empty
        Me.PhoneTextBoxt.HintText = ""
        Me.PhoneTextBoxt.isPassword = False
        Me.PhoneTextBoxt.LineFocusedColor = System.Drawing.Color.Blue
        Me.PhoneTextBoxt.LineIdleColor = System.Drawing.Color.Gray
        Me.PhoneTextBoxt.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.PhoneTextBoxt.LineThickness = 3
        Me.PhoneTextBoxt.Location = New System.Drawing.Point(118, 246)
        Me.PhoneTextBoxt.Margin = New System.Windows.Forms.Padding(4)
        Me.PhoneTextBoxt.Name = "PhoneTextBoxt"
        Me.PhoneTextBoxt.Size = New System.Drawing.Size(168, 32)
        Me.PhoneTextBoxt.TabIndex = 38
        Me.PhoneTextBoxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'AdressTextBox
        '
        Me.AdressTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AdressTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.AdressTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AdressTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.AdressTextBox.HintText = ""
        Me.AdressTextBox.isPassword = False
        Me.AdressTextBox.LineFocusedColor = System.Drawing.Color.Blue
        Me.AdressTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.AdressTextBox.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.AdressTextBox.LineThickness = 3
        Me.AdressTextBox.Location = New System.Drawing.Point(118, 206)
        Me.AdressTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AdressTextBox.Name = "AdressTextBox"
        Me.AdressTextBox.Size = New System.Drawing.Size(168, 32)
        Me.AdressTextBox.TabIndex = 37
        Me.AdressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FirstNameTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.FirstNameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FirstNameTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.FirstNameTextBox.HintText = ""
        Me.FirstNameTextBox.isPassword = False
        Me.FirstNameTextBox.LineFocusedColor = System.Drawing.Color.Blue
        Me.FirstNameTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.FirstNameTextBox.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.FirstNameTextBox.LineThickness = 3
        Me.FirstNameTextBox.Location = New System.Drawing.Point(118, 126)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(168, 32)
        Me.FirstNameTextBox.TabIndex = 36
        Me.FirstNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel6.Location = New System.Drawing.Point(21, 303)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(90, 15)
        Me.GunaLabel6.TabIndex = 35
        Me.GunaLabel6.Text = "AutreTelephone"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel5.Location = New System.Drawing.Point(23, 263)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(61, 15)
        Me.GunaLabel5.TabIndex = 34
        Me.GunaLabel5.Text = "Telephone"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel4.Location = New System.Drawing.Point(26, 223)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(48, 15)
        Me.GunaLabel4.TabIndex = 33
        Me.GunaLabel4.Text = "Adresse"
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel7.Location = New System.Drawing.Point(26, 183)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(49, 15)
        Me.GunaLabel7.TabIndex = 32
        Me.GunaLabel7.Text = "Prenom"
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel8.Location = New System.Drawing.Point(28, 143)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(34, 15)
        Me.GunaLabel8.TabIndex = 31
        Me.GunaLabel8.Text = "Nom"
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.UsernameTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.UsernameTextBox.HintForeColor = System.Drawing.Color.Empty
        Me.UsernameTextBox.HintText = ""
        Me.UsernameTextBox.isPassword = False
        Me.UsernameTextBox.LineFocusedColor = System.Drawing.Color.Blue
        Me.UsernameTextBox.LineIdleColor = System.Drawing.Color.Gray
        Me.UsernameTextBox.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.UsernameTextBox.LineThickness = 3
        Me.UsernameTextBox.Location = New System.Drawing.Point(118, 326)
        Me.UsernameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(168, 32)
        Me.UsernameTextBox.TabIndex = 43
        Me.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel9.Location = New System.Drawing.Point(27, 343)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(49, 15)
        Me.GunaLabel9.TabIndex = 41
        Me.GunaLabel9.Text = "Surnom"
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GunaPictureBox2.Location = New System.Drawing.Point(769, 12)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(157, 120)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 46
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = CType(resources.GetObject("GunaButton1.Image"), System.Drawing.Image)
        Me.GunaButton1.ImageSize = New System.Drawing.Size(15, 15)
        Me.GunaButton1.Location = New System.Drawing.Point(769, 417)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Size = New System.Drawing.Size(100, 32)
        Me.GunaButton1.TabIndex = 47
        Me.GunaButton1.Text = "Payment"
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.Black
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = CType(resources.GetObject("GunaButton2.Image"), System.Drawing.Image)
        Me.GunaButton2.ImageSize = New System.Drawing.Size(15, 15)
        Me.GunaButton2.Location = New System.Drawing.Point(34, 401)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Size = New System.Drawing.Size(89, 32)
        Me.GunaButton2.TabIndex = 48
        Me.GunaButton2.Text = "Update"
        '
        'GunaButton4
        '
        Me.GunaButton4.AnimationHoverSpeed = 0.07!
        Me.GunaButton4.AnimationSpeed = 0.03!
        Me.GunaButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaButton4.BorderColor = System.Drawing.Color.Black
        Me.GunaButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaButton4.ForeColor = System.Drawing.Color.White
        Me.GunaButton4.Image = CType(resources.GetObject("GunaButton4.Image"), System.Drawing.Image)
        Me.GunaButton4.ImageSize = New System.Drawing.Size(15, 15)
        Me.GunaButton4.Location = New System.Drawing.Point(183, 401)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton4.OnHoverImage = Nothing
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton4.Size = New System.Drawing.Size(89, 32)
        Me.GunaButton4.TabIndex = 49
        Me.GunaButton4.Text = "Delete"
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
        Me.GunaButton3.Location = New System.Drawing.Point(837, 138)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Size = New System.Drawing.Size(89, 26)
        Me.GunaButton3.TabIndex = 50
        Me.GunaButton3.Text = "Refresh Table"
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel10.Location = New System.Drawing.Point(430, 401)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(51, 15)
        Me.GunaLabel10.TabIndex = 51
        Me.GunaLabel10.Text = "Amount"
        '
        'amountTextBox
        '
        Me.amountTextBox.BorderColorFocused = System.Drawing.Color.Blue
        Me.amountTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.amountTextBox.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.amountTextBox.BorderThickness = 3
        Me.amountTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.amountTextBox.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.amountTextBox.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.amountTextBox.isPassword = False
        Me.amountTextBox.Location = New System.Drawing.Point(505, 390)
        Me.amountTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.amountTextBox.Name = "amountTextBox"
        Me.amountTextBox.Size = New System.Drawing.Size(160, 32)
        Me.amountTextBox.TabIndex = 52
        Me.amountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuTextbox1
        '
        Me.BunifuTextbox1.BackColor = System.Drawing.Color.White
        Me.BunifuTextbox1.BackgroundImage = CType(resources.GetObject("BunifuTextbox1.BackgroundImage"), System.Drawing.Image)
        Me.BunifuTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuTextbox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.BunifuTextbox1.Icon = CType(resources.GetObject("BunifuTextbox1.Icon"), System.Drawing.Image)
        Me.BunifuTextbox1.Location = New System.Drawing.Point(498, 136)
        Me.BunifuTextbox1.Name = "BunifuTextbox1"
        Me.BunifuTextbox1.Size = New System.Drawing.Size(250, 26)
        Me.BunifuTextbox1.TabIndex = 53
        Me.BunifuTextbox1.text = "Bunifu TextBox"
        '
        'PaymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(996, 467)
        Me.Controls.Add(Me.BunifuTextbox1)
        Me.Controls.Add(Me.amountTextBox)
        Me.Controls.Add(Me.GunaLabel10)
        Me.Controls.Add(Me.GunaButton3)
        Me.Controls.Add(Me.GunaButton4)
        Me.Controls.Add(Me.GunaButton2)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.GunaPictureBox2)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.GunaLabel9)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.OtherPhoneTextBox)
        Me.Controls.Add(Me.PhoneTextBoxt)
        Me.Controls.Add(Me.AdressTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.GunaLabel6)
        Me.Controls.Add(Me.GunaLabel5)
        Me.Controls.Add(Me.GunaLabel4)
        Me.Controls.Add(Me.GunaLabel7)
        Me.Controls.Add(Me.GunaLabel8)
        Me.Controls.Add(Me.GunaComboBox2)
        Me.Controls.Add(Me.GunaLabel3)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaComboBox1)
        Me.Controls.Add(Me.StudentsPaymentsDataGrid)
        Me.Controls.Add(Me.GunaLabel12)
        Me.Controls.Add(Me.GunaPictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PaymentForm"
        Me.Text = "PaymentForm"
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsPaymentsDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaLabel12 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents StudentsPaymentsDataGrid As ns1.BunifuCustomDataGrid
    Friend WithEvents GunaComboBox1 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaComboBox2 As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents LastNameTextBox As ns1.BunifuMaterialTextbox
    Friend WithEvents OtherPhoneTextBox As ns1.BunifuMaterialTextbox
    Friend WithEvents PhoneTextBoxt As ns1.BunifuMaterialTextbox
    Friend WithEvents AdressTextBox As ns1.BunifuMaterialTextbox
    Friend WithEvents FirstNameTextBox As ns1.BunifuMaterialTextbox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents UsernameTextBox As ns1.BunifuMaterialTextbox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents amountTextBox As ns1.BunifuMetroTextbox
    Friend WithEvents BunifuTextbox1 As ns1.BunifuTextbox
End Class
