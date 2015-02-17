Public Class AddNewMember

    Public memberIDstr As String
    Public memberIDnum As Integer

    Private Sub AddNewMember_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        checkDbConn()
        lblMemberID.Text = "MMBR00000"
        With selectCmd
            .CommandText = "SELECT LAST(MemberID) from MemberList"
            .Connection = dbConn
        End With
        dbRdr = selectCmd.ExecuteReader
        Try
            If dbRdr.Read Then
                memberIDstr = dbRdr.GetString(0)
                memberIDnum = Val(memberIDstr.Substring(4, 5))
                memberIDnum += 1
                If memberIDnum < 100000 Then
                    lblMemberID.Text = Mid(dbRdr.GetString(0), 1, 9 - (Len(memberIDnum.ToString))) & memberIDnum
                End If
            Else
                lblMemberID.Text = "MMBR00000"
            End If
        Catch ex As Exception

        End Try
        dbRdr.Close()
        closeDbConn()
    End Sub

    Private Sub btnAddMember_Click(sender As Object, e As EventArgs) Handles btnAddMember.Click
        Dim noofborrowedbook As Integer = 0
        checkDbConn()
        With insertCmd
            .CommandText = "INSERT INTO MemberList(MemberID,LastName,FirstName,MI,Address,ContactNo,NoofBorrowedBook)" & _
                           " VALUES('" & lblMemberID.Text & "', '" & txtMemberLastName.Text & "', '" & _
                            txtMemberFirstName.Text & "', '" & txtMemberMI.Text & "', '" & txtMemberAddress.Text & _
                            "', '" & txtMemberContactNo.Text & "', " & noofborrowedbook & ")"
            .Connection = dbConn
            .ExecuteNonQuery()
        End With
        closeDbConn()
        islstvwMemberListUpdated = True
        MainMenu.loadMemberListView()
        Me.Close()
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
            btnAddMember.Enabled = False
        Else
            btnAddMember.Enabled = True
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