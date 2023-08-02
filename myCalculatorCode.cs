namespace myCalculator
{
    public partial class Form1 : Form
    {
        double num1, num2, result;
        string Operator = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "1";
            }
            else
            {
                Screen.Text = Screen.Text + "1";
            }

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "2";
            }
            else
            {
                Screen.Text = Screen.Text + "2";
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "3";
            }
            else
            {
                Screen.Text = Screen.Text + "3";
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "4";
            }
            else
            {
                Screen.Text = Screen.Text + "4";
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "5";
            }
            else
            {
                Screen.Text = Screen.Text + "5";
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "6";
            }
            else
            {
                Screen.Text = Screen.Text + "6";
            }

        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "7";
            }
            else
            {
                Screen.Text = Screen.Text + "7";
            }

        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "8";
            }
            else
            {
                Screen.Text = Screen.Text + "8";
            }

        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "9";
            }
            else
            {
                Screen.Text = Screen.Text + "9";
            }

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "0";
            }
            else
            {
                Screen.Text = Screen.Text + "0";
            }
        }

        private void btn_00_Click(object sender, EventArgs e)
        {
            if (Screen.Text == "0")
            {
                Screen.Text = "0";
            }
            else
            {
                Screen.Text = Screen.Text + "00";
            }
        }

        private void btn_point_Click(object sender, EventArgs e)
        { // To Avoid multiple points
                if (Screen.Text.Contains("."))
                {       
                    Screen.Text = Screen.Text;
                }
            else
                {
                    Screen.Text = Screen.Text + ".";
                }
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Screen.Text);
            Operator = "+";
            Screen.Clear();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Screen.Text);
            Operator = "-";
            Screen.Clear();
        }

        private void btn_times_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Screen.Text);
            Operator = "x";
            Screen.Clear();
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(Screen.Text);
            Operator = "÷";
            Screen.Clear();
        }

        private void btn_percent_Click(object sender, EventArgs e)
        {
            double forPercentage = double.Parse(Screen.Text);
            Screen.Text = (forPercentage / 100).ToString();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // BACKSPACE CODE
            if (Screen.Text.Length > 0)
            {
                Screen.Text = Screen.Text.Remove(Screen.Text.Length - 1, 1);
            }
            else
            {
                Screen.Text = "0";
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Screen.Clear();
        }

        private void btn_dec_Click(object sender, EventArgs e)
        {
            string binaryNumber = Screen.Text;
            Screen.Text = Convert.ToInt32(binaryNumber, 2).ToString();
        }

        private void btn_bin_Click(object sender, EventArgs e)
        {
            int decimalNumber = int.Parse(Screen.Text);
            Screen.Text = Convert.ToString(decimalNumber, 2).ToString();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void equalToButton_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(Screen.Text);

            switch (Operator)
            {
                case "+": // Addition
                    result = (num1 + num2);
                    break;
                case "-": // Subtraction
                    result = (num1 - num2);
                    break;
                case "x": // Multiplication
                    result = (num1 * num2);
                    break;
                case "÷": // Division
                    result = (num1 / num2);
                    break;
                default:
                    break;
            }
            // DISPLAYING OPERATION RESULT
            Screen.Text = result.ToString();

        }
    }
}