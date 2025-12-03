# Remaining Tasks & Recommendations

## ✅ Already Completed
- ✅ Operator prevention fixed
- ✅ Form renamed to `MainForm_241439P`
- ✅ Status display added
- ✅ lblID with GUID copy functionality (already implemented)
- ✅ TopMost = true (already set)
- ✅ Modulus operator (verified implemented)
- ✅ 10˟ and e˟ functions (verified implemented)

---

## 🔴 High Priority - Must Fix

### 1. Solution & Project Naming (2 marks)
**Status:** ❌ **NOT COMPLIANT**

**Current:**
- Solution: `Calculator Application`
- Project: `Calculator Application`

**Required:**
- Solution: `Calculator_241439P`
- Project: `Calculator_241439P`

**How to Fix (Manual in Visual Studio):**
1. Right-click solution in Solution Explorer → Rename → `Calculator_241439P`
2. Right-click project in Solution Explorer → Rename → `Calculator_241439P`
3. Close Visual Studio
4. Rename folder: `Calculator Application` → `Calculator_241439P`
5. Reopen solution in Visual Studio
6. Verify it builds correctly

**Impact:** 2 marks deduction if not fixed

---

## 🟡 Medium Priority - Should Fix

### 2. Precision to 6 Significant Digits
**Status:** ⚠️ **NEEDS VERIFICATION/FIX**

**Issue:** `FormatNumber()` trims trailing zeros but doesn't enforce 6 decimal places for results like:
- `3 [ln] → 1.098612` (should show exactly 6 digits)
- `3 [1/x] → 0.333333` (should show exactly 6 digits)

**Current Behavior:** Shows as many digits as calculated, then trims trailing zeros

**Test Cases from Requirements:**
- `3 [ln] → 1.098612` ✅ (should work)
- `1.098612 [e˟] → 2.999999` ✅ (should work)
- `3 [1/x] → 0.333333` ⚠️ (might show more/less digits)

**Recommendation:** Update `FormatNumber()` to format results to 6 decimal places when the result is from a calculation (not user input).

**Impact:** Part of Task B (14 marks) - minor deduction possible

---

## 🟢 Low Priority - Nice to Have

### 3. Manual Testing Checklist
**Status:** ⚠️ **RECOMMENDED**

Test all the requirements to ensure everything works:
- [ ] Basic arithmetic: `4 x 6 ÷ 2 + 13 - 26 = -1`
- [ ] Modulus: `5 % 9 = 5`, `9 % 5 = 4`
- [ ] Advanced functions: `3 [10˟] → 1000`, `1.098612 [e˟] → 2.999999`
- [ ] Operator prevention: `1++2` should become `1+2`
- [ ] Keyboard input: `10 ÷ 2 x 5 + 6 – 1 = → 30`
- [ ] Status display updates correctly

---

## 📋 Summary

### Must Do (Before Submission):
1. **Rename Solution & Project** to `Calculator_241439P` (2 marks)

### Should Do (For Full Marks):
2. **Verify/Update Precision** formatting (minor marks)

### Nice to Have:
3. **Test everything** to ensure it works

---

## 🎯 Quick Action Plan

1. **Right now:** Rename solution/project in Visual Studio (5 minutes)
2. **Optional:** Test precision formatting and update if needed (10 minutes)
3. **Before submission:** Run through test checklist (15 minutes)

---

## 💡 Notes

- Form naming is ✅ **DONE** (MainForm_241439P)
- Most features are ✅ **IMPLEMENTED**
- Main remaining task is **naming conventions** (solution/project)
- Precision might be fine as-is, but worth testing



