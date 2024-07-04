Imports System.IO
Imports MySqlConnector

Public Class updateCredMain

    Public Shared Sub update1(mainForm As mainForm, e As KeyEventArgs)

        Dim nusername = mainForm.newUsername.Text
        Dim uID As Integer = mainForm.myID.Text

        If e.KeyCode = Keys.Enter Then


            If mainForm.cbUsername.CheckState = 0 Then

                MsgBox("Toggle ON first the change username check box before changing.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")

            Else

                If mainForm.cbUsername.CheckState = 1 And mainForm.newUsername.Text = String.Empty Then

                    MsgBox("Username field is empty", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

                Else

                    If mainForm.cbUsername.CheckState = 1 And mainForm.newUsername.Text = mainForm.newUsername.Text And Not mainForm.newUsername.TextLength > 4 Then

                        MsgBox("Username must be 4 length character to proceed", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

                    Else

                        Dim update_command As New MySqlCommand("UPDATE `altertable` SET `username`=@nusername WHERE `id`=@uID", mainForm.connection)
                        update_command.Parameters.Add("@uID", MySqlDbType.Int32).Value = uID
                        update_command.Parameters.Add("@nusername", MySqlDbType.VarChar).Value = nusername

                        If mainForm.subconnection(update_command) Then

                            MsgBox(mainForm.newUsername.Text & " is your new username", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

                        End If

                    End If

                End If

            End If

        End If

    End Sub


    Public Shared Sub update2(mainForm As mainForm, e As KeyEventArgs)

        Dim npass As String = mainForm.newPass.Text
        Dim npass2 As String = mainForm.newPass2.Text
        Dim uID As Integer = mainForm.myID.Text


        If e.KeyCode = Keys.Enter Then

            '' for password checbox function. nested

            If mainForm.cbPassword.CheckState = 0 Then

                MsgBox("Toggle ON first the change password check box before changing.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Error")

            Else

                If mainForm.cbPassword.CheckState = 1 And mainForm.newPass.Text = String.Empty Then

                    MsgBox("No password found found.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

                Else

                    If mainForm.cbPassword.CheckState = 1 And mainForm.newPass2.Text = String.Empty Then

                        MsgBox("Please repeat your password.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

                    Else

                        If mainForm.cbPassword.CheckState = 1 And mainForm.newPass2.Text = mainForm.newPass2.Text And Not mainForm.newPass2.MaxLength > 6 Then

                            MsgBox("Password must be more than 6 characters.")

                        Else

                            If Not String.Equals(npass, npass2) Then

                                MsgBox("Password not matched.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)

                            Else

                                Dim update_command As New MySqlCommand("UPDATE `altertable` SET `password`=@npass2 WHERE `id`=@uID", mainForm.connection)
                                update_command.Parameters.Add("@uID", MySqlDbType.Int32).Value = uID
                                update_command.Parameters.Add("@npass2", MySqlDbType.VarChar).Value = npass2

                                If mainForm.subconnection(update_command) Then

                                    MsgBox("Password successfully changed.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

                                End If

                            End If

                        End If

                    End If

                End If

            End If

        End If

    End Sub



    Public Shared Sub tab1(mainForm As mainForm)


        mainForm.modPanel.BringToFront()

        mainForm.btnMod.BackColor = Color.FromArgb(67, 61, 63)
        mainForm.btnSett.BackColor = Color.FromArgb(30, 28, 26)

    End Sub

    Public Shared Sub tab2(mainForm As mainForm)


        mainForm.appPanel.BringToFront()

        mainForm.btnMod.BackColor = Color.FromArgb(30, 28, 26)
        mainForm.btnSett.BackColor = Color.FromArgb(67, 61, 63)

    End Sub

    Public Shared Sub pfp(mainForm As mainForm)

        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.JPG;*.PNG;*.GIF)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = System.Windows.Forms.DialogResult.OK Then

            mainForm.RoundedPictureBox3.Image = Image.FromFile(opf.FileName)

            mainForm.btnPicture.Enabled = True

        End If

    End Sub

    Public Shared Sub submit(mainForm As mainForm)

        Dim con As New connectionToHeaven()

        Dim ms As New MemoryStream

        mainForm.RoundedPictureBox3.Image.Save(ms, mainForm.RoundedPictureBox3.Image.RawFormat)

        Dim update_command As New MySqlCommand("UPDATE `altertable` SET `usr_prf`=@profile WHERE `id` = @eID", con.getConnection())

        update_command.Parameters.Add("@eID", MySqlDbType.VarChar).Value = mainForm.myID.Text

        update_command.Parameters.Add("@profile", MySqlDbType.LongBlob).Value = ms.ToArray

        con.openConnection()

        If update_command.ExecuteNonQuery() = 1 Then

            mainForm.RoundedPictureBox3.Image = Nothing

            MsgBox("Image successfully saved", MsgBoxStyle.Information)

            con.closeConnection()

            AllFunctionsMain.updateImageButton(mainForm)

        End If

    End Sub
End Class
