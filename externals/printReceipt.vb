' sa pinaka-taas to
Imports Systems.Drawing.Printing

' sa baba ng public class your_name_class
Dim ppd as new PrintPreviewDialog()

' function
Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)

    Dim offset As Integer = 15

    Dim itemdesc As String = "Item".PadRight(30)
    Dim Pricedesc As String = "Price".PadRight(8)
    Dim qtydesc As String = "Qty".PadRight(5)
    Dim amtdesc As String = "Sub total"
    Dim descline As String = itemdesc + Pricedesc + qtydesc + amtdesc
    e.Graphics.DrawString(descline, New Font("Courier New", 15, FontStyle.Regular), Brushes.Black, 25, 100 + offset)
    offset += 10
    Dim startx As Integer = 25
    Dim starty As Integer = 150

    Dim font As New Font("Courier New", 15, FontStyle.Regular)
    Dim item As String
    Dim price As String
    Dim qty As String
    Dim amount As String

    Dim productline As String
    For k As Integer = 0 To checkoutItems.DataGridView1.RowCount - 1
        item = checkoutItems.DataGridView1.Rows(k).Cells(2).Value.ToString.PadRight(30)
        price = checkoutItems.DataGridView1.Rows(k).Cells(3).Value.ToString.PadRight(8)
        qty = checkoutItems.DataGridView1.Rows(k).Cells(4).Value.ToString.PadRight(5)
        amount = checkoutItems.DataGridView1.Rows(k).Cells(5).Value.ToString
        productline = item + price + qty + amount
        e.Graphics.DrawString(productline, font, Brushes.Black, startx, starty + offset)
        offset += 35

    Next

    Dim productline1 As Decimal = 0.0

    Dim startx1 As Integer = 25
    Dim starty1 As Integer = 200

    For k As Integer = 0 To checkoutItems.DataGridView1.RowCount - 1

        amount = checkoutItems.DataGridView1.Rows(k).Cells(5).Value.ToString

        productline1 += Convert.ToDecimal(amount)

        offset += 20

    Next

    e.Graphics.DrawString("Total Amount: " & productline1, font, Brushes.Black, startx1, starty1 + offset)

End Sub


' trigger function
Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    ' Create a PrintDocument object
    Dim pd As New PrintDocument()

    ' Add PrintPage event handler
    AddHandler pd.PrintPage, AddressOf PrintPageHandler

    ' Display the print preview dialog
    ppd.Document = pd
    ppd.ShowDialog()

End Sub