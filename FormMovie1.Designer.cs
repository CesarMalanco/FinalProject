namespace WinFormsFinalProject
{
    partial class FormMovie1
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
            pictureBox_Movie1 = new PictureBox();
            rtxtMovie1 = new RichTextBox();
            btnAddCartMovie1 = new Button();
            lblStock1 = new Label();
            txtStock1 = new TextBox();
            txtPrice1 = new TextBox();
            lblPrice1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Movie1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_Movie1
            // 
            pictureBox_Movie1.Cursor = Cursors.Hand;
            pictureBox_Movie1.Image = Properties.Resources.backToTheFuture;
            pictureBox_Movie1.Location = new Point(34, 52);
            pictureBox_Movie1.Name = "pictureBox_Movie1";
            pictureBox_Movie1.Size = new Size(174, 236);
            pictureBox_Movie1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Movie1.TabIndex = 2;
            pictureBox_Movie1.TabStop = false;
            // 
            // rtxtMovie1
            // 
            rtxtMovie1.BackColor = Color.FromArgb(255, 224, 192);
            rtxtMovie1.BorderStyle = BorderStyle.None;
            rtxtMovie1.Enabled = false;
            rtxtMovie1.Location = new Point(231, 49);
            rtxtMovie1.Name = "rtxtMovie1";
            rtxtMovie1.ReadOnly = true;
            rtxtMovie1.Size = new Size(326, 240);
            rtxtMovie1.TabIndex = 6;
            rtxtMovie1.Text = "";
            // 
            // btnAddCartMovie1
            // 
            btnAddCartMovie1.BackColor = Color.DarkRed;
            btnAddCartMovie1.FlatAppearance.BorderSize = 0;
            btnAddCartMovie1.FlatAppearance.MouseDownBackColor = Color.White;
            btnAddCartMovie1.FlatAppearance.MouseOverBackColor = Color.Salmon;
            btnAddCartMovie1.FlatStyle = FlatStyle.Flat;
            btnAddCartMovie1.ForeColor = SystemColors.ControlLightLight;
            btnAddCartMovie1.Location = new Point(609, 238);
            btnAddCartMovie1.Name = "btnAddCartMovie1";
            btnAddCartMovie1.Size = new Size(132, 39);
            btnAddCartMovie1.TabIndex = 7;
            btnAddCartMovie1.Text = "Añadir al carrito";
            btnAddCartMovie1.UseVisualStyleBackColor = false;
            // 
            // lblStock1
            // 
            lblStock1.AutoSize = true;
            lblStock1.Location = new Point(622, 203);
            lblStock1.Name = "lblStock1";
            lblStock1.Size = new Size(52, 15);
            lblStock1.TabIndex = 8;
            lblStock1.Text = "Quedan:";
            // 
            // txtStock1
            // 
            txtStock1.BorderStyle = BorderStyle.None;
            txtStock1.Enabled = false;
            txtStock1.Location = new Point(680, 195);
            txtStock1.Multiline = true;
            txtStock1.Name = "txtStock1";
            txtStock1.Size = new Size(45, 23);
            txtStock1.TabIndex = 9;
            // 
            // txtPrice1
            // 
            txtPrice1.BorderStyle = BorderStyle.None;
            txtPrice1.Enabled = false;
            txtPrice1.Location = new Point(659, 75);
            txtPrice1.Multiline = true;
            txtPrice1.Name = "txtPrice1";
            txtPrice1.Size = new Size(57, 32);
            txtPrice1.TabIndex = 10;
            // 
            // lblPrice1
            // 
            lblPrice1.AutoSize = true;
            lblPrice1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice1.ImageAlign = ContentAlignment.TopCenter;
            lblPrice1.Location = new Point(621, 70);
            lblPrice1.Name = "lblPrice1";
            lblPrice1.Size = new Size(32, 37);
            lblPrice1.TabIndex = 11;
            lblPrice1.Text = "$";
            lblPrice1.TextAlign = ContentAlignment.TopRight;
            // 
            // FormMovie1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 508);
            Controls.Add(lblPrice1);
            Controls.Add(txtPrice1);
            Controls.Add(txtStock1);
            Controls.Add(lblStock1);
            Controls.Add(btnAddCartMovie1);
            Controls.Add(rtxtMovie1);
            Controls.Add(pictureBox_Movie1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMovie1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMovie1";
            ((System.ComponentModel.ISupportInitialize)pictureBox_Movie1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_Movie1;
        private RichTextBox rtxtMovie1;
        private Button btnAddCartMovie1;
        private Label lblStock1;
        private TextBox txtStock1;
        private TextBox txtPrice1;
        private Label lblPrice1;
    }
}