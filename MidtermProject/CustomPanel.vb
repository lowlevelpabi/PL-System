Public Class CustomPanel
    Inherits Panel

    Private _borderColor As Color = Color.FromArgb(140, 151, 66) ' Custom border color
    Private _borderWidth As Integer = 1 ' Adjust border width as needed

    Public Sub New()
        MyBase.New()
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.ResizeRedraw, True)
        Me.BorderStyle = BorderStyle.None ' Ensure standard border is disabled
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)

        ' Draw custom border
        Using pen As New Pen(_borderColor, _borderWidth)
            ' Adjust offset to prevent cut-off edges
            Dim halfWidth As Integer = _borderWidth \ 2
            e.Graphics.DrawRectangle(pen, New Rectangle(halfWidth, halfWidth, Me.Width - _borderWidth, Me.Height - _borderWidth))
        End Using
    End Sub

    Public Property BorderColor As Color
        Get
            Return _borderColor
        End Get
        Set(value As Color)
            _borderColor = value
            Me.Invalidate() ' Redraw panel when border color changes
        End Set
    End Property

    Public Property BorderWidth As Integer
        Get
            Return _borderWidth
        End Get
        Set(value As Integer)
            _borderWidth = value
            Me.Invalidate() ' Redraw panel when border width changes
        End Set
    End Property
End Class
