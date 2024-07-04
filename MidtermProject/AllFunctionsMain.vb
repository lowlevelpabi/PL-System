Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySqlConnector
Imports Windows.Win32.System


' wag nyo pansinin 'to, hindi 'to importante :) mema lang :)

Public Class AllFunctionsMain

    Public Shared WithEvents button As System.Windows.Forms.Button
    Public Shared WithEvents pan As CustomPanel
    Public Shared WithEvents prdcode As Label
    Public Shared WithEvents prdname As Label
    Public Shared WithEvents prdmodel As Label
    Public Shared WithEvents price As Label
    Public Shared WithEvents stock As Label
    Public Shared WithEvents stock_count As Label
    Public Shared WithEvents spacer As Panel
    Public Shared WithEvents img As PictureBox

    Public Shared Sub createItem(mainForm As mainForm)

        Dim len As Long = dr.GetBytes(0, 0, Nothing, 0, 0)
        Dim array(len) As Byte
        dr.GetBytes(0, 0, array, 0, CInt(len))


        pan = New CustomPanel
        With pan
            .Width = 250
            .Height = 390
            .BackColor = Color.Transparent
            .Tag = dr.Item("prd_code").ToString
            .BorderColor = Color.FromArgb(16, 124, 16)
            .BorderStyle = BorderStyle.None
            .Margin = New Padding(50, 50, 0, 0)
        End With

        img = New PictureBox
        With img
            .Height = 170
            .Width = 170
            .BackgroundImageLayout = ImageLayout.Zoom
            .Dock = DockStyle.Top
            .Tag = dr.Item("prd_code").ToString
        End With

        spacer = New Panel
        With spacer
            .Height = 20
            .Dock = DockStyle.Top
            .Tag = dr.Item("prd_code").ToString
        End With

        prdcode = New Label
        With prdcode
            .ForeColor = Color.Orange
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleCenter
            .Dock = DockStyle.Top
            .Padding = New Padding(0, 0, 0, 5)
            .Margin = New Padding(0, 0, 10, 0)
            .Tag = dr.Item("prd_code").ToString
            .Visible = False
        End With


        prdname = New Label
        With prdname
            .ForeColor = Color.FromArgb(192, 192, 194)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleCenter
            .Dock = DockStyle.Top
            .Padding = New Padding(0, 5, 0, 0)
            .Size = New Size(50, 50)
            .Tag = dr.Item("prd_code").ToString
        End With

        prdmodel = New Label
        With prdmodel
            .ForeColor = Color.FromArgb(192, 192, 194)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleCenter
            .Dock = DockStyle.Top
            .Padding = New Padding(0, 5, 0, 5)
            .Size = New Size(40, 40)
            .Tag = dr.Item("prd_code").ToString
        End With

        price = New Label
        With price
            .ForeColor = Color.FromArgb(192, 192, 194)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.BottomCenter
            .Dock = DockStyle.Top
            .Padding = New Padding(0, 0, 0, 15)
            .Size = New Size(0, 40)
            .Tag = dr.Item("prd_code").ToString
        End With


        stock = New Label
        With stock
            .ForeColor = Color.FromArgb(192, 192, 194)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.BottomCenter
            .Dock = DockStyle.Bottom
            .Padding = New Padding(0, 0, 0, 10)
            .Tag = dr.Item("prd_code").ToString
        End With

        stock_count = New Label
        With stock
            .ForeColor = Color.FromArgb(192, 192, 194)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .Tag = dr.Item("prd_code").ToString
        End With

        button = New System.Windows.Forms.Button
        With button
            .Text = "Add to Cart"
            .BackColor = Color.FromArgb(36, 34, 35)
            .ForeColor = Color.FromArgb(192, 192, 194)
            .Font = New Font("Segoe UI", 8, FontStyle.Bold)
            .TextAlign = ContentAlignment.MiddleCenter
            .Dock = DockStyle.Bottom
            .Padding = New Padding(0, 5, 0, 0)
            .Size = New Size(50, 50)
            .FlatStyle = FlatStyle.Flat
            .FlatAppearance.BorderColor = Color.FromArgb(199, 54, 89)
            .Tag = dr.Item("prd_code").ToString
        End With

        Dim ms As New IO.MemoryStream(array)
        Dim bitmap As New Bitmap(ms)
        img.BackgroundImage = bitmap

        stock_count.Text = dr.Item("prd_stock").ToString
        stock.Text = "Available stock: " + stock_count.Text
        prdcode.Text = "Code : " & dr.Item("prd_code").ToString
        prdname.Text = "Product : " & dr.Item("prd_name").ToString
        prdmodel.Text = "Model : " & dr.Item("prd_model").ToString
        price.Text = "Price : " & dr.Item("prd_price").ToString


        pan.Controls.Add(stock)
        pan.Controls.Add(button)
        pan.Controls.Add(price)
        pan.Controls.Add(prdmodel)
        pan.Controls.Add(prdname)
        pan.Controls.Add(prdcode)
        pan.Controls.Add(img)
        mainForm.FlowLayoutPanel1.Controls.Add(pan)

        AddHandler button.Click, AddressOf mainForm.button_Click

    End Sub

    Public Shared Sub toCart(mainForm As mainForm, sender As Object)

        If Not String.IsNullOrEmpty(mainForm.unSession) Then

            conn.Open()

            Try

                cmd = New MySqlCommand("SELECT `prd_code`, `prd_name`, `prd_price`, `prd_stock` FROM `products` WHERE `prd_code` LIKE @prd_code", conn)

                cmd.Parameters.AddWithValue("@prd_code", sender.tag.ToString & "%")

                dr = cmd.ExecuteReader

                While dr.Read

                    Dim stockCount As Integer = Convert.ToInt32(dr("prd_stock"))

                    mainForm.Label30.ForeColor = Color.Green

                    mainForm.Label30.Text = dr.Item("prd_name") + " is successfully added!"

                    If stockCount > 0 Then

                        Dim price As Decimal = dr("prd_price")

                        Dim productCode As String = dr("prd_code")

                        Dim productName As String = dr("prd_name")

                        Dim rowExists As Boolean = False


                        For Each row As DataGridViewRow In mainForm.DataGridView1.Rows

                            If row.Cells("Column2").Value.ToString() = productCode Then

                                Dim currentQty As Integer = Convert.ToInt32(row.Cells("Column5").Value)

                                currentQty += 1

                                row.Cells("Column5").Value = currentQty

                                row.Cells("Column6").Value = price * currentQty

                                rowExists = True

                                Exit For

                            End If

                        Next

                        If Not rowExists Then

                            Dim newRow As DataGridViewRow = New DataGridViewRow()

                            newRow.CreateCells(mainForm.DataGridView1)

                            newRow.SetValues(mainForm.DataGridView1.Rows.Count + 1, productName, productCode, price, 1, price)

                            mainForm.DataGridView1.Rows.Add(newRow)

                        End If

                    Else

                        MsgBox("This product is out of stock", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)


                    End If

                End While

            Catch ex As MySqlException

                MsgBox("Server is offline: " & ex.Message)

            Finally

                dr.Dispose()

                conn.Close()

            End Try

        Else

            accountOption.ShowDialog()

        End If

    End Sub

    Public Shared Sub mainFunction(mainForm As mainForm)


        ' - controls behavior if unSession is blank and isLoginSession is false

        Dim overrider As String

        If mainForm.unSession = String.Empty Then

            overrider = "<no_user>"

        End If

        If mainForm.unSession = String.Empty And mainForm.isLoginSession = False Then

            mainForm.RoundedPictureBox1.Visible = False

            mainForm.btnHistory.Visible = False

            mainForm.Text = "Midterm Project : Main | no user is active | : " & overrider

            mainForm.Label1.Visible = True

            mainForm.panelLogin.Visible = True

            mainForm.lblHover1.Text = "Jika Anda tidak membeli, Anda jelek. Ya."

        Else

            mainForm.Text = "Midterm Project : Main | Signed-in as: " & mainForm.unSession

            mainForm.btnHistory.Visible = True

            mainForm.Label1.Visible = False

            mainForm.panelLogin.Visible = False

            mainForm.txtSign.Text = mainForm.unSession

            mainForm.lblHover1.Text = "Jika Anda tidak membeli " & mainForm.unSession & ", Anda jelek. Ya."
        End If


        ' - ...





        ' - prerequisite for fetching and populating products :p

        dikoalamto()

        mainForm.Load_Items()

        ' - ...



        ' - groupbox color

        mainForm.GroupBox3.ForeColor = Color.FromArgb(192, 192, 194)

        ' - ...



        ' - extras

        mainForm.DataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(192, 192, 194)

        mainForm.DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(37, 34, 35)

        mainForm.DataGridView2.DefaultCellStyle.ForeColor = Color.FromArgb(192, 192, 194)

        mainForm.DataGridView2.DefaultCellStyle.BackColor = Color.FromArgb(37, 34, 35)

        mainForm.ToolTip1.SetToolTip(mainForm.btnHome, "Home")

        mainForm.ToolTip1.SetToolTip(mainForm.btnStore, "Store")

        mainForm.ToolTip1.SetToolTip(mainForm.btnAbout, "Abut us")

        mainForm.ToolTip1.SetToolTip(mainForm.btnSettings, "Settings")

        ' - ...

    End Sub

    Public Shared Sub defaultranslate(mainForm As mainForm)

        mainForm.lblHover.Text = "Sepertinya Anda belum masuk? (Hover to translate)"

    End Sub

    Public Shared Sub translated(mainForm As mainForm)

        mainForm.lblHover.Text = "Looks like you're not signed-in yet?"

    End Sub

    Public Shared Sub defaultranslate2(mainForm As mainForm)

        mainForm.lblHover1.Text = "Jika Anda tidak membeli " & mainForm.unSession & ", Anda jelek. Ya."

    End Sub

    Public Shared Sub translated2(mainForm As mainForm)

        mainForm.lblHover1.Text = "If you don't buy " & mainForm.unSession & ", you are ugly. Yes."

    End Sub

    Public Shared Sub fetchUserImage(mainForm As mainForm)

        Dim checkoutFuck As New checkoutItems()

        ' - fetch id and user image

        mainForm.connection.Open()

        Dim dt As New DataSet

        Try

            Dim username As String = Form1.txtUsername.Text

            Dim sql As String = "SELECT * FROM altertable WHERE username='" & username & "'"

            Dim da As New MySqlDataAdapter(sql, mainForm.connection)

            da.Fill(dt, "altertable")

            mainForm.myID.DataBindings.Add("text", dt, "altertable.id")


            Dim cmd As New MySqlCommand("SELECT * FROM altertable WHERE username='" & username & "'", mainForm.connection)

            Dim dr As MySqlDataReader

            dr = cmd.ExecuteReader()

            If dr.Read() Then

                Dim imagebytes As Byte() = CType(dr("usr_prf"), Byte())

                Using ms As New IO.MemoryStream(imagebytes)

                    mainForm.RoundedPictureBox1.Image = Image.FromStream(ms)

                    mainForm.RoundedPictureBox1.SizeMode = PictureBoxSizeMode.Zoom

                End Using

            End If

            mainForm.connection.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        ' - ...

    End Sub
    Public Shared Sub updateImageButton(mainForm As mainForm)

        If mainForm.RoundedPictureBox3.Image Is Nothing Then

            mainForm.btnPicture.Enabled = False

        End If

    End Sub

    Public Shared Sub loader(mainForm As mainForm)

        mainForm.FlowLayoutPanel1.Controls.Clear()

        mainForm.FlowLayoutPanel1.AutoScroll = True

        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT `prd_img`, `prd_code`, `prd_name`, `prd_model`, `prd_price`, `prd_stock` FROM `products`", conn)

            dr = cmd.ExecuteReader

            While dr.Read

                mainForm.Load_Controls()

            End While

        Catch ex As MySqlException

            MsgBox("Server is offline")

        End Try

        conn.Close()


    End Sub

    Public Shared Sub functionOne(mainForm As mainForm)


        If mainForm.DataGridView1.Rows.Count = 0 Then

            mainForm.Label4.Text = "Cart is empty, no item can delete."
            mainForm.Label4.ForeColor = Color.Yellow

        Else


            Dim selectedRow As DataGridViewRow

            For Each selectedRow In mainForm.DataGridView1.SelectedRows  ' Assuming DataGridView1 is your DataGrid

                Dim response As Integer
                Dim itemName As String = selectedRow.Cells(1).Value ' Assuming item name is in first column (index 0)

                response = MsgBox("Are you sure you want to remove " & itemName & "?", MsgBoxStyle.Information + vbYesNo)

                If response = vbYes Then
                    mainForm.DataGridView1.Rows.Remove(selectedRow)  ' Remove the selected row
                    mainForm.Label4.ForeColor = Color.Green
                    mainForm.Label4.Text = "Item " & itemName & " removed."

                End If

            Next
            mainForm.DataGridView1.Refresh()
        End If
    End Sub

    Public Shared Sub functionTwo(mainForm As mainForm)

        If mainForm.DataGridView1.Rows.Count = 0 Then

            mainForm.Label4.Text = "Can't clear cart, no item found."
            mainForm.Label4.ForeColor = Color.Yellow

        Else

            Dim response As String

            response = MsgBox("Are you sure you want to clear your cart?", MsgBoxStyle.Question + vbYesNo, "Clear cart")

            If response = vbYes Then

                mainForm.DataGridView1.Rows.Clear()

                mainForm.Label4.Text = "Item(s) cleared"
                mainForm.Label4.ForeColor = Color.Green

            End If

        End If

    End Sub

    Public Shared Sub checkOut(mainForm As mainForm)

        Dim targetForm As New checkoutItems()

        If mainForm.DataGridView1.Rows.Count = 0 Then


            mainForm.Label4.Text = "Get something else to the store and cart it before you proceed."
            mainForm.Label4.ForeColor = Color.Yellow

        Else

            targetForm.DataGridView1.Rows.Clear()


            For Each row As DataGridViewRow In mainForm.DataGridView1.Rows

                If Not row.IsNewRow Then

                    Dim clonedRow As DataGridViewRow = CType(row.Clone(), DataGridViewRow)


                    For i As Integer = 0 To row.Cells.Count - 1

                        clonedRow.Cells(i).Value = row.Cells(i).Value

                    Next


                    targetForm.DataGridView1.Rows.Add(clonedRow)


                End If


            Next

            targetForm.idIdentifier = mainForm.myID.Text

            targetForm.ShowDialog()

        End If

    End Sub

    Public Shared Sub functionThree(mainForm As mainForm)

        Dim fname As String = mainForm.txtReceiver.Text

        Dim address As String = mainForm.txtAddress.Text

        Dim contact As String = mainForm.txtContact.Text

        Dim email As String = mainForm.txtEmail.Text

        Dim uID As Integer = mainForm.myID.Text


        If mainForm.cbShipping.Checked = 0 Then

            MsgBox("Enable 'Setup shipping address' to update your credential", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Settings")

        Else


            If fname = String.Empty And address = String.Empty And contact = String.Empty And email = String.Empty Then

                MsgBox("Can't confirm. All fields are empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Settings")

            Else

                If fname = String.Empty Then

                    MsgBox("Receiver's name is empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Settings")

                Else

                    If address = String.Empty Then

                        MsgBox("Receiver's address field is empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Settings")

                    Else

                        If contact = String.Empty Then

                            MsgBox("Receiver's contact no. field is empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Settings")

                        Else

                            If email = String.Empty Then

                                MsgBox("Receiver's email address field is empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Settings")

                            Else

                                Dim update_command As New MySqlCommand("UPDATE `altertable` SET `firstname`=@fname, `address`=@address, `contact`=@ucontact, `email`=@uemail WHERE `id`=@uID", mainForm.connection)

                                update_command.Parameters.Add("@uID", MySqlDbType.Int32).Value = uID

                                update_command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname

                                update_command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address

                                update_command.Parameters.Add("@ucontact", MySqlDbType.VarChar).Value = contact

                                update_command.Parameters.Add("@uemail", MySqlDbType.VarChar).Value = email

                                If mainForm.subconnection(update_command) Then

                                    MsgBox("Shipping address information updated successfully!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

                                End If

                            End If

                        End If

                    End If

                End If

            End If

        End If

    End Sub

    Public Shared Sub textIdentifier(mainForm As mainForm)

        mainForm.FlowLayoutPanel1.Controls.Clear()

        mainForm.FlowLayoutPanel1.AutoScroll = True

        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT prd_img, prd_code, prd_name, prd_model, prd_price, prd_stock FROM products WHERE prd_name LIKE '%" & mainForm.txtSearchproduct.Text & "%' or prd_model LIKE '%" & mainForm.txtSearchproduct.Text & "%'", conn)

            dr = cmd.ExecuteReader

            While dr.Read

                mainForm.Load_Controls()

            End While

        Catch ex As MySqlException

            MessageBox.Show("Error: Server is offline", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        conn.Close()

    End Sub

    Public Shared Sub orderIdExtractor(mainForm As mainForm)

        Dim cs As String = "Server=localhost;Port=3306;Database=alterdb;Uid=root;Pwd=;"

        Dim query As String = "SELECT id FROM altertable WHERE username=@username"

        Dim username As String = mainForm.unSession

        Try


            Using con As New MySqlConnection(cs)
                con.Open()

                Using cmd As New MySqlCommand(query, con)

                    cmd.Parameters.AddWithValue("@username", username)


                    Using rdr As MySqlDataReader = cmd.ExecuteReader()

                        If rdr.Read() Then

                            mainForm.orderIdByUser = rdr("id")

                            mainForm.cartIdByUser = rdr("id")

                            checkoutItems.orderIdByUser = rdr("id")

                        End If

                    End Using

                End Using

            End Using

        Catch ex As MySqlException

            MsgBox("Server is offline, can't retrieve id.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "No connection")

            End

        End Try

    End Sub

    Public Shared Sub retrieveOrders(mainForm As mainForm)


        Dim cs As String = "Server=localhost;Port=3306;Database=alterdb;Uid=root;Pwd=;"

        Dim baseid As Integer = mainForm.orderIdByUser

        Try

            Dim con As New MySqlConnection(cs)

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


    ' DI PA TAPOS TANGINA :))
    Public Shared Sub retrieveCart(mainForm As mainForm)

        mainForm.DataGridView1.Rows.Clear()

        Dim cs As String = "Server=localhost;Port=3306;database=alterdb;uid=root;pwd=;"

        Dim baseid1 As Integer = mainForm.cartIdByUser

        Try
            Dim con As New MySqlConnection(cs)
            con.Open()

            Dim cmd As New MySqlCommand("SELECT cart.cart_id, cart.item_code, cart.item_name, cart.item_price, cart.item_qty, cart.item_subt FROM altertable AS users JOIN table_cart AS cart ON users.id = cart.id WHERE cart.id LIKE @baseid1;", con)
            cmd.Parameters.AddWithValue("@baseid1", baseid1)

            Dim rdr As MySqlDataReader = cmd.ExecuteReader()

            While rdr.Read()

                Dim itemcode As Integer = rdr.GetInt32(1)
                Dim itemName As String = rdr.GetString(2)
                Dim itemPrice As Integer = rdr.GetInt32(3)
                Dim itemQty As Integer = rdr.GetInt32(4)
                Dim itemSubt As Integer = rdr.GetInt32(5)

                mainForm.DataGridView1.Rows.Add(itemcode, itemName, itemPrice, itemQty, itemSubt)
            End While

            con.Close()

        Catch ex As MySqlException
            MessageBox.Show("Error: Server is offline", "Error 1", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub
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
End Class
