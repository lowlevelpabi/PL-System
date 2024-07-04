Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySqlConnector

Public Class form1Functions

    Public Shared Sub submitLogin(Form1 As Form1)

        Dim username = Form1.txtUsername.Text
        Dim password = Form1.txtPassword.Text

        Dim cmd As New MySqlCommand("SELECT `username`, `password`  FROM `altertable` WHERE `username` = @username AND `password` = @pass", Form1.conString.getConnection)

        If Form1.txtUsername.Text = String.Empty And Form1.txtPassword.Text = String.Empty Then

            Form1.Label3.ForeColor = Color.Red

            Form1.Label3.Text = "All fields are empty."

            MsgBox("Please input some credentials", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)


        ElseIf password.Trim = "" Or password.Trim.ToLower = "password" Then

            MsgBox("Password is missing, please input something.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

        Else

            Try

                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username
                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password

                Form1.da.SelectCommand = cmd
                Form1.da.Fill(Form1.dt)
                Form1.da.SelectCommand.CommandTimeout = 750

                If Form1.dt.Rows.Count = 0 Then

                    MsgBox("The username (" + username + "), is not associated to any account registered to the database.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Login Error")

                Else
                    If Form1.dt.Rows.Count > 0 Then

                        Form1.Label3.ForeColor = Color.Green

                        Form1.Label3.Text = "Account found!"

                        MsgBox("Welcome back, " + username, MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

                        Form1.lobby.isLoginSession = True

                        Form1.lobby.unSession = username

                        Form1.lobby.Show()

                        Form1.Close()

                    Else

                        Form1.lobby.isLoginSession = False

                        MsgBox("This username or/and password doesn't exists." + Environment.NewLine + Environment.NewLine + "(con_close)", MsgBoxStyle.Exclamation, "Sign-in error")

                    End If

                End If

            Catch ex As MySqlException

                MsgBox("Connection to localhost server is not established/open. Please check and try again.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Login error - host offline")

            End Try

        End If
    End Sub

    Public Shared Sub usernameKeyEvent(Form1 As Form1, e As KeyEventArgs)

        If e.KeyCode = Keys.Enter Then

            Dim username = Form1.txtUsername.Text
            Dim password = Form1.txtPassword.Text

            Dim cmd As New MySqlCommand("SELECT `username`, `password` FROM `altertable` WHERE `username` = @username AND `password` = @pass", Form1.conString.getConnection)

            If Form1.txtUsername.Text = String.Empty And Form1.txtPassword.Text = String.Empty Then

                Form1.Label3.ForeColor = Color.Red
                Form1.Label3.Text = "All fields are empty."

                MsgBox("Please input some credentials", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)



            ElseIf password.Trim = "" Or password.Trim.ToLower = "password" Then

                MsgBox("Password is missing, please input something.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)


            Else

                Try

                    cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username
                    cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password

                    Form1.da.SelectCommand = cmd
                    Form1.da.Fill(Form1.dt)
                    Form1.da.SelectCommand.CommandTimeout = 750

                    If Form1.dt.Rows.Count = 0 Then

                        MsgBox("The username (" + username + "), is not associated to any account registered to the database.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Login Error")
                    Else
                        If Form1.dt.Rows.Count > 0 Then

                            Form1.Label3.ForeColor = Color.Green

                            Form1.Label3.Text = "Account found!"

                            MsgBox("Welcome back, " + username, MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

                            Form1.lobby.isLoginSession = True

                            Form1.lobby.unSession = username

                            Form1.lobby.Show()

                            Form1.Close()

                        Else

                            Form1.lobby.isLoginSession = False

                            MsgBox("This username or/and password doesn't exists." + Environment.NewLine + Environment.NewLine + "(con_close)", MsgBoxStyle.Exclamation, "Sign-in error")

                        End If

                    End If

                Catch ex As MySqlException

                    MsgBox("Connection to localhost server is not established/open. Please check and try again.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Login error - host offline")

                End Try

            End If

        End If

    End Sub

    Public Shared Sub passwordKeyEvent(Form1 As Form1, e As KeyEventArgs)

        If e.KeyCode = Keys.Enter Then

            Dim username = Form1.txtUsername.Text
            Dim password = Form1.txtPassword.Text

            Dim cmd As New MySqlCommand("SELECT `username`, `password` FROM `altertable` WHERE `username` = @username AND `password` = @pass", Form1.conString.getConnection)

            If Form1.txtUsername.Text = String.Empty And Form1.txtPassword.Text = String.Empty Then

                Form1.Label3.ForeColor = Color.Red
                Form1.Label3.Text = "All fields are empty."

                MsgBox("Please input some credentials", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)



            ElseIf password.Trim = "" Or password.Trim.ToLower = "password" Then

                MsgBox("Password is missing, please input something.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)


            Else

                Try

                    cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = username
                    cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password

                    Form1.da.SelectCommand = cmd
                    Form1.da.Fill(Form1.dt)
                    Form1.da.SelectCommand.CommandTimeout = 750

                    If Form1.dt.Rows.Count = 0 Then

                        MsgBox("The username (" + username + "), is not associated to any account registered to the database.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Login Error")
                    Else
                        If Form1.dt.Rows.Count > 0 Then

                            Form1.Label3.ForeColor = Color.Green

                            Form1.Label3.Text = "Account found!"

                            MsgBox("Welcome back, " + username, MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

                            Form1.lobby.isLoginSession = True

                            Form1.lobby.unSession = username

                            Form1.lobby.Show()

                            Form1.Close()

                        Else

                            Form1.lobby.isLoginSession = False

                            MsgBox("This username or/and password doesn't exists." + Environment.NewLine + Environment.NewLine + "(con_close)", MsgBoxStyle.Exclamation, "Sign-in error")

                        End If

                    End If

                Catch ex As MySqlException

                    MsgBox("Connection to localhost server is not established/open. Please check and try again.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Login error - host offline")

                End Try

            End If

        End If

    End Sub

    Public Shared Sub myBaseLoad(Form1 As Form1)

        Form1.txtUsername.Focus()

    End Sub
End Class
