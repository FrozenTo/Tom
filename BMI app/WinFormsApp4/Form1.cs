namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float classA = float.Parse(textBox2.Text) / (float.Parse(textBox3.Text) * float.Parse(textBox3.Text)) * 703;
            if (classA > 25)
            {
                string status = "overweight";
                textBox1.Text = "BMI: " + classA.ToString("0.00") + Environment.NewLine + "Status: " + status;
            }
            else if (classA < 18.5)
            {
                string status = "underweight";
                textBox1.Text = "BMI: " + classA.ToString("0.00") + Environment.NewLine + "Status: " + status;
            }
            else
            {
                string status = "normal";
                textBox1.Text = "BMI: " + classA.ToString("0.00") + Environment.NewLine + "Status: " + status;
            }

        }
    }
}