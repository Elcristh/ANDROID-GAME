namespace Project_itec_103
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            forgotpass = new Label();
            label2 = new Label();
            label1 = new Label();
            Resert = new Button();
            Login = new Button();
            Password = new TextBox();
            Username = new TextBox();
            Message = new Label();
            SuspendLayout();
            // 
            // forgotpass
            // 
            forgotpass.AutoSize = true;
            forgotpass.BackColor = Color.Transparent;
            forgotpass.Font = new Font("Californian FB", 9.75F, FontStyle.Underline, GraphicsUnit.Point);
            forgotpass.ForeColor = Color.FromArgb(255, 255, 128);
            forgotpass.Location = new Point(480, 264);
            forgotpass.Name = "forgotpass";
            forgotpass.Size = new Size(96, 16);
            forgotpass.TabIndex = 18;
            forgotpass.Text = "Forget Password?";
            forgotpass.Click += forgotpass_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Desktop;
            label2.Location = new Point(181, 239);
            label2.Name = "label2";
            label2.Size = new Size(129, 31);
            label2.TabIndex = 17;
            label2.Text = "Passwords:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(181, 179);
            label1.Name = "label1";
            label1.Size = new Size(129, 31);
            label1.TabIndex = 16;
            label1.Text = "Username: ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Resert
            // 
            Resert.BackColor = Color.CadetBlue;
            Resert.FlatAppearance.BorderSize = 0;
            Resert.FlatStyle = FlatStyle.Flat;
            Resert.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Resert.ForeColor = Color.White;
            Resert.Location = new Point(316, 340);
            Resert.Margin = new Padding(3, 2, 3, 2);
            Resert.Name = "Resert";
            Resert.Size = new Size(101, 35);
            Resert.TabIndex = 15;
            Resert.Text = "Clear";
            Resert.UseVisualStyleBackColor = false;
            Resert.Click += Resert_Click;
            // 
            // Login
            // 
            Login.BackColor = Color.CadetBlue;
            Login.FlatAppearance.BorderSize = 0;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Login.ForeColor = Color.White;
            Login.Location = new Point(459, 340);
            Login.Margin = new Padding(3, 2, 3, 2);
            Login.Name = "Login";
            Login.Size = new Size(105, 35);
            Login.TabIndex = 14;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // Password
            // 
            Password.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Password.Location = new Point(316, 241);
            Password.Margin = new Padding(3, 2, 3, 2);
            Password.Multiline = true;
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(260, 21);
            Password.TabIndex = 13;
            // 
            // Username
            // 
            Username.Font = new Font("Palatino Linotype", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(316, 185);
            Username.Margin = new Padding(3, 2, 3, 2);
            Username.Multiline = true;
            Username.Name = "Username";
            Username.Size = new Size(260, 25);
            Username.TabIndex = 12;
            // 
            // Message
            // 
            Message.BackColor = Color.Transparent;
            Message.Font = new Font("Copperplate Gothic Bold", 45F, FontStyle.Regular, GraphicsUnit.Point);
            Message.ForeColor = Color.FloralWhite;
            Message.Location = new Point(181, 64);
            Message.Name = "Message";
            Message.Size = new Size(453, 75);
            Message.TabIndex = 11;
            Message.Text = "Welcome";
            Message.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(forgotpass);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Resert);
            Controls.Add(Login);
            Controls.Add(Password);
            Controls.Add(Username);
            Controls.Add(Message);
            DoubleBuffered = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label forgotpass;
        private Label label2;
        private Label label1;
        private Button Resert;
        private Button Login;
        private TextBox Password;
        private TextBox Username;
        private Label Message;
    }
}