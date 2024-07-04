Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class RotatedPanel
    Inherits Panel

    Private _rotationAngle As Integer

    Public Property RotationAngle As Integer
        Get
            Return _rotationAngle
        End Get
        Set(value As Integer)
            _rotationAngle = value
            Me.Invalidate()  ' Invalidate to trigger a repaint
        End Set
    End Property

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        ' Save the original graphics state
        Dim g As Graphics = e.Graphics
        Dim originalState As GraphicsState = g.Save()

        ' Set the rotation point as the center of the control
        Dim centerX As Single = Me.Width / 2
        Dim centerY As Single = Me.Height / 2

        ' Rotate the graphics around the center point
        g.TranslateTransform(centerX, centerY)
        g.RotateTransform(_rotationAngle)
        g.TranslateTransform(-centerX, -centerY)

        ' Draw the content of the panel
        MyBase.OnPaint(e)

        ' Restore the original graphics state
        g.Restore(originalState)
    End Sub

    Protected Overrides Sub OnPaintBackground(e As PaintEventArgs)
        ' Save the original graphics state
        Dim g As Graphics = e.Graphics
        Dim originalState As GraphicsState = g.Save()

        ' Set the rotation point as the center of the control
        Dim centerX As Single = Me.Width / 2
        Dim centerY As Single = Me.Height / 2

        ' Rotate the graphics around the center point
        g.TranslateTransform(centerX, centerY)
        g.RotateTransform(_rotationAngle)
        g.TranslateTransform(-centerX, -centerY)

        ' Draw the background of the panel
        MyBase.OnPaintBackground(e)

        ' Restore the original graphics state
        g.Restore(originalState)
    End Sub
End Class

