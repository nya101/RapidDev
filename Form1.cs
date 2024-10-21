namespace MyFirstProject
{

    public partial class Form1 : Form
    {
        private bool isPlayerX = true; // True for player 'X', False for player 'O'
        private int turnCount = 0;     // Counts number of turns taken
        private Button[,] buttons = new Button[3, 3]; // Initialize buttons as an empty array

        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        // This nitialize the game and set up buttons
        private void InitializeGame()
        {
            buttons = new Button[3, 3] {
                { button1, button2, button3 },
                { button4, button5, button6 },
                { button7, button8, button9 }
            };

            // This attaches the ButtonClick event handler to all the buttons
            foreach (Button btn in buttons)
            {
                btn.Click += ButtonClick;
            }

            lblStatus.Text = "Player X's turn";
        }

        // Handles the  button click event
        private void ButtonClick(object? sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            if (clickedButton == null) return;

            // Check if the button has already been clicked
            if (clickedButton.Text != "")
                return;

            // Set the player's symbol (X or O)
            clickedButton.Text = isPlayerX ? "X" : "O";
            turnCount++;

            if (CheckWinner())
            {
                lblStatus.Text = $"Player {(isPlayerX ? "X" : "O")} wins!";
                DisableButtons();
                return;
            }

            // Check for a draw
            if (turnCount == 9)
            {
                lblStatus.Text = "It's a draw!";
                return;
            }

            // Switch turns
            isPlayerX = !isPlayerX;
            lblStatus.Text = $"Player {(isPlayerX ? "X" : "O")}'s turn";
        }

        // Checks for a winner
        private bool CheckWinner()
        {
            // This  function  compares three buttons for equal labels 'X' or 'O'
            bool AreButtonsEqual(Button b1, Button b2, Button b3)
            {
                return b1.Text != "" && b1.Text == b2.Text && b2.Text == b3.Text;
            }

            // Checks rows and columns
            for (int i = 0; i < 3; i++)
            {
                if (AreButtonsEqual(buttons[i, 0], buttons[i, 1], buttons[i, 2]) ||
                    AreButtonsEqual(buttons[0, i], buttons[1, i], buttons[2, i]))
                {
                    return true;
                }
            }

            // Check diagonals
            if (AreButtonsEqual(buttons[0, 0], buttons[1, 1], buttons[2, 2]) ||
                AreButtonsEqual(buttons[0, 2], buttons[1, 1], buttons[2, 0]))
            {
                return true;
            }

            return false;
        }

        // Disable all buttons after the game ends
        private void DisableButtons()
        {
            foreach (Button btn in buttons)
            {
                btn.Enabled = false;
            }
        }

        // Resets the game
        private void btnReset_Click(object sender, EventArgs e)
        {
            turnCount = 0;
            isPlayerX = true;

            foreach (Button btn in buttons)
            {
                btn.Text = "";
                btn.Enabled = true;
            }

            lblStatus.Text = "Player X's turn";  // Resets the game labels 'X' or 'Y'
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }



        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
