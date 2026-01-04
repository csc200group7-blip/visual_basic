# InvoiceGen - Invoice Generation Application

## Project Overview

InvoiceGen is a Windows Forms desktop application built with Visual Basic .NET that enables users to create and manage invoices. The application provides an intuitive interface for adding items, calculating totals, and generating PDF invoices from HTML templates.

## Technology Stack

- **Framework**: .NET 10.0 Windows Forms
- **Language**: Visual Basic .NET
- **PDF Generation**: iText7 (v9.4.0) and iText7.pdfhtml (v6.3.0)
- **Database**: SQLite (v2.0.2) - *Note: Database integration is included but not yet implemented*
- **Build System**: .NET SDK

## Dependencies

The project uses the following NuGet packages:
- `itext7` (v9.4.0) - Core PDF library
- `itext7.pdfhtml` (v6.3.0) - HTML to PDF conversion
- `System.Data.SQLite` (v2.0.2) - SQLite database provider

## Project Structure

```
InvoiceGen/
│
├── Forms/                          # UI Layer - Windows Forms
│   ├── home.vb                     # Main form logic (Form1)
│   ├── home.Designer.vb            # Main form UI designer code
│   ├── home.resx                   # Main form resources
│   ├── Invoice.vb                  # Invoice display form logic
│   ├── Invoice.Designer.vb         # Invoice form UI designer code
│   └── Invoice.resx                # Invoice form resources
│
├── Utils/                          # Business Logic Layer
│   ├── InvoiceGenHelpers.vb        # Helper functions for calculations
│   ├── PdfGenerator.vb             # PDF generation from HTML
│   └── invoice.html                # HTML template for PDF invoices
│
├── My Project/                     # Project configuration
│   ├── Application.Designer.vb     # Application framework
│   └── Application.myapp           # Application settings
│
├── ApplicationEvents.vb            # Application-level event handlers
├── InvoiceGen.vbproj              # Project file
└── InvoiceGen.slnx                # Solution file

```

## Setup and Installation

### Prerequisites
- Windows Operating System
- .NET 10.0 SDK or later
- Visual Studio 2022 (recommended) or Visual Studio Code with .NET extensions


## Application Architecture

### Form Flow
1. **Form1 (home.vb)** - Main entry point where users:
   - Add items with name, quantity, and price
   - View items in a DataGridView
   - Generate invoices

2. **InvoiceForm (Invoice.vb)** - Displays the generated invoice
   - Currently shows the total amount
   - *Note: Full invoice display is under development*

### Data Flow
```
User Input → Validation → DataGridView → Calculate Total → Invoice Form
                                                ↓
                                         PDF Generation
```

## Code Explanation

### 1. Forms/home.vb (Main Form)

The main form handles item entry and invoice generation.

#### Key Features:
- **Item Validation**: Ensures item name, quantity, and price are valid before adding
- **Duplicate Handling**: Checks if an item already exists and increments quantity instead of creating duplicate
- **Maximum Items**: Limited to 10 items per invoice
- **Data Grid**: Displays all added items in a table format

#### Important Methods:

**`BtnAddItem_Click`** - Handles adding items to the invoice
- Validates all input fields (item name, quantity, price)
- Checks for duplicate items using `CheckItemsExists()`
- Updates quantity if item exists, otherwise adds new row
- Clears input fields after successful addition

```vb
' Validation flow:
' 1. Check item name is not empty
' 2. Validate quantity is a number > 0
' 3. Validate price is a number > 0
' 4. Check if item already exists
' 5. Update or add item accordingly
```

**`GenInvoiceBtn_Click`** - Generates the invoice
- Iterates through DataGridView rows
- Creates formatted item list with quantities and prices
- Calculates total using `InvoiceGenHelpers.CalculateTotal()`
- Passes total to InvoiceForm and displays it

#### UI Controls:
- `txtItem` - Item name input
- `txtQuantity` - Quantity input
- `txtPrice` - Price input
- `ItemsList` - DataGridView displaying all items
- `BtnAddItem` - Button to add items
- `GenInvoiceBtn` - Button to generate invoice

### 2. Forms/Invoice.vb (Invoice Display Form)

Currently minimal implementation. **This is a key area for UI developers to expand.**

#### Current State:
- Has a `Total` property to receive the calculated total
- Empty form ready for UI implementation

#### TODO for UI Developers:
- Display customer information fields
- Show itemized list of products
- Display subtotal, tax, discount calculations
- Add print functionality
- Integrate PDF generation trigger

### 3. Utils/InvoiceGenHelpers.vb (Business Logic)

Contains shared helper functions for invoice calculations and item management.

#### Methods:

**`CalculateTotal(items As List(Of Dictionary(Of String, Decimal)))`**
- Takes a list of items with Quantity and Price
- Calculates total by multiplying quantity × price for each item
- Returns the sum as a Decimal

```vb
' Example:
' Item 1: Quantity=2, Price=10.00 → 20.00
' Item 2: Quantity=3, Price=5.00  → 15.00
' Total = 35.00
```

**`CheckItemsExists(ItemList As DataGridView, NewItem As String)`**
- Searches DataGridView for an existing item by name
- Returns the row index (Integer) if found
- Returns False if not found
- *Note: Has a bug - Exit For happens before Return, so it always returns False*

**`UpdateItemQty(ItemList As DataGridView, ItemRowIndex As String)`**
- Increments the quantity of an existing item by 1
- Takes the row index and updates the Quantity column (index 2)

### 4. Utils/PdfGenerator.vb (PDF Generation)

Handles PDF invoice generation using HTML templates.

#### Class Properties:
- `htmlFilePath` - Path to HTML template ("Invoice.html")
- `pdfFilePath` - Output PDF path ("Invoice.pdf")

#### Methods:

**`GeneratePdfFromHtml(CustomerName, CustomerAddress, CustomerEmail, Total)`**
- Reads HTML template from file
- Replaces placeholders with actual values:
  - `{{CustomerName}}` → Customer's name
  - `{{CustomerEmail}}` → Customer's email
  - `{{CustomerAddress}}` → Customer's address
  - `{{Total}}` → Formatted total (2 decimal places)
- Converts HTML to PDF using iText7's HtmlConverter
- Saves PDF to file

#### Usage Example:
```vb
Dim pdfGen As New PdfGenerator()
pdfGen.GeneratePdfFromHtml("John Doe", "123 Main St", "john@example.com", 150.00)
```

### 5. Utils/invoice.html (HTML Template)

**Currently empty** - This file needs to be created with the invoice template.

#### Expected Structure:
```html
<!DOCTYPE html>
<html>
<head>
    <style>
        /* Invoice styling */
    </style>
</head>
<body>
    <h1>INVOICE</h1>
    <p>Customer: {{CustomerName}}</p>
    <p>Email: {{CustomerEmail}}</p>
    <p>Address: {{CustomerAddress}}</p>
    <!-- Item table -->
    <p>Total: ${{Total}}</p>
</body>
</html>
```

## Development Guidelines

### For UI Developers (WinForms)

#### Working with Forms
1. **Use Visual Studio Designer**
   - Open `.Designer.vb` files in Visual Studio
   - Use the Form Designer to drag and drop controls
   - Properties are auto-generated in the Designer file

2. **Form1 (home.vb) Modifications**
   - UI is mostly complete
   - Can enhance with:
     - Better styling and colors
     - Input validation indicators
     - Item editing/deletion buttons
     - Customer information fields
     - Date picker for invoice date

3. **InvoiceForm (Invoice.vb) - PRIMARY TASK**
   This form needs significant UI development:
   
   **Required Controls:**
   - Labels for customer info (Name, Email, Address)
   - DataGridView or ListView for item display
   - Labels for subtotal, tax, discount, total
   - Buttons for "Print", "Save as PDF", "Email Invoice"
   - Date label for invoice date
   - Invoice number label
   
   **Suggested Layout:**
   ```
   +----------------------------------+
   |  INVOICE #12345      Date: XX/XX/XX
   |
   |  Customer Info Section
   |  Name: [Label]
   |  Email: [Label]
   |  Address: [Label]
   |
   |  Items Table
   |  | Item | Qty | Price | Total |
   |  +------+-----+-------+-------+
   |  | ...  | ... | ...   | ...   |
   |
   |  Subtotal: $XXX.XX
   |  Tax (10%): $XX.XX
   |  Discount: $XX.XX
   |  -----------------------
   |  TOTAL: $XXX.XX
   |
   |  [Print] [Save PDF] [Email] [Close]
   +----------------------------------+
   ```

4. **Accessing Data in Forms**
   ```vb
   ' In InvoiceForm, data is passed from Form1:
   ' Total is available via: Me.Total
   
   ' To receive items list, modify InvoiceForm.vb:
   Public Items As List(Of Dictionary(Of String, Decimal))
   
   ' Then in Form1.GenInvoiceBtn_Click:
   InvoiceForm.Items = FormattedItems
   InvoiceForm.Total = InvoiceGenHelpers.CalculateTotal(FormattedItems)
   ```

5. **Best Practices**
   - Keep logic in `.vb` files, UI in `.Designer.vb`
   - Use meaningful control names (e.g., `lblCustomerName`, `txtCustomerEmail`)
   - Handle form events properly (Load, Shown, Closing)
   - Test UI with different screen resolutions

### For Logic Developers (Business Layer)

#### Working with Utils/Helper Classes

1. **InvoiceGenHelpers.vb - Enhancement Areas**

   **Bug Fix Needed:**
   ```vb
   ' Current CheckItemsExists has a bug:
   Public Shared Function CheckItemsExists(ItemList As DataGridView, NewItem As String) As Object
       Dim RowIndex As Integer = 0
       For Each row As DataGridViewRow In ItemList.Rows
           If row.Cells(1).Value = NewItem Then
               Exit For      ' BUG: This exits the loop, making the Return statement unreachable
               Return RowIndex  ' This line never executes, so function always returns False
           End If
           RowIndex += 1
       Next
       Return False
   End Function
   
   ' Should be:
   Public Shared Function CheckItemsExists(ItemList As DataGridView, NewItem As String) As Object
       Dim RowIndex As Integer = 0
       For Each row As DataGridViewRow In ItemList.Rows
           If row.Cells(1).Value IsNot Nothing AndAlso row.Cells(1).Value.ToString() = NewItem Then
               Return RowIndex  ' Return immediately when found
           End If
           RowIndex += 1
       Next
       Return False  ' Only return False if not found
   End Function
   ```

   **Additional Functions to Implement:**
   - `CalculateTax(subtotal As Decimal, taxRate As Decimal)` - Calculate tax
   - `ApplyDiscount(total As Decimal, discountPercent As Decimal)` - Apply discount
   - `GenerateInvoiceNumber()` - Create unique invoice number
   - `ValidateEmail(email As String)` - Email validation
   - `FormatCurrency(amount As Decimal)` - Format money display

2. **PdfGenerator.vb - Enhancement Areas**

   **Current Limitations:**
   - Only supports customer info and total
   - No item list in PDF
   - No styling control
   - Fixed file paths
   
   **Suggested Enhancements:**
   ```vb
   ' Add method to include items in PDF
   Public Sub GeneratePdfWithItems(customerInfo As Dictionary(Of String, String),
                                   items As List(Of Dictionary(Of String, Object)),
                                   total As Decimal)
       ' Read template
       ' Replace customer placeholders
       ' Build HTML table for items
       ' Replace items placeholder
       ' Generate PDF
   End Sub
   
   ' Add method for custom file path
   Public Sub SetOutputPath(filePath As String)
       pdfFilePath = filePath
   End Sub
   ```

3. **Database Integration (SQLite)**

   **Current State:** SQLite package is included but not used
   
   **Recommended Implementation:**
   
   Create a new file `Utils/DatabaseHelper.vb`:
   ```vb
   Imports System.Data.SQLite
   
   Public Class DatabaseHelper
       Private Shared connectionString As String = "Data Source=invoices.db;Version=3;"
       
       Public Shared Sub InitializeDatabase()
           ' Create tables if not exist
       End Sub
       
       Public Shared Sub SaveInvoice(invoice As Invoice)
           ' Save invoice to database
       End Sub
       
       Public Shared Function GetInvoices() As List(Of Invoice)
           ' Retrieve all invoices
       End Function
   End Class
   ```
   
   **Database Schema Suggestion:**
   ```sql
   -- Invoices table
   CREATE TABLE Invoices (
       InvoiceId INTEGER PRIMARY KEY AUTOINCREMENT,
       InvoiceNumber TEXT UNIQUE,
       CustomerName TEXT,
       CustomerEmail TEXT,
       CustomerAddress TEXT,
       InvoiceDate TEXT,
       Subtotal REAL,
       Tax REAL,
       Discount REAL,
       Total REAL
   );
   
   -- Invoice Items table
   CREATE TABLE InvoiceItems (
       ItemId INTEGER PRIMARY KEY AUTOINCREMENT,
       InvoiceId INTEGER,
       ItemName TEXT,
       Quantity INTEGER,
       Price REAL,
       Total REAL,
       FOREIGN KEY (InvoiceId) REFERENCES Invoices(InvoiceId)
   );
   ```

4. **Testing Your Logic**
   ```vb
   ' Create test methods in a new file Utils/Tests.vb
   Public Class Tests
       Public Shared Sub TestCalculateTotal()
           Dim items As New List(Of Dictionary(Of String, Decimal))
           items.Add(New Dictionary(Of String, Decimal) From {{"Quantity", 2}, {"Price", 10.0}})
           items.Add(New Dictionary(Of String, Decimal) From {{"Quantity", 3}, {"Price", 5.0}})
           
           Dim result = InvoiceGenHelpers.CalculateTotal(items)
           Debug.Assert(result = 35.0, "Total should be 35.00")
       End Sub
   End Class
   ```

5. **Best Practices**
   - Use `Shared` methods for utility functions
   - Add error handling with Try-Catch blocks
   - Validate all inputs
   - Use meaningful variable names
   - Add XML documentation comments
   - Keep functions small and focused (Single Responsibility)

## Current Implementation Status

### ✅ Completed
- Basic form structure
- Item addition with validation
- DataGridView display
- Total calculation
- PDF generator class structure
- NuGet package setup

### 🚧 In Progress / TODO

#### High Priority
1. **Fix `CheckItemsExists` bug** (Logic team)
2. **Complete InvoiceForm UI** (UI team)
3. **Create invoice.html template** (UI/Logic collaboration)
4. **Add customer info fields to Form1** (UI team)

#### Medium Priority
5. **Implement database storage** (Logic team)
6. **Add tax and discount calculations** (Logic team)
7. **Add edit/delete item functionality** (UI team)
8. **Implement PDF generation trigger** (Logic team)

#### Low Priority
9. **Add invoice numbering system** (Logic team)
10. **Email invoice functionality** (Logic team)
11. **Print invoice functionality** (UI team)
12. **Add invoice history view** (UI/Logic collaboration)

## Common Tasks

### Adding a New Form
1. Right-click `Forms` folder in Solution Explorer
2. Add → Windows Form
3. Design UI in Designer
4. Add logic in `.vb` file
5. Reference from other forms using `FormName.Show()` or `FormName.ShowDialog()`

### Adding a New Utility Function
1. Open `Utils/InvoiceGenHelpers.vb`
2. Add `Public Shared Function` or `Sub`
3. Use from forms: `InvoiceGenHelpers.FunctionName(parameters)`

### Modifying the PDF Template
1. Edit `Utils/invoice.html`
2. Use placeholders: `{{PlaceholderName}}`
3. Update `PdfGenerator.GeneratePdfFromHtml()` to replace new placeholders

### Testing the Application
1. Build: `dotnet build`
2. Run: `dotnet run`
3. Or use Visual Studio: Press F5 to debug

## Troubleshooting

### Build Errors
- **Missing packages**: Run `dotnet restore`
- **SDK not found**: Install .NET 10.0 SDK
- **Form designer errors**: Rebuild project in Visual Studio

### Runtime Errors
- **PDF generation fails**: Ensure `invoice.html` exists and has valid HTML
- **Items not adding**: Check validation logic in `BtnAddItem_Click`
- **Total calculation wrong**: Verify `CalculateTotal` logic

### Common Issues
1. **"Cannot find file 'Invoice.html'"**
   - Ensure `invoice.html` is in the output directory
   - Set file properties: Copy to Output Directory = "Copy if newer"

2. **DataGridView not showing items**
   - Check if columns are properly defined in Designer
   - Verify row addition syntax: `ItemsList.Rows.Add(values)`

3. **Forms not showing**
   - Check if `Me.Hide()` was called without showing the new form
   - Use `ShowDialog()` for modal forms

## Contributing

### Workflow
1. Create a feature branch: `git checkout -b feature/your-feature-name`
2. Make changes
3. Test thoroughly
4. Commit: `git commit -m "Description of changes"`
5. Push: `git push origin feature/your-feature-name`
6. Create Pull Request

### Code Style
- Use meaningful variable names
- Add comments for complex logic
- Follow VB.NET naming conventions (PascalCase for methods, camelCase for variables)
- Keep methods under 50 lines when possible

## Team Coordination

### UI Team Responsibilities
- Design and implement form layouts
- Handle user input and validation feedback
- Ensure responsive and user-friendly interface
- Integrate with business logic methods

### Logic Team Responsibilities
- Implement calculation and validation functions
- Database operations
- PDF generation improvements
- Error handling and data processing

### Collaboration Points
- **Invoice display**: UI team designs layout, Logic team provides data formatting
- **PDF generation**: Logic team handles generation, UI team designs HTML template
- **Data validation**: Both teams coordinate on validation rules and user feedback

## Resources

### Visual Basic .NET
- [Microsoft VB.NET Documentation](https://docs.microsoft.com/en-us/dotnet/visual-basic/)
- [Windows Forms Documentation](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)

### Libraries
- [iText7 Documentation](https://itextpdf.com/en/resources/api-documentation/itext-7-net)
- [SQLite .NET Documentation](https://system.data.sqlite.org/index.html/doc/trunk/www/index.wiki)

### Tools
- [Visual Studio 2022](https://visualstudio.microsoft.com/)
- [.NET SDK](https://dotnet.microsoft.com/download)
