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
    Friend WithEvents lblTotal As Label
    Friend WithEvents InvoiceGrid As DataGridView
    Friend WithEvents BtnPrint As Button

    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblTitle = New Label()
        lblTotal = New Label()
        InvoiceGrid = New DataGridView()
        BtnPrint = New Button()
        dtpInvoiceDate = New DateTimePicker()
        Label1 = New Label()
        CType(InvoiceGrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(20, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(176, 31)
        lblTitle.TabIndex = 4
        lblTitle.Text = "Invoice Preview"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 11F, FontStyle.Bold)
        lblTotal.Location = New Point(20, 360)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(194, 25)
        lblTotal.TabIndex = 1
        lblTotal.Text = "Total Amount: ₦0.00"
        ' 
        ' InvoiceGrid
        ' 
        InvoiceGrid.AllowUserToAddRows = False
        InvoiceGrid.AllowUserToDeleteRows = False
        InvoiceGrid.BackgroundColor = Color.White
        InvoiceGrid.BorderStyle = BorderStyle.None
        InvoiceGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        InvoiceGrid.Location = New Point(20, 80)
        InvoiceGrid.Name = "InvoiceGrid"
        InvoiceGrid.ReadOnly = True
        InvoiceGrid.RowHeadersVisible = False
        InvoiceGrid.RowHeadersWidth = 51
        InvoiceGrid.Size = New Size(740, 260)
        InvoiceGrid.TabIndex = 2
        ' 
        ' BtnPrint
        ' 
        BtnPrint.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        BtnPrint.FlatAppearance.BorderSize = 0
        BtnPrint.FlatStyle = FlatStyle.Flat
        BtnPrint.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnPrint.ForeColor = Color.White
        BtnPrint.Location = New Point(560, 355)
        BtnPrint.Name = "BtnPrint"
        BtnPrint.Size = New Size(200, 40)
        BtnPrint.TabIndex = 0
        BtnPrint.Text = "Print / Export Invoice"
        BtnPrint.UseVisualStyleBackColor = False
        ' 
        ' dtpInvoiceDate
        ' 
        dtpInvoiceDate.CalendarFont = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpInvoiceDate.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dtpInvoiceDate.Format = DateTimePickerFormat.Short
        dtpInvoiceDate.Location = New Point(632, 21)
        dtpInvoiceDate.Name = "dtpInvoiceDate"
        dtpInvoiceDate.Size = New Size(128, 30)
        dtpInvoiceDate.TabIndex = 5
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 11F, FontStyle.Bold)
        Label1.Location = New Point(572, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(58, 25)
        Label1.TabIndex = 6
        Label1.Text = "Date:"
        ' 
        ' InvoiceForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(800, 450)
        Controls.Add(Label1)
        Controls.Add(dtpInvoiceDate)
        Controls.Add(BtnPrint)
        Controls.Add(lblTotal)
        Controls.Add(InvoiceGrid)
        Controls.Add(lblTitle)
        Font = New Font("Segoe UI", 9F)
        Name = "InvoiceForm"
        Text = "Invoice"
        CType(InvoiceGrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents dtpInvoiceDate As DateTimePicker
    Friend WithEvents Label1 As Label

End Class
