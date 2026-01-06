<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        BtnAddItem = New Button()
        txtQuantity = New TextBox()
        txtPrice = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        ItemsList = New DataGridView()
        IndexCol = New DataGridViewTextBoxColumn()
        ItemCol = New DataGridViewTextBoxColumn()
        QuantityCol = New DataGridViewTextBoxColumn()
        PriceCol = New DataGridViewTextBoxColumn()
        ActionCol = New DataGridViewTextBoxColumn()
        GenInvoiceBtn = New Button()
        itemListPanel = New Panel()
        InfoPanel = New Panel()
        ItemInfoPanel = New Panel()
        txtItem = New TextBox()
        InfoInnerPanel = New Panel()
        Panel3 = New Panel()
        Label6 = New Label()
        Label5 = New Label()
        Label4 = New Label()
        txtContactEmail = New TextBox()
        txtCustomerAddress = New TextBox()
        txtCustomerName = New TextBox()
        GenPanel = New Panel()
        AddPanel = New Panel()
        CType(ItemsList, ComponentModel.ISupportInitialize).BeginInit()
        itemListPanel.SuspendLayout()
        InfoPanel.SuspendLayout()
        ItemInfoPanel.SuspendLayout()
        InfoInnerPanel.SuspendLayout()
        Panel3.SuspendLayout()
        GenPanel.SuspendLayout()
        AddPanel.SuspendLayout()
        SuspendLayout()
        ' 
        ' BtnAddItem
        ' 
        BtnAddItem.BackColor = Color.Gainsboro
        BtnAddItem.Dock = DockStyle.Fill
        BtnAddItem.FlatAppearance.BorderSize = 0
        BtnAddItem.FlatStyle = FlatStyle.Flat
        BtnAddItem.Location = New Point(0, 0)
        BtnAddItem.MaximumSize = New Size(560, 0)
        BtnAddItem.Name = "BtnAddItem"
        BtnAddItem.Size = New Size(557, 49)
        BtnAddItem.TabIndex = 0
        BtnAddItem.Text = "Add Item"
        BtnAddItem.UseVisualStyleBackColor = False
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(90, 55)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(206, 27)
        txtQuantity.TabIndex = 3
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(409, 55)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(172, 27)
        txtPrice.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(45, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(39, 20)
        Label1.TabIndex = 5
        Label1.Text = "Item"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(19, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 20)
        Label2.TabIndex = 6
        Label2.Text = "Quantity"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(362, 58)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 20)
        Label3.TabIndex = 7
        Label3.Text = "Price"
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
        ItemsList.Columns.AddRange(New DataGridViewColumn() {IndexCol, ItemCol, QuantityCol, PriceCol, ActionCol})
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = SystemColors.Window
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle2.ForeColor = SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.False
        ItemsList.DefaultCellStyle = DataGridViewCellStyle2
        ItemsList.EnableHeadersVisualStyles = False
        ItemsList.Location = New Point(63, 29)
        ItemsList.MaximumSize = New Size(1500, 0)
        ItemsList.MinimumSize = New Size(0, 400)
        ItemsList.Name = "ItemsList"
        ItemsList.ReadOnly = True
        ItemsList.RowHeadersVisible = False
        ItemsList.RowHeadersWidth = 51
        ItemsList.Size = New Size(1000, 431)
        ItemsList.TabIndex = 8
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
        ' ActionCol
        ' 
        ActionCol.FillWeight = 63.2926064F
        ActionCol.HeaderText = "Action"
        ActionCol.MinimumWidth = 35
        ActionCol.Name = "ActionCol"
        ActionCol.ReadOnly = True
        ActionCol.Width = 126
        ' 
        ' GenInvoiceBtn
        ' 
        GenInvoiceBtn.AutoSize = True
        GenInvoiceBtn.BackColor = Color.FromArgb(CByte(0), CByte(120), CByte(215))
        GenInvoiceBtn.Dock = DockStyle.Fill
        GenInvoiceBtn.FlatAppearance.BorderSize = 0
        GenInvoiceBtn.FlatStyle = FlatStyle.Flat
        GenInvoiceBtn.ForeColor = Color.White
        GenInvoiceBtn.Location = New Point(0, 0)
        GenInvoiceBtn.MaximumSize = New Size(560, 0)
        GenInvoiceBtn.Name = "GenInvoiceBtn"
        GenInvoiceBtn.Size = New Size(560, 47)
        GenInvoiceBtn.TabIndex = 9
        GenInvoiceBtn.Text = "Generate Invoice"
        GenInvoiceBtn.UseVisualStyleBackColor = False
        ' 
        ' itemListPanel
        ' 
        itemListPanel.Controls.Add(ItemsList)
        itemListPanel.Dock = DockStyle.Top
        itemListPanel.Location = New Point(0, 0)
        itemListPanel.MinimumSize = New Size(0, 400)
        itemListPanel.Name = "itemListPanel"
        itemListPanel.Size = New Size(1085, 463)
        itemListPanel.TabIndex = 7
        ' 
        ' InfoPanel
        ' 
        InfoPanel.Controls.Add(ItemInfoPanel)
        InfoPanel.Controls.Add(InfoInnerPanel)
        InfoPanel.Location = New Point(0, 463)
        InfoPanel.MinimumSize = New Size(0, 300)
        InfoPanel.Name = "InfoPanel"
        InfoPanel.Size = New Size(1085, 453)
        InfoPanel.TabIndex = 4
        ' 
        ' ItemInfoPanel
        ' 
        ItemInfoPanel.Controls.Add(txtQuantity)
        ItemInfoPanel.Controls.Add(Label3)
        ItemInfoPanel.Controls.Add(Label1)
        ItemInfoPanel.Controls.Add(txtItem)
        ItemInfoPanel.Controls.Add(txtPrice)
        ItemInfoPanel.Controls.Add(Label2)
        ItemInfoPanel.Location = New Point(247, 30)
        ItemInfoPanel.MaximumSize = New Size(618, 108)
        ItemInfoPanel.MinimumSize = New Size(618, 108)
        ItemInfoPanel.Name = "ItemInfoPanel"
        ItemInfoPanel.Size = New Size(618, 108)
        ItemInfoPanel.TabIndex = 7
        ' 
        ' txtItem
        ' 
        txtItem.Location = New Point(90, 22)
        txtItem.Name = "txtItem"
        txtItem.Size = New Size(491, 27)
        txtItem.TabIndex = 2
        ' 
        ' InfoInnerPanel
        ' 
        InfoInnerPanel.Controls.Add(Panel3)
        InfoInnerPanel.Controls.Add(GenPanel)
        InfoInnerPanel.Controls.Add(AddPanel)
        InfoInnerPanel.Location = New Point(12, 30)
        InfoInnerPanel.Name = "InfoInnerPanel"
        InfoInnerPanel.Size = New Size(1082, 411)
        InfoInnerPanel.TabIndex = 6
        ' 
        ' Panel3
        ' 
        Panel3.Controls.Add(Label6)
        Panel3.Controls.Add(Label5)
        Panel3.Controls.Add(Label4)
        Panel3.Controls.Add(txtContactEmail)
        Panel3.Controls.Add(txtCustomerAddress)
        Panel3.Controls.Add(txtCustomerName)
        Panel3.Location = New Point(235, 169)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(618, 186)
        Panel3.TabIndex = 8
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(22, 133)
        Label6.Name = "Label6"
        Label6.Size = New Size(56, 20)
        Label6.TabIndex = 6
        Label6.Text = "Email *"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 74)
        Label5.Name = "Label5"
        Label5.Size = New Size(218, 20)
        Label5.TabIndex = 5
        Label5.Text = "Individual / Company Address *"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(19, 14)
        Label4.Name = "Label4"
        Label4.Size = New Size(205, 20)
        Label4.TabIndex = 4
        Label4.Text = "Individual / Company Name *"
        ' 
        ' txtContactEmail
        ' 
        txtContactEmail.Location = New Point(19, 156)
        txtContactEmail.Name = "txtContactEmail"
        txtContactEmail.Size = New Size(582, 27)
        txtContactEmail.TabIndex = 2
        ' 
        ' txtCustomerAddress
        ' 
        txtCustomerAddress.Location = New Point(19, 97)
        txtCustomerAddress.Name = "txtCustomerAddress"
        txtCustomerAddress.Size = New Size(582, 27)
        txtCustomerAddress.TabIndex = 1
        ' 
        ' txtCustomerName
        ' 
        txtCustomerName.Location = New Point(19, 37)
        txtCustomerName.Name = "txtCustomerName"
        txtCustomerName.Size = New Size(582, 27)
        txtCustomerName.TabIndex = 0
        ' 
        ' GenPanel
        ' 
        GenPanel.Controls.Add(GenInvoiceBtn)
        GenPanel.Location = New Point(3, 361)
        GenPanel.Name = "GenPanel"
        GenPanel.Size = New Size(560, 47)
        GenPanel.TabIndex = 7
        ' 
        ' AddPanel
        ' 
        AddPanel.Controls.Add(BtnAddItem)
        AddPanel.Location = New Point(3, 114)
        AddPanel.Name = "AddPanel"
        AddPanel.Size = New Size(557, 49)
        AddPanel.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        BackColor = Color.WhiteSmoke
        ClientSize = New Size(1106, 890)
        Controls.Add(InfoPanel)
        Controls.Add(itemListPanel)
        Font = New Font("Segoe UI", 9F)
        Location = New Point(0, 20)
        MinimumSize = New Size(690, 580)
        Name = "Form1"
        Text = "Home"
        CType(ItemsList, ComponentModel.ISupportInitialize).EndInit()
        itemListPanel.ResumeLayout(False)
        InfoPanel.ResumeLayout(False)
        ItemInfoPanel.ResumeLayout(False)
        ItemInfoPanel.PerformLayout()
        InfoInnerPanel.ResumeLayout(False)
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        GenPanel.ResumeLayout(False)
        GenPanel.PerformLayout()
        AddPanel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnAddItem As Button
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ItemsList As DataGridView
    Friend WithEvents GenInvoiceBtn As Button
    Friend WithEvents IndexCol As DataGridViewTextBoxColumn
    Friend WithEvents ItemCol As DataGridViewTextBoxColumn
    Friend WithEvents QuantityCol As DataGridViewTextBoxColumn
    Friend WithEvents PriceCol As DataGridViewTextBoxColumn
    Friend WithEvents ActionCol As DataGridViewTextBoxColumn
    Friend WithEvents itemListPanel As Panel
    Friend WithEvents InfoPanel As Panel
    Friend WithEvents InfoInnerPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ItemInfoPanel As Panel
    Friend WithEvents GenPanel As Panel
    Friend WithEvents AddPanel As Panel
    Friend WithEvents txtItem As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtCustomerAddress As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtContactEmail As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label

End Class
