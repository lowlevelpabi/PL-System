Imports MySqlConnector

Public Class connectionToHeaven

    Private connection As New MySqlConnection("server=localhost;port=;user id=root;password=;database=alterdb")


    ' return the connection
    ReadOnly Property getConnection() As MySqlConnection
        Get
            Return connection
        End Get
    End Property

    ' open the connection
    Sub openConnection()

        Try

            If connection.State = ConnectionState.Closed Then

                connection.Open()

            End If

        Catch ex As MySqlException

            MsgBox("Connection to server cannot establish. Please re-open the application.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Server is offline")

            End

        End Try


    End Sub

    ' close the connection
    Sub closeConnection()

        If connection.State = ConnectionState.Open Then
            connection.Close()
        End If

    End Sub

End Class