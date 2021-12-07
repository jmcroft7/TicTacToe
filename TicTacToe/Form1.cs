namespace TicTacToe
{
    public partial class Form1 : Form
    {
        bool turn = true; //true=x false=o
        int turnCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //about
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TicTacToe v1.0 \nBy Johnathan Croft", "About");
        }

        //new game
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {

            turnCount = 0;
            turn = true;

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

        //exit game
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if(turn)
            {
                b.Text = "X";
            } else
            {
                b.Text = "O";
            }
            turn = !turn;
            b.Enabled = false;
            turnCount++;
            checkForWinner();
        }

        private void checkForWinner()
        {
            bool isWinner = false;

            // horizontal checks
            if ((a1.Text == a2.Text) && (a2.Text == a3.Text) && (!a1.Enabled))
            {
                isWinner = true;
            }
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
            {
                isWinner = true;
            }
            else if ((b1.Text == b2.Text) && (b2.Text == b3.Text) && (!b1.Enabled))
            {
                isWinner = true;
            }

            // vertical checks
            if ((a1.Text == b1.Text) && (b1.Text == c1.Text) && (!a1.Enabled))
            {
                isWinner = true;
            }
            else if ((a2.Text == b2.Text) && (b2.Text == c2.Text) && (!a2.Enabled))
            {
                isWinner = true;
            }
            else if ((a3.Text == b3.Text) && (b3.Text == c3.Text) && (!a3.Enabled))
            {
                isWinner = true;
            }

            // diagonal checks
            if ((a1.Text == b2.Text) && (b2.Text == c3.Text) && (!a1.Enabled))
            {
                isWinner = true;
            }
            else if ((a3.Text == b2.Text) && (b2.Text == c1.Text) && (!c1.Enabled))
            {
                isWinner = true;
            }

            if (isWinner)
            {
                disableButtons();
                string winner = "";
                if(turn)
                {
                    winner = "O ";
                    owins.Text = (Int32.Parse(owins.Text) + 1).ToString();
                }
                else
                {
                    winner = "X ";
                    xwins.Text = (Int32.Parse(xwins.Text) + 1).ToString();
                }
                MessageBox.Show(winner + "Wins", "Game Over");
            }
            else
            {
                if(turnCount == 9)
                {
                MessageBox.Show("Draw", "Game Over");
                drawwins.Text = (Int32.Parse(drawwins.Text) + 1).ToString();
                }
            }
        }

        private void disableButtons()
        {
            try
            {

                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch { }
        }

        private void buttonEnter(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
            }
            else
            {
                b.Text = "O";
            }
        }

        private void buttonLeave(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Enabled)
            {
                b.Text = "";
            }
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawwins.Text = 0.ToString();
            xwins.Text = 0.ToString();
            owins.Text = 0.ToString();
            turnCount = 0;
            turn = true;

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