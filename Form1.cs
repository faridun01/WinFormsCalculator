using System;
using System.Data;
using System.Windows.Forms;

namespace WinFormsCalculator
{
    public partial class Form1 : Form
    {
        private string currentNumber = "";  // Stores current input
        private string lastResult = ""; // Stores last computed result
        private string currentOperator = ""; // Stores the selected operator
        private bool isOperatorClicked = false; // Prevents operator from showing immediately

        public Form1()
        {
            InitializeComponent();
        }

        // Append numbers to TextBox
        private void AppendText(string text)
        {
            if (isOperatorClicked)
            {
                textBoxDisplay.Text = ""; // Clear display before next input
                isOperatorClicked = false;
            }
            textBoxDisplay.Text += text;
        }

        // Number Button Click Event
        private void Number_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                AppendText(btn.Text);
            }
        }

        // Operator Button Click Event (Auto-Completes Previous Operation)
        private void Operator_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn == null || string.IsNullOrEmpty(textBoxDisplay.Text)) return;

            if (!string.IsNullOrEmpty(lastResult))
            {
                // If last result is stored, use it as the first number
                currentNumber = lastResult;
            }
            else
            {
                currentNumber = textBoxDisplay.Text;
            }

            if (!string.IsNullOrEmpty(currentOperator))
            {
                // Auto-complete the previous operation
                Equals_Click(null, null);
                currentNumber = textBoxDisplay.Text;
            }

            currentOperator = btn.Text;
            isOperatorClicked = true; // Prevents operator from showing immediately
        }

        // Equals Button Click Event (Computes Result)
        private void Equals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentNumber) && !isOperatorClicked)
            {
                try
                {
                    string expression = currentNumber + " " + currentOperator + " " + textBoxDisplay.Text;
                    DataTable dt = new DataTable();
                    var result = dt.Compute(expression, "");
                    textBoxDisplay.Text = result.ToString();
                    lastResult = textBoxDisplay.Text; // Store last result
                    currentOperator = "";
                }
                catch
                {
                    textBoxDisplay.Text = "Error";
                    lastResult = "";
                    currentOperator = "";
                }
            }
        }

        // Decimal Point Button Click Event
        private void Decimal_Click(object sender, EventArgs e)
        {
            if (!textBoxDisplay.Text.Contains("."))
            {
                AppendText(".");
            }
        }

        // Clear Button Click Event
        private void Clear_Click(object sender, EventArgs e)
        {
            textBoxDisplay.Text = "";
            currentNumber = "";
            lastResult = "";
            currentOperator = "";
        }

        // Delete (Backspace) Button Click Event
        private void Delete_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text.Length > 0)
            {
                textBoxDisplay.Text = textBoxDisplay.Text.Substring(0, textBoxDisplay.Text.Length - 1);
            }
        }

        // Square Root Button Click Event
        private void btnRoot_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.TryParse(textBoxDisplay.Text, out double number))
                {
                    if (number < 0)
                    {
                        textBoxDisplay.Text = ""; // Prevent sqrt of negative numbers
                    }
                    else
                    {
                        textBoxDisplay.Text = Math.Sqrt(number).ToString();
                    }
                }
                else
                {
                    textBoxDisplay.Text = "";
                }
            }
            catch
            {
                textBoxDisplay.Text = "Error";
            }
        }
    }
}
