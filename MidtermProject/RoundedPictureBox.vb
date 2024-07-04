Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Public Class RoundedPictureBox
    Inherits PictureBox

    Public Sub New()
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim brushImage As System.Drawing.Brush
        If Me.Image IsNot Nothing Then
            Try
                Dim Imagem As New Bitmap(Me.Image)
                Imagem = New Bitmap(Imagem, New Size(Me.Width - 1, Me.Height - 1))
                brushImage = New TextureBrush(Imagem)
            Catch
                ' Handle any exceptions here if needed
                brushImage = Brushes.Transparent
            End Try
        Else
            ' Handle the case where Image is null
            brushImage = Brushes.Transparent
        End If

        e.Graphics.SmoothingMode = SmoothingMode.HighQuality

        Dim path As New GraphicsPath()

        path.AddEllipse(0, 0, Me.Width - 1, Me.Height - 1)

        e.Graphics.FillPath(brushImage, path)

        e.Graphics.DrawPath(Pens.Transparent, path)

    End Sub
End Class
