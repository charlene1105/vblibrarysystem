Public Class BookList

    Private Sub lstvwBookInventory_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstvwBookInventory.MouseDoubleClick
        If lstvwBookInventory.SelectedItems.Count = 1 Then

        End If
    End Sub

    Private Sub lstvwBookInventory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstvwBookInventory.SelectedIndexChanged

    End Sub
End Class