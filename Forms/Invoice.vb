Public Class InvoiceForm
    Public CustomerName As String
    Public CustomerAddress As String
    Public ContactEmail As String
    Public ContactPhone As Integer


    Private Sub DisplayInvoiceInfo(sender As Object, e As EventArgs) Handles Me.Paint
        lblTotal.Text = "Total Amount: N" & Total.ToString("F2")
    End Sub

    Private Sub ItemsList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemsList.CellContentClick

    End Sub

    Private Sub CustomerAddressLabel_Click(sender As Object, e As EventArgs) Handles CustomerAddressLabel.Click

    End Sub

    'Code to display invoice with total, discount and other infos would be written below


End Class