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

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblTitle = New Label()
        ItemsList = New DataGridView()
        IndexCol = New DataGridViewTextBoxColumn()
        ItemCol = New DataGridViewTextBoxColumn()
        QuantityCol = New DataGridViewTextBoxColumn()
        PriceCol = New DataGridViewTextBoxColumn()
        TotalCol = New DataGridViewTextBoxColumn()
        btnPrint = New Button()
        btnExport = New Button()
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        lblSubtotal = New Label()
        lblTax = New Label()
        lblTotal = New Label()
        CType(ItemsList, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel3.SuspendLayout()
        SuspendLayout()
        '
        ' lblTitle
        '
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14.0!, FontStyle.Bold)
        lblTitle.Location = New Point(20, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(180, 32)
        lblTitle.Text = "Invoice Preview"
        '
        ' ItemsList
        '
        ItemsList.AllowUserToAddRows = False
        ItemsList.AllowUserToDeleteRows = False
        ItemsList.BackgroundColor = Color.White
        ItemsList.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Gainsboro
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        ItemsList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        ItemsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ItemsList.Columns.AddRange(New DataGridViewColumn() {IndexCol, ItemCol, QuantityCol, PriceCol, TotalCol})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9.0!)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        ItemsList.DefaultCellStyle = DataGridViewCellStyle2
        ItemsList.EnableHeadersVisualStyles = False
        ItemsList.Location = New Point(20, 70)
        ItemsList.Name = "ItemsList"
        ItemsList.ReadOnly = True
        ItemsList.RowHeadersVisible = False
        ItemsList.RowHeadersWidth = 51
        ItemsList.Size = New Size(740, 300)
        '
        ' IndexCol
        '
        IndexCol.HeaderText = "S/N"
        IndexCol.MinimumWidth = 30
        IndexCol.Name = "IndexCol"
        IndexCol.ReadOnly = True
        IndexCol.Width = 50
        '
        ' ItemCol
        '
        ItemCol.HeaderText = "Item"
        ItemCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        ItemCol.Name = "ItemCol"
        ItemCol.ReadOnly = True
        '
        ' QuantityCol
        '
        QuantityCol.HeaderText = "Quantity"
        QuantityCol.MinimumWidth = 60
        QuantityCol.Name = "QuantityCol"
        QuantityCol.ReadOnly = True
        QuantityCol.Width = 80
        '
        ' PriceCol
        '
        PriceCol.HeaderText = "Price"
        PriceCol.MinimumWidth = 80
        PriceCol.Name = "PriceCol"
        PriceCol.ReadOnly = True
        PriceCol.Width = 100
        '
        ' TotalCol
        '
        TotalCol.HeaderText = "Total"
        TotalCol.MinimumWidth = 80
        TotalCol.Name = "TotalCol"
        TotalCol.ReadOnly = True
        TotalCol.Width = 120
        '
        ' Panel1 (Totals section)
        '
        Panel1.Controls.Add(lblSubtotal)
        Panel1.Controls.Add(lblTax)
        Panel1.Controls.Add(lblTotal)
        Panel1.Location = New Point(500, 380)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(260, 120)
        '
        ' lblSubtotal
        '
        lblSubtotal.AutoSize = True
        lblSubtotal.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
        lblSubtotal.Location = New Point(10, 10)
        lblSubtotal.Name = "lblSubtotal"
        lblSubtotal.Text = "Subtotal: $0.00"
        '
        ' lblTax
        '
        lblTax.AutoSize = True
        lblTax.Font = New Font("Segoe UI", 10.0!, FontStyle.Regular)
        lblTax.Location = New Point(10, 40)
        lblTax.Name = "lblTax"
        lblTax.Text = "Tax: $0.00"
        '
        ' lblTotal
        '
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 12.0!, FontStyle.Bold)
        lblTotal.Location = New Point(10, 70)
        lblTotal.Name = "lblTotal"
        lblTotal.Text = "Total: $0.00"
        '
        ' btnPrint
        '
        btnPrint.BackColor = Color.FromArgb(0, 120, 215)
        btnPrint.ForeColor = Color.White
        btnPrint.FlatStyle = FlatStyle.Flat
        btnPrint.FlatAppearance.BorderSize = 0
        btnPrint.Location = New Point(20, 520)
        btnPrint.Name = "btnPrint"
        btnPrint.Size = New Size(120, 40)
        btnPrint.Text = "Print"
        btnPrint.UseVisualStyleBackColor = False
        '
        ' btnExport
        '
        btnExport.BackColor = Color.FromArgb(0, 120, 215)
        btnExport.ForeColor = Color.White
        btnExport.FlatStyle = FlatStyle.Flat
        btnExport.FlatAppearance.BorderSize = 0
        btnExport.Location = New Point(160, 520)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(120, 40)
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = False
        '
        ' Panel2 (Main container)
        '
        Panel2.Controls.Add(lblTitle)
        Panel2.Controls.Add(ItemsList)
        Panel2.Controls.Add(Panel1)
        Panel2.Controls.Add(btnPrint)
        Panel2.Controls.Add(btnExport)
        Panel2.Dock = DockStyle.Fill
        Panel2.Name = "Panel2"
        Panel2.BackColor = Color.White
        '
        ' Panel3 (Optional: Customer Info)
        '
        Panel3.Location = New Point(20, 400)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(460, 100)
        '
        ' InvoiceForm
        '
        AutoScaleDimensions = New SizeF(8.0!, 20.0!)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 580)
        Controls.Add(Panel2)
        Name = "InvoiceForm"
        Text = "Invoice Preview"
        BackColor = Color.White
        CType(ItemsList, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents ItemsList As DataGridView
    Friend WithEvents IndexCol As DataGridViewTextBoxColumn
    Friend WithEvents ItemCol As DataGridViewTextBoxColumn
    Friend WithEvents QuantityCol As DataGridViewTextBoxColumn
    Friend WithEvents PriceCol As DataGridViewTextBoxColumn
    Friend WithEvents TotalCol As DataGridViewTextBoxColumn
    Friend WithEvents btnPrint As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblTotal As Label
End Class
