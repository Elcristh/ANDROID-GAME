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
    public partial class CatchingHeart : Form
    {
        bool goleft;
        bool goright;
        int speed = 8;
        int score = 0;
        int missed = 0;
        Random rndY = new Random();
        Random rndX = new Random();
        PictureBox splash = new PictureBox();
        public CatchingHeart()
        {
            InitializeComponent();
            reset();
        }

        private void CatchingHeart_Load(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Thien Kim Nguyen\Downloads\secongame.wav");
            splayer.Play();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {

                goleft = true;
            }
            if (e.KeyCode == Keys.Right)
            {

                goright = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {

                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {

                goright = false;
            }
        }

        private void gameevent(object sender, EventArgs e)
        {
            scores.Text = "Heart Caught: " + score;
            MISS.Text = "Heart Missed: " + missed;

            if (goleft == true && cutegirl.Left > 0)
            {

                cutegirl.Left -= 12;

                cutegirl.Image = Properties.Resources.cutegirl;
            }

            if (goright == true && cutegirl.Left + cutegirl.Width < this.ClientSize.Width)
            {

                cutegirl.Left += 12;

                cutegirl.Image = Properties.Resources.cutegirl;
            }

            foreach (Control X in this.Controls)
            {

                if (X is PictureBox && X.Tag == "heart")
                {

                    X.Top += speed;

                    if (X.Top + X.Height > this.ClientSize.Height)
                    {

                        splash.Image = Properties.Resources.SPLASHSTRAW;
                        splash.Location = X.Location;
                        splash.Height = 59;
                        splash.Width = 60;
                        splash.BackColor = System.Drawing.Color.Transparent;
                        this.Controls.Add(splash);
                        X.Top = rndY.Next(80, 300) * -1;
                        X.Left = rndX.Next(5, this.ClientSize.Width - X.Width);
                        missed++;
                        cutegirl.Image = Properties.Resources.cutegirl2;
                    }

                    if (X.Bounds.IntersectsWith(cutegirl.Bounds))
                    {
                        X.Top = rndY.Next(100, 300) * -1;
                        X.Left = rndX.Next(5, this.ClientSize.Width - X.Width);
                        score++;
                    }

                    if (score >= 20)
                    {
                        speed = 16;
                    }

                    if (missed > 5)
                    {
                        gameTimer.Stop();

                        string MessageBoxTitle = "GameOver";
                        string MessageBoxContent = "little girl lost cute hearts" + "\r\n" + "restart(Y) or Back the Main Minigame(N)";

                        DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogResult == DialogResult.Yes)
                        {
                            this.Close();
                            MiniGame form = new MiniGame();
                            form.Show();
                        }
                        else if (dialogResult == DialogResult.No)
                        {
                            reset();
                        }

                    }
                }
            }
        }
        private void reset()
        {
            foreach (Control X in this.Controls)
            {

                if (X is PictureBox && X.Tag == "heart")
                {

                    X.Top = rndY.Next(80, 300) * -1;
                    X.Left = rndX.Next(5, this.ClientSize.Width - X.Width);
                }
            }
            foreach (Control X in this.Controls)
            {

                if (X is PictureBox && X.Tag == "heart")
                {

                    X.Top = rndY.Next(80, 300) * -1;
                    X.Left = rndX.Next(5, this.ClientSize.Width - X.Width);
                }
            }
            cutegirl.Left = this.ClientSize.Width / 2;
            cutegirl.Image = Properties.Resources.cutegirl;
            score = 0;
            missed = 0;
            speed = 8;
            goleft = false;
            goright = false;
            gameTimer.Start();

        }
    }
}
