Public Class BorderlessButton
    Inherits Button

    Protected Overrides Sub OnPaint(ByVal pe As PaintEventArgs)
        MyBase.OnPaint(pe)
        pe.Graphics.DrawRectangle(New Pen(BackColor, 5), ClientRectangle)
    End Sub

End Class