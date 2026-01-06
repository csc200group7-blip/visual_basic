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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        lblTitle = New Label()
        lblTotal = New Label()
        BtnPrint = New Button()
        ItemsList = New DataGridView()
        Panel1 = New Panel()
        IndexCol = New DataGridViewTextBoxColumn()
        ItemCol = New DataGridViewTextBoxColumn()
        QuantityCol = New DataGridViewTextBoxColumn()
        PriceCol = New DataGridViewTextBoxColumn()
        Total = New DataGridViewTextBoxColumn()
        Label1 = New Label()
        CustonerNameLabel = New Label()
        CustomerAddressLabel = New Label()
        CustomerEmailLabel = New Label()
        CType(ItemsList, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(20, 20)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(176, 31)
        lblTitle.TabIndex = 7
        lblTitle.Text = "Invoice Preview"
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotal.Location = New Point(13, 428)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(180, 25)
        lblTotal.TabIndex = 1
        lblTotal.Text = "Total Amount: ₦0.00"
        ' 
        ' BtnPrint
        ' 
        BtnPrint.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        BtnPrint.FlatAppearance.BorderSize = 0
        BtnPrint.FlatStyle = FlatStyle.Flat
        BtnPrint.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        BtnPrint.ForeColor = Color.White
        BtnPrint.Location = New Point(220, 554)
        BtnPrint.Name = "BtnPrint"
        BtnPrint.Size = New Size(575, 40)
        BtnPrint.TabIndex = 0
        BtnPrint.Text = "Print / Export Invoice"
        BtnPrint.UseVisualStyleBackColor = False
        ' 
        ' ItemsList
        ' 
        ItemsList.AllowUserToAddRows = False
        ItemsList.AllowUserToDeleteRows = False
        ItemsList.BackgroundColor = Color.White
        ItemsList.BorderStyle = BorderStyle.None
        DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = Color.Gainsboro
        DataGridViewCellStyle1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        DataGridViewCellStyle1.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = DataGridViewTriState.True
        ItemsList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        ItemsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ItemsList.Columns.AddRange(New DataGridViewColumn() {IndexCol, ItemCol, QuantityCol, PriceCol, Total})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        ItemsList.DefaultCellStyle = DataGridViewCellStyle2
        ItemsList.EnableHeadersVisualStyles = False
        ItemsList.Location = New Point(3, 151)
        ItemsList.MaximumSize = New Size(1500, 0)
        ItemsList.Name = "ItemsList"
        ItemsList.ReadOnly = True
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = SystemColors.Control
        DataGridViewCellStyle3.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.True
        ItemsList.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        ItemsList.RowHeadersVisible = False
        ItemsList.RowHeadersWidth = 51
        ItemsList.Size = New Size(1066, 262)
        ItemsList.TabIndex = 9
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.GhostWhite
        Panel1.Controls.Add(CustomerEmailLabel)
        Panel1.Controls.Add(CustomerAddressLabel)
        Panel1.Controls.Add(CustonerNameLabel)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(ItemsList)
        Panel1.Controls.Add(lblTotal)
        Panel1.Location = New Point(-1, 54)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1094, 465)
        Panel1.TabIndex = 6
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
        ' Total
        ' 
        Total.HeaderText = "Total"
        Total.MinimumWidth = 6
        Total.Name = "Total"
        Total.ReadOnly = True
        Total.Width = 155
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 11.8F, FontStyle.Bold)
        Label1.Location = New Point(9, 13)
        Label1.Name = "Label1"
        Label1.Size = New Size(71, 28)
        Label1.TabIndex = 10
        Label1.Text = "Bill To:"
        ' 
        ' CustonerNameLabel
        ' 
        CustonerNameLabel.AutoSize = True
        CustonerNameLabel.Font = New Font("Segoe UI Semibold", 10F)
        CustonerNameLabel.Location = New Point(13, 45)
        CustonerNameLabel.Name = "CustonerNameLabel"
        CustonerNameLabel.Size = New Size(95, 23)
        CustonerNameLabel.TabIndex = 11
        CustonerNameLabel.Text = "Max Essien"
        ' 
        ' CustomerAddressLabel
        ' 
        CustomerAddressLabel.AutoSize = True
        CustomerAddressLabel.Font = New Font("Segoe UI Semibold", 9.5F)
        CustomerAddressLabel.Location = New Point(13, 95)
        CustomerAddressLabel.Name = "CustomerAddressLabel"
        CustomerAddressLabel.Size = New Size(218, 21)
        CustomerAddressLabel.TabIndex = 12
        CustomerAddressLabel.Text = "123 Main Str, Surulere, Lagos"
        ' 
        ' CustomerEmailLabel
        ' 
        CustomerEmailLabel.AutoSize = True
        CustomerEmailLabel.Font = New Font("Segoe UI Semibold", 9.7F)
        CustomerEmailLabel.Location = New Point(13, 68)
        CustomerEmailLabel.Name = "CustomerEmailLabel"
        CustomerEmailLabel.Size = New Size(138, 23)
        CustomerEmailLabel.TabIndex = 13
        CustomerEmailLabel.Text = "max@gmail.com"
        ' 
        ' InvoiceForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.White
        ClientSize = New Size(1091, 630)
        Controls.Add(Panel1)
        Controls.Add(BtnPrint)
        Controls.Add(lblTitle)
        Font = New Font("Segoe UI", 9F)
        Name = "InvoiceForm"
        Text = "Invoice"
        CType(ItemsList, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents ItemsList As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Total As DataGridViewTextBoxColumn
    Friend WithEvents IndexCol As DataGridViewTextBoxColumn
    Friend WithEvents ItemCol As DataGridViewTextBoxColumn
    Friend WithEvents QuantityCol As DataGridViewTextBoxColumn
    Friend WithEvents PriceCol As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents CustomerAddressLabel As Label
    Friend WithEvents CustonerNameLabel As Label
    Friend WithEvents CustomerEmailLabel As Label

End Class
