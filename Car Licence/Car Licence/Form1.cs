namespace Car_Licence
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

        private void button1_Click(object sender, EventArgs e)
        {
            string[] text = File.ReadAllLines("C:\\Users\\tomps\\Desktop\\car.txt");

            string[] givememaxpoints = { "b", "d", "a", "a", "c", "a", "b", "a", "c", "d", "b", "c", "d", "a", "d", "c", "c", "b", "d", "a" };

            int num = 0;

            int anws = 0;

            foreach (string element in text)
            {
                if (element == text[num])
                {

                    anws++;

                }
                num++;
            }
            label2.Text = anws.ToString();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}