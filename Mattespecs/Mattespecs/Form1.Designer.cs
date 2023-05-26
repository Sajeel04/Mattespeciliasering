namespace Mattespecs
{
    partial class Form1
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
            btnEquals = new Button();
            btnCube = new Button();
            btnLog = new Button();
            btnPi = new Button();
            btnCos = new Button();
            btnTan = new Button();
            btnSqaure = new Button();
            btnSin = new Button();
            button1 = new Button();
            btn2 = new Button();
            txtResult = new TextBox();
            btnDivide = new Button();
            btnPercent = new Button();
            btnMult = new Button();
            btn3 = new Button();
            btnMinus = new Button();
            btn6 = new Button();
            btn0 = new Button();
            btnPlus = new Button();
            btn9 = new Button();
            btn5 = new Button();
            btnDot = new Button();
            btnPlusMinus = new Button();
            btn1 = new Button();
            btn8 = new Button();
            btn4 = new Button();
            btnClear = new Button();
            btn7 = new Button();
            btnClearEntry = new Button();
            btnBs = new Button();
            SuspendLayout();
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.FromArgb(255, 128, 0);
            btnEquals.Location = new Point(403, 336);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(191, 60);
            btnEquals.TabIndex = 33;
            btnEquals.Text = "EXE";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnCube
            // 
            btnCube.BackColor = Color.FromArgb(255, 128, 0);
            btnCube.Location = new Point(502, 266);
            btnCube.Name = "btnCube";
            btnCube.Size = new Size(93, 60);
            btnCube.TabIndex = 32;
            btnCube.Text = "x^3";
            btnCube.UseVisualStyleBackColor = false;
            btnCube.Click += btnCube_Click;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.FromArgb(255, 128, 0);
            btnLog.Location = new Point(502, 198);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(93, 60);
            btnLog.TabIndex = 31;
            btnLog.Text = "Log";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // btnPi
            // 
            btnPi.BackColor = Color.FromArgb(255, 128, 0);
            btnPi.Location = new Point(403, 266);
            btnPi.Name = "btnPi";
            btnPi.Size = new Size(93, 60);
            btnPi.TabIndex = 30;
            btnPi.Text = "π";
            btnPi.UseVisualStyleBackColor = false;
            btnPi.Click += btnPi_Click;
            // 
            // btnCos
            // 
            btnCos.BackColor = Color.FromArgb(255, 128, 0);
            btnCos.Location = new Point(502, 132);
            btnCos.Name = "btnCos";
            btnCos.Size = new Size(93, 60);
            btnCos.TabIndex = 29;
            btnCos.Text = "Cos";
            btnCos.UseVisualStyleBackColor = false;
            btnCos.Click += btnCos_Click;
            // 
            // btnTan
            // 
            btnTan.BackColor = Color.FromArgb(255, 128, 0);
            btnTan.Location = new Point(403, 198);
            btnTan.Name = "btnTan";
            btnTan.Size = new Size(93, 60);
            btnTan.TabIndex = 28;
            btnTan.Text = "Tan";
            btnTan.UseVisualStyleBackColor = false;
            btnTan.Click += btnTan_Click;
            // 
            // btnSqaure
            // 
            btnSqaure.BackColor = Color.FromArgb(255, 128, 0);
            btnSqaure.Location = new Point(502, 66);
            btnSqaure.Name = "btnSqaure";
            btnSqaure.Size = new Size(93, 60);
            btnSqaure.TabIndex = 27;
            btnSqaure.Text = "x^2";
            btnSqaure.UseVisualStyleBackColor = false;
            btnSqaure.Click += btnSqaure_Click;
            // 
            // btnSin
            // 
            btnSin.BackColor = Color.FromArgb(255, 128, 0);
            btnSin.Location = new Point(403, 132);
            btnSin.Name = "btnSin";
            btnSin.Size = new Size(93, 60);
            btnSin.TabIndex = 26;
            btnSin.Text = "Sin";
            btnSin.UseVisualStyleBackColor = false;
            btnSin.Click += btnSin_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 0);
            button1.Location = new Point(403, 66);
            button1.Name = "button1";
            button1.Size = new Size(93, 60);
            button1.TabIndex = 25;
            button1.Text = "Sqrt";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.BackColor = SystemColors.ControlDarkDark;
            btn2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn2.Location = new Point(105, 266);
            btn2.Margin = new Padding(4);
            btn2.Name = "btn2";
            btn2.Size = new Size(93, 60);
            btn2.TabIndex = 24;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += EnterNumbers;
            // 
            // txtResult
            // 
            txtResult.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            txtResult.Location = new Point(7, 10);
            txtResult.Margin = new Padding(4);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(588, 46);
            txtResult.TabIndex = 23;
            txtResult.Text = "0";
            txtResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.FromArgb(255, 128, 0);
            btnDivide.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDivide.Location = new Point(303, 336);
            btnDivide.Margin = new Padding(4);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(93, 60);
            btnDivide.TabIndex = 21;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += NumberOperations;
            // 
            // btnPercent
            // 
            btnPercent.BackColor = SystemColors.ControlDarkDark;
            btnPercent.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPercent.Location = new Point(204, 336);
            btnPercent.Margin = new Padding(4);
            btnPercent.Name = "btnPercent";
            btnPercent.Size = new Size(93, 60);
            btnPercent.TabIndex = 20;
            btnPercent.Text = "%";
            btnPercent.UseVisualStyleBackColor = false;
            btnPercent.Click += btnPercent_Click;
            // 
            // btnMult
            // 
            btnMult.BackColor = Color.FromArgb(255, 128, 0);
            btnMult.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMult.Location = new Point(303, 266);
            btnMult.Margin = new Padding(4);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(93, 60);
            btnMult.TabIndex = 19;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = false;
            btnMult.Click += NumberOperations;
            // 
            // btn3
            // 
            btn3.BackColor = SystemColors.ControlDarkDark;
            btn3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn3.Location = new Point(204, 266);
            btn3.Margin = new Padding(4);
            btn3.Name = "btn3";
            btn3.Size = new Size(93, 60);
            btn3.TabIndex = 4;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += EnterNumbers;
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.FromArgb(255, 128, 0);
            btnMinus.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinus.Location = new Point(303, 200);
            btnMinus.Margin = new Padding(4);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(93, 60);
            btnMinus.TabIndex = 17;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += NumberOperations;
            // 
            // btn6
            // 
            btn6.BackColor = SystemColors.ControlDarkDark;
            btn6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn6.Location = new Point(204, 200);
            btn6.Margin = new Padding(4);
            btn6.Name = "btn6";
            btn6.Size = new Size(93, 60);
            btn6.TabIndex = 16;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += EnterNumbers;
            // 
            // btn0
            // 
            btn0.BackColor = SystemColors.ControlDarkDark;
            btn0.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn0.Location = new Point(105, 336);
            btn0.Margin = new Padding(4);
            btn0.Name = "btn0";
            btn0.Size = new Size(93, 60);
            btn0.TabIndex = 15;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += EnterNumbers;
            // 
            // btnPlus
            // 
            btnPlus.BackColor = Color.FromArgb(255, 128, 0);
            btnPlus.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlus.Location = new Point(303, 130);
            btnPlus.Margin = new Padding(4);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(93, 60);
            btnPlus.TabIndex = 14;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = false;
            btnPlus.Click += NumberOperations;
            // 
            // btn9
            // 
            btn9.BackColor = SystemColors.ControlDarkDark;
            btn9.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn9.Location = new Point(204, 130);
            btn9.Margin = new Padding(4);
            btn9.Name = "btn9";
            btn9.Size = new Size(93, 60);
            btn9.TabIndex = 13;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += EnterNumbers;
            // 
            // btn5
            // 
            btn5.BackColor = SystemColors.ControlDarkDark;
            btn5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn5.Location = new Point(105, 200);
            btn5.Margin = new Padding(4);
            btn5.Name = "btn5";
            btn5.Size = new Size(93, 60);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += EnterNumbers;
            // 
            // btnDot
            // 
            btnDot.BackColor = SystemColors.ControlDarkDark;
            btnDot.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDot.Location = new Point(6, 336);
            btnDot.Margin = new Padding(4);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(93, 60);
            btnDot.TabIndex = 11;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = false;
            btnDot.Click += EnterNumbers;
            // 
            // btnPlusMinus
            // 
            btnPlusMinus.BackColor = Color.FromArgb(255, 128, 0);
            btnPlusMinus.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPlusMinus.Location = new Point(303, 64);
            btnPlusMinus.Margin = new Padding(4);
            btnPlusMinus.Name = "btnPlusMinus";
            btnPlusMinus.Size = new Size(93, 60);
            btnPlusMinus.TabIndex = 10;
            btnPlusMinus.Text = "±";
            btnPlusMinus.UseVisualStyleBackColor = false;
            btnPlusMinus.Click += btnPlusMinus_Click;
            // 
            // btn1
            // 
            btn1.BackColor = SystemColors.ControlDarkDark;
            btn1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn1.Location = new Point(6, 266);
            btn1.Margin = new Padding(4);
            btn1.Name = "btn1";
            btn1.Size = new Size(93, 60);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += EnterNumbers;
            // 
            // btn8
            // 
            btn8.BackColor = SystemColors.ControlDarkDark;
            btn8.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn8.Location = new Point(105, 130);
            btn8.Margin = new Padding(4);
            btn8.Name = "btn8";
            btn8.Size = new Size(93, 60);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += EnterNumbers;
            // 
            // btn4
            // 
            btn4.BackColor = SystemColors.ControlDarkDark;
            btn4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn4.Location = new Point(6, 200);
            btn4.Margin = new Padding(4);
            btn4.Name = "btn4";
            btn4.Size = new Size(93, 60);
            btn4.TabIndex = 7;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += EnterNumbers;
            // 
            // btnClear
            // 
            btnClear.BackColor = SystemColors.ButtonShadow;
            btnClear.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.Location = new Point(204, 64);
            btnClear.Margin = new Padding(4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(93, 60);
            btnClear.TabIndex = 6;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ControlDarkDark;
            btn7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn7.Location = new Point(6, 130);
            btn7.Margin = new Padding(4);
            btn7.Name = "btn7";
            btn7.Size = new Size(93, 60);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += EnterNumbers;
            // 
            // btnClearEntry
            // 
            btnClearEntry.BackColor = SystemColors.ButtonShadow;
            btnClearEntry.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnClearEntry.Location = new Point(105, 64);
            btnClearEntry.Margin = new Padding(4);
            btnClearEntry.Name = "btnClearEntry";
            btnClearEntry.Size = new Size(93, 60);
            btnClearEntry.TabIndex = 22;
            btnClearEntry.Text = "CE";
            btnClearEntry.UseVisualStyleBackColor = false;
            btnClearEntry.Click += btnClearEntry_Click;
            // 
            // btnBs
            // 
            btnBs.BackColor = SystemColors.ButtonShadow;
            btnBs.Font = new Font("Wingdings", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnBs.Location = new Point(6, 64);
            btnBs.Margin = new Padding(4);
            btnBs.Name = "btnBs";
            btnBs.Size = new Size(93, 60);
            btnBs.TabIndex = 18;
            btnBs.Text = "";
            btnBs.UseVisualStyleBackColor = false;
            btnBs.Click += btnBs_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaptionText;
            ClientSize = new Size(601, 404);
            Controls.Add(btnEquals);
            Controls.Add(btnCube);
            Controls.Add(btnLog);
            Controls.Add(btnPi);
            Controls.Add(btnCos);
            Controls.Add(btnTan);
            Controls.Add(btnSqaure);
            Controls.Add(btnSin);
            Controls.Add(button1);
            Controls.Add(btn2);
            Controls.Add(txtResult);
            Controls.Add(btnDivide);
            Controls.Add(btnPercent);
            Controls.Add(btnMult);
            Controls.Add(btn3);
            Controls.Add(btnMinus);
            Controls.Add(btn6);
            Controls.Add(btn0);
            Controls.Add(btnPlus);
            Controls.Add(btn9);
            Controls.Add(btn5);
            Controls.Add(btnDot);
            Controls.Add(btnPlusMinus);
            Controls.Add(btn1);
            Controls.Add(btn8);
            Controls.Add(btn4);
            Controls.Add(btnClear);
            Controls.Add(btn7);
            Controls.Add(btnClearEntry);
            Controls.Add(btnBs);
            Name = "Form1";
            Text = "Form1";
            Click += NumberOperations;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEquals;
        private Button btnCube;
        private Button btnLog;
        private Button btnPi;
        private Button btnCos;
        private Button btnTan;
        private Button btnSqaure;
        private Button btnSin;
        private Button button1;
        private Button btn2;
        private TextBox txtResult;
        private Button btnDivide;
        private Button btnPercent;
        private Button btnMult;
        private Button btn3;
        private Button btnMinus;
        private Button btn6;
        private Button btn0;
        private Button btnPlus;
        private Button btn9;
        private Button btn5;
        private Button btnDot;
        private Button btnPlusMinus;
        private Button btn1;
        private Button btn8;
        private Button btn4;
        private Button btnClear;
        private Button btn7;
        private Button btnClearEntry;
        private Button btnBs;
    }
}