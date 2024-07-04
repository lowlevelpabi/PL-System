Imports System.Drawing.Printing
Imports System.IO
Imports System.Text
Imports System.Transactions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySqlConnector
Public Class checkoutItems

    Public connection As New MySqlConnection("server=localhost;port=;user id=root;password=;database=alterdb")

    Public orderIdByUser As String

    Public generatedID As String

    Public idIdentifier As String

    Public con As MySqlConnection = Nothing

    Public cs As String = "Server=localhost;Port=3306;Database=alterdb;Uid=root;Pwd=;"

    'Draggable form propertys
    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs)

        If e.Button = MouseButtons.Left Then

            MoveForm = True
            Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location

        End If

    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Cursor = Cursors.Default
        End If

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs)

        If MoveForm Then

            Location = Location + (e.Location - MoveForm_MousePosition)

        End If

    End Sub
    Private Sub checkoutItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        checkOutSaver.getShipping(Me)

        checkOutSaver.mainmemory(Me, mainForm)

        checkOutSaver.orderIdGenerator(Me)

        mainForm.Enabled = True

        DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(37, 34, 35)

        DataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(192, 192, 194)

        Dim total As Decimal = 0


        For Each row As DataGridViewRow In DataGridView1.Rows

            If Not row.Cells("Column6").Value Is Nothing AndAlso IsNumeric(row.Cells("Column6").Value) Then

                total += Convert.ToDecimal(row.Cells("Column6").Value)

            End If

        Next

        Label5.Text = total

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim response As String

        Dim address = txtAddress.Text

        Dim name = txtName.Text

        Dim contact = txtContact.Text

        Dim email = txtEmail.Text

        response = MsgBox("Proceed to buy?", MsgBoxStyle.Question + vbYesNo, "Purchase")

        If address = String.Empty And name = String.Empty And contact = String.Empty And email = String.Empty Then

            MsgBox("Please add some details of the buyer.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Check out error")

        Else

            If address = String.Empty Then

                MsgBox("Address is empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Check out error")

            Else

                If name = String.Empty Then

                    MsgBox("Name is empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Check out error")

                Else

                    If contact = String.Empty Then

                        MsgBox("Contact no. is empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Check out error")

                    Else

                        If email = String.Empty Then

                            MsgBox("Email Address is empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Check out error")

                        Else

                            If response = vbYes Then

                                Dim connectionString As String = "server=localhost;port=;user id=root;password=;database=alterdb"

                                Dim connection As MySqlConnection = New MySqlConnection(connectionString)

                                Dim sql As String = "UPDATE products SET prd_stock = prd_stock - @quantity WHERE prd_code = @id"

                                Dim cmd As MySqlCommand = New MySqlCommand(sql, connection)

                                cmd.Parameters.AddWithValue("@id", MySqlDbType.Int32)

                                cmd.Parameters.AddWithValue("@quantity", MySqlDbType.Int32)

                                Try
                                    connection.Open()

                                    For Each row In DataGridView1.Rows

                                        Dim productId As Integer = CInt(row.Cells("Column3").Value)

                                        Dim quantityToDeduct As Integer = CInt(row.Cells("Column5").Value)

                                        cmd.Parameters("@id").Value = productId

                                        cmd.Parameters("@quantity").Value = quantityToDeduct

                                        cmd.ExecuteNonQuery()


                                    Next

                                    checkOutSaver.orderInserter(Me)

                                    loadPurchase.ShowDialog()

                                Catch ex As Exception

                                    MsgBox(ex, " Error")

                                Finally

                                    connection.Close()

                                End Try

                            Else

                                ' ...

                            End If

                        End If

                    End If

                End If

            End If

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.MouseClick

        Dim response As String

        response = MsgBox("Do you want to return in merchant?", MsgBoxStyle.Question + vbYesNo, "Check out")

        If response = vbYes Then

            Close()

        End If

    End Sub

    Private Sub txtContact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContact.KeyPress


        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then

            e.Handled = True

            MsgBox("String input value is not appropriate for contact field.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Invalid Input")

        End If


    End Sub
End Class