<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.BunifuElipse1 = New ns1.BunifuElipse(Me.components)
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.BunifuMaterialTextbox1 = New ns1.BunifuMaterialTextbox()
        Me.BunifuMaterialTextbox2 = New ns1.BunifuMaterialTextbox()
        Me.GunaSwitch1 = New Guna.UI.WinForms.GunaSwitch()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.BunifuCustomLabel1 = New ns1.BunifuCustomLabel()
        Me.GunaVSeparator1 = New Guna.UI.WinForms.GunaVSeparator()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaSeparator2 = New Guna.UI.WinForms.GunaSeparator()
        Me.GunaVSeparator2 = New Guna.UI.WinForms.GunaVSeparator()
        Me.GunaControlBox1 = New Guna.UI.WinForms.GunaControlBox()
        Me.GunaControlBox2 = New Guna.UI.WinForms.GunaControlBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPictureBox1 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaPanel1.Controls.Add(Me.GunaPictureBox1)
        Me.GunaPanel1.Location = New System.Drawing.Point(-2, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(275, 469)
        Me.GunaPanel1.TabIndex = 0
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 50
        Me.BunifuElipse1.TargetControl = Me
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
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(524, 380)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 15
        Me.GunaButton1.Size = New System.Drawing.Size(130, 38)
        Me.GunaButton1.TabIndex = 3
        Me.GunaButton1.Text = "Login"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox1.HintText = ""
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox1.LineThickness = 3
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(432, 204)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(293, 41)
        Me.BunifuMaterialTextbox1.TabIndex = 4
        Me.BunifuMaterialTextbox1.Text = "Email"
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuMaterialTextbox2
        '
        Me.BunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox2.HintText = ""
        Me.BunifuMaterialTextbox2.isPassword = False
        Me.BunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.BunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.BunifuMaterialTextbox2.LineThickness = 3
        Me.BunifuMaterialTextbox2.Location = New System.Drawing.Point(432, 267)
        Me.BunifuMaterialTextbox2.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox2.Name = "BunifuMaterialTextbox2"
        Me.BunifuMaterialTextbox2.Size = New System.Drawing.Size(293, 41)
        Me.BunifuMaterialTextbox2.TabIndex = 5
        Me.BunifuMaterialTextbox2.Text = "Password"
        Me.BunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'GunaSwitch1
        '
        Me.GunaSwitch1.BaseColor = System.Drawing.SystemColors.Control
        Me.GunaSwitch1.CheckedOffColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GunaSwitch1.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(2, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(92, Byte), Integer))
        Me.GunaSwitch1.FillColor = System.Drawing.Color.White
        Me.GunaSwitch1.Location = New System.Drawing.Point(445, 328)
        Me.GunaSwitch1.Name = "GunaSwitch1"
        Me.GunaSwitch1.Size = New System.Drawing.Size(28, 20)
        Me.GunaSwitch1.TabIndex = 6
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GunaLabel1.Location = New System.Drawing.Point(479, 331)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(89, 15)
        Me.GunaLabel1.TabIndex = 7
        Me.GunaLabel1.Text = "Show Password"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(571, 73)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(132, 62)
        Me.BunifuCustomLabel1.TabIndex = 8
        Me.BunifuCustomLabel1.Text = "Login" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "As Admin"
        '
        'GunaVSeparator1
        '
        Me.GunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaVSeparator1.Location = New System.Drawing.Point(838, 45)
        Me.GunaVSeparator1.Name = "GunaVSeparator1"
        Me.GunaVSeparator1.Size = New System.Drawing.Size(10, 49)
        Me.GunaVSeparator1.TabIndex = 10
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator1.Location = New System.Drawing.Point(794, 40)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(49, 10)
        Me.GunaSeparator1.TabIndex = 11
        '
        'GunaSeparator2
        '
        Me.GunaSeparator2.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator2.Location = New System.Drawing.Point(789, 440)
        Me.GunaSeparator2.Name = "GunaSeparator2"
        Me.GunaSeparator2.Size = New System.Drawing.Size(49, 10)
        Me.GunaSeparator2.TabIndex = 13
        '
        'GunaVSeparator2
        '
        Me.GunaVSeparator2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator2.LineColor = System.Drawing.Color.Silver
        Me.GunaVSeparator2.Location = New System.Drawing.Point(833, 397)
        Me.GunaVSeparator2.Name = "GunaVSeparator2"
        Me.GunaVSeparator2.Size = New System.Drawing.Size(10, 49)
        Me.GunaVSeparator2.TabIndex = 12
        '
        'GunaControlBox1
        '
        Me.GunaControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox1.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox1.AnimationSpeed = 0.03!
        Me.GunaControlBox1.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox1.IconSize = 15.0!
        Me.GunaControlBox1.Location = New System.Drawing.Point(851, 1)
        Me.GunaControlBox1.Name = "GunaControlBox1"
        Me.GunaControlBox1.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox1.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox1.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox1.TabIndex = 14
        '
        'GunaControlBox2
        '
        Me.GunaControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaControlBox2.AnimationHoverSpeed = 0.07!
        Me.GunaControlBox2.AnimationSpeed = 0.03!
        Me.GunaControlBox2.ControlBoxType = Guna.UI.WinForms.FormControlBoxType.MinimizeBox
        Me.GunaControlBox2.IconColor = System.Drawing.Color.Black
        Me.GunaControlBox2.IconSize = 15.0!
        Me.GunaControlBox2.Location = New System.Drawing.Point(806, 1)
        Me.GunaControlBox2.Name = "GunaControlBox2"
        Me.GunaControlBox2.OnHoverBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(183, Byte), Integer))
        Me.GunaControlBox2.OnHoverIconColor = System.Drawing.Color.White
        Me.GunaControlBox2.OnPressedColor = System.Drawing.Color.Black
        Me.GunaControlBox2.Size = New System.Drawing.Size(45, 29)
        Me.GunaControlBox2.TabIndex = 15
        '
        'Panel1
        '
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(903, 30)
        Me.Panel1.TabIndex = 16
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(445, 57)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(120, 101)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox2.TabIndex = 1
        Me.GunaPictureBox2.TabStop = False
        '
        'GunaPictureBox1
        '
        Me.GunaPictureBox1.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox1.Image = CType(resources.GetObject("GunaPictureBox1.Image"), System.Drawing.Image)
        Me.GunaPictureBox1.Location = New System.Drawing.Point(-18, -14)
        Me.GunaPictureBox1.Name = "GunaPictureBox1"
        Me.GunaPictureBox1.Size = New System.Drawing.Size(310, 493)
        Me.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.GunaPictureBox1.TabIndex = 0
        Me.GunaPictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(903, 468)
        Me.Controls.Add(Me.GunaControlBox2)
        Me.Controls.Add(Me.GunaControlBox1)
        Me.Controls.Add(Me.GunaSeparator2)
        Me.Controls.Add(Me.GunaVSeparator2)
        Me.Controls.Add(Me.GunaSeparator1)
        Me.Controls.Add(Me.GunaVSeparator1)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.GunaPictureBox2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.GunaSwitch1)
        Me.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Controls.Add(Me.BunifuMaterialTextbox2)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GunaPanel1.ResumeLayout(False)
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPictureBox1 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents BunifuElipse1 As ns1.BunifuElipse
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaSwitch1 As Guna.UI.WinForms.GunaSwitch
    Friend WithEvents BunifuMaterialTextbox2 As ns1.BunifuMaterialTextbox
    Friend WithEvents BunifuMaterialTextbox1 As ns1.BunifuMaterialTextbox
    Friend WithEvents GunaButton1 As Guna.UI.WinForms.GunaButton
    Friend WithEvents BunifuCustomLabel1 As ns1.BunifuCustomLabel
    Friend WithEvents GunaVSeparator1 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents GunaSeparator2 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaVSeparator2 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents GunaControlBox2 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents GunaControlBox1 As Guna.UI.WinForms.GunaControlBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
