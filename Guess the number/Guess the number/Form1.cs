using System;

namespace Guess_the_number
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private int a = 0;
        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int number = rand.Next(0, 100);
            a = number;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int guess = Int16.Parse(textBox1.Text);
                if (guess > a)
                {
                    textBox2.Text = "try lower";
                }
                else if (guess < a)
                {
                    textBox2.Text = "try higher";
                }
                else if (guess == a)
                {
                    textBox2.Text = "Congratulations, that's the number";
                }
            }
            catch
            {
                textBox2.Text = "Must have a number";
            }
        }


    }
}