# Phase 2: Layout Reorganization Plan

## Goal
Reorganize Scientific mode buttons to fit everything within the 6-column grid (0, 66, 132, 198, 264, 330) and eliminate buttons at X=396.

## Current Scientific Mode Layout Issues

### Buttons Outside Grid (X=396)
- btnEx at (396, 0)
- btnNthRoot at (396, 40)
- btnClearHistory at (396, 80)

### Column 5 (330) Currently Occupied
- Row 0: btn10x
- Row 1: btnCubeRoot
- Row 2: btnRecallMemory
- Row 3: btnCopySci
- Row 4: btnThemeSci
- Row 5: btnAudioToggleSci

## Proposed Reorganized Layout

### Row 0 (Y=0): Basic Functions
- Column 0: btnSquare (x²)
- Column 1: btnFactorial (n!)
- Column 2: btnPower (xʸ)
- Column 3: btnLog (log)
- Column 4: btnLn (ln)
- Column 5: btn10x (10˟)

### Row 1 (Y=40): Trig & Exponential
- Column 0: btnSin (sin)
- Column 1: btnCos (cos)
- Column 2: btnTan (tan)
- Column 3: btnDegreeRadian (DEG/RAD)
- Column 4: btnInverse (Inv)
- Column 5: btnEx (e˟) ← MOVED from (396, 0)

### Row 2 (Y=80): Roots & Powers
- Column 0: btnSqrt (√)
- Column 1: btnCubeRoot (∛)
- Column 2: btnNthRoot (ⁿ√) ← MOVED from (396, 40)
- Column 3: btnReciprocal (1/x)
- Column 4: btnPercent (%)

### Row 3 (Y=120): Memory Operations
- Column 0: btnMPlus (M+)
- Column 1: btnMMinus (M−)
- Column 2: btnMR (MR)
- Column 3: btnMC (MC)
- Column 4: btnSaveMemory (Save)
- Column 5: btnRecallMemory (Recall)

### Row 4 (Y=160): Constants & Utilities
- Column 0: btnPi (π)
- Column 1: btnE (e)
- Column 2: btnModulus (%)
- Column 3: btnCopySci (Copy)
- Column 4: btnClearHistory (Clear Hist) ← MOVED from (396, 80)
- Column 5: [Empty or Theme]

### Row 5 (Y=200): Controls
- Column 0: btnBackspaceSci (⌫)
- Column 1: btnCESci (CE)
- Column 2: btnCSci (AC)
- Column 3: btnUndo (Undo)
- Column 4: btnRedo (Redo)
- Column 5: btnThemeSci (Theme)

### Row 6 (Y=240): Number Row 1
- Column 0: btn7Sci (7)
- Column 1: btn8Sci (8)
- Column 2: btn9Sci (9)
- Column 3: btnDivideSci (÷)
- Column 4: btnSqrtSci (√)
- Column 5: btnAudioToggleSci (Audio)

### Row 7 (Y=280): Number Row 2
- Column 0: btn4Sci (4)
- Column 1: btn5Sci (5)
- Column 2: btn6Sci (6)
- Column 3: btnMultiplySci (×)
- Column 4: btnNegateSci (±)

### Row 8 (Y=320): Number Row 3 & Bottom
- Column 0: btn1Sci (1)
- Column 1: btn2Sci (2)
- Column 2: btn3Sci (3)
- Column 3: btnSubtractSci (−)
- Column 4: btnAddSci (+)

### Row 9 (Y=360): Bottom Row
- Column 0: btn0Sci (0) - could span 2 columns
- Column 1: [empty or span]
- Column 2: btnDotSci (.)
- Column 3: btnEquSci (=)

## Changes Summary

### Buttons Moved
1. **btnEx**: (396, 0) → (330, 40) - Row 1, Column 5
2. **btnNthRoot**: (396, 40) → (132, 80) - Row 2, Column 2
3. **btnClearHistory**: (396, 80) → (264, 160) - Row 4, Column 4

### Buttons Reorganized
- Row 2: Added Sqrt, CubeRoot, NthRoot, Reciprocal, Percent (roots/powers group)
- Row 3: Memory operations grouped together
- Row 4: Constants and utilities grouped together

### Grid Utilization
- All buttons within 6-column grid (0-330)
- Better logical grouping
- No buttons outside tab width


