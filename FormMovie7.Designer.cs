namespace WinFormsFinalProject
{
    partial class FormMovie7
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
            lblPrice7 = new Label();
            txtPrice7 = new TextBox();
            txtStock7 = new TextBox();
            lblStock7 = new Label();
            btnAddCartMovie7 = new Button();
            rtxtMovie7 = new RichTextBox();
            pictureBox_Movie7 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Movie7).BeginInit();
            SuspendLayout();
            // 
            // lblPrice7
            // 
            lblPrice7.AutoSize = true;
            lblPrice7.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice7.ImageAlign = ContentAlignment.TopCenter;
            lblPrice7.Location = new Point(616, 69);
            lblPrice7.Name = "lblPrice7";
            lblPrice7.Size = new Size(32, 37);
            lblPrice7.TabIndex = 39;
            lblPrice7.Text = "$";
            lblPrice7.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPrice7
            // 
            txtPrice7.BorderStyle = BorderStyle.None;
            txtPrice7.Enabled = false;
            txtPrice7.Location = new Point(654, 74);
            txtPrice7.Multiline = true;
            txtPrice7.Name = "txtPrice7";
            txtPrice7.Size = new Size(57, 32);
            txtPrice7.TabIndex = 38;
            // 
            // txtStock7
            // 
            txtStock7.BorderStyle = BorderStyle.None;
            txtStock7.Enabled = false;
            txtStock7.Location = new Point(675, 194);
            txtStock7.Multiline = true;
            txtStock7.Name = "txtStock7";
            txtStock7.Size = new Size(45, 23);
            txtStock7.TabIndex = 37;
            // 
            // lblStock7
            // 
            lblStock7.AutoSize = true;
            lblStock7.Location = new Point(617, 202);
            lblStock7.Name = "lblStock7";
            lblStock7.Size = new Size(52, 15);
            lblStock7.TabIndex = 36;
            lblStock7.Text = "Quedan:";
            // 
            // btnAddCartMovie7
            // 
            btnAddCartMovie7.BackColor = Color.DarkRed;
            btnAddCartMovie7.FlatAppearance.BorderSize = 0;
            btnAddCartMovie7.FlatAppearance.MouseDownBackColor = Color.White;
            btnAddCartMovie7.FlatAppearance.MouseOverBackColor = Color.Salmon;
            btnAddCartMovie7.FlatStyle = FlatStyle.Flat;
            btnAddCartMovie7.ForeColor = SystemColors.ControlLightLight;
            btnAddCartMovie7.Location = new Point(604, 237);
            btnAddCartMovie7.Name = "btnAddCartMovie7";
            btnAddCartMovie7.Size = new Size(132, 39);
            btnAddCartMovie7.TabIndex = 35;
            btnAddCartMovie7.Text = "Añadir al carrito";
            btnAddCartMovie7.UseVisualStyleBackColor = false;
            // 
            // rtxtMovie7
            // 
            rtxtMovie7.BackColor = Color.FromArgb(255, 224, 192);
            rtxtMovie7.BorderStyle = BorderStyle.None;
            rtxtMovie7.Enabled = false;
            rtxtMovie7.Location = new Point(226, 54);
            rtxtMovie7.Name = "rtxtMovie7";
            rtxtMovie7.ReadOnly = true;
            rtxtMovie7.Size = new Size(326, 240);
            rtxtMovie7.TabIndex = 34;
            rtxtMovie7.Text = "";
            // 
            // pictureBox_Movie7
            // 
            pictureBox_Movie7.Cursor = Cursors.Hand;
            pictureBox_Movie7.Image = Properties.Resources.prideAndPrej;
            pictureBox_Movie7.Location = new Point(32, 54);
            pictureBox_Movie7.Name = "pictureBox_Movie7";
            pictureBox_Movie7.Size = new Size(174, 236);
            pictureBox_Movie7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Movie7.TabIndex = 33;
            pictureBox_Movie7.TabStop = false;
            // 
            // FormMovie7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPrice7);
            Controls.Add(txtPrice7);
            Controls.Add(txtStock7);
            Controls.Add(lblStock7);
            Controls.Add(btnAddCartMovie7);
            Controls.Add(rtxtMovie7);
            Controls.Add(pictureBox_Movie7);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMovie7";
            Text = "FormMovie7";
          
            ((System.ComponentModel.ISupportInitialize)pictureBox_Movie7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrice7;
        private TextBox txtPrice7;
        private TextBox txtStock7;
        private Label lblStock7;
        private Button btnAddCartMovie7;
        private RichTextBox rtxtMovie7;
        private PictureBox pictureBox_Movie7;
    }
}