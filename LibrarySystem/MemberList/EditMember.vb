Public Class EditMember

    Private Sub btnEditMember_Click(sender As Object, e As EventArgs) Handles btnEditMember.Click
        checkDbConn()
        With updateCmd
            .CommandText = "UPDATE MemberList SET LastName='" & txtMemberLastName.Text & _
                            "', FirstName='" & txtMemberFirstName.Text & _
                            "', MI='" & txtMemberMI.Text & "', Address='" & txtMemberAddress.Text & _
                            "', ContactNo='" & txtMemberContactNo.Text & _
                            "' WHERE MemberID='" & lblMemberID.Text & "'"
            .Connection = dbConn
            .ExecuteNonQuery()
        End With
        closeDbConn()
        islstvwMemberListUpdated = True
        MainMenu.loadMemberListView()
        Me.Close()
    End Sub

    Private Sub EditMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblMemberID.Text = MainMenu.lstvwMemberList.SelectedItems(0).Text
        txtMemberLastName.Text = MainMenu.lstvwMemberList.SelectedItems(0).SubItems(1).Text
        txtMemberFirstName.Text = MainMenu.lstvwMemberList.SelectedItems(0).SubItems(2).Text
        txtMemberMI.Text = MainMenu.lstvwMemberList.SelectedItems(0).SubItems(3).Text
        txtMemberAddress.Text = MainMenu.lstvwMemberList.SelectedItems(0).SubItems(4).Text
        txtMemberContactNo.Text = MainMenu.lstvwMemberList.SelectedItems(0).SubItems(5).Text
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub


    Private Sub txtMemberMI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMemberMI.KeyPress
        If (Not Asc(e.KeyChar) = 46 And Not (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122)) And Asc(e.KeyChar) <> 8 _
            And Asc(e.KeyChar) <> 32 And Asc(e.KeyChar) <> 37 And Asc(e.KeyChar) <> 39 Then
            e.KeyChar = ChrW(0)
        End If
    End Sub



    Private Sub txtMemberLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMemberLastName.KeyPress
        If (Not Asc(e.KeyChar) = 46 And Not (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122)) And Asc(e.KeyChar) <> 8 _
             And Asc(e.KeyChar) <> 32 And Asc(e.KeyChar) <> 37 And Asc(e.KeyChar) <> 39 Then
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtMemberFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMemberFirstName.KeyPress
        If (Not Asc(e.KeyChar) = 46 And Not (Asc(e.KeyChar) >= 97 And Asc(e.KeyChar) <= 122)) And Asc(e.KeyChar) <> 8 _
             And Asc(e.KeyChar) <> 32 And Asc(e.KeyChar) <> 37 And Asc(e.KeyChar) <> 39 Then
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtMemberContactNo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMemberContactNo.KeyPress
        If (Asc(UCase(e.KeyChar)) < 48 Or Asc(UCase(e.KeyChar)) > 57) And Asc((e.KeyChar)) <> 8 And Asc(e.KeyChar) <> 45 Then
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtMemberLastName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMemberLastName.KeyUp
        txtMemberLastName.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtMemberLastName.Text)
        txtMemberLastName.SelectionStart = txtMemberLastName.Text.Length + 1
    End Sub

    Private Sub txtMemberFirstName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMemberFirstName.KeyUp
        txtMemberFirstName.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtMemberFirstName.Text)
        txtMemberFirstName.SelectionStart = txtMemberFirstName.Text.Length + 1
    End Sub


    Private Sub txtMemberMI_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMemberMI.KeyUp
        txtMemberMI.Text = Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txtMemberMI.Text)
        txtMemberMI.SelectionStart = txtMemberMI.Text.Length + 1
    End Sub


    Private Sub txtMemberLastName_TextChanged(sender As Object, e As EventArgs) Handles txtMemberLastName.TextChanged
        checkInputs()
    End Sub

    Private Sub checkInputs()
        Dim validregister As Boolean = False
        If txtMemberLastName.Text.Length > 0 And txtMemberFirstName.Text.Length > 0 _
        And txtMemberMI.Text.Length > 0 And txtMemberAddress.Text.Length > 0 And txtMemberContactNo.Text.Length > 0 Then
            validregister = True
        Else
            validregister = False
        End If

        If validregister = False Then
            btnEditMember.Enabled = False
        Else
            btnEditMember.Enabled = True
        End If
    End Sub

    Private Sub txtMemberFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtMemberFirstName.TextChanged
        checkInputs()
    End Sub

    Private Sub txtMemberMI_TextChanged(sender As Object, e As EventArgs) Handles txtMemberMI.TextChanged
        checkInputs()
    End Sub

    Private Sub txtMemberAddress_TextChanged(sender As Object, e As EventArgs) Handles txtMemberAddress.TextChanged
        checkInputs()
    End Sub

    Private Sub txtMemberContactNo_TextChanged(sender As Object, e As EventArgs) Handles txtMemberContactNo.TextChanged
        checkInputs()
    End Sub
End Class