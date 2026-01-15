
# InvoiceGen - Invoice Generation Application

## Project Overview

InvoiceGen is a complete Windows Forms desktop application built with Visual Basic .NET that enables users to create and manage invoices. The application provides an intuitive interface for adding items, calculating totals with VAT, and generating professional PDF invoices from HTML templates.

**Status:** ✅ **COMPLETED** - All core features implemented and functional.

## Features

✅ **Complete Invoice Management System** with the following capabilities:

- **Item Management**: Add multiple items with name, quantity, and price validation
- **Duplicate Detection**: Automatically merges duplicate items by incrementing quantity
- **Customer Information**: Capture customer name and address
- **Real-time Calculations**: 
  - Automatic subtotal calculation
  - 7.5% VAT calculation
  - Grand total computation
- **Professional Invoice Display**: Clean, modern invoice form with itemized list
- **PDF Generation**: Export invoices to PDF with professionally styled HTML templates
- **Input Validation**: Comprehensive validation for all user inputs
- **Item Deletion**: Remove items from invoice before generation

## Technology Stack

- **Framework**: .NET 10.0 Windows Forms
- **Language**: Visual Basic .NET
- **PDF Generation**: iText7 (v9.5.0) and iText7.pdfhtml (v6.3.1)
- **Build System**: .NET SDK

## Dependencies

The project uses the following NuGet packages:
- `itext7` (v9.5.0) - Core PDF library
- `itext.bouncy-castle-adapter` (v9.5.0) - Security provider for iText
- `itext7.pdfhtml` (v6.3.1) - HTML to PDF conversion
- `System.Data.SQLite` (v2.0.2) - SQLite database provider (available for future enhancements)

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

### Installation Steps

1. **Clone the repository:**
   ```bash
   git clone https://github.com/csc200group7-blip/visual_basic.git
   cd visual_basic
   ```

2. **Restore NuGet packages:**
   ```bash
   dotnet restore
   ```

3. **Build the project:**
   ```bash
   dotnet build
   ```

4. **Run the application:**
   ```bash
   dotnet run
   ```

   Or open `InvoiceGen.slnx` in Visual Studio 2022 and press F5 to run.

## How to Use

### Creating an Invoice

1. **Launch the Application**: Run the InvoiceGen application
2. **Enter Customer Information**:
   - Fill in the Customer Name
   - Fill in the Customer Address
3. **Add Items**:
   - Enter the Item Name
   - Enter the Quantity (must be a positive number)
   - Enter the Price (must be a positive decimal)
   - Click "Add Item" button
   - Repeat for all items (maximum 10 items per invoice)
4. **Review Items**: Check the items list in the data grid
5. **Delete Items** (optional): Click the "Delete" button in the Action column to remove unwanted items
6. **Generate Invoice**: Click the "Generate Invoice" button
7. **View Invoice**: The invoice form will display with:
   - Customer information
   - Itemized list with quantities and prices
   - Subtotal
   - VAT (7.5%)
   - Grand Total
8. **Export to PDF**: Click "Print Invoice" button and choose where to save the PDF file

### Invoice Calculations

- **Subtotal**: Sum of (Quantity × Price) for all items
- **VAT**: 7.5% of the subtotal
- **Grand Total**: Subtotal + VAT


## Application Architecture

### Form Flow
1. **Form1 (home.vb)** - Main entry point where users:
   - Enter customer name and address
   - Add items with name, quantity, and price
   - View items in a DataGridView with delete functionality
   - Generate invoices

2. **InvoiceForm (Invoice.vb)** - Displays the generated invoice with:
   - Customer information
   - Invoice number and date
   - Complete itemized list
   - Subtotal, VAT (7.5%), and Grand Total
   - PDF export functionality

### Data Flow
```
User Input → Validation → DataGridView → Generate Invoice → Invoice Form Display
                                                 ↓
                                          Calculate Totals (Subtotal + VAT)
                                                 ↓
                                          PDF Generation (HTML Template)
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
- Validates customer name and address are provided
- Iterates through DataGridView rows
- Creates formatted item list with quantities and prices
- Calculates total using `InvoiceGenHelpers.CalculateTotal()`
- Passes data to InvoiceForm (customer info and total)
- Hides main form and displays InvoiceForm

#### UI Controls:
- `txtCustomerName` - Customer name input
- `txtCustomerAddress` - Customer address input
- `txtItem` - Item name input
- `txtQuantity` - Quantity input
- `txtPrice` - Price input
- `ItemsList` - DataGridView displaying all items with delete button
- `BtnAddItem` - Button to add items
- `GenInvoiceBtn` - Button to generate invoice

### 2. Forms/Invoice.vb (Invoice Display Form)

Displays the complete invoice with all details and PDF export functionality.

#### Features:
- **Customer Information Display**: Shows customer name and address
- **Invoice Metadata**: Displays invoice number and date
- **Itemized List**: DataGridView showing all items with quantity, price, and totals
- **Automatic Calculations**: 
  - Subtotal calculation
  - 7.5% VAT calculation
  - Grand total display
- **PDF Export**: Generates professional PDF invoices with custom file location

#### Key Methods:

**`InvoiceForm_Load`** - Initializes the invoice display
- Generates invoice number
- Sets current date
- Loads customer information
- Populates items from the main form's data grid
- Calculates subtotal, VAT, and grand total
- Formats currency in Nigerian Naira (₦)

**`PrintBtn_Click`** - Handles PDF generation
- Collects all invoice data
- Formats items for PDF template
- Calls PdfGenerator to create PDF
- Shows file save dialog for user to choose location

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

**`CheckItemsExists(ItemList As DataGridView, NewItem As String, price As Integer)`**
- Searches DataGridView for an existing item by name and price
- Returns the row index (Integer) if found
- Returns False if not found
- Used to merge duplicate items by incrementing quantity

**`UpdateItemQty(ItemList As DataGridView, ItemRowIndex As String, NewQty As Integer)`**
- Updates the quantity of an existing item
- Takes the row index and adds the new quantity to the current quantity

### 4. Utils/PdfGenerator.vb (PDF Generation)

Handles PDF invoice generation using HTML templates with iText7 library.

#### Key Features:
- **File Save Dialog**: Allows users to choose where to save the PDF
- **HTML Template Processing**: Uses embedded HTML template from InvoiceHtml.vb
- **Dynamic Content Replacement**: Replaces placeholders with actual invoice data
- **Professional Formatting**: Currency symbols (₦), dates, and proper number formatting

#### Method:

**`GeneratePdfFromHtml(CustomerName, CustomerAddress, ItemsList, SubTotal, VAT, ShippingFee, InvoiceNo, Total)`**
- Prompts user to choose PDF save location
- Builds HTML table rows from items list
- Replaces all placeholders in HTML template:
  - `{{InvoiceNumber}}` → Invoice number
  - `{{Date}}` → Current date
  - `{{CustomerName}}` → Customer's name
  - `{{CustomerAddress}}` → Customer's address
  - `{{ItemsList}}` → HTML table rows with items
  - `{{SubTotal}}` → Formatted subtotal
  - `{{VAT}}` → Formatted VAT amount
  - `{{ShippingFee}}` → Shipping fee (currently 0)
  - `{{GrandTotal}}` → Formatted grand total
- Converts HTML to PDF using iText7's HtmlConverter with system fonts
- Displays success message after PDF generation

### 5. Utils/invoice.html & InvoiceHtml.vb (HTML Template)

Professional invoice template with modern styling.

#### Features:
- **Professional Design**: Clean, corporate look with blue color scheme
- **Responsive Layout**: Well-structured sections for all invoice components
- **Currency Support**: Nigerian Naira symbol (₦) support
- **Complete Information Display**:
  - Invoice header with number and date
  - Customer billing information
  - Itemized table with S/N, Item, Quantity, Unit Price, and Total columns
  - Totals section showing Subtotal, VAT (7.5%), Shipping, and Grand Total
  - Payment terms and notes in footer

## Implementation Status

### ✅ Completed Features

All core functionality has been implemented:

- ✅ Customer information entry (name and address)
- ✅ Item management with validation
- ✅ Duplicate item detection and quantity merging
- ✅ Item deletion functionality
- ✅ Real-time calculations (Subtotal, VAT, Grand Total)
- ✅ Professional invoice display form
- ✅ Invoice number generation
- ✅ PDF generation with professional HTML template
- ✅ Nigerian Naira (₦) currency support
- ✅ File save dialog for PDF export
- ✅ Complete input validation
- ✅ Maximum 10 items per invoice limit

### Future Enhancement Possibilities

While the core application is complete and functional, future developers could consider:
- Database integration for invoice history (SQLite package already included)
- Email functionality to send invoices directly
- Additional currency support
- Discount calculations
- Print preview functionality
- Invoice search and retrieval

## Troubleshooting

### Build Errors
- **Missing packages**: Run `dotnet restore`
- **SDK not found**: Install .NET 10.0 SDK
- **Form designer errors**: Rebuild project in Visual Studio

### Runtime Issues
- **PDF generation fails**: Ensure you have write permissions to the selected save location
- **Items not adding**: Verify all fields are filled with valid data
- **Currency symbols not displaying**: The application uses system fonts with Nigerian Naira support

## Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository
2. Create a feature branch: `git checkout -b feature/your-feature-name`
3. Make your changes and test thoroughly
4. Commit: `git commit -m "Description of changes"`
5. Push: `git push origin feature/your-feature-name`
6. Create a Pull Request

### Code Style Guidelines
- Use meaningful variable names
- Add comments for complex logic
- Follow VB.NET naming conventions (PascalCase for methods, camelCase for variables)
- Keep methods focused and under 50 lines when possible
- Add proper error handling with Try-Catch blocks

## Project Team

This project was developed by CSC200 Group 7 as a complete invoice generation solution.

## Resources

### Documentation
- [Microsoft VB.NET Documentation](https://docs.microsoft.com/en-us/dotnet/visual-basic/)
- [Windows Forms Documentation](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
- [iText7 Documentation](https://itextpdf.com/en/resources/api-documentation/itext-7-net)

### Tools
- [Visual Studio 2022](https://visualstudio.microsoft.com/)
- [.NET SDK](https://dotnet.microsoft.com/download)

## License

This project is part of an academic assignment for CSC200.

---

**Project Status**: ✅ Complete and Functional  
**Last Updated**: January 2026
