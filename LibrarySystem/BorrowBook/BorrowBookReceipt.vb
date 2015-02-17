Public Class BorrowBookReceipt
    Public borrowbooklistQuery As String
    Private Sub FormSkin1_Click(sender As Object, e As EventArgs) Handles FormSkin1.Click

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub

    Private Sub BorrowBookReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblBRTransactionNo.Text = MainMenu.lblBTransactionNo.Text
        lblBRBorrowedDate.Text = MainMenu.lblBTransactionDate.Text
        lblBRDueDate.Text = MainMenu.lblBDueDate.Text
        lblBRBorrower.Text = MainMenu.lblBMemberName.Text
        lblBRTotalAmt.Text = MainMenu.lblBTotalAmt.Text
        lblBRPayment.Text = MainMenu.lblBTotalAmt.Text
        lblBRChange.Text = MainMenu.lblBChange.Text
        islstvwBorrowBookListUpdated = True
        borrowbooklistQuery = "SELECT * FROM BorrowedBookList WHERE TransactionNo = '" & lblBRTransactionNo.Text & "'"
        loadBorrowBookListView()

    End Sub

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
            lstvwBorrowBookList.Columns.Add("Title", 250, HorizontalAlignment.Left)
         


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
                    End With
                End With
            Next
        End If
        closeDbConn()
        islstvwBookInventoryUpdated = False
    End Sub
End Class