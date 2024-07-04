Imports MySqlConnector
Imports System.IO

Public Class Form2

    'Draggable form property
    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point


    ' connection
    Public conString As New connectionToHeaven()
    Public ms As New MemoryStream()
    Public da As New MySqlDataAdapter()
    Public dt As New DataTable()


    Private Sub Form2_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown, Panel1.MouseDown

        If e.Button = MouseButtons.Left Then

            MoveForm = True
            Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location

        End If

    End Sub

    Private Sub Form2_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp, Panel1.MouseUp

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Cursor = Cursors.Default
        End If

    End Sub

    Private Sub Form2_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove, Panel1.MouseMove

        If MoveForm Then

            Location = Location + (e.Location - MoveForm_MousePosition)

        End If

    End Sub


    Public Sub checkCreateUsername(username As String)

        If Not username.Length > 0 Then

            Label4.Text = "Can't create account without username"
            Label4.ForeColor = Color.Red

        Else

            If Not username.Length > 6 Then

                Label4.ForeColor = Color.Red
                Label4.Text = "Username must be more than 6 characters"


            End If

        End If

    End Sub

    Public Sub passwordChecker(createPass As String, text As String)

        Dim createPassword As String = txtPassword1.Text
        Dim crpassword As String = txtPassword2.Text

        If Not createPass.Length > 0 Then

            Label4.ForeColor = Color.Red
            Label4.Text = "Please confirm your password"

        Else

            If Not String.Equals(createPassword, crpassword) Then

                Label4.ForeColor = Color.Red
                Label4.Text = "Password doesn't match. Retry."

            Else


                If Not createPass.Length > 6 Then

                    Label4.ForeColor = Color.Red
                    Label4.Text = "Password must be more than 9 characters"

                End If

            End If

        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtUsername.Size = New Size(299, 28)

        txtPassword1.Size = New Size(299, 28)

        txtPassword2.Size = New Size(299, 28)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.CheckState = 1 Then

            txtPassword1.PasswordChar = ""

            txtPassword2.PasswordChar = ""

        Else

            If CheckBox1.CheckState = 0 Then

                txtPassword1.PasswordChar = "●"

                txtPassword2.PasswordChar = "●"

            End If

        End If

    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown

        form2Functions.keyEvent1(Me, e)

    End Sub

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword1.KeyDown, txtPassword2.KeyDown

        form2Functions.keyEvent2(Me, e)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        form2Functions.submit(Me)

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        mainForm.Show()
        Close()
    End Sub
End Class