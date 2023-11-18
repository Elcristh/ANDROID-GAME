using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_itec_103
{
    public partial class Form1 : Form
    {
        public static string username, password;
        public Form1()

        {

            InitializeComponent();
            username = "DannielleAngelKim";
            password = "12345678";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Thien Kim Nguyen\Downloads\soundbutton.wav");
            splayer.Play();
            if (Username.Text.Trim() == username && Password.Text.Trim() == password)
            {
                string MessageBoxTitle = "Login";
                string MessageBoxContent = "Logged in Succesfully!";

                DialogResult dialogResult = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    this.Hide();
                    Form2 frm2 = new Form2();
                    frm2.Show();
                }
                else if (dialogResult == DialogResult.No)
                {
                    this.Close();
                }


            }
            else
            {
                string message = "Wrong Username or Password!";
                string title = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.OK)
                {
                    this.Show();
                }

            }
        }

        private void Resert_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Thien Kim Nguyen\Downloads\soundbutton.wav");
            splayer.Play();
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void forgotpass_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\Thien Kim Nguyen\Downloads\soundbutton.wav");
            splayer.Play();
            Form1 form = new Form1();
            this.Hide();
            FormForgotPassword ffp = new FormForgotPassword();
            ffp.ShowDialog();
        }
    }
}

