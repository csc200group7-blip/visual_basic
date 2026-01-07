Imports System.IO
Imports iText.Html2pdf
Imports iText.Kernel.Pdf

Public Class PdfGenerator
    'Uses html file with stylings to generate pdf
    Private ReadOnly htmlFilePath As String = "Invoice.html"
    Private ReadOnly pdfFilePath As String = "Invoice.pdf"

    Public Sub GeneratePdfFromHtml(CustomerName As String, CustomerAddress As String,
                                   Total As Decimal)
        Dim htmlContent As String = File.ReadAllText(htmlFilePath)
        htmlContent = htmlContent.Replace("{{CustomerName}}", CustomerName)
        htmlContent = htmlContent.Replace("{{CustomerAddress}}", CustomerAddress)
        htmlContent = htmlContent.Replace("{{Total}}", Total.ToString("F2"))
        HtmlConverter.ConvertToPdf(html:=htmlContent, New FileStream(pdfFilePath, FileMode.Create))
    End Sub
End Class
