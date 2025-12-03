# Scientific Mode Layout Optimization

## Current State
- **Tab Width**: 449px (usable width: ~443px after padding)
- **Current Grid**: 6 columns (0, 66, 132, 198, 264, 330)
- **Button Size**: 60px × 36px
- **Column Spacing**: 66px
- **Last Button**: Ends at 390px (330 + 60)
- **Unused Space**: ~53px

## Optimization Options

### Option 1: Larger Buttons, Same Spacing
- **Button Size**: 70px × 36px
- **Column Spacing**: 73px
- **Grid**: 0, 73, 146, 219, 292, 365
- **Last Button**: Ends at 435px
- **Unused**: ~8px

### Option 2: Larger Buttons, Equal Spacing (Recommended)
- **Button Size**: 72px × 36px
- **Column Spacing**: 72px
- **Grid**: 0, 72, 144, 216, 288, 360
- **Last Button**: Ends at 432px
- **Unused**: ~11px
- **Benefit**: Clean, equal spacing

### Option 3: Maximum Size
- **Button Size**: 75px × 36px
- **Column Spacing**: 70px
- **Grid**: 0, 70, 140, 210, 280, 350
- **Last Button**: Ends at 425px
- **Unused**: ~18px

## Recommended: Option 2
- **Button Size**: 72px × 36px (20% larger)
- **Column Spacing**: 72px (9% larger)
- **Better touch targets**
- **More professional appearance**
- **Uses 97.5% of available width**

## Implementation
1. Update all Scientific mode button sizes to 72px × 36px
2. Update all Scientific mode button positions to new grid (0, 72, 144, 216, 288, 360)
3. Keep row spacing at 40px (already optimal)


