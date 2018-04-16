<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stafffrm
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
        Dim Animation11 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation10 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation12 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim Animation9 As BunifuAnimatorNS.Animation = New BunifuAnimatorNS.Animation()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Stafffrm))
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.header = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuImageButton4 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton3 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuImageButton2 = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton7 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton5 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton4 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton3 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnMenu = New Bunifu.Framework.UI.BunifuImageButton()
        Me.logo = New System.Windows.Forms.PictureBox()
        Me.LogoAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.SettingsPanel = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton14 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton15 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton16 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SeatsPanel = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton21 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MoviesPanel = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton23 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton24 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton25 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.CustomersPanel = New System.Windows.Forms.Panel()
        Me.BunifuFlatButton26 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton27 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.BunifuFlatButton28 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SubPanel = New System.Windows.Forms.Panel()
        Me.main = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuCircleProgressbar1 = New Bunifu.Framework.UI.BunifuCircleProgressbar()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PanelAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.VertAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.BrandAnimator = New BunifuAnimatorNS.BunifuTransition(Me.components)
        Me.header.SuspendLayout()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SidePanel.SuspendLayout()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SettingsPanel.SuspendLayout()
        Me.SeatsPanel.SuspendLayout()
        Me.MoviesPanel.SuspendLayout()
        Me.CustomersPanel.SuspendLayout()
        Me.SubPanel.SuspendLayout()
        Me.main.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 10
        Me.BunifuElipse1.TargetControl = Me
        '
        'header
        '
        Me.header.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.header.Controls.Add(Me.Label8)
        Me.header.Controls.Add(Me.BunifuCustomLabel2)
        Me.header.Controls.Add(Me.BunifuImageButton4)
        Me.header.Controls.Add(Me.BunifuImageButton3)
        Me.header.Controls.Add(Me.BunifuImageButton2)
        Me.BrandAnimator.SetDecoration(Me.header, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.header, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.header, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.header, BunifuAnimatorNS.DecorationType.None)
        Me.header.Dock = System.Windows.Forms.DockStyle.Top
        Me.header.Location = New System.Drawing.Point(0, 0)
        Me.header.Name = "header"
        Me.header.Size = New System.Drawing.Size(945, 44)
        Me.header.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.VertAnimator.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.BrandAnimator.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.Label8, BunifuAnimatorNS.DecorationType.None)
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(58, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 20)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Staff"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.VertAnimator.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BrandAnimator.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuCustomLabel2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(826, 14)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(65, 21)
        Me.BunifuCustomLabel2.TabIndex = 2
        Me.BunifuCustomLabel2.Text = "Logout"
        '
        'BunifuImageButton4
        '
        Me.BunifuImageButton4.BackColor = System.Drawing.Color.Transparent
        Me.BrandAnimator.SetDecoration(Me.BunifuImageButton4, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuImageButton4, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuImageButton4, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.BunifuImageButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton4.Image = CType(resources.GetObject("BunifuImageButton4.Image"), System.Drawing.Image)
        Me.BunifuImageButton4.ImageActive = Nothing
        Me.BunifuImageButton4.Location = New System.Drawing.Point(798, 11)
        Me.BunifuImageButton4.Name = "BunifuImageButton4"
        Me.BunifuImageButton4.Size = New System.Drawing.Size(29, 26)
        Me.BunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton4.TabIndex = 3
        Me.BunifuImageButton4.TabStop = False
        Me.BunifuImageButton4.Zoom = 10
        '
        'BunifuImageButton3
        '
        Me.BunifuImageButton3.BackColor = System.Drawing.Color.Transparent
        Me.BrandAnimator.SetDecoration(Me.BunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.BunifuImageButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton3.Image = CType(resources.GetObject("BunifuImageButton3.Image"), System.Drawing.Image)
        Me.BunifuImageButton3.ImageActive = Nothing
        Me.BunifuImageButton3.Location = New System.Drawing.Point(898, 11)
        Me.BunifuImageButton3.Name = "BunifuImageButton3"
        Me.BunifuImageButton3.Size = New System.Drawing.Size(28, 27)
        Me.BunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton3.TabIndex = 2
        Me.BunifuImageButton3.TabStop = False
        Me.BunifuImageButton3.Zoom = 10
        '
        'BunifuImageButton2
        '
        Me.BunifuImageButton2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuImageButton2.BackgroundImage = CType(resources.GetObject("BunifuImageButton2.BackgroundImage"), System.Drawing.Image)
        Me.BrandAnimator.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.BunifuImageButton2, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuImageButton2.Image = CType(resources.GetObject("BunifuImageButton2.Image"), System.Drawing.Image)
        Me.BunifuImageButton2.ImageActive = Nothing
        Me.BunifuImageButton2.Location = New System.Drawing.Point(13, 5)
        Me.BunifuImageButton2.Name = "BunifuImageButton2"
        Me.BunifuImageButton2.Size = New System.Drawing.Size(37, 33)
        Me.BunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BunifuImageButton2.TabIndex = 2
        Me.BunifuImageButton2.TabStop = False
        Me.BunifuImageButton2.Zoom = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.VertAnimator.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.BrandAnimator.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.Label4, BunifuAnimatorNS.DecorationType.None)
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(801, 264)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 21)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "00:00:00"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.VertAnimator.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.BrandAnimator.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuCustomLabel3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(821, 233)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(0, 21)
        Me.BunifuCustomLabel3.TabIndex = 4
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.VertAnimator.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BrandAnimator.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(788, 231)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(28, 21)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Hi,"
        '
        'SidePanel
        '
        Me.SidePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.SidePanel.Controls.Add(Me.BunifuFlatButton7)
        Me.SidePanel.Controls.Add(Me.BunifuFlatButton5)
        Me.SidePanel.Controls.Add(Me.BunifuFlatButton4)
        Me.SidePanel.Controls.Add(Me.BunifuFlatButton3)
        Me.SidePanel.Controls.Add(Me.btnMenu)
        Me.SidePanel.Controls.Add(Me.logo)
        Me.BrandAnimator.SetDecoration(Me.SidePanel, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.SidePanel, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.SidePanel, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.SidePanel, BunifuAnimatorNS.DecorationType.None)
        Me.SidePanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.SidePanel.Location = New System.Drawing.Point(0, 44)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(221, 524)
        Me.SidePanel.TabIndex = 1
        Me.SidePanel.Visible = False
        '
        'BunifuFlatButton7
        '
        Me.BunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton7.BorderRadius = 0
        Me.BunifuFlatButton7.ButtonText = "                   Settings"
        Me.BunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrandAnimator.SetDecoration(Me.BunifuFlatButton7, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton7, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuFlatButton7, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.BunifuFlatButton7, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton7.Iconimage = CType(resources.GetObject("BunifuFlatButton7.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton7.Iconimage_right = Nothing
        Me.BunifuFlatButton7.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton7.Iconimage_Selected = Nothing
        Me.BunifuFlatButton7.IconMarginLeft = 0
        Me.BunifuFlatButton7.IconMarginRight = 0
        Me.BunifuFlatButton7.IconRightVisible = True
        Me.BunifuFlatButton7.IconRightZoom = 0.0R
        Me.BunifuFlatButton7.IconVisible = True
        Me.BunifuFlatButton7.IconZoom = 60.0R
        Me.BunifuFlatButton7.IsTab = False
        Me.BunifuFlatButton7.Location = New System.Drawing.Point(0, 393)
        Me.BunifuFlatButton7.Name = "BunifuFlatButton7"
        Me.BunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton7.selected = False
        Me.BunifuFlatButton7.Size = New System.Drawing.Size(229, 52)
        Me.BunifuFlatButton7.TabIndex = 5
        Me.BunifuFlatButton7.Text = "                   Settings"
        Me.BunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton7.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton7.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton5
        '
        Me.BunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton5.BorderRadius = 0
        Me.BunifuFlatButton5.ButtonText = "                  Time Logs"
        Me.BunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrandAnimator.SetDecoration(Me.BunifuFlatButton5, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton5, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuFlatButton5, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.BunifuFlatButton5, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton5.Iconimage = CType(resources.GetObject("BunifuFlatButton5.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton5.Iconimage_right = Nothing
        Me.BunifuFlatButton5.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton5.Iconimage_Selected = Nothing
        Me.BunifuFlatButton5.IconMarginLeft = 0
        Me.BunifuFlatButton5.IconMarginRight = 0
        Me.BunifuFlatButton5.IconRightVisible = True
        Me.BunifuFlatButton5.IconRightZoom = 0.0R
        Me.BunifuFlatButton5.IconVisible = True
        Me.BunifuFlatButton5.IconZoom = 70.0R
        Me.BunifuFlatButton5.IsTab = False
        Me.BunifuFlatButton5.Location = New System.Drawing.Point(0, 319)
        Me.BunifuFlatButton5.Name = "BunifuFlatButton5"
        Me.BunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton5.selected = False
        Me.BunifuFlatButton5.Size = New System.Drawing.Size(229, 52)
        Me.BunifuFlatButton5.TabIndex = 5
        Me.BunifuFlatButton5.Text = "                  Time Logs"
        Me.BunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton5.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton5.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton4
        '
        Me.BunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton4.BorderRadius = 0
        Me.BunifuFlatButton4.ButtonText = "                   Movies"
        Me.BunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrandAnimator.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.BunifuFlatButton4, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton4.Iconimage = CType(resources.GetObject("BunifuFlatButton4.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton4.Iconimage_right = Nothing
        Me.BunifuFlatButton4.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton4.Iconimage_Selected = Nothing
        Me.BunifuFlatButton4.IconMarginLeft = 0
        Me.BunifuFlatButton4.IconMarginRight = 0
        Me.BunifuFlatButton4.IconRightVisible = True
        Me.BunifuFlatButton4.IconRightZoom = 0.0R
        Me.BunifuFlatButton4.IconVisible = True
        Me.BunifuFlatButton4.IconZoom = 50.0R
        Me.BunifuFlatButton4.IsTab = False
        Me.BunifuFlatButton4.Location = New System.Drawing.Point(0, 247)
        Me.BunifuFlatButton4.Name = "BunifuFlatButton4"
        Me.BunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton4.selected = False
        Me.BunifuFlatButton4.Size = New System.Drawing.Size(229, 52)
        Me.BunifuFlatButton4.TabIndex = 5
        Me.BunifuFlatButton4.Text = "                   Movies"
        Me.BunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton4.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton4.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton3
        '
        Me.BunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton3.BorderRadius = 0
        Me.BunifuFlatButton3.ButtonText = "                  Customers"
        Me.BunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrandAnimator.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.BunifuFlatButton3, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton3.Iconimage = CType(resources.GetObject("BunifuFlatButton3.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton3.Iconimage_right = Nothing
        Me.BunifuFlatButton3.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton3.Iconimage_Selected = Nothing
        Me.BunifuFlatButton3.IconMarginLeft = 0
        Me.BunifuFlatButton3.IconMarginRight = 0
        Me.BunifuFlatButton3.IconRightVisible = True
        Me.BunifuFlatButton3.IconRightZoom = 0.0R
        Me.BunifuFlatButton3.IconVisible = True
        Me.BunifuFlatButton3.IconZoom = 80.0R
        Me.BunifuFlatButton3.IsTab = False
        Me.BunifuFlatButton3.Location = New System.Drawing.Point(0, 175)
        Me.BunifuFlatButton3.Name = "BunifuFlatButton3"
        Me.BunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton3.selected = False
        Me.BunifuFlatButton3.Size = New System.Drawing.Size(229, 52)
        Me.BunifuFlatButton3.TabIndex = 4
        Me.BunifuFlatButton3.Text = "                  Customers"
        Me.BunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton3.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton3.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnMenu.BackColor = System.Drawing.Color.Transparent
        Me.BrandAnimator.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.btnMenu, BunifuAnimatorNS.DecorationType.None)
        Me.btnMenu.Image = CType(resources.GetObject("btnMenu.Image"), System.Drawing.Image)
        Me.btnMenu.ImageActive = Nothing
        Me.btnMenu.Location = New System.Drawing.Point(182, 13)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(29, 26)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 1
        Me.btnMenu.TabStop = False
        Me.btnMenu.Zoom = 10
        '
        'logo
        '
        Me.VertAnimator.SetDecoration(Me.logo, BunifuAnimatorNS.DecorationType.None)
        Me.BrandAnimator.SetDecoration(Me.logo, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.logo, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.logo, BunifuAnimatorNS.DecorationType.None)
        Me.logo.Image = CType(resources.GetObject("logo.Image"), System.Drawing.Image)
        Me.logo.Location = New System.Drawing.Point(-10, 61)
        Me.logo.Name = "logo"
        Me.logo.Size = New System.Drawing.Size(184, 80)
        Me.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logo.TabIndex = 0
        Me.logo.TabStop = False
        '
        'LogoAnimator
        '
        Me.LogoAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Rotate
        Me.LogoAnimator.Cursor = Nothing
        Animation11.AnimateOnlyDifferences = True
        Animation11.BlindCoeff = CType(resources.GetObject("Animation11.BlindCoeff"), System.Drawing.PointF)
        Animation11.LeafCoeff = 0.0!
        Animation11.MaxTime = 1.0!
        Animation11.MinTime = 0.0!
        Animation11.MosaicCoeff = CType(resources.GetObject("Animation11.MosaicCoeff"), System.Drawing.PointF)
        Animation11.MosaicShift = CType(resources.GetObject("Animation11.MosaicShift"), System.Drawing.PointF)
        Animation11.MosaicSize = 0
        Animation11.Padding = New System.Windows.Forms.Padding(50)
        Animation11.RotateCoeff = 1.0!
        Animation11.RotateLimit = 0.0!
        Animation11.ScaleCoeff = CType(resources.GetObject("Animation11.ScaleCoeff"), System.Drawing.PointF)
        Animation11.SlideCoeff = CType(resources.GetObject("Animation11.SlideCoeff"), System.Drawing.PointF)
        Animation11.TimeCoeff = 0.0!
        Animation11.TransparencyCoeff = 1.0!
        Me.LogoAnimator.DefaultAnimation = Animation11
        '
        'SettingsPanel
        '
        Me.SettingsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SettingsPanel.Controls.Add(Me.BunifuFlatButton14)
        Me.SettingsPanel.Controls.Add(Me.BunifuFlatButton15)
        Me.SettingsPanel.Controls.Add(Me.BunifuFlatButton16)
        Me.BrandAnimator.SetDecoration(Me.SettingsPanel, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.SettingsPanel, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.SettingsPanel, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.SettingsPanel, BunifuAnimatorNS.DecorationType.None)
        Me.SettingsPanel.Location = New System.Drawing.Point(0, 230)
        Me.SettingsPanel.Name = "SettingsPanel"
        Me.SettingsPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SettingsPanel.Size = New System.Drawing.Size(213, 151)
        Me.SettingsPanel.TabIndex = 9
        Me.SettingsPanel.Visible = False
        '
        'BunifuFlatButton14
        '
        Me.BunifuFlatButton14.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton14.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton14.BorderRadius = 0
        Me.BunifuFlatButton14.ButtonText = "                   Security"
        Me.BunifuFlatButton14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrandAnimator.SetDecoration(Me.BunifuFlatButton14, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton14, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuFlatButton14, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.BunifuFlatButton14, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton14.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton14.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton14.Iconimage = CType(resources.GetObject("BunifuFlatButton14.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton14.Iconimage_right = Nothing
        Me.BunifuFlatButton14.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton14.Iconimage_Selected = Nothing
        Me.BunifuFlatButton14.IconMarginLeft = 0
        Me.BunifuFlatButton14.IconMarginRight = 0
        Me.BunifuFlatButton14.IconRightVisible = True
        Me.BunifuFlatButton14.IconRightZoom = 0.0R
        Me.BunifuFlatButton14.IconVisible = True
        Me.BunifuFlatButton14.IconZoom = 60.0R
        Me.BunifuFlatButton14.IsTab = False
        Me.BunifuFlatButton14.Location = New System.Drawing.Point(0, 98)
        Me.BunifuFlatButton14.Name = "BunifuFlatButton14"
        Me.BunifuFlatButton14.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton14.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton14.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton14.selected = False
        Me.BunifuFlatButton14.Size = New System.Drawing.Size(229, 52)
        Me.BunifuFlatButton14.TabIndex = 6
        Me.BunifuFlatButton14.Text = "                   Security"
        Me.BunifuFlatButton14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton14.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton14.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton15
        '
        Me.BunifuFlatButton15.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton15.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton15.BorderRadius = 0
        Me.BunifuFlatButton15.ButtonText = "    Change Password"
        Me.BunifuFlatButton15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrandAnimator.SetDecoration(Me.BunifuFlatButton15, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton15, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuFlatButton15, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.BunifuFlatButton15, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton15.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton15.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton15.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton15.Iconimage = CType(resources.GetObject("BunifuFlatButton15.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton15.Iconimage_right = Nothing
        Me.BunifuFlatButton15.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton15.Iconimage_Selected = Nothing
        Me.BunifuFlatButton15.IconMarginLeft = 0
        Me.BunifuFlatButton15.IconMarginRight = 0
        Me.BunifuFlatButton15.IconRightVisible = True
        Me.BunifuFlatButton15.IconRightZoom = 0.0R
        Me.BunifuFlatButton15.IconVisible = True
        Me.BunifuFlatButton15.IconZoom = 60.0R
        Me.BunifuFlatButton15.IsTab = False
        Me.BunifuFlatButton15.Location = New System.Drawing.Point(0, 53)
        Me.BunifuFlatButton15.Name = "BunifuFlatButton15"
        Me.BunifuFlatButton15.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton15.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton15.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton15.selected = False
        Me.BunifuFlatButton15.Size = New System.Drawing.Size(229, 52)
        Me.BunifuFlatButton15.TabIndex = 4
        Me.BunifuFlatButton15.Text = "    Change Password"
        Me.BunifuFlatButton15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton15.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton15.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton16
        '
        Me.BunifuFlatButton16.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton16.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton16.BorderRadius = 0
        Me.BunifuFlatButton16.ButtonText = "         View Account"
        Me.BunifuFlatButton16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrandAnimator.SetDecoration(Me.BunifuFlatButton16, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton16, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuFlatButton16, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.BunifuFlatButton16, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton16.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton16.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton16.Iconimage = CType(resources.GetObject("BunifuFlatButton16.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton16.Iconimage_right = Nothing
        Me.BunifuFlatButton16.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton16.Iconimage_Selected = Nothing
        Me.BunifuFlatButton16.IconMarginLeft = 0
        Me.BunifuFlatButton16.IconMarginRight = 0
        Me.BunifuFlatButton16.IconRightVisible = True
        Me.BunifuFlatButton16.IconRightZoom = 0.0R
        Me.BunifuFlatButton16.IconVisible = True
        Me.BunifuFlatButton16.IconZoom = 60.0R
        Me.BunifuFlatButton16.IsTab = False
        Me.BunifuFlatButton16.Location = New System.Drawing.Point(0, 4)
        Me.BunifuFlatButton16.Name = "BunifuFlatButton16"
        Me.BunifuFlatButton16.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton16.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton16.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton16.selected = False
        Me.BunifuFlatButton16.Size = New System.Drawing.Size(229, 52)
        Me.BunifuFlatButton16.TabIndex = 3
        Me.BunifuFlatButton16.Text = "         View Account"
        Me.BunifuFlatButton16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton16.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton16.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SeatsPanel
        '
        Me.SeatsPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeatsPanel.Controls.Add(Me.BunifuFlatButton21)
        Me.BrandAnimator.SetDecoration(Me.SeatsPanel, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.SeatsPanel, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.SeatsPanel, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.SeatsPanel, BunifuAnimatorNS.DecorationType.None)
        Me.SeatsPanel.Location = New System.Drawing.Point(0, 153)
        Me.SeatsPanel.Name = "SeatsPanel"
        Me.SeatsPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SeatsPanel.Size = New System.Drawing.Size(213, 151)
        Me.SeatsPanel.TabIndex = 11
        Me.SeatsPanel.Visible = False
        '
        'BunifuFlatButton21
        '
        Me.BunifuFlatButton21.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton21.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton21.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton21.BorderRadius = 0
        Me.BunifuFlatButton21.ButtonText = "                Your Logs"
        Me.BunifuFlatButton21.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrandAnimator.SetDecoration(Me.BunifuFlatButton21, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton21, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuFlatButton21, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.BunifuFlatButton21, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton21.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton21.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton21.Iconimage = CType(resources.GetObject("BunifuFlatButton21.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton21.Iconimage_right = Nothing
        Me.BunifuFlatButton21.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton21.Iconimage_Selected = Nothing
        Me.BunifuFlatButton21.IconMarginLeft = 0
        Me.BunifuFlatButton21.IconMarginRight = 0
        Me.BunifuFlatButton21.IconRightVisible = True
        Me.BunifuFlatButton21.IconRightZoom = 0.0R
        Me.BunifuFlatButton21.IconVisible = True
        Me.BunifuFlatButton21.IconZoom = 60.0R
        Me.BunifuFlatButton21.IsTab = False
        Me.BunifuFlatButton21.Location = New System.Drawing.Point(0, 53)
        Me.BunifuFlatButton21.Name = "BunifuFlatButton21"
        Me.BunifuFlatButton21.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton21.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton21.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton21.selected = False
        Me.BunifuFlatButton21.Size = New System.Drawing.Size(229, 52)
        Me.BunifuFlatButton21.TabIndex = 4
        Me.BunifuFlatButton21.Text = "                Your Logs"
        Me.BunifuFlatButton21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton21.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton21.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MoviesPanel
        '
        Me.MoviesPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MoviesPanel.Controls.Add(Me.BunifuFlatButton23)
        Me.MoviesPanel.Controls.Add(Me.BunifuFlatButton24)
        Me.MoviesPanel.Controls.Add(Me.BunifuFlatButton25)
        Me.BrandAnimator.SetDecoration(Me.MoviesPanel, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.MoviesPanel, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.MoviesPanel, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.MoviesPanel, BunifuAnimatorNS.DecorationType.None)
        Me.MoviesPanel.Location = New System.Drawing.Point(0, 80)
        Me.MoviesPanel.Name = "MoviesPanel"
        Me.MoviesPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MoviesPanel.Size = New System.Drawing.Size(213, 151)
        Me.MoviesPanel.TabIndex = 12
        Me.MoviesPanel.Visible = False
        '
        'BunifuFlatButton23
        '
        Me.BunifuFlatButton23.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton23.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton23.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton23.BorderRadius = 0
        Me.BunifuFlatButton23.ButtonText = "           View Movie"
        Me.BunifuFlatButton23.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrandAnimator.SetDecoration(Me.BunifuFlatButton23, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton23, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuFlatButton23, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.BunifuFlatButton23, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton23.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton23.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton23.Iconimage = CType(resources.GetObject("BunifuFlatButton23.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton23.Iconimage_right = Nothing
        Me.BunifuFlatButton23.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton23.Iconimage_Selected = Nothing
        Me.BunifuFlatButton23.IconMarginLeft = 0
        Me.BunifuFlatButton23.IconMarginRight = 0
        Me.BunifuFlatButton23.IconRightVisible = True
        Me.BunifuFlatButton23.IconRightZoom = 0.0R
        Me.BunifuFlatButton23.IconVisible = True
        Me.BunifuFlatButton23.IconZoom = 60.0R
        Me.BunifuFlatButton23.IsTab = False
        Me.BunifuFlatButton23.Location = New System.Drawing.Point(0, 98)
        Me.BunifuFlatButton23.Name = "BunifuFlatButton23"
        Me.BunifuFlatButton23.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton23.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton23.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton23.selected = False
        Me.BunifuFlatButton23.Size = New System.Drawing.Size(229, 52)
        Me.BunifuFlatButton23.TabIndex = 6
        Me.BunifuFlatButton23.Text = "           View Movie"
        Me.BunifuFlatButton23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton23.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton23.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton24
        '
        Me.BunifuFlatButton24.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton24.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton24.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton24.BorderRadius = 0
        Me.BunifuFlatButton24.ButtonText = "             Edit Movie"
        Me.BunifuFlatButton24.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrandAnimator.SetDecoration(Me.BunifuFlatButton24, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton24, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuFlatButton24, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.BunifuFlatButton24, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton24.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton24.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton24.Iconimage = CType(resources.GetObject("BunifuFlatButton24.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton24.Iconimage_right = Nothing
        Me.BunifuFlatButton24.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton24.Iconimage_Selected = Nothing
        Me.BunifuFlatButton24.IconMarginLeft = 0
        Me.BunifuFlatButton24.IconMarginRight = 0
        Me.BunifuFlatButton24.IconRightVisible = True
        Me.BunifuFlatButton24.IconRightZoom = 0.0R
        Me.BunifuFlatButton24.IconVisible = True
        Me.BunifuFlatButton24.IconZoom = 60.0R
        Me.BunifuFlatButton24.IsTab = False
        Me.BunifuFlatButton24.Location = New System.Drawing.Point(0, 53)
        Me.BunifuFlatButton24.Name = "BunifuFlatButton24"
        Me.BunifuFlatButton24.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton24.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton24.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton24.selected = False
        Me.BunifuFlatButton24.Size = New System.Drawing.Size(229, 52)
        Me.BunifuFlatButton24.TabIndex = 4
        Me.BunifuFlatButton24.Text = "             Edit Movie"
        Me.BunifuFlatButton24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton24.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton24.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton25
        '
        Me.BunifuFlatButton25.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton25.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton25.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton25.BorderRadius = 0
        Me.BunifuFlatButton25.ButtonText = "            Add Movie "
        Me.BunifuFlatButton25.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrandAnimator.SetDecoration(Me.BunifuFlatButton25, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton25, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuFlatButton25, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.BunifuFlatButton25, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton25.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton25.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton25.Iconimage = CType(resources.GetObject("BunifuFlatButton25.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton25.Iconimage_right = Nothing
        Me.BunifuFlatButton25.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton25.Iconimage_Selected = Nothing
        Me.BunifuFlatButton25.IconMarginLeft = 0
        Me.BunifuFlatButton25.IconMarginRight = 0
        Me.BunifuFlatButton25.IconRightVisible = True
        Me.BunifuFlatButton25.IconRightZoom = 0.0R
        Me.BunifuFlatButton25.IconVisible = True
        Me.BunifuFlatButton25.IconZoom = 60.0R
        Me.BunifuFlatButton25.IsTab = False
        Me.BunifuFlatButton25.Location = New System.Drawing.Point(0, 4)
        Me.BunifuFlatButton25.Name = "BunifuFlatButton25"
        Me.BunifuFlatButton25.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton25.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton25.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton25.selected = False
        Me.BunifuFlatButton25.Size = New System.Drawing.Size(229, 52)
        Me.BunifuFlatButton25.TabIndex = 3
        Me.BunifuFlatButton25.Text = "            Add Movie "
        Me.BunifuFlatButton25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton25.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton25.TextFont = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'CustomersPanel
        '
        Me.CustomersPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomersPanel.Controls.Add(Me.BunifuFlatButton26)
        Me.CustomersPanel.Controls.Add(Me.BunifuFlatButton27)
        Me.CustomersPanel.Controls.Add(Me.BunifuFlatButton28)
        Me.BrandAnimator.SetDecoration(Me.CustomersPanel, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.CustomersPanel, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.CustomersPanel, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.CustomersPanel, BunifuAnimatorNS.DecorationType.None)
        Me.CustomersPanel.Location = New System.Drawing.Point(0, 9)
        Me.CustomersPanel.Name = "CustomersPanel"
        Me.CustomersPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CustomersPanel.Size = New System.Drawing.Size(213, 151)
        Me.CustomersPanel.TabIndex = 13
        Me.CustomersPanel.Visible = False
        '
        'BunifuFlatButton26
        '
        Me.BunifuFlatButton26.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton26.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton26.BorderRadius = 0
        Me.BunifuFlatButton26.ButtonText = "     View Customer's RFID"
        Me.BunifuFlatButton26.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrandAnimator.SetDecoration(Me.BunifuFlatButton26, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton26, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuFlatButton26, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.BunifuFlatButton26, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton26.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton26.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton26.Iconimage = CType(resources.GetObject("BunifuFlatButton26.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton26.Iconimage_right = Nothing
        Me.BunifuFlatButton26.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton26.Iconimage_Selected = Nothing
        Me.BunifuFlatButton26.IconMarginLeft = 0
        Me.BunifuFlatButton26.IconMarginRight = 0
        Me.BunifuFlatButton26.IconRightVisible = True
        Me.BunifuFlatButton26.IconRightZoom = 0.0R
        Me.BunifuFlatButton26.IconVisible = True
        Me.BunifuFlatButton26.IconZoom = 60.0R
        Me.BunifuFlatButton26.IsTab = False
        Me.BunifuFlatButton26.Location = New System.Drawing.Point(0, 98)
        Me.BunifuFlatButton26.Name = "BunifuFlatButton26"
        Me.BunifuFlatButton26.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton26.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton26.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton26.selected = False
        Me.BunifuFlatButton26.Size = New System.Drawing.Size(229, 52)
        Me.BunifuFlatButton26.TabIndex = 6
        Me.BunifuFlatButton26.Text = "     View Customer's RFID"
        Me.BunifuFlatButton26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton26.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton26.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton27
        '
        Me.BunifuFlatButton27.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton27.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton27.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton27.BorderRadius = 0
        Me.BunifuFlatButton27.ButtonText = "     Load Customer's RFID"
        Me.BunifuFlatButton27.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrandAnimator.SetDecoration(Me.BunifuFlatButton27, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton27, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuFlatButton27, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.BunifuFlatButton27, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton27.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton27.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton27.Iconimage = CType(resources.GetObject("BunifuFlatButton27.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton27.Iconimage_right = Nothing
        Me.BunifuFlatButton27.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton27.Iconimage_Selected = Nothing
        Me.BunifuFlatButton27.IconMarginLeft = 0
        Me.BunifuFlatButton27.IconMarginRight = 0
        Me.BunifuFlatButton27.IconRightVisible = True
        Me.BunifuFlatButton27.IconRightZoom = 0.0R
        Me.BunifuFlatButton27.IconVisible = True
        Me.BunifuFlatButton27.IconZoom = 60.0R
        Me.BunifuFlatButton27.IsTab = False
        Me.BunifuFlatButton27.Location = New System.Drawing.Point(0, 53)
        Me.BunifuFlatButton27.Name = "BunifuFlatButton27"
        Me.BunifuFlatButton27.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton27.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton27.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton27.selected = False
        Me.BunifuFlatButton27.Size = New System.Drawing.Size(229, 52)
        Me.BunifuFlatButton27.TabIndex = 4
        Me.BunifuFlatButton27.Text = "     Load Customer's RFID"
        Me.BunifuFlatButton27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton27.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton27.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'BunifuFlatButton28
        '
        Me.BunifuFlatButton28.Activecolor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BunifuFlatButton28.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton28.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton28.BorderRadius = 0
        Me.BunifuFlatButton28.ButtonText = "      Add Customer's RFID"
        Me.BunifuFlatButton28.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BrandAnimator.SetDecoration(Me.BunifuFlatButton28, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuFlatButton28, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.BunifuFlatButton28, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.BunifuFlatButton28, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuFlatButton28.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton28.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuFlatButton28.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton28.Iconimage = CType(resources.GetObject("BunifuFlatButton28.Iconimage"), System.Drawing.Image)
        Me.BunifuFlatButton28.Iconimage_right = Nothing
        Me.BunifuFlatButton28.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton28.Iconimage_Selected = Nothing
        Me.BunifuFlatButton28.IconMarginLeft = 0
        Me.BunifuFlatButton28.IconMarginRight = 0
        Me.BunifuFlatButton28.IconRightVisible = True
        Me.BunifuFlatButton28.IconRightZoom = 0.0R
        Me.BunifuFlatButton28.IconVisible = True
        Me.BunifuFlatButton28.IconZoom = 60.0R
        Me.BunifuFlatButton28.IsTab = False
        Me.BunifuFlatButton28.Location = New System.Drawing.Point(0, 4)
        Me.BunifuFlatButton28.Name = "BunifuFlatButton28"
        Me.BunifuFlatButton28.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BunifuFlatButton28.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuFlatButton28.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton28.selected = False
        Me.BunifuFlatButton28.Size = New System.Drawing.Size(229, 52)
        Me.BunifuFlatButton28.TabIndex = 3
        Me.BunifuFlatButton28.Text = "      Add Customer's RFID"
        Me.BunifuFlatButton28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BunifuFlatButton28.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton28.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'SubPanel
        '
        Me.SubPanel.Controls.Add(Me.CustomersPanel)
        Me.SubPanel.Controls.Add(Me.MoviesPanel)
        Me.SubPanel.Controls.Add(Me.SeatsPanel)
        Me.SubPanel.Controls.Add(Me.SettingsPanel)
        Me.BrandAnimator.SetDecoration(Me.SubPanel, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.SubPanel, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.SubPanel, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.SubPanel, BunifuAnimatorNS.DecorationType.None)
        Me.SubPanel.Location = New System.Drawing.Point(951, 136)
        Me.SubPanel.Name = "SubPanel"
        Me.SubPanel.Size = New System.Drawing.Size(213, 408)
        Me.SubPanel.TabIndex = 21
        '
        'main
        '
        Me.main.Controls.Add(Me.Label4)
        Me.main.Controls.Add(Me.Label5)
        Me.main.Controls.Add(Me.BunifuCustomLabel3)
        Me.main.Controls.Add(Me.Label3)
        Me.main.Controls.Add(Me.Label2)
        Me.main.Controls.Add(Me.Label1)
        Me.main.Controls.Add(Me.SubPanel)
        Me.main.Controls.Add(Me.BunifuCircleProgressbar1)
        Me.main.Controls.Add(Me.BunifuCustomLabel1)
        Me.BrandAnimator.SetDecoration(Me.main, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.main, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.main, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.main, BunifuAnimatorNS.DecorationType.None)
        Me.main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.main.Location = New System.Drawing.Point(0, 0)
        Me.main.Name = "main"
        Me.main.Size = New System.Drawing.Size(945, 568)
        Me.main.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.VertAnimator.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.BrandAnimator.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.Label5, BunifuAnimatorNS.DecorationType.None)
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(828, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 16)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.VertAnimator.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.BrandAnimator.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.Label3, BunifuAnimatorNS.DecorationType.None)
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(798, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "9/09/2017"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.VertAnimator.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.BrandAnimator.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.Label2, BunifuAnimatorNS.DecorationType.None)
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(802, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Monday"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.VertAnimator.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.BrandAnimator.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me.Label1, BunifuAnimatorNS.DecorationType.None)
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(811, 115)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 21)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "12:00"
        '
        'BunifuCircleProgressbar1
        '
        Me.BunifuCircleProgressbar1.animated = True
        Me.BunifuCircleProgressbar1.animationIterval = 1
        Me.BunifuCircleProgressbar1.animationSpeed = 1
        Me.BunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCircleProgressbar1.BackgroundImage = CType(resources.GetObject("BunifuCircleProgressbar1.BackgroundImage"), System.Drawing.Image)
        Me.BrandAnimator.SetDecoration(Me.BunifuCircleProgressbar1, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me.BunifuCircleProgressbar1, BunifuAnimatorNS.DecorationType.BottomMirror)
        Me.LogoAnimator.SetDecoration(Me.BunifuCircleProgressbar1, BunifuAnimatorNS.DecorationType.None)
        Me.VertAnimator.SetDecoration(Me.BunifuCircleProgressbar1, BunifuAnimatorNS.DecorationType.None)
        Me.BunifuCircleProgressbar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!)
        Me.BunifuCircleProgressbar1.ForeColor = System.Drawing.Color.White
        Me.BunifuCircleProgressbar1.LabelVisible = False
        Me.BunifuCircleProgressbar1.LineProgressThickness = 15
        Me.BunifuCircleProgressbar1.LineThickness = 8
        Me.BunifuCircleProgressbar1.Location = New System.Drawing.Point(763, 71)
        Me.BunifuCircleProgressbar1.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.BunifuCircleProgressbar1.MaxValue = 60
        Me.BunifuCircleProgressbar1.Name = "BunifuCircleProgressbar1"
        Me.BunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro
        Me.BunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.BunifuCircleProgressbar1.Size = New System.Drawing.Size(144, 144)
        Me.BunifuCircleProgressbar1.TabIndex = 22
        Me.BunifuCircleProgressbar1.Value = 0
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.header
        Me.BunifuDragControl1.Vertical = True
        '
        'PanelAnimator
        '
        Me.PanelAnimator.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide
        Me.PanelAnimator.Cursor = Nothing
        Animation10.AnimateOnlyDifferences = True
        Animation10.BlindCoeff = CType(resources.GetObject("Animation10.BlindCoeff"), System.Drawing.PointF)
        Animation10.LeafCoeff = 0.0!
        Animation10.MaxTime = 1.0!
        Animation10.MinTime = 0.0!
        Animation10.MosaicCoeff = CType(resources.GetObject("Animation10.MosaicCoeff"), System.Drawing.PointF)
        Animation10.MosaicShift = CType(resources.GetObject("Animation10.MosaicShift"), System.Drawing.PointF)
        Animation10.MosaicSize = 0
        Animation10.Padding = New System.Windows.Forms.Padding(0)
        Animation10.RotateCoeff = 0.0!
        Animation10.RotateLimit = 0.0!
        Animation10.ScaleCoeff = CType(resources.GetObject("Animation10.ScaleCoeff"), System.Drawing.PointF)
        Animation10.SlideCoeff = CType(resources.GetObject("Animation10.SlideCoeff"), System.Drawing.PointF)
        Animation10.TimeCoeff = 0.0!
        Animation10.TransparencyCoeff = 0.0!
        Me.PanelAnimator.DefaultAnimation = Animation10
        Me.PanelAnimator.Interval = 5
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'VertAnimator
        '
        Me.VertAnimator.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide
        Me.VertAnimator.Cursor = Nothing
        Animation12.AnimateOnlyDifferences = True
        Animation12.BlindCoeff = CType(resources.GetObject("Animation12.BlindCoeff"), System.Drawing.PointF)
        Animation12.LeafCoeff = 0.0!
        Animation12.MaxTime = 1.0!
        Animation12.MinTime = 0.0!
        Animation12.MosaicCoeff = CType(resources.GetObject("Animation12.MosaicCoeff"), System.Drawing.PointF)
        Animation12.MosaicShift = CType(resources.GetObject("Animation12.MosaicShift"), System.Drawing.PointF)
        Animation12.MosaicSize = 0
        Animation12.Padding = New System.Windows.Forms.Padding(0)
        Animation12.RotateCoeff = 0.0!
        Animation12.RotateLimit = 0.0!
        Animation12.ScaleCoeff = CType(resources.GetObject("Animation12.ScaleCoeff"), System.Drawing.PointF)
        Animation12.SlideCoeff = CType(resources.GetObject("Animation12.SlideCoeff"), System.Drawing.PointF)
        Animation12.TimeCoeff = 0.0!
        Animation12.TransparencyCoeff = 0.0!
        Me.VertAnimator.DefaultAnimation = Animation12
        '
        'BrandAnimator
        '
        Me.BrandAnimator.AnimationType = BunifuAnimatorNS.AnimationType.Leaf
        Me.BrandAnimator.Cursor = Nothing
        Animation9.AnimateOnlyDifferences = True
        Animation9.BlindCoeff = CType(resources.GetObject("Animation9.BlindCoeff"), System.Drawing.PointF)
        Animation9.LeafCoeff = 1.0!
        Animation9.MaxTime = 1.0!
        Animation9.MinTime = 0.0!
        Animation9.MosaicCoeff = CType(resources.GetObject("Animation9.MosaicCoeff"), System.Drawing.PointF)
        Animation9.MosaicShift = CType(resources.GetObject("Animation9.MosaicShift"), System.Drawing.PointF)
        Animation9.MosaicSize = 0
        Animation9.Padding = New System.Windows.Forms.Padding(0)
        Animation9.RotateCoeff = 0.0!
        Animation9.RotateLimit = 0.0!
        Animation9.ScaleCoeff = CType(resources.GetObject("Animation9.ScaleCoeff"), System.Drawing.PointF)
        Animation9.SlideCoeff = CType(resources.GetObject("Animation9.SlideCoeff"), System.Drawing.PointF)
        Animation9.TimeCoeff = 0.0!
        Animation9.TransparencyCoeff = 0.0!
        Me.BrandAnimator.DefaultAnimation = Animation9
        '
        'Stafffrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(945, 568)
        Me.Controls.Add(Me.SidePanel)
        Me.Controls.Add(Me.header)
        Me.Controls.Add(Me.main)
        Me.VertAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.BrandAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.LogoAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.PanelAnimator.SetDecoration(Me, BunifuAnimatorNS.DecorationType.None)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Stafffrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Adminfrm"
        Me.header.ResumeLayout(False)
        Me.header.PerformLayout()
        CType(Me.BunifuImageButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BunifuImageButton2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SidePanel.ResumeLayout(False)
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SettingsPanel.ResumeLayout(False)
        Me.SeatsPanel.ResumeLayout(False)
        Me.MoviesPanel.ResumeLayout(False)
        Me.CustomersPanel.ResumeLayout(False)
        Me.SubPanel.ResumeLayout(False)
        Me.main.ResumeLayout(False)
        Me.main.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents header As System.Windows.Forms.Panel
    Friend WithEvents SidePanel As System.Windows.Forms.Panel
    Friend WithEvents logo As System.Windows.Forms.PictureBox
    Friend WithEvents btnMenu As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton2 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuImageButton4 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuImageButton3 As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuFlatButton3 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton4 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton7 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton5 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents LogoAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents PanelAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents CustomersPanel As System.Windows.Forms.Panel
    Friend WithEvents BunifuFlatButton26 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton27 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton28 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MoviesPanel As System.Windows.Forms.Panel
    Friend WithEvents BunifuFlatButton23 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton24 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton25 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents SeatsPanel As System.Windows.Forms.Panel
    Friend WithEvents BunifuFlatButton21 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents SettingsPanel As System.Windows.Forms.Panel
    Friend WithEvents BunifuFlatButton14 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton15 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuFlatButton16 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents SubPanel As System.Windows.Forms.Panel
    Friend WithEvents main As System.Windows.Forms.Panel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCircleProgressbar1 As Bunifu.Framework.UI.BunifuCircleProgressbar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents VertAnimator As BunifuAnimatorNS.BunifuTransition
    Friend WithEvents BrandAnimator As BunifuAnimatorNS.BunifuTransition
End Class
