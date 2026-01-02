# InvoiceGen - Invoice Generator Application

A Windows Forms desktop application built with Visual Basic .NET for creating and managing invoices. This application provides an intuitive interface for adding items, calculating totals, and generating professional invoices.

## Features

- **Item Management**: Add multiple items to an invoice with name, quantity, and price
- **Input Validation**: Comprehensive validation for all input fields to ensure data integrity
- **Real-time Display**: Items are displayed in a data grid with serial numbers for easy tracking
- **Invoice Generation**: Generate complete invoices from the added items
- **Maximum Item Limit**: Prevents adding more than 10 items per invoice for optimal performance
- **User-Friendly Interface**: Clean and intuitive Windows Forms interface

## Technology Stack

- **Framework**: .NET 10.0 (Windows)
- **Language**: Visual Basic .NET
- **UI Framework**: Windows Forms
- **Target Platform**: Windows Desktop

## Project Structure

```
visual_basic/
├── Forms/                          # UI Form files
│   ├── home.vb                    # Main form with item entry logic
│   ├── home.Designer.vb           # Auto-generated form designer code
│   ├── home.resx                  # Form resources
│   ├── Invoice.vb                 # Invoice display form
│   ├── Invoice.Designer.vb        # Invoice form designer code
│   └── Invoice.resx               # Invoice form resources
├── Utils/                          # Utility classes
│   ├── InvoiceCalculator.vb       # Invoice calculation logic (planned)
│   └── PdfGenerator.vb            # PDF generation functionality (planned)
├── My Project/                     # Application configuration
│   ├── Application.Designer.vb    # Application settings
│   └── Application.myapp          # Application metadata
├── ApplicationEvents.vb           # Application-level event handlers
├── InvoiceGen.vbproj             # Visual Basic project file
├── InvoiceGen.slnx               # Solution file
└── .gitignore                     # Git ignore rules
```

## Prerequisites

Before running this application, ensure you have:

- **Windows Operating System**: Windows 10 or later
- **.NET SDK**: .NET 10.0 SDK or later
- **Visual Studio** (recommended): Visual Studio 2022 or later with Visual Basic support, OR
- **Visual Studio Code**: With appropriate .NET extensions

## Installation & Setup

1. **Clone the repository**:
   ```bash
   git clone https://github.com/csc200group7-blip/visual_basic.git
   cd visual_basic
   ```

2. **Restore dependencies**:
   ```bash
   dotnet restore
   ```

3. **Build the project**:
   ```bash
   dotnet build
   ```

4. **Run the application**:
   ```bash
   dotnet run
   ```

## Usage

### Adding Items to Invoice

1. Launch the application to see the main form (Form1)
2. Enter the item details:
   - **Item Name**: Enter a descriptive name for the item
   - **Quantity**: Enter the number of items (must be a positive integer)
   - **Price**: Enter the unit price (must be a positive decimal number)
3. Click the **"Add item"** button to add the item to the invoice
4. The item will appear in the data grid with a serial number

### Input Validation

The application validates all inputs to ensure data quality:
- Item name cannot be empty
- Quantity must be a valid positive integer
- Price must be a valid positive decimal number
- Maximum of 10 items can be added per invoice

### Generating an Invoice

1. After adding all desired items to the grid
2. Click the **"Generate Invoice"** button
3. The application will process the items and generate the invoice

## Development Features

### Main Components

- **Form1 (home.vb)**: 
  - Main user interface for item entry
  - Handles item validation and addition
  - Manages the items data grid
  - Limited to 10 items per invoice

- **Invoice Form**: 
  - Displays the generated invoice (implementation in progress)

- **Utility Classes**:
  - `InvoiceCalculator`: Handles invoice calculations (planned feature)
  - `PdfGenerator`: Generates PDF invoices (planned feature)

### Key Validations

- Empty field checking
- Numeric type validation using `TryParse`
- Positive value validation
- Item count limit enforcement

## Future Enhancements

- Complete implementation of InvoiceCalculator for totals and tax calculations
- PDF generation functionality via PdfGenerator
- Save and load invoice functionality
- Custom invoice templates
- Print preview and direct printing
- Database integration for invoice history
- Customer information management

## Contributing

This project is part of CSC200 Group 7. If you're a team member:

1. Create a new branch for your feature
2. Make your changes
3. Test thoroughly
4. Submit a pull request for review

## Project Information

- **Course**: CSC200
- **Group**: Group 7
- **Project Type**: Desktop Application Development
- **Language**: Visual Basic .NET

## License

This project is created for educational purposes as part of CSC200 coursework.

## Support

For issues, questions, or suggestions, please open an issue in the GitHub repository or contact the development team.

---

**Note**: This application is currently in active development. Some features are planned but not yet implemented. Check the project structure and code comments for implementation status.
