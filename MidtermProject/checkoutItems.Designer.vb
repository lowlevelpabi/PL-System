<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checkoutItems
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        Button2 = New Button()
        Timer1 = New Timer(components)
        DataGridView1 = New DataGridView()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        targetLabel = New Label()
        txtEmail = New TextBox()
        txtContact = New TextBox()
        txtAddress = New TextBox()
        txtName = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        Column1 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        Column6 = New DataGridViewTextBoxColumn()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        Label1.Location = New Point(750, 390)
        Label1.Name = "Label1"
        Label1.Size = New Size(338, 15)
        Label1.TabIndex = 1
        Label1.Text = "Please double check your items before proceeding transaction."
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.FromArgb(CByte(30), CByte(28), CByte(26))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(230), CByte(232), CByte(236))
        Button1.Location = New Point(1280, 383)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 29)
        Button1.TabIndex = 2
        Button1.Text = "Proceed"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(302, 390)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 15)
        Label2.TabIndex = 3
        Label2.Text = "Total Cost : ₱"
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.FromArgb(CByte(30), CByte(28), CByte(26))
        Button2.FlatStyle = FlatStyle.Flat
        Button2.ForeColor = Color.FromArgb(CByte(230), CByte(232), CByte(236))
        Button2.Location = New Point(1156, 383)
        Button2.Name = "Button2"
        Button2.Size = New Size(118, 29)
        Button2.TabIndex = 6
        Button2.Text = "Return to Store"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 300
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.BackgroundColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        DataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Column1, Column3, Column2, Column4, Column5, Column6})
        DataGridView1.Location = New Point(295, 12)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersVisible = False
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DataGridView1.Size = New Size(1103, 315)
        DataGridView1.TabIndex = 34
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(378, 392)
        Label5.Name = "Label5"
        Label5.Size = New Size(41, 15)
        Label5.TabIndex = 37
        Label5.Text = "Label5"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(targetLabel)
        GroupBox1.Controls.Add(txtEmail)
        GroupBox1.Controls.Add(txtContact)
        GroupBox1.Controls.Add(txtAddress)
        GroupBox1.Controls.Add(txtName)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(20, 12)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(260, 400)
        GroupBox1.TabIndex = 38
        GroupBox1.TabStop = False
        ' 
        ' targetLabel
        ' 
        targetLabel.AutoSize = True
        targetLabel.Location = New Point(6, 378)
        targetLabel.Name = "targetLabel"
        targetLabel.Size = New Size(28, 15)
        targetLabel.TabIndex = 48
        targetLabel.Text = "<?>"
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = Color.FromArgb(CByte(36), CByte(34), CByte(35))
        txtEmail.BorderStyle = BorderStyle.FixedSingle
        txtEmail.Font = New Font("Segoe UI Semilight", 10F)
        txtEmail.ForeColor = SystemColors.Control
        txtEmail.Location = New Point(27, 327)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(194, 25)
        txtEmail.TabIndex = 47
        ' 
        ' txtContact
        ' 
        txtContact.BackColor = Color.FromArgb(CByte(36), CByte(34), CByte(35))
        txtContact.BorderStyle = BorderStyle.FixedSingle
        txtContact.Font = New Font("Segoe UI Semilight", 10F)
        txtContact.ForeColor = SystemColors.Control
        txtContact.Location = New Point(27, 250)
        txtContact.Name = "txtContact"
        txtContact.Size = New Size(194, 25)
        txtContact.TabIndex = 46
        ' 
        ' txtAddress
        ' 
        txtAddress.BackColor = Color.FromArgb(CByte(36), CByte(34), CByte(35))
        txtAddress.BorderStyle = BorderStyle.FixedSingle
        txtAddress.Font = New Font("Segoe UI Semilight", 10F)
        txtAddress.ForeColor = SystemColors.Control
        txtAddress.Location = New Point(27, 178)
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(194, 25)
        txtAddress.TabIndex = 45
        ' 
        ' txtName
        ' 
        txtName.BackColor = Color.FromArgb(CByte(36), CByte(34), CByte(35))
        txtName.BorderStyle = BorderStyle.FixedSingle
        txtName.Font = New Font("Segoe UI Semilight", 10F)
        txtName.ForeColor = SystemColors.Control
        txtName.Location = New Point(27, 94)
        txtName.Name = "txtName"
        txtName.Size = New Size(194, 25)
        txtName.TabIndex = 44
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(4, 1)
        Label8.Name = "Label8"
        Label8.Size = New Size(81, 15)
        Label8.TabIndex = 43
        Label8.Text = "Delivery detail"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(27, 294)
        Label7.Name = "Label7"
        Label7.Size = New Size(39, 15)
        Label7.TabIndex = 41
        Label7.Text = "Email:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(27, 218)
        Label6.Name = "Label6"
        Label6.Size = New Size(74, 15)
        Label6.TabIndex = 39
        Label6.Text = "Contact No.:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 60)
        Label4.Name = "Label4"
        Label4.Size = New Size(42, 15)
        Label4.TabIndex = 2
        Label4.Text = "Name:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 141)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 15)
        Label3.TabIndex = 0
        Label3.Text = "Address"
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
        Column3.Width = 300
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Product Code"
        Column2.MinimumWidth = 6
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
        Column6.Width = 217
        ' 
        ' checkoutItems
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        ClientSize = New Size(1436, 429)
        Controls.Add(GroupBox1)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Button2)
        ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "checkoutItems"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Midterm Project : Check out"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents targetLabel As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
