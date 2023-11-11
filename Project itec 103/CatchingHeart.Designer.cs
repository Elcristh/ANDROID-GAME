namespace Project_itec_103
{
    partial class CatchingHeart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatchingHeart));
            MISS = new Label();
            scores = new Label();
            cutegirl = new PictureBox();
            Heart = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)cutegirl).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Heart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // MISS
            // 
            MISS.BackColor = Color.Transparent;
            MISS.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            MISS.ForeColor = Color.Lime;
            MISS.Location = new Point(348, 20);
            MISS.Name = "MISS";
            MISS.Size = new Size(176, 25);
            MISS.TabIndex = 11;
            MISS.Text = "Miss: 0";
            // 
            // scores
            // 
            scores.BackColor = Color.Transparent;
            scores.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            scores.ForeColor = Color.Lime;
            scores.Location = new Point(37, 20);
            scores.Name = "scores";
            scores.Size = new Size(230, 25);
            scores.TabIndex = 10;
            scores.Tag = "rose1";
            scores.Text = "Catching:  0";
            // 
            // cutegirl
            // 
            cutegirl.BackColor = Color.Transparent;
            cutegirl.Image = Properties.Resources.cutegirl;
            cutegirl.Location = new Point(205, 398);
            cutegirl.Margin = new Padding(3, 2, 3, 2);
            cutegirl.Name = "cutegirl";
            cutegirl.Size = new Size(126, 117);
            cutegirl.SizeMode = PictureBoxSizeMode.StretchImage;
            cutegirl.TabIndex = 9;
            cutegirl.TabStop = false;
            // 
            // Heart
            // 
            Heart.BackColor = Color.Transparent;
            Heart.Image = (Image)resources.GetObject("Heart.Image");
            Heart.Location = new Point(90, 57);
            Heart.Margin = new Padding(3, 2, 3, 2);
            Heart.Name = "Heart";
            Heart.Size = new Size(72, 50);
            Heart.SizeMode = PictureBoxSizeMode.StretchImage;
            Heart.TabIndex = 8;
            Heart.TabStop = false;
            Heart.Tag = "heart";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.heart;
            pictureBox2.Location = new Point(382, 57);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "heart";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.heart;
            pictureBox1.Location = new Point(240, 57);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "heart";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += gameevent;
            // 
            // CatchingHeart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(536, 526);
            Controls.Add(MISS);
            Controls.Add(scores);
            Controls.Add(cutegirl);
            Controls.Add(Heart);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "CatchingHeart";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CatchingHeart";
            Load += CatchingHeart_Load;
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)cutegirl).EndInit();
            ((System.ComponentModel.ISupportInitialize)Heart).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label MISS;
        private Label scores;
        private PictureBox cutegirl;
        private PictureBox Heart;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer gameTimer;
    }
}