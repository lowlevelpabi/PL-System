<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mainForm))
        Panel3 = New Panel()
        Panel6 = New Panel()
        panelCart = New Panel()
        Label24 = New Label()
        DataGridView1 = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        Label4 = New Label()
        Label3 = New Label()
        btnDelete = New Button()
        btnClear = New Button()
        btnCheckout = New Button()
        panelSettings = New Panel()
        Panel1 = New Panel()
        btnSett = New Button()
        btnMod = New Button()
        Panel5 = New Panel()
        Panel2 = New Panel()
        modPanel = New Panel()
        GroupBox4 = New GroupBox()
        btnDeliver = New BorderlessButton()
        Label29 = New Label()
        txtEmail = New TextBox()
        Label28 = New Label()
        txtContact = New TextBox()
        Label27 = New Label()
        txtAddress = New TextBox()
        Label21 = New Label()
        cbShipping = New CheckBox()
        txtReceiver = New TextBox()
        GroupBox6 = New GroupBox()
        CheckBox2 = New CheckBox()
        Label25 = New Label()
        TextBox2 = New TextBox()
        Label26 = New Label()
        TextBox3 = New TextBox()
        myID = New Label()
        GroupBox3 = New GroupBox()
        btnPicture = New Button()
        RoundedPictureBox3 = New RoundedPictureBox()
        GroupBox1 = New GroupBox()
        cbUsername = New CheckBox()
        Label18 = New Label()
        newUsername = New TextBox()
        GroupBox2 = New GroupBox()
        cbPassword = New CheckBox()
        Label19 = New Label()
        newPass2 = New TextBox()
        Label20 = New Label()
        newPass = New TextBox()
        Label22 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        appPanel = New Panel()
        Label15 = New Label()
        Label14 = New Label()
        panelAbout = New Panel()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label47 = New Label()
        Label48 = New Label()
        Label45 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label54 = New Label()
        Label55 = New Label()
        historyPanel = New Panel()
        Label23 = New Label()
        Label5 = New Label()
        DataGridView2 = New DataGridView()
        Column7 = New DataGridViewTextBoxColumn()
        Column8 = New DataGridViewTextBoxColumn()
        Column9 = New DataGridViewTextBoxColumn()
        Column16 = New DataGridViewTextBoxColumn()
        Column18 = New DataGridViewTextBoxColumn()
        Column19 = New DataGridViewTextBoxColumn()
        Column15 = New DataGridViewTextBoxColumn()
        Column10 = New DataGridViewTextBoxColumn()
        Column17 = New DataGridViewTextBoxColumn()
        Column11 = New DataGridViewTextBoxColumn()
        Column12 = New DataGridViewTextBoxColumn()
        Column13 = New DataGridViewTextBoxColumn()
        Column14 = New DataGridViewTextBoxColumn()
        homePanel = New Panel()
        Label32 = New Label()
        panelLogin = New Panel()
        lblHover = New Label()
        Label13 = New Label()
        Label31 = New Label()
        btnRegister = New BorderlessButton()
        Label1 = New Label()
        btnLogin = New BorderlessButton()
        lblHover1 = New Label()
        Label44 = New Label()
        storePanel = New Panel()
        Label30 = New Label()
        txtSearchproduct = New TextBox()
        Label2 = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Panel4 = New Panel()
        txtSign = New Label()
        btnHistory = New BorderlessButton()
        RoundedPictureBox1 = New RoundedPictureBox()
        btnCart = New BorderlessButton()
        btnStore = New BorderlessButton()
        btnAbout = New BorderlessButton()
        btnSettings = New BorderlessButton()
        btnHome = New BorderlessButton()
        ToolTip1 = New ToolTip(components)
        Panel3.SuspendLayout()
        Panel6.SuspendLayout()
        panelCart.SuspendLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        panelSettings.SuspendLayout()
        Panel1.SuspendLayout()
        Panel5.SuspendLayout()
        Panel2.SuspendLayout()
        modPanel.SuspendLayout()
        GroupBox4.SuspendLayout()
        GroupBox6.SuspendLayout()
        GroupBox3.SuspendLayout()
        CType(RoundedPictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GroupBox2.SuspendLayout()
        appPanel.SuspendLayout()
        panelAbout.SuspendLayout()
        historyPanel.SuspendLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        homePanel.SuspendLayout()
        panelLogin.SuspendLayout()
        storePanel.SuspendLayout()
        Panel4.SuspendLayout()
        CType(RoundedPictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Panel6)
        Panel3.Controls.Add(Panel4)
        Panel3.Dock = DockStyle.Fill
        Panel3.Location = New Point(0, 0)
        Panel3.Margin = New Padding(3, 2, 3, 2)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(1550, 881)
        Panel3.TabIndex = 16
        ' 
        ' Panel6
        ' 
        Panel6.Controls.Add(homePanel)
        Panel6.Controls.Add(storePanel)
        Panel6.Controls.Add(panelCart)
        Panel6.Controls.Add(panelSettings)
        Panel6.Controls.Add(panelAbout)
        Panel6.Controls.Add(historyPanel)
        Panel6.Dock = DockStyle.Fill
        Panel6.Location = New Point(0, 70)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(1550, 811)
        Panel6.TabIndex = 37
        ' 
        ' panelCart
        ' 
        panelCart.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        panelCart.Controls.Add(Label24)
        panelCart.Controls.Add(DataGridView1)
        panelCart.Controls.Add(Label4)
        panelCart.Controls.Add(Label3)
        panelCart.Controls.Add(btnDelete)
        panelCart.Controls.Add(btnClear)
        panelCart.Controls.Add(btnCheckout)
        panelCart.Dock = DockStyle.Fill
        panelCart.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        panelCart.Location = New Point(0, 0)
        panelCart.Margin = New Padding(3, 2, 3, 2)
        panelCart.Name = "panelCart"
        panelCart.Size = New Size(1550, 811)
        panelCart.TabIndex = 16
        ' 
        ' Label24
        ' 
        Label24.AutoSize = True
        Label24.Font = New Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label24.Location = New Point(39, 13)
        Label24.Name = "Label24"
        Label24.Size = New Size(734, 15)
        Label24.TabIndex = 34
        Label24.Text = "Please be advised: Cart record has no database table. All cart item will be cleared out when you sign-out or exit the application. Thank you."
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = SystemColors.Control
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column3, Column2, Column4, Column5, Column6})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        DataGridView1.Location = New Point(38, 37)
        DataGridView1.Margin = New Padding(3, 2, 3, 2)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1471, 641)
        DataGridView1.TabIndex = 33
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "#"
        Column1.MinimumWidth = 6
        Column1.Name = "Column1"
        Column1.ReadOnly = True
        Column1.Visible = False
        Column1.Width = 30
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Product Name"
        Column3.MinimumWidth = 6
        Column3.Name = "Column3"
        Column3.ReadOnly = True
        Column3.Width = 400
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Product Code"
        Column2.Name = "Column2"
        Column2.ReadOnly = True
        Column2.Width = 150
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Price"
        Column4.MinimumWidth = 6
        Column4.Name = "Column4"
        Column4.ReadOnly = True
        Column4.Width = 200
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Quantity Count"
        Column5.MinimumWidth = 6
        Column5.Name = "Column5"
        Column5.ReadOnly = True
        Column5.Width = 200
        ' 
        ' Column6
        ' 
        Column6.HeaderText = "Subtotal per quantity count"
        Column6.MinimumWidth = 6
        Column6.Name = "Column6"
        Column6.ReadOnly = True
        Column6.Width = 200
        ' 
        ' Label4
        ' 
        Label4.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label4.AutoSize = True
        Label4.Location = New Point(92, 768)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label3.AutoSize = True
        Label3.Location = New Point(38, 768)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 15)
        Label3.TabIndex = 4
        Label3.Text = "Status :"
        ' 
        ' btnDelete
        ' 
        btnDelete.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        btnDelete.Location = New Point(1178, 752)
        btnDelete.Margin = New Padding(3, 2, 3, 2)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(106, 31)
        btnDelete.TabIndex = 3
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnClear.FlatStyle = FlatStyle.Flat
        btnClear.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        btnClear.Location = New Point(1290, 752)
        btnClear.Margin = New Padding(3, 2, 3, 2)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(106, 30)
        btnClear.TabIndex = 2
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnCheckout
        ' 
        btnCheckout.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        btnCheckout.FlatStyle = FlatStyle.Flat
        btnCheckout.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        btnCheckout.Location = New Point(1402, 752)
        btnCheckout.Margin = New Padding(3, 2, 3, 2)
        btnCheckout.Name = "btnCheckout"
        btnCheckout.Size = New Size(106, 31)
        btnCheckout.TabIndex = 1
        btnCheckout.Text = "Place order"
        btnCheckout.UseVisualStyleBackColor = True
        ' 
        ' panelSettings
        ' 
        panelSettings.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        panelSettings.Controls.Add(Panel1)
        panelSettings.Controls.Add(Panel5)
        panelSettings.Dock = DockStyle.Fill
        panelSettings.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        panelSettings.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        panelSettings.Location = New Point(0, 0)
        panelSettings.Margin = New Padding(3, 2, 3, 2)
        panelSettings.Name = "panelSettings"
        panelSettings.Size = New Size(1550, 811)
        panelSettings.TabIndex = 36
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(30), CByte(28), CByte(26))
        Panel1.Controls.Add(btnSett)
        Panel1.Controls.Add(btnMod)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Margin = New Padding(3, 2, 3, 2)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1550, 77)
        Panel1.TabIndex = 5
        ' 
        ' btnSett
        ' 
        btnSett.Anchor = AnchorStyles.Left
        btnSett.BackColor = Color.FromArgb(CByte(30), CByte(28), CByte(26))
        btnSett.FlatStyle = FlatStyle.Flat
        btnSett.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold)
        btnSett.ForeColor = Color.FromArgb(CByte(230), CByte(232), CByte(236))
        btnSett.Location = New Point(784, 0)
        btnSett.Margin = New Padding(3, 2, 3, 2)
        btnSett.Name = "btnSett"
        btnSett.Size = New Size(220, 77)
        btnSett.TabIndex = 9
        btnSett.Text = "App setting"
        btnSett.UseVisualStyleBackColor = False
        ' 
        ' btnMod
        ' 
        btnMod.Anchor = AnchorStyles.Left
        btnMod.BackColor = Color.FromArgb(CByte(67), CByte(61), CByte(63))
        btnMod.FlatStyle = FlatStyle.Flat
        btnMod.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMod.ForeColor = Color.FromArgb(CByte(230), CByte(232), CByte(236))
        btnMod.Location = New Point(573, 0)
        btnMod.Margin = New Padding(3, 2, 3, 2)
        btnMod.Name = "btnMod"
        btnMod.Size = New Size(211, 77)
        btnMod.TabIndex = 8
        btnMod.Text = "Modify credentials"
        btnMod.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.Controls.Add(Panel2)
        Panel5.Dock = DockStyle.Fill
        Panel5.Location = New Point(0, 0)
        Panel5.Margin = New Padding(3, 2, 3, 2)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(1550, 811)
        Panel5.TabIndex = 7
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(modPanel)
        Panel2.Controls.Add(appPanel)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(3, 2, 3, 2)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1550, 811)
        Panel2.TabIndex = 6
        ' 
        ' modPanel
        ' 
        modPanel.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        modPanel.Controls.Add(GroupBox4)
        modPanel.Controls.Add(myID)
        modPanel.Controls.Add(GroupBox3)
        modPanel.Controls.Add(Label22)
        modPanel.Controls.Add(Label16)
        modPanel.Controls.Add(Label17)
        modPanel.Dock = DockStyle.Fill
        modPanel.Location = New Point(0, 0)
        modPanel.Margin = New Padding(3, 2, 3, 2)
        modPanel.Name = "modPanel"
        modPanel.Size = New Size(1550, 811)
        modPanel.TabIndex = 5
        ' 
        ' GroupBox4
        ' 
        GroupBox4.Controls.Add(btnDeliver)
        GroupBox4.Controls.Add(Label29)
        GroupBox4.Controls.Add(txtEmail)
        GroupBox4.Controls.Add(Label28)
        GroupBox4.Controls.Add(txtContact)
        GroupBox4.Controls.Add(Label27)
        GroupBox4.Controls.Add(txtAddress)
        GroupBox4.Controls.Add(Label21)
        GroupBox4.Controls.Add(cbShipping)
        GroupBox4.Controls.Add(txtReceiver)
        GroupBox4.Controls.Add(GroupBox6)
        GroupBox4.Location = New Point(53, 481)
        GroupBox4.Margin = New Padding(3, 2, 3, 2)
        GroupBox4.Name = "GroupBox4"
        GroupBox4.Padding = New Padding(3, 2, 3, 2)
        GroupBox4.Size = New Size(589, 284)
        GroupBox4.TabIndex = 16
        GroupBox4.TabStop = False
        ' 
        ' btnDeliver
        ' 
        btnDeliver.BackColor = Color.FromArgb(CByte(30), CByte(29), CByte(29))
        btnDeliver.FlatStyle = FlatStyle.Flat
        btnDeliver.Location = New Point(39, 217)
        btnDeliver.Name = "btnDeliver"
        btnDeliver.Size = New Size(507, 41)
        btnDeliver.TabIndex = 10
        btnDeliver.Text = "Confirm"
        btnDeliver.UseVisualStyleBackColor = False
        ' 
        ' Label29
        ' 
        Label29.AutoSize = True
        Label29.Location = New Point(328, 136)
        Label29.Name = "Label29"
        Label29.Size = New Size(39, 15)
        Label29.TabIndex = 9
        Label29.Text = "Email:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(328, 162)
        txtEmail.Margin = New Padding(3, 2, 3, 2)
        txtEmail.Name = "txtEmail"
        txtEmail.PlaceholderText = "user@email.com"
        txtEmail.Size = New Size(218, 23)
        txtEmail.TabIndex = 8
        ' 
        ' Label28
        ' 
        Label28.AutoSize = True
        Label28.Location = New Point(328, 50)
        Label28.Name = "Label28"
        Label28.Size = New Size(73, 15)
        Label28.TabIndex = 7
        Label28.Text = "Contact No.:"
        ' 
        ' txtContact
        ' 
        txtContact.Location = New Point(328, 76)
        txtContact.Margin = New Padding(3, 2, 3, 2)
        txtContact.Name = "txtContact"
        txtContact.PlaceholderText = "09xxxxxxxxx"
        txtContact.Size = New Size(218, 23)
        txtContact.TabIndex = 6
        ' 
        ' Label27
        ' 
        Label27.AutoSize = True
        Label27.Location = New Point(39, 136)
        Label27.Name = "Label27"
        Label27.Size = New Size(52, 15)
        Label27.TabIndex = 5
        Label27.Text = "Address:"
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(39, 162)
        txtAddress.Margin = New Padding(3, 2, 3, 2)
        txtAddress.Name = "txtAddress"
        txtAddress.PlaceholderText = "01 Location 1, Zone 1"
        txtAddress.Size = New Size(218, 23)
        txtAddress.TabIndex = 4
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Location = New Point(39, 50)
        Label21.Name = "Label21"
        Label21.Size = New Size(117, 15)
        Label21.TabIndex = 1
        Label21.Text = "Receiver: (Full name)"
        ' 
        ' cbShipping
        ' 
        cbShipping.AutoSize = True
        cbShipping.Location = New Point(8, 0)
        cbShipping.Margin = New Padding(3, 2, 3, 2)
        cbShipping.Name = "cbShipping"
        cbShipping.Size = New Size(149, 19)
        cbShipping.TabIndex = 2
        cbShipping.Text = "Setup shipping address"
        cbShipping.UseVisualStyleBackColor = True
        ' 
        ' txtReceiver
        ' 
        txtReceiver.Location = New Point(39, 76)
        txtReceiver.Margin = New Padding(3, 2, 3, 2)
        txtReceiver.Name = "txtReceiver"
        txtReceiver.PlaceholderText = "Juan Dela Cruz"
        txtReceiver.Size = New Size(218, 23)
        txtReceiver.TabIndex = 0
        ' 
        ' GroupBox6
        ' 
        GroupBox6.Anchor = AnchorStyles.Top
        GroupBox6.Controls.Add(CheckBox2)
        GroupBox6.Controls.Add(Label25)
        GroupBox6.Controls.Add(TextBox2)
        GroupBox6.Controls.Add(Label26)
        GroupBox6.Controls.Add(TextBox3)
        GroupBox6.Location = New Point(910, 53)
        GroupBox6.Margin = New Padding(3, 2, 3, 2)
        GroupBox6.Name = "GroupBox6"
        GroupBox6.Padding = New Padding(3, 2, 3, 2)
        GroupBox6.Size = New Size(338, 158)
        GroupBox6.TabIndex = 3
        GroupBox6.TabStop = False
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(0, -1)
        CheckBox2.Margin = New Padding(3, 2, 3, 2)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(119, 19)
        CheckBox2.TabIndex = 6
        CheckBox2.Text = "Change password"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' Label25
        ' 
        Label25.AutoSize = True
        Label25.Location = New Point(29, 86)
        Label25.Name = "Label25"
        Label25.Size = New Size(96, 15)
        Label25.TabIndex = 3
        Label25.Text = "Repeat password"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(29, 112)
        TextBox2.Margin = New Padding(3, 2, 3, 2)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(218, 23)
        TextBox2.TabIndex = 2
        ' 
        ' Label26
        ' 
        Label26.AutoSize = True
        Label26.Location = New Point(29, 31)
        Label26.Name = "Label26"
        Label26.Size = New Size(90, 15)
        Label26.TabIndex = 1
        Label26.Text = "New password :"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(29, 57)
        TextBox3.Margin = New Padding(3, 2, 3, 2)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(218, 23)
        TextBox3.TabIndex = 0
        ' 
        ' myID
        ' 
        myID.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        myID.AutoSize = True
        myID.Location = New Point(118, 783)
        myID.Name = "myID"
        myID.Size = New Size(14, 15)
        myID.TabIndex = 15
        myID.Text = "0"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(btnPicture)
        GroupBox3.Controls.Add(RoundedPictureBox3)
        GroupBox3.Controls.Add(GroupBox1)
        GroupBox3.Controls.Add(GroupBox2)
        GroupBox3.Location = New Point(53, 184)
        GroupBox3.Margin = New Padding(3, 2, 3, 2)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Padding = New Padding(3, 2, 3, 2)
        GroupBox3.Size = New Size(1172, 267)
        GroupBox3.TabIndex = 5
        GroupBox3.TabStop = False
        GroupBox3.Text = "Choose profile"
        ' 
        ' btnPicture
        ' 
        btnPicture.FlatStyle = FlatStyle.Flat
        btnPicture.Location = New Point(109, 192)
        btnPicture.Margin = New Padding(3, 2, 3, 2)
        btnPicture.Name = "btnPicture"
        btnPicture.Size = New Size(82, 22)
        btnPicture.TabIndex = 5
        btnPicture.Text = "Confirm"
        btnPicture.UseVisualStyleBackColor = True
        ' 
        ' RoundedPictureBox3
        ' 
        RoundedPictureBox3.Location = New Point(81, 68)
        RoundedPictureBox3.Margin = New Padding(3, 2, 3, 2)
        RoundedPictureBox3.Name = "RoundedPictureBox3"
        RoundedPictureBox3.Size = New Size(140, 111)
        RoundedPictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        RoundedPictureBox3.TabIndex = 4
        RoundedPictureBox3.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Anchor = AnchorStyles.Top
        GroupBox1.Controls.Add(cbUsername)
        GroupBox1.Controls.Add(Label18)
        GroupBox1.Controls.Add(newUsername)
        GroupBox1.Location = New Point(296, 54)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(338, 158)
        GroupBox1.TabIndex = 2
        GroupBox1.TabStop = False
        ' 
        ' cbUsername
        ' 
        cbUsername.AutoSize = True
        cbUsername.Location = New Point(0, 0)
        cbUsername.Margin = New Padding(3, 2, 3, 2)
        cbUsername.Name = "cbUsername"
        cbUsername.Size = New Size(121, 19)
        cbUsername.TabIndex = 2
        cbUsername.Text = "Change username"
        cbUsername.UseVisualStyleBackColor = True
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Location = New Point(29, 51)
        Label18.Name = "Label18"
        Label18.Size = New Size(92, 15)
        Label18.TabIndex = 1
        Label18.Text = "New username :"
        ' 
        ' newUsername
        ' 
        newUsername.Location = New Point(29, 76)
        newUsername.Margin = New Padding(3, 2, 3, 2)
        newUsername.Name = "newUsername"
        newUsername.Size = New Size(218, 23)
        newUsername.TabIndex = 0
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Anchor = AnchorStyles.Top
        GroupBox2.Controls.Add(cbPassword)
        GroupBox2.Controls.Add(Label19)
        GroupBox2.Controls.Add(newPass2)
        GroupBox2.Controls.Add(Label20)
        GroupBox2.Controls.Add(newPass)
        GroupBox2.Location = New Point(716, 54)
        GroupBox2.Margin = New Padding(3, 2, 3, 2)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(3, 2, 3, 2)
        GroupBox2.Size = New Size(338, 158)
        GroupBox2.TabIndex = 3
        GroupBox2.TabStop = False
        ' 
        ' cbPassword
        ' 
        cbPassword.AutoSize = True
        cbPassword.Location = New Point(0, 0)
        cbPassword.Margin = New Padding(3, 2, 3, 2)
        cbPassword.Name = "cbPassword"
        cbPassword.Size = New Size(119, 19)
        cbPassword.TabIndex = 6
        cbPassword.Text = "Change password"
        cbPassword.UseVisualStyleBackColor = True
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Location = New Point(29, 87)
        Label19.Name = "Label19"
        Label19.Size = New Size(96, 15)
        Label19.TabIndex = 3
        Label19.Text = "Repeat password"
        ' 
        ' newPass2
        ' 
        newPass2.Location = New Point(29, 112)
        newPass2.Margin = New Padding(3, 2, 3, 2)
        newPass2.Name = "newPass2"
        newPass2.Size = New Size(218, 23)
        newPass2.TabIndex = 2
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Location = New Point(29, 32)
        Label20.Name = "Label20"
        Label20.Size = New Size(90, 15)
        Label20.TabIndex = 1
        Label20.Text = "New password :"
        ' 
        ' newPass
        ' 
        newPass.Location = New Point(29, 57)
        newPass.Margin = New Padding(3, 2, 3, 2)
        newPass.Name = "newPass"
        newPass.Size = New Size(218, 23)
        newPass.TabIndex = 0
        ' 
        ' Label22
        ' 
        Label22.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label22.AutoSize = True
        Label22.Location = New Point(25, 783)
        Label22.Name = "Label22"
        Label22.Size = New Size(93, 15)
        Label22.TabIndex = 14
        Label22.Text = "Your fucking id :"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Location = New Point(644, 141)
        Label16.Name = "Label16"
        Label16.Size = New Size(283, 15)
        Label16.TabIndex = 1
        Label16.Text = "Manage your account credentials through this page."
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        Label17.Location = New Point(655, 103)
        Label17.Name = "Label17"
        Label17.Size = New Size(259, 37)
        Label17.TabIndex = 0
        Label17.Text = "Account credentials"
        ' 
        ' appPanel
        ' 
        appPanel.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        appPanel.Controls.Add(Label15)
        appPanel.Controls.Add(Label14)
        appPanel.Dock = DockStyle.Fill
        appPanel.Location = New Point(0, 0)
        appPanel.Margin = New Padding(3, 2, 3, 2)
        appPanel.Name = "appPanel"
        appPanel.Size = New Size(1550, 811)
        appPanel.TabIndex = 6
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Location = New Point(662, 166)
        Label15.Name = "Label15"
        Label15.Size = New Size(271, 15)
        Label15.TabIndex = 1
        Label15.Text = "No available feature for now. Soon to be available."
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(746, 116)
        Label14.Name = "Label14"
        Label14.Size = New Size(96, 21)
        Label14.TabIndex = 0
        Label14.Text = "App setting"
        ' 
        ' panelAbout
        ' 
        panelAbout.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        panelAbout.BackgroundImage = My.Resources.Resources.Untitled_design__11_
        panelAbout.BackgroundImageLayout = ImageLayout.Zoom
        panelAbout.Controls.Add(Label12)
        panelAbout.Controls.Add(Label11)
        panelAbout.Controls.Add(Label10)
        panelAbout.Controls.Add(Label9)
        panelAbout.Controls.Add(Label47)
        panelAbout.Controls.Add(Label48)
        panelAbout.Controls.Add(Label45)
        panelAbout.Controls.Add(Label8)
        panelAbout.Controls.Add(Label7)
        panelAbout.Controls.Add(Label6)
        panelAbout.Controls.Add(Label54)
        panelAbout.Controls.Add(Label55)
        panelAbout.Dock = DockStyle.Fill
        panelAbout.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        panelAbout.Location = New Point(0, 0)
        panelAbout.Margin = New Padding(3, 2, 3, 2)
        panelAbout.Name = "panelAbout"
        panelAbout.Size = New Size(1550, 811)
        panelAbout.TabIndex = 18
        ' 
        ' Label12
        ' 
        Label12.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label12.AutoSize = True
        Label12.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(265, 660)
        Label12.Name = "Label12"
        Label12.Size = New Size(46, 15)
        Label12.TabIndex = 29
        Label12.Text = "MySQL"
        ' 
        ' Label11
        ' 
        Label11.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(244, 631)
        Label11.Name = "Label11"
        Label11.Size = New Size(151, 15)
        Label11.TabIndex = 28
        Label11.Text = "Microsoft Visual Basic .NET"
        ' 
        ' Label10
        ' 
        Label10.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(134, 660)
        Label10.Name = "Label10"
        Label10.Size = New Size(113, 15)
        Label10.TabIndex = 27
        Label10.Text = "Other components :"
        ' 
        ' Label9
        ' 
        Label9.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(134, 631)
        Label9.Name = "Label9"
        Label9.Size = New Size(93, 15)
        Label9.TabIndex = 26
        Label9.Text = "Language used :"
        ' 
        ' Label47
        ' 
        Label47.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label47.AutoSize = True
        Label47.Location = New Point(134, 760)
        Label47.Name = "Label47"
        Label47.Size = New Size(53, 15)
        Label47.TabIndex = 21
        Label47.Text = "BSCS-3A"
        ' 
        ' Label48
        ' 
        Label48.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label48.AutoSize = True
        Label48.Location = New Point(134, 724)
        Label48.Name = "Label48"
        Label48.Size = New Size(72, 15)
        Label48.TabIndex = 22
        Label48.Text = "Reyes, Ryan."
        ' 
        ' Label45
        ' 
        Label45.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label45.AutoSize = True
        Label45.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label45.Location = New Point(134, 693)
        Label45.Name = "Label45"
        Label45.Size = New Size(108, 15)
        Label45.TabIndex = 20
        Label45.Text = "Created by: alterrrrr"
        ' 
        ' Label8
        ' 
        Label8.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        Label8.Location = New Point(118, 584)
        Label8.Name = "Label8"
        Label8.Size = New Size(181, 37)
        Label8.TabIndex = 25
        Label8.Text = "Development"
        ' 
        ' Label7
        ' 
        Label7.Anchor = AnchorStyles.Left
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(134, 342)
        Label7.Name = "Label7"
        Label7.Size = New Size(620, 45)
        Label7.TabIndex = 24
        Label7.Text = resources.GetString("Label7.Text")
        ' 
        ' Label6
        ' 
        Label6.Anchor = AnchorStyles.Left
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        Label6.Location = New Point(118, 301)
        Label6.Name = "Label6"
        Label6.Size = New Size(73, 37)
        Label6.TabIndex = 23
        Label6.Text = "Goal"
        ' 
        ' Label54
        ' 
        Label54.AutoSize = True
        Label54.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label54.Location = New Point(134, 89)
        Label54.Name = "Label54"
        Label54.Size = New Size(625, 30)
        Label54.TabIndex = 13
        Label54.Text = "This software application is created for school project. This project is not for sale, and it is exclusive only to the owner." & vbCrLf & "If you have any concern kindly reach out or contact the creator."
        ' 
        ' Label55
        ' 
        Label55.AutoSize = True
        Label55.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        Label55.Location = New Point(118, 40)
        Label55.Name = "Label55"
        Label55.Size = New Size(93, 37)
        Label55.TabIndex = 12
        Label55.Text = "About"
        ' 
        ' historyPanel
        ' 
        historyPanel.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        historyPanel.BackgroundImageLayout = ImageLayout.Zoom
        historyPanel.Controls.Add(Label23)
        historyPanel.Controls.Add(Label5)
        historyPanel.Controls.Add(DataGridView2)
        historyPanel.Dock = DockStyle.Fill
        historyPanel.Font = New Font("Segoe UI", 8.830189F)
        historyPanel.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        historyPanel.Location = New Point(0, 0)
        historyPanel.Margin = New Padding(3, 2, 3, 2)
        historyPanel.Name = "historyPanel"
        historyPanel.Size = New Size(1550, 811)
        historyPanel.TabIndex = 33
        ' 
        ' Label23
        ' 
        Label23.Anchor = AnchorStyles.Top
        Label23.AutoSize = True
        Label23.Font = New Font("Segoe UI", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(675, 40)
        Label23.Name = "Label23"
        Label23.Size = New Size(222, 19)
        Label23.TabIndex = 2
        Label23.Text = "Review your purchase history here."
        ' 
        ' Label5
        ' 
        Label5.Anchor = AnchorStyles.Top
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI Semibold", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(698, 13)
        Label5.Name = "Label5"
        Label5.Size = New Size(170, 23)
        Label5.TabIndex = 1
        Label5.Text = "PURCHASE HISTORY"
        ' 
        ' DataGridView2
        ' 
        DataGridView2.AllowUserToAddRows = False
        DataGridView2.AllowUserToDeleteRows = False
        DataGridView2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridView2.BackgroundColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        DataGridView2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Columns.AddRange(New DataGridViewColumn() {Column7, Column8, Column9, Column16, Column18, Column19, Column15, Column10, Column17, Column11, Column12, Column13, Column14})
        DataGridView2.Location = New Point(38, 68)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.ReadOnly = True
        DataGridView2.RowHeadersVisible = False
        DataGridView2.RowHeadersWidth = 45
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView2.Size = New Size(1479, 714)
        DataGridView2.TabIndex = 0
        ' 
        ' Column7
        ' 
        Column7.HeaderText = "Order ID"
        Column7.MinimumWidth = 6
        Column7.Name = "Column7"
        Column7.ReadOnly = True
        Column7.Width = 130
        ' 
        ' Column8
        ' 
        Column8.HeaderText = "Item Code"
        Column8.MinimumWidth = 6
        Column8.Name = "Column8"
        Column8.ReadOnly = True
        Column8.Width = 140
        ' 
        ' Column9
        ' 
        Column9.HeaderText = "Order by"
        Column9.MinimumWidth = 6
        Column9.Name = "Column9"
        Column9.ReadOnly = True
        Column9.Width = 110
        ' 
        ' Column16
        ' 
        Column16.HeaderText = "Name"
        Column16.Name = "Column16"
        Column16.ReadOnly = True
        ' 
        ' Column18
        ' 
        Column18.HeaderText = "Contact"
        Column18.Name = "Column18"
        Column18.ReadOnly = True
        ' 
        ' Column19
        ' 
        Column19.HeaderText = "Email"
        Column19.Name = "Column19"
        Column19.ReadOnly = True
        ' 
        ' Column15
        ' 
        Column15.HeaderText = "Item name/model"
        Column15.MinimumWidth = 6
        Column15.Name = "Column15"
        Column15.ReadOnly = True
        Column15.Width = 210
        ' 
        ' Column10
        ' 
        Column10.HeaderText = "Order date"
        Column10.MinimumWidth = 6
        Column10.Name = "Column10"
        Column10.ReadOnly = True
        Column10.Width = 210
        ' 
        ' Column17
        ' 
        Column17.HeaderText = "Address"
        Column17.Name = "Column17"
        Column17.ReadOnly = True
        ' 
        ' Column11
        ' 
        Column11.HeaderText = "Item Price"
        Column11.MinimumWidth = 6
        Column11.Name = "Column11"
        Column11.ReadOnly = True
        Column11.Width = 130
        ' 
        ' Column12
        ' 
        Column12.HeaderText = "Item quantity"
        Column12.MinimumWidth = 6
        Column12.Name = "Column12"
        Column12.ReadOnly = True
        Column12.Width = 130
        ' 
        ' Column13
        ' 
        Column13.HeaderText = "Item sub-total"
        Column13.MinimumWidth = 6
        Column13.Name = "Column13"
        Column13.ReadOnly = True
        Column13.Width = 140
        ' 
        ' Column14
        ' 
        Column14.HeaderText = "Item total"
        Column14.MinimumWidth = 6
        Column14.Name = "Column14"
        Column14.ReadOnly = True
        Column14.Width = 140
        ' 
        ' homePanel
        ' 
        homePanel.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        homePanel.BackgroundImageLayout = ImageLayout.Zoom
        homePanel.Controls.Add(Label32)
        homePanel.Controls.Add(panelLogin)
        homePanel.Controls.Add(lblHover1)
        homePanel.Controls.Add(Label44)
        homePanel.Dock = DockStyle.Fill
        homePanel.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        homePanel.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        homePanel.Location = New Point(0, 0)
        homePanel.Margin = New Padding(3, 2, 3, 2)
        homePanel.Name = "homePanel"
        homePanel.Size = New Size(1550, 811)
        homePanel.TabIndex = 15
        ' 
        ' Label32
        ' 
        Label32.AutoSize = True
        Label32.Font = New Font("Segoe UI", 9.75F)
        Label32.Location = New Point(662, 287)
        Label32.Name = "Label32"
        Label32.Size = New Size(237, 17)
        Label32.TabIndex = 38
        Label32.Text = "(Hover to translate. Unhover to default)"
        ' 
        ' panelLogin
        ' 
        panelLogin.Controls.Add(lblHover)
        panelLogin.Controls.Add(Label13)
        panelLogin.Controls.Add(Label31)
        panelLogin.Controls.Add(btnRegister)
        panelLogin.Controls.Add(Label1)
        panelLogin.Controls.Add(btnLogin)
        panelLogin.Location = New Point(546, 426)
        panelLogin.Name = "panelLogin"
        panelLogin.Size = New Size(496, 176)
        panelLogin.TabIndex = 37
        ' 
        ' lblHover
        ' 
        lblHover.Font = New Font("Segoe UI", 11.25F)
        lblHover.Location = New Point(3, 27)
        lblHover.Name = "lblHover"
        lblHover.Size = New Size(490, 24)
        lblHover.TabIndex = 38
        lblHover.Text = "Sepertinya Anda belum masuk? (Hover to translate)"
        lblHover.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label13
        ' 
        Label13.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label13.AutoSize = True
        Label13.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(305, 143)
        Label13.Name = "Label13"
        Label13.Size = New Size(122, 17)
        Label13.TabIndex = 38
        Label13.Text = "Create new account"
        ' 
        ' Label31
        ' 
        Label31.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label31.AutoSize = True
        Label31.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label31.Location = New Point(117, 143)
        Label31.Name = "Label31"
        Label31.Size = New Size(40, 17)
        Label31.TabIndex = 37
        Label31.Text = "Login"
        ' 
        ' btnRegister
        ' 
        btnRegister.Anchor = AnchorStyles.Top
        btnRegister.BackColor = Color.FromArgb(CByte(13), CByte(127), CByte(205))
        btnRegister.FlatStyle = FlatStyle.Flat
        btnRegister.Image = My.Resources.Resources.icons8_register_351
        btnRegister.Location = New Point(288, 70)
        btnRegister.Margin = New Padding(3, 2, 3, 2)
        btnRegister.Name = "btnRegister"
        btnRegister.Size = New Size(154, 57)
        btnRegister.TabIndex = 36
        btnRegister.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        Label1.Location = New Point(226, 89)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 19)
        Label1.TabIndex = 33
        Label1.Text = "- OR -"
        ' 
        ' btnLogin
        ' 
        btnLogin.Anchor = AnchorStyles.Top
        btnLogin.BackColor = Color.FromArgb(CByte(13), CByte(127), CByte(205))
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Image = My.Resources.Resources.icons8_login_30
        btnLogin.Location = New Point(61, 70)
        btnLogin.Margin = New Padding(3, 2, 3, 2)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(154, 57)
        btnLogin.TabIndex = 35
        btnLogin.UseVisualStyleBackColor = False
        ' 
        ' lblHover1
        ' 
        lblHover1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        lblHover1.Font = New Font("Segoe UI Semibold", 13F, FontStyle.Bold)
        lblHover1.Location = New Point(513, 245)
        lblHover1.Name = "lblHover1"
        lblHover1.Size = New Size(550, 25)
        lblHover1.TabIndex = 32
        lblHover1.Text = "Jika Anda tidak membeli, Anda jelek. Ya."
        lblHover1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label44
        ' 
        Label44.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom
        Label44.AutoSize = True
        Label44.BackColor = Color.Transparent
        Label44.Font = New Font("Segoe UI Semibold", 30F, FontStyle.Bold)
        Label44.ForeColor = SystemColors.Control
        Label44.Location = New Point(622, 166)
        Label44.Name = "Label44"
        Label44.Size = New Size(323, 54)
        Label44.TabIndex = 30
        Label44.Text = "Welcome to MP!"
        ' 
        ' storePanel
        ' 
        storePanel.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        storePanel.Controls.Add(Label30)
        storePanel.Controls.Add(txtSearchproduct)
        storePanel.Controls.Add(Label2)
        storePanel.Controls.Add(FlowLayoutPanel1)
        storePanel.Dock = DockStyle.Fill
        storePanel.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        storePanel.Location = New Point(0, 0)
        storePanel.Margin = New Padding(3, 2, 3, 2)
        storePanel.Name = "storePanel"
        storePanel.Size = New Size(1550, 811)
        storePanel.TabIndex = 14
        ' 
        ' Label30
        ' 
        Label30.AutoSize = True
        Label30.Location = New Point(70, 786)
        Label30.Name = "Label30"
        Label30.Size = New Size(47, 15)
        Label30.TabIndex = 0
        Label30.Text = "Label30"
        ' 
        ' txtSearchproduct
        ' 
        txtSearchproduct.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearchproduct.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        txtSearchproduct.BorderStyle = BorderStyle.FixedSingle
        txtSearchproduct.Font = New Font("Segoe UI", 10.3F)
        txtSearchproduct.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        txtSearchproduct.Location = New Point(25, 20)
        txtSearchproduct.Margin = New Padding(3, 2, 3, 2)
        txtSearchproduct.Multiline = True
        txtSearchproduct.Name = "txtSearchproduct"
        txtSearchproduct.PlaceholderText = "Search for product name or product model"
        txtSearchproduct.Size = New Size(1483, 28)
        txtSearchproduct.TabIndex = 33
        ' 
        ' Label2
        ' 
        Label2.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(25, 776)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 15)
        Label2.TabIndex = 32
        Label2.Text = "Status :"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel1.Location = New Point(6, 59)
        FlowLayoutPanel1.Margin = New Padding(3, 2, 3, 2)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(1532, 697)
        FlowLayoutPanel1.TabIndex = 31
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(47), CByte(43), CByte(44))
        Panel4.Controls.Add(txtSign)
        Panel4.Controls.Add(btnHistory)
        Panel4.Controls.Add(RoundedPictureBox1)
        Panel4.Controls.Add(btnCart)
        Panel4.Controls.Add(btnStore)
        Panel4.Controls.Add(btnAbout)
        Panel4.Controls.Add(btnSettings)
        Panel4.Controls.Add(btnHome)
        Panel4.Dock = DockStyle.Top
        Panel4.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        Panel4.Location = New Point(0, 0)
        Panel4.Margin = New Padding(3, 2, 3, 2)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1550, 70)
        Panel4.TabIndex = 31
        ' 
        ' txtSign
        ' 
        txtSign.AutoSize = True
        txtSign.Location = New Point(164, 28)
        txtSign.Name = "txtSign"
        txtSign.Size = New Size(0, 15)
        txtSign.TabIndex = 38
        ' 
        ' btnHistory
        ' 
        btnHistory.Anchor = AnchorStyles.Top
        btnHistory.BackColor = Color.FromArgb(CByte(47), CByte(43), CByte(44))
        btnHistory.FlatStyle = FlatStyle.Flat
        btnHistory.Image = My.Resources.Resources.icons8_time_machine_30
        btnHistory.Location = New Point(1429, 0)
        btnHistory.Margin = New Padding(3, 2, 3, 2)
        btnHistory.Name = "btnHistory"
        btnHistory.Size = New Size(121, 68)
        btnHistory.TabIndex = 37
        ToolTip1.SetToolTip(btnHistory, "Purchase History")
        btnHistory.UseVisualStyleBackColor = False
        ' 
        ' RoundedPictureBox1
        ' 
        RoundedPictureBox1.Location = New Point(92, 5)
        RoundedPictureBox1.Margin = New Padding(3, 2, 3, 2)
        RoundedPictureBox1.Name = "RoundedPictureBox1"
        RoundedPictureBox1.Size = New Size(64, 60)
        RoundedPictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        RoundedPictureBox1.TabIndex = 34
        RoundedPictureBox1.TabStop = False
        ' 
        ' btnCart
        ' 
        btnCart.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnCart.BackColor = Color.FromArgb(CByte(47), CByte(43), CByte(44))
        btnCart.FlatStyle = FlatStyle.Flat
        btnCart.Image = My.Resources.Resources.icons8_fast_cart_30
        btnCart.Location = New Point(730, 1)
        btnCart.Margin = New Padding(3, 2, 3, 2)
        btnCart.Name = "btnCart"
        btnCart.Size = New Size(121, 68)
        btnCart.TabIndex = 34
        ToolTip1.SetToolTip(btnCart, "My Cart")
        btnCart.UseVisualStyleBackColor = False
        ' 
        ' btnStore
        ' 
        btnStore.Anchor = AnchorStyles.Top
        btnStore.BackColor = Color.FromArgb(CByte(47), CByte(43), CByte(44))
        btnStore.FlatStyle = FlatStyle.Flat
        btnStore.Image = My.Resources.Resources.icons8_bag_301
        btnStore.Location = New Point(609, 1)
        btnStore.Margin = New Padding(3, 2, 3, 2)
        btnStore.Name = "btnStore"
        btnStore.Size = New Size(121, 68)
        btnStore.TabIndex = 34
        btnStore.UseVisualStyleBackColor = False
        ' 
        ' btnAbout
        ' 
        btnAbout.Anchor = AnchorStyles.Top
        btnAbout.BackColor = Color.FromArgb(CByte(47), CByte(43), CByte(44))
        btnAbout.FlatStyle = FlatStyle.Flat
        btnAbout.Image = My.Resources.Resources.icons8_about_30
        btnAbout.Location = New Point(972, 1)
        btnAbout.Margin = New Padding(3, 2, 3, 2)
        btnAbout.Name = "btnAbout"
        btnAbout.Size = New Size(121, 68)
        btnAbout.TabIndex = 35
        btnAbout.UseVisualStyleBackColor = False
        ' 
        ' btnSettings
        ' 
        btnSettings.Anchor = AnchorStyles.Top
        btnSettings.BackColor = Color.FromArgb(CByte(47), CByte(43), CByte(44))
        btnSettings.FlatStyle = FlatStyle.Flat
        btnSettings.Image = My.Resources.Resources.icons8_setting_301
        btnSettings.Location = New Point(851, 1)
        btnSettings.Margin = New Padding(3, 2, 3, 2)
        btnSettings.Name = "btnSettings"
        btnSettings.Size = New Size(121, 68)
        btnSettings.TabIndex = 36
        btnSettings.UseVisualStyleBackColor = False
        ' 
        ' btnHome
        ' 
        btnHome.Anchor = AnchorStyles.Top
        btnHome.BackColor = Color.FromArgb(CByte(199), CByte(54), CByte(89))
        btnHome.FlatStyle = FlatStyle.Flat
        btnHome.Image = My.Resources.Resources.icons8_home_30__2_
        btnHome.Location = New Point(488, 1)
        btnHome.Margin = New Padding(3, 2, 3, 2)
        btnHome.Name = "btnHome"
        btnHome.Size = New Size(121, 68)
        btnHome.TabIndex = 33
        btnHome.UseVisualStyleBackColor = False
        ' 
        ' mainForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1550, 881)
        Controls.Add(Panel3)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "mainForm"
        StartPosition = FormStartPosition.CenterScreen
        Panel3.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        panelCart.ResumeLayout(False)
        panelCart.PerformLayout()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        panelSettings.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel5.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        modPanel.ResumeLayout(False)
        modPanel.PerformLayout()
        GroupBox4.ResumeLayout(False)
        GroupBox4.PerformLayout()
        GroupBox6.ResumeLayout(False)
        GroupBox6.PerformLayout()
        GroupBox3.ResumeLayout(False)
        CType(RoundedPictureBox3, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        appPanel.ResumeLayout(False)
        appPanel.PerformLayout()
        panelAbout.ResumeLayout(False)
        panelAbout.PerformLayout()
        historyPanel.ResumeLayout(False)
        historyPanel.PerformLayout()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        homePanel.ResumeLayout(False)
        homePanel.PerformLayout()
        panelLogin.ResumeLayout(False)
        panelLogin.PerformLayout()
        storePanel.ResumeLayout(False)
        storePanel.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(RoundedPictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button1 As Button
    Friend WithEvents orderIDLabel As Label
    Friend WithEvents panelProfile As Panel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents setupBox As CheckBox
    Friend WithEvents btnHome As BorderlessButton
    Friend WithEvents btnSettings As BorderlessButton
    Friend WithEvents btnAbout As BorderlessButton
    Friend WithEvents btnStore As BorderlessButton
    Friend WithEvents btnCart As BorderlessButton
    Friend WithEvents RoundedPictureBox1 As RoundedPictureBox
    Friend WithEvents btnHistory As BorderlessButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents homePanel As Panel
    Friend WithEvents panelLogin As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents btnRegister As BorderlessButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As BorderlessButton
    Friend WithEvents lblHover1 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents storePanel As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents txtSearchproduct As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents panelCart As Panel
    Friend WithEvents Label24 As Label
    Public WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCheckout As Button
    Friend WithEvents panelSettings As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSett As Button
    Friend WithEvents btnMod As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents modPanel As Panel
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnDeliver As BorderlessButton
    Friend WithEvents Label29 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents cbShipping As CheckBox
    Friend WithEvents txtReceiver As TextBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents Label25 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents myID As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnPicture As Button
    Friend WithEvents RoundedPictureBox3 As RoundedPictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbUsername As CheckBox
    Friend WithEvents Label18 As Label
    Friend WithEvents newUsername As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cbPassword As CheckBox
    Friend WithEvents Label19 As Label
    Friend WithEvents newPass2 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents newPass As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents appPanel As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents historyPanel As Panel
    Friend WithEvents Label23 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents panelAbout As Panel
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lblHover As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents txtSign As Label
End Class
