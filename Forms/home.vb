Public Class Form1
    Dim itemCount As Integer = 0
    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles BtnAddItem.Click
        ' Declare variables for validation
        Dim qty As Integer
        Dim price As Decimal

        itemCount += 1
        'ItemsList.Rows.Add(itemCount, "Book", 5, 2500.0)

        If itemCount > 10 Then
            MessageBox.Show("Exceeded maximum number of items")
            Exit Sub
        End If

        ' Validate inputs
        If txtItem.Text = "" Then
            MessageBox.Show("Please enter item name.")
            txtItem.Focus()
            Exit Sub
        End If

        If Not Integer.TryParse(txtQuantity.Text, qty) Then
            MessageBox.Show("Quantity must be a number.")
            txtQuantity.Focus()
            Exit Sub
        Else
            qty = txtQuantity.Text
        End If

        If qty <= 0 Then
            MessageBox.Show("Quantity must be greater than zero.")
            txtQuantity.Focus()
            Exit Sub
        End If

        If Not Decimal.TryParse(txtPrice.Text, price) Then
            MessageBox.Show("Price must be a number.")
            txtPrice.Focus()
            Exit Sub
        Else
            price = txtPrice.Text
        End If

        If price <= 0 Then
            MessageBox.Show("Price must be greater than zero.")
            txtPrice.Focus()
            Exit Sub
        End If


        Dim ItemExists As Object = InvoiceGenHelpers.CheckItemsExists(ItemsList, txtItem.Text, price)
        Debug.WriteLine(ItemExists, "Items exists")
        If TypeOf ItemExists Is Integer Then
            InvoiceGenHelpers.UpdateItemQty(ItemsList, ItemExists, qty)
        Else
            ' Add row; ActionCol is a button column with UseColumnTextForButtonValue=True
            ItemsList.Rows.Add(itemCount, txtItem.Text, qty, price)
        End If

        ' Clear textboxes for next entry
        txtItem.Clear()
        txtQuantity.Clear()
        txtPrice.Clear()
        txtItem.Focus()
    End Sub

    Private Sub GenInvoiceBtn_Click(sender As Object, e As EventArgs) Handles GenInvoiceBtn.Click
        ' Validate required customer info before navigating
        If String.IsNullOrWhiteSpace(txtCustomerName.Text) Then
            MessageBox.Show("Please enter customer name.")
            txtCustomerName.Focus()
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(txtCustomerAddress.Text) Then
            MessageBox.Show("Please enter customer address.")
            txtCustomerAddress.Focus()
            Exit Sub
        End If

        Dim FormattedItems As New List(Of Dictionary(Of String, Decimal))
        For Each row As DataGridViewRow In ItemsList.Rows
            If row.IsNewRow Then Continue For
            Dim ItemDict As New Dictionary(Of String, Decimal) From {
                {"Quantity", row.Cells(2).Value},
                {"Price", row.Cells(3).Value}
            }
            FormattedItems.Add(ItemDict)
        Next

        InvoiceForm.Total = InvoiceGenHelpers.CalculateTotal(FormattedItems)
        InvoiceForm.CustomerName = txtCustomerName.Text
        InvoiceForm.CustomerAddress = txtCustomerAddress.Text
        Me.Hide()
        InvoiceForm.Show()
    End Sub

    Private Sub ItemsList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemsList.CellContentClick
        ' Handle delete button clicks in the Action column
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = ItemsList.Columns("ActionCol").Index Then
            ItemsList.Rows.RemoveAt(e.RowIndex)
            If itemCount > 0 Then
                itemCount -= 1
            End If
            ' Optionally reindex S/N column
            For i As Integer = 0 To ItemsList.Rows.Count - 1
                ItemsList.Rows(i).Cells(0).Value = i + 1
            Next
        End If
    End Sub

    Private Sub Home_Resize(Sender As Object, e As EventArgs) Handles Me.Paint
        Dim clientW As Integer = Me.ClientSize.Width
        Dim clientH As Integer = Me.ClientSize.Height

        ' Ensure the top list panel spans the width
        itemListPanel.Width = clientW

        ' Center the items grid and size it relative to height
        Dim widthDiff As Integer = itemListPanel.ClientSize.Width - ItemsList.Width
        ItemsList.Left = Math.Max(0, widthDiff \ 2)

        ItemsList.Height = Math.Max(400, clientH \ 2)
        itemListPanel.Height = ItemsList.Height + 35

        ' Stack the info panel below the list panel and stretch it to width
        InfoPanel.Top = itemListPanel.Bottom
        InfoPanel.Width = clientW

        ' Center inner sections within the info panel
        InfoInnerPanel.Left = Math.Max(0, (InfoPanel.ClientSize.Width - InfoInnerPanel.Width) \ 2)
        ItemInfoPanel.Left = Math.Max(0, (InfoPanel.ClientSize.Width - ItemInfoPanel.Width) \ 2)

        ' Center child panels within InfoInnerPanel
        GenPanel.Left = Math.Max(0, (InfoInnerPanel.ClientSize.Width - GenPanel.Width) \ 2)
        AddPanel.Left = Math.Max(0, (InfoInnerPanel.ClientSize.Width - AddPanel.Width) \ 2)
        Panel3.Left = Math.Max(0, (InfoInnerPanel.ClientSize.Width - Panel3.Width) \ 2)
    End Sub

End Class