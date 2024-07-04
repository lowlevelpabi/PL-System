Try

    mainForm.connect.openConnection()

    For Each row As DataGridViewRow In mainForm.DataGridView1.Rows

        If Not row.IsNewRow Then

            Dim cartid As String = mainForm.cartIdGenerated

            Dim itemcode As Integer = Convert.ToInt32(row.Cells("Column2").Value)

            Dim itemname As String = row.Cells("Column3").Value.ToString()

            Dim itemprice As Integer = Convert.ToInt32(row.Cells("Column4").Value)

            Dim itemqty As Integer = Convert.ToInt32(row.Cells("Column5").Value)

            Dim itemsubt As Integer = Convert.ToInt32(row.Cells("Column6").Value)

            Dim cartby As String = mainForm.unSession

            Dim sessionid As Integer = mainForm.cartIdByUser


            Dim cmd As New MySqlCommand("INSERT INTO `table_cart` (`cart_id`, `item_code`, `item_name`, `item_price`, `item_qty`, `item_subt`, `cart_by`, `id`) VALUES (@cartid, @itemcode, @itemname, @itemprice, @itemqty, @itemsubt, @cartby, @sessionid)", mainForm.connect.getConnection())

            cmd.Parameters.Add("@cartid", MySqlDbType.Int32).Value = cartid

            cmd.Parameters.Add("@itemcode", MySqlDbType.Int32).Value = itemcode

            cmd.Parameters.Add("@itemname", MySqlDbType.VarChar).Value = itemname

            cmd.Parameters.Add("@itemprice", MySqlDbType.Int32).Value = itemprice

            cmd.Parameters.Add("@itemqty", MySqlDbType.Int32).Value = itemqty

            cmd.Parameters.Add("@itemsubt", MySqlDbType.Int32).Value = itemsubt

            cmd.Parameters.Add("@cartby", MySqlDbType.Int32).Value = cartby

            cmd.Parameters.Add("@sessionid", MySqlDbType.Int32).Value = sessionid

            cmd.ExecuteNonQuery()

        End If

    Next

Catch ex As MySqlException

    MessageBox.Show("An error occurred: " & ex.Message)

Finally

    mainForm.connect.closeConnection()

End Try