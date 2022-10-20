using System.Windows.Forms;

namespace Rock__Paper__Scissors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int number = rand.Next(1, 4);
            
            if (number == 1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                label2.Text = "Computer's choice was Rock, it's a Tie!";
                
            }
            if (number == 2)
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
                label2.Text = "Computer's choice was Paper, You Lost!";
            }
            if (number == 3)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox1.Visible = true;
                label2.Text = "Computer's choice was Scissors, You Win!";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int number = rand.Next(1, 4);
            
            if (number == 1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                label2.Text = "Computer's choice was Rock, You Lost!";

            }
            if (number == 2)
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
                label2.Text = "Computer's choice was Paper, You Win!";
            }
            if (number == 3)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox1.Visible = true;
                label2.Text = "Computer's choice was Scissors, it's a Tie!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int number = rand.Next(1, 4);
            
            if (number == 1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                label2.Text = "Computer's choice was Rock, You Win!";

            }
            if (number == 2)
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
                label2.Text = "Computer's choice was Paper, it's a Tie!";
            }
            if (number == 3)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox1.Visible = true;
                label2.Text = "Computer's choice was Scissors, You Lost!";
            }

        }
    }
}