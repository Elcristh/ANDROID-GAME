namespace Project_itec_103
{
    partial class Flabbybird
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flabbybird));
            cutebird = new PictureBox();
            pipeup = new PictureBox();
            pipedown = new PictureBox();
            ground = new PictureBox();
            scorestext = new Label();
            scorestxt = new Label();
            Mess = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)cutebird).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pipedown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ground).BeginInit();
            SuspendLayout();
            // 
            // cutebird
            // 
            cutebird.BackColor = Color.Transparent;
            cutebird.Image = Properties.Resources.flygirl;
            cutebird.Location = new Point(44, 135);
            cutebird.Margin = new Padding(3, 2, 3, 2);
            cutebird.Name = "cutebird";
            cutebird.Size = new Size(119, 86);
            cutebird.SizeMode = PictureBoxSizeMode.StretchImage;
            cutebird.TabIndex = 13;
            cutebird.TabStop = false;
            // 
            // pipeup
            // 
            pipeup.BackColor = Color.Transparent;
            pipeup.Image = (Image)resources.GetObject("pipeup.Image");
            pipeup.Location = new Point(379, 258);
            pipeup.Margin = new Padding(3, 2, 3, 2);
            pipeup.Name = "pipeup";
            pipeup.Size = new Size(62, 64);
            pipeup.SizeMode = PictureBoxSizeMode.StretchImage;
            pipeup.TabIndex = 12;
            pipeup.TabStop = false;
            // 
            // pipedown
            // 
            pipedown.BackColor = Color.Transparent;
            pipedown.Image = (Image)resources.GetObject("pipedown.Image");
            pipedown.Location = new Point(590, -1);
            pipedown.Margin = new Padding(3, 2, 3, 2);
            pipedown.Name = "pipedown";
            pipedown.Size = new Size(55, 67);
            pipedown.SizeMode = PictureBoxSizeMode.StretchImage;
            pipedown.TabIndex = 11;
            pipedown.TabStop = false;
            // 
            // ground
            // 
            ground.Image = (Image)resources.GetObject("ground.Image");
            ground.Location = new Point(1, 317);
            ground.Margin = new Padding(3, 2, 3, 2);
            ground.Name = "ground";
            ground.Size = new Size(700, 41);
            ground.SizeMode = PictureBoxSizeMode.StretchImage;
            ground.TabIndex = 10;
            ground.TabStop = false;
            // 
            // scorestext
            // 
            scorestext.BackColor = Color.Transparent;
            scorestext.Font = new Font("Ravie", 15F, FontStyle.Bold, GraphicsUnit.Point);
            scorestext.ForeColor = Color.Cyan;
            scorestext.Location = new Point(121, 7);
            scorestext.Name = "scorestext";
            scorestext.Size = new Size(279, 25);
            scorestext.TabIndex = 9;
            // 
            // scorestxt
            // 
            scorestxt.AutoSize = true;
            scorestxt.Location = new Point(121, 11);
            scorestxt.Name = "scorestxt";
            scorestxt.Size = new Size(0, 15);
            scorestxt.TabIndex = 8;
            // 
            // Mess
            // 
            Mess.BackColor = Color.Transparent;
            Mess.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Mess.ForeColor = Color.Yellow;
            Mess.Location = new Point(12, 11);
            Mess.Name = "Mess";
            Mess.Size = new Size(103, 29);
            Mess.TabIndex = 7;
            Mess.Text = "Scores:";
            // 
            // gameTimer
            // 
            gameTimer.Interval = 10;
            gameTimer.Tick += gametimertick;
            // 
            // Flabbybird
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(702, 357);
            Controls.Add(cutebird);
            Controls.Add(pipeup);
            Controls.Add(pipedown);
            Controls.Add(ground);
            Controls.Add(scorestext);
            Controls.Add(scorestxt);
            Controls.Add(Mess);
            Name = "Flabbybird";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Flabbybird";
            Load += Flabbybird_Load;
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)cutebird).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipeup).EndInit();
            ((System.ComponentModel.ISupportInitialize)pipedown).EndInit();
            ((System.ComponentModel.ISupportInitialize)ground).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox cutebird;
        private PictureBox pipeup;
        private PictureBox pipedown;
        private PictureBox ground;
        private Label scorestext;
        private Label scorestxt;
        private Label Mess;
        private System.Windows.Forms.Timer gameTimer;
    }
}