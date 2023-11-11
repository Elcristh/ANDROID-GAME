namespace Project_itec_103
{
    partial class Tictaktoe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tictaktoe));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            Resart = new Button();
            back = new Button();
            tiktoe = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Georgia", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Chartreuse;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(178, 23);
            label1.TabIndex = 0;
            label1.Text = "Player Wins – 0";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Chartreuse;
            label2.Location = new Point(522, 20);
            label2.Name = "label2";
            label2.Size = new Size(121, 23);
            label2.TabIndex = 1;
            label2.Text = "AI Wins – 0";
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(69, 86);
            button1.Name = "button1";
            button1.Size = new Size(158, 143);
            button1.TabIndex = 2;
            button1.Tag = "play";
            button1.Text = "?";
            button1.UseVisualStyleBackColor = true;
            button1.Click += playerClick;
            // 
            // button2
            // 
            button2.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(256, 86);
            button2.Name = "button2";
            button2.Size = new Size(158, 143);
            button2.TabIndex = 3;
            button2.Tag = "play";
            button2.Text = "?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += playerClick;
            // 
            // button3
            // 
            button3.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(441, 86);
            button3.Name = "button3";
            button3.Size = new Size(158, 143);
            button3.TabIndex = 4;
            button3.Tag = "play";
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            button3.Click += playerClick;
            // 
            // button4
            // 
            button4.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(69, 250);
            button4.Name = "button4";
            button4.Size = new Size(158, 143);
            button4.TabIndex = 5;
            button4.Tag = "play";
            button4.Text = "?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += playerClick;
            // 
            // button5
            // 
            button5.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(256, 250);
            button5.Name = "button5";
            button5.Size = new Size(158, 143);
            button5.TabIndex = 6;
            button5.Tag = "play";
            button5.Text = "?";
            button5.UseVisualStyleBackColor = true;
            button5.Click += playerClick;
            // 
            // button6
            // 
            button6.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(441, 250);
            button6.Name = "button6";
            button6.Size = new Size(158, 143);
            button6.TabIndex = 7;
            button6.Tag = "play";
            button6.Text = "?";
            button6.UseVisualStyleBackColor = true;
            button6.Click += playerClick;
            // 
            // button7
            // 
            button7.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(69, 417);
            button7.Name = "button7";
            button7.Size = new Size(158, 143);
            button7.TabIndex = 8;
            button7.Tag = "play";
            button7.Text = "?";
            button7.UseVisualStyleBackColor = true;
            button7.Click += playerClick;
            // 
            // button8
            // 
            button8.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(256, 417);
            button8.Name = "button8";
            button8.Size = new Size(158, 143);
            button8.TabIndex = 9;
            button8.Tag = "play";
            button8.Text = "?";
            button8.UseVisualStyleBackColor = true;
            button8.Click += playerClick;
            // 
            // button9
            // 
            button9.Font = new Font("Cambria", 36F, FontStyle.Bold, GraphicsUnit.Point);
            button9.Location = new Point(441, 417);
            button9.Name = "button9";
            button9.Size = new Size(158, 143);
            button9.TabIndex = 10;
            button9.Tag = "play";
            button9.Text = "?";
            button9.UseVisualStyleBackColor = true;
            button9.Click += playerClick;
            // 
            // Resart
            // 
            Resart.BackColor = Color.CadetBlue;
            Resart.FlatAppearance.BorderSize = 0;
            Resart.FlatStyle = FlatStyle.Flat;
            Resart.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Resart.ForeColor = Color.White;
            Resart.Location = new Point(23, 614);
            Resart.Name = "Resart";
            Resart.Size = new Size(127, 35);
            Resart.TabIndex = 11;
            Resart.Text = "RESTART";
            Resart.UseVisualStyleBackColor = false;
            Resart.Click += restartGameplayer;
            // 
            // back
            // 
            back.BackColor = Color.CadetBlue;
            back.FlatAppearance.BorderSize = 0;
            back.FlatStyle = FlatStyle.Flat;
            back.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            back.ForeColor = Color.White;
            back.Location = new Point(519, 614);
            back.Name = "back";
            back.Size = new Size(124, 35);
            back.TabIndex = 12;
            back.Text = "QUIT";
            back.UseVisualStyleBackColor = false;
            back.Click += back_Click;
            // 
            // tiktoe
            // 
            tiktoe.Interval = 1000;
            tiktoe.Tick += gametimer;
            // 
            // Tictaktoe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(671, 679);
            Controls.Add(back);
            Controls.Add(Resart);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Tictaktoe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tictaktoe";
            Load += Tictaktoe_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button Resart;
        private Button back;
        private System.Windows.Forms.Timer tiktoe;
    }
}