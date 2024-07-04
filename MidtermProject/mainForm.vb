Imports MySqlConnector


Public Class mainForm

    Public targetForm As New checkoutItems()

    Public isLoginSession As Boolean = False

    Public unSession As String = ""

    Public orderIdByUser As Integer

    Public cartIdByUser As Integer

    Public cartIdGenerated As String

    Public connect As New connectionToHeaven

    Public con As MySqlConnection = Nothing


    Public dt As DataSet

    Public dr As MySqlDataReader


    'Draggable form property
    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point

    Public cs As String = "Server=localhost;Port=3306;Database=alterdb;Uid=root;Pwd=;"

    Public connection As New MySqlConnection("server=localhost;port=;user id=root;password=;database=alterdb")

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


    Function conChecker()

        Dim dbConnection As New connectionToHeaven()

        dbConnection.openConnection()

        Return dbConnection

    End Function

    Function subconnection(cmd As MySqlCommand) As Boolean

        If connection.State = ConnectionState.Closed Then

            connection.Open()

        End If

        Try

            If cmd.ExecuteNonQuery() = 1 Then

                Return True

            Else

                Return False

            End If

        Catch ex As Exception

            MsgBox("An error has occured", MsgBoxStyle.Exclamation & MsgBoxStyle.OkOnly)
            Return False

        End Try

        If connection.State = ConnectionState.Open Then

            connection.Close()

        End If

    End Function

    Function subconnection2(cmd As MySqlCommand) As Boolean

        If connection.State = ConnectionState.Closed Then

            connection.Open()

        End If

        Try

            If cmd.ExecuteNonQuery() = 1 Then

                Return True

            Else

                Return False

            End If

        Catch ex As Exception

            MsgBox("An error has occured", MsgBoxStyle.Exclamation & MsgBoxStyle.OkOnly)
            Return False

        End Try

        If connection.State = ConnectionState.Open Then

            connection.Close()

        End If

    End Function

    Private Sub Panel2_MouseDown(sender As Object, e As MouseEventArgs)

        If e.Button = MouseButtons.Left Then

            MoveForm = True
            Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location

        End If

    End Sub

    Private Sub Panel2_MouseUp(sender As Object, e As MouseEventArgs)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Cursor = Cursors.Default
        End If

    End Sub

    Private Sub Panel2_MouseMove(sender As Object, e As MouseEventArgs)

        If MoveForm Then

            Location = Location + (e.Location - MoveForm_MousePosition)

        End If

    End Sub

    Private Sub Panel4_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel4.MouseDown

        If e.Button = MouseButtons.Left Then

            MoveForm = True
            Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location

        End If

    End Sub

    Private Sub Panel4_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel4.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Cursor = Cursors.Default
        End If

    End Sub

    Private Sub Panel4_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel4.MouseMove

        If MoveForm Then

            Location = Location + (e.Location - MoveForm_MousePosition)

        End If

    End Sub

    Sub Load_Controls()

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
        FlowLayoutPanel1.Controls.Add(pan)

        AddHandler button.Click, AddressOf button_Click

    End Sub

    Public Sub button_Click(sender As Object, e As EventArgs)

        If Not String.IsNullOrEmpty(unSession) Then

            conn.Open()

            Try

                cmd = New MySqlCommand("SELECT `prd_code`, `prd_name`, `prd_price`, `prd_stock` FROM `products` WHERE `prd_code` LIKE @prd_code", conn)

                cmd.Parameters.AddWithValue("@prd_code", sender.tag.ToString & "%")

                dr = cmd.ExecuteReader

                While dr.Read

                    Dim stockCount As Integer = Convert.ToInt32(dr("prd_stock"))

                    Label30.ForeColor = Color.Green

                    Label30.Text = dr.Item("prd_name") + " is successfully added!"

                    If stockCount > 0 Then

                        Dim price As Decimal = dr("prd_price")

                        Dim productCode As String = dr("prd_code")

                        Dim productName As String = dr("prd_name")

                        Dim rowExists As Boolean = False


                        For Each row As DataGridViewRow In DataGridView1.Rows

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

                            newRow.CreateCells(DataGridView1)

                            newRow.SetValues(DataGridView1.Rows.Count + 1, productName, productCode, price, 1, price)

                            DataGridView1.Rows.Add(newRow)

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

    Sub Load_Items()

        FlowLayoutPanel1.Controls.Clear()

        FlowLayoutPanel1.AutoScroll = True

        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT `prd_img`, `prd_code`, `prd_name`, `prd_model`, `prd_price`, `prd_stock` FROM `products`", conn)

            dr = cmd.ExecuteReader

            While dr.Read

                Load_Controls()

            End While

        Catch ex As MySqlException

            MsgBox("Server is offline")

        End Try

        conn.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearchproduct.TextChanged, txtSearchproduct.TextChanged

        FlowLayoutPanel1.Controls.Clear()

        FlowLayoutPanel1.AutoScroll = True

        Try
            conn.Open()

            cmd = New MySqlCommand("SELECT prd_img, prd_code, prd_name, prd_model, prd_price, prd_stock FROM products WHERE prd_name LIKE '%" & txtSearchproduct.Text & "%' or prd_model LIKE '%" & txtSearchproduct.Text & "%'", conn)

            dr = cmd.ExecuteReader

            While dr.Read

                Load_Controls()

            End While

        Catch ex As MySqlException

            MessageBox.Show("Error: Server is offline", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try

        conn.Close()

    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.MouseClick, btnCheckout.MouseClick

        If DataGridView1.Rows.Count = 0 Then


            Label4.Text = "Get something else to the store and cart it before you proceed."
            Label4.ForeColor = Color.Yellow

        Else

            checkoutItems.DataGridView1.Rows.Clear()


            For Each row As DataGridViewRow In DataGridView1.Rows

                If Not row.IsNewRow Then

                    Dim clonedRow As DataGridViewRow = CType(row.Clone(), DataGridViewRow)


                    For i As Integer = 0 To row.Cells.Count - 1

                        clonedRow.Cells(i).Value = row.Cells(i).Value

                    Next


                    checkoutItems.DataGridView1.Rows.Add(clonedRow)


                End If


            Next

            checkoutItems.idIdentifier = myID.Text

            checkoutItems.ShowDialog()

        End If

    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '
        conChecker()

        ' order functttions
        Dim cs As String = "Server=localhost;Port=3306;Database=alterdb;Uid=root;Pwd=;"

        Dim query As String = "SELECT id FROM altertable WHERE username=@username"

        Dim username As String = unSession

        Try


            Using con As New MySqlConnection(cs)
                con.Open()

                Using cmd As New MySqlCommand(query, con)

                    cmd.Parameters.AddWithValue("@username", username)


                    Using rdr As MySqlDataReader = cmd.ExecuteReader()

                        If rdr.Read() Then

                            orderIdByUser = rdr("id")

                            cartIdByUser = rdr("id")

                            checkoutItems.orderIdByUser = rdr("id")

                        End If

                    End Using

                End Using

            End Using

        Catch ex As MySqlException

            MsgBox("Server is offline, can't retrieve id.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "No connection")

            End

        End Try

        ' mybase funcions
        ' - controls behavior if unSession is blank and isLoginSession is false

        Dim overrider As String

        If unSession = String.Empty Then

            overrider = "<no_user>"

        End If

        If unSession = String.Empty And isLoginSession = False Then

            RoundedPictureBox1.Visible = False

            btnHistory.Visible = False

            Text = "Midterm Project : Main | no user is active | : " & overrider

            Label1.Visible = True

            panelLogin.Visible = True

            lblHover1.Text = "Jika Anda tidak membeli, Anda jelek. Ya."

        Else

            Text = "Midterm Project : Main | Signed-in as: " & unSession

            btnHistory.Visible = True

            Label1.Visible = False

            panelLogin.Visible = False

            txtSign.Text = unSession

            lblHover1.Text = "Jika Anda tidak membeli " & unSession & ", Anda jelek. Ya."
        End If


        ' - ...





        ' - prerequisite for fetching and populating products :p

        dikoalamto()

        Load_Items()

        ' - ...



        ' - groupbox color

        GroupBox3.ForeColor = Color.FromArgb(192, 192, 194)

        ' - ...



        ' - extras

        DataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(192, 192, 194)

        DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(37, 34, 35)

        DataGridView2.DefaultCellStyle.ForeColor = Color.FromArgb(192, 192, 194)

        DataGridView2.DefaultCellStyle.BackColor = Color.FromArgb(37, 34, 35)

        ToolTip1.SetToolTip(btnHome, "Home")

        ToolTip1.SetToolTip(btnStore, "Store")

        ToolTip1.SetToolTip(btnAbout, "Abut us")

        ToolTip1.SetToolTip(btnSettings, "Settings")

        ' - ...
        Dim checkoutFuck As New checkoutItems()

        ' - fetch id and user image

        connection.Open()

        Dim dt As New DataSet

        Try

            Dim username1 As String = Form1.txtUsername.Text

            Dim sql As String = "SELECT * FROM altertable WHERE username='" & username1 & "'"

            Dim da As New MySqlDataAdapter(sql, connection)

            da.Fill(dt, "altertable")

            myID.DataBindings.Add("text", dt, "altertable.id")


            Dim cmd As New MySqlCommand("SELECT * FROM altertable WHERE username='" & username1 & "'", connection)

            Dim dr As MySqlDataReader

            dr = cmd.ExecuteReader()

            If dr.Read() Then

                Dim imagebytes As Byte() = CType(dr("usr_prf"), Byte())

                Using ms As New IO.MemoryStream(imagebytes)

                    RoundedPictureBox1.Image = Image.FromStream(ms)

                    RoundedPictureBox1.SizeMode = PictureBoxSizeMode.Zoom

                End Using

            End If

            connection.Close()

        Catch ex As Exception

            MsgBox(ex.Message)

        End Try

        ' cart
        DataGridView1.Rows.Clear()

        Dim baseid1 As Integer = cartIdByUser

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

                DataGridView1.Rows.Add(itemcode, itemName, itemPrice, itemQty, itemSubt)
            End While

            con.Close()

        Catch ex As MySqlException
            MessageBox.Show("Error: Server is offline", "Error 1", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.MouseClick, btnClear.MouseClick

        If DataGridView1.Rows.Count = 0 Then

            Label4.Text = "Can't clear cart, no item found."
            Label4.ForeColor = Color.Yellow

        Else

            Dim response As String

            response = MsgBox("Are you sure you want to clear your cart?", MsgBoxStyle.Question + vbYesNo, "Clear cart")

            If response = vbYes Then

                DataGridView1.Rows.Clear()

                Label4.Text = "Item(s) cleared"
                Label4.ForeColor = Color.Green

            End If

        End If

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.MouseClick, btnDelete.MouseClick

        If DataGridView1.Rows.Count = 0 Then

            Label4.Text = "Cart is empty, no item can delete."
            Label4.ForeColor = Color.Yellow

        Else


            Dim selectedRow As DataGridViewRow

            For Each selectedRow In DataGridView1.SelectedRows  ' Assuming DataGridView1 is your DataGrid

                Dim response As Integer
                Dim itemName As String = selectedRow.Cells(1).Value ' Assuming item name is in first column (index 0)

                response = MsgBox("Are you sure you want to remove " & itemName & "?", MsgBoxStyle.Information + vbYesNo)

                If response = vbYes Then
                    DataGridView1.Rows.Remove(selectedRow)  ' Remove the selected row
                    Label4.ForeColor = Color.Green
                    Label4.Text = "Item " & itemName & " removed."

                End If

            Next
            DataGridView1.Refresh()
        End If

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles btnStore.MouseClick

        navBarCallMain.btn1(Me)

    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btnHome.MouseClick

        navBarCallMain.btn2(Me)

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles btnAbout.MouseClick

        navBarCallMain.btn3(Me)

    End Sub

    Private Sub btnSettings_MouseClick(sender As Object, e As EventArgs) Handles btnSettings.MouseClick

        navBarCallMain.btn5(Me)

    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.MouseClick

        navBarCallMain.btn4(Me)

    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.MouseClick

        navBarCallMain.btn6(Me)

    End Sub
    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click, btnMod.Click

        updateCredMain.tab1(Me)

    End Sub

    Private Sub btnSett_Click(sender As Object, e As EventArgs) Handles btnSett.Click, btnSett.Click

        updateCredMain.tab2(Me)

    End Sub

    Private Sub RoundedPictureBox3_Click(sender As Object, e As EventArgs) Handles RoundedPictureBox3.Click, RoundedPictureBox3.Click

        updateCredMain.pfp(Me)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnPicture.Click, btnPicture.Click

        updateCredMain.submit(Me)

    End Sub

    Private Sub newUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles newUsername.KeyDown

        updateCredMain.update1(Me, e)

    End Sub

    Private Sub newPass_KeyDown(sender As Object, e As KeyEventArgs) Handles newPass.KeyDown, newPass.KeyDown

        updateCredMain.update2(Me, e)

    End Sub

    Private Sub newPass2_KeyDown(sender As Object, e As KeyEventArgs) Handles newPass2.KeyDown, newPass2.KeyDown

        updateCredMain.update2(Me, e)

    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click

    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)

        navBarCallMain.deleteAccount(Me)

    End Sub

    Private Sub RoundedPictureBox1_Click(sender As Object, e As EventArgs) Handles RoundedPictureBox1.Click
        navBarCallMain.revoke2(Me)
    End Sub

    Private Sub btnDeliver_MouseClick(sender As Object, e As MouseEventArgs) Handles btnDeliver.MouseClick, btnDeliver.MouseClick

        Dim fname As String = txtReceiver.Text

        Dim address As String = txtAddress.Text

        Dim contact As String = txtContact.Text

        Dim email As String = txtEmail.Text

        Dim uID As Integer = myID.Text


        If cbShipping.Checked = 0 Then

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

                                Dim update_command As New MySqlCommand("UPDATE `altertable` SET `firstname`=@fname, `address`=@address, `contact`=@ucontact, `email`=@uemail WHERE `id`=@uID", connection)

                                update_command.Parameters.Add("@uID", MySqlDbType.Int32).Value = uID

                                update_command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname

                                update_command.Parameters.Add("@address", MySqlDbType.VarChar).Value = address

                                update_command.Parameters.Add("@ucontact", MySqlDbType.VarChar).Value = contact

                                update_command.Parameters.Add("@uemail", MySqlDbType.VarChar).Value = email

                                If subconnection(update_command) Then

                                    MsgBox("Shipping address information updated successfully!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

                                End If

                            End If

                        End If

                    End If

                End If

            End If

        End If

    End Sub

    Private Sub btnLogin_MouseClick(sender As Object, e As MouseEventArgs) Handles btnLogin.MouseClick, btnLogin.MouseClick

        Form1.Show
        Hide

    End Sub

    Private Sub btnRegister_MouseClick(sender As Object, e As MouseEventArgs) Handles btnRegister.MouseClick, btnRegister.MouseClick

        Form2.Show
        Hide

    End Sub

    Private Sub lblHover_MouseHover(sender As Object, e As EventArgs) Handles lblHover.MouseEnter

        lblHover.Text = "Looks like you're not signed-in yet?"

    End Sub

    Private Sub lblHover_MouseLeave(sender As Object, e As EventArgs) Handles lblHover.MouseLeave

        lblHover.Text = "Sepertinya Anda belum masuk? (Hover to translate)"

    End Sub

    Private Sub lblHover1_MouseEnter(sender As Object, e As EventArgs) Handles lblHover1.MouseEnter

        lblHover1.Text = "If you don't buy " & unSession & ", you are ugly. Yes."

    End Sub

    Private Sub lblHover1_MouseLeave(sender As Object, e As EventArgs) Handles lblHover1.MouseLeave

        lblHover1.Text = "Jika Anda tidak membeli " & unSession & ", Anda jelek. Ya."

    End Sub
End Class