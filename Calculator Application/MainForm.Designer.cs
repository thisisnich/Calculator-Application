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
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnCE = new System.Windows.Forms.Button();
            this.btnBackspace = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnEqu = new System.Windows.Forms.Button();
            this.btnNegate = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnFactorial = new System.Windows.Forms.Button();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnLog = new System.Windows.Forms.Button();
            this.btnLn = new System.Windows.Forms.Button();
            this.btnSin = new System.Windows.Forms.Button();
            this.btnCos = new System.Windows.Forms.Button();
            this.btnTan = new System.Windows.Forms.Button();
            this.btnMPlus = new System.Windows.Forms.Button();
            this.btnMMinus = new System.Windows.Forms.Button();
            this.btnMR = new System.Windows.Forms.Button();
            this.btnMC = new System.Windows.Forms.Button();
            this.btnPi = new System.Windows.Forms.Button();
            this.btnE = new System.Windows.Forms.Button();
            this.btnPercent = new System.Windows.Forms.Button();
            this.btnDegreeRadian = new System.Windows.Forms.Button();
            this.btnInverse = new System.Windows.Forms.Button();
            this.btnReciprocal = new System.Windows.Forms.Button();
            this.btnCubeRoot = new System.Windows.Forms.Button();
            this.btnNthRoot = new System.Windows.Forms.Button();
            this.btnSaveMemory = new System.Windows.Forms.Button();
            this.btnRecallMemory = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.tabModes = new Calculator_Application.StyledTabControl();
            this.tabStandard = new System.Windows.Forms.TabPage();
            this.tabScientific = new System.Windows.Forms.TabPage();
            this.tabHistory = new System.Windows.Forms.TabPage();
            this.btnRedo = new System.Windows.Forms.Button();
            this.lblPreview = new System.Windows.Forms.Label();
            this.lstHistory = new System.Windows.Forms.ListBox();
            this.btnClearHistory = new System.Windows.Forms.Button();
            this.btnTheme = new System.Windows.Forms.Button();
            this.btnAudioToggle = new System.Windows.Forms.Button();
            // Scientific mode duplicate buttons
            this.btnBackspaceSci = new System.Windows.Forms.Button();
            this.btnCESci = new System.Windows.Forms.Button();
            this.btnCSci = new System.Windows.Forms.Button();
            this.btnThemeSci = new System.Windows.Forms.Button();
            this.btn7Sci = new System.Windows.Forms.Button();
            this.btn8Sci = new System.Windows.Forms.Button();
            this.btn9Sci = new System.Windows.Forms.Button();
            this.btnDivideSci = new System.Windows.Forms.Button();
            this.btnSqrtSci = new System.Windows.Forms.Button();
            this.btn4Sci = new System.Windows.Forms.Button();
            this.btn5Sci = new System.Windows.Forms.Button();
            this.btn6Sci = new System.Windows.Forms.Button();
            this.btnMultiplySci = new System.Windows.Forms.Button();
            this.btnNegateSci = new System.Windows.Forms.Button();
            this.btn1Sci = new System.Windows.Forms.Button();
            this.btn2Sci = new System.Windows.Forms.Button();
            this.btn3Sci = new System.Windows.Forms.Button();
            this.btnSubtractSci = new System.Windows.Forms.Button();
            this.btnAddSci = new System.Windows.Forms.Button();
            this.btn0Sci = new System.Windows.Forms.Button();
            this.btnDotSci = new System.Windows.Forms.Button();
            this.btnEquSci = new System.Windows.Forms.Button();
            this.btnCopySci = new System.Windows.Forms.Button();
            this.btnReciprocalSci = new System.Windows.Forms.Button();
            this.btnPercentSci = new System.Windows.Forms.Button();
            this.btnAudioToggleSci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabModes
            // 
            this.tabModes.Location = new System.Drawing.Point(12, 98);
            this.tabModes.Name = "tabModes";
            this.tabModes.Padding = new System.Drawing.Point(12, 4);
            this.tabModes.SelectedIndex = 0;
            // Fixed size - user controls window resizing manually
            this.tabModes.Size = new System.Drawing.Size(400, 480);
            this.tabModes.TabIndex = 51;
            this.tabModes.TabPages.Add(this.tabStandard);
            this.tabModes.TabPages.Add(this.tabScientific);
            this.tabModes.TabPages.Add(this.tabHistory);
            // 
            // tabStandard
            // 
            this.tabStandard.Location = new System.Drawing.Point(4, 24);
            this.tabStandard.Name = "tabStandard";
            this.tabStandard.Padding = new System.Windows.Forms.Padding(3);
            this.tabStandard.Size = new System.Drawing.Size(392, 300);
            this.tabStandard.TabIndex = 0;
            this.tabStandard.Text = "Standard";
            this.tabStandard.UseVisualStyleBackColor = false;
            this.tabStandard.BackColor = System.Drawing.SystemColors.Control;
            // 
            // tabScientific
            // 
            this.tabScientific.Location = new System.Drawing.Point(4, 24);
            this.tabScientific.Name = "tabScientific";
            this.tabScientific.Padding = new System.Windows.Forms.Padding(3);
            this.tabScientific.Size = new System.Drawing.Size(392, 480);
            this.tabScientific.TabIndex = 1;
            this.tabScientific.Text = "Scientific";
            this.tabScientific.UseVisualStyleBackColor = false;
            this.tabScientific.BackColor = System.Drawing.SystemColors.Control;
            // 
            // tabHistory
            // 
            this.tabHistory.Location = new System.Drawing.Point(4, 24);
            this.tabHistory.Name = "tabHistory";
            this.tabHistory.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistory.Size = new System.Drawing.Size(392, 480);
            this.tabHistory.TabIndex = 2;
            this.tabHistory.Text = "History";
            this.tabHistory.UseVisualStyleBackColor = false;
            this.tabHistory.BackColor = System.Drawing.SystemColors.Control;
            // 
            // lblPreview
            // 
            this.lblPreview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPreview.Location = new System.Drawing.Point(12, 12);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(346, 25);
            this.lblPreview.TabIndex = 16;
            this.lblPreview.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSquare.Location = new System.Drawing.Point(12, 98);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(60, 50);
            this.btnSquare.TabIndex = 23;
            this.btnSquare.Tag = "Square";
            this.btnSquare.Text = "x²";
            this.btnSquare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnSquare.ForeColor = System.Drawing.Color.White;
            this.btnSquare.UseVisualStyleBackColor = false;
            this.btnSquare.Click += new System.EventHandler(this.uOperator_Click);
            this.btnSquare.Location = new System.Drawing.Point(0, 0);
            this.btnSquare.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnSquare);
            // 
            // btnFactorial
            // 
            this.btnFactorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFactorial.Location = new System.Drawing.Point(78, 98);
            this.btnFactorial.Name = "btnFactorial";
            this.btnFactorial.Size = new System.Drawing.Size(60, 50);
            this.btnFactorial.TabIndex = 41;
            this.btnFactorial.Tag = "Factorial";
            this.btnFactorial.Text = "n!";
            this.btnFactorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnFactorial.ForeColor = System.Drawing.Color.White;
            this.btnFactorial.UseVisualStyleBackColor = false;
            this.btnFactorial.Click += new System.EventHandler(this.uOperator_Click);
            this.btnFactorial.Location = new System.Drawing.Point(66, 0);
            this.btnFactorial.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnFactorial);
            // 
            // btnPower
            // 
            this.btnPower.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPower.Location = new System.Drawing.Point(144, 98);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(60, 50);
            this.btnPower.TabIndex = 24;
            this.btnPower.Tag = "Power";
            this.btnPower.Text = "xʸ";
            this.btnPower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnPower.ForeColor = System.Drawing.Color.White;
            this.btnPower.UseVisualStyleBackColor = false;
            this.btnPower.Click += new System.EventHandler(this.uOperator_Click);
            this.btnPower.Location = new System.Drawing.Point(132, 0);
            this.btnPower.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnPower);
            // 
            // btnLog
            // 
            this.btnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLog.Location = new System.Drawing.Point(210, 98);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(60, 50);
            this.btnLog.TabIndex = 25;
            this.btnLog.Tag = "Log";
            this.btnLog.Text = "log";
            this.btnLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnLog.ForeColor = System.Drawing.Color.White;
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.uOperator_Click);
            this.btnLog.Location = new System.Drawing.Point(198, 0);
            this.btnLog.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnLog);
            // 
            // btnLn
            // 
            this.btnLn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLn.Location = new System.Drawing.Point(276, 98);
            this.btnLn.Name = "btnLn";
            this.btnLn.Size = new System.Drawing.Size(60, 50);
            this.btnLn.TabIndex = 26;
            this.btnLn.Tag = "Ln";
            this.btnLn.Text = "ln";
            this.btnLn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnLn.ForeColor = System.Drawing.Color.White;
            this.btnLn.UseVisualStyleBackColor = false;
            this.btnLn.Click += new System.EventHandler(this.uOperator_Click);
            this.btnLn.Location = new System.Drawing.Point(264, 0);
            this.btnLn.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnLn);
            // 
            // btnSin
            // 
            this.btnSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSin.Location = new System.Drawing.Point(342, 98);
            this.btnSin.Name = "btnSin";
            this.btnSin.Size = new System.Drawing.Size(60, 50);
            this.btnSin.TabIndex = 27;
            this.btnSin.Tag = "Sin";
            this.btnSin.Text = "sin";
            this.btnSin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnSin.ForeColor = System.Drawing.Color.White;
            this.btnSin.UseVisualStyleBackColor = false;
            this.btnSin.Click += new System.EventHandler(this.uOperator_Click);
            this.btnSin.Location = new System.Drawing.Point(320, 0);
            this.btnSin.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnSin);
            // 
            // btnCos
            // 
            this.btnCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCos.Location = new System.Drawing.Point(408, 98);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(60, 50);
            this.btnCos.TabIndex = 28;
            this.btnCos.Tag = "Cos";
            this.btnCos.Text = "cos";
            this.btnCos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnCos.ForeColor = System.Drawing.Color.White;
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.uOperator_Click);
            this.btnCos.Location = new System.Drawing.Point(0, 37);
            this.btnCos.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnCos);
            // 
            // btnTan
            // 
            this.btnTan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTan.Location = new System.Drawing.Point(474, 98);
            this.btnTan.Name = "btnTan";
            this.btnTan.Size = new System.Drawing.Size(60, 50);
            this.btnTan.TabIndex = 29;
            this.btnTan.Tag = "Tan";
            this.btnTan.Text = "tan";
            this.btnTan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnTan.ForeColor = System.Drawing.Color.White;
            this.btnTan.UseVisualStyleBackColor = false;
            this.btnTan.Click += new System.EventHandler(this.uOperator_Click);
            this.btnTan.Location = new System.Drawing.Point(66, 37);
            this.btnTan.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnTan);
            // 
            // btnMPlus
            // 
            this.btnMPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMPlus.Location = new System.Drawing.Point(480, 158);
            this.btnMPlus.Name = "btnMPlus";
            this.btnMPlus.Size = new System.Drawing.Size(60, 50);
            this.btnMPlus.TabIndex = 30;
            this.btnMPlus.Tag = "MPlus";
            this.btnMPlus.Text = "M+";
            this.btnMPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnMPlus.ForeColor = System.Drawing.Color.White;
            this.btnMPlus.UseVisualStyleBackColor = false;
            this.btnMPlus.Click += new System.EventHandler(this.memoryButton_Click);
            this.btnMPlus.Location = new System.Drawing.Point(0, 74);
            this.btnMPlus.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnMPlus);
            // 
            // btnMMinus
            // 
            this.btnMMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMMinus.Location = new System.Drawing.Point(480, 213);
            this.btnMMinus.Name = "btnMMinus";
            this.btnMMinus.Size = new System.Drawing.Size(60, 50);
            this.btnMMinus.TabIndex = 31;
            this.btnMMinus.Tag = "MMinus";
            this.btnMMinus.Text = "M−";
            this.btnMMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnMMinus.ForeColor = System.Drawing.Color.White;
            this.btnMMinus.UseVisualStyleBackColor = false;
            this.btnMMinus.Click += new System.EventHandler(this.memoryButton_Click);
            this.btnMMinus.Location = new System.Drawing.Point(66, 74);
            this.btnMMinus.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnMMinus);
            // 
            // btnMR
            // 
            this.btnMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMR.Location = new System.Drawing.Point(480, 268);
            this.btnMR.Name = "btnMR";
            this.btnMR.Size = new System.Drawing.Size(60, 50);
            this.btnMR.TabIndex = 32;
            this.btnMR.Tag = "MR";
            this.btnMR.Text = "MR";
            this.btnMR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnMR.ForeColor = System.Drawing.Color.White;
            this.btnMR.UseVisualStyleBackColor = false;
            this.btnMR.Click += new System.EventHandler(this.memoryButton_Click);
            this.btnMR.Location = new System.Drawing.Point(132, 74);
            this.btnMR.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnMR);
            // 
            // btnMC
            // 
            this.btnMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMC.Location = new System.Drawing.Point(480, 323);
            this.btnMC.Name = "btnMC";
            this.btnMC.Size = new System.Drawing.Size(60, 50);
            this.btnMC.TabIndex = 33;
            this.btnMC.Tag = "MC";
            this.btnMC.Text = "MC";
            this.btnMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnMC.ForeColor = System.Drawing.Color.White;
            this.btnMC.UseVisualStyleBackColor = false;
            this.btnMC.Click += new System.EventHandler(this.memoryButton_Click);
            this.btnMC.Location = new System.Drawing.Point(198, 74);
            this.btnMC.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnMC);
            // 
            // btnPi
            // 
            this.btnPi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPi.Location = new System.Drawing.Point(480, 378);
            this.btnPi.Name = "btnPi";
            this.btnPi.Size = new System.Drawing.Size(60, 50);
            this.btnPi.TabIndex = 34;
            this.btnPi.Tag = "Pi";
            this.btnPi.Text = "π";
            this.btnPi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnPi.ForeColor = System.Drawing.Color.White;
            this.btnPi.UseVisualStyleBackColor = false;
            this.btnPi.Click += new System.EventHandler(this.constantButton_Click);
            this.btnPi.Location = new System.Drawing.Point(0, 111);
            this.btnPi.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnPi);
            // 
            // btnE
            // 
            this.btnE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnE.Location = new System.Drawing.Point(480, 433);
            this.btnE.Name = "btnE";
            this.btnE.Size = new System.Drawing.Size(60, 50);
            this.btnE.TabIndex = 35;
            this.btnE.Tag = "E";
            this.btnE.Text = "e";
            this.btnE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnE.ForeColor = System.Drawing.Color.White;
            this.btnE.UseVisualStyleBackColor = false;
            this.btnE.Click += new System.EventHandler(this.constantButton_Click);
            this.btnE.Location = new System.Drawing.Point(66, 111);
            this.btnE.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnE);
            // 
            // btnPercent
            // 
            this.btnPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPercent.Location = new System.Drawing.Point(324, 383);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(72, 48);
            this.btnPercent.TabIndex = 36;
            this.btnPercent.Text = "%";
            this.btnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnPercent.ForeColor = System.Drawing.Color.White;
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.btnPercent_Click);
            // btnPercent in Standard mode
            this.btnPercent.Location = new System.Drawing.Point(320, 112);
            this.tabStandard.Controls.Add(this.btnPercent);
            // 
            // btnDegreeRadian
            // 
            this.btnDegreeRadian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDegreeRadian.Location = new System.Drawing.Point(168, 433);
            this.btnDegreeRadian.Name = "btnDegreeRadian";
            this.btnDegreeRadian.Size = new System.Drawing.Size(60, 50);
            this.btnDegreeRadian.TabIndex = 39;
            this.btnDegreeRadian.Text = "RAD";
            this.btnDegreeRadian.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDegreeRadian.ForeColor = System.Drawing.Color.White;
            this.btnDegreeRadian.UseVisualStyleBackColor = false;
            this.btnDegreeRadian.Click += new System.EventHandler(this.btnDegreeRadian_Click);
            this.btnDegreeRadian.Location = new System.Drawing.Point(132, 37);
            this.btnDegreeRadian.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnDegreeRadian);
            // 
            // btnInverse
            // 
            this.btnInverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInverse.Location = new System.Drawing.Point(246, 433);
            this.btnInverse.Name = "btnInverse";
            this.btnInverse.Size = new System.Drawing.Size(60, 50);
            this.btnInverse.TabIndex = 40;
            this.btnInverse.Text = "Inv";
            this.btnInverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnInverse.ForeColor = System.Drawing.Color.White;
            this.btnInverse.UseVisualStyleBackColor = false;
            this.btnInverse.Click += new System.EventHandler(this.btnInverse_Click);
            this.btnInverse.Location = new System.Drawing.Point(198, 37);
            this.btnInverse.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnInverse);
            // 
            // btnReciprocal
            // 
            this.btnReciprocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // btnReciprocal in Scientific mode (row 3, col 0)
            // Note: btnReciprocal is in tabStandard, will be handled by runtime code for Scientific mode
            // For now, keep it in tabStandard only
            this.btnReciprocal.Name = "btnReciprocal";
            this.btnReciprocal.Size = new System.Drawing.Size(72, 48);
            this.btnReciprocal.TabIndex = 42;
            this.btnReciprocal.Text = "1/x";
            this.btnReciprocal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnReciprocal.ForeColor = System.Drawing.Color.White;
            this.btnReciprocal.UseVisualStyleBackColor = false;
            this.btnReciprocal.Click += new System.EventHandler(this.btnReciprocal_Click);
            this.tabStandard.Controls.Add(this.btnReciprocal);
            // 
            // btnCubeRoot
            // 
            this.btnCubeRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCubeRoot.Location = new System.Drawing.Point(90, 433);
            this.btnCubeRoot.Name = "btnCubeRoot";
            this.btnCubeRoot.Size = new System.Drawing.Size(60, 50);
            this.btnCubeRoot.TabIndex = 43;
            this.btnCubeRoot.Text = "∛";
            this.btnCubeRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnCubeRoot.ForeColor = System.Drawing.Color.White;
            this.btnCubeRoot.UseVisualStyleBackColor = false;
            this.btnCubeRoot.Click += new System.EventHandler(this.btnCubeRoot_Click);
            this.btnCubeRoot.Location = new System.Drawing.Point(264, 37);
            this.btnCubeRoot.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnCubeRoot);
            // 
            // btnNthRoot
            // 
            this.btnNthRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNthRoot.Location = new System.Drawing.Point(246, 433);
            this.btnNthRoot.Name = "btnNthRoot";
            this.btnNthRoot.Size = new System.Drawing.Size(60, 50);
            this.btnNthRoot.TabIndex = 44;
            this.btnNthRoot.Text = "ⁿ√";
            this.btnNthRoot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnNthRoot.ForeColor = System.Drawing.Color.White;
            this.btnNthRoot.UseVisualStyleBackColor = false;
            this.btnNthRoot.Click += new System.EventHandler(this.btnNthRoot_Click);
            this.btnNthRoot.Location = new System.Drawing.Point(320, 37);
            this.btnNthRoot.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnNthRoot);
            // 
            // btnSaveMemory
            // 
            this.btnSaveMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSaveMemory.Location = new System.Drawing.Point(324, 433);
            this.btnSaveMemory.Name = "btnSaveMemory";
            this.btnSaveMemory.Size = new System.Drawing.Size(60, 50);
            this.btnSaveMemory.TabIndex = 45;
            this.btnSaveMemory.Text = "Save";
            this.btnSaveMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnSaveMemory.ForeColor = System.Drawing.Color.White;
            this.btnSaveMemory.UseVisualStyleBackColor = false;
            this.btnSaveMemory.Click += new System.EventHandler(this.btnSaveMemory_Click);
            this.btnSaveMemory.Location = new System.Drawing.Point(264, 74);
            this.btnSaveMemory.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnSaveMemory);
            // 
            // btnRecallMemory
            // 
            this.btnRecallMemory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRecallMemory.Location = new System.Drawing.Point(402, 433);
            this.btnRecallMemory.Name = "btnRecallMemory";
            this.btnRecallMemory.Size = new System.Drawing.Size(60, 50);
            this.btnRecallMemory.TabIndex = 46;
            this.btnRecallMemory.Text = "Recall";
            this.btnRecallMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnRecallMemory.ForeColor = System.Drawing.Color.White;
            this.btnRecallMemory.UseVisualStyleBackColor = false;
            this.btnRecallMemory.Click += new System.EventHandler(this.btnRecallMemory_Click);
            this.btnRecallMemory.Location = new System.Drawing.Point(320, 74);
            this.btnRecallMemory.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnRecallMemory);
            // 
            // btnUndo
            // 
            this.btnUndo.Enabled = false;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUndo.Location = new System.Drawing.Point(12, 490);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(80, 35);
            this.btnUndo.TabIndex = 47;
            this.btnUndo.Text = "Undo";
            this.btnUndo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnUndo.ForeColor = System.Drawing.Color.White;
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            this.btnUndo.Location = new System.Drawing.Point(192, 148);
            this.btnUndo.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnUndo);
            // 
            // btnRedo
            // 
            this.btnRedo.Enabled = false;
            this.btnRedo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRedo.Location = new System.Drawing.Point(98, 490);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(80, 35);
            this.btnRedo.TabIndex = 48;
            this.btnRedo.Text = "Redo";
            this.btnRedo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnRedo.ForeColor = System.Drawing.Color.White;
            this.btnRedo.UseVisualStyleBackColor = false;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            this.btnRedo.Location = new System.Drawing.Point(256, 148);
            this.btnRedo.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnRedo);
            // 
            // lstHistory
            // 
            this.lstHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstHistory.FormattingEnabled = true;
            this.lstHistory.ItemHeight = 15;
            // Position history list in History tab
            this.lstHistory.Location = new System.Drawing.Point(0, 0);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(392, 480);
            this.lstHistory.TabIndex = 49;
            this.lstHistory.DoubleClick += new System.EventHandler(this.lstHistory_DoubleClick);
            this.lstHistory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstHistory_KeyDown);
            // 
            // btnClearHistory
            // 
            this.btnClearHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClearHistory.Location = new System.Drawing.Point(402, 383);
            this.btnClearHistory.Name = "btnClearHistory";
            this.btnClearHistory.Size = new System.Drawing.Size(60, 60);
            this.btnClearHistory.TabIndex = 38;
            this.btnClearHistory.Text = "Clear\nHistory";
            this.btnClearHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnClearHistory.ForeColor = System.Drawing.Color.White;
            this.btnClearHistory.UseVisualStyleBackColor = false;
            this.btnClearHistory.Click += new System.EventHandler(this.btnClearHistory_Click);
            this.btnClearHistory.Location = new System.Drawing.Point(256, 111);
            this.btnClearHistory.Size = new System.Drawing.Size(60, 36);
            this.tabScientific.Controls.Add(this.btnClearHistory);
            // 
            // Scientific mode duplicate buttons
            // 
            // btnBackspaceSci (row 6, col 0)
            this.btnBackspaceSci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackspaceSci.Location = new System.Drawing.Point(0, 148);
            this.btnBackspaceSci.Name = "btnBackspaceSci";
            this.btnBackspaceSci.Size = new System.Drawing.Size(60, 36);
            this.btnBackspaceSci.TabIndex = 100;
            this.btnBackspaceSci.Text = "⌫";
            this.btnBackspaceSci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(64)))));
            this.btnBackspaceSci.ForeColor = System.Drawing.Color.White;
            this.btnBackspaceSci.UseVisualStyleBackColor = false;
            this.btnBackspaceSci.Click += new System.EventHandler(this.btnBackspace_Click);
            this.tabScientific.Controls.Add(this.btnBackspaceSci);
            // 
            // btnCESci (row 6, col 1)
            this.btnCESci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCESci.Location = new System.Drawing.Point(66, 148);
            this.btnCESci.Name = "btnCESci";
            this.btnCESci.Size = new System.Drawing.Size(60, 38);
            this.btnCESci.TabIndex = 101;
            this.btnCESci.Text = "CE";
            this.btnCESci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(64)))));
            this.btnCESci.ForeColor = System.Drawing.Color.White;
            this.btnCESci.UseVisualStyleBackColor = false;
            this.btnCESci.Click += new System.EventHandler(this.btnCE_Click);
            this.tabScientific.Controls.Add(this.btnCESci);
            // 
            // btnCSci (row 6, col 2)
            this.btnCSci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCSci.Location = new System.Drawing.Point(132, 148);
            this.btnCSci.Name = "btnCSci";
            this.btnCSci.Size = new System.Drawing.Size(60, 38);
            this.btnCSci.TabIndex = 102;
            this.btnCSci.Text = "C";
            this.btnCSci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(64)))));
            this.btnCSci.ForeColor = System.Drawing.Color.White;
            this.btnCSci.UseVisualStyleBackColor = false;
            this.btnCSci.Click += new System.EventHandler(this.btnC_Click);
            this.tabScientific.Controls.Add(this.btnCSci);
            // 
            // btn7Sci (row 7, col 0)
            this.btn7Sci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7Sci.Location = new System.Drawing.Point(0, 185);
            this.btn7Sci.Name = "btn7Sci";
            this.btn7Sci.Size = new System.Drawing.Size(60, 38);
            this.btn7Sci.TabIndex = 103;
            this.btn7Sci.Text = "7";
            this.btn7Sci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn7Sci.UseVisualStyleBackColor = false;
            this.btn7Sci.Click += new System.EventHandler(this.numPad_Click);
            this.tabScientific.Controls.Add(this.btn7Sci);
            // 
            // btn8Sci (row 7, col 1)
            this.btn8Sci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8Sci.Location = new System.Drawing.Point(66, 185);
            this.btn8Sci.Name = "btn8Sci";
            this.btn8Sci.Size = new System.Drawing.Size(60, 38);
            this.btn8Sci.TabIndex = 104;
            this.btn8Sci.Text = "8";
            this.btn8Sci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn8Sci.UseVisualStyleBackColor = false;
            this.btn8Sci.Click += new System.EventHandler(this.numPad_Click);
            this.tabScientific.Controls.Add(this.btn8Sci);
            // 
            // btn9Sci (row 7, col 2)
            this.btn9Sci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9Sci.Location = new System.Drawing.Point(132, 185);
            this.btn9Sci.Name = "btn9Sci";
            this.btn9Sci.Size = new System.Drawing.Size(60, 38);
            this.btn9Sci.TabIndex = 105;
            this.btn9Sci.Text = "9";
            this.btn9Sci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn9Sci.UseVisualStyleBackColor = false;
            this.btn9Sci.Click += new System.EventHandler(this.numPad_Click);
            this.tabScientific.Controls.Add(this.btn9Sci);
            // 
            // btnDivideSci (row 7, col 3)
            this.btnDivideSci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivideSci.Location = new System.Drawing.Point(198, 185);
            this.btnDivideSci.Name = "btnDivideSci";
            this.btnDivideSci.Size = new System.Drawing.Size(60, 38);
            this.btnDivideSci.TabIndex = 106;
            this.btnDivideSci.Tag = "Divide";
            this.btnDivideSci.Text = "÷";
            this.btnDivideSci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDivideSci.ForeColor = System.Drawing.Color.White;
            this.btnDivideSci.UseVisualStyleBackColor = false;
            this.btnDivideSci.Click += new System.EventHandler(this.operator_Click);
            this.tabScientific.Controls.Add(this.btnDivideSci);
            // 
            // btnSqrtSci (row 7, col 4)
            this.btnSqrtSci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSqrtSci.Location = new System.Drawing.Point(264, 185);
            this.btnSqrtSci.Name = "btnSqrtSci";
            this.btnSqrtSci.Size = new System.Drawing.Size(60, 38);
            this.btnSqrtSci.TabIndex = 107;
            this.btnSqrtSci.Tag = "Sqrt";
            this.btnSqrtSci.Text = "√";
            this.btnSqrtSci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSqrtSci.ForeColor = System.Drawing.Color.White;
            this.btnSqrtSci.UseVisualStyleBackColor = false;
            this.btnSqrtSci.Click += new System.EventHandler(this.uOperator_Click);
            this.tabScientific.Controls.Add(this.btnSqrtSci);
            // 
            // btn4Sci (row 8, col 0)
            this.btn4Sci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4Sci.Location = new System.Drawing.Point(0, 222);
            this.btn4Sci.Name = "btn4Sci";
            this.btn4Sci.Size = new System.Drawing.Size(60, 38);
            this.btn4Sci.TabIndex = 108;
            this.btn4Sci.Text = "4";
            this.btn4Sci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn4Sci.UseVisualStyleBackColor = false;
            this.btn4Sci.Click += new System.EventHandler(this.numPad_Click);
            this.tabScientific.Controls.Add(this.btn4Sci);
            // 
            // btn5Sci (row 8, col 1)
            this.btn5Sci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5Sci.Location = new System.Drawing.Point(66, 222);
            this.btn5Sci.Name = "btn5Sci";
            this.btn5Sci.Size = new System.Drawing.Size(60, 38);
            this.btn5Sci.TabIndex = 109;
            this.btn5Sci.Text = "5";
            this.btn5Sci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn5Sci.UseVisualStyleBackColor = false;
            this.btn5Sci.Click += new System.EventHandler(this.numPad_Click);
            this.tabScientific.Controls.Add(this.btn5Sci);
            // 
            // btn6Sci (row 8, col 2)
            this.btn6Sci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6Sci.Location = new System.Drawing.Point(132, 222);
            this.btn6Sci.Name = "btn6Sci";
            this.btn6Sci.Size = new System.Drawing.Size(60, 38);
            this.btn6Sci.TabIndex = 110;
            this.btn6Sci.Text = "6";
            this.btn6Sci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn6Sci.UseVisualStyleBackColor = false;
            this.btn6Sci.Click += new System.EventHandler(this.numPad_Click);
            this.tabScientific.Controls.Add(this.btn6Sci);
            // 
            // btnMultiplySci (row 8, col 3)
            this.btnMultiplySci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplySci.Location = new System.Drawing.Point(198, 222);
            this.btnMultiplySci.Name = "btnMultiplySci";
            this.btnMultiplySci.Size = new System.Drawing.Size(60, 38);
            this.btnMultiplySci.TabIndex = 111;
            this.btnMultiplySci.Tag = "Multiply";
            this.btnMultiplySci.Text = "×";
            this.btnMultiplySci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnMultiplySci.ForeColor = System.Drawing.Color.White;
            this.btnMultiplySci.UseVisualStyleBackColor = false;
            this.btnMultiplySci.Click += new System.EventHandler(this.operator_Click);
            this.tabScientific.Controls.Add(this.btnMultiplySci);
            // 
            // btnNegateSci (row 8, col 4)
            this.btnNegateSci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNegateSci.Location = new System.Drawing.Point(264, 222);
            this.btnNegateSci.Name = "btnNegateSci";
            this.btnNegateSci.Size = new System.Drawing.Size(60, 38);
            this.btnNegateSci.TabIndex = 112;
            this.btnNegateSci.Text = "±";
            this.btnNegateSci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnNegateSci.ForeColor = System.Drawing.Color.White;
            this.btnNegateSci.UseVisualStyleBackColor = false;
            this.btnNegateSci.Click += new System.EventHandler(this.btnNegate_Click);
            this.tabScientific.Controls.Add(this.btnNegateSci);
            // 
            // btn1Sci (row 9, col 0)
            this.btn1Sci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1Sci.Location = new System.Drawing.Point(0, 259);
            this.btn1Sci.Name = "btn1Sci";
            this.btn1Sci.Size = new System.Drawing.Size(60, 38);
            this.btn1Sci.TabIndex = 113;
            this.btn1Sci.Text = "1";
            this.btn1Sci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn1Sci.UseVisualStyleBackColor = false;
            this.btn1Sci.Click += new System.EventHandler(this.numPad_Click);
            this.tabScientific.Controls.Add(this.btn1Sci);
            // 
            // btn2Sci (row 9, col 1)
            this.btn2Sci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2Sci.Location = new System.Drawing.Point(66, 259);
            this.btn2Sci.Name = "btn2Sci";
            this.btn2Sci.Size = new System.Drawing.Size(60, 38);
            this.btn2Sci.TabIndex = 114;
            this.btn2Sci.Text = "2";
            this.btn2Sci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn2Sci.UseVisualStyleBackColor = false;
            this.btn2Sci.Click += new System.EventHandler(this.numPad_Click);
            this.tabScientific.Controls.Add(this.btn2Sci);
            // 
            // btn3Sci (row 9, col 2)
            this.btn3Sci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3Sci.Location = new System.Drawing.Point(132, 259);
            this.btn3Sci.Name = "btn3Sci";
            this.btn3Sci.Size = new System.Drawing.Size(60, 38);
            this.btn3Sci.TabIndex = 115;
            this.btn3Sci.Text = "3";
            this.btn3Sci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn3Sci.UseVisualStyleBackColor = false;
            this.btn3Sci.Click += new System.EventHandler(this.numPad_Click);
            this.tabScientific.Controls.Add(this.btn3Sci);
            // 
            // btnSubtractSci (row 9, col 3)
            this.btnSubtractSci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubtractSci.Location = new System.Drawing.Point(198, 259);
            this.btnSubtractSci.Name = "btnSubtractSci";
            this.btnSubtractSci.Size = new System.Drawing.Size(60, 38);
            this.btnSubtractSci.TabIndex = 116;
            this.btnSubtractSci.Tag = "Subtract";
            this.btnSubtractSci.Text = "−";
            this.btnSubtractSci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSubtractSci.ForeColor = System.Drawing.Color.White;
            this.btnSubtractSci.UseVisualStyleBackColor = false;
            this.btnSubtractSci.Click += new System.EventHandler(this.operator_Click);
            this.tabScientific.Controls.Add(this.btnSubtractSci);
            // 
            // btnAddSci (row 9, col 4)
            this.btnAddSci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddSci.Location = new System.Drawing.Point(264, 259);
            this.btnAddSci.Name = "btnAddSci";
            this.btnAddSci.Size = new System.Drawing.Size(60, 38);
            this.btnAddSci.TabIndex = 117;
            this.btnAddSci.Tag = "Add";
            this.btnAddSci.Text = "+";
            this.btnAddSci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAddSci.ForeColor = System.Drawing.Color.White;
            this.btnAddSci.UseVisualStyleBackColor = false;
            this.btnAddSci.Click += new System.EventHandler(this.operator_Click);
            this.tabScientific.Controls.Add(this.btnAddSci);
            // 
            // btn0Sci (row 10, col 0)
            this.btn0Sci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0Sci.Location = new System.Drawing.Point(0, 296);
            this.btn0Sci.Name = "btn0Sci";
            this.btn0Sci.Size = new System.Drawing.Size(60, 38);
            this.btn0Sci.TabIndex = 118;
            this.btn0Sci.Text = "0";
            this.btn0Sci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn0Sci.UseVisualStyleBackColor = false;
            this.btn0Sci.Click += new System.EventHandler(this.numPad_Click);
            this.tabScientific.Controls.Add(this.btn0Sci);
            // 
            // btnDotSci (row 10, col 1)
            this.btnDotSci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDotSci.Location = new System.Drawing.Point(66, 296);
            this.btnDotSci.Name = "btnDotSci";
            this.btnDotSci.Size = new System.Drawing.Size(60, 38);
            this.btnDotSci.TabIndex = 119;
            this.btnDotSci.Text = ".";
            this.btnDotSci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDotSci.UseVisualStyleBackColor = false;
            this.btnDotSci.Click += new System.EventHandler(this.numPad_Click);
            this.tabScientific.Controls.Add(this.btnDotSci);
            // 
            // btnEquSci (row 10, col 3)
            this.btnEquSci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEquSci.Location = new System.Drawing.Point(198, 296);
            this.btnEquSci.Name = "btnEquSci";
            this.btnEquSci.Size = new System.Drawing.Size(60, 38);
            this.btnEquSci.TabIndex = 120;
            this.btnEquSci.Tag = "Equ";
            this.btnEquSci.Text = "=";
            this.btnEquSci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnEquSci.ForeColor = System.Drawing.Color.White;
            this.btnEquSci.UseVisualStyleBackColor = false;
            this.btnEquSci.Click += new System.EventHandler(this.btnEqu_Click);
            this.tabScientific.Controls.Add(this.btnEquSci);
            // 
            // btnCopySci (row 5, col 4)
            this.btnCopySci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCopySci.Location = new System.Drawing.Point(320, 111);
            this.btnCopySci.Name = "btnCopySci";
            this.btnCopySci.Size = new System.Drawing.Size(60, 38);
            this.btnCopySci.TabIndex = 121;
            this.btnCopySci.Text = "Copy";
            this.btnCopySci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCopySci.ForeColor = System.Drawing.Color.White;
            this.btnCopySci.UseVisualStyleBackColor = false;
            this.btnCopySci.Click += new System.EventHandler(this.btnCopy_Click);
            this.tabScientific.Controls.Add(this.btnCopySci);
            // 
            // btnReciprocalSci (row 3, col 0)
            this.btnReciprocalSci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReciprocalSci.Location = new System.Drawing.Point(132, 111);
            this.btnReciprocalSci.Name = "btnReciprocalSci";
            this.btnReciprocalSci.Size = new System.Drawing.Size(60, 38);
            this.btnReciprocalSci.TabIndex = 122;
            this.btnReciprocalSci.Text = "1/x";
            this.btnReciprocalSci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(136)))), ((int)(((byte)(255)))));
            this.btnReciprocalSci.ForeColor = System.Drawing.Color.White;
            this.btnReciprocalSci.UseVisualStyleBackColor = false;
            this.btnReciprocalSci.Click += new System.EventHandler(this.btnReciprocal_Click);
            this.tabScientific.Controls.Add(this.btnReciprocalSci);
            // 
            // btnPercentSci (row 3, col 3)
            this.btnPercentSci.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPercentSci.Location = new System.Drawing.Point(198, 111);
            this.btnPercentSci.Name = "btnPercentSci";
            this.btnPercentSci.Size = new System.Drawing.Size(60, 38);
            this.btnPercentSci.TabIndex = 123;
            this.btnPercentSci.Text = "%";
            this.btnPercentSci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnPercentSci.ForeColor = System.Drawing.Color.White;
            this.btnPercentSci.UseVisualStyleBackColor = false;
            this.btnPercentSci.Click += new System.EventHandler(this.btnPercent_Click);
            this.tabScientific.Controls.Add(this.btnPercentSci);
            // 
            // btnThemeSci (row 4, col 4)
            this.btnThemeSci.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThemeSci.Location = new System.Drawing.Point(320, 148);
            this.btnThemeSci.Name = "btnThemeSci";
            this.btnThemeSci.Size = new System.Drawing.Size(60, 38);
            this.btnThemeSci.TabIndex = 124;
            this.btnThemeSci.Text = "Theme";
            this.btnThemeSci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnThemeSci.ForeColor = System.Drawing.Color.White;
            this.btnThemeSci.UseVisualStyleBackColor = false;
            this.btnThemeSci.Click += new System.EventHandler(this.btnTheme_Click);
            this.tabScientific.Controls.Add(this.btnThemeSci);
            // 
            // btnAudioToggleSci (row 4, col 4)
            this.btnAudioToggleSci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAudioToggleSci.Location = new System.Drawing.Point(320, 185);
            this.btnAudioToggleSci.Name = "btnAudioToggleSci";
            this.btnAudioToggleSci.Size = new System.Drawing.Size(60, 38);
            this.btnAudioToggleSci.TabIndex = 125;
            this.btnAudioToggleSci.Text = "🔊";
            this.btnAudioToggleSci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAudioToggleSci.ForeColor = System.Drawing.Color.White;
            this.btnAudioToggleSci.UseVisualStyleBackColor = false;
            this.btnAudioToggleSci.Click += new System.EventHandler(this.btnAudioToggle_Click);
            this.tabScientific.Controls.Add(this.btnAudioToggleSci);
            // 
            // txtResults
            // 
            this.txtResults.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResults.Location = new System.Drawing.Point(12, 40);
            this.txtResults.Name = "txtResults";
            this.txtResults.ReadOnly = true;
            this.txtResults.Size = new System.Drawing.Size(346, 50);
            this.txtResults.BackColor = System.Drawing.Color.White;
            this.txtResults.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResults.TabIndex = 0;
            this.txtResults.Text = "0";
            this.txtResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn1.Location = new System.Drawing.Point(0, 168);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(72, 48);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.numPad_Click);
            // btn1 in Standard mode
            this.btn1.Location = new System.Drawing.Point(0, 168);
            this.tabStandard.Controls.Add(this.btn1);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn2.Location = new System.Drawing.Point(80, 168);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(72, 48);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.numPad_Click);
            // btn2 in Standard mode
            this.btn2.Location = new System.Drawing.Point(80, 168);
            this.tabStandard.Controls.Add(this.btn2);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn3.Location = new System.Drawing.Point(160, 168);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(72, 48);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.numPad_Click);
            // btn3 in Standard mode
            this.btn3.Location = new System.Drawing.Point(160, 168);
            this.tabStandard.Controls.Add(this.btn3);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn4.Location = new System.Drawing.Point(0, 112);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(72, 48);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.numPad_Click);
            // btn4 in Standard mode
            this.btn4.Location = new System.Drawing.Point(0, 112);
            this.tabStandard.Controls.Add(this.btn4);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn5.Location = new System.Drawing.Point(80, 112);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(72, 48);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.numPad_Click);
            // btn5 in Standard mode
            this.btn5.Location = new System.Drawing.Point(80, 112);
            this.tabStandard.Controls.Add(this.btn5);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn6.Location = new System.Drawing.Point(160, 112);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(72, 48);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.numPad_Click);
            // btn6 in Standard mode
            this.btn6.Location = new System.Drawing.Point(160, 112);
            this.tabStandard.Controls.Add(this.btn6);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn7.Location = new System.Drawing.Point(0, 56);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(72, 48);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.numPad_Click);
            // btn7 in Standard mode
            this.btn7.Location = new System.Drawing.Point(0, 56);
            this.tabStandard.Controls.Add(this.btn7);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn8.Location = new System.Drawing.Point(80, 56);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(72, 48);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.numPad_Click);
            // btn8 in Standard mode
            this.btn8.Location = new System.Drawing.Point(80, 56);
            this.tabStandard.Controls.Add(this.btn8);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn9.Location = new System.Drawing.Point(160, 56);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(72, 48);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.numPad_Click);
            // btn9 in Standard mode
            this.btn9.Location = new System.Drawing.Point(160, 56);
            this.tabStandard.Controls.Add(this.btn9);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn0.Location = new System.Drawing.Point(0, 224);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(72, 48);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.numPad_Click);
            // btn0 in Standard mode
            this.btn0.Location = new System.Drawing.Point(0, 224);
            this.tabStandard.Controls.Add(this.btn0);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDot.Location = new System.Drawing.Point(80, 224);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(72, 48);
            this.btnDot.TabIndex = 11;
            this.btnDot.Text = ".";
            this.btnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.numPad_Click);
            // btnDot in Standard mode
            this.btnDot.Location = new System.Drawing.Point(80, 224);
            this.tabStandard.Controls.Add(this.btnDot);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnC.Location = new System.Drawing.Point(160, 0);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(72, 48);
            this.btnC.TabIndex = 12;
            this.btnC.Text = "C";
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(64)))));
            this.btnC.ForeColor = System.Drawing.Color.White;
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // btnC in Standard mode
            this.btnC.Location = new System.Drawing.Point(160, 0);
            this.tabStandard.Controls.Add(this.btnC);
            // 
            // btnCE
            // 
            this.btnCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCE.Location = new System.Drawing.Point(80, 0);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(72, 48);
            this.btnCE.TabIndex = 13;
            this.btnCE.Text = "CE";
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(64)))));
            this.btnCE.ForeColor = System.Drawing.Color.White;
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // btnCE in Standard mode
            this.btnCE.Location = new System.Drawing.Point(80, 0);
            this.tabStandard.Controls.Add(this.btnCE);
            // 
            // btnBackspace
            // 
            this.btnBackspace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBackspace.Location = new System.Drawing.Point(0, 0);
            this.btnBackspace.Name = "btnBackspace";
            this.btnBackspace.Size = new System.Drawing.Size(72, 48);
            this.btnBackspace.TabIndex = 14;
            this.btnBackspace.Text = "⌫";
            this.btnBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(159)))), ((int)(((byte)(64)))));
            this.btnBackspace.ForeColor = System.Drawing.Color.White;
            this.btnBackspace.UseVisualStyleBackColor = false;
            this.btnBackspace.Click += new System.EventHandler(this.btnBackspace_Click);
            // btnBackspace in Standard mode
            this.btnBackspace.Location = new System.Drawing.Point(0, 0);
            this.tabStandard.Controls.Add(this.btnBackspace);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(240, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 48);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Tag = "Add";
            this.btnAdd.Text = "+";
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.operator_Click);
            // btnAdd in Standard mode
            this.btnAdd.Location = new System.Drawing.Point(240, 224);
            this.tabStandard.Controls.Add(this.btnAdd);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubtract.Location = new System.Drawing.Point(240, 168);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(72, 48);
            this.btnSubtract.TabIndex = 20;
            this.btnSubtract.Tag = "Subtract";
            this.btnSubtract.Text = "−";
            this.btnSubtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSubtract.ForeColor = System.Drawing.Color.White;
            this.btnSubtract.UseVisualStyleBackColor = false;
            this.btnSubtract.Click += new System.EventHandler(this.operator_Click);
            // btnSubtract in Standard mode
            this.btnSubtract.Location = new System.Drawing.Point(240, 168);
            this.tabStandard.Controls.Add(this.btnSubtract);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiply.Location = new System.Drawing.Point(240, 112);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(72, 48);
            this.btnMultiply.TabIndex = 21;
            this.btnMultiply.Tag = "Multiply";
            this.btnMultiply.Text = "×";
            this.btnMultiply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnMultiply.ForeColor = System.Drawing.Color.White;
            this.btnMultiply.UseVisualStyleBackColor = false;
            this.btnMultiply.Click += new System.EventHandler(this.operator_Click);
            // btnMultiply in Standard mode
            this.btnMultiply.Location = new System.Drawing.Point(240, 112);
            this.tabStandard.Controls.Add(this.btnMultiply);
            // 
            // btnDivide
            // 
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDivide.Location = new System.Drawing.Point(240, 56);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(72, 48);
            this.btnDivide.TabIndex = 22;
            this.btnDivide.Tag = "Divide";
            this.btnDivide.Text = "÷";
            this.btnDivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDivide.ForeColor = System.Drawing.Color.White;
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.operator_Click);
            // btnDivide in Standard mode
            this.btnDivide.Location = new System.Drawing.Point(240, 56);
            this.tabStandard.Controls.Add(this.btnDivide);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSqrt.Location = new System.Drawing.Point(320, 56);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(72, 48);
            this.btnSqrt.TabIndex = 16;
            this.btnSqrt.Tag = "Sqrt";
            this.btnSqrt.Text = "√";
            this.btnSqrt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSqrt.ForeColor = System.Drawing.Color.White;
            this.btnSqrt.UseVisualStyleBackColor = false;
            this.btnSqrt.Click += new System.EventHandler(this.uOperator_Click);
            // btnSqrt in Standard mode
            this.btnSqrt.Location = new System.Drawing.Point(320, 56);
            this.tabStandard.Controls.Add(this.btnSqrt);
            // 
            // btnEqu
            // 
            this.btnEqu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEqu.Location = new System.Drawing.Point(320, 224);
            this.btnEqu.Name = "btnEqu";
            this.btnEqu.Size = new System.Drawing.Size(72, 48);
            this.btnEqu.TabIndex = 17;
            this.btnEqu.Tag = "Equ";
            this.btnEqu.Text = "=";
            this.btnEqu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.btnEqu.ForeColor = System.Drawing.Color.White;
            this.btnEqu.UseVisualStyleBackColor = false;
            this.btnEqu.Click += new System.EventHandler(this.btnEqu_Click);
            // btnEqu in Standard mode
            this.btnEqu.Location = new System.Drawing.Point(320, 224);
            this.tabStandard.Controls.Add(this.btnEqu);
            // 
            // btnNegate
            // 
            this.btnNegate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNegate.Location = new System.Drawing.Point(160, 224);
            this.btnNegate.Name = "btnNegate";
            this.btnNegate.Size = new System.Drawing.Size(72, 48);
            this.btnNegate.TabIndex = 18;
            this.btnNegate.Text = "±";
            this.btnNegate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnNegate.ForeColor = System.Drawing.Color.White;
            this.btnNegate.UseVisualStyleBackColor = false;
            this.btnNegate.Click += new System.EventHandler(this.btnNegate_Click);
            // btnNegate in Standard mode
            this.btnNegate.Location = new System.Drawing.Point(160, 224);
            this.tabStandard.Controls.Add(this.btnNegate);
            // 
            // btnCopy
            // 
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCopy.Location = new System.Drawing.Point(320, 168);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(72, 48);
            this.btnCopy.TabIndex = 19;
            this.btnCopy.Text = "Copy";
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCopy.ForeColor = System.Drawing.Color.White;
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // btnCopy in Standard mode
            this.btnCopy.Location = new System.Drawing.Point(320, 168);
            this.tabStandard.Controls.Add(this.btnCopy);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            // Fixed size - user controls window resizing manually
            this.ClientSize = new System.Drawing.Size(416, 620);
            // Position shared buttons for Standard mode (they'll be visible in both tabs)
            this.btnSpeech = new System.Windows.Forms.Button();
            // Add controls that stay on the main form
            this.tabHistory.Controls.Add(this.lstHistory);
            this.Controls.Add(this.tabModes);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.btnSpeech);
            this.Controls.Add(this.txtResults);
            // 
            // btnTheme
            // 
            this.btnTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTheme.Location = new System.Drawing.Point(240, 0);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(72, 48);
            this.btnTheme.TabIndex = 50;
            this.btnTheme.Text = "Theme";
            this.btnTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnTheme.ForeColor = System.Drawing.Color.White;
            this.btnTheme.UseVisualStyleBackColor = false;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // btnTheme in Standard mode
            this.btnTheme.Location = new System.Drawing.Point(240, 0);
            this.tabStandard.Controls.Add(this.btnTheme);
            // 
            // btnAudioToggle
            // 
            this.btnAudioToggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAudioToggle.Location = new System.Drawing.Point(320, 0);
            this.btnAudioToggle.Name = "btnAudioToggle";
            this.btnAudioToggle.Size = new System.Drawing.Size(72, 48);
            this.btnAudioToggle.TabIndex = 52;
            this.btnAudioToggle.Text = "🔊";
            this.btnAudioToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnAudioToggle.ForeColor = System.Drawing.Color.White;
            this.btnAudioToggle.UseVisualStyleBackColor = false;
            this.btnAudioToggle.Click += new System.EventHandler(this.btnAudioToggle_Click);
            // btnAudioToggle in Standard mode
            this.btnAudioToggle.Location = new System.Drawing.Point(320, 0);
            this.tabStandard.Controls.Add(this.btnAudioToggle);
            // 
            // btnSpeech
            // 
            this.btnSpeech.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSpeech.Location = new System.Drawing.Point(364, 40);
            this.btnSpeech.Name = "btnSpeech";
            this.btnSpeech.Size = new System.Drawing.Size(40, 50);
            this.btnSpeech.TabIndex = 53;
            this.btnSpeech.Text = "🗣";
            this.btnSpeech.UseVisualStyleBackColor = false;
            this.btnSpeech.Click += new System.EventHandler(this.btnSpeech_Click);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.TopMost = false;
            this.Padding = new System.Windows.Forms.Padding(8);
            this.ResumeLayout(false);
            this.PerformLayout();
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
        private System.Windows.Forms.Button btnAudioToggleSci;
    }
}
