namespace Estonian_Names
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] boynames = File.ReadAllLines("C:\\Users\\tomps\\Desktop\\boy names.txt");
            string[] girlnames = File.ReadAllLines("C:\\Users\\tomps\\Desktop\\girl names.txt");
            string searchelement = textBox1.Text;
            bool exists = Array.Exists(boynames, element => element == searchelement);
            if (exists)
            {
                label2.Text = "The name was popular amongst male names.";
            }
            else
            {
                bool exists2 = Array.Exists(girlnames, element => element == searchelement);
                if (exists2)
                {
                    label2.Text = "The name was popular amongst female names.";
                }
                else
                {
                    label2.Text = "The name was not popular amongst female \n nor male names.";
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}