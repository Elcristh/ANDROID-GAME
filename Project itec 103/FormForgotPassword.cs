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
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
        }

        private void Resert_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Thien Kim Nguyen\Downloads\soundbutton.wav");
            splayer.Play();
            FormForgotPassword form = new FormForgotPassword();
            form.Show();
            this.Hide();
        }

        private void nnext_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Thien Kim Nguyen\Downloads\soundbutton.wav");
            splayer.Play();
            if (CNICB.Text.Trim() == "12345-678910-1112" && Dateofbirth.Text == "Friday, 19 April 2002")
            {
                string MessageBoxTitle = "Forgot";
                string MessageBoxContent = "Succesfully!";

                DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    this.Hide();
                    NewPassWord form = new NewPassWord();
                    form.ShowDialog();
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Show();
                }
            }
            else
            {
                string message = "Invalid CNIC or Date of Birth!";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    this.Show();
                }
            }
        }
    }
}
