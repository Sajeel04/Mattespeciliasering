namespace Mattespecs
{
    public partial class Form1 : Form
    {
        double enterFirstValue;
        double enterSecondValue;
        string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBs_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!txtResult.Text.Contains("."))
                        txtResult.Text = txtResult.Text + num.Text;
                }
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;
                }
            }
        }

        private void NumberOperations(object sender, EventArgs e)
        {
            Button operatorButton = (Button)sender;
            enterFirstValue = double.Parse(txtResult.Text);
            op = operatorButton.Text;
            txtResult.Text = enterFirstValue.ToString() + op;
            enterSecondValue = 0;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            string expression = txtResult.Text;

            string[] numbers = expression.Split('+', '-', '*', '/');

            string[] operators = expression.Split(numbers, StringSplitOptions.RemoveEmptyEntries);

            List<string> operations = new List<string>();

            for (int i = 0; i < numbers.Length; i++)
            {
                operations.Add(numbers[i]);

                if (i < operators.Length)
                {
                    operations.Add(operators[i]);
                }
            }

            double result;

            if (double.TryParse(operations[0], out result))
            {
                for (int i = 1; i < operations.Count; i += 2)
                {
                    string op = operations[i];
                    double operand;
                    if (double.TryParse(operations[i + 1], out operand))
                    {
                        switch (op)
                        {
                            case "+":
                                result += operand;
                                break;
                            case "-":
                                result -= operand;
                                break;
                            case "*":
                                result *= operand;
                                break;
                            case "/":
                                result /= operand;
                                break;
                            default:
                                throw new InvalidOperationException("Invalid operator");
                        }
                    }
                    else
                    {
                        throw new FormatException("Invalid numeric value");
                    }
                }

                txtResult.Text = result.ToString();
            }
            else
            {
                throw new FormatException("Invalid numeric value");
            }
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            enterSecondValue = 0;
            op = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            enterFirstValue = 0;
            enterSecondValue = 0;
            op = string.Empty;
            txtResult.Text = "0";
        }

        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResult.Text, out double currentValue))
            {
                double percentageValue = currentValue * 0.01;
                txtResult.Text = percentageValue.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResult.Text, out double currentValue))
            {
                double sqrtValue = Math.Sqrt(currentValue);
                txtResult.Text = sqrtValue.ToString();
            }
        }

        private void btnSqaure_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResult.Text, out double currentValue))
            {
                double squareValue = currentValue * currentValue;
                txtResult.Text = squareValue.ToString();
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResult.Text, out double currentValue))
            {
                double sinValue = Math.Sin(currentValue);
                txtResult.Text = sinValue.ToString();
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResult.Text, out double currentValue))
            {
                double cosValue = Math.Cos(currentValue);
                txtResult.Text = cosValue.ToString();
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResult.Text, out double currentValue))
            {
                double tanValue = Math.Tan(currentValue);
                txtResult.Text = tanValue.ToString();
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResult.Text, out double currentValue))
            {
                double logValue = Math.Log10(currentValue);
                txtResult.Text = logValue.ToString();
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            double piValue = Math.PI;
            txtResult.Text = piValue.ToString();
        }

        private void btnCube_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResult.Text, out double currentValue))
            {
                double cubeValue = currentValue * currentValue * currentValue;
                txtResult.Text = cubeValue.ToString();
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtResult.Text, out double currentValue))
            {
                double negatedValue = -currentValue;
                txtResult.Text = negatedValue.ToString();
            }
        }
    }
}