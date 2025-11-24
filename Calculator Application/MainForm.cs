using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Calculator_Application
{
    public partial class MainForm : Form
    {
        string opr = "";
        double operand = 0;
        bool flagOpPressed = false; // create & set flag if operator is pressed
        string operandDisplay = ""; // store display value of first operand for preview
        string currentInput = ""; // store current input being typed for second operand
        Dictionary<string, double> namedMemory = new Dictionary<string, double>(); // named memory storage
        Button? lastPressedButton = null; // for visual feedback
        Color? originalButtonColor = null; // store original button color
        System.Windows.Forms.Timer highlightTimer = new System.Windows.Forms.Timer();
        List<string> calculationHistory = new List<string>(); // store calculation history
        bool isDegreeMode = false; // false = radians, true = degrees
        bool isInverseMode = false; // false = normal trig, true = inverse trig
        Stack<CalculatorState> undoStack = new Stack<CalculatorState>();
        Stack<CalculatorState> redoStack = new Stack<CalculatorState>();
        bool isRestoringState = false;
        const int MaxUndoSteps = 100;

        private string historyFilePath;

        public MainForm()
        {
            InitializeComponent();
            SetupKeyboardSupport();
            SetupVisualFeedback();
            UpdateDegreeRadianButton();
            UpdateTrigButtonLabels();
            
            // Set up history file path in user's AppData folder
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appFolder = Path.Combine(appDataPath, "Calculator Application");
            Directory.CreateDirectory(appFolder);
            historyFilePath = Path.Combine(appFolder, "history.txt");
            
            // Load history and memory on startup
            LoadHistory();
            LoadMemoryFromFile();
            UpdateUndoRedoButtons();
        }

        private void SetupKeyboardSupport()
        {
            this.KeyPreview = true;
            this.KeyDown += MainForm_KeyDown;
        }

        private void SetupVisualFeedback()
        {
            highlightTimer.Interval = 150; // 150ms highlight
            highlightTimer.Tick += (s, e) =>
            {
                if (lastPressedButton != null && originalButtonColor != null)
                {
                    lastPressedButton.BackColor = originalButtonColor.Value;
                    lastPressedButton = null;
                    originalButtonColor = null;
                }
                highlightTimer.Stop();
            };
        }

        private void MainForm_KeyDown(object? sender, KeyEventArgs e)
        {
            // Check operators FIRST before numbers to avoid conflicts
            // Multiplication operator (numpad * or shift+8 or asterisk key)
            if (e.KeyCode == Keys.Multiply || (e.Shift && e.KeyCode == Keys.D8))
            {
                btnMultiply.PerformClick();
                HighlightButton(btnMultiply);
                e.Handled = true;
            }
            // Division operator (numpad / or / key)
            else if (e.KeyCode == Keys.Divide || e.KeyCode == Keys.OemQuestion)
            {
                btnDivide.PerformClick();
                HighlightButton(btnDivide);
                e.Handled = true;
            }
            // Addition operator (numpad + or shift+=)
            else if (e.KeyCode == Keys.Add || (e.Shift && e.KeyCode == Keys.Oemplus))
            {
                btnAdd.PerformClick();
                HighlightButton(btnAdd);
                e.Handled = true;
            }
            // Subtraction operator (numpad - or - key)
            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.OemMinus)
            {
                btnSubtract.PerformClick();
                HighlightButton(btnSubtract);
                e.Handled = true;
            }
            // Numbers 0-9 (but not if Shift is pressed with 8, as that's multiplication)
            else if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && !(e.KeyCode == Keys.D8 && e.Shift))
            {
                string num = (e.KeyCode - Keys.D0).ToString();
                SimulateButtonClick(num);
                e.Handled = true;
            }
            // Numpad numbers 0-9
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                string num = (e.KeyCode - Keys.NumPad0).ToString();
                SimulateButtonClick(num);
                e.Handled = true;
            }
            // Decimal point
            else if (e.KeyCode == Keys.OemPeriod || e.KeyCode == Keys.Decimal)
            {
                btnDot.PerformClick();
                HighlightButton(btnDot);
                e.Handled = true;
            }
            // Equals (Enter key)
            else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                btnEqu.PerformClick();
                HighlightButton(btnEqu);
                e.Handled = true;
            }
            // Clear All (Escape)
            else if (e.KeyCode == Keys.Escape)
            {
                btnC.PerformClick();
                HighlightButton(btnC);
                e.Handled = true;
            }
            // Backspace
            else if (e.KeyCode == Keys.Back)
            {
                btnBackspace.PerformClick();
                HighlightButton(btnBackspace);
                e.Handled = true;
            }
            // Copy to clipboard (Ctrl+C)
            else if (e.KeyCode == Keys.C && e.Control)
            {
                CopyToClipboard();
                e.Handled = true;
            }
            // Percentage (Shift+5)
            else if (e.Shift && e.KeyCode == Keys.D5)
            {
                btnPercent.PerformClick();
                HighlightButton(btnPercent);
                e.Handled = true;
            }
            // Undo (Ctrl+Z)
            else if (e.Control && e.KeyCode == Keys.Z)
            {
                if (btnUndo.Enabled)
                {
                    btnUndo.PerformClick();
                    e.Handled = true;
                }
            }
            // Redo (Ctrl+Y)
            else if (e.Control && e.KeyCode == Keys.Y)
            {
                if (btnRedo.Enabled)
                {
                    btnRedo.PerformClick();
                    e.Handled = true;
                }
            }
            // Inverse mode toggle (Shift+I)
            else if (e.Shift && e.KeyCode == Keys.I)
            {
                btnInverse.PerformClick();
                HighlightButton(btnInverse);
                e.Handled = true;
            }
            // Degree/Radian toggle (Shift+D)
            else if (e.Shift && e.KeyCode == Keys.D)
            {
                btnDegreeRadian.PerformClick();
                HighlightButton(btnDegreeRadian);
                e.Handled = true;
            }
        }

        private void SimulateButtonClick(string num)
        {
            Button? btn = null;
            switch (num)
            {
                case "0": btn = btn0; break;
                case "1": btn = btn1; break;
                case "2": btn = btn2; break;
                case "3": btn = btn3; break;
                case "4": btn = btn4; break;
                case "5": btn = btn5; break;
                case "6": btn = btn6; break;
                case "7": btn = btn7; break;
                case "8": btn = btn8; break;
                case "9": btn = btn9; break;
            }
            if (btn != null)
            {
                btn.PerformClick();
                HighlightButton(btn);
            }
        }

        private void HighlightButton(Button btn)
        {
            // Restore previous button's color if any
            if (lastPressedButton != null && originalButtonColor != null)
            {
                lastPressedButton.BackColor = originalButtonColor.Value;
            }
            
            // Store current button's original color and highlight it
            originalButtonColor = btn.BackColor;
            lastPressedButton = btn;
            btn.BackColor = Color.LightBlue;
            highlightTimer.Start();
        }

        private string FormatNumber(string numberStr)
        {
            if (string.IsNullOrEmpty(numberStr) || numberStr == "Error") return numberStr;

            // Try to parse as double
            if (double.TryParse(numberStr, out double value))
            {
                // Remove trailing zeros and unnecessary decimal point
                if (numberStr.Contains('.'))
                {
                    numberStr = numberStr.TrimEnd('0').TrimEnd('.');
                    if (string.IsNullOrEmpty(numberStr)) numberStr = "0";
                }

                // Format large numbers with commas
                if (Math.Abs(value) >= 1000)
                {
                    return value.ToString("N0");
                }
                else if (Math.Abs(value) >= 1000000 || (Math.Abs(value) < 0.0001 && value != 0))
                {
                    // Use scientific notation for very large or very small numbers
                    return value.ToString("E6").Replace("E+0", "E+").Replace("E-0", "E-");
                }

                return numberStr;
            }
            return numberStr;
        }

        private void numPad_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SaveStateForUndo();
            string num = btn.Text;
            
            // If there's a pending operation, we're typing the second operand
            if (opr != "" && operandDisplay != "")
            {
                // Handle input for second operand
                if (flagOpPressed == true)
                {
                    currentInput = "";
                    flagOpPressed = false;
                }
                
                switch (num)
                {
                    case ".":
                        if (!currentInput.Contains('.'))
                        {
                            currentInput += '.';
                        }
                        break;
                    default:
                        if (currentInput == "0" || currentInput == "")
                            currentInput = "";
                        currentInput += num;
                        break;
                }
                
                // Update preview and calculate result
                UpdatePreviewWithResult(currentInput);
            }
            else
            {
                // No pending operation, normal input
                string temp = txtResults.Text;

                // Don't allow input if showing error
                if (temp == "Error")
                {
                    temp = "0";
                }

                switch (num)
                {
                    case ".":
                        if (!temp.Contains('.'))
                        {
                            temp += '.';
                        }
                        break;
                    default:
                        if (temp == "0" || temp == "Error")
                            temp = "";
                        temp += num;
                        break;
                }

                txtResults.Text = temp;
            }
            
            HighlightButton(btn);
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SaveStateForUndo();
            
            // Only perform previous operation if there's one pending
            if (opr != "")
            {
                btnEqu.PerformClick();
            }

            // get the operand value from Display content
            if (txtResults.Text != "Error")
            {
                operand = Double.Parse(txtResults.Text);
                operandDisplay = txtResults.Text;
                currentInput = ""; // Reset current input for second operand

                // get the operator
                opr = btn.Tag?.ToString() ?? "";

                // Update preview label with operator
                string operatorSymbol = GetOperatorSymbol(opr);
                lblPreview.Text = operandDisplay + " " + operatorSymbol;

                flagOpPressed = true;
                HighlightButton(btn);
            }
        }
        
        private string GetOperatorSymbol(string operation)
        {
            switch (operation)
            {
                case "Add":
                    return "+";
                case "Subtract":
                    return "−";
                case "Multiply":
                    return "×";
                case "Divide":
                    return "÷";
                case "Power":
                    return "^";
                default:
                    return "";
            }
        }
        
        private void UpdatePreviewWithResult(string secondOperandText)
        {
            if (opr == "" || operandDisplay == "") return;
            
            string operatorSymbol = GetOperatorSymbol(opr);
            
            // Update preview label with expression (no result)
            lblPreview.Text = operandDisplay + " " + operatorSymbol + " " + secondOperandText;
            
            // Try to parse and calculate the result, show it in the bottom display
            try
            {
                if (double.TryParse(secondOperandText, out double operand2))
                {
                    double result = 0;
                    bool validOperation = true;
                    
                    switch (opr)
                    {
                        case "Add":
                            result = operand + operand2;
                            break;
                        case "Subtract":
                            result = operand - operand2;
                            break;
                        case "Multiply":
                            result = operand * operand2;
                            break;
                        case "Divide":
                            if (operand2 == 0)
                            {
                                txtResults.Text = "Error";
                                return;
                            }
                            result = operand / operand2;
                            break;
                        default:
                            validOperation = false;
                            break;
                    }
                    
                    if (validOperation)
                    {
                        string resultText = FormatNumber(result.ToString());
                        txtResults.Text = resultText;
                    }
                }
            }
            catch
            {
                // On error, keep showing the current input
            }
        }

        private void btnEqu_Click(object sender, EventArgs e)
        {
            if (opr == "" || txtResults.Text == "Error") return; // No operation to perform
            SaveStateForUndo();

            // Use currentInput if available, otherwise use txtResults
            string operand2Text = (opr != "" && currentInput != "") ? currentInput : txtResults.Text;
            double operand2 = Double.Parse(operand2Text);
            string operand2Display = operand2Text;

            // Update preview label to show full expression
            string operatorSymbol = GetOperatorSymbol(opr);
            string fullExpression = "";

            if (operandDisplay != "")
            {
                fullExpression = operandDisplay + " " + operatorSymbol + " " + operand2Display;
                lblPreview.Text = fullExpression;
            }

            try
            {
                switch (opr)
                {
                    case "Add":
                        operand = operand + operand2;
                        txtResults.Text = FormatNumber(operand.ToString());
                        break;
                    case "Subtract":
                        operand = operand - operand2;
                        txtResults.Text = FormatNumber(operand.ToString());
                        break;
                    case "Multiply":
                        operand = operand * operand2;
                        txtResults.Text = FormatNumber(operand.ToString());
                        break;
                    case "Divide":
                        if (operand2 == 0)
                        {
                            txtResults.Text = "Error";
                            lblPreview.Text = "";
                            opr = "";
                            operandDisplay = "";
                            currentInput = "";
                            return;
                        }
                        operand = operand / operand2;
                        txtResults.Text = FormatNumber(operand.ToString());
                        break;
                    case "Power":
                        operand = Math.Pow(operand, operand2);
                        txtResults.Text = FormatNumber(operand.ToString());
                        break;
                    default:
                        break;
                }

                // Add to history
                if (fullExpression != "" && txtResults.Text != "Error")
                {
                    AddToHistory(fullExpression + " = " + txtResults.Text);
                }
            }
            catch
            {
                txtResults.Text = "Error";
                lblPreview.Text = "";
                opr = "";
                operandDisplay = "";
                currentInput = "";
                HighlightButton((Button)sender);
                return;
            }

            // Move result to top label as if it's the first input for next operation
            operandDisplay = txtResults.Text;
            operand = Double.Parse(txtResults.Text);
            opr = "";
            currentInput = "";
            lblPreview.Text = txtResults.Text; // Show result in top label
            HighlightButton((Button)sender);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            SaveStateForUndo();
            opr = "";
            operand = 0;
            operandDisplay = "";
            currentInput = "";
            flagOpPressed = false;
            txtResults.Text = "0";
            lblPreview.Text = "";
            HighlightButton((Button)sender);
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            SaveStateForUndo();
            // Clear Entry - only clears current display, keeps operation
            if (opr != "" && operandDisplay != "")
            {
                // Clear the second operand input
                currentInput = "";
                UpdatePreviewWithResult("0");
            }
            else
            {
                txtResults.Text = "0";
            }
            flagOpPressed = false;
            
            HighlightButton((Button)sender);
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            SaveStateForUndo();
            if (opr != "" && operandDisplay != "")
            {
                // Backspace on second operand
                if (currentInput.Length > 1)
                {
                    currentInput = currentInput.Substring(0, currentInput.Length - 1);
                    UpdatePreviewWithResult(currentInput);
                }
                else if (currentInput.Length == 1)
                {
                    currentInput = "";
                    UpdatePreviewWithResult("0");
                }
                else
                {
                    // If currentInput is empty, clear the operator
                    opr = "";
                    operandDisplay = "";
                    currentInput = "";
                    flagOpPressed = false;
                    lblPreview.Text = "";
                }
            }
            else
            {
                // Backspace on first operand
                string temp = txtResults.Text;
                
                if (temp == "Error" || temp == "0")
                {
                    txtResults.Text = "0";
                }
                else if (temp.Length > 1)
                {
                    temp = temp.Substring(0, temp.Length - 1);
                    txtResults.Text = temp;
                }
                else
                {
                    txtResults.Text = "0";
                }
            }
            
            HighlightButton((Button)sender);
        }

        private void btnNegate_Click(object sender, EventArgs e)
        {
            SaveStateForUndo();
            if (opr != "" && operandDisplay != "" && currentInput != "")
            {
                // Negate the second operand
                try
                {
                    if (double.TryParse(currentInput, out double value))
                    {
                        value = -value;
                        currentInput = FormatNumber(value.ToString());
                        UpdatePreviewWithResult(currentInput);
                    }
                }
                catch
                {
                    txtResults.Text = "Error";
                }
            }
            else if (txtResults.Text != "Error" && txtResults.Text != "0")
            {
                // Negate the first operand or result
                try
                {
                    double value = Double.Parse(txtResults.Text);
                    value = -value;
                    txtResults.Text = FormatNumber(value.ToString());
                }
                catch
                {
                    txtResults.Text = "Error";
                }
            }
            HighlightButton((Button)sender);
        }

        private void uOperator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string u_opr = btn.Tag?.ToString() ?? "";
            SaveStateForUndo();
            
            if (txtResults.Text == "Error") return;

            try
            {
                double value = Double.Parse(txtResults.Text);
                string valueDisplay = txtResults.Text;
                string results;
                double result = 0;

                switch (u_opr)
                {
                    case "Sqrt":
                        if (value < 0)
                        {
                            txtResults.Text = "Error";
                            lblPreview.Text = "";
                            return;
                        }
                        lblPreview.Text = "√(" + valueDisplay + ")";
                        result = Math.Sqrt(value);
                        break;
                    case "Square":
                        lblPreview.Text = "(" + valueDisplay + ")²";
                        result = value * value;
                        break;
                    case "Factorial":
                        // Factorial only works for non-negative integers
                        if (value < 0 || value != Math.Floor(value))
                        {
                            txtResults.Text = "Error";
                            lblPreview.Text = "";
                            return;
                        }
                        int n = (int)value;
                        // Limit to reasonable values to avoid overflow
                        if (n > 170)
                        {
                            txtResults.Text = "Error";
                            lblPreview.Text = "";
                            return;
                        }
                        lblPreview.Text = valueDisplay + "!";
                        result = CalculateFactorial(n);
                        break;
                    case "Power":
                        // For power, we need to get the exponent from user
                        // For now, we'll use the current value as base and ask for exponent
                        // This is a simplified version - you might want to handle it differently
                        if (opr == "" || operandDisplay == "")
                        {
                            // Store current value as base, wait for exponent
                            operand = value;
                            operandDisplay = valueDisplay;
                            opr = "Power";
                            lblPreview.Text = valueDisplay + " ^";
                            txtResults.Text = "0";
                            flagOpPressed = true;
                            HighlightButton(btn);
                            return;
                        }
                        break;
                    case "Log":
                        if (value <= 0)
                        {
                            txtResults.Text = "Error";
                            lblPreview.Text = "";
                            return;
                        }
                        lblPreview.Text = "log(" + valueDisplay + ")";
                        result = Math.Log10(value);
                        break;
                    case "Ln":
                        if (value <= 0)
                        {
                            txtResults.Text = "Error";
                            lblPreview.Text = "";
                            return;
                        }
                        lblPreview.Text = "ln(" + valueDisplay + ")";
                        result = Math.Log(value);
                        break;
                    case "Sin":
                        if (isInverseMode)
                        {
                            // Arcsin: input must be between -1 and 1
                            if (value < -1 || value > 1)
                            {
                                txtResults.Text = "Error";
                                lblPreview.Text = "";
                                return;
                            }
                            lblPreview.Text = "arcsin(" + valueDisplay + ")";
                            result = Math.Asin(value);
                            // Convert from radians to degrees if needed
                            if (isDegreeMode)
                            {
                                result = result * 180.0 / Math.PI;
                            }
                        }
                        else
                        {
                            lblPreview.Text = "sin(" + valueDisplay + ")";
                            // Convert from degrees to radians if needed
                            double angle = isDegreeMode ? value * Math.PI / 180.0 : value;
                            result = Math.Sin(angle);
                        }
                        break;
                    case "Cos":
                        if (isInverseMode)
                        {
                            // Arccos: input must be between -1 and 1
                            if (value < -1 || value > 1)
                            {
                                txtResults.Text = "Error";
                                lblPreview.Text = "";
                                return;
                            }
                            lblPreview.Text = "arccos(" + valueDisplay + ")";
                            result = Math.Acos(value);
                            // Convert from radians to degrees if needed
                            if (isDegreeMode)
                            {
                                result = result * 180.0 / Math.PI;
                            }
                        }
                        else
                        {
                            lblPreview.Text = "cos(" + valueDisplay + ")";
                            // Convert from degrees to radians if needed
                            double angle = isDegreeMode ? value * Math.PI / 180.0 : value;
                            result = Math.Cos(angle);
                        }
                        break;
                    case "Tan":
                        if (isInverseMode)
                        {
                            lblPreview.Text = "arctan(" + valueDisplay + ")";
                            result = Math.Atan(value);
                            // Convert from radians to degrees if needed
                            if (isDegreeMode)
                            {
                                result = result * 180.0 / Math.PI;
                            }
                        }
                        else
                        {
                            lblPreview.Text = "tan(" + valueDisplay + ")";
                            // Convert from degrees to radians if needed
                            double angle = isDegreeMode ? value * Math.PI / 180.0 : value;
                            result = Math.Tan(angle);
                        }
                        break;
                    default:
                        HighlightButton(btn);
                        return;
                }

                if (u_opr != "Power")
                {
                    results = result.ToString("N10");
                    results = results.TrimEnd('0').TrimEnd('.');
                    txtResults.Text = FormatNumber(results);
                    
                    // Add to history
                    if (lblPreview.Text != "" && txtResults.Text != "Error")
                    {
                        AddToHistory(lblPreview.Text + " = " + txtResults.Text);
                    }
                }
            }
            catch
            {
                txtResults.Text = "Error";
                lblPreview.Text = "";
            }
            
            HighlightButton(btn);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            CopyToClipboard();
            HighlightButton((Button)sender);
        }

        private void CopyToClipboard()
        {
            if (txtResults.Text != "Error")
            {
                Clipboard.SetText(txtResults.Text);
            }
        }

        private void memoryButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string memOp = btn.Tag?.ToString() ?? "";
            const string defaultVarName = "M"; // Default variable name for old memory buttons
            SaveStateForUndo();

            try
            {
                switch (memOp)
                {
                    case "MPlus":
                        if (txtResults.Text != "Error")
                        {
                            double value = Double.Parse(txtResults.Text);
                            if (!namedMemory.ContainsKey(defaultVarName))
                            {
                                namedMemory[defaultVarName] = 0;
                            }
                            namedMemory[defaultVarName] += value;
                            SaveMemoryToFile();
                        }
                        break;
                    case "MMinus":
                        if (txtResults.Text != "Error")
                        {
                            double value = Double.Parse(txtResults.Text);
                            if (!namedMemory.ContainsKey(defaultVarName))
                            {
                                namedMemory[defaultVarName] = 0;
                            }
                            namedMemory[defaultVarName] -= value;
                            SaveMemoryToFile();
                        }
                        break;
                    case "MR":
                        // Memory Recall - insert memory value
                        if (namedMemory.ContainsKey(defaultVarName))
                        {
                            double memoryValue = namedMemory[defaultVarName];
                            if (opr != "" && operandDisplay != "")
                            {
                                // If there's a pending operation, insert as second operand
                                currentInput = FormatNumber(memoryValue.ToString());
                                UpdatePreviewWithResult(currentInput);
                            }
                            else
                            {
                                // No pending operation, replace display
                                txtResults.Text = FormatNumber(memoryValue.ToString());
                            }
                        }
                        break;
                    case "MC":
                        // Memory Clear - remove default variable
                        if (namedMemory.ContainsKey(defaultVarName))
                        {
                            namedMemory.Remove(defaultVarName);
                            SaveMemoryToFile();
                        }
                        break;
                }
            }
            catch
            {
                txtResults.Text = "Error";
            }

            HighlightButton(btn);
        }

        private void constantButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            SaveStateForUndo();
            string constant = btn.Tag?.ToString() ?? "";
            string valueStr = "";

            switch (constant)
            {
                case "Pi":
                    valueStr = Math.PI.ToString();
                    break;
                case "E":
                    valueStr = Math.E.ToString();
                    break;
            }

            if (opr != "" && operandDisplay != "")
            {
                // If there's a pending operation, insert as second operand
                currentInput = FormatNumber(valueStr);
                UpdatePreviewWithResult(currentInput);
            }
            else
            {
                // No pending operation, replace display
                txtResults.Text = FormatNumber(valueStr);
            }

            HighlightButton(btn);
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "Error") return;
            SaveStateForUndo();

            try
            {
                double value = Double.Parse(txtResults.Text);
                string valueDisplay = txtResults.Text;
                double result = 0;
                string expression = "";

                if (opr != "" && operandDisplay != "")
                {
                    // If there's a pending operation, calculate percentage of the first operand
                    // Common use cases:
                    // - 100 + 10% = 100 + (100 * 0.10) = 110
                    // - 100 - 10% = 100 - (100 * 0.10) = 90
                    // - 100 * 10% = 100 * 0.10 = 10
                    // - 100 / 10% = 100 / 0.10 = 1000
                    
                    double percentageValue = value / 100.0; // Convert percentage to decimal
                    string operatorSymbol = GetOperatorSymbol(opr);
                    
                    switch (opr)
                    {
                        case "Add":
                            result = operand + (operand * percentageValue);
                            expression = operandDisplay + " + " + valueDisplay + "%";
                            break;
                        case "Subtract":
                            result = operand - (operand * percentageValue);
                            expression = operandDisplay + " − " + valueDisplay + "%";
                            break;
                        case "Multiply":
                            result = operand * percentageValue;
                            expression = operandDisplay + " × " + valueDisplay + "%";
                            break;
                        case "Divide":
                            if (percentageValue == 0)
                            {
                                txtResults.Text = "Error";
                                lblPreview.Text = "";
                                opr = "";
                                operandDisplay = "";
                                currentInput = "";
                                return;
                            }
                            result = operand / percentageValue;
                            expression = operandDisplay + " ÷ " + valueDisplay + "%";
                            break;
                        default:
                            // For other operations, just convert to decimal
                            result = percentageValue;
                            expression = valueDisplay + "%";
                            break;
                    }
                    
                    lblPreview.Text = expression;
                    txtResults.Text = FormatNumber(result.ToString());
                    
                    // Add to history
                    if (expression != "" && txtResults.Text != "Error")
                    {
                        AddToHistory(expression + " = " + txtResults.Text);
                    }
                    
                    // Reset operation state
                    operandDisplay = txtResults.Text;
                    operand = result;
                    opr = "";
                    currentInput = "";
                }
                else
                {
                    // No pending operation, just convert percentage to decimal
                    result = value / 100.0;
                    expression = valueDisplay + "%";
                    txtResults.Text = FormatNumber(result.ToString());
                    
                    // Add to history
                    AddToHistory(expression + " = " + txtResults.Text);
                }
            }
            catch
            {
                txtResults.Text = "Error";
                lblPreview.Text = "";
            }
            
            HighlightButton((Button)sender);
        }

        private void AddToHistory(string entry)
        {
            calculationHistory.Insert(0, entry); // Add to beginning of list
            
            // Limit history to 50 entries
            if (calculationHistory.Count > 50)
            {
                calculationHistory.RemoveAt(calculationHistory.Count - 1);
            }
            
            // Update listbox
            UpdateHistoryListBox();
            
            // Save to file
            SaveHistory();
        }

        private void UpdateHistoryListBox()
        {
            lstHistory.Items.Clear();
            foreach (string item in calculationHistory)
            {
                lstHistory.Items.Add(item);
            }
        }

        private void SaveHistory()
        {
            try
            {
                File.WriteAllLines(historyFilePath, calculationHistory);
            }
            catch
            {
                // Silently fail - don't interrupt user experience if file save fails
            }
        }

        private void LoadHistory()
        {
            try
            {
                if (File.Exists(historyFilePath))
                {
                    string[] lines = File.ReadAllLines(historyFilePath);
                    calculationHistory.Clear();
                    
                    // Load up to 50 most recent entries
                    int startIndex = Math.Max(0, lines.Length - 50);
                    for (int i = startIndex; i < lines.Length; i++)
                    {
                        if (!string.IsNullOrWhiteSpace(lines[i]))
                        {
                            calculationHistory.Add(lines[i]);
                        }
                    }
                    
                    // Reverse to show most recent first
                    calculationHistory.Reverse();
                    
                    UpdateHistoryListBox();
                }
            }
            catch
            {
                // Silently fail - start with empty history if file can't be read
                calculationHistory.Clear();
            }
        }

        private void lstHistory_DoubleClick(object sender, EventArgs e)
        {
            if (lstHistory.SelectedItem != null)
            {
                string? selectedItem = lstHistory.SelectedItem.ToString();
                
                if (selectedItem != null)
                {
                    // Extract the result (everything after " = ")
                    int equalsIndex = selectedItem.LastIndexOf(" = ");
                    if (equalsIndex >= 0)
                    {
                        SaveStateForUndo();
                        string result = selectedItem.Substring(equalsIndex + 3);
                        
                        // Insert the result into the calculator
                        if (opr != "" && operandDisplay != "")
                        {
                            // If there's a pending operation, insert as second operand
                            currentInput = result;
                            UpdatePreviewWithResult(currentInput);
                        }
                        else
                        {
                            // No pending operation, replace display
                            txtResults.Text = result;
                        }
                    }
                }
            }
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            SaveStateForUndo();
            calculationHistory.Clear();
            UpdateHistoryListBox();
            SaveHistory(); // Save empty history to file
            HighlightButton((Button)sender);
        }

        private void lstHistory_KeyDown(object sender, KeyEventArgs e)
        {
            // If Enter is pressed in the history list, perform equals operation
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Return)
            {
                btnEqu.PerformClick();
                HighlightButton(btnEqu);
                e.Handled = true;
            }
        }

        private void btnDegreeRadian_Click(object sender, EventArgs e)
        {
            SaveStateForUndo();
            isDegreeMode = !isDegreeMode;
            UpdateDegreeRadianButton();
            HighlightButton((Button)sender);
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            SaveStateForUndo();
            isInverseMode = !isInverseMode;
            UpdateTrigButtonLabels();
            HighlightButton((Button)sender);
        }

        private void UpdateDegreeRadianButton()
        {
            btnDegreeRadian.Text = isDegreeMode ? "DEG" : "RAD";
            btnDegreeRadian.BackColor = isDegreeMode 
                ? Color.FromArgb(46, 125, 50)  // Green when degrees
                : Color.FromArgb(52, 152, 219); // Blue when radians
        }

        private void UpdateTrigButtonLabels()
        {
            if (isInverseMode)
            {
                btnSin.Text = "arcsin";
                btnCos.Text = "arccos";
                btnTan.Text = "arctan";
                btnInverse.BackColor = Color.FromArgb(46, 125, 50); // Green when active
            }
            else
            {
                btnSin.Text = "sin";
                btnCos.Text = "cos";
                btnTan.Text = "tan";
                btnInverse.BackColor = Color.FromArgb(52, 152, 219); // Blue when inactive
            }
        }

        private double CalculateFactorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            
            double result = 1;
            for (int i = 2; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "Error") return;
            SaveStateForUndo();

            try
            {
                double value = Double.Parse(txtResults.Text);
                if (value == 0)
                {
                    txtResults.Text = "Error";
                    lblPreview.Text = "";
                    return;
                }
                
                string valueDisplay = txtResults.Text;
                double result = 1.0 / value;
                string expression = "1/(" + valueDisplay + ")";
                
                lblPreview.Text = expression;
                txtResults.Text = FormatNumber(result.ToString());
                
                // Add to history
                AddToHistory(expression + " = " + txtResults.Text);
            }
            catch
            {
                txtResults.Text = "Error";
                lblPreview.Text = "";
            }
            
            HighlightButton((Button)sender);
        }

        private void btnCubeRoot_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "Error") return;
            SaveStateForUndo();

            try
            {
                double value = Double.Parse(txtResults.Text);
                string valueDisplay = txtResults.Text;
                
                // Cube root: if negative, result is negative
                double result;
                if (value < 0)
                {
                    result = -Math.Pow(-value, 1.0 / 3.0);
                }
                else
                {
                    result = Math.Pow(value, 1.0 / 3.0);
                }
                
                string expression = "∛(" + valueDisplay + ")";
                lblPreview.Text = expression;
                txtResults.Text = FormatNumber(result.ToString());
                
                // Add to history
                AddToHistory(expression + " = " + txtResults.Text);
            }
            catch
            {
                txtResults.Text = "Error";
                lblPreview.Text = "";
            }
            
            HighlightButton((Button)sender);
        }

        private void btnNthRoot_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "Error") return;

            try
            {
                // Get the root order from user
                using (var dialog = new NthRootDialog())
                {
                    dialog.Owner = this;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        int rootOrder = dialog.RootOrder;
                        if (rootOrder <= 0)
                        {
                            MessageBox.Show(this, "Root order must be a positive integer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            HighlightButton((Button)sender);
                            return;
                        }
                        
                        double value = Double.Parse(txtResults.Text);
                        string valueDisplay = txtResults.Text;
                        
                        // Check for even root of negative number
                        if (rootOrder % 2 == 0 && value < 0)
                        {
                            txtResults.Text = "Error";
                            lblPreview.Text = "";
                            MessageBox.Show(this, "Cannot calculate even root of negative number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            HighlightButton((Button)sender);
                            return;
                        }
                        
                        SaveStateForUndo();
                        double result;
                        if (value < 0)
                        {
                            result = -Math.Pow(-value, 1.0 / rootOrder);
                        }
                        else
                        {
                            result = Math.Pow(value, 1.0 / rootOrder);
                        }
                        
                        string expression = rootOrder + "√(" + valueDisplay + ")";
                        lblPreview.Text = expression;
                        txtResults.Text = FormatNumber(result.ToString());
                        
                        // Add to history
                        AddToHistory(expression + " = " + txtResults.Text);
                    }
                }
            }
            catch
            {
                txtResults.Text = "Error";
                lblPreview.Text = "";
            }
            
            HighlightButton((Button)sender);
        }

        private void btnSaveMemory_Click(object sender, EventArgs e)
        {
            if (txtResults.Text == "Error") return;

            try
            {
                double value = Double.Parse(txtResults.Text);
                
                // Show dialog to get variable name
                using (var dialog = new MemoryNameDialog())
                {
                    dialog.Owner = this;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string varName = dialog.VariableName.Trim();
                        
                        if (string.IsNullOrEmpty(varName))
                        {
                            MessageBox.Show(this, "Variable name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            HighlightButton((Button)sender);
                            return;
                        }
                        
                        SaveStateForUndo();
                        // Save to named memory
                        namedMemory[varName] = value;
                        SaveMemoryToFile();
                        
                        MessageBox.Show(this, $"Variable '{varName}' saved with value {FormatNumber(value.ToString())}.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch
            {
                    MessageBox.Show(this, "Error saving to memory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            HighlightButton((Button)sender);
        }

        private void btnRecallMemory_Click(object sender, EventArgs e)
        {
            try
            {
                if (namedMemory.Count == 0)
                {
                    MessageBox.Show(this, "No saved variables.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HighlightButton((Button)sender);
                    return;
                }
                
                // Show dialog to select variable
                using (var dialog = new MemoryRecallDialog(namedMemory))
                {
                    dialog.Owner = this;
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        string varName = dialog.SelectedVariable;
                        if (!string.IsNullOrEmpty(varName) && namedMemory.ContainsKey(varName))
                        {
                            SaveStateForUndo();
                            double value = namedMemory[varName];
                            
                            // Insert the value into the calculator
                            if (opr != "" && operandDisplay != "")
                            {
                                // If there's a pending operation, insert as second operand
                                currentInput = FormatNumber(value.ToString());
                                UpdatePreviewWithResult(currentInput);
                            }
                            else
                            {
                                // No pending operation, replace display
                                txtResults.Text = FormatNumber(value.ToString());
                            }
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show(this, "Error recalling from memory.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            HighlightButton((Button)sender);
        }

        private void SaveMemoryToFile()
        {
            try
            {
                string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string appFolder = Path.Combine(appDataPath, "Calculator Application");
                Directory.CreateDirectory(appFolder);
                string memoryFilePath = Path.Combine(appFolder, "memory.txt");
                
                List<string> lines = new List<string>();
                foreach (var kvp in namedMemory)
                {
                    lines.Add($"{kvp.Key}={kvp.Value}");
                }
                
                File.WriteAllLines(memoryFilePath, lines);
            }
            catch
            {
                // Silently fail
            }
        }

        private void LoadMemoryFromFile()
        {
            try
            {
                string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string appFolder = Path.Combine(appDataPath, "Calculator Application");
                string memoryFilePath = Path.Combine(appFolder, "memory.txt");
                
                if (File.Exists(memoryFilePath))
                {
                    string[] lines = File.ReadAllLines(memoryFilePath);
                    namedMemory.Clear();
                    
                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line)) continue;
                        
                        int equalsIndex = line.IndexOf('=');
                        if (equalsIndex > 0 && equalsIndex < line.Length - 1)
                        {
                            string varName = line.Substring(0, equalsIndex).Trim();
                            string valueStr = line.Substring(equalsIndex + 1).Trim();
                            
                            if (double.TryParse(valueStr, out double value))
                            {
                                namedMemory[varName] = value;
                            }
                        }
                    }
                }
            }
            catch
            {
                // Silently fail
            }
        }

        private void SaveStateForUndo()
        {
            if (isRestoringState) return;

            undoStack.Push(CaptureState());
            if (undoStack.Count > MaxUndoSteps)
            {
                var trimmed = undoStack.Take(MaxUndoSteps).Reverse().ToList();
                undoStack = new Stack<CalculatorState>(trimmed);
            }

            redoStack.Clear();
            UpdateUndoRedoButtons();
        }

        private CalculatorState CaptureState()
        {
            return new CalculatorState
            {
                TxtResults = txtResults.Text,
                LblPreview = lblPreview.Text,
                Operator = opr,
                Operand = operand,
                FlagOpPressed = flagOpPressed,
                OperandDisplay = operandDisplay,
                CurrentInput = currentInput,
                IsDegreeMode = isDegreeMode,
                IsInverseMode = isInverseMode,
                CalculationHistory = new List<string>(calculationHistory),
                NamedMemory = new Dictionary<string, double>(namedMemory)
            };
        }

        private void RestoreState(CalculatorState state)
        {
            isRestoringState = true;

            txtResults.Text = state.TxtResults;
            lblPreview.Text = state.LblPreview;
            opr = state.Operator;
            operand = state.Operand;
            flagOpPressed = state.FlagOpPressed;
            operandDisplay = state.OperandDisplay;
            currentInput = state.CurrentInput;
            isDegreeMode = state.IsDegreeMode;
            isInverseMode = state.IsInverseMode;
            calculationHistory = new List<string>(state.CalculationHistory);
            namedMemory = new Dictionary<string, double>(state.NamedMemory);

            UpdateDegreeRadianButton();
            UpdateTrigButtonLabels();
            UpdateHistoryListBox();
            SaveHistory();
            SaveMemoryToFile();

            isRestoringState = false;
        }

        private void UpdateUndoRedoButtons()
        {
            btnUndo.Enabled = undoStack.Count > 0;
            btnRedo.Enabled = redoStack.Count > 0;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (undoStack.Count == 0) return;

            redoStack.Push(CaptureState());
            var previousState = undoStack.Pop();
            RestoreState(previousState);
            UpdateUndoRedoButtons();
            HighlightButton((Button)sender);
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            if (redoStack.Count == 0) return;

            undoStack.Push(CaptureState());
            var nextState = redoStack.Pop();
            RestoreState(nextState);
            UpdateUndoRedoButtons();
            HighlightButton((Button)sender);
        }

        private class CalculatorState
        {
            public string TxtResults { get; set; } = "";
            public string LblPreview { get; set; } = "";
            public string Operator { get; set; } = "";
            public double Operand { get; set; }
            public bool FlagOpPressed { get; set; }
            public string OperandDisplay { get; set; } = "";
            public string CurrentInput { get; set; } = "";
            public bool IsDegreeMode { get; set; }
            public bool IsInverseMode { get; set; }
            public List<string> CalculationHistory { get; set; } = new List<string>();
            public Dictionary<string, double> NamedMemory { get; set; } = new Dictionary<string, double>();
        }
    }
}
