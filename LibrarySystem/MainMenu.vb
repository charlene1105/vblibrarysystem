Public Class MainMenu
    Public bookInventoryQuery As String
    Public memberQuery As String
    Public borrowersListQuery As String
    Public borrowbooklistQuery As String
    Public booksborrowedQuery As String
    Public returnbooklistQuery As String
    Public penaltytotalamt As Double
    Public totalamount As Double
    Public borrower As String
    Public returnbookBorrowerID As String
    Public indexOfBorrowBookId As Integer
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tabHome.Select()
        tmrDateTime.Enabled = True
        tmrDateTime.Start()
        borrowBookLoad()
        bookInventoryLoad()
        manageMembersLoad()


    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Me.Hide()
        Login.Show()
    End Sub



   

    '================================================================================================
    ' BOOK INVENTORY
    '================================================================================================
    'BOOK INVENTORY CLICKED
    Private Sub btnBookInventory_Click(sender As Object, e As EventArgs) Handles btnBookInventory.Click
        tabGrp.SelectTab(1)
        bookInventoryLoad()
    End Sub

    Public Sub bookInventoryLoad()
        islstvwBookInventoryUpdated = True
        bookInventoryQuery = "SELECT * FROM BookInventory ORDER BY BookID ASC"
        loadBookInventoryListView()
    End Sub

    'LOAD BOOK INVENTORY LIST VIEW
    Public Sub loadBookInventoryListView()
        If islstvwBookInventoryUpdated = True Then
            checkDbConn()
            lstvwBookInventory.MultiSelect = False
            lstvwBookInventory.GridLines = True
            lstvwBookInventory.FullRowSelect = True
            lstvwBookInventory.View = View.Details
            lstvwBookInventory.Items.Clear()
            lstvwBookInventory.Clear()

            lstvwBookInventory.Columns.Add("Book ID", 100, HorizontalAlignment.Left)
            lstvwBookInventory.Columns.Add("Title", 300, HorizontalAlignment.Left)
            lstvwBookInventory.Columns.Add("Publisher", 150, HorizontalAlignment.Left)
            lstvwBookInventory.Columns.Add("Author", 150, HorizontalAlignment.Left)
            lstvwBookInventory.Columns.Add("Category", 130, HorizontalAlignment.Left)
            lstvwBookInventory.Columns.Add("Year", 75, HorizontalAlignment.Left)
            lstvwBookInventory.Columns.Add("Total Qty", 100, HorizontalAlignment.Left)
            lstvwBookInventory.Columns.Add("Available Qty", 100, HorizontalAlignment.Left)
            lstvwBookInventory.Columns.Add("Borrowed Qty", 100, HorizontalAlignment.Left)

            With selectCmd
                .CommandText = bookInventoryQuery
            End With
            Dim dbTbl As New DataTable
            dbTbl.TableName = "BookInventory"

            With dbAdptr
                .SelectCommand = selectCmd
                .SelectCommand.Connection = dbConn
                .Fill(dbTbl)
            End With

            For i = 0 To dbTbl.Rows.Count - 1
                With lstvwBookInventory
                    .Items.Add(dbTbl.Rows(i)("BookID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(dbTbl.Rows(i)("Title"))
                        .Add(dbTbl.Rows(i)("Publisher"))
                        .Add(dbTbl.Rows(i)("Author"))
                        .Add(dbTbl.Rows(i)("Category"))
                        .Add(dbTbl.Rows(i)("PublishedYear"))
                        .Add(dbTbl.Rows(i)("TotalNo"))
                        .Add(Val(dbTbl.Rows(i)("NoofAvailableBook").ToString))
                        .Add(Val(dbTbl.Rows(i)("NoofBorrowedBook").ToString))
                    End With
                End With
            Next
        End If
        closeDbConn()
        islstvwBookInventoryUpdated = False
    End Sub

    'DISABLE ENABLE THE EDIT AND DELETE BUTTON
    Private Sub lstvwBookInventory_LostFocus(sender As Object, e As EventArgs) Handles lstvwBookInventory.LostFocus
        If btnDeleteBook.Focused Or btnEditBook.Focused Then
        Else
            btnDeleteBook.Enabled = False
            btnEditBook.Enabled = False
        End If
    End Sub

    Private Sub lstvwBookInventory_MouseClick(sender As Object, e As MouseEventArgs) Handles lstvwBookInventory.MouseClick
        If Val(lstvwBookInventory.SelectedItems(0).SubItems(8).Text) > 0 Then
            If Val(lstvwBookInventory.SelectedItems(0).SubItems(8).Text) > 0 Then
                btnDeleteBook.Enabled = False
            Else
                btnDeleteBook.Enabled = True
            End If
        End If
        btnEditBook.Enabled = True
    End Sub

    Private Sub lstvwBookInventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvwBookInventory.SelectedIndexChanged
        If lstvwBookInventory.SelectedItems.Count > 0 Then
            If Val(lstvwBookInventory.SelectedItems(0).SubItems(8).Text) > 0 Then
                btnDeleteBook.Enabled = False
            Else
                btnDeleteBook.Enabled = True
            End If
        End If
        btnEditBook.Enabled = True
    End Sub

    'ADD BOOK
    Private Sub btnAddBook_Click(sender As Object, e As EventArgs) Handles btnAddBook.Click
        AddNewBook.Show()
    End Sub

    'EDIT BOOK
    Private Sub btnEditBook_Click(sender As Object, e As EventArgs) Handles btnEditBook.Click
        If lstvwBookInventory.Items.Count > 0 Then
            EditBook.Show()
            btnEditBook.Enabled = False
            btnDeleteBook.Enabled = False
        Else
            MessageBox.Show("No selected member")
        End If
        btnEditBook.Enabled = False
    End Sub

    'DELETE BOOK
    Private Sub btnDeleteBook_Click(sender As Object, e As EventArgs) Handles btnDeleteBook.Click
        If lstvwBookInventory.SelectedItems.Count > 0 Then
            checkDbConn()
            With deleteCmd
                .CommandText = "DELETE FROM BookInventory WHERE BookID ='" & lstvwBookInventory.SelectedItems(0).Text & "'"
                .Connection = dbConn
                .ExecuteNonQuery()
            End With
            closeDbConn()
            islstvwBookInventoryUpdated = True
            bookInventoryQuery = "SELECT * FROM BookInventory"
            loadBookInventoryListView()
        Else
            MessageBox.Show("No selected member")
        End If
        btnDeleteBook.Enabled = False
        btnEditBook.Enabled = False
    End Sub

    'SEARCH BOOK
    Private Sub txtSearchBook_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBook.TextChanged
        'bookInventoryQuery = "SELECT * FROM BookInventory WHERE BookID like '%" & txtSearchBook.Text & _
        '                    "%' or Title like '%" & txtSearchBook.Text & "%' or Publisher like '" & _
        '                    txtSearchBook.Text & "%' or Category like '" & txtSearchBook.Text & "%'"
        'checkDbConn()
        'With selectCmd
        '    .CommandText = bookInventoryQuery
        '    .Connection = dbConn
        '    .ExecuteNonQuery()
        'End With
        'closeDbConn()
        'islstvwBookInventoryUpdated = True
        'loadBookInventoryListView()


        If cmbBookInventorySearch.Text <> "" Then
            If cmbBookInventorySearch.Text = "Book ID" Then
                bookInventoryQuery = "SELECT * FROM BookInventory WHERE BookID like '" & txtSearchBook.Text & "%'"
            ElseIf cmbBookInventorySearch.Text = "Title" Then
                bookInventoryQuery = "SELECT * FROM BookInventory WHERE Title like '" & txtSearchBook.Text & "%'"
            ElseIf cmbBookInventorySearch.Text = "Publisher" Then
                bookInventoryQuery = "SELECT * FROM BookInventory WHERE Publisher like '" & txtSearchBook.Text & "%'"
            ElseIf cmbBookInventorySearch.Text = "Author" Then
                bookInventoryQuery = "SELECT * FROM BookInventory WHERE Author like '" & txtSearchBook.Text & "%'"
            ElseIf cmbBookInventorySearch.Text = "Category" Then
                bookInventoryQuery = "SELECT * FROM BookInventory WHERE Category like '" & txtSearchBook.Text & "%'"
            ElseIf cmbBookInventorySearch.Text = "Published Year" Then
                bookInventoryQuery = "SELECT * FROM BookInventory WHERE PublishedYear like '" & txtSearchBook.Text & "%'"
            End If
            checkDbConn()
            With selectCmd
                .CommandText = bookInventoryQuery
                .Connection = dbConn
                .ExecuteNonQuery()
            End With
            closeDbConn()
            islstvwBookInventoryUpdated = True
            loadBookInventoryListView()
        Else
            MessageBox.Show("Please choose a category to search for")
        End If
    End Sub


    '================================================================================================
    ' MEMBER LIST
    '================================================================================================
    'MEMBER LIST CLICKED
    Private Sub btnManageMembers_Click(sender As Object, e As EventArgs) Handles btnManageMembers.Click
        tabGrp.SelectTab(4)
        manageMembersLoad()
    End Sub

    Public Sub manageMembersLoad()
        islstvwMemberListUpdated = True
        memberQuery = "SELECT * FROM MemberList"
        loadMemberListView()
    End Sub

    'LOAD MEMBER LIST VIEW
    Public Sub loadMemberListView()
        If islstvwMemberListUpdated = True Then
            checkDbConn()
            lstvwMemberList.MultiSelect = False
            lstvwMemberList.GridLines = True
            lstvwMemberList.FullRowSelect = True
            lstvwMemberList.View = View.Details
            lstvwMemberList.Items.Clear()
            lstvwMemberList.Clear()

            lstvwMemberList.Columns.Add("Member ID", 100, HorizontalAlignment.Left)
            lstvwMemberList.Columns.Add("Last Name", 150, HorizontalAlignment.Left)
            lstvwMemberList.Columns.Add("First Name", 150, HorizontalAlignment.Left)
            lstvwMemberList.Columns.Add("MI", 52, HorizontalAlignment.Left)
            lstvwMemberList.Columns.Add("Address", 300, HorizontalAlignment.Left)
            lstvwMemberList.Columns.Add("Contact No", 100, HorizontalAlignment.Left)

            With selectCmd
                .CommandText = memberQuery
            End With
            Dim dbTbl As New DataTable
            dbTbl.TableName = "MemberList"

            With dbAdptr
                .SelectCommand = selectCmd
                .SelectCommand.Connection = dbConn
                .Fill(dbTbl)
            End With

            For i = 0 To dbTbl.Rows.Count - 1
                With lstvwMemberList
                    .Items.Add(dbTbl.Rows(i)("MemberID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(dbTbl.Rows(i)("LastName"))
                        .Add(dbTbl.Rows(i)("FirstName"))
                        .Add(dbTbl.Rows(i)("MI"))
                        .Add(dbTbl.Rows(i)("Address"))
                        .Add(dbTbl.Rows(i)("ContactNo"))
                    End With
                End With
            Next
        End If
        closeDbConn()
        islstvwMemberListUpdated = False
    End Sub

    
    'DISABLE ENABLE THE EDIT AND DELETE BUTTON
    Private Sub lstvwMemberList_LostFocus(sender As Object, e As EventArgs) Handles lstvwMemberList.LostFocus
        If btnDeleteMember.Focused Or btnEditMember.Focused Then
        Else
            btnDeleteMember.Enabled = False
            btnEditMember.Enabled = False
        End If
    End Sub

    Private Sub lstvwMemberList_MouseClick(sender As Object, e As MouseEventArgs) Handles lstvwMemberList.MouseClick
        btnDeleteMember.Enabled = True
        btnEditMember.Enabled = True
    End Sub

    Private Sub lstvwMemberList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvwMemberList.SelectedIndexChanged
        btnDeleteMember.Enabled = True
        btnEditMember.Enabled = True
    End Sub

    'ADD MEMBER
    Private Sub btnAddMember_Click(sender As Object, e As EventArgs) Handles btnAddMember.Click
        AddNewMember.Show()
    End Sub

    'EDIT MEMBER
    Private Sub btnEditMember_Click(sender As Object, e As EventArgs) Handles btnEditMember.Click
        If lstvwMemberList.Items.Count > 0 Then
            EditMember.Show()
            btnEditMember.Enabled = False
            btnDeleteMember.Enabled = False
        Else
            MessageBox.Show("No selected member")
        End If
        btnEditMember.Enabled = False
    End Sub

    'DELETE MEMBER
    Private Sub btnDeleteMember_Click(sender As Object, e As EventArgs) Handles btnDeleteMember.Click
        If lstvwMemberList.SelectedItems.Count > 0 Then
            checkDbConn()
            With deleteCmd
                .CommandText = "DELETE FROM MemberList WHERE MemberID ='" & lstvwMemberList.SelectedItems(0).Text & "'"
                .Connection = dbConn
                .ExecuteNonQuery()
            End With
            closeDbConn()
            islstvwMemberListUpdated = True
            loadMemberListView()
        Else
            MessageBox.Show("No selected member")
        End If
        btnDeleteMember.Enabled = False
        btnEditMember.Enabled = False
    End Sub

    'SEARCH MEMBER
    Private Sub txtSearchMember_TextChanged(sender As Object, e As EventArgs) Handles txtSearchMember.TextChanged
        If cmbSearchBy.Text <> "" Then
            If cmbSearchBy.Text = "MemberID" Then
                memberQuery = "SELECT * FROM MemberList WHERE MemberID like '" & txtSearchMember.Text & "%'"
            ElseIf cmbSearchBy.Text = "Lastname" Then
                memberQuery = "SELECT * FROM MemberList WHERE LastName like '" & txtSearchMember.Text & "%'"
            ElseIf cmbSearchBy.Text = "Firstname" Then
                memberQuery = "SELECT * FROM MemberList WHERE FirstName like '" & txtSearchMember.Text & "%'"
            ElseIf cmbSearchBy.Text = "MI" Then
                memberQuery = "SELECT * FROM MemberList WHERE MI like '" & txtSearchMember.Text & "%'"
            ElseIf cmbSearchBy.Text = "Address" Then
                memberQuery = "SELECT * FROM MemberList WHERE Address like '%" & txtSearchMember.Text & "%'"
            ElseIf cmbSearchBy.Text = "ContactNo" Then
                memberQuery = "SELECT * FROM MemberList WHERE ContactNo like '" & txtSearchMember.Text & "%'"
            End If
            checkDbConn()
            With selectCmd
                .CommandText = memberQuery
                .Connection = dbConn
                .ExecuteNonQuery()
            End With
            closeDbConn()
            islstvwMemberListUpdated = True
            loadMemberListView()
        Else
            MessageBox.Show("Please choose a category to search for")
        End If
       
    End Sub

    '================================================================================================
    ' BORROW BOOK
    '================================================================================================

    'BORROW BOOK CLICKED
    Private Sub btnBorrowBook_Click(sender As Object, e As EventArgs) Handles btnBorrowBook.Click
        tabGrp.SelectTab(2)
        borrowBookLoad()
        txtRBPayment.Text = ""
        cmbBookID.Enabled = True
    End Sub

    Public Sub borrowBookLoad()
        cmbBMemberID.Items.Clear()
        cmbBookID.Items.Clear()
        lstvwBorrowBookList.Items.Clear()
        txtBPayment.Text = ""
        lblBChange.Text = ""
        lblBTotalAmt.Text = ""
        cmbBMemberID.Enabled = True
        lblBTitle.Text = ""
        lblBPublisher.Text = ""
        lblBMemberName.Text = ""
        btnBorrowBookReceipt.Enabled = False
        cmbBMemberID.Text = ""
        cmbBookID.Text = ""
        lblBAuthor.Text = ""
        lblBCategory.Text = ""
        lblBPublishedYear.Text = ""
        lblBNoofAvailableBook.Text = ""
        lblErrorBookID.Visible = False
        lblErrorBorrowerID.Visible = False
        lblErrorBNotEnough.Visible = False

        'TRANSACTION NO AUTO GENERATED
        Dim trnsctnno As Integer
        checkDbConn()
        lblBTransactionNo.Text = "0000000"
        With selectCmd
            .CommandText = "SELECT LAST(TransactionNo) from BorrowBook"
            .Connection = dbConn
        End With
        dbRdr = selectCmd.ExecuteReader
        Try
            If dbRdr.Read Then

                trnsctnno = Val(dbRdr.GetString(0).Substring(0, 7))
                trnsctnno += 1
                If trnsctnno < 1000000 Then
                    lblBTransactionNo.Text = Mid(dbRdr.GetString(0), 1, 7 - (Len(trnsctnno.ToString))) & trnsctnno
                End If
            Else
                lblBTransactionNo.Text = "0000000"
            End If
        Catch ex As Exception

        End Try
        dbRdr.Close()
        closeDbConn()

        'TRANSACTION DATE AND DUE DATE
        Dim datenow As New Date
        Dim duedate As New Date
        Dim isSunday As Boolean = False

        datenow = Date.Now.Month & "/" & Date.Now.Day & "/" & Date.Now.Year
        lblBTransactionDate.Text = datenow
        duedate = datenow

        Dim daysadded As Integer
        Dim workingdays As Integer = 0
        For i = 0 To 5
            If datenow.DayOfWeek = DayOfWeek.Sunday Then
                isSunday = True
            End If
            datenow = datenow.AddDays(1)
        Next

        If isSunday = True Then
            daysadded = 6
        Else
            daysadded = 5
        End If
        lblBDueDate.Text = duedate.AddDays(daysadded)


        'MEMBER ID LOAD
        checkDbConn()
        With selectCmd
            .CommandText = "SELECT MemberID FROM MemberList WHERE NoofBorrowedBook = 0"
        End With
        Dim dbTbl As New DataTable
        dbTbl.TableName = "MemberList"

        With dbAdptr
            .SelectCommand = selectCmd
            .SelectCommand.Connection = dbConn
            .Fill(dbTbl)
        End With

        For i = 0 To dbTbl.Rows.Count - 1
            cmbBMemberID.Items.Add(dbTbl.Rows(i)("MemberID"))
        Next
        closeDbConn()


        'BOOK ID LOAD
        checkDbConn()
        With selectCmd
            .CommandText = "SELECT BookID FROM BookInventory WHERE NoofAvailableBook > 0"
        End With
        Dim dbTbl2 As New DataTable
        dbTbl2.TableName = "BookInventory"

        With dbAdptr
            .SelectCommand = selectCmd
            .SelectCommand.Connection = dbConn
            .Fill(dbTbl2)
        End With

        For i = 0 To dbTbl2.Rows.Count - 1
            cmbBookID.Items.Add(dbTbl2.Rows(i)("BookID"))
        Next
        closeDbConn()
    End Sub

    Private Sub cmbBMemberID_TextChanged(sender As Object, e As EventArgs) Handles cmbBMemberID.TextChanged
        checkDbConn()
        With selectCmd
            .CommandText = "SELECT * FROM MemberList WHERE MemberID='" & cmbBMemberID.Text & "'"
            .Connection = dbConn
        End With
        dbRdr = selectCmd.ExecuteReader
        If dbRdr.Read Then
            Try
                lblErrorBorrowerID.Visible = False
                lblBMemberName.Text = dbRdr.GetString(1) & ", " & dbRdr.GetString(2) & " " & dbRdr.GetString(3)
            Catch ex As Exception

            End Try
            If lblErrorBookID.Visible = False And Not cmbBookID.Text = "" Then
                btnAddBooktoBList.Enabled = True
            End If
        Else
            btnAddBooktoBList.Enabled = False
            lblErrorBorrowerID.Visible = True
            lblBMemberName.Text = "N/A"
        End If
        dbRdr.Close()
        closeDbConn()

    End Sub

    Private Sub cmbBookID_TextChanged(sender As Object, e As EventArgs) Handles cmbBookID.TextChanged
        If lstvwBorrowBookList.SelectedItems.Count > 0 Then
            btnAddBooktoBList.Enabled = False
        Else
            btnAddBooktoBList.Enabled = True
        End If
        checkDbConn()
        With selectCmd
            .CommandText = "SELECT * FROM BookInventory WHERE BookID='" & cmbBookID.Text & "'"
            .Connection = dbConn
        End With
        dbRdr = selectCmd.ExecuteReader
        If dbRdr.Read Then
            Try
                lblErrorBookID.Visible = False
                lblBTitle.Text = dbRdr.GetString(1)
                lblBPublisher.Text = dbRdr.GetString(2)
                lblBAuthor.Text = dbRdr.GetString(3)
                lblBCategory.Text = dbRdr.GetString(4)
                lblBPublishedYear.Text = dbRdr.GetValue(5)
                lblBNoofAvailableBook.Text = dbRdr.GetValue(7)
            Catch ex As Exception

            End Try
            If lblErrorBorrowerID.Visible = False And Not cmbBMemberID.Text = "" Then
                btnAddBooktoBList.Enabled = True
            Else

            End If
        Else

            lblErrorBookID.Visible = True
            lblBTitle.Text = ""
            lblBPublisher.Text = ""
            lblBAuthor.Text = ""
            lblBCategory.Text = ""
            lblBPublishedYear.Text = ""
            lblBNoofAvailableBook.Text = ""
            btnAddBooktoBList.Enabled = False
        End If
        dbRdr.Close()
        closeDbConn()
       
    End Sub

    Private Sub btnAddBooktoBList_Click(sender As Object, e As EventArgs) Handles btnAddBooktoBList.Click
        If cmbBookID.Text = "" Then
            MessageBox.Show("No selected item")
        Else
            Dim trnsctnoexist As Boolean = False
            checkDbConn()
            With selectCmd
                .CommandText = "SELECT TransactionNo FROM BorrowBook WHERE TransactionNo = '" & lblBTransactionNo.Text & "'"
                .Connection = dbConn
            End With
            dbRdr = selectCmd.ExecuteReader
            If dbRdr.Read Then
                Try
                    trnsctnoexist = True
                Catch ex As Exception

                End Try
            Else
                trnsctnoexist = False
            End If

            If trnsctnoexist = False Then
                checkDbConn()
                With insertCmd
                    .CommandText = "INSERT INTO BorrowBook(TransactionNo,MemberID,TransactionDate,DueDate,Penalty) VALUES('" & lblBTransactionNo.Text & _
                                   "', '" & cmbBMemberID.Text & "', '" & lblBTransactionDate.Text & _
                                   "', '" & lblBDueDate.Text & "', 0.00) "
                    .Connection = dbConn
                    .ExecuteNonQuery()
                End With
                closeDbConn()
            End If

            checkDbConn()
            With insertCmd
                .CommandText = "INSERT INTO BorrowedBookList VALUES('" & lblBTransactionNo.Text & _
                               "', '" & cmbBookID.Text & "', '" & lblBTitle.Text & _
                               "', '" & lblBPublisher.Text & "', '" & lblBCategory.Text & _
                               "', " & Val(lblBPublishedYear.Text) & ", '" & cmbBMemberID.Text & "')"
                .Connection = dbConn
                .ExecuteNonQuery()
            End With

            closeDbConn()

            
            cmbBookID.Items.Remove(cmbBookID.Text)

            borrowbooklistQuery = "SELECT * FROM BorrowedBookList WHERE TransactionNo = '" & lblBTransactionNo.Text & "'"
            islstvwBorrowBookListUpdated = True
            loadBorrowBookListView()
            cmbBookID.Text = ""
            DisableAll()
            btnAddBooktoBList.Enabled = False
            ComputeTotalAmount()
            txtBPayment.Enabled = True
        End If

        
    End Sub

    'LOAD THE BORROWEDLISTVIEW
    Public Sub loadBorrowBookListView()
        If islstvwBorrowBookListUpdated = True Then
            checkDbConn()
            lstvwBorrowBookList.MultiSelect = False
            lstvwBorrowBookList.GridLines = True
            lstvwBorrowBookList.FullRowSelect = True
            lstvwBorrowBookList.View = View.Details
            lstvwBorrowBookList.Items.Clear()
            lstvwBorrowBookList.Clear()

            lstvwBorrowBookList.Columns.Add("Item Code", 100, HorizontalAlignment.Left)
            lstvwBorrowBookList.Columns.Add("Title", 380, HorizontalAlignment.Left)
            lstvwBorrowBookList.Columns.Add("Publisher", 150, HorizontalAlignment.Left)
            lstvwBorrowBookList.Columns.Add("Category", 100, HorizontalAlignment.Left)
            lstvwBorrowBookList.Columns.Add("Year Published", 100, HorizontalAlignment.Left)


            With selectCmd
                .CommandText = borrowbooklistQuery
            End With
            Dim dbTbl As New DataTable
            dbTbl.TableName = "BorrowedBookList"

            With dbAdptr
                .SelectCommand = selectCmd
                .SelectCommand.Connection = dbConn
                .Fill(dbTbl)
            End With

            For i = 0 To dbTbl.Rows.Count - 1
                With lstvwBorrowBookList
                    .Items.Add(dbTbl.Rows(i)("BookID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(dbTbl.Rows(i)("Title"))
                        .Add(dbTbl.Rows(i)("Publisher"))
                        .Add(dbTbl.Rows(i)("Category"))
                        .Add(dbTbl.Rows(i)("YearPublished"))
                    End With
                End With
            Next
        End If
        closeDbConn()
        islstvwBookInventoryUpdated = False
    End Sub

    'FUNCTION TO DISABLE BUTTONS AND ALL UNNESSARY OBJECT
    Public Sub DisableAll()
        cmbBMemberID.Enabled = False
        btnBookInventory.Enabled = False
        btnReturnBook.Enabled = False
        btnManageMembers.Enabled = False
        btnBorrowersList.Enabled = False
        btnLogout.Enabled = False
        btnBorrowBook.Enabled = False

        If lstvwBorrowBookList.Items.Count >= 3 Then
            cmbBookID.Enabled = False
            btnAddBooktoBList.Enabled = False
        Else
            btnAddBooktoBList.Enabled = True
        End If
        lblBTitle.Text = ""
        lblBPublisher.Text = ""
        lblBAuthor.Text = ""
        lblBCategory.Text = ""
        lblBPublishedYear.Text = ""
        lblBNoofAvailableBook.Text = ""
        lblErrorBookID.Visible = False
    End Sub

    'UPDATE THE BOOK INVENTORY INCREASE THE NO OF BORROWED BOOKS DECREASE THE NO OF AVAILABLE BOOKS 
    Public Sub UpdateAvailableBook()
        For i = 0 To lstvwBorrowBookList.Items.Count - 1
            Dim noavailable As Integer
            Dim noborrow As Integer
            checkDbConn()
            With selectCmd
                .CommandText = "SELECT NoofAvailableBook, NoofBorrowedBook FROM BookInventory WHERE BookID = '" & lstvwBorrowBookList.Items(i).Text & "'"
                .Connection = dbConn
            End With
            dbRdr = selectCmd.ExecuteReader
            If dbRdr.Read Then
                Try
                    noavailable = dbRdr.GetValue(0)
                    noborrow = dbRdr.GetValue(1)
                Catch ex As Exception

                End Try
            End If
            closeDbConn()

            noavailable -= 1
            noborrow += 1
            checkDbConn()
            With updateCmd
                .CommandText = "UPDATE BookInventory SET NoofAvailableBook ='" & noavailable & "', NoofBorrowedBook ='" & noborrow & "' WHERE BookID = '" & lstvwBorrowBookList.Items(i).Text & "'"
                .ExecuteNonQuery()
            End With
            islstvwBookInventoryUpdated = True
            bookInventoryQuery = "SELECT * FROM BookInventory"
            loadBookInventoryListView()



            Dim membernoofborrowedbook As Integer

            checkDbConn()
            With selectCmd
                .CommandText = "SELECT NoofBorrowedBook FROM MemberList WHERE MemberID = '" & cmbBMemberID.Text & "'"
                .Connection = dbConn
            End With
            dbRdr = selectCmd.ExecuteReader
            If dbRdr.Read Then
                Try
                    membernoofborrowedbook = Val(dbRdr.GetValue(0))
                Catch ex As Exception

                End Try
            Else

            End If
            closeDbConn()
            membernoofborrowedbook += 1
            checkDbConn()
            With updateCmd
                .CommandText = "UPDATE MemberList SET NoofBorrowedBook = '" & membernoofborrowedbook & "' WHERE MemberID = '" & cmbBMemberID.Text & "'"
                .ExecuteNonQuery()
            End With
            closeDbConn()

        Next
    End Sub

    'ADD THE TOTAL AMOUNT
    Public Sub ComputeTotalAmount()
        lblBTotalAmt.Text = FormatCurrency(Val(lstvwBorrowBookList.Items.Count * 30), 2)
        totalamount = Val(lstvwBorrowBookList.Items.Count * 30)
    End Sub

    Private Sub txtBPayment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBPayment.KeyPress
        If (Asc(UCase(e.KeyChar)) < 48 Or Asc(UCase(e.KeyChar)) > 57) And Asc((e.KeyChar)) <> 8 And Asc((e.KeyChar)) <> 46 Then
            e.KeyChar = ChrW(0)
        End If
    End Sub

    'COMPUTE THE CHANGE
    Private Sub txtBPayment_TextChanged(sender As Object, e As EventArgs) Handles txtBPayment.TextChanged
        lblErrorBookID.Visible = False
        If lstvwBorrowBookList.Items.Count > 0 Then
            If Val(txtBPayment.Text) >= totalamount Then
                lblBChange.Text = FormatCurrency((Val(txtBPayment.Text) - totalamount), 2)
                lblErrorBNotEnough.Visible = False
                btnBorrowBookReceipt.Enabled = True
            Else
                lblErrorBNotEnough.Visible = True
                btnBorrowBookReceipt.Enabled = False
            End If
        End If
    End Sub

    Private Sub btnBorrowBookPay_Click(sender As Object, e As EventArgs) Handles btnBorrowBookReceipt.Click
        UpdateAvailableBook()
        txtBPayment.Enabled = False
        checkDbConn()
        With insertCmd
            .CommandText = "INSERT INTO BorrowPayment VALUES('" & lblBTransactionNo.Text & _
                       "', '" & lblBTotalAmt.Text & "', '" & txtBPayment.Text & "', '" & lblBChange.Text & "')"
            .Connection = dbConn
            .ExecuteNonQuery()
        End With
        closeDbConn()
        BorrowBookReceipt.Show()

        btnBookInventory.Enabled = True
        btnReturnBook.Enabled = True
        btnManageMembers.Enabled = True
        btnBorrowersList.Enabled = True
        btnBorrowBook.Enabled = True
        btnBorrowBookReceipt.Enabled = False
        btnLogout.Enabled = True
    End Sub
 



    '================================================================================================
    ' RETURN BOOK
    '================================================================================================
    Private Sub btnReturnBook_Click(sender As Object, e As EventArgs) Handles btnReturnBook.Click
        tabGrp.SelectTab(3)
        pnlPenalty.Enabled = False
        lblRBReturnDate.Text = Date.Now.Month & "/" & Date.Now.Day & "/" & Date.Now.Year

        cmbRBTransactionNo.Text = ""
        lstvwReturnBookList.Items.Clear()
        returnBookLoad()
        btnReturnBooks.Enabled = False
        cmbRBTransactionNo.Enabled = True
    End Sub

    Public Sub returnBookLoad()
        cmbRBTransactionNo.Items.Clear()
        lblRBDateBorrowed.Text = ""
        lblRBDueDate.Text = ""
        lblRBBorrower.Text = ""
        lblRBChange.Text = ""
        lblRBPenalty.Text = ""

        'TRANSACTION NO LOAD
        checkDbConn()
        With selectCmd
            .CommandText = "SELECT * FROM BorrowBook"
            .Connection = dbConn
        End With
        Dim dbTbl As New DataTable
        dbTbl.TableName = "BorrowBook"

        With dbAdptr
            .SelectCommand = selectCmd
            .SelectCommand.Connection = dbConn
            .Fill(dbTbl)
        End With

        For i = 0 To dbTbl.Rows.Count - 1
            cmbRBTransactionNo.Items.Add(dbTbl.Rows(i)("TransactionNo"))
        Next
        closeDbConn()




    End Sub

    Private Sub cmbRBTransactionNo_TextChanged(sender As Object, e As EventArgs) Handles cmbRBTransactionNo.TextChanged

        checkDbConn()
        With selectCmd
            .CommandText = "SELECT * FROM BorrowBook WHERE TransactionNo='" & cmbRBTransactionNo.Text & "'"
            .Connection = dbConn
        End With
        dbRdr = selectCmd.ExecuteReader
        If dbRdr.Read Then
            Try

                lblRBDateBorrowed.Text = dbRdr.GetString(2)
                lblRBDueDate.Text = dbRdr.GetString(3)
                borrower = dbRdr.GetString(1)
                returnbookBorrowerID = dbRdr.GetString(1)
                If lblRBPenalty.Text = "Php0.00" Then
                    pnlPenalty.Enabled = False
                    btnReturnBook.Enabled = True
                Else
                    pnlPenalty.Enabled = True
                End If
            Catch ex As Exception

            End Try
        Else
            pnlPenalty.Enabled = True
            btnReturnBook.Enabled = True
        End If

        dbRdr.Close()
        closeDbConn()


        checkDbConn()
        With selectCmd
            .CommandText = "SELECT * FROM MemberList WHERE MemberID='" & borrower & "'"
            .Connection = dbConn
        End With
        dbRdr = selectCmd.ExecuteReader
        If dbRdr.Read Then
            Try
                lblErrorBorrowerID.Visible = False
                lblRBBorrower.Text = dbRdr.GetString(1) & ", " & dbRdr.GetString(2) & " " & dbRdr.GetString(3)
            Catch ex As Exception

            End Try

    
        End If
        dbRdr.Close()
        closeDbConn()

        returnbooklistQuery = "SELECT * FROM BorrowedBooklist WHERE TransactionNo='" & cmbRBTransactionNo.Text & "'"
        islstvwReturnBookListUpdated = True
        loadReturnBookListView()
        Dim date1 As Date
        Dim date2 As Date
        Dim datedifference As Integer
        If cmbRBTransactionNo.Text <> "" Then
            date1 = lblRBDueDate.Text
        End If
        date2 = lblRBReturnDate.Text
        datedifference = DateDiff(DateInterval.Day, date1, date2)
        If datedifference > 0 Then
            lblRBDueDate.BackColor = Color.Transparent
            lblRBDueDate.ForeColor = Color.Red
            lblRBPenalty.ForeColor = Color.Red
            Dim NoofSunday As Integer = 0
            For i = 0 To datedifference
                If date1.DayOfWeek = DayOfWeek.Sunday Then
                    NoofSunday += 1
                End If
                date1 = date1.AddDays(1)
            Next
            datedifference -= NoofSunday

            penaltytotalamt = datedifference * 50
            lblRBPenalty.Text = FormatCurrency(penaltytotalamt, 2)
        Else
            lblRBPenalty.ForeColor = Color.DimGray
            lblRBPenalty.Text = "Php0.00"
            lblRBDueDate.BackColor = Color.DimGray
            lblRBDueDate.ForeColor = Color.White

        End If
        'TRANSACTION DATE AND DUE DATE




        
    End Sub


    Public Sub loadReturnBookListView()
        If islstvwReturnBookListUpdated = True Then
            checkDbConn()
            lstvwReturnBookList.MultiSelect = False
            lstvwReturnBookList.GridLines = True
            lstvwReturnBookList.FullRowSelect = True
            lstvwReturnBookList.View = View.Details
            lstvwReturnBookList.Items.Clear()
            lstvwReturnBookList.Clear()

            lstvwReturnBookList.Columns.Add("Item Code", 100, HorizontalAlignment.Left)
            lstvwReturnBookList.Columns.Add("Title", 350, HorizontalAlignment.Left)
            lstvwReturnBookList.Columns.Add("Publisher", 150, HorizontalAlignment.Left)
            lstvwReturnBookList.Columns.Add("Category", 100, HorizontalAlignment.Left)
            lstvwReturnBookList.Columns.Add("Year Published", 120, HorizontalAlignment.Left)


            With selectCmd
                .CommandText = returnbooklistQuery
            End With
            Dim dbTbl As New DataTable
            dbTbl.TableName = "BorrowedBookList"

            With dbAdptr
                .SelectCommand = selectCmd
                .SelectCommand.Connection = dbConn
                .Fill(dbTbl)
            End With

            For i = 0 To dbTbl.Rows.Count - 1
                With lstvwReturnBookList
                    .Items.Add(dbTbl.Rows(i)("BookID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(dbTbl.Rows(i)("Title"))
                        .Add(dbTbl.Rows(i)("Publisher"))
                        .Add(dbTbl.Rows(i)("Category"))
                        .Add(dbTbl.Rows(i)("YearPublished"))
                    End With
                End With
            Next
        End If
        closeDbConn()
        islstvwReturnBookListUpdated = False
    End Sub

    Private Sub txtRBPayment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRBPayment.KeyPress
        If (Asc(UCase(e.KeyChar)) < 48 Or Asc(UCase(e.KeyChar)) > 57) And Asc((e.KeyChar)) <> 8 And Asc((e.KeyChar)) <> 46 Then
            e.KeyChar = ChrW(0)
        End If
    End Sub

    Private Sub txtRBPayment_TextChanged(sender As Object, e As EventArgs) Handles txtRBPayment.TextChanged
        If lstvwReturnBookList.Items.Count > 0 Then
            If Val(txtRBPayment.Text) >= penaltytotalamt Then
                lblRBChange.Text = FormatCurrency((Val(txtRBPayment.Text) - penaltytotalamt), 2)
                lblErrorRBNotEnough.Visible = False
                btnReturnBooks.Enabled = True

            Else
                lblErrorRBNotEnough.Visible = True
                btnReturnBooks.Enabled = False
            End If
        End If
    End Sub











    '================================================================================================
    ' BORROWERS LIST
    '================================================================================================
    'MEMBER LIST CLICKED
     Private Sub btnBorrowersList_Click(sender As Object, e As EventArgs) Handles btnBorrowersList.Click
        tabGrp.SelectTab(5)
        lstvwBooksBorrowed.Items.Clear()
        borrowersListLoad()
    End Sub

    Public Sub borrowersListLoad()
        islstvwBorrowersListUpdated = True
        borrowersListQuery = "SELECT * FROM MemberList WHERE NoofBorrowedBook > 0"
        islstvwBorrowersListUpdated = True
        loadBorrowersListView()

    End Sub

    'LOAD BORROWER LIST VIEW
    Public Sub loadBorrowersListView()
        If islstvwBorrowersListUpdated = True Then
            checkDbConn()
            lstvwBorrowersList.MultiSelect = False
            lstvwBorrowersList.GridLines = True
            lstvwBorrowersList.FullRowSelect = True
            lstvwBorrowersList.View = View.Details
            lstvwBorrowersList.Items.Clear()
            lstvwBorrowersList.Clear()

            lstvwBorrowersList.Columns.Add("Member ID", 100, HorizontalAlignment.Left)
            lstvwBorrowersList.Columns.Add("Last Name", 250, HorizontalAlignment.Left)
            lstvwBorrowersList.Columns.Add("First Name", 250, HorizontalAlignment.Left)
            lstvwBorrowersList.Columns.Add("MI", 80, HorizontalAlignment.Left)
            lstvwBorrowersList.Columns.Add("No of Borrowed Books", 150, HorizontalAlignment.Left)
            With selectCmd
                .CommandText = borrowersListQuery
            End With
            Dim dbTbl As New DataTable
            dbTbl.TableName = "MemberList"

            With dbAdptr
                .SelectCommand = selectCmd
                .SelectCommand.Connection = dbConn
                .Fill(dbTbl)
            End With

            For i = 0 To dbTbl.Rows.Count - 1
                With lstvwBorrowersList
                    .Items.Add(dbTbl.Rows(i)("MemberID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(dbTbl.Rows(i)("LastName"))
                        .Add(dbTbl.Rows(i)("FirstName"))
                        .Add(dbTbl.Rows(i)("MI"))
                        .Add(dbTbl.Rows(i)("NoofBorrowedBook"))
                    End With
                End With
            Next
        End If
        closeDbConn()
        islstvwBorrowersListUpdated = True
    End Sub
   

    Public Sub ReturnUpdateAvailableBook()
        For i = 0 To lstvwReturnBookList.Items.Count - 1
            Dim noavailable As Integer
            Dim noborrow As Integer
            checkDbConn()
            With selectCmd
                .CommandText = "SELECT NoofAvailableBook, NoofBorrowedBook FROM BookInventory WHERE BookID = '" & lstvwReturnBookList.Items(i).Text & "'"
                .Connection = dbConn
            End With
            dbRdr = selectCmd.ExecuteReader
            If dbRdr.Read Then
                Try
                    noavailable = dbRdr.GetValue(0)
                    noborrow = dbRdr.GetValue(1)
                Catch ex As Exception

                End Try
            End If
            closeDbConn()

            noavailable += 1
            noborrow -= 1
            checkDbConn()
            With updateCmd
                .CommandText = "UPDATE BookInventory SET NoofAvailableBook ='" & noavailable & "', NoofBorrowedBook ='" & noborrow & "' WHERE BookID = '" & lstvwReturnBookList.Items(i).Text & "'"
                .ExecuteNonQuery()
            End With
            islstvwBookInventoryUpdated = True
            bookInventoryQuery = "SELECT * FROM BookInventory"
            loadBookInventoryListView()
            closeDbConn()




            Dim membernoofborrowedbook As Integer = 0
            checkDbConn()
            With selectCmd
                .CommandText = "SELECT NoofBorrowedBook FROM MemberList WHERE MemberID = '" & returnbookBorrowerID & "'"
                .Connection = dbConn
            End With
            dbRdr = selectCmd.ExecuteReader
            If dbRdr.Read Then
                Try
                    membernoofborrowedbook = Val(dbRdr.GetValue(0))
                Catch ex As Exception

                End Try
            Else

            End If
            closeDbConn()
            membernoofborrowedbook -= 1

            checkDbConn()
            With updateCmd
                .CommandText = "UPDATE MemberList SET NoofBorrowedBook = '" & membernoofborrowedbook & "' WHERE MemberID = '" & returnbookBorrowerID & "'"
                .ExecuteNonQuery()
            End With
            closeDbConn()

        Next


     
    End Sub

    Public Sub deletefromBorrowedList()
        checkDbConn()
        With deleteCmd
            .CommandText = "DELETE FROM BorrowedBookList WHERE TransactionNo= '" & cmbRBTransactionNo.Text & "'"
            .Connection = dbConn
            .ExecuteNonQuery()
        End With
        closeDbConn()

        checkDbConn()
        With deleteCmd
            .CommandText = "DELETE FROM BorrowBook WHERE TransactionNo= '" & cmbRBTransactionNo.Text & "'"
            .Connection = dbConn
            .ExecuteNonQuery()
        End With
        closeDbConn()


    End Sub

    Private Sub btnReturnBooks_Click(sender As Object, e As EventArgs) Handles btnReturnBooks.Click
        btnReturnBooks.Enabled = False
        If txtRBPayment.Text = "" And Not lblRBPenalty.Text = "Php0.00" Then
            MessageBox.Show("Enter payment!")


        ElseIf lblErrorRBNotEnough.Visible = False Then
            If txtRBPayment.Text <> "" Then
                islstvwReceiptReturnBookListUpdated = True
                ReturnBookReceipt.Show()
                ReturnBookReceipt.loadReceiptReturnBookListView()
            End If
            ReturnUpdateAvailableBook()
            deletefromBorrowedList()
            cmbRBTransactionNo.Text = ""
            lblRBBorrower.Text = ""
            lblRBDateBorrowed.Text = ""
            lblRBDueDate.Text = ""
            lblRBPenalty.Text = ""
            lblRBReturnDate.Text = ""
            txtRBPayment.Text = ""
        End If
        btnReturnBooks.Enabled = False
        cmbRBTransactionNo.Enabled = False
    End Sub

    Private Sub cmbRBTransactionNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRBTransactionNo.SelectedIndexChanged
        If lstvwReturnBookList.Items.Count > 0 And cmbRBTransactionNo.Text <> "" Then
            btnReturnBooks.Enabled = True
        End If
    End Sub

    Private Sub lstvwBorrowersList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvwBorrowersList.SelectedIndexChanged
        If lstvwBorrowersList.SelectedItems.Count > 0 Then
            islstvwBooksBorrowedUpdated = True
            booksborrowedQuery = "SELECT * FROM BorrowedBookList WHERE MemberID = '" & lstvwBorrowersList.SelectedItems(0).Text & "'"
            loadBooksBorrowed()
        End If
    End Sub


    Public Sub loadBooksBorrowed()
        If islstvwBooksBorrowedUpdated = True Then
            checkDbConn()
            lstvwBooksBorrowed.MultiSelect = False
            lstvwBooksBorrowed.GridLines = True
            lstvwBooksBorrowed.FullRowSelect = True
            lstvwBooksBorrowed.View = View.Details
            lstvwBooksBorrowed.Items.Clear()
            lstvwBooksBorrowed.Clear()

            lstvwBooksBorrowed.Columns.Add("Transaction No", 150, HorizontalAlignment.Left)
            lstvwBooksBorrowed.Columns.Add("Book ID", 100, HorizontalAlignment.Left)
            lstvwBooksBorrowed.Columns.Add("Title", 350, HorizontalAlignment.Left)
            lstvwBooksBorrowed.Columns.Add("Publisher", 150, HorizontalAlignment.Left)
            lstvwBooksBorrowed.Columns.Add("Category", 125, HorizontalAlignment.Left)
            lstvwBooksBorrowed.Columns.Add("Year Published", 150, HorizontalAlignment.Left)
            With selectCmd
                .CommandText = booksborrowedQuery
            End With
            Dim dbTbl As New DataTable
            dbTbl.TableName = "BorrowedBookList"

            With dbAdptr
                .SelectCommand = selectCmd
                .SelectCommand.Connection = dbConn
                .Fill(dbTbl)
            End With

            For i = 0 To dbTbl.Rows.Count - 1
                With lstvwBooksBorrowed
                    .Items.Add(dbTbl.Rows(i)("TransactionNo"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(dbTbl.Rows(i)("BookID"))
                        .Add(dbTbl.Rows(i)("Title"))
                        .Add(dbTbl.Rows(i)("Publisher"))
                        .Add(dbTbl.Rows(i)("Category"))
                        .Add(dbTbl.Rows(i)("YearPublished"))
                    End With
                End With
            Next
        End If
        closeDbConn()
        islstvwBooksBorrowedUpdated = False
    End Sub



    Private Sub txtSearchBorrower_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBorrower.TextChanged
        'islstvwBorrowersListUpdated = True
        'borrowersListQuery = "SELECT * FROM MemberList WHERE NoofBorrowedBook > 0 AND (LastName like '" & _
        '                     txtSearchBorrower.Text & "%' OR FirstName like '" & txtSearchBorrower.Text & "%' OR MemberID = '%" & txtSearchBorrower.Text & "%') "
        'islstvwBorrowersListUpdated = True
        'loadBorrowersListView()
        islstvwBorrowersListUpdated = True
        If cmbBorrowerSearch.Text <> "" Then
            If cmbBorrowerSearch.Text = "MemberID" Then
                borrowersListQuery = "SELECT * FROM MemberList WHERE NoofBorrowedBook > 0 and  MemberID like '" & txtSearchBorrower.Text & "%'"
            ElseIf cmbBorrowerSearch.Text = "Lastname" Then
                borrowersListQuery = "SELECT * FROM MemberList WHERE NoofBorrowedBook > 0 and LastName like '" & txtSearchBorrower.Text & "%'"
            ElseIf cmbBorrowerSearch.Text = "Firstname" Then
                borrowersListQuery = "SELECT * FROM MemberList WHERE NoofBorrowedBook > 0 and FirstName like '" & txtSearchBorrower.Text & "%'"
            ElseIf cmbBorrowerSearch.Text = "MI" Then
                borrowersListQuery = "SELECT * FROM MemberList WHERE NoofBorrowedBook > 0 and MI like '" & txtSearchBorrower.Text & "%'"
            ElseIf cmbBorrowerSearch.Text = "Address" Then
                borrowersListQuery = "SELECT * FROM MemberList WHERE NoofBorrowedBook > 0 and Address like '%" & txtSearchBorrower.Text & "%'"
            ElseIf cmbBorrowerSearch.Text = "ContactNo" Then
                borrowersListQuery = "SELECT * FROM MemberList WHERE NoofBorrowedBook > 0 and ContactNo like '" & txtSearchBorrower.Text & "%'"
            End If
            checkDbConn()
            With selectCmd
                .CommandText = borrowersListQuery
                .Connection = dbConn
                .ExecuteNonQuery()
            End With
            closeDbConn()
            islstvwBorrowersListUpdated = True
            loadBorrowersListView()
        Else
            MessageBox.Show("Please choose a category to search for")
        End If


    End Sub

    Private Sub tmrDateTime_Tick(sender As Object, e As EventArgs) Handles tmrDateTime.Tick
        lblDateNow.Text = Date.Now.ToShortDateString
        lblCurrentTime.Text = Date.Now.ToLongTimeString
    End Sub


   
    Private Sub lstvwBorrowBookList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvwBorrowBookList.SelectedIndexChanged
        If lstvwBorrowBookList.SelectedItems.Count > 0 Then
            btnAddBooktoBList.Enabled = False
            btnRemoveBooktoBList.Enabled = True
            cmbBookID.Text = lstvwBorrowBookList.SelectedItems(0).Text
            lblBTitle.Text = lstvwBorrowBookList.SelectedItems(0).SubItems(1).Text
            lblBCategory.Text = lstvwBorrowBookList.SelectedItems(0).SubItems(3).Text
            lblBPublisher.Text = lstvwBorrowBookList.SelectedItems(0).SubItems(2).Text
            lblBPublishedYear.Text = lstvwBorrowBookList.SelectedItems(0).SubItems(4).Text

            checkDbConn()
            With selectCmd
                .CommandText = "SELECT * FROM BookInventory WHERE BookID='" & cmbBookID.Text & "'"
                .Connection = dbConn
            End With
            dbRdr = selectCmd.ExecuteReader
            If dbRdr.Read Then
                Try
                    lblErrorBookID.Visible = False
                    lblBAuthor.Text = dbRdr.GetString(3)
                    lblBNoofAvailableBook.Text = dbRdr.GetValue(7)
                Catch ex As Exception

                End Try
                If lblErrorBorrowerID.Visible = False And Not cmbBMemberID.Text = "" Then
                    btnAddBooktoBList.Enabled = True
                End If
            Else

                lblErrorBookID.Visible = True
                lblBTitle.Text = ""
                lblBPublisher.Text = ""
                lblBAuthor.Text = ""
                lblBCategory.Text = ""
                lblBPublishedYear.Text = ""
                lblBNoofAvailableBook.Text = ""
                btnAddBooktoBList.Enabled = False
            End If
            dbRdr.Close()
            closeDbConn()
        Else
            btnRemoveBooktoBList.Enabled = False
            btnAddBooktoBList.Enabled = True
        End If

        
    End Sub

    Private Sub cmbBookID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBookID.SelectedIndexChanged

    End Sub

   
    Private Sub btnRemoveBooktoBList_Click(sender As Object, e As EventArgs) Handles btnRemoveBooktoBList.Click
        If lstvwBorrowBookList.SelectedItems.Count > 0 Then
            checkDbConn()
            With deleteCmd
                .CommandText = "DELETE FROM BorrowedBookList WHERE BookID ='" & lstvwBorrowBookList.SelectedItems(0).Text & "'"
                .Connection = dbConn
                .ExecuteNonQuery()
            End With
            closeDbConn()
            cmbBookID.Items.Add(lstvwBorrowBookList.SelectedItems(0).Text)
            cmbBookID.Sorted = True

            borrowbooklistQuery = "SELECT * FROM BorrowedBookList WHERE TransactionNo = '" & lblBTransactionNo.Text & "'"
            islstvwBorrowBookListUpdated = True
            loadBorrowBookListView()
            cmbBookID.Text = ""
            ComputeTotalAmount()
        Else
            MessageBox.Show("No selected book")
        End If
        btnRemoveBooktoBList.Enabled = False

        If lstvwBorrowBookList.Items.Count > 0 Then
            cmbBookID.Enabled = True
        End If



    End Sub

    
    Private Sub cmbBorrowerSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBorrowerSearch.SelectedIndexChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBookInventorySearch.SelectedIndexChanged

    End Sub
End Class