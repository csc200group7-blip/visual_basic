Public Class InvoiceGenHelpers
    Public Shared Function CalculateTotal(items As List(Of Dictionary(Of String, Decimal))) As Decimal
        Dim total As Decimal = 0.00
        For Each item As Dictionary(Of String, Decimal) In items
            total += item("Quantity") * item("Price")
        Next
        Return total
    End Function

    Public Shared Function CheckItemsExists(ItemList As DataGridView, NewItem As String, price As Integer) As Object
        Dim RowIndex As Integer = 0
        For Each row As DataGridViewRow In ItemList.Rows
            If row.Cells(1).Value = NewItem And row.Cells(3).Value = price Then
                Return RowIndex
            End If
            RowIndex += 1
        Next
        Return False
    End Function

    Public Shared Sub UpdateItemQty(ItemList As DataGridView, ItemRowIndex As String, NewQty As Integer)
        Debug.WriteLine(ItemRowIndex, "Row index")
        ItemList.Rows(ItemRowIndex).Cells(2).Value += NewQty
    End Sub
End Class
