namespace Calculator
{
    partial class Calc
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._calcDisplay = new System.Windows.Forms.RichTextBox();
            this._btn2 = new System.Windows.Forms.Button();
            this._btn1 = new System.Windows.Forms.Button();
            this._btn3 = new System.Windows.Forms.Button();
            this._btn0 = new System.Windows.Forms.Button();
            this._btnDeci = new System.Windows.Forms.Button();
            this._btnNegative = new System.Windows.Forms.Button();
            this._btn4 = new System.Windows.Forms.Button();
            this._btn5 = new System.Windows.Forms.Button();
            this._btn6 = new System.Windows.Forms.Button();
            this._btnEquals = new System.Windows.Forms.Button();
            this._btnPlus = new System.Windows.Forms.Button();
            this._btnSub = new System.Windows.Forms.Button();
            this._btnMulti = new System.Windows.Forms.Button();
            this._btnDiv = new System.Windows.Forms.Button();
            this._btn9 = new System.Windows.Forms.Button();
            this._btn8 = new System.Windows.Forms.Button();
            this._btn7 = new System.Windows.Forms.Button();
            this._btnClear = new System.Windows.Forms.Button();
            this._btnCP = new System.Windows.Forms.Button();
            this._btnOP = new System.Windows.Forms.Button();
            this._btnPow = new System.Windows.Forms.Button();
            this._author = new System.Windows.Forms.Label();
            this._DelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _calcDisplay
            // 
            this._calcDisplay.DetectUrls = false;
            this._calcDisplay.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._calcDisplay.ForeColor = System.Drawing.Color.Black;
            this._calcDisplay.Location = new System.Drawing.Point(13, 13);
            this._calcDisplay.Name = "_calcDisplay";
            this._calcDisplay.ReadOnly = true;
            this._calcDisplay.Size = new System.Drawing.Size(556, 75);
            this._calcDisplay.TabIndex = 0;
            this._calcDisplay.Text = "Enter Data...";
            this._calcDisplay.TextChanged += new System.EventHandler(this._calcDisplay_TextChanged);
            // 
            // _btn2
            // 
            this._btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this._btn2.Location = new System.Drawing.Point(154, 358);
            this._btn2.Name = "_btn2";
            this._btn2.Size = new System.Drawing.Size(59, 47);
            this._btn2.TabIndex = 1;
            this._btn2.Text = "2";
            this._btn2.UseVisualStyleBackColor = true;
            this._btn2.Click += new System.EventHandler(this._btn2_Click);
            // 
            // _btn1
            // 
            this._btn1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._btn1.Location = new System.Drawing.Point(89, 358);
            this._btn1.Name = "_btn1";
            this._btn1.Size = new System.Drawing.Size(59, 47);
            this._btn1.TabIndex = 2;
            this._btn1.Text = "1";
            this._btn1.UseVisualStyleBackColor = true;
            this._btn1.Click += new System.EventHandler(this._btn1_Click);
            // 
            // _btn3
            // 
            this._btn3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._btn3.Location = new System.Drawing.Point(219, 358);
            this._btn3.Name = "_btn3";
            this._btn3.Size = new System.Drawing.Size(59, 47);
            this._btn3.TabIndex = 3;
            this._btn3.Text = "3";
            this._btn3.UseVisualStyleBackColor = true;
            this._btn3.Click += new System.EventHandler(this._btn3_Click);
            // 
            // _btn0
            // 
            this._btn0.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._btn0.Location = new System.Drawing.Point(89, 411);
            this._btn0.Name = "_btn0";
            this._btn0.Size = new System.Drawing.Size(59, 47);
            this._btn0.TabIndex = 4;
            this._btn0.Text = "0";
            this._btn0.UseVisualStyleBackColor = true;
            this._btn0.Click += new System.EventHandler(this._btn0_Click);
            // 
            // _btnDeci
            // 
            this._btnDeci.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._btnDeci.Location = new System.Drawing.Point(154, 412);
            this._btnDeci.Name = "_btnDeci";
            this._btnDeci.Size = new System.Drawing.Size(59, 47);
            this._btnDeci.TabIndex = 5;
            this._btnDeci.Text = ".";
            this._btnDeci.UseVisualStyleBackColor = true;
            this._btnDeci.Click += new System.EventHandler(this._btnDeci_Click);
            // 
            // _btnNegative
            // 
            this._btnNegative.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._btnNegative.Location = new System.Drawing.Point(219, 412);
            this._btnNegative.Name = "_btnNegative";
            this._btnNegative.Size = new System.Drawing.Size(59, 47);
            this._btnNegative.TabIndex = 6;
            this._btnNegative.Text = "(-)";
            this._btnNegative.UseVisualStyleBackColor = true;
            this._btnNegative.Click += new System.EventHandler(this._btnNegative_Click);
            // 
            // _btn4
            // 
            this._btn4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._btn4.Location = new System.Drawing.Point(89, 305);
            this._btn4.Name = "_btn4";
            this._btn4.Size = new System.Drawing.Size(59, 47);
            this._btn4.TabIndex = 10;
            this._btn4.Text = "4";
            this._btn4.UseVisualStyleBackColor = true;
            this._btn4.Click += new System.EventHandler(this._btn4_Click);
            // 
            // _btn5
            // 
            this._btn5.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._btn5.Location = new System.Drawing.Point(154, 305);
            this._btn5.Name = "_btn5";
            this._btn5.Size = new System.Drawing.Size(59, 47);
            this._btn5.TabIndex = 11;
            this._btn5.Text = "5";
            this._btn5.UseVisualStyleBackColor = true;
            this._btn5.Click += new System.EventHandler(this._btn5_Click);
            // 
            // _btn6
            // 
            this._btn6.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._btn6.Location = new System.Drawing.Point(219, 305);
            this._btn6.Name = "_btn6";
            this._btn6.Size = new System.Drawing.Size(59, 47);
            this._btn6.TabIndex = 12;
            this._btn6.Text = "6";
            this._btn6.UseVisualStyleBackColor = true;
            this._btn6.Click += new System.EventHandler(this._btn6_Click);
            // 
            // _btnEquals
            // 
            this._btnEquals.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._btnEquals.Location = new System.Drawing.Point(285, 411);
            this._btnEquals.Name = "_btnEquals";
            this._btnEquals.Size = new System.Drawing.Size(95, 47);
            this._btnEquals.TabIndex = 13;
            this._btnEquals.Text = "=";
            this._btnEquals.UseVisualStyleBackColor = true;
            this._btnEquals.Click += new System.EventHandler(this.button13_Click);
            // 
            // _btnPlus
            // 
            this._btnPlus.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._btnPlus.Location = new System.Drawing.Point(285, 358);
            this._btnPlus.Name = "_btnPlus";
            this._btnPlus.Size = new System.Drawing.Size(59, 47);
            this._btnPlus.TabIndex = 14;
            this._btnPlus.Text = "+";
            this._btnPlus.UseVisualStyleBackColor = true;
            this._btnPlus.Click += new System.EventHandler(this._btnPlus_Click);
            // 
            // _btnSub
            // 
            this._btnSub.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._btnSub.Location = new System.Drawing.Point(285, 305);
            this._btnSub.Name = "_btnSub";
            this._btnSub.Size = new System.Drawing.Size(59, 47);
            this._btnSub.TabIndex = 15;
            this._btnSub.Text = "-";
            this._btnSub.UseVisualStyleBackColor = true;
            this._btnSub.Click += new System.EventHandler(this._btnSub_Click);
            // 
            // _btnMulti
            // 
            this._btnMulti.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._btnMulti.Location = new System.Drawing.Point(285, 252);
            this._btnMulti.Name = "_btnMulti";
            this._btnMulti.Size = new System.Drawing.Size(59, 47);
            this._btnMulti.TabIndex = 16;
            this._btnMulti.Text = "*";
            this._btnMulti.UseVisualStyleBackColor = true;
            this._btnMulti.Click += new System.EventHandler(this.button16_Click);
            // 
            // _btnDiv
            // 
            this._btnDiv.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._btnDiv.Location = new System.Drawing.Point(285, 199);
            this._btnDiv.Name = "_btnDiv";
            this._btnDiv.Size = new System.Drawing.Size(59, 47);
            this._btnDiv.TabIndex = 17;
            this._btnDiv.Text = "÷";
            this._btnDiv.UseVisualStyleBackColor = true;
            this._btnDiv.Click += new System.EventHandler(this._btnDiv_Click);
            // 
            // _btn9
            // 
            this._btn9.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._btn9.Location = new System.Drawing.Point(219, 252);
            this._btn9.Name = "_btn9";
            this._btn9.Size = new System.Drawing.Size(59, 47);
            this._btn9.TabIndex = 18;
            this._btn9.Text = "9";
            this._btn9.UseVisualStyleBackColor = true;
            this._btn9.Click += new System.EventHandler(this._btn9_Click);
            // 
            // _btn8
            // 
            this._btn8.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._btn8.Location = new System.Drawing.Point(154, 252);
            this._btn8.Name = "_btn8";
            this._btn8.Size = new System.Drawing.Size(59, 47);
            this._btn8.TabIndex = 19;
            this._btn8.Text = "8";
            this._btn8.UseVisualStyleBackColor = true;
            this._btn8.Click += new System.EventHandler(this._btn8_Click);
            // 
            // _btn7
            // 
            this._btn7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._btn7.Location = new System.Drawing.Point(89, 252);
            this._btn7.Name = "_btn7";
            this._btn7.Size = new System.Drawing.Size(59, 47);
            this._btn7.TabIndex = 20;
            this._btn7.Text = "7";
            this._btn7.UseVisualStyleBackColor = true;
            this._btn7.Click += new System.EventHandler(this._btn7_Click);
            // 
            // _btnClear
            // 
            this._btnClear.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._btnClear.Location = new System.Drawing.Point(350, 147);
            this._btnClear.Name = "_btnClear";
            this._btnClear.Size = new System.Drawing.Size(95, 47);
            this._btnClear.TabIndex = 21;
            this._btnClear.Text = "CLEAR";
            this._btnClear.UseVisualStyleBackColor = true;
            this._btnClear.Click += new System.EventHandler(this._btnClear_Click);
            // 
            // _btnCP
            // 
            this._btnCP.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._btnCP.Location = new System.Drawing.Point(219, 199);
            this._btnCP.Name = "_btnCP";
            this._btnCP.Size = new System.Drawing.Size(59, 47);
            this._btnCP.TabIndex = 22;
            this._btnCP.Text = ")";
            this._btnCP.UseVisualStyleBackColor = true;
            this._btnCP.Click += new System.EventHandler(this._btnCP_Click);
            // 
            // _btnOP
            // 
            this._btnOP.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._btnOP.Location = new System.Drawing.Point(154, 199);
            this._btnOP.Name = "_btnOP";
            this._btnOP.Size = new System.Drawing.Size(59, 47);
            this._btnOP.TabIndex = 23;
            this._btnOP.Text = "(";
            this._btnOP.UseVisualStyleBackColor = true;
            this._btnOP.Click += new System.EventHandler(this._btnOP_Click);
            // 
            // _btnPow
            // 
            this._btnPow.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._btnPow.Location = new System.Drawing.Point(285, 147);
            this._btnPow.Name = "_btnPow";
            this._btnPow.Size = new System.Drawing.Size(59, 46);
            this._btnPow.TabIndex = 24;
            this._btnPow.Text = "^";
            this._btnPow.UseVisualStyleBackColor = true;
            this._btnPow.Click += new System.EventHandler(this._btnPow_Click);
            // 
            // _author
            // 
            this._author.AutoSize = true;
            this._author.Enabled = false;
            this._author.Font = new System.Drawing.Font("Times New Roman", 8F);
            this._author.Location = new System.Drawing.Point(448, 444);
            this._author.Name = "_author";
            this._author.Size = new System.Drawing.Size(121, 14);
            this._author.TabIndex = 27;
            this._author.Text = "Created by: Troy Frazier";
            this._author.Click += new System.EventHandler(this._author_Click);
            // 
            // _DelBtn
            // 
            this._DelBtn.Font = new System.Drawing.Font("Times New Roman", 12F);
            this._DelBtn.Location = new System.Drawing.Point(350, 199);
            this._DelBtn.Name = "_DelBtn";
            this._DelBtn.Size = new System.Drawing.Size(95, 46);
            this._DelBtn.TabIndex = 28;
            this._DelBtn.Text = "DELETE";
            this._DelBtn.UseVisualStyleBackColor = true;
            this._DelBtn.Click += new System.EventHandler(this._DelBtn_Click);
            // 
            // Calc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 470);
            this.Controls.Add(this._DelBtn);
            this.Controls.Add(this._author);
            this.Controls.Add(this._btnPow);
            this.Controls.Add(this._btnOP);
            this.Controls.Add(this._btnCP);
            this.Controls.Add(this._btnClear);
            this.Controls.Add(this._btn7);
            this.Controls.Add(this._btn8);
            this.Controls.Add(this._btn9);
            this.Controls.Add(this._btnDiv);
            this.Controls.Add(this._btnMulti);
            this.Controls.Add(this._btnSub);
            this.Controls.Add(this._btnPlus);
            this.Controls.Add(this._btnEquals);
            this.Controls.Add(this._btn6);
            this.Controls.Add(this._btn5);
            this.Controls.Add(this._btn4);
            this.Controls.Add(this._btnNegative);
            this.Controls.Add(this._btnDeci);
            this.Controls.Add(this._btn0);
            this.Controls.Add(this._btn3);
            this.Controls.Add(this._btn1);
            this.Controls.Add(this._btn2);
            this.Controls.Add(this._calcDisplay);
            this.Name = "Calc";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button _btn2;
        private System.Windows.Forms.Button _btn1;
        private System.Windows.Forms.Button _btn3;
        private System.Windows.Forms.Button _btn0;
        private System.Windows.Forms.Button _btnDeci;
        private System.Windows.Forms.Button _btnNegative;
        private System.Windows.Forms.Button _btn4;
        private System.Windows.Forms.Button _btn5;
        private System.Windows.Forms.Button _btn6;
        private System.Windows.Forms.Button _btnEquals;
        private System.Windows.Forms.Button _btnPlus;
        private System.Windows.Forms.Button _btnSub;
        private System.Windows.Forms.Button _btnMulti;
        private System.Windows.Forms.Button _btnDiv;
        private System.Windows.Forms.Button _btn9;
        private System.Windows.Forms.Button _btn8;
        private System.Windows.Forms.Button _btn7;
        private System.Windows.Forms.Button _btnClear;
        public System.Windows.Forms.RichTextBox _calcDisplay;
        private System.Windows.Forms.Button _btnCP;
        private System.Windows.Forms.Button _btnOP;
        private System.Windows.Forms.Button _btnPow;
        private System.Windows.Forms.Label _author;
        private System.Windows.Forms.Button _DelBtn;
    }
}

