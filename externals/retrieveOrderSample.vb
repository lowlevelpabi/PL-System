' retrieve order detail along with its responsible user.

Public Shared Sub RetrieveOrdersWithUsers(mainForm as mainForm)
    
    Using connection As New MySqlConnection(mainForm.connect.getConnection())

        connection.Open()

        Dim query As String = "SELECT o.order_id, o.order_date, u.user_id, u.username " &
                              "FROM orders o " &
                              "JOIN users u ON o.user_id = u.user_id"

        Using command As New MySqlCommand(query, connection)

            Using reader As MySqlDataReader = command.ExecuteReader()
                
                If reader.HasRows Then

                    While reader.Read()

                        Dim orderId As Integer = reader.GetInt32("order_id")

                        Dim orderDate As Date = reader.GetDateTime("order_date")

                        Dim userId As Integer = reader.GetInt32("user_id")

                        Dim username As String = reader.GetString("username")

                        ' return msg

                    End While

                Else

                    ' No rows returned

                End If

            End Using

        End Using

        connection.Close()

    End Using

End Sub