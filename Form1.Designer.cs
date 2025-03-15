namespace WinFormsCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            textBoxDisplay = new TextBox();
            btn0 = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btnDecimal = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnAdd = new Button();
            btnClear = new Button();
            btnDivide = new Button();
            btnMultiply = new Button();
            btnSubtract = new Button();
            btnEquals = new Button();
            btnRoot = new Button();
            Delete = new Button();
            SuspendLayout();
            // 
            // textBoxDisplay
            // 
            textBoxDisplay.BackColor = Color.Black;
            resources.ApplyResources(textBoxDisplay, "textBoxDisplay");
            textBoxDisplay.ForeColor = Color.White;
            textBoxDisplay.Name = "textBoxDisplay";
            textBoxDisplay.ReadOnly = true;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Black;
            resources.ApplyResources(btn0, "btn0");
            btn0.ForeColor = Color.White;
            btn0.Name = "btn0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += Number_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Black;
            resources.ApplyResources(btn1, "btn1");
            btn1.ForeColor = Color.White;
            btn1.Name = "btn1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += Number_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Black;
            resources.ApplyResources(btn2, "btn2");
            btn2.ForeColor = Color.White;
            btn2.Name = "btn2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += Number_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.Black;
            resources.ApplyResources(btnDecimal, "btnDecimal");
            btnDecimal.ForeColor = Color.White;
            btnDecimal.Name = "btnDecimal";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += Decimal_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Black;
            resources.ApplyResources(btn3, "btn3");
            btn3.ForeColor = Color.White;
            btn3.Name = "btn3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += Number_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Black;
            resources.ApplyResources(btn4, "btn4");
            btn4.ForeColor = Color.White;
            btn4.Name = "btn4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += Number_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Black;
            resources.ApplyResources(btn5, "btn5");
            btn5.ForeColor = Color.White;
            btn5.Name = "btn5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += Number_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Black;
            resources.ApplyResources(btn6, "btn6");
            btn6.ForeColor = Color.White;
            btn6.Name = "btn6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += Number_Click;
            // 
            // btn7
            // 
            btn7.BackColor = SystemColors.ActiveCaptionText;
            resources.ApplyResources(btn7, "btn7");
            btn7.ForeColor = Color.White;
            btn7.Name = "btn7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += Number_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Black;
            resources.ApplyResources(btn8, "btn8");
            btn8.ForeColor = Color.White;
            btn8.Name = "btn8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += Number_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Black;
            resources.ApplyResources(btn9, "btn9");
            btn9.ForeColor = Color.White;
            btn9.Name = "btn9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += Number_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Black;
            resources.ApplyResources(btnAdd, "btnAdd");
            btnAdd.ForeColor = Color.White;
            btnAdd.Name = "btnAdd";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += Operator_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Red;
            resources.ApplyResources(btnClear, "btnClear");
            btnClear.ForeColor = Color.White;
            btnClear.Name = "btnClear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += Clear_Click;
            // 
            // btnDivide
            // 
            btnDivide.BackColor = Color.Black;
            resources.ApplyResources(btnDivide, "btnDivide");
            btnDivide.ForeColor = Color.White;
            btnDivide.Name = "btnDivide";
            btnDivide.UseVisualStyleBackColor = false;
            btnDivide.Click += Operator_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.BackColor = Color.Black;
            resources.ApplyResources(btnMultiply, "btnMultiply");
            btnMultiply.ForeColor = Color.White;
            btnMultiply.Name = "btnMultiply";
            btnMultiply.UseVisualStyleBackColor = false;
            btnMultiply.Click += Operator_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.BackColor = Color.Black;
            resources.ApplyResources(btnSubtract, "btnSubtract");
            btnSubtract.ForeColor = Color.White;
            btnSubtract.Name = "btnSubtract";
            btnSubtract.UseVisualStyleBackColor = false;
            btnSubtract.Click += Operator_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = Color.Black;
            resources.ApplyResources(btnEquals, "btnEquals");
            btnEquals.ForeColor = Color.White;
            btnEquals.Name = "btnEquals";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += Equals_Click;
            // 
            // btnRoot
            // 
            btnRoot.BackColor = Color.Black;
            resources.ApplyResources(btnRoot, "btnRoot");
            btnRoot.ForeColor = Color.White;
            btnRoot.Name = "btnRoot";
            btnRoot.UseVisualStyleBackColor = false;
            btnRoot.Click += btnRoot_Click;
            // 
            // Delete
            // 
            Delete.BackColor = Color.Black;
            resources.ApplyResources(Delete, "Delete");
            Delete.ForeColor = Color.White;
            Delete.Name = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            Controls.Add(Delete);
            Controls.Add(btnRoot);
            Controls.Add(btnEquals);
            Controls.Add(btnSubtract);
            Controls.Add(btnMultiply);
            Controls.Add(btnDivide);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btnDecimal);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btn0);
            Controls.Add(textBoxDisplay);
            Cursor = Cursors.Hand;
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private TextBox textBoxDisplay;
        private Button btn0;
        private Button btn1;
        private Button btn2;
        private Button btnDecimal;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnAdd;
        private Button btnClear;
        private Button btnDivide;
        private Button btnMultiply;
        private Button btnSubtract;
        private Button btnEquals;
        private Button btnRoot;
        private Button Delete;
    }
}