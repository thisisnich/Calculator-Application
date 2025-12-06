# Rename Solution & Project Instructions

## ⚠️ IMPORTANT: Close Visual Studio First!

Before proceeding, **close Visual Studio completely**.

---

## Step-by-Step Instructions

### Option 1: Automated (Recommended)

I've created the new files. Now you need to:

1. **Close Visual Studio** (if open)

2. **Run this PowerShell command** (from the project root):
```powershell
# Rename the project folder
Rename-Item -Path "Calculator Application" -NewName "Calculator_241439P"

# The solution file and new project file are already created
```

3. **Copy all files** from old folder to new folder:
```powershell
# Copy all files except .csproj (we already have the new one)
Copy-Item -Path "Calculator Application\*" -Destination "Calculator_241439P\" -Recurse -Exclude "*.csproj","*.csproj.user"
```

4. **Delete the old solution file**:
```powershell
Remove-Item "Calculator Application.sln"
```

5. **Open the new solution** in Visual Studio:
   - Double-click `Calculator_241439P.sln`
   - Or: File → Open → Project/Solution → Select `Calculator_241439P.sln`

6. **Verify it builds**:
   - Build → Build Solution (Ctrl+Shift+B)
   - Should build successfully

---

### Option 2: Manual (If PowerShell doesn't work)

1. **Close Visual Studio**

2. **Rename the folder**:
   - In File Explorer, navigate to the project root
   - Right-click `Calculator Application` folder
   - Rename to `Calculator_241439P`

3. **Rename the .csproj file**:
   - Go into `Calculator_241439P` folder
   - Rename `Calculator Application.csproj` to `Calculator_241439P.csproj`
   - (I've already created the new one, so you can delete the old one)

4. **Delete old solution file**:
   - Delete `Calculator Application.sln`

5. **Open new solution**:
   - Double-click `Calculator_241439P.sln`

6. **Verify it builds**

---

## Verification Checklist

After renaming, verify:
- [ ] Solution name in Visual Studio shows: `Calculator_241439P`
- [ ] Project name in Solution Explorer shows: `Calculator_241439P`
- [ ] Project builds without errors
- [ ] Application runs correctly

---

## Troubleshooting

**If build fails:**
- Clean solution: Build → Clean Solution
- Rebuild: Build → Rebuild Solution
- Check that all files were copied correctly

**If files are missing:**
- Make sure you copied all files from the old folder
- Check that `MainForm.cs`, `MainForm.Designer.cs`, etc. are in the new folder

**If Visual Studio shows errors:**
- Close and reopen Visual Studio
- Delete `bin` and `obj` folders
- Rebuild solution

---

## What Was Created

✅ `Calculator_241439P.sln` - New solution file
✅ `Calculator_241439P/Calculator_241439P.csproj` - New project file

You still need to:
- Rename the folder (or copy files)
- Delete old solution file
- Open new solution in Visual Studio






