# Calculator Application

A feature-rich scientific calculator application built with C# and Windows Forms (.NET 8.0).

## Features

### Basic Operations
- **Arithmetic**: Addition (+), Subtraction (−), Multiplication (×), Division (÷)
- **Power Operations**: Exponentiation (xʸ), Square (x²), Square Root (√), Cube Root (∛), Nth Root (ⁿ√)
- **Percentage Calculations**: Support for percentage operations with arithmetic

### Advanced Mathematical Functions
- **Logarithms**: Base 10 logarithm (log), Natural logarithm (ln)
- **Trigonometric Functions**: 
  - Sine (sin), Cosine (cos), Tangent (tan)
  - Inverse functions: Arcsin, Arccos, Arctan
  - Degree/Radian mode toggle
- **Other Functions**: Factorial (n!), Reciprocal (1/x)

### Memory Management
- **Standard Memory**: M+ (Memory Add), M− (Memory Subtract), MR (Memory Recall), MC (Memory Clear)
- **Named Memory**: Save and recall values with custom variable names
- **Persistent Storage**: Memory values are saved to disk and restored on startup

### History & Undo/Redo
- **Calculation History**: View past calculations in a scrollable list
- **History Persistence**: History is saved to disk and restored on startup
- **Undo/Redo**: Undo and redo operations (up to 100 steps)
- **Quick Recall**: Double-click any history entry to use its result

### User Interface
- **Preview Display**: Shows current expression being calculated
- **Real-time Calculation**: See results as you type the second operand
- **Visual Feedback**: Button highlights when clicked
- **Keyboard Support**: Full keyboard and numpad support
- **Copy to Clipboard**: Copy results with Ctrl+C or the Copy button
- **Dark/Light Theme**: Toggle between light and dark themes with persistent preference

### Constants
- **π (Pi)**: Mathematical constant π
- **e**: Euler's number

## Keyboard Shortcuts

| Key | Action |
|-----|--------|
| `0-9` | Number input |
| `+` | Addition |
| `-` | Subtraction |
| `*` or `Shift+8` | Multiplication |
| `/` | Division |
| `.` | Decimal point |
| `Enter` | Equals |
| `Escape` | Clear All (C) |
| `Backspace` | Backspace |
| `Ctrl+C` | Copy to clipboard |
| `Shift+5` | Percentage |
| `Ctrl+Z` | Undo |
| `Ctrl+Y` | Redo |
| `Shift+I` | Toggle Inverse mode |
| `Shift+D` | Toggle Degree/Radian mode |

## Building and Running

### Prerequisites
- .NET 8.0 SDK or later
- Windows OS (Windows Forms application)

### Build Instructions

1. Clone or download this repository
2. Open a terminal in the project directory
3. Restore dependencies:
   ```bash
   dotnet restore
   ```
4. Build the solution:
   ```bash
   dotnet build
   ```
5. Run the application:
   ```bash
   dotnet run --project "Calculator Application/Calculator Application.csproj"
   ```

### Running Tests

To run the unit tests:

```bash
dotnet test
```

The test suite includes 102+ tests covering all calculation functions, error handling, and edge cases.

## Usage Examples

### Basic Calculation
1. Enter a number: `123`
2. Press an operator: `+`
3. Enter another number: `456`
4. Press `=` or `Enter` to get the result: `579`

### Using Functions
1. Enter a number: `25`
2. Click `√` (square root) to get: `5`

### Using Memory
1. Calculate a value: `100 + 50 = 150`
2. Click `Save` button
3. Enter a variable name (e.g., `total`)
4. Later, click `Recall` to retrieve the saved value

### Using History
- All calculations are automatically saved to history
- Double-click any history entry to use its result
- Click `Clear History` to remove all history entries

### Using Undo/Redo
- After any operation, press `Ctrl+Z` to undo
- Press `Ctrl+Y` to redo
- Supports up to 100 undo steps

## Project Structure

```
Calculator Application/
├── Calculator Application/
│   ├── MainForm.cs              # Main calculator form and logic
│   ├── MainForm.Designer.cs     # UI designer code
│   ├── CalculatorEngine.cs      # Core calculation engine (testable)
│   ├── Program.cs               # Application entry point
│   ├── MemoryNameDialog.cs       # Dialog for naming memory variables
│   ├── MemoryRecallDialog.cs    # Dialog for recalling memory variables
│   └── NthRootDialog.cs         # Dialog for nth root input
├── Calculator Application.Tests/
│   └── CalculatorEngineTests.cs # Unit tests
└── README.md                     # This file
```

## Technical Details

- **Framework**: .NET 8.0
- **UI Framework**: Windows Forms
- **Testing Framework**: xUnit
- **Architecture**: Separation of concerns with `CalculatorEngine` class for testable calculation logic

## Data Storage

The application stores data in the user's AppData folder:
- **History**: `%AppData%\Calculator Application\history.txt`
- **Memory**: `%AppData%\Calculator Application\memory.txt`

Data persists between application sessions.

## License

This project is provided as-is for educational and personal use.

## Contributing

Contributions are welcome! Please feel free to submit issues or pull requests.

## Future Enhancements

Potential features for future versions:
- Expression parser for direct input
- Unit conversions
- Graphing capabilities
- Additional mathematical constants
- Export history to CSV/JSON

---

**Note**: This calculator follows standard mathematical order of operations and handles edge cases like division by zero, negative square roots, and invalid inputs gracefully.

