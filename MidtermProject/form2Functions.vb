Imports MySqlConnector
Imports System.Reflection.Emit

Public Class form2Functions

    Public Shared Sub keyEvent1(Form2 As Form2, e As KeyEventArgs)

        If e.KeyCode = Keys.Enter Then

            Dim createUsername As String = Form2.txtUsername.Text
            Dim createPassword As String = Form2.txtPassword1.Text
            Dim crpassword As String = Form2.txtPassword2.Text

            Form2.passwordChecker(Form2.txtPassword1.Text, Form2.txtPassword2.Text)

            Form2.checkCreateUsername(Form2.txtUsername.Text)

            If Form2.txtUsername.Text = String.Empty And Form2.txtPassword1.Text = String.Empty And Form2.txtPassword2.Text = String.Empty Then

                MsgBox("All fields are empty. Please fill up.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                Form2.Label4.ForeColor = Color.Red
                Form2.Label4.Text = "Can't create account, please input something"

            Else

                If Form2.txtUsername.Text = String.Empty Then

                    MsgBox("Username is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                    Form2.Label4.ForeColor = Color.Red
                    Form2.Label4.Text = "Username field required."

                Else


                    If Form2.txtPassword1.Text = String.Empty Then

                        MsgBox("Password field is empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                        Form2.Label4.ForeColor = Color.Red
                        Form2.Label4.Text = "Password required."

                    Else

                        If Form2.txtPassword2.Text = String.Empty Then

                            MsgBox("Repeat password is empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                            Form2.Label4.ForeColor = Color.Red
                            Form2.Label4.Text = "Repeat password required."

                        ElseIf Not String.Equals(createPassword, crpassword) Then

                            MsgBox("Password doesn't match.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                            Form2.Label4.ForeColor = Color.Red
                            Form2.Label4.Text = "Password doesn't match. Please try again."

                        End If



                        If Form2.txtPassword1.TextLength < 8 And Form2.txtPassword2.TextLength < 8 And Form2.txtUsername.TextLength < 8 Then

                            Form2.Label4.ForeColor = Color.Red
                            Form2.Label4.Text = "Password must be 8 character long."

                        Else

                            If Form2.txtPassword1.TextLength < 8 And Form2.txtPassword2.TextLength < 8 And Form2.txtUsername.TextLength < 4 Then

                                Form2.Label4.ForeColor = Color.Red
                                Form2.Label4.Text = "All fields are not 8 character long."

                            Else

                                If Form2.txtPassword1.TextLength < 8 And Form2.txtPassword2.Text < 8 Then

                                    Form2.Label4.ForeColor = Color.Red
                                    Form2.Label4.Text = "Both password is not 8 character long."

                                Else

                                    If Form2.txtUsername.TextLength < 4 Then

                                        Form2.Label4.ForeColor = Color.Red
                                        Form2.Label4.Text = "Username must be 4 character long."

                                    Else

                                        Dim cmd As New MySqlCommand("INSERT INTO `altertable`(`username`, `password`) VALUES (@username, @pass)", Form2.conString.getConnection())

                                        cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = createUsername
                                        cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = createPassword

                                        Form2.conString.openConnection()

                                        If cmd.ExecuteNonQuery() = 1 Then


                                            Form2.Label4.ForeColor = Color.Green
                                            Form2.Label4.Text = Form2.txtUsername.Text + " is registered."
                                            Form2.conString.closeConnection()
                                        Else

                                            Form2.Label4.ForeColor = Color.Red
                                            Form2.Label4.Text = "Something Happen. Error."

                                        End If

                                    End If

                                End If

                            End If

                        End If

                    End If

                End If
            End If

        End If

    End Sub

    Public Shared Sub keyEvent2(Form2 As Form2, e As KeyEventArgs)

        If e.KeyCode = Keys.Enter Then

            Dim createUsername As String = Form2.txtUsername.Text
            Dim createPassword As String = Form2.txtPassword1.Text
            Dim crpassword As String = Form2.txtPassword2.Text

            Form2.passwordChecker(Form2.txtPassword1.Text, Form2.txtPassword2.Text)

            Form2.checkCreateUsername(Form2.txtUsername.Text)

            If Form2.txtUsername.Text = String.Empty And Form2.txtPassword1.Text = String.Empty And Form2.txtPassword2.Text = String.Empty Then

                MsgBox("All fields are empty. Please fill up.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                Form2.Label4.ForeColor = Color.Red
                Form2.Label4.Text = "Can't create account, please input something"

            Else

                If Form2.txtUsername.Text = String.Empty Then

                    MsgBox("Username is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                    Form2.Label4.ForeColor = Color.Red
                    Form2.Label4.Text = "Username field required."

                Else


                    If Form2.txtPassword1.Text = String.Empty Then

                        MsgBox("Password field is empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                        Form2.Label4.ForeColor = Color.Red
                        Form2.Label4.Text = "Password required."

                    Else

                        If Form2.txtPassword2.Text = String.Empty Then

                            MsgBox("Repeat password is empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                            Form2.Label4.ForeColor = Color.Red
                            Form2.Label4.Text = "Repeat password required."

                        ElseIf Not String.Equals(createPassword, crpassword) Then

                            MsgBox("Password doesn't match.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                            Form2.Label4.ForeColor = Color.Red
                            Form2.Label4.Text = "Password doesn't match. Please try again."

                        End If

                        If Form2.txtPassword1.TextLength < 8 And Form2.txtPassword2.TextLength < 8 And Form2.txtUsername.TextLength < 8 Then

                            Form2.Label4.ForeColor = Color.Red
                            Form2.Label4.Text = "Password must be 8 character long."

                        Else

                            If Form2.txtPassword1.TextLength < 8 And Form2.txtPassword2.TextLength < 8 And Form2.txtUsername.TextLength < 4 Then

                                Form2.Label4.ForeColor = Color.Red
                                Form2.Label4.Text = "All fields are not 8 character long."

                            Else

                                If Form2.txtPassword1.TextLength < 8 And Form2.txtPassword2.Text < 8 Then

                                    Form2.Label4.ForeColor = Color.Red
                                    Form2.Label4.Text = "Both password is not 8 character long."

                                Else

                                    If Form2.txtUsername.TextLength < 4 Then

                                        Form2.Label4.ForeColor = Color.Red
                                        Form2.Label4.Text = "Username must be 4 character long."

                                    Else

                                        Dim cmd As New MySqlCommand("INSERT INTO `altertable`(`username`, `password`) VALUES (@username, @pass)", Form2.conString.getConnection())

                                        cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = createUsername
                                        cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = createPassword

                                        Form2.conString.openConnection()

                                        If cmd.ExecuteNonQuery() = 1 Then


                                            Form2.Label4.ForeColor = Color.Green
                                            Form2.Label4.Text = Form2.txtUsername.Text + " is registered."
                                            Form2.conString.closeConnection()

                                        Else

                                            Form2.Label4.ForeColor = Color.Red
                                            Form2.Label4.Text = "Something Happen. Error."

                                        End If

                                    End If

                                End If

                            End If

                        End If

                    End If

                End If

            End If

        End If

    End Sub

    Public Shared Sub submit(Form2 As Form2)

        Dim createUsername As String = Form2.txtUsername.Text
        Dim createPassword As String = Form2.txtPassword1.Text
        Dim crpassword As String = Form2.txtPassword2.Text

        Form2.passwordChecker(Form2.txtPassword1.Text, Form2.txtPassword2.Text)

        Form2.checkCreateUsername(Form2.txtUsername.Text)

        If Form2.txtUsername.Text = String.Empty And Form2.txtPassword1.Text = String.Empty And Form2.txtPassword2.Text = String.Empty Then

            MsgBox("All fields are empty. Please fill up.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Form2.Label4.ForeColor = Color.Red
            Form2.Label4.Text = "Can't create account, please input something"

        Else

            If Form2.txtUsername.Text = String.Empty Then

                MsgBox("Username is missing.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                Form2.Label4.ForeColor = Color.Red
                Form2.Label4.Text = "Username field required."

            Else

                If Form2.txtPassword1.Text = String.Empty Then

                    MsgBox("Password field is empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                    Form2.Label4.ForeColor = Color.Red
                    Form2.Label4.Text = "Password required."

                Else

                    If Form2.txtPassword2.Text = String.Empty Then

                        MsgBox("Repeat password is empty.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                        Form2.Label4.ForeColor = Color.Red
                        Form2.Label4.Text = "Repeat password required."

                    ElseIf Not String.Equals(createPassword, crpassword) Then

                        MsgBox("Password doesn't match.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
                        Form2.Label4.ForeColor = Color.Red
                        Form2.Label4.Text = "Password doesn't match. Please try again."

                    End If

                    If Form2.txtPassword1.TextLength < 8 And Form2.txtPassword2.TextLength < 8 And Form2.txtUsername.TextLength < 4 Then

                        Form2.Label4.ForeColor = Color.Red
                        Form2.Label4.Text = "All fields are not 8 character long."

                    Else

                        If Form2.txtPassword1.TextLength < 8 And Form2.txtPassword2.Text < 8 Then

                            Form2.Label4.ForeColor = Color.Red
                            Form2.Label4.Text = "Both password is not 8 character long."

                        Else

                            If Form2.txtUsername.TextLength < 4 Then

                                Form2.Label4.ForeColor = Color.Red
                                Form2.Label4.Text = "Username must be 4 character long."

                            Else


                                Dim cmd As New MySqlCommand("INSERT INTO `altertable`(`username`, `password`) VALUES (@username, @pass)", Form2.conString.getConnection())

                                cmd.Parameters.Add("@username", MySqlDbType.VarChar).Value = createUsername
                                cmd.Parameters.Add("@pass", MySqlDbType.VarChar).Value = createPassword

                                Form2.conString.openConnection()

                                If cmd.ExecuteNonQuery() = 1 Then


                                    Form2.Label4.ForeColor = Color.Green
                                    Form2.Label4.Text = Form2.txtUsername.Text + " is registered."
                                    Form2.conString.closeConnection()
                                Else

                                    Form2.Label4.ForeColor = Color.Red
                                    Form2.Label4.Text = "Something Happen. Error."

                                End If

                            End If

                        End If

                    End If

                End If

            End If

        End If

    End Sub
End Class
