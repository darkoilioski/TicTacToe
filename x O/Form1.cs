namespace x_O
{
    public partial class Form1 : Form
    {
        bool turn = true; // true = X, false = O
        int count = 0;
        Button[] buttons;
        public Form1()
        {
            InitializeComponent();
            buttons = new Button[] { A1, A2, A3, B1, B2, B3, C1, C2, C3 };
            ApplyLabelStyles();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.TabStop = false;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
            {
                b.Text = "X";
                b.Font = new Font(b.Font.FontFamily, 18);
                b.BackColor = Color.LightBlue;
                b.Enabled = false;
            }
            else
            {
                b.Text = "O";
                b.Font = new Font(b.Font.FontFamily, 18);
                b.BackColor = Color.LightSalmon;
                b.Enabled = false;
            }
            turn = !turn;
            count++;
            checkForWinner();
        }

        public void checkForWinner()
        {
            bool IsWinner = false;

            // Horizontal checks
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                IsWinner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                IsWinner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                IsWinner = true;

            // Vertical checks
            if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                IsWinner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                IsWinner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                IsWinner = true;

            // Diagonal checks
            if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                IsWinner = true;
            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                IsWinner = true;

            String winner = "";
            if (IsWinner)
            {
                winner = turn ? "O" : "X";
                DialogResult result = MessageBox.Show("Player " + winner + " Wins! Do you want to start a new game?", "Game Over", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    resetGame();
                }
            }
            if (IsWinner && winner == "X")
            {
                resultX.Text = (int.Parse(resultX.Text) + 1).ToString();
            }
            else if (IsWinner && winner == "O")
            {
                result0.Text = (int.Parse(result0.Text) + 1).ToString();
            }
            else if (count == 9)
            {
                DialogResult result = MessageBox.Show("It's a draw! Do you want to start a new game?", "Game Over", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    resetGame();
                }
            }
        }
        private void resetGame()
        {
            turn = true;
            count = 0;

            foreach (Button b in buttons)
            {
                b.Enabled = true;
                b.Text = "";
                b.BackColor = Color.White; // Додајте го ова за да ја ресетирате бојата на текстот

            }
        }
        private void ApplyLabelStyles()
        {
            foreach (Button button in buttons)
            {
                button.FlatAppearance.BorderSize = 1;
            }

            title.Font = new Font("Arial", 12, FontStyle.Bold | FontStyle.Italic);
            title.ForeColor = Color.White;
            title.BackColor = Color.MediumSeaGreen;
            title.TextAlign = ContentAlignment.MiddleCenter;
                

            playerX.Font = new Font("Arial", 12, FontStyle.Bold);
            playerX.ForeColor = Color.Black;
            playerX.BackColor = Color.White;
            playerX.AutoSize = false;
            playerX.TextAlign = ContentAlignment.MiddleCenter;
            playerX.Width = 100;

            player0.Font = new Font("Arial", 12, FontStyle.Bold);
            player0.ForeColor = Color.Black;
            player0.BackColor = Color.White;
            player0.AutoSize = false;
            player0.TextAlign = ContentAlignment.MiddleCenter;
            player0.Width = 100;

            resultX.Font = new Font("Arial", 12, FontStyle.Bold);
            resultX.ForeColor = Color.Black;
            resultX.BackColor = Color.White;
            resultX.AutoSize = false;
            resultX.TextAlign = ContentAlignment.MiddleCenter;
            resultX.Width = 100;

            result0.Font = new Font("Arial", 12, FontStyle.Bold);
            result0.ForeColor = Color.Black;
            result0.BackColor = Color.White;
            result0.AutoSize = false;
            result0.TextAlign = ContentAlignment.MiddleCenter;
            result0.Width = 100;

            VS.Font = new Font("Arial", 12, FontStyle.Bold);
            VS.ForeColor = Color.Black;
            VS.BackColor = Color.White;
            VS.AutoSize = false;
            VS.TextAlign = ContentAlignment.MiddleCenter;
            VS.Width = 100;

            newGame.Font = new Font("Arial", 9, FontStyle.Bold);
            newGame.ForeColor = Color.White;
            newGame.BackColor = Color.FromArgb(255, 0, 128, 128);
            newGame.AutoSize = false;
            newGame.TextAlign = ContentAlignment.MiddleCenter;
            newGame.Width = 100;

            resetResult.Font = new Font("Arial", 9, FontStyle.Bold);
            resetResult.ForeColor = Color.White;
            resetResult.BackColor = Color.FromArgb(255, 0, 128, 128); 
            resetResult.AutoSize = false;
            resetResult.TextAlign = ContentAlignment.MiddleCenter;
            resetResult.Width = 100;

            exitForm.BackColor = Color.Red;
            exitForm.Font = new Font("Arial", 10, FontStyle.Bold);
            exitForm.TextAlign = ContentAlignment.MiddleCenter;
            exitForm.ForeColor = Color.White;
        }
        private void newGame_Click(object sender, EventArgs e)
        {
            resetGame();

        }
        private void resetResult_Click(object sender, EventArgs e)
        {
            resultX.Text = "0";
            result0.Text = "0";
        }
        private void exitForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}