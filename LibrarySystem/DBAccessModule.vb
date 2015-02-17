Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Module DBAccessModule


    Public dbConn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Library.accdb")
    Public selectCmd As New OleDbCommand(dbConn.ConnectionString, dbConn)
    Public insertCmd As New OleDbCommand(dbConn.ConnectionString, dbConn)
    Public deleteCmd As New OleDbCommand(dbConn.ConnectionString, dbConn)
    Public updateCmd As New OleDbCommand(dbConn.ConnectionString, dbConn)
    Public dbRdr As OleDbDataReader
    Public dbAdptr As New OleDbDataAdapter


    Public islstvwBookInventoryUpdated As Boolean
    Public islstvwMemberListUpdated As Boolean
    Public islstvwBorrowBookListUpdated As Boolean
    Public islstvwBorrowersListUpdated As Boolean
    Public islstvwReturnBookListUpdated As Boolean
    Public islstvwBooksBorrowedUpdated As Boolean
    Public islstvwReceiptReturnBookListUpdated As Boolean
    'Check Database Connection
    Public Sub checkDbConn()
        If dbConn.State = ConnectionState.Closed Then
            dbConn.Open()
        End If
    End Sub

    'Close Database Connection
    Public Sub closeDbConn()
        If dbConn.State = ConnectionState.Open Then
            dbConn.Close()
            selectCmd.CommandText = ""
            insertCmd.CommandText = ""
            selectCmd.Dispose()
            insertCmd.Dispose()
            deleteCmd.Dispose()
            dbAdptr.Dispose()
        End If
    End Sub

    Public Function returnStringMonth(ByVal Month As Integer) As String
        Dim monthArray() As String = {"Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"}
        Return monthArray(Month - 1)
    End Function


    Public regex As Regex
    '=========================================================================
    ' Function that check if a string contains a number
    ' return Boolean
    ' true - if it's valid/letters only
    ' false - if it's include special characters and numbers
    '=========================================================================
    Function isValidName(ByRef value As String) As Boolean
        Dim Val As Boolean
        Val = regex.IsMatch(value, "^[A-Za-z. ]*$")
        Return Val
    End Function


    Function isValidNo(ByRef value As String) As Boolean
        Return regex.IsMatch(value, "^[0-9-+]*$")
    End Function

    Function isValidEmail(ByRef email As String) As Boolean
        Return regex.IsMatch(email, "^[A-Za-z0-9@.-]*$")
    End Function

End Module
