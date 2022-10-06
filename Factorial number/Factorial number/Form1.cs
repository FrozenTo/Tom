namespace Factorial_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            int factorial = 1;
            int number = Int16.Parse(textBox1.Text);
            if (number < 0)
                textBox2.Text = "Negative";
            else if (number <= 1)
                textBox2.Text = "1";
            else
            {
                for(int counter = number; counter >= 2; counter--)
                {
                    factorial = factorial * counter;
                }
                textBox2.Text = factorial.ToString();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}