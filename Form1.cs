namespace Calculator_App
{
    public partial class Form1 : Form
    {

        private Math calculator = new Math();
        private string currentOperation = string.Empty;
        private double firstNumber = 0;
        private bool isNewEntry = true;


        public Form1()
        {
            InitializeComponent();
            AttachNumberButtonEvents();
            AttachOperationButtonEvents();
            btnEquals.Click += btnEquals_Click!;
            btnClear.Click += btnClear_Click!;
        }


        private void AttachNumberButtonEvents()
        {
            btn0.Click += NumberButton_Click!;
            btn1.Click += NumberButton_Click!;
            btn2.Click += NumberButton_Click!;
            btn3.Click += NumberButton_Click!;
            btn4.Click += NumberButton_Click!;
            btn5.Click += NumberButton_Click!;
            btn6.Click += NumberButton_Click!;
            btn7.Click += NumberButton_Click!;
            btn8.Click += NumberButton_Click!;
            btn9.Click += NumberButton_Click!;
        }


        private void AttachOperationButtonEvents()
        {
            btnAdd.Click += OperationButton_Click!;
            btnSubtract.Click += OperationButton_Click!;
            btnMultiply.Click += OperationButton_Click!;
            btnDivide.Click += OperationButton_Click!;
        }


        private void NumberButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button button)
            {
                // If it's a new entry, replace the display text with the button text
                if (isNewEntry)
                {
                    txtDisplay.Text = button.Text;
                    isNewEntry = false;
                }
                // Otherwise, append the button text to the display text
                else
                {
                    txtDisplay.Text += button.Text;
                }
            }
        }


        private void OperationButton_Click(object? sender, EventArgs e)
        {
            if (sender is Button button && double.TryParse(txtDisplay.Text, out firstNumber))
            {
                // Store the current operation and set isNewEntry to true
                currentOperation = button.Text;
                isNewEntry = true;
            }
        }


        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtDisplay.Text, out double secondNumber))
            {
                double result = 0;
                try
                {
                    // Perform the calculation based on the current operation
                    switch (currentOperation)
                    {
                        case "+":
                            result = calculator.Add(firstNumber, secondNumber);
                            break;
                        case "-":
                            result = calculator.Subtract(firstNumber, secondNumber);
                            break;
                        case "*":
                            result = calculator.Multiply(firstNumber, secondNumber);
                            break;
                        case "/":
                            result = calculator.Divide(firstNumber, secondNumber);
                            break;
                        default:
                            MessageBox.Show("Invalid operation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                    }


                    txtDisplay.Text = result.ToString();
                    lstHistory.Items.Add($"{firstNumber} {currentOperation} {secondNumber} = {result}");
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                isNewEntry = true;
            }
            else
            {
                MessageBox.Show("Invalid number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear the display and reset the calculator state
            txtDisplay.Clear();
            firstNumber = 0;
            currentOperation = string.Empty;
            isNewEntry = true;
        }

        private void btn7_Click(object sender, EventArgs e)
        {

        }
    }
}