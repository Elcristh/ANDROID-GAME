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
    public partial class MiniGame : Form
    {
        public MiniGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Thien Kim Nguyen\Downloads\soundbutton.wav");
            splayer.Play();
            this.Hide();
            Flabbybird form = new Flabbybird();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Thien Kim Nguyen\Downloads\soundbutton.wav");
            splayer.Play();
            this.Hide();
            Tictaktoe form = new Tictaktoe();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Thien Kim Nguyen\Downloads\soundbutton.wav");
            splayer.Play();
            this.Hide();
            CatchingHeart form = new CatchingHeart();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Thien Kim Nguyen\Downloads\soundbutton.wav");
            splayer.Play();
            string MessageBoxTitle = "Back";
            string MessageBoxContent = "Do you want to go back? ";

            DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Form2 form = new Form2();
                form.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                this.Show();
            }
        }
    }
}
