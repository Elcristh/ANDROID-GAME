namespace Project_itec_103
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            start = new Button();
            quit = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // start
            // 
            start.BackColor = Color.CadetBlue;
            start.FlatAppearance.BorderSize = 0;
            start.FlatStyle = FlatStyle.Flat;
            start.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            start.ForeColor = Color.White;
            start.Location = new Point(116, 263);
            start.Name = "start";
            start.Size = new Size(100, 40);
            start.TabIndex = 0;
            start.Text = "Start";
            start.UseVisualStyleBackColor = false;
            start.Click += start_Click;
            // 
            // quit
            // 
            quit.BackColor = Color.CadetBlue;
            quit.FlatAppearance.BorderSize = 0;
            quit.FlatStyle = FlatStyle.Flat;
            quit.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            quit.ForeColor = Color.White;
            quit.Location = new Point(116, 335);
            quit.Name = "quit";
            quit.Size = new Size(100, 38);
            quit.TabIndex = 1;
            quit.Text = "Quit";
            quit.UseVisualStyleBackColor = false;
            quit.Click += quit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(282, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(534, 481);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(321, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(479, 446);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Footlight MT Light", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Lavender;
            label1.Location = new Point(12, 174);
            label1.Name = "label1";
            label1.Size = new Size(318, 53);
            label1.TabIndex = 4;
            label1.Text = "LUMINANCE";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(-1, 435);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(801, 23);
            progressBar1.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 437);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(quit);
            Controls.Add(start);
            DoubleBuffered = true;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button start;
        private Button quit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}