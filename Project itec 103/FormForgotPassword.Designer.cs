namespace Project_itec_103
{
    partial class FormForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgotPassword));
            Resert = new Button();
            CNICB = new TextBox();
            nnext = new Button();
            label1 = new Label();
            Dateofbirth = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Resert
            // 
            Resert.BackColor = Color.CadetBlue;
            Resert.FlatAppearance.BorderSize = 0;
            Resert.FlatStyle = FlatStyle.Flat;
            Resert.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Resert.ForeColor = Color.White;
            Resert.Location = new Point(282, 325);
            Resert.Name = "Resert";
            Resert.Size = new Size(82, 30);
            Resert.TabIndex = 0;
            Resert.Text = "Clear";
            Resert.UseVisualStyleBackColor = false;
            Resert.Click += Resert_Click;
            // 
            // CNICB
            // 
            CNICB.Location = new Point(282, 198);
            CNICB.Multiline = true;
            CNICB.Name = "CNICB";
            CNICB.Size = new Size(244, 24);
            CNICB.TabIndex = 3;
            // 
            // nnext
            // 
            nnext.BackColor = Color.CadetBlue;
            nnext.FlatAppearance.BorderSize = 0;
            nnext.FlatStyle = FlatStyle.Flat;
            nnext.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nnext.ForeColor = Color.White;
            nnext.Location = new Point(424, 325);
            nnext.Name = "nnext";
            nnext.Size = new Size(75, 30);
            nnext.TabIndex = 5;
            nnext.Text = "Next";
            nnext.UseVisualStyleBackColor = false;
            nnext.Click += nnext_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(218, 198);
            label1.Name = "label1";
            label1.Size = new Size(58, 24);
            label1.TabIndex = 6;
            label1.Text = "CNIC";
            // 
            // Dateofbirth
            // 
            Dateofbirth.Location = new Point(282, 247);
            Dateofbirth.Name = "Dateofbirth";
            Dateofbirth.Size = new Size(242, 23);
            Dateofbirth.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(152, 246);
            label2.Name = "label2";
            label2.Size = new Size(124, 24);
            label2.TabIndex = 8;
            label2.Text = "Date of Birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Copperplate Gothic Bold", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(162, 84);
            label3.Name = "label3";
            label3.Size = new Size(486, 44);
            label3.TabIndex = 9;
            label3.Text = "FORGOT PASSWORD";
            // 
            // FormForgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Dateofbirth);
            Controls.Add(label1);
            Controls.Add(nnext);
            Controls.Add(CNICB);
            Controls.Add(Resert);
            DoubleBuffered = true;
            Name = "FormForgotPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormForgotPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Resert;
        private TextBox CNICB;
        private Button nnext;
        private Label label1;
        private DateTimePicker Dateofbirth;
        private Label label2;
        private Label label3;
    }
}