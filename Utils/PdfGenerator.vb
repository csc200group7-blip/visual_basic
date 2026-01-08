Imports System.IO
Imports iText.Html2pdf
Imports iText.Kernel.Pdf
Imports iText.Layout.Font
Imports System.Windows.Forms


Public Class PdfGenerator

    Public Shared Sub GeneratePdfFromHtml(CustomerName As String, CustomerAddress As String,
                                   ItemsList As List(Of Dictionary(Of String, String)),
                                   SubTotal As String,
                                   VAT As String, ShippingFee As String, InvoiceNo As String,
                                   Total As Decimal)
        Dim PdfFilePath As String
        Dim FileSaver As New SaveFileDialog With {
            .Title = "Save Invoice",
            .Filter = "PDF Files (*.pdf) | *.pdf | All files (*.*) | *.*",
            .DefaultExt = "pdf",
            .AddExtension = True
        }

        If FileSaver.ShowDialog() = DialogResult.OK Then
            PdfFilePath = FileSaver.FileName
        Else
            MessageBox.Show("File Not Saved")
            Exit Sub
        End If

        Dim Tbody As String = ""
        For Each Item In ItemsList
            ' Skip invalid or empty items
            Dim idx As String = If(Item.ContainsKey("Index"), Item("Index"), Nothing)
            Dim name As String = If(Item.ContainsKey("Item"), Item("Item"), Nothing)
            Dim qty As String = If(Item.ContainsKey("Quantity"), Item("Quantity"), Nothing)
            Dim price As String = If(Item.ContainsKey("Price"), Item("Price"), Nothing)
            Dim totalStr As String = If(Item.ContainsKey("Total"), Item("Total"), Nothing)

            If String.IsNullOrWhiteSpace(idx) AndAlso
               String.IsNullOrWhiteSpace(name) AndAlso
               String.IsNullOrWhiteSpace(qty) AndAlso
               String.IsNullOrWhiteSpace(price) AndAlso
               String.IsNullOrWhiteSpace(totalStr) Then
                Continue For
            End If

            Tbody += $"<tr>
                        <td>{idx}</td>
                        <td>{name}</td>
                        <td>{qty}</td>
                        <td>{price}</td>
                        <td>{totalStr}</td>
                    </tr>"
        Next

        Dim htmlContent As String = InvoiceHtml.HtmlContent

        If String.IsNullOrWhiteSpace(htmlContent) Then
            Throw New Exception("HTML content is empty.")
        End If

        htmlContent = htmlContent.Replace("{{InvoiceNumber}}", InvoiceNo)
        htmlContent = htmlContent.Replace("{{Date}}", $"Date: {DateTime.Now:dd-MMM-yyyy}")
        htmlContent = htmlContent.Replace("{{CustomerName}}", CustomerName)
        htmlContent = htmlContent.Replace("{{CustomerAddress}}", CustomerAddress)
        htmlContent = htmlContent.Replace("{{ItemsList}}", Tbody)
        htmlContent = htmlContent.Replace("{{SubTotal}}", SubTotal)
        htmlContent = htmlContent.Replace("{{VAT}}", VAT)
        htmlContent = htmlContent.Replace("{{ShippingFee}}", ShippingFee)
        htmlContent = htmlContent.Replace("{{GrandTotal}}", Total.ToString("N2"))

        ' Ensure fonts with Naira glyph are available and CSS fonts can be resolved
        Dim props As New ConverterProperties()
        Dim fp As New FontProvider()
        fp.AddSystemFonts()
        props.SetFontProvider(fp)

        Using fs As New FileStream(PdfFilePath, FileMode.Create)
            HtmlConverter.ConvertToPdf(htmlContent, fs, props)
        End Using

        MessageBox.Show("Invoice PDF generated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub
End Class
