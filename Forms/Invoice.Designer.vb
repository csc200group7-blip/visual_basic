<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class InvoiceForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list
    <System.Diagnostics.DebuggerNonUserCode()>
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

    'Form initialization
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Panel1 = New Panel()
        Label1 = New Label()
        Panel2 = New Panel()
        lblDate = New Label()
        lblInvoiceNo = New Label()
        lblBillToAddress = New Label()
        lblBillToName = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        Panel4 = New Panel()
        txtShipping = New Label()
        txtTotal = New Label()
        txtTax = New Label()
        txtSubtotal = New Label()
        PrintInvoiceBtn = New Button()
        InvoiceItems = New DataGridView()
        IndexCol = New DataGridViewTextBoxColumn()
        ItemCol = New DataGridViewTextBoxColumn()
        QuantityCol = New DataGridViewTextBoxColumn()
        PriceCol = New DataGridViewTextBoxColumn()
        TotalCol = New DataGridViewTextBoxColumn()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        CType(InvoiceItems, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1100, 44)
        Panel1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(176, 31)
        Label1.TabIndex = 0
        Label1.Text = "Invoice Preview"
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(lblDate)
        Panel2.Controls.Add(lblInvoiceNo)
        Panel2.Controls.Add(lblBillToAddress)
        Panel2.Controls.Add(lblBillToName)
        Panel2.Controls.Add(Label2)
        Panel2.Location = New Point(0, 50)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1096, 125)
        Panel2.TabIndex = 1
        ' 
        ' lblDate
        ' 
        lblDate.AutoSize = True
        lblDate.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblDate.Location = New Point(588, 48)
        lblDate.Name = "lblDate"
        lblDate.Size = New Size(66, 25)
        lblDate.TabIndex = 4
        lblDate.Text = "Label3"
        ' 
        ' lblInvoiceNo
        ' 
        lblInvoiceNo.AutoSize = True
        lblInvoiceNo.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblInvoiceNo.Location = New Point(588, 9)
        lblInvoiceNo.Name = "lblInvoiceNo"
        lblInvoiceNo.Size = New Size(66, 25)
        lblInvoiceNo.TabIndex = 3
        lblInvoiceNo.Text = "Label3"
        ' 
        ' lblBillToAddress
        ' 
        lblBillToAddress.AutoSize = True
        lblBillToAddress.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblBillToAddress.Location = New Point(12, 62)
        lblBillToAddress.Name = "lblBillToAddress"
        lblBillToAddress.Size = New Size(227, 23)
        lblBillToAddress.TabIndex = 2
        lblBillToAddress.Text = "123 Main str, Surulere, Lagos"
        ' 
        ' lblBillToName
        ' 
        lblBillToName.AutoSize = True
        lblBillToName.Font = New Font("Segoe UI Semibold", 10F, FontStyle.Bold)
        lblBillToName.Location = New Point(12, 39)
        lblBillToName.Name = "lblBillToName"
        lblBillToName.Size = New Size(95, 23)
        lblBillToName.TabIndex = 1
        lblBillToName.Text = "Max Essien"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12.2F, FontStyle.Bold)
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(75, 30)
        Label2.TabIndex = 0
        Label2.Text = "Bill To:"
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Panel4)
        Panel3.Controls.Add(PrintInvoiceBtn)
        Panel3.Controls.Add(InvoiceItems)
        Panel3.Location = New Point(0, 204)
        Panel3.Name = "Panel3"
        Panel3.Padding = New Padding(0, 25, 0, 25)
        Panel3.Size = New Size(1096, 684)
        Panel3.TabIndex = 2
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(txtShipping)
        Panel4.Controls.Add(txtTotal)
        Panel4.Controls.Add(txtTax)
        Panel4.Controls.Add(txtSubtotal)
        Panel4.Location = New Point(40, 460)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(1000, 144)
        Panel4.TabIndex = 11
        ' 
        ' txtShipping
        ' 
        txtShipping.AutoSize = True
        txtShipping.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        txtShipping.Location = New Point(11, 69)
        txtShipping.Name = "txtShipping"
        txtShipping.Size = New Size(59, 23)
        txtShipping.TabIndex = 3
        txtShipping.Text = "Label3"
        ' 
        ' txtTotal
        ' 
        txtTotal.AutoSize = True
        txtTotal.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtTotal.Location = New Point(11, 104)
        txtTotal.Name = "txtTotal"
        txtTotal.Size = New Size(74, 28)
        txtTotal.TabIndex = 2
        txtTotal.Text = "Label5"
        ' 
        ' txtTax
        ' 
        txtTax.AutoSize = True
        txtTax.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        txtTax.Location = New Point(11, 37)
        txtTax.Name = "txtTax"
        txtTax.Size = New Size(59, 23)
        txtTax.TabIndex = 1
        txtTax.Text = "Label5"
        ' 
        ' txtSubtotal
        ' 
        txtSubtotal.AutoSize = True
        txtSubtotal.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        txtSubtotal.Location = New Point(11, 6)
        txtSubtotal.Name = "txtSubtotal"
        txtSubtotal.Size = New Size(59, 23)
        txtSubtotal.TabIndex = 0
        txtSubtotal.Text = "Label5"
        ' 
        ' PrintInvoiceBtn
        ' 
        PrintInvoiceBtn.BackColor = Color.SteelBlue
        PrintInvoiceBtn.Dock = DockStyle.Bottom
        PrintInvoiceBtn.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        PrintInvoiceBtn.Location = New Point(0, 610)
        PrintInvoiceBtn.MaximumSize = New Size(505, 49)
        PrintInvoiceBtn.MinimumSize = New Size(400, 49)
        PrintInvoiceBtn.Name = "PrintInvoiceBtn"
        PrintInvoiceBtn.Size = New Size(505, 49)
        PrintInvoiceBtn.TabIndex = 10
        PrintInvoiceBtn.Text = "Print Invoice"
        PrintInvoiceBtn.UseVisualStyleBackColor = False
        ' 
        ' InvoiceItems
        ' 
        InvoiceItems.AllowUserToAddRows = False
        InvoiceItems.AllowUserToDeleteRows = False
        InvoiceItems.BackgroundColor = Color.White
        InvoiceItems.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Gainsboro
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        InvoiceItems.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        InvoiceItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        InvoiceItems.Columns.AddRange(New DataGridViewColumn() {IndexCol, ItemCol, QuantityCol, PriceCol, TotalCol})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        InvoiceItems.DefaultCellStyle = DataGridViewCellStyle2
        InvoiceItems.EnableHeadersVisualStyles = False
        InvoiceItems.Location = New Point(40, 3)
        InvoiceItems.MaximumSize = New Size(1500, 0)
        InvoiceItems.MinimumSize = New Size(0, 400)
        InvoiceItems.Name = "InvoiceItems"
        InvoiceItems.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        InvoiceItems.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        InvoiceItems.RowHeadersVisible = False
        InvoiceItems.RowHeadersWidth = 51
        InvoiceItems.Size = New Size(1000, 431)
        InvoiceItems.TabIndex = 9
        ' 
        ' IndexCol
        ' 
        IndexCol.FillWeight = 30.03003F
        IndexCol.HeaderText = "S/N"
        IndexCol.MinimumWidth = 30
        IndexCol.Name = "IndexCol"
        IndexCol.ReadOnly = True
        IndexCol.Width = 60
        ' 
        ' ItemCol
        ' 
        ItemCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ItemCol.FillWeight = 303.1112F
        ItemCol.HeaderText = "Item"
        ItemCol.MinimumWidth = 176
        ItemCol.Name = "ItemCol"
        ItemCol.ReadOnly = True
        ' 
        ' QuantityCol
        ' 
        QuantityCol.FillWeight = 43.3671455F
        QuantityCol.HeaderText = "Quantity"
        QuantityCol.MinimumWidth = 55
        QuantityCol.Name = "QuantityCol"
        QuantityCol.ReadOnly = True
        QuantityCol.Width = 86
        ' 
        ' PriceCol
        ' 
        PriceCol.FillWeight = 60.1990433F
        PriceCol.HeaderText = "Price"
        PriceCol.MinimumWidth = 65
        PriceCol.Name = "PriceCol"
        PriceCol.ReadOnly = True
        PriceCol.Width = 121
        ' 
        ' TotalCol
        ' 
        TotalCol.HeaderText = "Total"
        TotalCol.MinimumWidth = 125
        TotalCol.Name = "TotalCol"
        TotalCol.ReadOnly = True
        TotalCol.Width = 160
        ' 
        ' InvoiceForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1100, 900)
        Controls.Add(Panel3)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Font = New Font("Segoe UI", 9F)
        MinimumSize = New Size(700, 600)
        Name = "InvoiceForm"
        Text = "Invoice Preview"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        CType(InvoiceItems, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents lblBillToAddress As Label
    Friend WithEvents lblBillToName As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PrintInvoiceBtn As Button
    Friend WithEvents InvoiceItems As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtTotal As Label
    Friend WithEvents txtTax As Label
    Friend WithEvents txtSubtotal As Label
    Friend WithEvents IndexCol As DataGridViewTextBoxColumn
    Friend WithEvents ItemCol As DataGridViewTextBoxColumn
    Friend WithEvents QuantityCol As DataGridViewTextBoxColumn
    Friend WithEvents PriceCol As DataGridViewTextBoxColumn
    Friend WithEvents TotalCol As DataGridViewTextBoxColumn
    Friend WithEvents lblInvoiceNo As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents txtShipping As Label

End Class
