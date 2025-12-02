# Rename Solution and Project Script
# Run this from the project root directory

Write-Host "=== Renaming Solution and Project ===" -ForegroundColor Cyan
Write-Host ""

# Check if Visual Studio might be using the files
Write-Host "WARNING: Make sure Visual Studio is CLOSED before continuing!" -ForegroundColor Yellow
$response = Read-Host "Press Enter to continue (or Ctrl+C to cancel)"

# Check if old folder exists
if (-not (Test-Path "Calculator Application")) {
    Write-Host "ERROR: 'Calculator Application' folder not found!" -ForegroundColor Red
    exit 1
}

# Check if new folder already exists
if (Test-Path "Calculator_241439P") {
    Write-Host "WARNING: 'Calculator_241439P' folder already exists!" -ForegroundColor Yellow
    $overwrite = Read-Host "Delete and recreate? (y/n)"
    if ($overwrite -eq "y") {
        Remove-Item -Path "Calculator_241439P" -Recurse -Force
    } else {
        Write-Host "Aborted." -ForegroundColor Red
        exit 1
    }
}

Write-Host "Step 1: Renaming project folder..." -ForegroundColor Green
Rename-Item -Path "Calculator Application" -NewName "Calculator_241439P"

Write-Host "Step 2: Renaming .csproj file..." -ForegroundColor Green
Rename-Item -Path "Calculator_241439P\Calculator Application.csproj" -NewName "Calculator_241439P.csproj" -ErrorAction SilentlyContinue

# If the new .csproj already exists (we created it), remove the old one
if (Test-Path "Calculator_241439P\Calculator Application.csproj") {
    Remove-Item -Path "Calculator_241439P\Calculator Application.csproj" -Force
}

Write-Host "Step 3: Removing old solution file..." -ForegroundColor Green
if (Test-Path "Calculator Application.sln") {
    Remove-Item -Path "Calculator Application.sln" -Force
}

Write-Host "Step 4: Cleaning up bin/obj folders..." -ForegroundColor Green
if (Test-Path "Calculator_241439P\bin") {
    Remove-Item -Path "Calculator_241439P\bin" -Recurse -Force
}
if (Test-Path "Calculator_241439P\obj") {
    Remove-Item -Path "Calculator_241439P\obj" -Recurse -Force
}

Write-Host ""
Write-Host "Renaming complete!" -ForegroundColor Green
Write-Host ""
Write-Host "Next steps:" -ForegroundColor Cyan
Write-Host "1. Open Calculator_241439P.sln in Visual Studio"
Write-Host "2. Build the solution (Ctrl+Shift+B)"
Write-Host "3. Verify everything works"
Write-Host ""
