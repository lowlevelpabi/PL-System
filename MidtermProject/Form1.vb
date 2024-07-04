Imports MySqlConnector


Public Class Form1

    Public lobby As New mainForm

    Public conString As New connectionToHeaven()
    Public da As New MySqlDataAdapter()
    Public dt As New DataTable()

    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown

        If e.Button = MouseButtons.Left Then

            MoveForm = True
            Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location

        End If

    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Cursor = Cursors.Default
        End If

    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove

        If MoveForm Then

            Location = Location + (e.Location - MoveForm_MousePosition)

        End If

    End Sub


    Public Sub checkUsername(username As String)

        If Not username.Length > 0 Then

            MsgBox("Username is required.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

        Else

            If Not username.Length > 6 Then

                Label3.ForeColor = Color.Red

                Label3.Text = "Username must be more than 6 characters."

            End If

        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtUsername.Focus()

        Label3.Text = String.Empty

        txtUsername.Size = New Size(299, 28)

        txtPassword.Size = New Size(299, 28)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim username = txtUsername.Text
        Dim password = txtPassword.Text

        Dim cmd As New MySqlCommand("SELECT `username`, `password`  FROM `altertable` WHERE `username` = @username AND `password` = @pass", conString.getConnection)

        If txtUsername.Text = String.Empty And txtPassword.Text = String.Empty Then

            Label3.ForeColor = Color.Red

            Label3.Text = "All fields are empty."

            MsgBox("Please input some credentials", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)


        ElseIf password.Trim = "" Or password.Trim.ToLower = "password" Then

            MsgBox("Password is missing, please input something.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

        Else

            Try

                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password

                da.SelectCommand = cmd
                da.Fill(dt)
                da.SelectCommand.CommandTimeout = 750

                If dt.Rows.Count = 0 Then

                    MsgBox("The username (" + username + "), is not associated to any account registered to the database.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Login Error")

                Else
                    If dt.Rows.Count > 0 Then

                        Label3.ForeColor = Color.Green

                        Label3.Text = "Account found!"

                        MsgBox("Welcome back, " + username, MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

                        lobby.isLoginSession = True

                        lobby.unSession = username

                        lobby.Show()

                        Close()

                    Else

                        lobby.isLoginSession = False

                        MsgBox("This username or/and password doesn't exists." + Environment.NewLine + Environment.NewLine + "(con_close)", MsgBoxStyle.Exclamation, "Sign-in error")

                    End If

                End If

            Catch ex As MySqlException

                MsgBox("Connection to localhost server is not established/open. Please check and try again.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Login error - host offline")

            End Try

        End If

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown

        If e.KeyCode = Keys.Enter Then

            Dim username = txtUsername.Text
            Dim password = txtPassword.Text

            Dim cmd As New MySqlCommand("SELECT `username`, `password` FROM `altertable` WHERE `username` = @username AND `password` = @pass", conString.getConnection)

            If txtUsername.Text = String.Empty And txtPassword.Text = String.Empty Then

                Label3.ForeColor = Color.Red
                Label3.Text = "All fields are empty."

                MsgBox("Please input some credentials", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)



            ElseIf password.Trim = "" Or password.Trim.ToLower = "password" Then

                MsgBox("Password is missing, please input something.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)


            Else

                Try

                    cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username
                    cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password

                    da.SelectCommand = cmd
                    da.Fill(dt)
                    da.SelectCommand.CommandTimeout = 750

                    If dt.Rows.Count = 0 Then

                        MsgBox("The username (" + username + "), is not associated to any account registered to the database.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Login Error")
                    Else
                        If dt.Rows.Count > 0 Then

                            Label3.ForeColor = Color.Green

                            Label3.Text = "Account found!"

                            MsgBox("Welcome back, " + username, MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

                            lobby.isLoginSession = True

                            lobby.unSession = username

                            lobby.Show()

                            Close()

                        Else

                            lobby.isLoginSession = False

                            MsgBox("This username or/and password doesn't exists." + Environment.NewLine + Environment.NewLine + "(con_close)", MsgBoxStyle.Exclamation, "Sign-in error")

                        End If

                    End If

                Catch ex As MySqlException

                    MsgBox("Connection to localhost server is not established/open. Please check and try again.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Login error - host offline")

                End Try

            End If

        End If


    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown

        If e.KeyCode = Keys.Enter Then

            Dim username = txtUsername.Text
            Dim password = txtPassword.Text

            Dim cmd As New MySqlCommand("SELECT `username`, `password` FROM `altertable` WHERE `username` = @username AND `password` = @pass", conString.getConnection)

            If txtUsername.Text = String.Empty And txtPassword.Text = String.Empty Then

                Label3.ForeColor = Color.Red
                Label3.Text = "All fields are empty."

                MsgBox("Please input some credentials", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)



            ElseIf password.Trim = "" Or password.Trim.ToLower = "password" Then

                MsgBox("Password is missing, please input something.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)


            Else

                Try

                    cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username
                    cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password

                    da.SelectCommand = cmd
                    da.Fill(dt)
                    da.SelectCommand.CommandTimeout = 750

                    If dt.Rows.Count = 0 Then

                        MsgBox("The username (" + username + "), is not associated to any account registered to the database.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Login Error")
                    Else
                        If dt.Rows.Count > 0 Then

                            Label3.ForeColor = Color.Green

                            Label3.Text = "Account found!"

                            MsgBox("Welcome back, " + username, MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

                            lobby.isLoginSession = True

                            lobby.unSession = username

                            lobby.Show()

                            Close()

                        Else

                            lobby.isLoginSession = False

                            MsgBox("This username or/and password doesn't exists." + Environment.NewLine + Environment.NewLine + "(con_close)", MsgBoxStyle.Exclamation, "Sign-in error")

                        End If

                    End If

                Catch ex As MySqlException

                    MsgBox("Connection to localhost server is not established/open. Please check and try again.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Login error - host offline")

                End Try

            End If

        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.CheckState = 1 Then

            txtPassword.PasswordChar = ""

        Else

            If CheckBox1.CheckState = 0 Then

                txtPassword.PasswordChar = "●"

            End If

        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        mainForm.Show()
        Close()
    End Sub
End Class
