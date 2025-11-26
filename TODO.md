# Project 1: Calculator Application - TODO List

## Critical Requirements (Must Complete for Full Marks)

### 🔴 High Priority - Missing Features

#### 1. Standard/Scientific Mode Switching (8 marks) - **CRITICAL**
- [ ] Add Tab Control or Panel Control to switch between Standard and Scientific modes
- [ ] Create Standard mode layout (basic calculator)
- [ ] Create Scientific mode layout (advanced functions)
- [ ] Add mode indicator label/status display
- [ ] Test mode switching functionality
- **Status:** ❌ **NOT IMPLEMENTED** - This is worth 8 marks!

#### 2. Audio Enhancement (6 marks) - **CRITICAL**
- [ ] Find/create button click sound files (.wav or .mp3)
- [ ] Find/create result announcement sound files
- [ ] Import sound files into project `resource.resx`
- [ ] Implement button clicking sound playback
- [ ] Implement result announcement on `[=]` key press
- [ ] Implement unary operator result announcement (without `[=]`)
- [ ] Add Audio ON/OFF toggle button
- [ ] Test audio functionality
- **Status:** ❌ **NOT IMPLEMENTED** - This is worth 6 marks!

#### 3. Modulus Operator (%) - **VERIFY**
- [ ] Check if modulus operator is implemented
- [ ] Test: `5 % 9 = 5`
- [ ] Test: `9 % 5 = 4`
- [ ] Add keyboard support for `%` key if missing
- [ ] Verify it works in equation display
- **Status:** ⚠️ **NEEDS VERIFICATION**

#### 4. Exponential Functions (10˟ and e˟) - **VERIFY**
- [ ] Check if 10˟ (10 to the power of x) is implemented
- [ ] Check if e˟ (e to the power of x) is implemented
- [ ] Test: `3 [10˟] → 1000`
- [ ] Test: `1.098612 [e˟] → 2.999999`
- [ ] Add buttons if missing
- [ ] Verify precision (6 significant digits)
- **Status:** ⚠️ **NEEDS VERIFICATION**

#### 5. Multiple Consecutive Operator Prevention - **VERIFY**
- [ ] Review current operator input logic
- [ ] Test: `1++2` should not be allowed
- [ ] Test: `1+2+x3` should not be allowed
- [ ] Implement prevention logic if missing
- [ ] Add user-friendly error message
- **Status:** ⚠️ **NEEDS VERIFICATION**

---

### 🟡 Medium Priority - Verification & Improvements

#### 6. Naming Requirements Compliance (2 marks)
- [ ] Verify Solution Name: `Calculator_<Your Admin Number>`
- [ ] Verify Project Name: `Calculator_<Your Admin Number>`
- [ ] Verify Form Name: `MainForm_<Your Admin No>`
- [ ] Add Label ID (lblID) with Name, Admin Number, Module Group
- [ ] Implement `lblID_Click` handler with GUID copy functionality
- [ ] Add required namespaces: `System.Reflection`, `System.Runtime.InteropServices`
- [ ] Set Form `TopMost` property to `True`
- [ ] Set Form `StartPosition` to `CenterScreen`
- [ ] Verify Zip filename format: `PROJ01-[Gp]-[SN]-[Admin No]-[Name]`
- **Status:** ⚠️ **NEEDS VERIFICATION**

#### 7. Precision Control (6 Significant Digits)
- [ ] Review number formatting functions
- [ ] Ensure all results show 6 significant digits after decimal point
- [ ] Test: `3 [ln] → 1.098612` (not 1.098612...)
- [ ] Test: `3 [1/x] → 0.333333` (not 0.333333...)
- [ ] Update FormatNumber function if needed
- **Status:** ⚠️ **NEEDS VERIFICATION**

#### 8. Status Display Improvements
- [ ] Add status indicators for:
  - Current mode (Standard/Scientific)
  - Angle mode (DEG/RAD)
  - Inverse mode (ON/OFF)
  - Audio status (ON/OFF)
- [ ] Make status display visible and clear
- [ ] Update status when modes change
- **Status:** ⚠️ **NEEDS IMPROVEMENT**

---

### 🟢 Low Priority - Polish & Documentation

#### 9. Project Structure & File Organization
- [ ] Verify project is in correct location: `C:\!EGE202\Testing\`
- [ ] Ensure solution and project are NOT in same directory
- [ ] Verify all files are properly organized
- [ ] Clean up unused code/comments
- **Status:** ⚠️ **NEEDS VERIFICATION**

#### 10. Readme.txt File (Optional but Recommended)
- [ ] Create `readme.txt` in solution directory
- [ ] Document all enhanced features:
  - Compact design
  - Color scheme
  - Mode switching
  - Audio features
  - Status displays
  - Other enhancements
- [ ] Follow sample format from requirements
- **Status:** ⚠️ **OPTIONAL**

#### 11. Testing & Debugging
- [ ] Run through complete test sequence from requirements
- [ ] Test all basic arithmetic operations
- [ ] Test all advanced arithmetic operations
- [ ] Test equation display at all levels
- [ ] Test keyboard input
- [ ] Test special keys (ANS, COPY, DEL)
- [ ] Fix any bugs found
- **Status:** ⚠️ **ONGOING**

#### 12. Demo Preparation
- [ ] Prepare 3-minute test sequence demonstration
- [ ] Prepare answers for Q&A session:
  - Programming concepts explanation
  - Code explanation for Lab 5a & 5b
  - Error types & debugging techniques
  - Your implementation details
- [ ] Practice presentation
- **Status:** ⚠️ **PENDING**

---

## Implementation Checklist by Task

### Task A: Basic Arithmetic Operations (14 marks)
- [x] Binary Operators (+, -, ×, ÷)
- [x] Equal Button
- [x] Clear ALL Button
- [ ] Modulus Operator (%) - **VERIFY**

### Task B: Advanced Arithmetic Operations (14 marks)
- [x] Unary Operators (compute without [=])
- [x] Logarithm Functions (log₁₀, ln)
- [ ] Exponential Functions (10˟, e˟) - **VERIFY**
- [x] Trigonometry Functions (sin, cos, tan)
- [x] DEG/RAD mode toggle
- [ ] Precision to 6 significant digits - **VERIFY**

### Task C: Equation Display (14 marks)
- [x] Left-aligned display
- [x] Smaller font than RESULT
- [x] Lighter forecolor than RESULT
- [x] Show 1 operand + 1 operator
- [x] Show 2 operands + 1 operator
- [x] Show full equation expression
- [ ] Prevent multiple consecutive operators - **VERIFY**

### Task D: Hard Keyboard Entry (4 marks)
- [x] Numbers 0-9
- [x] Operators +, -, *, /
- [ ] Modulus % key - **VERIFY**
- [x] Enter key simulates [=]
- [x] C/c key simulates [AC]

### Task E: Additional Operation Keys (4 marks)
- [x] ANS key (memory recall)
- [x] COPY key (clipboard)
- [x] DEL key (backspace)

### GUI Enhancement (8 marks)
- [x] Good design color scheme
- [x] Compact design
- [x] Category buttons alignment & layout
- [ ] Standard/Scientific mode switching - **MISSING**

### Audio Enhancement (6 marks)
- [ ] Button clicking sound - **MISSING**
- [ ] Result announcement on [=] - **MISSING**
- [ ] Unary operator announcement - **MISSING**
- [ ] Audio ON/OFF button - **MISSING**
- [ ] Sound files in resource.resx - **MISSING**

### Others Enhancement (10 marks)
- [x] User friendly, ease of use
- [x] Handle peculiar inputs
- [x] Other challenging features (history, undo/redo, memory, themes)
- [ ] Status display - **NEEDS IMPROVEMENT**

---

## Quick Reference: Test Sequence

### Must Pass All Tests:

1. **Basic Arithmetic:**
   - `4 x 6 ÷ 2 + 13 - 26 = -1`
   - `5 % 9 = 5`
   - `9 % 5 = 4`
   - `[AC] → 0`

2. **Advanced Arithmetic:**
   - `3 [X²] → 9`
   - `9 [√] → 3`
   - `3 [10˟] → 1000` ⚠️
   - `1000 [log₁₀] → 3`
   - `3 [ln] → 1.098612`
   - `1.098612 [e˟] → 2.999999` ⚠️
   - `3 [1/x] → 0.333333`
   - `[±]` toggle test
   - Trig functions (RAD/DEG)

3. **Equation Display:**
   - `1 +` (1 operand + operator)
   - `1 + 2` (2 operands + operator)
   - `1 + 2 x 3 ÷ 4` (full equation)
   - Prevent `1++2` ⚠️
   - Prevent `1+2+x3` ⚠️

4. **Keyboard Input:**
   - `10 ÷ 2 x 5 + 6 – 1 = → 30`

5. **Special Keys:**
   - ANS recall
   - COPY to clipboard
   - DEL clears equation

---

## Priority Order for Implementation

1. **🔴 CRITICAL (14 marks):**
   - Standard/Scientific mode switching (8 marks)
   - Audio enhancement (6 marks)

2. **🟡 HIGH (Verification):**
   - Modulus operator verification
   - 10˟ and e˟ functions verification
   - Multiple operator prevention verification
   - Naming requirements compliance

3. **🟢 MEDIUM (Polish):**
   - Precision control
   - Status display improvements
   - Testing and debugging

4. **⚪ LOW (Documentation):**
   - Readme.txt file
   - Demo preparation

---

## Notes

- **Total Marks:** 100
- **Core Requirements:** 50 marks (Tasks A-E)
- **Enhancements:** 24 marks (GUI 8, Audio 6, Others 10)
- **Naming:** 2 marks
- **Checkpoints:** 4 marks
- **Demo:** 20 marks

**Current Estimated Score (if demo goes well):**
- Core Requirements: ~46/50 (missing modulus verification)
- GUI Enhancement: ~0/8 (missing mode switching)
- Audio Enhancement: 0/6 (not implemented)
- Others Enhancement: ~8/10 (good features, needs status display)
- Naming: ?/2 (needs verification)
- Checkpoints: ?/4
- **Estimated: ~54-60/100** (without mode switching and audio)

**To reach full marks, MUST implement:**
- Standard/Scientific mode switching (8 marks)
- Audio enhancement (6 marks)
- Verify all existing features work correctly





