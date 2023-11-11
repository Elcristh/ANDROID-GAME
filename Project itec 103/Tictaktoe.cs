using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using static Project_itec_103.Tictaktoe;


namespace Project_itec_103
{
    public partial class Tictaktoe : Form
    {
        public enum Player
        {
            X, O
        }
        Player currentPlayer;

        List<Button> buttons;

        Random rand = new Random();

        int playerWins = 0;

        int computerWins = 0;
        public Tictaktoe()
        {
            InitializeComponent();
            resetGame();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
            MiniGame form = new MiniGame();
            form.Show();
        }

        private void gametimer(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count);
                buttons[index].Enabled = false;

                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = System.Drawing.Color.PowderBlue;
                buttons.RemoveAt(index);
                Check();
                tiktoe.Stop();
            }
        }

        private void playerClick(object sender, EventArgs e)
        {
            var button = (Button)sender;
            currentPlayer = Player.X;
            button.Text = currentPlayer.ToString();
            button.Enabled = false;
            button.BackColor = System.Drawing.Color.SpringGreen;
            buttons.Remove(button);
            Check();
            tiktoe.Start();
        }

        private void restartGameplayer(object sender, EventArgs e)
        {
            resetGame();
        }
        private void loadbuttons()
        {
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button8, button9 };
        }
        private void resetGame()
        {
            foreach (Control X in this.Controls)
            {
                if (X is Button && X.Tag == "play")
                {
                    ((Button)X).Enabled = true;
                    ((Button)X).Text = "?";
                    ((Button)X).BackColor = default(Color);
                }
            }
            loadbuttons();
        }
        private void Check()
        {
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button9.Text == "X" && button8.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                tiktoe.Stop();
                string message = "Congatulation! Player Wins";
                string title = "Claim";
                MessageBox.Show(message, title);
                playerWins++;
                label1.Text = "Player Wins- " + playerWins;
                resetGame();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
            || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
            || button7.Text == "O" && button9.Text == "O" && button8.Text == "O"
            || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
            || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
            || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
            || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
            || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                tiktoe.Stop();
                string message = "Congatulation! Al Wins";
                string title = "Claim";
                MessageBox.Show(message, title);
                computerWins++;
                label2.Text = "AI Wins- " + computerWins;
                resetGame();
            }
        }

        private void Tictaktoe_Load(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Thien Kim Nguyen\Downloads\secongame.wav");
            splayer.Play();
        }
    }
}
