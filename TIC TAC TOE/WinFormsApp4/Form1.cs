using System.ComponentModel;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        bool turn = true; //my turn = true
        int turns = 0; //turn count

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            if (turn)
            {
                label1.Text = "O turn!";
            }
            else { label1.Text = "X turn!";
            }
            turn = !turn;
            b.Enabled = false;
            turns++;
            checkW();
        }

        private void checkW()
        {
            bool Winner = false;
            
            //horizontal
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                Winner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                Winner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                Winner = true;
            //Vertical
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                Winner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                Winner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                Winner = true;
            //diagonal
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                Winner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!C1.Enabled))
                Winner = true;
            if (Winner)
            {
                disableButtons();

                String winr = "";
                if (turn)
                    winr = "O";
                else
                    winr = "X";
                MessageBox.Show(winr + " wins!", "Congrats!");
            }
            else
            {
                if (turns == 9)
                    MessageBox.Show("Draw!", "So close!");
            }
            


        }
        private void disableButtons()
        {
            
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
                catch { }
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
            turn = true;
            turns = 0;
            label1.Text = "X turn!";
            foreach (Control c in Controls)
            {
                try
                {
                    Button b = (Button)c;
                    b.Enabled = true;
                    b.Text = "";
                }
                catch { }
            }
        }
    }
}
