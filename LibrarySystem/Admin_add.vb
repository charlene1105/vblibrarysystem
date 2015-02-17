Public Class Admin_add

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            checkDbConn()
            With insertCmd
                .CommandText = "INSERT INTO Admin VALUES('" & txtUsername.Text & "', '" & txtPassword.Text & "')"
                .Connection = dbConn
                .ExecuteNonQuery()
            End With
            closeDbConn()
            MessageBox.Show("Successfully added a new admin")
            Me.Close()

        Catch ex As Exception

        End Try
    End Sub
End Class