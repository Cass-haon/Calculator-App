namespace Calculator_App
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
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnAdd = new Button();
            btnSubtract = new Button();
            btnMultiply = new Button();
            btnDivide = new Button();
            btnEquals = new Button();
            btnClear = new Button();
            lstHistory = new ListBox();
            txtDisplay = new TextBox();
            SuspendLayout();
            // 
            // btn0
            // 
            btn0.Location = new Point(36, 216);
            btn0.Name = "btn0";
            btn0.Size = new Size(76, 24);
            btn0.TabIndex = 0;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Location = new Point(118, 216);
            btn1.Name = "btn1";
            btn1.Size = new Size(76, 24);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Location = new Point(200, 216);
            btn2.Name = "btn2";
            btn2.Size = new Size(76, 24);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(36, 246);
            btn3.Name = "btn3";
            btn3.Size = new Size(76, 24);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(118, 246);
            btn4.Name = "btn4";
            btn4.Size = new Size(76, 24);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(200, 246);
            btn5.Name = "btn5";
            btn5.Size = new Size(76, 24);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(36, 276);
            btn6.Name = "btn6";
            btn6.Size = new Size(76, 24);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Location = new Point(118, 276);
            btn7.Name = "btn7";
            btn7.Size = new Size(76, 24);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(200, 276);
            btn8.Name = "btn8";
            btn8.Size = new Size(76, 24);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Location = new Point(36, 306);
            btn9.Name = "btn9";
            btn9.Size = new Size(76, 24);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(303, 215);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(303, 246);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(75, 23);
            btnSubtract.TabIndex = 11;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(303, 276);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(75, 23);
            btnMultiply.TabIndex = 12;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(303, 306);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(75, 23);
            btnDivide.TabIndex = 13;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(303, 335);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(75, 23);
            btnEquals.TabIndex = 14;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(119, 306);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 15;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // lstHistory
            // 
            lstHistory.FormattingEnabled = true;
            lstHistory.ItemHeight = 15;
            lstHistory.Location = new Point(36, 25);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(342, 109);
            lstHistory.TabIndex = 16;
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(36, 161);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(342, 23);
            txtDisplay.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDisplay);
            Controls.Add(lstHistory);
            Controls.Add(btnClear);
            Controls.Add(btnEquals);
            Controls.Add(btnDivide);
            Controls.Add(btnMultiply);
            Controls.Add(btnSubtract);
            Controls.Add(btnAdd);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiply;
        private Button btnDivide;
        private Button btnEquals;
        private Button btnClear;
        private ListBox lstHistory;
        private TextBox txtDisplay;
    }
}
