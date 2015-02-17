Public Class ReturnBookPenaltyPayment
    Public returnbooklistQuery

    Private Property lstvwBorrowBookList As Object

    Private Sub ReturnBookPenaltyPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblRBTransactionNo.Text = MainMenu.cmbRBTransactionNo.Text
        lblRBReturnDate.Text = MainMenu.lblRBReturnDate.Text
        lblRBDueDate.Text = MainMenu.lblRBDueDate.Text
        lblRBBorrower.Text = MainMenu.lblRBBorrower.Text
        lblRBTotalAmt.Text = MainMenu.lblRBPenalty.Text
        lblRBPayment.Text = FormatCurrency(MainMenu.txtRBPayment.Text, 2)
        lblRBChange.Text = MainMenu.lblRBChange.Text
        islstvwReturnBookListUpdated = True
        returnbooklistQuery = "SELECT * FROM BorrowedBookList WHERE TransactionNo = '" & lblRBTransactionNo.Text & "'"
        loadReturnBookListView()

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
            lstvwReturnBookList.Columns.Add("Title", 150, HorizontalAlignment.Left)
          

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
                  
                    End With
                End With
            Next
        End If
        closeDbConn()
        islstvwReturnBookListUpdated = False
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()

    End Sub
End Class