namespace Pet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pet Pet1 = new Pet(textBox1.Text, textBox2.Text, Convert.ToInt16(textBox3.Text));
            
            textBox4.Text = "Name: "+ Pet1.name + "\r\n" + "\r\nType: " + Pet1.type + "\r\nAge: " + Pet1.age;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    class Pet
    {
        public string name;
        public string type;
        public int age;

        public Pet(string Name, string Type, int Age)
        {
            name = Name;
            type = Type;
            age = Age;
        }

    }
}