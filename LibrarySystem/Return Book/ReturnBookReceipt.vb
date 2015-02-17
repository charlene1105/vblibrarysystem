Public Class ReturnBookReceipt
    Public returnbooklistQuery
    Private Sub ReturnBookReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRBTransactionNo.Text = MainMenu.cmbRBTransactionNo.Text
        lblRBReturnDate.Text = MainMenu.lblRBReturnDate.Text
        lblRBDueDate.Text = MainMenu.lblRBDueDate.Text
        lblRBBorrower.Text = MainMenu.lblRBBorrower.Text
        lblRBTotalAmt.Text = MainMenu.lblRBPenalty.Text
        lblRBPayment.Text = FormatCurrency(MainMenu.txtRBPayment.Text, 2)
        lblRBChange.Text = MainMenu.lblRBChange.Text

    End Sub

    Public Sub loadReceiptReturnBookListView()

        returnbooklistQuery = "SELECT * FROM BorrowedBookList WHERE TransactionNo = '" & lblRBTransactionNo.Text & "'"
        If islstvwReceiptReturnBookListUpdated = True Then
            checkDbConn()
            lstvwReceiptReturnBookList.MultiSelect = False
            lstvwReceiptReturnBookList.GridLines = True
            lstvwReceiptReturnBookList.FullRowSelect = True
            lstvwReceiptReturnBookList.View = View.Details
            lstvwReceiptReturnBookList.Items.Clear()
            lstvwReceiptReturnBookList.Clear()

            lstvwReceiptReturnBookList.Columns.Add("Item Code", 100, HorizontalAlignment.Left)
            lstvwReceiptReturnBookList.Columns.Add("Title", 250, HorizontalAlignment.Left)


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
                With lstvwReceiptReturnBookList
                    .Items.Add(dbTbl.Rows(i)("BookID"))
                    With .Items(.Items.Count - 1).SubItems
                        .Add(dbTbl.Rows(i)("Title"))

                    End With
                End With
            Next
        End If
        closeDbConn()
        islstvwReceiptReturnBookListUpdated = False
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()
    End Sub
End Class