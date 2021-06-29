<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaButton6 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton3 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton2 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton10 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton9 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton8 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton13 = New Guna.UI.WinForms.GunaButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GunaButton11 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton7 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton5 = New Guna.UI.WinForms.GunaButton()
        Me.GunaButton4 = New Guna.UI.WinForms.GunaButton()
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel1.Controls.Add(Me.GunaButton6)
        Me.GunaPanel1.Controls.Add(Me.GunaButton3)
        Me.GunaPanel1.Controls.Add(Me.GunaButton2)
        Me.GunaPanel1.Controls.Add(Me.GunaButton10)
        Me.GunaPanel1.Controls.Add(Me.GunaButton9)
        Me.GunaPanel1.Controls.Add(Me.GunaButton8)
        Me.GunaPanel1.Controls.Add(Me.GunaButton1)
        Me.GunaPanel1.Controls.Add(Me.GunaButton13)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(202, 608)
        Me.GunaPanel1.TabIndex = 14
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(11, 3)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(178, 153)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 28
        Me.GunaPictureBox1.TabStop = False
        '
        'GunaButton6
        '
        Me.GunaButton6.AnimationHoverSpeed = 0.07!
        Me.GunaButton6.AnimationSpeed = 0.03!
        Me.GunaButton6.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton6.BaseColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaButton6.BorderColor = System.Drawing.Color.White
        Me.GunaButton6.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton6.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton6.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton6.ForeColor = System.Drawing.Color.White
        Me.GunaButton6.Image = CType(resources.GetObject("GunaButton6.Image"), System.Drawing.Image)
        Me.GunaButton6.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton6.Location = New System.Drawing.Point(15, 431)
        Me.GunaButton6.Name = "GunaButton6"
        Me.GunaButton6.OnHoverBaseColor = System.Drawing.Color.Gold
        Me.GunaButton6.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton6.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton6.OnHoverImage = Nothing
        Me.GunaButton6.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton6.Radius = 24
        Me.GunaButton6.Size = New System.Drawing.Size(187, 50)
        Me.GunaButton6.TabIndex = 27
        Me.GunaButton6.Text = "Administrateur"
        Me.GunaButton6.UseTransfarantBackground = True
        '
        'GunaButton3
        '
        Me.GunaButton3.AnimationHoverSpeed = 0.07!
        Me.GunaButton3.AnimationSpeed = 0.03!
        Me.GunaButton3.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaButton3.BorderColor = System.Drawing.Color.White
        Me.GunaButton3.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton3.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton3.ForeColor = System.Drawing.Color.White
        Me.GunaButton3.Image = CType(resources.GetObject("GunaButton3.Image"), System.Drawing.Image)
        Me.GunaButton3.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton3.Location = New System.Drawing.Point(12, 322)
        Me.GunaButton3.Name = "GunaButton3"
        Me.GunaButton3.OnHoverBaseColor = System.Drawing.Color.Gold
        Me.GunaButton3.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton3.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton3.OnHoverImage = Nothing
        Me.GunaButton3.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton3.Radius = 24
        Me.GunaButton3.Size = New System.Drawing.Size(190, 50)
        Me.GunaButton3.TabIndex = 26
        Me.GunaButton3.Text = "Les Classes"
        Me.GunaButton3.UseTransfarantBackground = True
        '
        'GunaButton2
        '
        Me.GunaButton2.AnimationHoverSpeed = 0.07!
        Me.GunaButton2.AnimationSpeed = 0.03!
        Me.GunaButton2.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaButton2.BorderColor = System.Drawing.Color.White
        Me.GunaButton2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton2.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton2.ForeColor = System.Drawing.Color.White
        Me.GunaButton2.Image = CType(resources.GetObject("GunaButton2.Image"), System.Drawing.Image)
        Me.GunaButton2.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton2.Location = New System.Drawing.Point(9, 162)
        Me.GunaButton2.Name = "GunaButton2"
        Me.GunaButton2.OnHoverBaseColor = System.Drawing.Color.Gold
        Me.GunaButton2.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton2.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton2.OnHoverImage = Nothing
        Me.GunaButton2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton2.Radius = 24
        Me.GunaButton2.Size = New System.Drawing.Size(193, 50)
        Me.GunaButton2.TabIndex = 25
        Me.GunaButton2.Text = "Etudiant"
        Me.GunaButton2.UseTransfarantBackground = True
        '
        'GunaButton10
        '
        Me.GunaButton10.AnimationHoverSpeed = 0.07!
        Me.GunaButton10.AnimationSpeed = 0.03!
        Me.GunaButton10.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton10.BaseColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaButton10.BorderColor = System.Drawing.Color.White
        Me.GunaButton10.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton10.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton10.ForeColor = System.Drawing.Color.White
        Me.GunaButton10.Image = CType(resources.GetObject("GunaButton10.Image"), System.Drawing.Image)
        Me.GunaButton10.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton10.Location = New System.Drawing.Point(15, 487)
        Me.GunaButton10.Name = "GunaButton10"
        Me.GunaButton10.OnHoverBaseColor = System.Drawing.Color.Gold
        Me.GunaButton10.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton10.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton10.OnHoverImage = Nothing
        Me.GunaButton10.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton10.Radius = 24
        Me.GunaButton10.Size = New System.Drawing.Size(160, 50)
        Me.GunaButton10.TabIndex = 24
        Me.GunaButton10.Text = "About US"
        Me.GunaButton10.UseTransfarantBackground = True
        '
        'GunaButton9
        '
        Me.GunaButton9.AnimationHoverSpeed = 0.07!
        Me.GunaButton9.AnimationSpeed = 0.03!
        Me.GunaButton9.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton9.BaseColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaButton9.BorderColor = System.Drawing.Color.White
        Me.GunaButton9.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton9.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton9.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton9.ForeColor = System.Drawing.Color.White
        Me.GunaButton9.Image = CType(resources.GetObject("GunaButton9.Image"), System.Drawing.Image)
        Me.GunaButton9.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton9.Location = New System.Drawing.Point(15, 375)
        Me.GunaButton9.Name = "GunaButton9"
        Me.GunaButton9.OnHoverBaseColor = System.Drawing.Color.Gold
        Me.GunaButton9.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton9.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton9.OnHoverImage = Nothing
        Me.GunaButton9.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton9.Radius = 24
        Me.GunaButton9.Size = New System.Drawing.Size(187, 50)
        Me.GunaButton9.TabIndex = 22
        Me.GunaButton9.Text = "Courses & branches"
        Me.GunaButton9.UseTransfarantBackground = True
        '
        'GunaButton8
        '
        Me.GunaButton8.AnimationHoverSpeed = 0.07!
        Me.GunaButton8.AnimationSpeed = 0.03!
        Me.GunaButton8.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton8.BaseColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaButton8.BorderColor = System.Drawing.Color.White
        Me.GunaButton8.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton8.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton8.ForeColor = System.Drawing.Color.White
        Me.GunaButton8.Image = CType(resources.GetObject("GunaButton8.Image"), System.Drawing.Image)
        Me.GunaButton8.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton8.Location = New System.Drawing.Point(11, 266)
        Me.GunaButton8.Name = "GunaButton8"
        Me.GunaButton8.OnHoverBaseColor = System.Drawing.Color.Gold
        Me.GunaButton8.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton8.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton8.OnHoverImage = Nothing
        Me.GunaButton8.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton8.Radius = 24
        Me.GunaButton8.Size = New System.Drawing.Size(191, 50)
        Me.GunaButton8.TabIndex = 21
        Me.GunaButton8.Text = "Historique"
        Me.GunaButton8.UseTransfarantBackground = True
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaButton1.BorderColor = System.Drawing.Color.White
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = CType(resources.GetObject("GunaButton1.Image"), System.Drawing.Image)
        Me.GunaButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton1.Location = New System.Drawing.Point(15, 543)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.Gold
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 24
        Me.GunaButton1.Size = New System.Drawing.Size(160, 42)
        Me.GunaButton1.TabIndex = 16
        Me.GunaButton1.Text = "LogOut"
        Me.GunaButton1.UseTransfarantBackground = True
        '
        'GunaButton13
        '
        Me.GunaButton13.AnimationHoverSpeed = 0.07!
        Me.GunaButton13.AnimationSpeed = 0.03!
        Me.GunaButton13.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton13.BaseColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaButton13.BorderColor = System.Drawing.Color.White
        Me.GunaButton13.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton13.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton13.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton13.ForeColor = System.Drawing.Color.White
        Me.GunaButton13.Image = CType(resources.GetObject("GunaButton13.Image"), System.Drawing.Image)
        Me.GunaButton13.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton13.Location = New System.Drawing.Point(9, 210)
        Me.GunaButton13.Name = "GunaButton13"
        Me.GunaButton13.OnHoverBaseColor = System.Drawing.Color.Gold
        Me.GunaButton13.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton13.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton13.OnHoverImage = Nothing
        Me.GunaButton13.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton13.Radius = 24
        Me.GunaButton13.Size = New System.Drawing.Size(189, 50)
        Me.GunaButton13.TabIndex = 2
        Me.GunaButton13.Text = "Professeurs"
        Me.GunaButton13.UseTransfarantBackground = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.GunaButton11)
        Me.Panel4.Controls.Add(Me.GunaButton7)
        Me.Panel4.Controls.Add(Me.GunaButton5)
        Me.Panel4.Controls.Add(Me.GunaButton4)
        Me.Panel4.Location = New System.Drawing.Point(202, 141)
        Me.Panel4.MaximumSize = New System.Drawing.Size(164, 250)
        Me.Panel4.MinimumSize = New System.Drawing.Size(2, 250)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(164, 250)
        Me.Panel4.TabIndex = 20
        '
        'GunaButton11
        '
        Me.GunaButton11.AnimationHoverSpeed = 0.07!
        Me.GunaButton11.AnimationSpeed = 0.03!
        Me.GunaButton11.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton11.BaseColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.GunaButton11.BorderColor = System.Drawing.Color.White
        Me.GunaButton11.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton11.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton11.ForeColor = System.Drawing.Color.White
        Me.GunaButton11.Image = CType(resources.GetObject("GunaButton11.Image"), System.Drawing.Image)
        Me.GunaButton11.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton11.Location = New System.Drawing.Point(1, 151)
        Me.GunaButton11.Name = "GunaButton11"
        Me.GunaButton11.OnHoverBaseColor = System.Drawing.SystemColors.ButtonShadow
        Me.GunaButton11.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton11.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton11.OnHoverImage = Nothing
        Me.GunaButton11.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton11.Radius = 5
        Me.GunaButton11.Size = New System.Drawing.Size(160, 50)
        Me.GunaButton11.TabIndex = 30
        Me.GunaButton11.Text = "Les Notes"
        Me.GunaButton11.UseTransfarantBackground = True
        '
        'GunaButton7
        '
        Me.GunaButton7.AnimationHoverSpeed = 0.07!
        Me.GunaButton7.AnimationSpeed = 0.03!
        Me.GunaButton7.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton7.BaseColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.GunaButton7.BorderColor = System.Drawing.Color.White
        Me.GunaButton7.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton7.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton7.ForeColor = System.Drawing.Color.White
        Me.GunaButton7.Image = CType(resources.GetObject("GunaButton7.Image"), System.Drawing.Image)
        Me.GunaButton7.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton7.Location = New System.Drawing.Point(2, 101)
        Me.GunaButton7.Name = "GunaButton7"
        Me.GunaButton7.OnHoverBaseColor = System.Drawing.SystemColors.ButtonShadow
        Me.GunaButton7.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton7.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton7.OnHoverImage = Nothing
        Me.GunaButton7.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton7.Radius = 5
        Me.GunaButton7.Size = New System.Drawing.Size(160, 50)
        Me.GunaButton7.TabIndex = 29
        Me.GunaButton7.Text = "Absence"
        Me.GunaButton7.UseTransfarantBackground = True
        '
        'GunaButton5
        '
        Me.GunaButton5.AnimationHoverSpeed = 0.07!
        Me.GunaButton5.AnimationSpeed = 0.03!
        Me.GunaButton5.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.GunaButton5.BorderColor = System.Drawing.Color.White
        Me.GunaButton5.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton5.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton5.ForeColor = System.Drawing.Color.White
        Me.GunaButton5.Image = CType(resources.GetObject("GunaButton5.Image"), System.Drawing.Image)
        Me.GunaButton5.ImageSize = New System.Drawing.Size(23, 23)
        Me.GunaButton5.Location = New System.Drawing.Point(2, 51)
        Me.GunaButton5.Name = "GunaButton5"
        Me.GunaButton5.OnHoverBaseColor = System.Drawing.SystemColors.ButtonShadow
        Me.GunaButton5.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton5.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton5.OnHoverImage = Nothing
        Me.GunaButton5.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton5.Radius = 5
        Me.GunaButton5.Size = New System.Drawing.Size(160, 50)
        Me.GunaButton5.TabIndex = 27
        Me.GunaButton5.Text = " Payment/Modifier"
        Me.GunaButton5.UseTransfarantBackground = True
        '
        'GunaButton4
        '
        Me.GunaButton4.AnimationHoverSpeed = 0.07!
        Me.GunaButton4.AnimationSpeed = 0.03!
        Me.GunaButton4.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(4, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.GunaButton4.BorderColor = System.Drawing.Color.White
        Me.GunaButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton4.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaButton4.ForeColor = System.Drawing.Color.White
        Me.GunaButton4.Image = CType(resources.GetObject("GunaButton4.Image"), System.Drawing.Image)
        Me.GunaButton4.ImageSize = New System.Drawing.Size(30, 30)
        Me.GunaButton4.Location = New System.Drawing.Point(2, 1)
        Me.GunaButton4.Name = "GunaButton4"
        Me.GunaButton4.OnHoverBaseColor = System.Drawing.SystemColors.ButtonShadow
        Me.GunaButton4.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton4.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton4.OnHoverImage = Nothing
        Me.GunaButton4.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton4.Radius = 5
        Me.GunaButton4.Size = New System.Drawing.Size(160, 50)
        Me.GunaButton4.TabIndex = 26
        Me.GunaButton4.Text = "Ajouter Etudiant"
        Me.GunaButton4.UseTransfarantBackground = True
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox2.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(1067, 0)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox2.TabIndex = 17
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(1112, 0)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox1.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(202, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(951, 29)
        Me.Panel1.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(203, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(950, 582)
        Me.Panel2.TabIndex = 19
        '
        'Timer1
        '
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 608)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.GunaControlBox2)
        Me.Controls.Add(Me.GunaControlBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Home"
        Me.Text = "Admin"
        Me.GunaPanel1.ResumeLayout(False)
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GunaButton8 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton10 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton9 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton11 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton7 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton5 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton4 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton2 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton13 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton3 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaButton6 As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
End Class
