# Plan to Fix Layout Discrepancy Between Designer and Runtime

## Problem Analysis

The layout appears different in the designer vs when running because runtime code is overriding the designer positions.

## Functions That Modify Layout at Runtime

### 1. `InitializeTabs()` (line 1794)
   - **Called from**: `InitializeRuntimeFeatures()` (line 112)
   - **What it does**: Adds tab pages to `tabModes`
   - **Issue**: Adding tabs triggers `SelectedIndexChanged` event, which calls `ApplyLayout()`

### 2. `TabModes_SelectedIndexChanged()` (line 1807)
   - **Triggered by**: Adding tabs in `InitializeTabs()` OR user switching tabs
   - **What it does**: Calls `ApplyLayout()`
   - **Issue**: This runs on initialization even though we don't want it to

### 3. `ApplyLayout()` (line 1812)
   - **Called from**: `TabModes_SelectedIndexChanged()` (line 1809)
   - **What it does**: 
     - If Standard mode: Calls `RestoreStandardLayout()` (line 1819)
     - If Scientific mode: Repositions all buttons for Scientific layout
   - **Issue**: `RestoreStandardLayout()` recalculates positions instead of preserving designer positions

### 4. `RestoreStandardLayout()` (line 1892)
   - **Called from**: `ApplyLayout()` when in Standard mode (line 1819)
   - **What it does**: 
     - Hides Scientific-only buttons
     - **RECALCULATES** all Standard button positions programmatically (lines 1919-2009)
     - Sets form size
   - **Issue**: This overrides the designer positions! It should preserve them instead.

## Root Cause

When the form loads:
1. Designer sets button positions ✅
2. `InitializeRuntimeFeatures()` calls `InitializeTabs()` 
3. `InitializeTabs()` adds tabs, which triggers `SelectedIndexChanged`
4. `SelectedIndexChanged` calls `ApplyLayout()`
5. `ApplyLayout()` calls `RestoreStandardLayout()` for Standard mode
6. `RestoreStandardLayout()` **recalculates and overrides** all designer positions ❌

## Solution Plan

### Option 1: Prevent Layout Changes on Initial Load (RECOMMENDED)
- Add a flag `isInitializing` to prevent `ApplyLayout()` from running during initialization
- Only allow `ApplyLayout()` to run when user actually switches tabs
- This preserves designer positions on startup

### Option 2: Make RestoreStandardLayout() Preserve Designer Positions
- Instead of recalculating positions, check if buttons are already in correct positions
- Only move buttons if they're in wrong positions (e.g., after Scientific mode)
- This is more complex but allows for dynamic switching

### Option 3: Remove RestoreStandardLayout() Entirely
- Let designer positions be the source of truth
- Only handle Scientific mode repositioning
- When switching back to Standard, just hide Scientific buttons and show Standard buttons
- Don't touch positions of Standard buttons

## Recommended Implementation (Option 1 + Option 3 Hybrid)

1. **Add initialization flag**:
   ```csharp
   private bool isInitializing = true;
   ```

2. **Modify `TabModes_SelectedIndexChanged`**:
   ```csharp
   private void TabModes_SelectedIndexChanged(object? sender, EventArgs e)
   {
       if (isInitializing) return; // Skip on initial load
       ApplyLayout();
   }
   ```

3. **Set flag after initialization**:
   ```csharp
   InitializeTabs();
   isInitializing = false; // Allow tab switching after this
   ```

4. **Simplify `RestoreStandardLayout()`**:
   - Remove all position/size calculations
   - Only hide Scientific buttons
   - Only show Standard buttons
   - Don't touch positions - they're already correct from designer

5. **Update `ApplyLayout()` for Standard mode**:
   - Just call simplified `RestoreStandardLayout()` that only handles visibility
   - Don't recalculate positions

## Files to Modify

1. `MainForm.cs`:
   - Add `isInitializing` flag
   - Modify `TabModes_SelectedIndexChanged()` to check flag
   - Simplify `RestoreStandardLayout()` to only handle visibility
   - Set `isInitializing = false` after `InitializeTabs()`

## Expected Result

- Designer positions are preserved on startup
- Standard mode uses designer positions (editable in designer)
- Scientific mode still works (repositions buttons)
- Switching tabs works correctly
- No runtime override of designer positions for Standard mode











