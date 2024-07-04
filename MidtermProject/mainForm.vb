Imports MySqlConnector


Public Class mainForm



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

        AllFunctionsMain.createItem(Me)

    End Sub

    Public Sub button_Click(sender As Object, e As EventArgs)

        AllFunctionsMain.toCart(Me, sender)

    End Sub

    Sub Load_Items()

        AllFunctionsMain.loader(Me)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearchproduct.TextChanged, txtSearchproduct.TextChanged

        AllFunctionsMain.textIdentifier(Me)

    End Sub

    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.MouseClick, btnCheckout.MouseClick

        AllFunctionsMain.checkOut(Me)

    End Sub

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '
        conChecker()

        ' order functttions
        AllFunctionsMain.orderIdExtractor(Me)
        AllFunctionsMain.retrieveOrders(Me)

        ' mybase funcions
        AllFunctionsMain.mainFunction(Me)
        AllFunctionsMain.fetchUserImage(Me)
        AllFunctionsMain.updateImageButton(Me)

        ' cart
        AllFunctionsMain.retrieveCart(Me)


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.MouseClick, btnClear.MouseClick

        AllFunctionsMain.functionTwo(Me)

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.MouseClick, btnDelete.MouseClick

        AllFunctionsMain.functionOne(Me)

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

        AllFunctionsMain.functionThree(Me)

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

        AllFunctionsMain.translated(Me)

    End Sub

    Private Sub lblHover_MouseLeave(sender As Object, e As EventArgs) Handles lblHover.MouseLeave

        AllFunctionsMain.defaultranslate(Me)

    End Sub

    Private Sub lblHover1_MouseEnter(sender As Object, e As EventArgs) Handles lblHover1.MouseEnter

        AllFunctionsMain.translated2(Me)

    End Sub

    Private Sub lblHover1_MouseLeave(sender As Object, e As EventArgs) Handles lblHover1.MouseLeave

        AllFunctionsMain.defaultranslate2(Me)

    End Sub
End Class