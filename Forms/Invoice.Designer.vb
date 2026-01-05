<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InvoiceForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents InvoiceGrid As DataGridView
    Friend WithEvents BtnPrint As Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblTitle = New Label()
        Me.lblDate = New Label()
        Me.lblTotal = New Label()
        Me.InvoiceGrid = New DataGridView()
        Me.BtnPrint = New Button()

        CType(Me.InvoiceGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()

        '
        ' lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New Font("Segoe UI", 14.0!, FontStyle.Bold)
        Me.lblTitle.Location = New Point(20, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New Size(170, 32)
        Me.lblTitle.Text = "Invoice Preview"

        '
        ' lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New Font("Segoe UI", 9.0!)
        Me.lblDate.Location = New Point(600, 30)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New Size(120, 20)
        Me.lblDate.Text = "Date: -- / -- / ----"

        '
        ' InvoiceGrid
        '
        Me.InvoiceGrid.AllowUserToAddRows = False
        Me.InvoiceGrid.AllowUserToDeleteRows = False
        Me.InvoiceGrid.BackgroundColor = Color.White
        Me.InvoiceGrid.BorderStyle = BorderStyle.None
        Me.InvoiceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InvoiceGrid.Location = New Point(20, 80)
        Me.InvoiceGrid.Name = "InvoiceGrid"
        Me.InvoiceGrid.ReadOnly = True
        Me.InvoiceGrid.RowHeadersVisible = False
        Me.InvoiceGrid.Size = New Size(740, 260)

        '
        ' lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New Font("Segoe UI", 11.0!, FontStyle.Bold)
        Me.lblTotal.Location = New Point(20, 360)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New Size(160, 25)
        Me.lblTotal.Text = "Total Amount: ₦0.00"

        '
        ' BtnPrint
        '
        Me.BtnPrint.BackColor = Color.FromArgb(0, 120, 215)
        Me.BtnPrint.FlatAppearance.BorderSize = 0
        Me.BtnPrint.FlatStyle = FlatStyle.Flat
        Me.BtnPrint.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        Me.BtnPrint.ForeColor = Color.White
        Me.BtnPrint.Location = New Point(560, 355)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New Size(200, 40)
        Me.BtnPrint.Text = "Print / Export Invoice"
        Me.BtnPrint.UseVisualStyleBackColor = False

        '
        ' InvoiceForm
        '
        Me.AutoScaleDimensions = New SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(800, 450)
        Me.BackColor = Color.White
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.InvoiceGrid)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New Font("Segoe UI", 9.0!)
        Me.Name = "InvoiceForm"
        Me.Text = "Invoice"

        CType(Me.InvoiceGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

End Class
