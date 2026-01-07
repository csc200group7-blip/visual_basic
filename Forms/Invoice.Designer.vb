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
        Dim dgvHeaderStyle As New DataGridViewCellStyle()
        Dim dgvCellStyle As New DataGridViewCellStyle()

        ' ================= Form Properties =================
        Me.SuspendLayout()
        Me.AutoScaleDimensions = New SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.BackColor = Color.WhiteSmoke
        Me.ClientSize = New Size(1100, 800)
        Me.MinimumSize = New Size(700, 500)
        Me.Text = "Invoice Preview"
        Me.Font = New Font("Segoe UI", 9.0!)
        Me.AutoScroll = True

        ' ================= Panels =================
        Me.TopPanel = New Panel()
        Me.BottomPanel = New Panel()
        Me.CustomerPanel = New Panel()
        Me.TotalPanel = New Panel()
        Me.ButtonPanel = New Panel()

        ' ================= DataGridView: ItemsList =================
        Me.ItemsList = New DataGridView()
        Me.IndexCol = New DataGridViewTextBoxColumn()
        Me.ItemCol = New DataGridViewTextBoxColumn()
        Me.QuantityCol = New DataGridViewTextBoxColumn()
        Me.PriceCol = New DataGridViewTextBoxColumn()
        Me.TotalCol = New DataGridViewTextBoxColumn()

        ' ================= Customer Controls =================
        Me.LabelCustomerName = New Label()
        Me.txtCustomerName = New TextBox()
        Me.LabelCustomerAddress = New Label()
        Me.txtCustomerAddress = New TextBox()
        Me.LabelCustomerEmail = New Label()
        Me.txtCustomerEmail = New TextBox()

        ' ================= Totals Controls =================
        Me.LabelSubtotal = New Label()
        Me.txtSubtotal = New TextBox()
        Me.LabelTax = New Label()
        Me.txtTax = New TextBox()
        Me.LabelTotal = New Label()
        Me.txtTotal = New TextBox()

        ' ================= Buttons =================
        Me.PrintBtn = New Button()
        Me.ExportBtn = New Button()

        ' ================= TopPanel: Invoice Items =================
        Me.TopPanel.Dock = DockStyle.Top
        Me.TopPanel.Height = 350
        Me.TopPanel.Padding = New Padding(10)
        Me.TopPanel.BackColor = Color.White

        ' DataGridView Styling
        Me.ItemsList.Dock = DockStyle.Fill
        Me.ItemsList.BackgroundColor = Color.White
        Me.ItemsList.BorderStyle = BorderStyle.None
        Me.ItemsList.EnableHeadersVisualStyles = False
        Me.ItemsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemsList.ReadOnly = True
        Me.ItemsList.RowHeadersVisible = False
        Me.ItemsList.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Me.ItemsList.AllowUserToAddRows = False
        Me.ItemsList.AllowUserToDeleteRows = False
        Me.ItemsList.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right

        ' Column Header Style
        dgvHeaderStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvHeaderStyle.BackColor = Color.Gainsboro
        dgvHeaderStyle.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold)
        dgvHeaderStyle.ForeColor = SystemColors.WindowText
        dgvHeaderStyle.SelectionBackColor = SystemColors.Highlight
        dgvHeaderStyle.SelectionForeColor = SystemColors.HighlightText
        dgvHeaderStyle.WrapMode = DataGridViewTriState.True
        Me.ItemsList.ColumnHeadersDefaultCellStyle = dgvHeaderStyle

        ' Default Cell Style
        dgvCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvCellStyle.BackColor = SystemColors.Window
        dgvCellStyle.Font = New Font("Segoe UI", 9.0!)
        dgvCellStyle.ForeColor = SystemColors.ControlText
        dgvCellStyle.SelectionBackColor = SystemColors.Highlight
        dgvCellStyle.SelectionForeColor = SystemColors.HighlightText
        dgvCellStyle.WrapMode = DataGridViewTriState.False
        Me.ItemsList.DefaultCellStyle = dgvCellStyle

        ' Columns
        Me.IndexCol.HeaderText = "S/N"
        Me.IndexCol.Width = 50
        Me.ItemCol.HeaderText = "Item"
        Me.ItemCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Me.QuantityCol.HeaderText = "Quantity"
        Me.QuantityCol.Width = 80
        Me.PriceCol.HeaderText = "Price"
        Me.PriceCol.Width = 100
        Me.TotalCol.HeaderText = "Total"
        Me.TotalCol.Width = 100
        Me.ItemsList.Columns.AddRange(New DataGridViewColumn() {Me.IndexCol, Me.ItemCol, Me.QuantityCol, Me.PriceCol, Me.TotalCol})

        Me.TopPanel.Controls.Add(Me.ItemsList)

        ' ================= BottomPanel =================
        Me.BottomPanel.Dock = DockStyle.Fill
        Me.BottomPanel.Padding = New Padding(10)

        ' ---------------- CustomerPanel ----------------
        Me.CustomerPanel.Dock = DockStyle.Top
        Me.CustomerPanel.Height = 180
        Me.CustomerPanel.BackColor = Color.WhiteSmoke
        Me.CustomerPanel.Padding = New Padding(10)

        ' Customer Name
        Me.LabelCustomerName.Text = "Individual / Company Name *"
        Me.LabelCustomerName.AutoSize = True
        Me.LabelCustomerName.Location = New Point(10, 10)
        Me.txtCustomerName.Location = New Point(10, 35)
        Me.txtCustomerName.Width = 600
        Me.txtCustomerName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right

        ' Customer Address
        Me.LabelCustomerAddress.Text = "Individual / Company Address *"
        Me.LabelCustomerAddress.AutoSize = True
        Me.LabelCustomerAddress.Location = New Point(10, 70)
        Me.txtCustomerAddress.Location = New Point(10, 95)
        Me.txtCustomerAddress.Width = 600
        Me.txtCustomerAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right

        ' Customer Email
        Me.LabelCustomerEmail.Text = "Email *"
        Me.LabelCustomerEmail.AutoSize = True
        Me.LabelCustomerEmail.Location = New Point(10, 130)
        Me.txtCustomerEmail.Location = New Point(10, 155)
        Me.txtCustomerEmail.Width = 600
        Me.txtCustomerEmail.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right

        Me.CustomerPanel.Controls.Add(Me.LabelCustomerName)
        Me.CustomerPanel.Controls.Add(Me.txtCustomerName)
        Me.CustomerPanel.Controls.Add(Me.LabelCustomerAddress)
        Me.CustomerPanel.Controls.Add(Me.txtCustomerAddress)
        Me.CustomerPanel.Controls.Add(Me.LabelCustomerEmail)
        Me.CustomerPanel.Controls.Add(Me.txtCustomerEmail)

        ' ---------------- TotalPanel ----------------
        Me.TotalPanel.Dock = DockStyle.Top
        Me.TotalPanel.Height = 100
        Me.TotalPanel.BackColor = Color.White
        Me.TotalPanel.Padding = New Padding(10)

        Me.LabelSubtotal.Text = "Subtotal"
        Me.LabelSubtotal.Location = New Point(10, 10)
        Me.LabelSubtotal.AutoSize = True
        Me.txtSubtotal.Location = New Point(100, 7)
        Me.txtSubtotal.Width = 120
        Me.txtSubtotal.ReadOnly = True
        Me.txtSubtotal.Anchor = AnchorStyles.Top Or AnchorStyles.Left

        Me.LabelTax.Text = "Tax"
        Me.LabelTax.Location = New Point(10, 40)
        Me.LabelTax.AutoSize = True
        Me.txtTax.Location = New Point(100, 37)
        Me.txtTax.Width = 120
        Me.txtTax.ReadOnly = True
        Me.txtTax.Anchor = AnchorStyles.Top Or AnchorStyles.Left

        Me.LabelTotal.Text = "Total"
        Me.LabelTotal.Location = New Point(10, 70)
        Me.LabelTotal.AutoSize = True
        Me.txtTotal.Location = New Point(100, 67)
        Me.txtTotal.Width = 120
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Anchor = AnchorStyles.Top Or AnchorStyles.Left

        Me.TotalPanel.Controls.Add(Me.LabelSubtotal)
        Me.TotalPanel.Controls.Add(Me.txtSubtotal)
        Me.TotalPanel.Controls.Add(Me.LabelTax)
        Me.TotalPanel.Controls.Add(Me.txtTax)
        Me.TotalPanel.Controls.Add(Me.LabelTotal)
        Me.TotalPanel.Controls.Add(Me.txtTotal)

        ' ---------------- ButtonPanel ----------------
        Me.ButtonPanel.Dock = DockStyle.Top
        Me.ButtonPanel.Height = 50
        Me.ButtonPanel.BackColor = Color.White

        Me.PrintBtn.Text = "Print"
        Me.PrintBtn.BackColor = Color.FromArgb(0, 120, 215)
        Me.PrintBtn.ForeColor = Color.White
        Me.PrintBtn.FlatStyle = FlatStyle.Flat
        Me.PrintBtn.FlatAppearance.BorderSize = 0
        Me.PrintBtn.Width = 120
        Me.PrintBtn.Height = 35
        Me.PrintBtn.Location = New Point(10, 10)
        Me.PrintBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Left

        Me.ExportBtn.Text = "Export PDF"
        Me.ExportBtn.BackColor = Color.Gray
        Me.ExportBtn.ForeColor = Color.White
        Me.ExportBtn.FlatStyle = FlatStyle.Flat
        Me.ExportBtn.FlatAppearance.BorderSize = 0
        Me.ExportBtn.Width = 120
        Me.ExportBtn.Height = 35
        Me.ExportBtn.Location = New Point(140, 10)
        Me.ExportBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Left

        Me.ButtonPanel.Controls.Add(Me.PrintBtn)
        Me.ButtonPanel.Controls.Add(Me.ExportBtn)

        ' ---------------- Add panels to BottomPanel ----------------
        Me.BottomPanel.Controls.Add(Me.ButtonPanel)
        Me.BottomPanel.Controls.Add(Me.TotalPanel)
        Me.BottomPanel.Controls.Add(Me.CustomerPanel)

        ' ---------------- Add panels to Form ----------------
        Me.Controls.Add(Me.BottomPanel)
        Me.Controls.Add(Me.TopPanel)

        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    ' ================= Controls Declaration =================
    Friend WithEvents TopPanel As Panel
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents CustomerPanel As Panel
    Friend WithEvents TotalPanel As Panel
    Friend WithEvents ButtonPanel As Panel

    Friend WithEvents ItemsList As DataGridView
    Friend WithEvents IndexCol As DataGridViewTextBoxColumn
    Friend WithEvents ItemCol As DataGridViewTextBoxColumn
    Friend WithEvents QuantityCol As DataGridViewTextBoxColumn
    Friend WithEvents PriceCol As DataGridViewTextBoxColumn
    Friend WithEvents TotalCol As DataGridViewTextBoxColumn

    Friend WithEvents LabelCustomerName As Label
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents LabelCustomerAddress As Label
    Friend WithEvents txtCustomerAddress As TextBox
    Friend WithEvents LabelCustomerEmail As Label
    Friend WithEvents txtCustomerEmail As TextBox

    Friend WithEvents LabelSubtotal As Label
    Friend WithEvents txtSubtotal As TextBox
    Friend WithEvents LabelTax As Label
    Friend WithEvents txtTax As TextBox
    Friend WithEvents LabelTotal As Label
    Friend WithEvents txtTotal As TextBox

    Friend WithEvents PrintBtn As Button
    Friend WithEvents ExportBtn As Button

End Class
