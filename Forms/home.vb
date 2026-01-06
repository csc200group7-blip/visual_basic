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
            ItemsList.Rows.Add(itemCount, txtItem.Text, qty, price)
        End If

        ' Clear textboxes for next entry
        txtItem.Clear()
        txtQuantity.Clear()
        txtPrice.Clear()
        txtItem.Focus()
    End Sub

    Private Sub GenInvoiceBtn_Click(sender As Object, e As EventArgs) Handles GenInvoiceBtn.Click
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
        InvoiceForm.ContactEmail = txtContactEmail.Text
        'If TypeOf txtContactPhone.Text Is String Then
        '    InvoiceForm.ContactPhone = txtContactPhone.Text
        'Else
        '    InvoiceForm.ContactPhone = Nothing
        'End If

        Me.Hide()
        InvoiceForm.Show()
    End Sub

    Private Sub Home_Resize(Sender As Object, e As EventArgs) Handles Me.Paint
        Dim PanelWidth = itemListPanel.Size.Width
        Dim ListContainerWidth = ItemsList.Size.Width
        Dim FormSizeHeight = Me.Size.Height

        Dim WidthDiff = PanelWidth - ListContainerWidth

        ItemsList.Left = WidthDiff / 2

        itemListPanel.Height = FormSizeHeight + 35 / 2
        ItemsList.Height = FormSizeHeight / 2
        InfoPanel.Width = Me.Size.Width
        InfoInnerPanel.Left = (InfoPanel.Width - InfoInnerPanel.Width) / 2
        GenPanel.Left = (InfoInnerPanel.Width - GenInvoiceBtn.Width) / 2
        AddPanel.Left = (InfoInnerPanel.Width - BtnAddItem.Width) / 2
        ItemInfoPanel.Left = (InfoInnerPanel.Width - ItemInfoPanel.Width) / 2
    End Sub

End Class