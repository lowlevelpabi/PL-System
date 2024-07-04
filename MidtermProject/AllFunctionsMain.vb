Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySqlConnector
Imports Windows.Win32.System


' wag nyo pansinin 'to, hindi 'to importante :) mema lang :)

Public Class AllFunctionsMain

    Public Shared Sub cartIdGenerator(mainForm As mainForm)

        Try

            Dim Num As Integer = 0

            mainForm.con = New MySqlConnection(mainForm.cs)

            mainForm.con.Open()

            Dim sql As String = ("SELECT MAX(cart_id) FROM table_cart")

            cmd = New MySqlCommand(sql)

            cmd.Connection = checkoutItems.con

            If (IsDBNull(cmd.ExecuteScalar)) Then

                Num = 1011

                mainForm.cartIdGenerated = Num.ToString

            Else

                Num = cmd.ExecuteScalar + 1

                mainForm.cartIdGenerated = Num.ToString

            End If

            cmd.Dispose()

            checkoutItems.con.Close()

            checkoutItems.con.Dispose()

        Catch ex As MySqlException

            MessageBox.Show("Error: Server is offline", "Error 2", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

    End Sub

    Public Shared Sub retrieveOrders(mainForm As mainForm)

        Dim baseid As Integer = mainForm.orderIdByUser

        Try

            Dim con As New MySqlConnection(mainForm.cs)

            con.Open()

            Dim cmd As New MySqlCommand("SELECT orders.order_id, orders.item_code, users.username, orders.order_name, orders.order_contact, orders.order_email, orders.item_name, orders.order_date, orders.order_address, orders.item_price, orders.item_qty," &
                                        "orders.item_subt, orders.item_total FROM altertable AS users JOIN alter_orders AS orders ON users.id = orders.id WHERE orders.id Like @baseid;", con)

            cmd.Parameters.AddWithValue("@baseid", baseid)

            Dim rdr As MySqlDataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection)

            mainForm.DataGridView2.Rows.Clear()

            While (rdr.Read() = True)

                mainForm.DataGridView2.Rows.Add(rdr(0), rdr(1), rdr(2), rdr(3), rdr(4), rdr(5), rdr(6), rdr(7), rdr(8), rdr(9), rdr(10), rdr(11), rdr(12))

            End While

            con.Close()

        Catch ex As MySqlException

            MsgBox("Server is offline, can't retrieve orders.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "No connection")

        End Try

    End Sub

    Public Shared Sub updateImageButton(mainForm As mainForm)

        ' - ...
        If mainForm.RoundedPictureBox3.Image Is Nothing Then

            mainForm.btnPicture.Enabled = False

        End If

    End Sub
End Class
