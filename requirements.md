# Project 1: Calculator Application - Requirements & Specifications

## Project Overview
- **Course:** EGDF20 - EGE202 Application Programming
- **Project Weight:** 20% of module
- **Deadline:** Week 8 Monday 12pm (File Upload) + Week 8 Demo Presentation
- **Framework:** Visual Studio, Windows Forms, C# (.NET Framework)
- **Individual Project**

## Naming Requirements (2 marks)

### Critical Naming Conventions:
- **Solution Name:** `Calculator_<Your Admin Number>`
- **Project Name:** `Calculator_<Your Admin Number>`
- **Form Name:** `MainForm_<Your Admin No>`
- **Zip Filename:** `PROJ01-[Gp]-[SN]-[Admin No]-[Name]`
- **Label ID:** Must show Name, Admin Number, Module Group (as per Figure 1)

### Form Properties:
- `TopMost` property: **True**
- `StartPosition` property: **CenterScreen**

### Label ID Implementation:
```csharp
private void lblID_Click(object sender, EventArgs e)
{
    Assembly assembly = Assembly.GetExecutingAssembly();
    var attribute = (GuidAttribute)assembly.GetCustomAttributes(typeof(GuidAttribute), true)[0];
    Clipboard.SetText(attribute.Value.ToString());
}
```
**Required Namespaces:**
- `using System.Reflection;`
- `using System.Runtime.InteropServices;`

---

## Part 1: Core Project Requirements (50 marks)

### Task A: Basic Arithmetic Operations (14 marks)

#### Requirements:
- ✅ **Binary Operators:** +, -, ×, ÷
- ✅ **Equal Button:** Compute final result
- ✅ **Clear ALL Button:** 
  - Result display shows zero
  - Clear the Equation display
- ⚠️ **Precedence & Associativity:** Will NOT be tested

#### Test Cases:
- `4 x 6 ÷ 2 + 13 - 26 = -1`
- `5 % 9 = 5` (modulus operator)
- `9 % 5 = 4`
- `[AC] → 0` (All Clear)

**Status:** ✅ **IMPLEMENTED** - Basic arithmetic operations working

---

### Task B: Advanced Arithmetic Operations (14 marks)

#### Requirements:
- ✅ **Unary Operators:** Operations that compute result WITHOUT hitting [=] button
- ✅ **Logarithm Functions:** log₁₀, ln
- ✅ **Exponential Functions:** 10˟, e˟
- ✅ **Trigonometry Functions:** sin, cos, tan (with DEG/RAD mode)
- ⚠️ **Precision:** Keep all results to 6 significant digits after floating point

#### Test Cases:
- `3 [X²] → 9`
- `9 [√] → 3`
- `3 [10˟] → 1000`
- `1000 [log₁₀] → 3`
- `3 [ln] → 1.098612`
- `1.098612 [e˟] → 2.999999`
- `3 [1/x] → 0.333333`
- `[±]` (Hit twice to toggle) → -0.333333 → 0.333333 → -0.333333
- `30 [sin]` → -0.988032 (RAD) or 0.5 (DEG)
- `10 [cos]` → -0.839072 (RAD) or 0.984808 (DEG)
- `45 [tan]` → 1.619775 (RAD) or 1 (DEG)

**Status:** ✅ **MOSTLY IMPLEMENTED** - Need to verify:
- ⚠️ 10˟ (10 to the power of x) - **NEEDS CHECK**
- ⚠️ e˟ (e to the power of x) - **NEEDS CHECK**
- ⚠️ Modulus operator (%) - **NEEDS CHECK**
- ⚠️ Precision to 6 significant digits - **NEEDS VERIFICATION**

---

### Task C: Equation Display (14 marks)

#### Requirements:
- ✅ **Equation Label:** Left-aligned display
- ✅ **Font Size:** Smaller than RESULT display
- ✅ **Forecolor:** Lighter than RESULT display
- ✅ **Expression Levels:**
  1. Showing at least 1 operand and 1 Operator: `1 +`
  2. Showing at least 2 operands and 1 Operator: `1 + 2`
  3. Showing more operands and Operators: `1 + 2 x 7 ÷ 4 – 5 % 2`
  4. **Handling multiple consecutive operators:**
     - `1++2` [Should not be allowed]
     - `1+2+x3` [Should not be allowed]
     - Provide your own logical solution

**Status:** ✅ **IMPLEMENTED** - Equation display working with preview
- ⚠️ **NEEDS VERIFICATION:** Multiple consecutive operator prevention

---

### Task D: Hard Keyboard Entry Operation (4 marks)

#### Requirements:
- ✅ **Minimum Required Keys:**
  - Numbers: `0, 1, 2, 3, 4, 5, 6, 7, 8, 9`
  - Operators: `+, -, *, /, %`
  - `Enter` key simulates `[=]`
  - `C` or `c` key simulates `[AC]`

#### Test Case:
- `10 ÷ 2 x 5 + 6 – 1 = → 30` (Hitting `[=]` or `[Enter]` is acceptable)

**Status:** ✅ **IMPLEMENTED** - Keyboard support working
- ⚠️ **NEEDS VERIFICATION:** Modulus (%) key on keyboard

---

### Task E: Additional Operation Keys (4 marks)

#### Requirements:
- ✅ **ANS Key:** Store computed result and recall after AC key is pressed
- ✅ **COPY Key:** Copy Result onto window clipboard for pasting in other applications
- ✅ **DEL Key:** 
  - Also Backspace key
  - Delete a character on Equation each time when pressed
  - When Equation is fully deleted, Result must show 0

#### Test Cases:
- ANS key → Recall previously computed result
- COPY key → Copy Result onto window clipboard
- Enter equation: `1 + 36 x 987`
- DEL Key → Hit `[Del]` key until Equation is fully clear, result display shows 0

**Status:** ✅ **IMPLEMENTED** - All features working
- ✅ ANS functionality (via memory recall)
- ✅ COPY functionality
- ✅ DEL/Backspace functionality

---

## Part 2: Enhancement Criteria (24 marks)

### GUI Enhancement (8 marks)

#### Requirements:
- ✅ **Good Design Color Scheme:** Professional, visually appealing
- ✅ **Compact Design:** Palm size (not too large)
- ✅ **Category Buttons Alignment & Layout:** Well-organized button groups
- ⚠️ **Standard/Scientific Mode Switching:**
  - Use Tab Control, Panel Control, Checkbox Control, or similar
  - Must be able to switch between Standard and Scientific calculator modes

**Status:** ✅ **IMPLEMENTED**
- ✅ Color scheme implemented (with theme support)
- ✅ Compact design
- ✅ Button alignment good
- ✅ Standard/Scientific mode switching via tab control (Standard + Scientific tabs)

---

### Audio Enhancement (6 marks)

#### Requirements:
- ✅ **Buttons Clicking Sound:** Sound when buttons are clicked
- ✅ **Computed Result Announcement:** 
  - Only upon `[EQUAL]` key press
- ✅ **Unary Operator Result Announcement:** 
  - Without `[EQUAL]` key (immediate announcement)
- ✅ **Audio ON/OFF Button:** Toggle audio on/off
- ✅ **Speech Toggle Button:** Next to result display to enable/disable spoken output
- ✅ **Sound Files:** Imported into PROJECT `resource.resx`

**Status:** ✅ **IMPLEMENTED** - Button sounds, toggle, and spoken announcements complete

---

### Others Enhancement (10 marks)

#### Requirements:
- ⚠️ **Status Display:** Correspond to respective buttons (show current mode, angle mode, etc.)
- ✅ **User Friendly, Ease of Use:** Intuitive interface
- ✅ **Handle Peculiar Inputs:** Error handling for edge cases
- ✅ **Other Challenging Features:** 
  - History tracking ✅
  - Undo/Redo ✅
  - Named memory ✅
  - Theme support ✅
  - Constants (π, e) ✅

**Status:** ✅ **MOSTLY IMPLEMENTED**
- ✅ User friendly
- ✅ Error handling
- ✅ Advanced features
- ⚠️ **NEEDS IMPROVEMENT:** Status display for buttons (show current state more clearly)

---

## Development Check Points (4 marks)

- ✅ Complete lab & SDL exercises up to Lab 5
- ⚠️ Complete Project 1 – Task A & B by Week 7 session 1

---

## Demo Presentation (20 marks)

- **Duration:** 3 mins test sequence + 3 mins Q&A
- **Requirements:**
  - Explain project coding implementation
  - Answer questions related to module programming concepts
  - Explain codes behind controls in Lab 5a & 5b
  - Explain type of program errors & debugging techniques
  - Explain group of codes implemented by yourself

---

## Critical Missing Features

### High Priority (Required for Full Marks):
1. ✅ **Standard/Scientific Mode Switching** (implemented with tab control)
2. ✅ **Audio Enhancement** (6 marks) - Click sounds, announcements, toggle, and resources complete
3. ⚠️ **Modulus Operator (%)** - Verify implementation
4. ⚠️ **10˟ and e˟ Functions** - Verify if implemented
5. ⚠️ **Multiple Consecutive Operator Prevention** - Verify logic

### Medium Priority (Enhancement):
1. ⚠️ **Status Display** - Better visual feedback for button states
2. ⚠️ **Precision Control** - Ensure 6 significant digits after decimal point
3. ⚠️ **Naming Convention** - Verify all naming requirements are met

---

## Test Sequence Checklist

### 1. Basic Arithmetic Operations
- [ ] `4 x 6 ÷ 2 + 13 - 26 = -1`
- [ ] `5 % 9 = 5`
- [ ] `9 % 5 = 4`
- [ ] `[AC] → 0`

### 2. Advanced Arithmetic Operations
- [ ] `3 [X²] → 9`
- [ ] `9 [√] → 3`
- [ ] `3 [10˟] → 1000`
- [ ] `1000 [log₁₀] → 3`
- [ ] `3 [ln] → 1.098612`
- [ ] `1.098612 [e˟] → 2.999999`
- [ ] `3 [1/x] → 0.333333`
- [ ] `[±]` toggle test
- [ ] Trigonometric functions (RAD/DEG modes)

### 3. Equation Display
- [ ] Left justification
- [ ] Smaller font
- [ ] Lighter forecolor
- [ ] Show `1 +` (1 operand + 1 operator)
- [ ] Show `1 + 2` (2 operands + 1 operator)
- [ ] Show `1 + 2 x 3 ÷ 4` (full equation)
- [ ] Prevent `1++2`
- [ ] Prevent `1+2+x3`

### 4. Hard Keyboard Input
- [ ] `10 ÷ 2 x 5 + 6 – 1 = → 30`

### 5. Special Key Operations
- [ ] ANS key recall
- [ ] COPY key to clipboard
- [ ] DEL key clears equation, shows 0 when empty

---

## Notes

- **Precedence & Associativity:** Will NOT be tested
- **Multiple uploads allowed:** Only latest upload before deadline is considered
- **Late submissions:** Will be considered as late
- **Plagiarism:** Strictly enforced - sharing work is considered plagiarism
- **Readme.txt:** Optional but recommended - document enhanced features

---

## Current Implementation Status Summary

✅ **Fully Implemented:**
- Basic arithmetic operations
- Advanced arithmetic operations (most)
- Equation display with preview
- Keyboard input support
- ANS, COPY, DEL functionality
- History tracking
- Undo/Redo
- Memory management
- Theme support
- Constants (π, e)

❌ **Missing:**
- Standard/Scientific mode switching (Tab Control/Panel)
- Audio enhancement (sounds, announcements, toggle)
- Modulus operator verification
- 10˟ and e˟ functions verification

⚠️ **Needs Verification:**
- Multiple consecutive operator prevention
- Precision to 6 significant digits
- Naming conventions compliance
- Status display improvements





