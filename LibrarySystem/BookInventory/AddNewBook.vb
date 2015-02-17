Public Class AddNewBook

    Public bookIDstr As String
    Public bookIDnum As Integer

    Private Sub AddNewBook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkDbConn()
        lblBookID.Text = "BOOK0000000"
        With selectCmd
            .CommandText = "SELECT LAST(BookID) from BookInventory"
            .Connection = dbConn
        End With
        dbRdr = selectCmd.ExecuteReader
        Try
            If dbRdr.Read Then
                bookIDstr = dbRdr.GetString(0)
                bookIDnum = Val(bookIDstr.Substring(4, 7))
                bookIDnum += 1
                If bookIDnum < 1000000 Then
                    lblBookID.Text = Mid(dbRdr.GetString(0), 1, 11 - (Len(bookIDnum.ToString))) & bookIDnum
                End If
            Else
                lblBookID.Text = "BOOK0000000"
            End If
        Catch ex As Exception

        End Try
        dbRdr.Close()
        closeDbConn()
    End Sub
   

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

  
    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        checkDbConn()
        With insertCmd
            .CommandText = "INSERT INTO BookInventory(BookID,Title,Publisher,Author,Category,PublishedYear,TotalNo,NoofAvailableBook)" & _
                           " VALUES('" & lblBookID.Text & "', '" & txtTitle.Text & "', '" & _
                            txtPublisher.Text & "', '" & txtAuthor.Text & "', '" & txtCategory.Text & _
                            "', " & Val(txtPublishedYear.Text) & ", " & Val(txtCopies.Text) & ", " & Val(txtCopies.Text) & ")"
            .Connection = dbConn
            .ExecuteNonQuery()
        End With
        closeDbConn()
        islstvwBookInventoryUpdated = True
        MainMenu.loadBookInventoryListView()
        Me.Close()
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
            btnAddBook.Enabled = False
        Else
            btnAddBook.Enabled = True
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
