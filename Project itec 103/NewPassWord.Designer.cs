namespace Project_itec_103
{
    partial class NewPassWord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPassWord));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            change = new Button();
            newpass = new TextBox();
            Resert = new Button();
            firmpass = new TextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Copperplate Gothic Bold", 35.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(160, 59);
            label3.Name = "label3";
            label3.Size = new Size(484, 53);
            label3.TabIndex = 16;
            label3.Text = "Renew Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(160, 235);
            label2.Name = "label2";
            label2.Size = new Size(176, 24);
            label2.TabIndex = 15;
            label2.Text = "Confirm Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(186, 175);
            label1.Name = "label1";
            label1.Size = new Size(143, 24);
            label1.TabIndex = 13;
            label1.Text = "New Password:";
            // 
            // change
            // 
            change.BackColor = Color.CadetBlue;
            change.FlatAppearance.BorderSize = 0;
            change.FlatStyle = FlatStyle.Flat;
            change.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            change.ForeColor = Color.White;
            change.Location = new Point(504, 300);
            change.Name = "change";
            change.Size = new Size(75, 41);
            change.TabIndex = 12;
            change.Text = "Next";
            change.UseVisualStyleBackColor = false;
            change.Click += change_Click;
            // 
            // newpass
            // 
            newpass.Location = new Point(337, 174);
            newpass.Multiline = true;
            newpass.Name = "newpass";
            newpass.Size = new Size(262, 25);
            newpass.TabIndex = 11;
            // 
            // Resert
            // 
            Resert.BackColor = Color.CadetBlue;
            Resert.FlatAppearance.BorderSize = 0;
            Resert.FlatStyle = FlatStyle.Flat;
            Resert.Font = new Font("Cambria", 15F, FontStyle.Bold, GraphicsUnit.Point);
            Resert.ForeColor = Color.White;
            Resert.Location = new Point(337, 300);
            Resert.Name = "Resert";
            Resert.Size = new Size(75, 41);
            Resert.TabIndex = 10;
            Resert.Text = "Clear";
            Resert.UseVisualStyleBackColor = false;
            Resert.Click += Resert_Click;
            // 
            // firmpass
            // 
            firmpass.Location = new Point(337, 234);
            firmpass.Multiline = true;
            firmpass.Name = "firmpass";
            firmpass.Size = new Size(262, 25);
            firmpass.TabIndex = 17;
            firmpass.TextChanged += firmpass_TextChanged;
            // 
            // NewPassWord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(firmpass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(change);
            Controls.Add(newpass);
            Controls.Add(Resert);
            DoubleBuffered = true;
            Name = "NewPassWord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NewPassWord";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private Button change;
        private TextBox newpass;
        private Button Resert;
        private TextBox firmpass;
    }
}