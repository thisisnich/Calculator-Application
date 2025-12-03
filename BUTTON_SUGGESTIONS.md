# Button Suggestions for Empty Positions

## Current Empty Positions

After moving sqrt above ClearHistory, we have these empty positions:

1. **Position (264, 200)** - Row 5, Column 4
   - Previously occupied by btnSqrtSci (moved to 264, 160)
   - In the number row (7, 8, 9, ÷, [empty], Audio)

2. **Position (330, 120)** - Row 3, Column 5
   - Currently empty (btnUndo moved here temporarily, but could be moved)
   - In the constants/operations row (π, e, Save, Recall, 1/x, [empty])

## Suggested Buttons

### Option 1: Common Scientific Functions

**For Position (264, 200) - Number Row:**
- **btnPercentSci** - Currently at (198, 320), could move here
  - Makes sense: Percentage is commonly used with numbers
  - Logical grouping: With number pad operations
  - **Text**: "%"

**For Position (330, 120) - Operations Row:**
- **btnModulusSci** - Currently at (330, 280), could move here
  - Makes sense: Modulus is a mathematical operation, fits with constants/operations
  - Better grouping: With other operations (Save, Recall, 1/x)
  - **Text**: "mod"

### Option 2: Additional Useful Functions

**For Position (264, 200):**
- **btnCopySci** - Currently at (330, 240), could move here
  - Makes sense: Copy is a utility function, could be with number operations
  - **Text**: "Copy"

**For Position (330, 120):**
- Keep **btnModulusSci** here (as suggested above)

### Option 3: Reorganize Existing Buttons

**For Position (264, 200):**
- Move **btnPercentSci** from (198, 320) to here
  - Better position: With number pad
  - More accessible: Users often use % with numbers

**For Position (330, 120):**
- Move **btnModulusSci** from (330, 280) to here
  - Better grouping: With other mathematical operations
  - More logical: Near constants and memory operations

## Recommended Solution

**Best Option:**
1. **Position (264, 200)**: Move **btnPercentSci** from (198, 320)
   - Better UX: Percentage is commonly used with numbers
   - Logical grouping: With ÷ and other operations

2. **Position (330, 120)**: Move **btnModulusSci** from (330, 280)
   - Better grouping: With constants and memory operations
   - More accessible: Modulus is a mathematical operation

This creates a more logical layout:
- Operations row (120): π, e, Save, Recall, 1/x, mod
- Number row (200): 7, 8, 9, ÷, %, Audio

## Alternative: New Buttons (if needed)

If you want to add completely new buttons, consider:
1. **Log base 2** (log₂) - Useful for computer science
2. **Random number** - Generate random numbers
3. **Round** - Round to nearest integer
4. **Floor/Ceiling** - Round down/up functions
5. **Absolute value** - |x| function

But these would require implementing new functionality in the code.


