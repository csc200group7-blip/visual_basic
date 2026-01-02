Public Class Form1
    Dim itemCount As Integer = 0
    Private Sub BtnAddItem_Click(sender As Object, e As EventArgs) Handles BtnAddItem.Click
        ' Declare variables for validation
        Dim qty As Integer
        Dim price As Decimal

        itemCount += 1
        ItemsList.Rows.Add(itemCount, "Book", 5, 2500.0)

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
            MessageBox.Show("Please enter a valid quantity.")
            txtQuantity.Focus()
            Exit Sub
        End If

        If qty <= 0 Then
            MessageBox.Show("Quantity must be greater than zero.")
            txtQuantity.Focus()
            Exit Sub
        End If

        If Not Decimal.TryParse(txtPrice.Text, price) Then
            MessageBox.Show("Please enter a valid price.")
            txtPrice.Focus()
            Exit Sub
        End If

        If price <= 0 Then
            MessageBox.Show("Price must be greater than zero.")
            txtPrice.Focus()
            Exit Sub
        End If

        ItemsList.Rows.Add(itemCount, txtItem.Text, qty.ToString(), price.ToString("F2"))
        ' Clear textboxes for next entry
        txtItem.Clear()
        txtQuantity.Clear()
        txtPrice.Clear()
        txtItem.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GenInvoiceBtn.Click
        For Each item As DataGridViewRow In ItemsList.Rows
            Debug.WriteLine(item.Cells(0))
        Next
    End Sub
End Class
