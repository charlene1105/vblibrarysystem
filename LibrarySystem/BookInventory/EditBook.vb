Public Class EditBook
    Public noofborrowedbooks As Integer = 0
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub


    Private Sub btnEditBook_Click(sender As Object, e As EventArgs) Handles btnEditBook.Click
        checkDbConn()
        With updateCmd
            .CommandText = "UPDATE BookInventory SET Title='" & txtTitle.Text & _
                            "', Publisher='" & txtPublisher.Text & _
                            "', Author='" & txtAuthor.Text & "', Category='" & txtCategory.Text & _
                            "', PublishedYear='" & txtPublishedYear.Text & _
                            "', TotalNo='" & Val(txtCopies.Text) & _
                             "', NoofAvailableBook='" & Val(txtCopies.Text) - Val(MainMenu.lstvwBookInventory.SelectedItems(0).SubItems(8).Text) & _
                            "' WHERE BookID='" & lblBookID.Text & "'"
            .Connection = dbConn
            .ExecuteNonQuery()
        End With
        closeDbConn()
        islstvwBookInventoryUpdated = True
        MainMenu.loadBookInventoryListView()
        Me.Close()
    End Sub

    Private Sub EditBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBookID.Text = MainMenu.lstvwBookInventory.SelectedItems(0).Text
        txtTitle.Text = MainMenu.lstvwBookInventory.SelectedItems(0).SubItems(1).Text
        txtPublisher.Text = MainMenu.lstvwBookInventory.SelectedItems(0).SubItems(2).Text
        txtAuthor.Text = MainMenu.lstvwBookInventory.SelectedItems(0).SubItems(3).Text
        txtCategory.Text = MainMenu.lstvwBookInventory.SelectedItems(0).SubItems(4).Text
        txtPublishedYear.Text = MainMenu.lstvwBookInventory.SelectedItems(0).SubItems(5).Text
        txtCopies.Text = MainMenu.lstvwBookInventory.SelectedItems(0).SubItems(6).Text

    End Sub

    Private Sub txtTitle_TextChanged(sender As Object, e As EventArgs) Handles txtTitle.TextChanged
        checkInputs()
    End Sub

    Private Sub checkInputs()
        Dim validregister As Boolean = False
        If txtTitle.Text.Length > 0 And txtAuthor.Text.Length > 0 _
        And txtCopies.Text.Length > 0 And txtPublishedYear.Text.Length > 0 _
        And txtPublisher.Text.Length > 0 And txtCategory.Text.Length > 0 And Val(txtCopies.Text) > 0 Then
            validregister = True
        Else
            validregister = False
        End If

        If validregister = False Then
            btnEditBook.Enabled = False
        Else
            btnEditBook.Enabled = True
        End If
    End Sub

    Private Sub txtCopies_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCopies.KeyPress
        If (Asc(UCase(e.KeyChar)) < 48 Or Asc(UCase(e.KeyChar)) > 57) And Asc((e.KeyChar)) <> 8 Then
            e.KeyChar = ChrW(0)
        End If
    End Sub


    Private Sub txtPublishedYear_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPublishedYear.KeyPress
        If (Asc(UCase(e.KeyChar)) < 48 Or Asc(UCase(e.KeyChar)) > 57) And Asc((e.KeyChar)) <> 8 Then
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtAuthor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAuthor.KeyPress
        If (Not Asc(e.KeyChar) = 46 And Not (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122)) And Asc(e.KeyChar) <> 8 _
           And Asc(e.KeyChar) <> 32 And Asc(e.KeyChar) <> 37 And Asc(e.KeyChar) <> 39 Then
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtAuthor_KeyUp(sender As Object, e As KeyEventArgs) Handles txtAuthor.KeyUp
        txtAuthor.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtAuthor.Text)
        txtAuthor.SelectionStart = txtAuthor.Text.Length + 1
    End Sub

    Private Sub txtCategory_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCategory.KeyPress
        txtCategory.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtCategory.Text)
        txtCategory.SelectionStart = txtCategory.Text.Length + 1
    End Sub

    Private Sub txtCategory_TextChanged(sender As Object, e As EventArgs) Handles txtCategory.TextChanged
        checkInputs()
    End Sub


    Private Sub txtPublisher_TextChanged(sender As Object, e As EventArgs) Handles txtPublisher.TextChanged
        checkInputs()
    End Sub

    Private Sub txtAuthor_TextChanged(sender As Object, e As EventArgs) Handles txtAuthor.TextChanged
        checkInputs()
    End Sub

    Private Sub txtPublishedYear_TextChanged(sender As Object, e As EventArgs) Handles txtPublishedYear.TextChanged
        checkInputs()
    End Sub
    Private Sub txtCopies_TextChanged(sender As Object, e As EventArgs) Handles txtCopies.TextChanged
        If Val(txtCopies.Text) = 0 Then
            lblErrorZero.Visible = True
        Else
            lblErrorZero.Visible = False
        End If
        checkInputs()
    End Sub
End Class