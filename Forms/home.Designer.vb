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
        BtnAddItem = New Button()
        txtItem = New TextBox()
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
        CType(ItemsList, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnAddItem
        ' 
        BtnAddItem.Location = New Point(165, 404)
        BtnAddItem.Name = "BtnAddItem"
        BtnAddItem.Size = New Size(219, 40)
        BtnAddItem.TabIndex = 0
        BtnAddItem.Text = "Add Item"
        BtnAddItem.BackColor = System.Drawing.Color.Gainsboro
        BtnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        BtnAddItem.FlatAppearance.BorderSize = 0
        BtnAddItem.UseVisualStyleBackColor = False
        ' 
        ' txtItem
        ' 
        txtItem.Location = New Point(148, 300)
        txtItem.Name = "txtItem"
        txtItem.Size = New Size(491, 27)
        txtItem.TabIndex = 2
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(148, 344)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(206, 27)
        txtQuantity.TabIndex = 3
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(467, 344)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(172, 27)
        txtPrice.TabIndex = 4
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(103, 303)
        Label1.Name = "Label1"
        Label1.Size = New Size(82, 20)
        Label1.TabIndex = 5
        Label1.Text = "Item Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(77, 347)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 20)
        Label2.TabIndex = 6
        Label2.Text = "Quantity"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(420, 347)
        Label3.Name = "Label3"
        Label3.Size = New Size(41, 20)
        Label3.TabIndex = 7
        Label3.Text = "Price"
        ' 
        ' ItemsList
        ' 
        ItemsList.AllowUserToAddRows = False
        ItemsList.AllowUserToDeleteRows = False
        ItemsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        ItemsList.BackgroundColor = System.Drawing.Color.White
        ItemsList.BorderStyle = BorderStyle.None
        ItemsList.EnableHeadersVisualStyles = False
        ItemsList.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Gainsboro
        ItemsList.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!, FontStyle.Bold)
        ItemsList.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        ItemsList.Columns.AddRange(New DataGridViewColumn() {IndexCol, ItemCol, QuantityCol, PriceCol, ActionCol})
        ItemsList.Location = New Point(39, 27)
        ItemsList.Name = "ItemsList"
        ItemsList.ReadOnly = True
        ItemsList.RowHeadersVisible = False
        ItemsList.RowHeadersWidth = 51
        ItemsList.Size = New Size(725, 232)
        ItemsList.TabIndex = 8
        ' 
        ' IndexCol
        ' 
        IndexCol.HeaderText = "S/N"
        IndexCol.MinimumWidth = 6
        IndexCol.Name = "IndexCol"
        IndexCol.ReadOnly = True
        IndexCol.Width = 55
        ' 
        ' ItemCol
        ' 
        ItemCol.HeaderText = "Item"
        ItemCol.MinimumWidth = 6
        ItemCol.Name = "ItemCol"
        ItemCol.ReadOnly = True
        ItemCol.Width = 295
        ' 
        ' QuantityCol
        ' 
        QuantityCol.HeaderText = "Quantity"
        QuantityCol.MinimumWidth = 6
        QuantityCol.Name = "QuantityCol"
        QuantityCol.ReadOnly = True
        QuantityCol.Width = 105
        ' 
        ' PriceCol
        ' 
        PriceCol.HeaderText = "Price"
        PriceCol.MinimumWidth = 6
        PriceCol.Name = "PriceCol"
        PriceCol.ReadOnly = True
        PriceCol.Width = 125
        ' 
        ' ActionCol
        ' 
        ActionCol.HeaderText = "Action"
        ActionCol.MinimumWidth = 6
        ActionCol.Name = "ActionCol"
        ActionCol.ReadOnly = True
        ActionCol.Width = 140
        ' 
        ' GenInvoiceBtn
        ' 
        GenInvoiceBtn.Location = New Point(419, 404)
        GenInvoiceBtn.Name = "GenInvoiceBtn"
        GenInvoiceBtn.Size = New Size(220, 40)
        GenInvoiceBtn.TabIndex = 9
        GenInvoiceBtn.Text = "Generate Invoice"
        GenInvoiceBtn.BackColor = System.Drawing.Color.FromArgb(0, 120, 215)
        GenInvoiceBtn.ForeColor = System.Drawing.Color.White
        GenInvoiceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        GenInvoiceBtn.FlatAppearance.BorderSize = 0
        GenInvoiceBtn.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        BackColor = System.Drawing.Color.WhiteSmoke
        Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Controls.Add(GenInvoiceBtn)
        Controls.Add(ItemsList)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPrice)
        Controls.Add(txtQuantity)
        Controls.Add(txtItem)
        Controls.Add(BtnAddItem)
        Name = "Form1"
        Text = "Home"
        CType(ItemsList, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnAddItem As Button
    Friend WithEvents txtItem As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents ItemsList As DataGridView
    Friend WithEvents IndexCol As DataGridViewTextBoxColumn
    Friend WithEvents ItemCol As DataGridViewTextBoxColumn
    Friend WithEvents QuantityCol As DataGridViewTextBoxColumn
    Friend WithEvents PriceCol As DataGridViewTextBoxColumn
    Friend WithEvents ActionCol As DataGridViewTextBoxColumn
    Friend WithEvents GenInvoiceBtn As Button

End Class
