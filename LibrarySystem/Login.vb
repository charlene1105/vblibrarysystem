Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        MainMenu.tabGrp.SelectTab(0)
        MainMenu.Show()
        txtUsername.Text = ""
        txtPassword.Text = ""
        lblError.Visible = False

    End Sub

   

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        checkDbConn()
        With selectCmd
            .CommandText = "SELECT * from Admin where username = '" & txtUsername.Text & "' and password = '" & txtPassword.Text & "'"
            .Connection = dbConn
        End With
        dbRdr = selectCmd.ExecuteReader
        Try
            If dbRdr.Read Then
                btnLogin.Enabled = True
                lblError.Visible = False
            Else
                btnLogin.Enabled = False
                lblError.Visible = True
            End If
        Catch ex As Exception

        End Try
        dbRdr.Close()
        closeDbConn()

    End Sub

    Private Sub FlatLabel3_Click(sender As Object, e As EventArgs) Handles FlatLabel3.Click
        Admin_add.Show()
    End Sub

    Private Sub txtUsername_GotFocus(sender As Object, e As EventArgs) Handles txtUsername.GotFocus
        txtPassword.Text = ""
    End Sub

   
End Class
