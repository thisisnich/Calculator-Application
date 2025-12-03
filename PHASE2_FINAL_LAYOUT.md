# Phase 2: Final Reorganized Scientific Mode Layout

## Grid System
- **Columns**: 0, 66, 132, 198, 264, 330 (6 columns, 66px spacing)
- **Rows**: 0, 40, 80, 120, 160, 200, 240, 280, 320 (40px spacing)

## Final Layout

### Row 0 (Y=0): Basic Functions
- (0, 0): btnSquare (x²)
- (66, 0): btnFactorial (n!)
- (132, 0): btnPower (xʸ)
- (198, 0): btnLog (log)
- (264, 0): btnLn (ln)
- (330, 0): btn10x (10˟)

### Row 1 (Y=40): Trig & Exponential
- (0, 40): btnSin (sin)
- (66, 40): btnCos (cos)
- (132, 40): btnTan (tan)
- (198, 40): btnDegreeRadian (DEG/RAD)
- (264, 40): btnInverse (Inv)
- (330, 40): btnEx (e˟) ✅ MOVED from (396, 0)

### Row 2 (Y=80): Memory & Roots
- (0, 80): btnMPlus (M+)
- (66, 80): btnMMinus (M−)
- (132, 80): btnMR (MR)
- (198, 80): btnMC (MC)
- (264, 80): btnCubeRoot (∛)
- (330, 80): btnNthRoot (ⁿ√) ✅ MOVED from (396, 40)

### Row 3 (Y=120): Constants & Operations
- (0, 120): btnPi (π)
- (66, 120): btnE (e)
- (132, 120): btnSaveMemory (Save)
- (198, 120): btnRecallMemory (Recall)
- (264, 120): btnReciprocalSci (1/x)
- (330, 120): btnModulusSci (mod)

### Row 4 (Y=160): Controls & Utilities
- (0, 160): btnBackspaceSci (⌫)
- (66, 160): btnCESci (CE)
- (132, 160): btnCSci (AC)
- (198, 160): btnUndo (Undo)
- (264, 160): btnRedo (Redo)
- (330, 160): btnClearHistory (Clear Hist) ✅ MOVED from (396, 80)

### Row 5 (Y=200): Number Row 1
- (0, 200): btn7Sci (7)
- (66, 200): btn8Sci (8)
- (132, 200): btn9Sci (9)
- (198, 200): btnDivideSci (÷)
- (264, 200): btnSqrtSci (√)
- (330, 200): btnAudioToggleSci (Audio)

### Row 6 (Y=240): Number Row 2
- (0, 240): btn4Sci (4)
- (66, 240): btn5Sci (5)
- (132, 240): btn6Sci (6)
- (198, 240): btnMultiplySci (×)
- (264, 240): btnNegateSci (±)

### Row 7 (Y=280): Number Row 3
- (0, 280): btn1Sci (1)
- (66, 280): btn2Sci (2)
- (132, 280): btn3Sci (3)
- (198, 280): btnSubtractSci (−)
- (264, 280): btnAddSci (+)

### Row 8 (Y=320): Bottom Row
- (0, 320): btn0Sci (0)
- (66, 320): btnDotSci (.)
- (132, 320): btnEquSci (=)

## Buttons Moved
1. ✅ btnEx: (396, 0) → (330, 40)
2. ✅ btnNthRoot: (396, 40) → (330, 80)
3. ✅ btnClearHistory: (396, 80) → (330, 160)

## Buttons Reorganized
- Row 2: Memory operations + roots grouped
- Row 3: Constants + memory save/recall + operations
- Row 4: All control buttons grouped together

## Remaining Issues to Fix
- btnCopySci needs new position (was at 330, 120, now conflicts)
- btnPercentSci needs new position (was at 264, 120, now conflicts)
- btnThemeSci needs new position (was at 330, 160, now conflicts)


