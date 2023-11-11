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

namespace Project_itec_103
{
    public partial class Flabbybird : Form
    {
        int obstacleSpeed = 5;
        int gravity = 6;
        int score = 0;
        bool gameOver = false;
        public Flabbybird()
        {
            InitializeComponent();
            gameTimer.Start();
            RestarGame();
        }

        private void gametimertick(object sender, EventArgs e)
        {
            cutebird.Top += gravity;
            pipedown.Left -= obstacleSpeed;
            pipeup.Left -= obstacleSpeed;
            scorestext.Text = score.ToString();

            if (pipedown.Left < -150)
            {
                pipedown.Left = 950;

                score++;
            }


            if (pipeup.Left < -180)
            {
                pipeup.Left = 950;

                score++;
            }


            if (cutebird.Bounds.IntersectsWith(pipedown.Bounds) || cutebird.Bounds.IntersectsWith(pipeup.Bounds) || cutebird.Bounds.IntersectsWith(ground.Bounds) || cutebird.Top < -25)
            {
                endGame();
            }
            if (score > 10)
            {
                obstacleSpeed = 10;
            }
            else if (score > 20)
            {
                obstacleSpeed = 20;
            }

            if (cutebird.Top < -25)
            {
                endGame();
            }

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                gravity = 5;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                gravity = -5;
            }
        }

        private void endGame()
        {
            gameTimer.Stop();

            string MessageBoxTitle = "GameOver";

            string MessageBoxContent = "Back the Main Minigame(Y) or Resert Game(N)";

            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
                MiniGame form = new MiniGame();
                form.Show();
            }
            if (dialogResult == DialogResult.No)
            {
                RestarGame();
            }

            gameOver = true;

        }
        private void RestarGame()
        {
            gameOver = false;
            cutebird.Location = new Point(70, 208);
            pipeup.Left = 800;
            pipedown.Left = 1200;

            score = 0;
            obstacleSpeed = 8;
            gameTimer.Start();

        }

        private void Flabbybird_Load(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Thien Kim Nguyen\Downloads\FlabbyBird.wav");
            splayer.Play();
        }
    }
}
