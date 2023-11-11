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
    public partial class NewPassWord : Form
    {
        public NewPassWord()
        {
            InitializeComponent();
        }

        private void change_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Thien Kim Nguyen\Downloads\soundbutton.wav");
            splayer.Play();
            if (newpass.Text.Trim() == firmpass.Text.Trim())
            {
                string message = "Changed p[assword successfully!";
                string title = "Success";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    Form1.password = firmpass.Text;
                    this.Hide();
                    Form1 form = new Form1();
                    form.Show();

                }
            }
        }
        private void Resert_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Thien Kim Nguyen\Downloads\soundbutton.wav");
            splayer.Play();
            NewPassWord form = new NewPassWord();
            form.Show();
            this.Hide();
        }

        private void firmpass_TextChanged(object sender, EventArgs e)
        {

        }
    }

}

