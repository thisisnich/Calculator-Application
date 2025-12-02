namespace Calculator_Application
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();

                currentSoundPlayer?.Stop();
                currentSoundPlayer?.Dispose();
                // Dispose all cached sound players
                foreach (var player in soundCache.Values)
                {
                    player?.Dispose();
                }
                soundCache.Clear();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResults = new TextBox();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnC = new Button();
            btnCE = new Button();
            btnBackspace = new Button();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnSqrt = new Button();
            btnEqu = new Button();
            btnNegate = new Button();
            btnCopy = new Button();
            btnSquare = new Button();
            btnFactorial = new Button();
            btnPower = new Button();
            btnLog = new Button();
            btnLn = new Button();
            btnSin = new Button();
            btnCos = new Button();
            btnTan = new Button();
            btnMPlus = new Button();
            btnMMinus = new Button();
            btnMR = new Button();
            btnMC = new Button();
            btnPi = new Button();
            btnE = new Button();
            btnPercent = new Button();
            btnModulus = new Button();
            btnDegreeRadian = new Button();
            btnInverse = new Button();
            btnReciprocal = new Button();
            btnCubeRoot = new Button();
            btnNthRoot = new Button();
            btnSaveMemory = new Button();
            btnRecallMemory = new Button();
            btnUndo = new Button();
            tabModes = new StyledTabControl();
            tabStandard = new TabPage();
            btnTheme = new Button();
            btnAudioToggle = new Button();
            tabScientific = new TabPage();
            btnRedo = new Button();
            btnClearHistory = new Button();
            btnBackspaceSci = new Button();
            btnCESci = new Button();
            btnCSci = new Button();
            btn7Sci = new Button();
            btn8Sci = new Button();
            btn9Sci = new Button();
            btnDivideSci = new Button();
            btnSqrtSci = new Button();
            btn4Sci = new Button();
            btn5Sci = new Button();
            btn6Sci = new Button();
            btnMultiplySci = new Button();
            btnNegateSci = new Button();
            btn1Sci = new Button();
            btn2Sci = new Button();
            btn3Sci = new Button();
            btnSubtractSci = new Button();
            btnAddSci = new Button();
            btn0Sci = new Button();
            btnDotSci = new Button();
            btnEquSci = new Button();
            btnCopySci = new Button();
            btnReciprocalSci = new Button();
            btnPercentSci = new Button();
            btnModulusSci = new Button();
            btnThemeSci = new Button();
            btnAudioToggleSci = new Button();
            tabHistory = new TabPage();
            lstHistory = new ListBox();
            lblPreview = new Label();
            lblID = new Label();
            btnSpeech = new Button();
            tabModes.SuspendLayout();
            tabStandard.SuspendLayout();
            tabScientific.SuspendLayout();
            tabHistory.SuspendLayout();
            SuspendLayout();
            // 
            // txtResults
            // 
            txtResults.BackColor = Color.FromArgb(45, 45, 45);
            txtResults.ForeColor = Color.White;
            txtResults.BorderStyle = BorderStyle.FixedSingle;
            txtResults.Font = new Font("Segoe UI", 28F);
            txtResults.Location = new Point(14, 53);
            txtResults.Margin = new Padding(3, 4, 3, 4);
            txtResults.Name = "txtResults";
            txtResults.ReadOnly = true;
            txtResults.Size = new Size(395, 70);
            txtResults.TabIndex = 0;
            txtResults.Text = "0";
            txtResults.TextAlign = HorizontalAlignment.Right;
            // 
            // btn1
            // 
            btn1.BackColor = Color.FromArgb(60, 60, 60);
            btn1.ForeColor = Color.White;
            btn1.Font = new Font("Microsoft Sans Serif", 15F);
            btn1.Location = new Point(0, 224);
            btn1.Margin = new Padding(3, 4, 3, 4);
            btn1.Name = "btn1";
            btn1.Size = new Size(82, 64);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.FlatStyle = FlatStyle.Flat;
            btn1.FlatAppearance.BorderSize = 0;
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += numPad_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.FromArgb(60, 60, 60);
            btn2.ForeColor = Color.White;
            btn2.Font = new Font("Microsoft Sans Serif", 15F);
            btn2.Location = new Point(91, 224);
            btn2.Margin = new Padding(3, 4, 3, 4);
            btn2.Name = "btn2";
            btn2.Size = new Size(82, 64);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += numPad_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.FromArgb(60, 60, 60);
            btn3.ForeColor = Color.White;
            btn3.Font = new Font("Microsoft Sans Serif", 15F);
            btn3.Location = new Point(183, 224);
            btn3.Margin = new Padding(3, 4, 3, 4);
            btn3.Name = "btn3";
            btn3.Size = new Size(82, 64);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += numPad_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.FromArgb(60, 60, 60);
            btn4.ForeColor = Color.White;
            btn4.Font = new Font("Microsoft Sans Serif", 15F);
            btn4.Location = new Point(0, 149);
            btn4.Margin = new Padding(3, 4, 3, 4);
            btn4.Name = "btn4";
            btn4.Size = new Size(82, 64);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += numPad_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.FromArgb(60, 60, 60);
            btn5.ForeColor = Color.White;
            btn5.Font = new Font("Microsoft Sans Serif", 15F);
            btn5.Location = new Point(91, 149);
            btn5.Margin = new Padding(3, 4, 3, 4);
            btn5.Name = "btn5";
            btn5.Size = new Size(82, 64);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += numPad_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.FromArgb(60, 60, 60);
            btn6.ForeColor = Color.White;
            btn6.Font = new Font("Microsoft Sans Serif", 15F);
            btn6.Location = new Point(183, 149);
            btn6.Margin = new Padding(3, 4, 3, 4);
            btn6.Name = "btn6";
            btn6.Size = new Size(82, 64);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += numPad_Click;
            // 
            // btn7
            // 
            btn7.BackColor = Color.FromArgb(60, 60, 60);
            btn7.ForeColor = Color.White;
            btn7.Font = new Font("Microsoft Sans Serif", 15F);
            btn7.Location = new Point(0, 75);
            btn7.Margin = new Padding(3, 4, 3, 4);
            btn7.Name = "btn7";
            btn7.Size = new Size(82, 64);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += numPad_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.FromArgb(60, 60, 60);
            btn8.ForeColor = Color.White;
            btn8.Font = new Font("Microsoft Sans Serif", 15F);
            btn8.Location = new Point(91, 75);
            btn8.Margin = new Padding(3, 4, 3, 4);
            btn8.Name = "btn8";
            btn8.Size = new Size(82, 64);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += numPad_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.FromArgb(60, 60, 60);
            btn9.ForeColor = Color.White;
            btn9.Font = new Font("Microsoft Sans Serif", 15F);
            btn9.Location = new Point(183, 75);
            btn9.Margin = new Padding(3, 4, 3, 4);
            btn9.Name = "btn9";
            btn9.Size = new Size(82, 64);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += numPad_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.FromArgb(60, 60, 60);
            btn0.ForeColor = Color.White;
            btn0.Font = new Font("Microsoft Sans Serif", 15F);
            btn0.Location = new Point(0, 299);
            btn0.Margin = new Padding(3, 4, 3, 4);
            btn0.Name = "btn0";
            btn0.Size = new Size(82, 64);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += numPad_Click;
            // 
            // btnDot
            // 
            btnDot.BackColor = Color.FromArgb(60, 60, 60);
            btnDot.ForeColor = Color.White;
            btnDot.Font = new Font("Microsoft Sans Serif", 15F);
            btnDot.Location = new Point(91, 299);
            btnDot.Margin = new Padding(3, 4, 3, 4);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(82, 64);
            btnDot.TabIndex = 11;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += numPad_Click;
            // 
            // btnC
            // 
            btnC.BackColor = Color.FromArgb(192, 57, 43);
            btnC.Font = new Font("Microsoft Sans Serif", 15F);
            btnC.ForeColor = Color.White;
            btnC.Location = new Point(183, 0);
            btnC.Margin = new Padding(3, 4, 3, 4);
            btnC.Name = "btnC";
            btnC.Size = new Size(82, 64);
            btnC.TabIndex = 12;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = false;
            btnC.Click += btnC_Click;
            // 
            // btnCE
            // 
            btnCE.BackColor = Color.FromArgb(192, 57, 43);
            btnCE.Font = new Font("Microsoft Sans Serif", 15F);
            btnCE.ForeColor = Color.White;
            btnCE.Location = new Point(91, 0);
            btnCE.Margin = new Padding(3, 4, 3, 4);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(82, 64);
            btnCE.TabIndex = 13;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = false;
            btnCE.Click += btnCE_Click;
            // 
            // btnBackspace
            // 
            btnBackspace.BackColor = Color.FromArgb(192, 57, 43);
            btnBackspace.Font = new Font("Microsoft Sans Serif", 15F);
            btnBackspace.ForeColor = Color.White;
            btnBackspace.Location = new Point(0, 0);
            btnBackspace.Margin = new Padding(3, 4, 3, 4);
            btnBackspace.Name = "btnBackspace";
            btnBackspace.Size = new Size(82, 64);
            btnBackspace.TabIndex = 14;
            btnBackspace.Text = "⌫";
            btnBackspace.UseVisualStyleBackColor = false;
            btnBackspace.Click += btnBackspace_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(41, 128, 185);
            btnAdd.Font = new Font("Microsoft Sans Serif", 15F);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(274, 299);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(82, 64);
            btnAdd.TabIndex = 15;
            btnAdd.Tag = "Add";
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += operator_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.FromArgb(41, 128, 185);
            btnSubtract.Font = new Font("Microsoft Sans Serif", 15F);
            btnSubtract.ForeColor = Color.White;
            btnSubtract.Location = new Point(274, 224);
            btnSubtract.Margin = new Padding(3, 4, 3, 4);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(82, 64);
            btnSubtract.TabIndex = 20;
            btnSubtract.Tag = "Subtract";
            btnSubtract.Text = "−";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += operator_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.FromArgb(41, 128, 185);
            btnMultiply.Font = new Font("Microsoft Sans Serif", 15F);
            btnMultiply.ForeColor = Color.White;
            btnMultiply.Location = new Point(274, 149);
            btnMultiply.Margin = new Padding(3, 4, 3, 4);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(82, 64);
            btnMultiply.TabIndex = 21;
            btnMultiply.Tag = "Multiply";
            btnMultiply.Text = "×";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += operator_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(41, 128, 185);
            btnDivide.Font = new Font("Microsoft Sans Serif", 15F);
            btnDivide.ForeColor = Color.White;
            btnDivide.Location = new Point(274, 75);
            btnDivide.Margin = new Padding(3, 4, 3, 4);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(82, 64);
            btnDivide.TabIndex = 22;
            btnDivide.Tag = "Divide";
            btnDivide.Text = "÷";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += operator_Click;
            // 
            // btnSqrt
            // 
            btnSqrt.BackColor = Color.FromArgb(142, 68, 173);
            btnSqrt.Font = new Font("Microsoft Sans Serif", 15F);
            btnSqrt.ForeColor = Color.White;
            btnSqrt.Location = new Point(366, 75);
            btnSqrt.Margin = new Padding(3, 4, 3, 4);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(82, 64);
            btnSqrt.TabIndex = 16;
            btnSqrt.Tag = "Sqrt";
            btnSqrt.Text = "√";
            btnSqrt.UseVisualStyleBackColor = false;
            btnSqrt.Click += uOperator_Click;
            // 
            // btnEqu
            // 
            btnEqu.BackColor = Color.FromArgb(41, 128, 185);
            btnEqu.Font = new Font("Microsoft Sans Serif", 15F);
            btnEqu.ForeColor = Color.White;
            btnEqu.Location = new Point(366, 299);
            btnEqu.Margin = new Padding(3, 4, 3, 4);
            btnEqu.Name = "btnEqu";
            btnEqu.Size = new Size(82, 64);
            btnEqu.TabIndex = 17;
            btnEqu.Tag = "Equ";
            btnEqu.Text = "=";
            btnEqu.UseVisualStyleBackColor = false;
            btnEqu.Click += btnEqu_Click;
            // 
            // btnNegate
            // 
            btnNegate.BackColor = Color.FromArgb(41, 128, 185);
            btnNegate.Font = new Font("Microsoft Sans Serif", 15F);
            btnNegate.ForeColor = Color.White;
            btnNegate.Location = new Point(183, 299);
            btnNegate.Margin = new Padding(3, 4, 3, 4);
            btnNegate.Name = "btnNegate";
            btnNegate.Size = new Size(82, 64);
            btnNegate.TabIndex = 18;
            btnNegate.Text = "±";
            btnNegate.UseVisualStyleBackColor = false;
            btnNegate.Click += btnNegate_Click;
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.FromArgb(142, 68, 173);
            btnCopy.Font = new Font("Microsoft Sans Serif", 12F);
            btnCopy.ForeColor = Color.White;
            btnCopy.Location = new Point(366, 224);
            btnCopy.Margin = new Padding(3, 4, 3, 4);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(82, 64);
            btnCopy.TabIndex = 19;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnSquare
            // 
            btnSquare.BackColor = Color.FromArgb(142, 68, 173);
            btnSquare.Font = new Font("Microsoft Sans Serif", 12F);
            btnSquare.ForeColor = Color.White;
            btnSquare.Location = new Point(0, 0);
            btnSquare.Margin = new Padding(3, 4, 3, 4);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(69, 48);
            btnSquare.TabIndex = 23;
            btnSquare.Tag = "Square";
            btnSquare.Text = "x²";
            btnSquare.UseVisualStyleBackColor = false;
            btnSquare.Click += uOperator_Click;
            // 
            // btnFactorial
            // 
            btnFactorial.BackColor = Color.FromArgb(142, 68, 173);
            btnFactorial.Font = new Font("Microsoft Sans Serif", 12F);
            btnFactorial.ForeColor = Color.White;
            btnFactorial.Location = new Point(75, 0);
            btnFactorial.Margin = new Padding(3, 4, 3, 4);
            btnFactorial.Name = "btnFactorial";
            btnFactorial.Size = new Size(69, 48);
            btnFactorial.TabIndex = 41;
            btnFactorial.Tag = "Factorial";
            btnFactorial.Text = "n!";
            btnFactorial.UseVisualStyleBackColor = false;
            btnFactorial.Click += uOperator_Click;
            // 
            // btnPower
            // 
            btnPower.BackColor = Color.FromArgb(142, 68, 173);
            btnPower.Font = new Font("Microsoft Sans Serif", 12F);
            btnPower.ForeColor = Color.White;
            btnPower.Location = new Point(151, 0);
            btnPower.Margin = new Padding(3, 4, 3, 4);
            btnPower.Name = "btnPower";
            btnPower.Size = new Size(69, 48);
            btnPower.TabIndex = 24;
            btnPower.Tag = "Power";
            btnPower.Text = "xʸ";
            btnPower.UseVisualStyleBackColor = false;
            btnPower.Click += uOperator_Click;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.FromArgb(142, 68, 173);
            btnLog.Font = new Font("Microsoft Sans Serif", 12F);
            btnLog.ForeColor = Color.White;
            btnLog.Location = new Point(226, 0);
            btnLog.Margin = new Padding(3, 4, 3, 4);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(69, 48);
            btnLog.TabIndex = 25;
            btnLog.Tag = "Log";
            btnLog.Text = "log";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += uOperator_Click;
            // 
            // btnLn
            // 
            btnLn.BackColor = Color.FromArgb(142, 68, 173);
            btnLn.Font = new Font("Microsoft Sans Serif", 12F);
            btnLn.ForeColor = Color.White;
            btnLn.Location = new Point(302, 0);
            btnLn.Margin = new Padding(3, 4, 3, 4);
            btnLn.Name = "btnLn";
            btnLn.Size = new Size(69, 48);
            btnLn.TabIndex = 26;
            btnLn.Tag = "Ln";
            btnLn.Text = "ln";
            btnLn.UseVisualStyleBackColor = false;
            btnLn.Click += uOperator_Click;
            // 
            // btnSin
            // 
            btnSin.BackColor = Color.FromArgb(142, 68, 173);
            btnSin.Font = new Font("Microsoft Sans Serif", 12F);
            btnSin.ForeColor = Color.White;
            btnSin.Location = new Point(377, 0);
            btnSin.Margin = new Padding(3, 4, 3, 4);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(69, 48);
            btnSin.TabIndex = 27;
            btnSin.Tag = "Sin";
            btnSin.Text = "sin";
            btnSin.UseVisualStyleBackColor = false;
            btnSin.Click += uOperator_Click;
            // 
            // btnCos
            // 
            btnCos.BackColor = Color.FromArgb(142, 68, 173);
            btnCos.Font = new Font("Microsoft Sans Serif", 12F);
            btnCos.ForeColor = Color.White;
            btnCos.Location = new Point(0, 53);
            btnCos.Margin = new Padding(3, 4, 3, 4);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(69, 48);
            btnCos.TabIndex = 28;
            btnCos.Tag = "Cos";
            btnCos.Text = "cos";
            btnCos.UseVisualStyleBackColor = false;
            btnCos.Click += uOperator_Click;
            // 
            // btnTan
            // 
            btnTan.BackColor = Color.FromArgb(142, 68, 173);
            btnTan.Font = new Font("Microsoft Sans Serif", 12F);
            btnTan.ForeColor = Color.White;
            btnTan.Location = new Point(75, 53);
            btnTan.Margin = new Padding(3, 4, 3, 4);
            btnTan.Name = "btnTan";
            btnTan.Size = new Size(69, 48);
            btnTan.TabIndex = 29;
            btnTan.Tag = "Tan";
            btnTan.Text = "tan";
            btnTan.UseVisualStyleBackColor = false;
            btnTan.Click += uOperator_Click;
            // 
            // btnMPlus
            // 
            btnMPlus.BackColor = Color.FromArgb(142, 68, 173);
            btnMPlus.Font = new Font("Microsoft Sans Serif", 11F);
            btnMPlus.ForeColor = Color.White;
            btnMPlus.Location = new Point(0, 107);
            btnMPlus.Margin = new Padding(3, 4, 3, 4);
            btnMPlus.Name = "btnMPlus";
            btnMPlus.Size = new Size(69, 48);
            btnMPlus.TabIndex = 30;
            btnMPlus.Tag = "MPlus";
            btnMPlus.Text = "M+";
            btnMPlus.UseVisualStyleBackColor = false;
            btnMPlus.Click += memoryButton_Click;
            // 
            // btnMMinus
            // 
            btnMMinus.BackColor = Color.FromArgb(142, 68, 173);
            btnMMinus.Font = new Font("Microsoft Sans Serif", 11F);
            btnMMinus.ForeColor = Color.White;
            btnMMinus.Location = new Point(75, 107);
            btnMMinus.Margin = new Padding(3, 4, 3, 4);
            btnMMinus.Name = "btnMMinus";
            btnMMinus.Size = new Size(69, 48);
            btnMMinus.TabIndex = 31;
            btnMMinus.Tag = "MMinus";
            btnMMinus.Text = "M−";
            btnMMinus.UseVisualStyleBackColor = false;
            btnMMinus.Click += memoryButton_Click;
            // 
            // btnMR
            // 
            btnMR.BackColor = Color.FromArgb(142, 68, 173);
            btnMR.Font = new Font("Microsoft Sans Serif", 11F);
            btnMR.ForeColor = Color.White;
            btnMR.Location = new Point(151, 107);
            btnMR.Margin = new Padding(3, 4, 3, 4);
            btnMR.Name = "btnMR";
            btnMR.Size = new Size(69, 48);
            btnMR.TabIndex = 32;
            btnMR.Tag = "MR";
            btnMR.Text = "MR";
            btnMR.UseVisualStyleBackColor = false;
            btnMR.Click += memoryButton_Click;
            // 
            // btnMC
            // 
            btnMC.BackColor = Color.FromArgb(142, 68, 173);
            btnMC.Font = new Font("Microsoft Sans Serif", 11F);
            btnMC.ForeColor = Color.White;
            btnMC.Location = new Point(226, 107);
            btnMC.Margin = new Padding(3, 4, 3, 4);
            btnMC.Name = "btnMC";
            btnMC.Size = new Size(69, 48);
            btnMC.TabIndex = 33;
            btnMC.Tag = "MC";
            btnMC.Text = "MC";
            btnMC.UseVisualStyleBackColor = false;
            btnMC.Click += memoryButton_Click;
            // 
            // btnPi
            // 
            btnPi.BackColor = Color.FromArgb(142, 68, 173);
            btnPi.Font = new Font("Microsoft Sans Serif", 12F);
            btnPi.ForeColor = Color.White;
            btnPi.Location = new Point(0, 160);
            btnPi.Margin = new Padding(3, 4, 3, 4);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(69, 48);
            btnPi.TabIndex = 34;
            btnPi.Tag = "Pi";
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = false;
            btnPi.Click += constantButton_Click;
            // 
            // btnE
            // 
            btnE.BackColor = Color.FromArgb(142, 68, 173);
            btnE.Font = new Font("Microsoft Sans Serif", 12F);
            btnE.ForeColor = Color.White;
            btnE.Location = new Point(75, 160);
            btnE.Margin = new Padding(3, 4, 3, 4);
            btnE.Name = "btnE";
            btnE.Size = new Size(69, 48);
            btnE.TabIndex = 35;
            btnE.Tag = "E";
            btnE.Text = "e";
            btnE.UseVisualStyleBackColor = false;
            btnE.Click += constantButton_Click;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = Color.FromArgb(41, 128, 185);
            btnPercent.Font = new Font("Microsoft Sans Serif", 15F);
            btnPercent.ForeColor = Color.White;
            btnPercent.Location = new Point(366, 149);
            btnPercent.Margin = new Padding(3, 4, 3, 4);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(82, 64);
            btnPercent.TabIndex = 36;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            btnPercent.Click += btnPercent_Click;
            // 
            // btnModulus
            // 
            btnModulus.BackColor = Color.FromArgb(41, 128, 185);
            btnModulus.Font = new Font("Microsoft Sans Serif", 15F);
            btnModulus.ForeColor = Color.White;
            btnModulus.Location = new Point(274, 149);
            btnModulus.Margin = new Padding(3, 4, 3, 4);
            btnModulus.Name = "btnModulus";
            btnModulus.Size = new Size(82, 64);
            btnModulus.TabIndex = 37;
            btnModulus.Tag = "Modulus";
            btnModulus.Text = "mod";
            btnModulus.FlatStyle = FlatStyle.Flat;
            btnModulus.FlatAppearance.BorderSize = 0;
            btnModulus.UseVisualStyleBackColor = false;
            btnModulus.Click += operator_Click;
            tabStandard.Controls.Add(btnModulus);
            // 
            // btnDegreeRadian
            // 
            btnDegreeRadian.BackColor = Color.FromArgb(41, 128, 185);
            btnDegreeRadian.Font = new Font("Microsoft Sans Serif", 10F);
            btnDegreeRadian.ForeColor = Color.White;
            btnDegreeRadian.Location = new Point(151, 53);
            btnDegreeRadian.Margin = new Padding(3, 4, 3, 4);
            btnDegreeRadian.Name = "btnDegreeRadian";
            btnDegreeRadian.Size = new Size(69, 48);
            btnDegreeRadian.TabIndex = 39;
            btnDegreeRadian.Text = "RAD";
            btnDegreeRadian.UseVisualStyleBackColor = false;
            btnDegreeRadian.Click += btnDegreeRadian_Click;
            // 
            // btnInverse
            // 
            btnInverse.BackColor = Color.FromArgb(41, 128, 185);
            btnInverse.Font = new Font("Microsoft Sans Serif", 10F);
            btnInverse.ForeColor = Color.White;
            btnInverse.Location = new Point(226, 53);
            btnInverse.Margin = new Padding(3, 4, 3, 4);
            btnInverse.Name = "btnInverse";
            btnInverse.Size = new Size(69, 48);
            btnInverse.TabIndex = 40;
            btnInverse.Text = "Inv";
            btnInverse.UseVisualStyleBackColor = false;
            btnInverse.Click += btnInverse_Click;
            // 
            // btnReciprocal
            // 
            btnReciprocal.BackColor = Color.FromArgb(142, 68, 173);
            btnReciprocal.Font = new Font("Microsoft Sans Serif", 12F);
            btnReciprocal.ForeColor = Color.White;
            btnReciprocal.Location = new Point(0, 0);
            btnReciprocal.Margin = new Padding(3, 4, 3, 4);
            btnReciprocal.Name = "btnReciprocal";
            btnReciprocal.Size = new Size(82, 64);
            btnReciprocal.TabIndex = 42;
            btnReciprocal.Text = "1/x";
            btnReciprocal.UseVisualStyleBackColor = false;
            btnReciprocal.Click += btnReciprocal_Click;
            // 
            // btnCubeRoot
            // 
            btnCubeRoot.BackColor = Color.FromArgb(142, 68, 173);
            btnCubeRoot.Font = new Font("Microsoft Sans Serif", 12F);
            btnCubeRoot.ForeColor = Color.White;
            btnCubeRoot.Location = new Point(302, 53);
            btnCubeRoot.Margin = new Padding(3, 4, 3, 4);
            btnCubeRoot.Name = "btnCubeRoot";
            btnCubeRoot.Size = new Size(69, 48);
            btnCubeRoot.TabIndex = 43;
            btnCubeRoot.Text = "∛";
            btnCubeRoot.UseVisualStyleBackColor = false;
            btnCubeRoot.Click += btnCubeRoot_Click;
            // 
            // btnNthRoot
            // 
            btnNthRoot.BackColor = Color.FromArgb(142, 68, 173);
            btnNthRoot.Font = new Font("Microsoft Sans Serif", 12F);
            btnNthRoot.ForeColor = Color.White;
            btnNthRoot.Location = new Point(377, 53);
            btnNthRoot.Margin = new Padding(3, 4, 3, 4);
            btnNthRoot.Name = "btnNthRoot";
            btnNthRoot.Size = new Size(69, 48);
            btnNthRoot.TabIndex = 44;
            btnNthRoot.Text = "ⁿ√";
            btnNthRoot.UseVisualStyleBackColor = false;
            btnNthRoot.Click += btnNthRoot_Click;
            // 
            // btnSaveMemory
            // 
            btnSaveMemory.BackColor = Color.FromArgb(142, 68, 173);
            btnSaveMemory.Font = new Font("Microsoft Sans Serif", 10F);
            btnSaveMemory.ForeColor = Color.White;
            btnSaveMemory.Location = new Point(302, 107);
            btnSaveMemory.Margin = new Padding(3, 4, 3, 4);
            btnSaveMemory.Name = "btnSaveMemory";
            btnSaveMemory.Size = new Size(69, 48);
            btnSaveMemory.TabIndex = 45;
            btnSaveMemory.Text = "Save";
            btnSaveMemory.UseVisualStyleBackColor = false;
            btnSaveMemory.Click += btnSaveMemory_Click;
            // 
            // btnRecallMemory
            // 
            btnRecallMemory.BackColor = Color.FromArgb(142, 68, 173);
            btnRecallMemory.Font = new Font("Microsoft Sans Serif", 10F);
            btnRecallMemory.ForeColor = Color.White;
            btnRecallMemory.Location = new Point(377, 107);
            btnRecallMemory.Margin = new Padding(3, 4, 3, 4);
            btnRecallMemory.Name = "btnRecallMemory";
            btnRecallMemory.Size = new Size(69, 48);
            btnRecallMemory.TabIndex = 46;
            btnRecallMemory.Text = "Recall";
            btnRecallMemory.UseVisualStyleBackColor = false;
            btnRecallMemory.Click += btnRecallMemory_Click;
            // 
            // btnUndo
            // 
            btnUndo.BackColor = Color.FromArgb(41, 128, 185);
            btnUndo.Enabled = false;
            btnUndo.Font = new Font("Microsoft Sans Serif", 10F);
            btnUndo.ForeColor = Color.White;
            btnUndo.Location = new Point(226, 213);
            btnUndo.Margin = new Padding(3, 4, 3, 4);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(69, 48);
            btnUndo.TabIndex = 47;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = false;
            btnUndo.Click += btnUndo_Click;
            // 
            // tabModes
            // 
            tabModes.Controls.Add(tabStandard);
            tabModes.Controls.Add(tabScientific);
            tabModes.Controls.Add(tabHistory);
            tabModes.ItemSize = new Size(80, 30);
            tabModes.Location = new Point(14, 131);
            tabModes.Margin = new Padding(3, 4, 3, 4);
            tabModes.Name = "tabModes";
            tabModes.Padding = new Point(12, 4);
            tabModes.SelectedIndex = 0;
            tabModes.Size = new Size(457, 640);
            tabModes.SizeMode = TabSizeMode.Fixed;
            tabModes.TabIndex = 51;
            // 
            // tabStandard
            // 
            tabStandard.BackColor = Color.FromArgb(30, 30, 30);
            tabStandard.Controls.Add(btnPercent);
            tabStandard.Controls.Add(btnReciprocal);
            tabStandard.Controls.Add(btn1);
            tabStandard.Controls.Add(btn2);
            tabStandard.Controls.Add(btn3);
            tabStandard.Controls.Add(btn4);
            tabStandard.Controls.Add(btn5);
            tabStandard.Controls.Add(btn6);
            tabStandard.Controls.Add(btn7);
            tabStandard.Controls.Add(btn8);
            tabStandard.Controls.Add(btn9);
            tabStandard.Controls.Add(btn0);
            tabStandard.Controls.Add(btnDot);
            tabStandard.Controls.Add(btnC);
            tabStandard.Controls.Add(btnCE);
            tabStandard.Controls.Add(btnBackspace);
            tabStandard.Controls.Add(btnAdd);
            tabStandard.Controls.Add(btnSubtract);
            tabStandard.Controls.Add(btnMultiply);
            tabStandard.Controls.Add(btnDivide);
            tabStandard.Controls.Add(btnSqrt);
            tabStandard.Controls.Add(btnEqu);
            tabStandard.Controls.Add(btnNegate);
            tabStandard.Controls.Add(btnCopy);
            tabStandard.Controls.Add(btnTheme);
            tabStandard.Controls.Add(btnAudioToggle);
            tabStandard.Location = new Point(4, 34);
            tabStandard.Margin = new Padding(3, 4, 3, 4);
            tabStandard.Name = "tabStandard";
            tabStandard.Padding = new Padding(3, 4, 3, 4);
            tabStandard.Size = new Size(449, 602);
            tabStandard.TabIndex = 0;
            tabStandard.Text = "Standard";
            // 
            // btnTheme
            // 
            btnTheme.BackColor = Color.FromArgb(41, 128, 185);
            btnTheme.Font = new Font("Microsoft Sans Serif", 6F);
            btnTheme.ForeColor = Color.White;
            btnTheme.Location = new Point(274, 0);
            btnTheme.Margin = new Padding(3, 4, 3, 4);
            btnTheme.Name = "btnTheme";
            btnTheme.Size = new Size(82, 64);
            btnTheme.TabIndex = 50;
            btnTheme.Text = "Theme";
            btnTheme.UseVisualStyleBackColor = false;
            btnTheme.Click += btnTheme_Click;
            // 
            // btnAudioToggle
            // 
            btnAudioToggle.BackColor = Color.FromArgb(41, 128, 185);
            btnAudioToggle.Font = new Font("Microsoft Sans Serif", 12F);
            btnAudioToggle.ForeColor = Color.White;
            btnAudioToggle.Location = new Point(366, 0);
            btnAudioToggle.Margin = new Padding(3, 4, 3, 4);
            btnAudioToggle.Name = "btnAudioToggle";
            btnAudioToggle.Size = new Size(82, 64);
            btnAudioToggle.TabIndex = 52;
            btnAudioToggle.Text = "🔊";
            btnAudioToggle.UseVisualStyleBackColor = false;
            btnAudioToggle.Click += btnAudioToggle_Click;
            // 
            // tabScientific
            // 
            tabScientific.BackColor = Color.FromArgb(30, 30, 30);
            tabScientific.Controls.Add(btnSquare);
            tabScientific.Controls.Add(btnFactorial);
            tabScientific.Controls.Add(btnPower);
            tabScientific.Controls.Add(btnLog);
            tabScientific.Controls.Add(btnLn);
            tabScientific.Controls.Add(btnSin);
            tabScientific.Controls.Add(btnCos);
            tabScientific.Controls.Add(btnTan);
            tabScientific.Controls.Add(btnMPlus);
            tabScientific.Controls.Add(btnMMinus);
            tabScientific.Controls.Add(btnMR);
            tabScientific.Controls.Add(btnMC);
            tabScientific.Controls.Add(btnPi);
            tabScientific.Controls.Add(btnE);
            tabScientific.Controls.Add(btnDegreeRadian);
            tabScientific.Controls.Add(btnInverse);
            tabScientific.Controls.Add(btnCubeRoot);
            tabScientific.Controls.Add(btnNthRoot);
            tabScientific.Controls.Add(btnSaveMemory);
            tabScientific.Controls.Add(btnRecallMemory);
            tabScientific.Controls.Add(btnUndo);
            tabScientific.Controls.Add(btnRedo);
            tabScientific.Controls.Add(btnClearHistory);
            tabScientific.Controls.Add(btnBackspaceSci);
            tabScientific.Controls.Add(btnCESci);
            tabScientific.Controls.Add(btnCSci);
            tabScientific.Controls.Add(btn7Sci);
            tabScientific.Controls.Add(btn8Sci);
            tabScientific.Controls.Add(btn9Sci);
            tabScientific.Controls.Add(btnDivideSci);
            tabScientific.Controls.Add(btnSqrtSci);
            tabScientific.Controls.Add(btn4Sci);
            tabScientific.Controls.Add(btn5Sci);
            tabScientific.Controls.Add(btn6Sci);
            tabScientific.Controls.Add(btnMultiplySci);
            tabScientific.Controls.Add(btnNegateSci);
            tabScientific.Controls.Add(btn1Sci);
            tabScientific.Controls.Add(btn2Sci);
            tabScientific.Controls.Add(btn3Sci);
            tabScientific.Controls.Add(btnSubtractSci);
            tabScientific.Controls.Add(btnAddSci);
            tabScientific.Controls.Add(btn0Sci);
            tabScientific.Controls.Add(btnDotSci);
            tabScientific.Controls.Add(btnEquSci);
            tabScientific.Controls.Add(btnCopySci);
            tabScientific.Controls.Add(btnReciprocalSci);
            tabScientific.Controls.Add(btnPercentSci);
            tabScientific.Controls.Add(btnThemeSci);
            tabScientific.Controls.Add(btnAudioToggleSci);
            tabScientific.Location = new Point(4, 34);
            tabScientific.Margin = new Padding(3, 4, 3, 4);
            tabScientific.Name = "tabScientific";
            tabScientific.Padding = new Padding(3, 4, 3, 4);
            tabScientific.Size = new Size(449, 602);
            tabScientific.TabIndex = 1;
            tabScientific.Text = "Scientific";
            // 
            // btnRedo
            // 
            btnRedo.BackColor = Color.FromArgb(41, 128, 185);
            btnRedo.Enabled = false;
            btnRedo.Font = new Font("Microsoft Sans Serif", 10F);
            btnRedo.ForeColor = Color.White;
            btnRedo.Location = new Point(302, 213);
            btnRedo.Margin = new Padding(3, 4, 3, 4);
            btnRedo.Name = "btnRedo";
            btnRedo.Size = new Size(69, 48);
            btnRedo.TabIndex = 48;
            btnRedo.Text = "Redo";
            btnRedo.UseVisualStyleBackColor = false;
            btnRedo.Click += btnRedo_Click;
            // 
            // btnClearHistory
            // 
            btnClearHistory.BackColor = Color.FromArgb(192, 57, 43);
            btnClearHistory.Font = new Font("Microsoft Sans Serif", 10F);
            btnClearHistory.ForeColor = Color.White;
            btnClearHistory.Location = new Point(302, 160);
            btnClearHistory.Margin = new Padding(3, 4, 3, 4);
            btnClearHistory.Name = "btnClearHistory";
            btnClearHistory.Size = new Size(69, 48);
            btnClearHistory.TabIndex = 38;
            btnClearHistory.Text = "Clear\nHistory";
            btnClearHistory.UseVisualStyleBackColor = false;
            btnClearHistory.Click += btnClearHistory_Click;
            // 
            // btnBackspaceSci
            // 
            btnBackspaceSci.BackColor = Color.FromArgb(192, 57, 43);
            btnBackspaceSci.Font = new Font("Microsoft Sans Serif", 15F);
            btnBackspaceSci.ForeColor = Color.White;
            btnBackspaceSci.Location = new Point(0, 213);
            btnBackspaceSci.Margin = new Padding(3, 4, 3, 4);
            btnBackspaceSci.Name = "btnBackspaceSci";
            btnBackspaceSci.Size = new Size(69, 48);
            btnBackspaceSci.TabIndex = 100;
            btnBackspaceSci.Text = "⌫";
            btnBackspaceSci.UseVisualStyleBackColor = false;
            btnBackspaceSci.Click += btnBackspace_Click;
            // 
            // btnCESci
            // 
            btnCESci.BackColor = Color.FromArgb(192, 57, 43);
            btnCESci.Font = new Font("Microsoft Sans Serif", 15F);
            btnCESci.ForeColor = Color.White;
            btnCESci.Location = new Point(75, 213);
            btnCESci.Margin = new Padding(3, 4, 3, 4);
            btnCESci.Name = "btnCESci";
            btnCESci.Size = new Size(69, 48);
            btnCESci.TabIndex = 101;
            btnCESci.Text = "CE";
            btnCESci.UseVisualStyleBackColor = false;
            btnCESci.Click += btnCE_Click;
            // 
            // btnCSci
            // 
            btnCSci.BackColor = Color.FromArgb(192, 57, 43);
            btnCSci.Font = new Font("Microsoft Sans Serif", 15F);
            btnCSci.ForeColor = Color.White;
            btnCSci.Location = new Point(151, 213);
            btnCSci.Margin = new Padding(3, 4, 3, 4);
            btnCSci.Name = "btnCSci";
            btnCSci.Size = new Size(69, 48);
            btnCSci.TabIndex = 102;
            btnCSci.Text = "C";
            btnCSci.UseVisualStyleBackColor = false;
            btnCSci.Click += btnC_Click;
            // 
            // btn7Sci
            // 
            btn7Sci.BackColor = Color.FromArgb(60, 60, 60);
            btn7Sci.ForeColor = Color.White;
            btn7Sci.Font = new Font("Microsoft Sans Serif", 15F);
            btn7Sci.Location = new Point(0, 267);
            btn7Sci.Margin = new Padding(3, 4, 3, 4);
            btn7Sci.Name = "btn7Sci";
            btn7Sci.Size = new Size(69, 48);
            btn7Sci.TabIndex = 103;
            btn7Sci.Text = "7";
            btn7Sci.UseVisualStyleBackColor = false;
            btn7Sci.Click += numPad_Click;
            // 
            // btn8Sci
            // 
            btn8Sci.BackColor = Color.FromArgb(60, 60, 60);
            btn8Sci.ForeColor = Color.White;
            btn8Sci.Font = new Font("Microsoft Sans Serif", 15F);
            btn8Sci.Location = new Point(75, 267);
            btn8Sci.Margin = new Padding(3, 4, 3, 4);
            btn8Sci.Name = "btn8Sci";
            btn8Sci.Size = new Size(69, 48);
            btn8Sci.TabIndex = 104;
            btn8Sci.Text = "8";
            btn8Sci.UseVisualStyleBackColor = false;
            btn8Sci.Click += numPad_Click;
            // 
            // btn9Sci
            // 
            btn9Sci.BackColor = Color.FromArgb(60, 60, 60);
            btn9Sci.ForeColor = Color.White;
            btn9Sci.Font = new Font("Microsoft Sans Serif", 15F);
            btn9Sci.Location = new Point(151, 267);
            btn9Sci.Margin = new Padding(3, 4, 3, 4);
            btn9Sci.Name = "btn9Sci";
            btn9Sci.Size = new Size(69, 48);
            btn9Sci.TabIndex = 105;
            btn9Sci.Text = "9";
            btn9Sci.UseVisualStyleBackColor = false;
            btn9Sci.Click += numPad_Click;
            // 
            // btnDivideSci
            // 
            btnDivideSci.BackColor = Color.FromArgb(41, 128, 185);
            btnDivideSci.Font = new Font("Microsoft Sans Serif", 15F);
            btnDivideSci.ForeColor = Color.White;
            btnDivideSci.Location = new Point(226, 267);
            btnDivideSci.Margin = new Padding(3, 4, 3, 4);
            btnDivideSci.Name = "btnDivideSci";
            btnDivideSci.Size = new Size(69, 48);
            btnDivideSci.TabIndex = 106;
            btnDivideSci.Tag = "Divide";
            btnDivideSci.Text = "÷";
            btnDivideSci.UseVisualStyleBackColor = false;
            btnDivideSci.Click += operator_Click;
            // 
            // btnSqrtSci
            // 
            btnSqrtSci.BackColor = Color.FromArgb(142, 68, 173);
            btnSqrtSci.Font = new Font("Microsoft Sans Serif", 15F);
            btnSqrtSci.ForeColor = Color.White;
            btnSqrtSci.Location = new Point(302, 267);
            btnSqrtSci.Margin = new Padding(3, 4, 3, 4);
            btnSqrtSci.Name = "btnSqrtSci";
            btnSqrtSci.Size = new Size(69, 48);
            btnSqrtSci.TabIndex = 107;
            btnSqrtSci.Tag = "Sqrt";
            btnSqrtSci.Text = "√";
            btnSqrtSci.UseVisualStyleBackColor = false;
            btnSqrtSci.Click += uOperator_Click;
            // 
            // btn4Sci
            // 
            btn4Sci.BackColor = Color.FromArgb(60, 60, 60);
            btn4Sci.ForeColor = Color.White;
            btn4Sci.Font = new Font("Microsoft Sans Serif", 15F);
            btn4Sci.Location = new Point(0, 320);
            btn4Sci.Margin = new Padding(3, 4, 3, 4);
            btn4Sci.Name = "btn4Sci";
            btn4Sci.Size = new Size(69, 48);
            btn4Sci.TabIndex = 108;
            btn4Sci.Text = "4";
            btn4Sci.UseVisualStyleBackColor = false;
            btn4Sci.Click += numPad_Click;
            // 
            // btn5Sci
            // 
            btn5Sci.BackColor = Color.FromArgb(60, 60, 60);
            btn5Sci.ForeColor = Color.White;
            btn5Sci.Font = new Font("Microsoft Sans Serif", 15F);
            btn5Sci.Location = new Point(75, 320);
            btn5Sci.Margin = new Padding(3, 4, 3, 4);
            btn5Sci.Name = "btn5Sci";
            btn5Sci.Size = new Size(69, 48);
            btn5Sci.TabIndex = 109;
            btn5Sci.Text = "5";
            btn5Sci.UseVisualStyleBackColor = false;
            btn5Sci.Click += numPad_Click;
            // 
            // btn6Sci
            // 
            btn6Sci.BackColor = Color.FromArgb(60, 60, 60);
            btn6Sci.ForeColor = Color.White;
            btn6Sci.Font = new Font("Microsoft Sans Serif", 15F);
            btn6Sci.Location = new Point(151, 320);
            btn6Sci.Margin = new Padding(3, 4, 3, 4);
            btn6Sci.Name = "btn6Sci";
            btn6Sci.Size = new Size(69, 48);
            btn6Sci.TabIndex = 110;
            btn6Sci.Text = "6";
            btn6Sci.UseVisualStyleBackColor = false;
            btn6Sci.Click += numPad_Click;
            // 
            // btnMultiplySci
            // 
            btnMultiplySci.BackColor = Color.FromArgb(41, 128, 185);
            btnMultiplySci.Font = new Font("Microsoft Sans Serif", 15F);
            btnMultiplySci.ForeColor = Color.White;
            btnMultiplySci.Location = new Point(226, 320);
            btnMultiplySci.Margin = new Padding(3, 4, 3, 4);
            btnMultiplySci.Name = "btnMultiplySci";
            btnMultiplySci.Size = new Size(69, 48);
            btnMultiplySci.TabIndex = 111;
            btnMultiplySci.Tag = "Multiply";
            btnMultiplySci.Text = "×";
            btnMultiplySci.UseVisualStyleBackColor = false;
            btnMultiplySci.Click += operator_Click;
            // 
            // btnNegateSci
            // 
            btnNegateSci.BackColor = Color.FromArgb(41, 128, 185);
            btnNegateSci.Font = new Font("Microsoft Sans Serif", 15F);
            btnNegateSci.ForeColor = Color.White;
            btnNegateSci.Location = new Point(302, 320);
            btnNegateSci.Margin = new Padding(3, 4, 3, 4);
            btnNegateSci.Name = "btnNegateSci";
            btnNegateSci.Size = new Size(69, 48);
            btnNegateSci.TabIndex = 112;
            btnNegateSci.Text = "±";
            btnNegateSci.UseVisualStyleBackColor = false;
            btnNegateSci.Click += btnNegate_Click;
            // 
            // btn1Sci
            // 
            btn1Sci.BackColor = Color.FromArgb(60, 60, 60);
            btn1Sci.ForeColor = Color.White;
            btn1Sci.Font = new Font("Microsoft Sans Serif", 15F);
            btn1Sci.Location = new Point(0, 373);
            btn1Sci.Margin = new Padding(3, 4, 3, 4);
            btn1Sci.Name = "btn1Sci";
            btn1Sci.Size = new Size(69, 48);
            btn1Sci.TabIndex = 113;
            btn1Sci.Text = "1";
            btn1Sci.UseVisualStyleBackColor = false;
            btn1Sci.Click += numPad_Click;
            // 
            // btn2Sci
            // 
            btn2Sci.BackColor = Color.FromArgb(60, 60, 60);
            btn2Sci.ForeColor = Color.White;
            btn2Sci.Font = new Font("Microsoft Sans Serif", 15F);
            btn2Sci.Location = new Point(75, 373);
            btn2Sci.Margin = new Padding(3, 4, 3, 4);
            btn2Sci.Name = "btn2Sci";
            btn2Sci.Size = new Size(69, 48);
            btn2Sci.TabIndex = 114;
            btn2Sci.Text = "2";
            btn2Sci.UseVisualStyleBackColor = false;
            btn2Sci.Click += numPad_Click;
            // 
            // btn3Sci
            // 
            btn3Sci.BackColor = Color.FromArgb(60, 60, 60);
            btn3Sci.ForeColor = Color.White;
            btn3Sci.Font = new Font("Microsoft Sans Serif", 15F);
            btn3Sci.Location = new Point(151, 373);
            btn3Sci.Margin = new Padding(3, 4, 3, 4);
            btn3Sci.Name = "btn3Sci";
            btn3Sci.Size = new Size(69, 48);
            btn3Sci.TabIndex = 115;
            btn3Sci.Text = "3";
            btn3Sci.UseVisualStyleBackColor = false;
            btn3Sci.Click += numPad_Click;
            // 
            // btnSubtractSci
            // 
            btnSubtractSci.BackColor = Color.FromArgb(41, 128, 185);
            btnSubtractSci.Font = new Font("Microsoft Sans Serif", 15F);
            btnSubtractSci.ForeColor = Color.White;
            btnSubtractSci.Location = new Point(226, 373);
            btnSubtractSci.Margin = new Padding(3, 4, 3, 4);
            btnSubtractSci.Name = "btnSubtractSci";
            btnSubtractSci.Size = new Size(69, 48);
            btnSubtractSci.TabIndex = 116;
            btnSubtractSci.Tag = "Subtract";
            btnSubtractSci.Text = "−";
            btnSubtractSci.UseVisualStyleBackColor = false;
            btnSubtractSci.Click += operator_Click;
            // 
            // btnAddSci
            // 
            btnAddSci.BackColor = Color.FromArgb(41, 128, 185);
            btnAddSci.Font = new Font("Microsoft Sans Serif", 15F);
            btnAddSci.ForeColor = Color.White;
            btnAddSci.Location = new Point(302, 373);
            btnAddSci.Margin = new Padding(3, 4, 3, 4);
            btnAddSci.Name = "btnAddSci";
            btnAddSci.Size = new Size(69, 48);
            btnAddSci.TabIndex = 117;
            btnAddSci.Tag = "Add";
            btnAddSci.Text = "+";
            btnAddSci.UseVisualStyleBackColor = false;
            btnAddSci.Click += operator_Click;
            // 
            // btn0Sci
            // 
            btn0Sci.BackColor = Color.FromArgb(60, 60, 60);
            btn0Sci.ForeColor = Color.White;
            btn0Sci.Font = new Font("Microsoft Sans Serif", 15F);
            btn0Sci.Location = new Point(0, 427);
            btn0Sci.Margin = new Padding(3, 4, 3, 4);
            btn0Sci.Name = "btn0Sci";
            btn0Sci.Size = new Size(69, 48);
            btn0Sci.TabIndex = 118;
            btn0Sci.Text = "0";
            btn0Sci.UseVisualStyleBackColor = false;
            btn0Sci.Click += numPad_Click;
            // 
            // btnDotSci
            // 
            btnDotSci.BackColor = Color.FromArgb(60, 60, 60);
            btnDotSci.ForeColor = Color.White;
            btnDotSci.Font = new Font("Microsoft Sans Serif", 15F);
            btnDotSci.Location = new Point(75, 427);
            btnDotSci.Margin = new Padding(3, 4, 3, 4);
            btnDotSci.Name = "btnDotSci";
            btnDotSci.Size = new Size(69, 48);
            btnDotSci.TabIndex = 119;
            btnDotSci.Text = ".";
            btnDotSci.UseVisualStyleBackColor = false;
            btnDotSci.Click += numPad_Click;
            // 
            // btnEquSci
            // 
            btnEquSci.BackColor = Color.FromArgb(41, 128, 185);
            btnEquSci.Font = new Font("Microsoft Sans Serif", 15F);
            btnEquSci.ForeColor = Color.White;
            btnEquSci.Location = new Point(226, 427);
            btnEquSci.Margin = new Padding(3, 4, 3, 4);
            btnEquSci.Name = "btnEquSci";
            btnEquSci.Size = new Size(69, 48);
            btnEquSci.TabIndex = 120;
            btnEquSci.Tag = "Equ";
            btnEquSci.Text = "=";
            btnEquSci.UseVisualStyleBackColor = false;
            btnEquSci.Click += btnEqu_Click;
            // 
            // btnCopySci
            // 
            btnCopySci.BackColor = Color.FromArgb(142, 68, 173);
            btnCopySci.Font = new Font("Microsoft Sans Serif", 12F);
            btnCopySci.ForeColor = Color.White;
            btnCopySci.Location = new Point(377, 160);
            btnCopySci.Margin = new Padding(3, 4, 3, 4);
            btnCopySci.Name = "btnCopySci";
            btnCopySci.Size = new Size(69, 48);
            btnCopySci.TabIndex = 121;
            btnCopySci.Text = "Copy";
            btnCopySci.UseVisualStyleBackColor = false;
            btnCopySci.Click += btnCopy_Click;
            // 
            // btnReciprocalSci
            // 
            btnReciprocalSci.BackColor = Color.FromArgb(142, 68, 173);
            btnReciprocalSci.Font = new Font("Microsoft Sans Serif", 12F);
            btnReciprocalSci.ForeColor = Color.White;
            btnReciprocalSci.Location = new Point(151, 160);
            btnReciprocalSci.Margin = new Padding(3, 4, 3, 4);
            btnReciprocalSci.Name = "btnReciprocalSci";
            btnReciprocalSci.Size = new Size(69, 48);
            btnReciprocalSci.TabIndex = 122;
            btnReciprocalSci.Text = "1/x";
            btnReciprocalSci.UseVisualStyleBackColor = false;
            btnReciprocalSci.Click += btnReciprocal_Click;
            // 
            // btnModulusSci
            // 
            btnModulusSci.BackColor = Color.FromArgb(41, 128, 185);
            btnModulusSci.Font = new Font("Microsoft Sans Serif", 12F);
            btnModulusSci.ForeColor = Color.White;
            btnModulusSci.Location = new Point(132, 160);
            btnModulusSci.Margin = new Padding(3, 4, 3, 4);
            btnModulusSci.Name = "btnModulusSci";
            btnModulusSci.Size = new Size(60, 48);
            btnModulusSci.TabIndex = 124;
            btnModulusSci.Tag = "Modulus";
            btnModulusSci.Text = "mod";
            btnModulusSci.FlatStyle = FlatStyle.Flat;
            btnModulusSci.FlatAppearance.BorderSize = 0;
            btnModulusSci.UseVisualStyleBackColor = false;
            btnModulusSci.Click += operator_Click;
            tabScientific.Controls.Add(btnModulusSci);
            // 
            // btnPercentSci
            // 
            btnPercentSci.BackColor = Color.FromArgb(41, 128, 185);
            btnPercentSci.Font = new Font("Microsoft Sans Serif", 15F);
            btnPercentSci.ForeColor = Color.White;
            btnPercentSci.Location = new Point(226, 160);
            btnPercentSci.Margin = new Padding(3, 4, 3, 4);
            btnPercentSci.Name = "btnPercentSci";
            btnPercentSci.Size = new Size(69, 48);
            btnPercentSci.TabIndex = 123;
            btnPercentSci.Text = "%";
            btnPercentSci.UseVisualStyleBackColor = false;
            btnPercentSci.Click += btnPercent_Click;
            // 
            // btnThemeSci
            // 
            btnThemeSci.BackColor = Color.FromArgb(41, 128, 185);
            btnThemeSci.Font = new Font("Microsoft Sans Serif", 6F);
            btnThemeSci.ForeColor = Color.White;
            btnThemeSci.Location = new Point(377, 213);
            btnThemeSci.Margin = new Padding(3, 4, 3, 4);
            btnThemeSci.Name = "btnThemeSci";
            btnThemeSci.Size = new Size(69, 48);
            btnThemeSci.TabIndex = 124;
            btnThemeSci.Text = "Theme";
            btnThemeSci.UseVisualStyleBackColor = false;
            btnThemeSci.Click += btnTheme_Click;
            // 
            // btnAudioToggleSci
            // 
            btnAudioToggleSci.BackColor = Color.FromArgb(41, 128, 185);
            btnAudioToggleSci.Font = new Font("Microsoft Sans Serif", 12F);
            btnAudioToggleSci.ForeColor = Color.White;
            btnAudioToggleSci.Location = new Point(377, 267);
            btnAudioToggleSci.Margin = new Padding(3, 4, 3, 4);
            btnAudioToggleSci.Name = "btnAudioToggleSci";
            btnAudioToggleSci.Size = new Size(69, 48);
            btnAudioToggleSci.TabIndex = 125;
            btnAudioToggleSci.Text = "🔊";
            btnAudioToggleSci.UseVisualStyleBackColor = false;
            btnAudioToggleSci.Click += btnAudioToggle_Click;
            // 
            // tabHistory
            // 
            tabHistory.BackColor = Color.FromArgb(30, 30, 30);
            tabHistory.Controls.Add(lstHistory);
            tabHistory.Location = new Point(4, 34);
            tabHistory.Margin = new Padding(3, 4, 3, 4);
            tabHistory.Name = "tabHistory";
            tabHistory.Padding = new Padding(3, 4, 3, 4);
            tabHistory.Size = new Size(449, 602);
            tabHistory.TabIndex = 2;
            tabHistory.Text = "History";
            // 
            // lstHistory
            // 
            lstHistory.BackColor = Color.FromArgb(45, 45, 45);
            lstHistory.ForeColor = Color.White;
            lstHistory.Font = new Font("Microsoft Sans Serif", 9F);
            lstHistory.FormattingEnabled = true;
            lstHistory.ItemHeight = 18;
            lstHistory.Location = new Point(0, 0);
            lstHistory.Margin = new Padding(3, 4, 3, 4);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(447, 634);
            lstHistory.TabIndex = 49;
            lstHistory.DoubleClick += lstHistory_DoubleClick;
            lstHistory.KeyDown += lstHistory_KeyDown;
            // 
            // lblPreview
            // 
            lblPreview.Font = new Font("Segoe UI", 11F);
            lblPreview.ForeColor = Color.White;
            lblPreview.Location = new Point(14, 16);
            lblPreview.Name = "lblPreview";
            lblPreview.Size = new Size(395, 33);
            lblPreview.TabIndex = 16;
            lblPreview.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            lblID.Cursor = Cursors.Hand;
            lblID.Font = new Font("Segoe UI", 8F);
            lblID.ForeColor = Color.White;
            lblID.Location = new Point(14, 793);
            lblID.Name = "lblID";
            lblID.Size = new Size(343, 27);
            lblID.TabIndex = 54;
            lblID.Text = "Dubs Nicholas Francis RuiQiang | 241439P | E2";
            lblID.TextAlign = ContentAlignment.MiddleLeft;
            lblID.Click += lblID_Click;
            // 
            // btnSpeech
            // 
            btnSpeech.Font = new Font("Segoe UI", 9F);
            btnSpeech.Location = new Point(416, 53);
            btnSpeech.Margin = new Padding(3, 4, 3, 4);
            btnSpeech.Name = "btnSpeech";
            btnSpeech.Size = new Size(46, 67);
            btnSpeech.TabIndex = 53;
            btnSpeech.Text = "🗣";
            btnSpeech.UseVisualStyleBackColor = false;
            btnSpeech.Click += btnSpeech_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(475, 827);
            Controls.Add(tabModes);
            Controls.Add(lblPreview);
            Controls.Add(lblID);
            Controls.Add(btnSpeech);
            Controls.Add(txtResults);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "MainForm";
            Padding = new Padding(9, 11, 9, 11);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            TopMost = true;
            tabModes.ResumeLayout(false);
            tabStandard.ResumeLayout(false);
            tabScientific.ResumeLayout(false);
            tabHistory.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnCE;
        private System.Windows.Forms.Button btnBackspace;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnEqu;
        private System.Windows.Forms.Button btnNegate;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnFactorial;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Button btnLn;
        private System.Windows.Forms.Button btnSin;
        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.Button btnTan;
        private System.Windows.Forms.Button btnMPlus;
        private System.Windows.Forms.Button btnMMinus;
        private System.Windows.Forms.Button btnMR;
        private System.Windows.Forms.Button btnMC;
        private System.Windows.Forms.Button btnPi;
        private System.Windows.Forms.Button btnE;
        private System.Windows.Forms.Button btnPercent;
        private System.Windows.Forms.Button btnModulus;
        private System.Windows.Forms.Button btnDegreeRadian;
        private System.Windows.Forms.Button btnInverse;
        private System.Windows.Forms.Button btnReciprocal;
        private System.Windows.Forms.Button btnCubeRoot;
        private System.Windows.Forms.Button btnNthRoot;
        private System.Windows.Forms.Button btnSaveMemory;
        private System.Windows.Forms.Button btnRecallMemory;
        private System.Windows.Forms.Button btnUndo;
        private Calculator_Application.StyledTabControl tabModes;
        private System.Windows.Forms.TabPage tabStandard;
        private System.Windows.Forms.TabPage tabScientific;
        private System.Windows.Forms.TabPage tabHistory;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.ListBox lstHistory;
        private System.Windows.Forms.Button btnClearHistory;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnTheme;
        private System.Windows.Forms.Button btnAudioToggle;
        private System.Windows.Forms.Button btnSpeech;
        // Scientific mode duplicate buttons
        private System.Windows.Forms.Button btnBackspaceSci;
        private System.Windows.Forms.Button btnCESci;
        private System.Windows.Forms.Button btnCSci;
        private System.Windows.Forms.Button btnThemeSci;
        private System.Windows.Forms.Button btn7Sci;
        private System.Windows.Forms.Button btn8Sci;
        private System.Windows.Forms.Button btn9Sci;
        private System.Windows.Forms.Button btnDivideSci;
        private System.Windows.Forms.Button btnSqrtSci;
        private System.Windows.Forms.Button btn4Sci;
        private System.Windows.Forms.Button btn5Sci;
        private System.Windows.Forms.Button btn6Sci;
        private System.Windows.Forms.Button btnMultiplySci;
        private System.Windows.Forms.Button btnNegateSci;
        private System.Windows.Forms.Button btn1Sci;
        private System.Windows.Forms.Button btn2Sci;
        private System.Windows.Forms.Button btn3Sci;
        private System.Windows.Forms.Button btnSubtractSci;
        private System.Windows.Forms.Button btnAddSci;
        private System.Windows.Forms.Button btn0Sci;
        private System.Windows.Forms.Button btnDotSci;
        private System.Windows.Forms.Button btnEquSci;
        private System.Windows.Forms.Button btnCopySci;
        private System.Windows.Forms.Button btnReciprocalSci;
        private System.Windows.Forms.Button btnPercentSci;
        private System.Windows.Forms.Button btnModulusSci;
        private System.Windows.Forms.Button btnAudioToggleSci;
    }
}
