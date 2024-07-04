<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loadPurchase
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
        Timer1 = New Timer(components)
        Button1 = New Button()
        TextBox1 = New TextBox()
        Button2 = New Button()
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 5000
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 106)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 25)
        Button1.TabIndex = 1
        Button1.Text = "Close"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Control
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Enabled = False
        TextBox1.Location = New Point(30, 37)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(243, 18)
        TextBox1.TabIndex = 2
        TextBox1.Text = "Processing, please wait..."
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(159, 106)
        Button2.Name = "Button2"
        Button2.Size = New Size(131, 25)
        Button2.TabIndex = 3
        Button2.Text = "View Receipt"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' loadPurchase
        ' 
        AutoScaleDimensions = New SizeF(7F, 17F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(302, 143)
        Controls.Add(Button2)
        Controls.Add(TextBox1)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.None
        Name = "loadPurchase"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Purchase"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
End Class
