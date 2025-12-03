# Phase 1: Spacing & Sizing Standardization

## Goal
Standardize button sizes and spacing in Designer for both Standard and Scientific modes. Focus on spacing/sizing only, not layout reorganization.

## Scientific Mode - Current Issues

### Button Heights
- ✅ Most buttons: 60px × 36px (CORRECT)
- ⚠️ Need to verify ALL are 36px

### Column Spacing Issues
- Column 0: 0px ✅
- Column 1: 66px ✅
- Column 2: 132px ✅
- Column 3: 198px ✅
- Column 4: 264px ✅
- Column 5: 330px ✅ (some buttons already here)
- ❌ **Problem**: Some buttons at X=396 (should be 330 or removed)

### Row Spacing Issues
- Current: 0, 40, 80, 120, 160, 200, 240, 280, 320 (40px spacing) ✅
- This is CORRECT - 40px row spacing

### Specific Button Position Issues

**Row 0 (Y=0):**
- Square(0), Factorial(66), Power(132), Log(198), Ln(264), 10x(330) ✅
- Ex was at 396, moved to (330, 40) - but conflicts with CubeRoot

**Row 1 (Y=40):**
- Sin(0), Cos(66), Tan(132), DegreeRadian(198), Inverse(264), CubeRoot(330) ✅
- Ex moved to (330, 40) - CONFLICTS with CubeRoot!
- NthRoot was at 396, moved to (330, 80) - but conflicts with RecallMemory

**Row 2 (Y=80):**
- MPlus(0), MMinus(66), MR(132), MC(198), SaveMemory(264), RecallMemory(330) ✅
- NthRoot moved to (330, 80) - CONFLICTS with RecallMemory!

**Row 3 (Y=120):**
- Pi(0), E(66), ReciprocalSci(132), ModulusSci(198), PercentSci(264), CopySci(330) ✅
- ClearHistory at (330, 120) - CONFLICTS with CopySci!

**Row 4 (Y=160):**
- BackspaceSci(0), CESci(66), CSci(132), Undo(198), Redo(264), ThemeSci(330) ✅

## Fixes Needed

1. **ClearHistory conflict**: Currently at (330, 120) overlapping CopySci
   - Option A: Move to (330, 80) - but conflicts with RecallMemory
   - Option B: Move to different row/column
   - Option C: Remove from Scientific mode (keep only in History tab?)

2. **Ex button**: Currently at (330, 40) overlapping CubeRoot
   - Should be in Row 0, but 10x is already at (330, 0)
   - Option: Move to different position or remove

3. **NthRoot**: Currently at (330, 80) overlapping RecallMemory
   - Should be in Row 1, but CubeRoot is at (330, 40)
   - Option: Move to different position

## Standard Mode - Verification Needed

### Current Spacing
- Button size: 82px × 64px ✅
- Column spacing: 91px (82px + 9px gap) ✅
- Row spacing: 75px (64px + 11px gap) ✅

### Issues to Check
- Verify all buttons are 82px × 64px
- Verify column spacing is consistent (91px)
- Verify row spacing is consistent (75px)

## Action Plan

### Step 1: Fix Overlapping Buttons
1. ClearHistory: Move from (330, 120) to available position
2. Ex: Resolve conflict with CubeRoot at (330, 40)
3. NthRoot: Resolve conflict with RecallMemory at (330, 80)

### Step 2: Verify All Heights
- Check all Scientific buttons are 36px height
- Check all Standard buttons are 64px height

### Step 3: Verify Spacing
- Scientific: 66px column spacing, 40px row spacing
- Standard: 91px column spacing, 75px row spacing

## Notes
- Layout reorganization (moving buttons to different rows) will be Phase 2
- For Phase 1, focus on fixing overlaps and standardizing spacing
- Some buttons may need to be temporarily moved to resolve conflicts

