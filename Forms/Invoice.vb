Public Class InvoiceForm
    Public CustomerName As String
    Public CustomerAddress As String
    Public ContactEmail As String
    Public ContactPhone As Integer
    Public Total As Decimal

    Private Const VatRate As Decimal = 0.075D
    'Private Const ShippingFlat As Decimal = 1500D

    Private Sub InvoiceForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Header info
        lblInvoiceNo.Text = $"Invoice No: {GenerateInvoiceNumber()}"
        lblDate.Text = $"Date: {DateTime.Now:dd-MMM-yyyy}"

        ' Bill To / Ship To
        lblBillToName.Text = CustomerName
        lblBillToAddress.Text = CustomerAddress

        ' Items from Home form
        If InvoiceItems.Columns.Count = 0 Then
            InvoiceItems.Columns.AddRange(New DataGridViewColumn() {IndexCol, ItemCol, QuantityCol, PriceCol, TotalCol})
        End If

        Try
            InvoiceItems.Rows.Clear()
        Catch
        End Try

        Dim subtotal As Decimal = 0D
        Try
            Dim src As DataGridView = Form1.ItemsList
            Dim snCounter As Integer = 1
            For Each row As DataGridViewRow In src.Rows
                If row.IsNewRow Then Continue For
                Dim itemName As String = If(row.Cells(1).Value, "").ToString()
                Dim qty As Integer = 0
                Integer.TryParse(If(row.Cells(2).Value, 0).ToString(), qty)
                Dim price As Decimal = 0D
                Decimal.TryParse(If(row.Cells(3).Value, 0D).ToString(), price)
                Dim lineTotal As Decimal = qty * price
                subtotal += lineTotal
                InvoiceItems.Rows.Add(snCounter, itemName, qty, price.ToString("N0"), lineTotal.ToString("N0"))
                snCounter += 1
            Next
        Catch
            ' Ignore if source is unavailable
        End Try

        ' Totals
        Dim vat As Decimal = subtotal * VatRate
        Dim grandTotal As Decimal = subtotal + vat

        txtSubtotal.Text = $"Sub Total: {FormatCurrencyNaira(subtotal)}"
        txtTax.Text = $"Tax: {FormatCurrencyNaira(vat)}"
        'txtShipping.Text = FormatCurrencyNaira(ShippingFlat)
        txtTotal.Text = $"Total: {FormatCurrencyNaira(grandTotal)}"

        ' Keep Total field synced for PDF
        Total = grandTotal
    End Sub

    Private Function GenerateInvoiceNumber() As String
        ' Basic example: INV-YYYYMMDD-### (time-based sequence)
        Return $"INV-{DateTime.Now:yyyyMMdd}-001"
    End Function

    Private Function FormatCurrencyNaira(value As Decimal) As String
        Return "₦" & value.ToString("N2")
    End Function

    Private Sub PrintBtn_Click(sender As Object, e As EventArgs) Handles PrintInvoiceBtn.Click
        Try
            ' Build items list for PDF
            Dim itemsForPdf As New List(Of Dictionary(Of String, String))
            For Each r As DataGridViewRow In InvoiceItems.Rows
                If r.IsNewRow Then Continue For
                Dim dict As New Dictionary(Of String, String) From {
                    {"Index", Convert.ToString(r.Cells(0).Value)},
                    {"Item", Convert.ToString(r.Cells(1).Value)},
                    {"Quantity", Convert.ToString(r.Cells(2).Value)},
                    {"Price", Convert.ToString(r.Cells(3).Value)},
                    {"Total", Convert.ToString(r.Cells(4).Value)}
                }
                itemsForPdf.Add(dict)
            Next

            ' Compute totals (as numbers); format plain numbers for template
            Dim subtotal As Decimal = 0D
            For Each r As DataGridViewRow In InvoiceItems.Rows
                If r.IsNewRow Then Continue For
                Dim qty As Integer = 0
                Integer.TryParse(Convert.ToString(r.Cells(2).Value), qty)
                Dim price As Decimal = 0D
                Decimal.TryParse(Convert.ToString(r.Cells(3).Value), price)
                subtotal += qty * price
            Next
            Dim vat As Decimal = subtotal * VatRate
            Dim shipping As Decimal = 0D ' no shipping applied currently
            Dim grandTotal As Decimal = subtotal + vat + shipping

            ' Extract invoice number only (without label prefix)
            Dim invoiceNoText As String = lblInvoiceNo.Text
            Dim invoiceNo As String = invoiceNoText
            Dim colonIdx As Integer = invoiceNoText.IndexOf(":")
            If colonIdx >= 0 AndAlso colonIdx + 1 < invoiceNoText.Length Then
                invoiceNo = invoiceNoText.Substring(colonIdx + 1).Trim()
            End If

            'Dim generator As New PdfGenerator
            PdfGenerator.GeneratePdfFromHtml(
                CustomerName:=CustomerName,
                CustomerAddress:=CustomerAddress,
                ItemsList:=itemsForPdf,
                SubTotal:=subtotal.ToString("F2"),
                VAT:=vat.ToString("F2"),
                ShippingFee:=shipping.ToString("F2"),
                InvoiceNo:=invoiceNo,
                Total:=grandTotal
            )
        Catch ex As Exception
            MessageBox.Show("Failed to generate PDF: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Keep layout responsive on resize/paint
    Private Sub InvoiceForm_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        Dim formW As Integer = Me.ClientSize.Width
        Dim formH As Integer = Me.ClientSize.Height

        ' Stretch main sections across width
        Panel1.Width = formW
        Panel2.Width = formW

        Panel3.Left = 0
        Panel3.Width = formW
        Panel3.Top = Panel2.Bottom + 29
        Panel3.Height = Math.Max(600, formH - Panel3.Top - 10)

        ' Grid width centered with margins, and height calculated from available space
        Dim marginX As Integer = 40
        Dim gridW As Integer = Math.Min(1500, Math.Max(400, formW - (marginX * 2)))
        InvoiceItems.Width = gridW
        InvoiceItems.Left = (formW - InvoiceItems.Width) \ 2

        ' Reserve space for totals and bottom button
        Dim reserved As Integer = 20 + Panel4.Height + 20 + PrintInvoiceBtn.Height + 20
        Dim gridH As Integer = Math.Max(300, Panel3.ClientSize.Height - reserved)
        InvoiceItems.Height = gridH
        InvoiceItems.Top = 3

        ' Totals panel below grid, align to grid
        Panel4.Width = InvoiceItems.Width
        Panel4.Left = InvoiceItems.Left
        Panel4.Top = InvoiceItems.Bottom + 20

        ' Center the print button at the bottom of the content area
        If PrintInvoiceBtn.Dock <> DockStyle.None Then
            PrintInvoiceBtn.Dock = DockStyle.None
        End If
        PrintInvoiceBtn.Top = Panel3.ClientSize.Height - PrintInvoiceBtn.Height - 10
        PrintInvoiceBtn.Left = (formW - PrintInvoiceBtn.Width) \ 2
    End Sub
End Class