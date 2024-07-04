<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        txtUsername = New TextBox()
        txtPassword1 = New TextBox()
        Button1 = New Button()
        Label3 = New Label()
        Label4 = New Label()
        txtPassword2 = New TextBox()
        CheckBox1 = New CheckBox()
        Label9 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label8 = New Label()
        PictureBox2 = New PictureBox()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        txtUsername.BorderStyle = BorderStyle.None
        txtUsername.CharacterCasing = CharacterCasing.Lower
        txtUsername.Font = New Font("Segoe UI Semilight", 10F)
        txtUsername.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        txtUsername.Location = New Point(367, 136)
        txtUsername.Name = "txtUsername"
        txtUsername.PlaceholderText = "Create username"
        txtUsername.Size = New Size(262, 18)
        txtUsername.TabIndex = 1
        ' 
        ' txtPassword1
        ' 
        txtPassword1.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        txtPassword1.BorderStyle = BorderStyle.None
        txtPassword1.Font = New Font("Segoe UI Semilight", 10F)
        txtPassword1.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        txtPassword1.Location = New Point(367, 200)
        txtPassword1.Name = "txtPassword1"
        txtPassword1.PasswordChar = "●"c
        txtPassword1.PlaceholderText = "Create password"
        txtPassword1.Size = New Size(262, 18)
        txtPassword1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        Button1.Location = New Point(571, 420)
        Button1.Name = "Button1"
        Button1.Size = New Size(122, 30)
        Button1.TabIndex = 4
        Button1.Text = "Sign-up"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 448)
        Label3.Name = "Label3"
        Label3.Size = New Size(45, 15)
        Label3.TabIndex = 5
        Label3.Text = "Status :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.FromArgb(CByte(30), CByte(29), CByte(29))
        Label4.Location = New Point(62, 448)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 15)
        Label4.TabIndex = 6
        ' 
        ' txtPassword2
        ' 
        txtPassword2.BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        txtPassword2.BorderStyle = BorderStyle.None
        txtPassword2.Font = New Font("Segoe UI Semilight", 10F)
        txtPassword2.ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        txtPassword2.Location = New Point(367, 267)
        txtPassword2.Name = "txtPassword2"
        txtPassword2.PasswordChar = "●"c
        txtPassword2.PlaceholderText = "Confirm password"
        txtPassword2.Size = New Size(198, 18)
        txtPassword2.TabIndex = 9
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(571, 266)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(55, 19)
        CheckBox1.TabIndex = 11
        CheckBox1.Text = "Show"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI Semibold", 20F, FontStyle.Bold)
        Label9.Location = New Point(250, 19)
        Label9.Name = "Label9"
        Label9.Size = New Size(122, 37)
        Label9.TabIndex = 17
        Label9.Text = "SIGN UP"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.FromArgb(CByte(30), CByte(29), CByte(29))
        Label7.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        Label7.Location = New Point(134, 243)
        Label7.Name = "Label7"
        Label7.Size = New Size(69, 20)
        Label7.TabIndex = 21
        Label7.Text = "PROJECT"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.FromArgb(CByte(30), CByte(29), CByte(29))
        Label6.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        Label6.Location = New Point(132, 226)
        Label6.Name = "Label6"
        Label6.Size = New Size(76, 20)
        Label6.TabIndex = 20
        Label6.Text = "MIDTERM"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.FromArgb(CByte(30), CByte(29), CByte(29))
        Label8.Font = New Font("Segoe UI Semibold", 32F, FontStyle.Bold)
        Label8.Location = New Point(48, 214)
        Label8.Name = "Label8"
        Label8.Size = New Size(90, 59)
        Label8.TabIndex = 19
        Label8.Text = "MP"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.FromArgb(CByte(30), CByte(29), CByte(29))
        PictureBox2.Cursor = Cursors.Hand
        PictureBox2.Image = My.Resources.Resources.x_mark_4_24
        PictureBox2.Location = New Point(12, 11)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(21, 17)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 18
        PictureBox2.TabStop = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(37), CByte(34), CByte(35))
        BackgroundImage = My.Resources.Resources.Untitled_design__18_
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(715, 471)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label8)
        Controls.Add(PictureBox2)
        Controls.Add(Label9)
        Controls.Add(CheckBox1)
        Controls.Add(txtPassword2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(txtPassword1)
        Controls.Add(txtUsername)
        DoubleBuffered = True
        ForeColor = Color.FromArgb(CByte(192), CByte(192), CByte(194))
        FormBorderStyle = FormBorderStyle.None
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Basta form 2 to :))"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword2 As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label9 As Label
End Class
