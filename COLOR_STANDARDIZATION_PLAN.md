# Color Standardization Plan

## Current Situation

### Theme System
- **ThemeManager.cs** defines 3 themes: Rustic, Light, Dark
- Colors are applied at runtime via `ApplyTheme()` method
- Designer has hardcoded colors (mostly Dark theme colors)

### Current Designer Colors
- **Function buttons**: `Color.FromArgb(142, 68, 173)` (purple) - Dark theme
- **Operator buttons**: `Color.FromArgb(41, 128, 185)` (blue) - Dark theme
- **Control buttons**: `Color.FromArgb(192, 57, 43)` (red) - Dark theme
- **Number buttons**: `Color.FromArgb(60, 60, 60)` (dark gray) - Dark theme
- **ForeColor**: Mostly `Color.White`

### Issues
1. Hardcoded colors scattered throughout Designer
2. Some buttons may have inconsistent colors
3. Colors don't match theme system (only defaults for designer preview)

## Standardization Options

### Option 1: Use ThemeManager Colors as Constants (Recommended)
- Create constants in Designer that reference ThemeManager default colors
- Makes it clear these are defaults
- Easier to maintain

### Option 2: Standardize to Dark Theme Colors
- Use Dark theme colors consistently throughout Designer
- These are already mostly used
- Runtime ApplyTheme() will override anyway

### Option 3: Create Color Constants Class
- Create a `DesignerColors` class with static readonly Color properties
- Reference ThemeManager.DarkColors
- Use throughout Designer

## Recommended Approach

**Use Option 2 + Document:**
1. Standardize all Designer colors to Dark theme values
2. Document that Designer colors are defaults only
3. Runtime ApplyTheme() handles actual theming

## Color Standard Values (Dark Theme)

```csharp
// Number buttons (0-9, decimal point)
NeutralButtonBackColor = Color.FromArgb(60, 60, 60)
NeutralButtonForeColor = Color.White

// Operator buttons (+, -, ×, ÷, =, ±, %, Undo, Redo, Theme, Audio)
OperatorButtonBackColor = Color.FromArgb(41, 128, 185)
OperatorButtonForeColor = Color.White

// Control buttons (C, CE, Backspace, Clear History)
ControlButtonBackColor = Color.FromArgb(192, 57, 43)
ControlButtonForeColor = Color.White

// Function buttons (sin, cos, log, sqrt, memory, constants, etc.)
FunctionButtonBackColor = Color.FromArgb(142, 68, 173)
FunctionButtonForeColor = Color.White
```

## Implementation Steps

1. Scan all buttons in Designer
2. Identify any inconsistent colors
3. Replace with standard Dark theme colors
4. Ensure all buttons follow the same pattern:
   - Numbers → NeutralButtonBackColor
   - Operators → OperatorButtonBackColor
   - Controls → ControlButtonBackColor
   - Functions → FunctionButtonBackColor
5. Document the color scheme


