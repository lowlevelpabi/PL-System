Imports System.Data
Imports System.Drawing
Imports MySqlConnector
Imports MidtermProject
Public Class Class1


    Public Shared Sub mainFunction()

        Dim mainForm = New mainForm

        mainForm.connection.Open()

        Dim dt As New DataSet

        Try

            Dim username As String = Form1.txtUsername.Text

            Dim sql As String = "SELECT * FROM altertable WHERE username='" & username & "'"
            Dim da As New MySqlDataAdapter(sql, mainForm.connection)

            da.Fill(dt, "alterdb")

            mainForm.myID.DataBindings.Add("text", dt, "alterdb.id")
            Dim cmd As New MySqlCommand("Select * FROM altertable WHERE username='" & username & "'", mainForm.connection)
            Dim dr As MySqlDataReader
            dr = cmd.ExecuteReader()
            If dr.Read() Then
                Dim imagebytes As Byte() = CType(dr("usr_prf"), Byte())
                Using ms As New IO.MemoryStream(imagebytes)
                    mainForm.RoundedPictureBox1.Image = Image.FromStream(ms)
                    mainForm.RoundedPictureBox1.SizeMode = PictureBoxSizeMode.Zoom
                End Using
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        ' groupbox color
        mainForm.GroupBox3.ForeColor = Color.FromArgb(192, 192, 194)

        ' con for fetching items
        dbconn()
        mainForm.Load_Items()


        ' extras

        mainForm.Text = "Midterm Project : Main"

        mainForm.Label13.Text = "Logged-in as, " & Environment.NewLine & mainForm.unSession


        mainForm.DataGridView1.DefaultCellStyle.ForeColor = Color.FromArgb(192, 192, 194)

        mainForm.DataGridView1.DefaultCellStyle.BackColor = Color.FromArgb(37, 34, 35)

        If mainForm.RoundedPictureBox3.Image Is Nothing Then

            mainForm.btnPicture.Enabled = False
        End If

        mainForm.ToolTip1.SetToolTip(mainForm.btnHome, "Home")
        mainForm.ToolTip1.SetToolTip(mainForm.btnStore, "Store")
        mainForm.ToolTip1.SetToolTip(mainForm.btnAbout, "Abut us")
        mainForm.ToolTip1.SetToolTip(mainForm.btnSettings, "Settings")


    End Sub

    Public Shared Sub functionOne(mainForm As mainForm)


            If mainForm.DataGridView1.Rows.Count = 0 Then

                mainForm.Label4.Text = "Cart is empty, no item can delete."
                mainForm.Label4.ForeColor = Color.Yellow

            Else


                Dim selectedRow As DataGridViewRow

                For Each selectedRow In mainForm.DataGridView1.SelectedRows  ' Assuming DataGridView1 is your DataGrid

                    Dim response As Integer
                    Dim itemName As String = selectedRow.Cells(2).Value ' Assuming item name is in first column (index 0)

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
                mainForm.DataGridView1.Rows.Clear()

                mainForm.Label4.Text = "Item(s) cleared"
                mainForm.Label4.ForeColor = Color.Green

            End If

        End Sub

        Public Shared Sub checkOut(mainForm As mainForm)

            If mainForm.DataGridView1.Rows.Count = 0 Then


                mainForm.Label4.Text = "Get something else to the store and cart it before you proceed."
                mainForm.Label4.ForeColor = Color.Yellow

            Else

                checkoutItems.DataGridView1.Rows.Clear()


                For Each row As DataGridViewRow In mainForm.DataGridView1.Rows

                    If Not row.IsNewRow Then

                        Dim clonedRow As DataGridViewRow = CType(row.Clone(), DataGridViewRow)


                        For i As Integer = 0 To row.Cells.Count - 1

                            clonedRow.Cells(i).Value = row.Cells(i).Value
                        Next


                        checkoutItems.DataGridView1.Rows.Add(clonedRow)
                    End If
                Next

                checkoutItems.ShowDialog()

            End If

        End Sub
End Class