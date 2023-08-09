using BusinessLogic;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        decimal number1, number2;
        string operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OnNumberClick(object sender, EventArgs e)
        {
            if (ResultTextBox.Text == operation)
            {
                ResultTextBox.Text = "";
            }
            Button button = (Button)sender;
            switch (button.Text)
            {
                case "0":
                    ResultTextBox.Text += "0";
                    break;
                case "1":
                    ResultTextBox.Text += "1";
                    break;
                case "2":
                    ResultTextBox.Text += "2";
                    break;
                case "3":
                    ResultTextBox.Text += "3";
                    break;
                case "4":
                    ResultTextBox.Text += "4";
                    break;
                case "5":
                    ResultTextBox.Text += "5";
                    break;
                case "6":
                    ResultTextBox.Text += "6";
                    break;
                case "7":
                    ResultTextBox.Text += "7";
                    break;
                case "8":
                    ResultTextBox.Text += "8";
                    break;
                case "9":
                    ResultTextBox.Text += "9";
                    break;
            }
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            if (number1 == 0 && number2 == 0)
            {
                ResultTextBox.Text = "0";
            }
            try
            {
                number2 = Convert.ToDecimal(ResultTextBox.Text);
                switch (operation)
                {
                    case "+":
                        ResultTextBox.Text = Calculator.AddNumbers(number1, number2).ToString();
                        break;
                    case "-":
                        ResultTextBox.Text = Calculator.SubNumbers(number1, number2).ToString();
                        break;
                    case "x":
                        ResultTextBox.Text = Calculator.MultiplyNumbers(number1, number2).ToString();
                        break;
                    case "/":
                        ResultTextBox.Text = Calculator.DivideNumbers(number1, number2).ToString();
                        break;
                    case "^":
                        ResultTextBox.Text = Calculator.ToThePowerOf(number1, number2).ToString();
                        break;
                }
            }
            catch
            {
                CheckIfOperationAlreadyClicked(sender, e);
            }
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            number2 = 0;
            operation = "";
            ResultTextBox.Text = "";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            number1 = 0;
            number2 = 0;
            ResultTextBox.Text = "";
        }

        private void CheckIfOperationAlreadyClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            String newOperation = button.Text;
            if (newOperation == operation)
            {
                ResultTextBox.Text = operation;
            }
            else
            {
                ResultTextBox.Text = newOperation;
            }
        }

        private void OnOperationClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            try
            {
                number1 = Convert.ToDecimal(ResultTextBox.Text);
            }
            catch
            {
                CheckIfOperationAlreadyClicked(sender, e);
            }
            operation = button.Text;
            ResultTextBox.Text = operation;
        }

        private void NegateSignButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal number = Convert.ToDecimal(ResultTextBox.Text);
                number *= -1;
                ResultTextBox.Text = number.ToString();
            }
            catch
            {
                CheckIfOperationAlreadyClicked(sender, e);
            }
        }

        private void SquareRootButtonClick(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToDecimal(ResultTextBox.Text);
                number1 = Calculator.SquareRoot(number1);
                ResultTextBox.Text = number1.ToString();
            }
            catch
            {
                CheckIfOperationAlreadyClicked(sender, e);
            }
        }
    }
}