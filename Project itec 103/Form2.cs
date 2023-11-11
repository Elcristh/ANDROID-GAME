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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pictureBox2.Parent = pictureBox1;
            pictureBox2.Location =
                new Point(
                    pictureBox2.Location.X
                    - pictureBox1.Location.X,
                    pictureBox2.Location.Y
                    - pictureBox1.Location.Y);
        }

        private void quit_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Thien Kim Nguyen\Downloads\soundbutton.wav");
            splayer.Play();
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void start_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Thien Kim Nguyen\Downloads\soundbutton.wav");
            splayer.Play();
            int i;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;

            for (i = 0; i <= 200; i++)
            {
                progressBar1.Value = i;
            }
            this.Hide();
            string MessageBoxTitle = "Start";
            string MessageBoxContent = "Minigame(Y) or Story(N)?";

            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                MiniGame form = new MiniGame();
                form.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Hide();
                Story ffp = new Story();
                ffp.Show();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
