using System;
using System.Drawing;
using System.Windows.Forms;

namespace Calculator_Application
{
    public partial class MainForm : Form
    {
        string opr = "";
        double operand = 0;
        bool flagOpPressed = false; // create & set flag if operator is pressed
        string operandDisplay = ""; // store display value of first operand for preview
        Button? lastPressedButton = null; // for visual feedback
        Color? originalButtonColor = null; // store original button color
        System.Windows.Forms.Timer highlightTimer = new System.Windows.Forms.Timer();

        public MainForm()
        {
            InitializeComponent();
            SetupKeyboardSupport();
            SetupVisualFeedback();
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
            // Numbers 0-9
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
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
            // Multiplication operator (numpad * or shift+8)
            else if (e.KeyCode == Keys.Multiply || (e.Shift && e.KeyCode == Keys.D8))
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
            string num = btn.Text;
            string temp = txtResults.Text;

            // Don't allow input if showing error
            if (temp == "Error")
            {
                temp = "0";
            }

            // To clear result display if operator is pressed previously
            if (flagOpPressed == true)
            {
                temp = "";
                flagOpPressed = false;
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
            HighlightButton(btn);
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
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

                // get the operator
                opr = btn.Tag?.ToString() ?? "";

                // Update preview label
                string operatorSymbol = btn.Text;
                lblPreview.Text = operandDisplay + " " + operatorSymbol;

                flagOpPressed = true;
                HighlightButton(btn);
            }
        }

        private void btnEqu_Click(object sender, EventArgs e)
        {
            if (opr == "" || txtResults.Text == "Error") return; // No operation to perform

            double operand2 = Double.Parse(txtResults.Text);
            string operand2Display = txtResults.Text;

            // Update preview label to show full expression
            string operatorSymbol = "";
            switch (opr)
            {
                case "Add":
                    operatorSymbol = "+";
                    break;
                case "Subtract":
                    operatorSymbol = "−";
                    break;
                case "Multiply":
                    operatorSymbol = "×";
                    break;
                case "Divide":
                    operatorSymbol = "÷";
                    break;
            }

            if (operandDisplay != "")
            {
                lblPreview.Text = operandDisplay + " " + operatorSymbol + " " + operand2Display;
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
                            return;
                        }
                        operand = operand / operand2;
                        txtResults.Text = FormatNumber(operand.ToString());
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                txtResults.Text = "Error";
                lblPreview.Text = "";
            }

            opr = "";
            operandDisplay = "";
            HighlightButton((Button)sender);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            opr = "";
            operand = 0;
            operandDisplay = "";
            flagOpPressed = false;
            txtResults.Text = "0";
            lblPreview.Text = "";
            HighlightButton((Button)sender);
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            // Clear Entry - only clears current display, keeps operation
            txtResults.Text = "0";
            flagOpPressed = false;
            HighlightButton((Button)sender);
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
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
            HighlightButton((Button)sender);
        }

        private void btnNegate_Click(object sender, EventArgs e)
        {
            if (txtResults.Text != "Error" && txtResults.Text != "0")
            {
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
            
            if (txtResults.Text == "Error") return;

            try
            {
                double value = Double.Parse(txtResults.Text);
                string valueDisplay = txtResults.Text;
                string results;

                switch (u_opr)
                {
                    case "Sqrt":
                        if (value < 0)
                        {
                            txtResults.Text = "Error";
                            lblPreview.Text = "";
                            return;
                        }
                        // Update preview label
                        lblPreview.Text = "√" + valueDisplay;
                        results = Math.Sqrt(value).ToString("N10");
                        results = results.TrimEnd('0').TrimEnd('.');
                        txtResults.Text = FormatNumber(results);
                        break;
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
    }
}
