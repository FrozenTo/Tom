namespace WinFormsApp3
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int classA = Int16.Parse(textBox1.Text) * 15;
            textBox7.Text = "$" + classA.ToString();
            int classB = Int16.Parse(textBox2.Text) * 12;
            textBox4.Text = "$" + classB.ToString();
            int classC = Int16.Parse(textBox3.Text) * 9;
            textBox6.Text = "$" + classC.ToString();
            int Total = classA + classB + classC;
            textBox5.Text = "$" + Total.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}