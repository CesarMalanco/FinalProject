namespace WinFormsFinalProject
{
    partial class FormMovie4
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
            lblPrice4 = new Label();
            txtPrice4 = new TextBox();
            txtStock4 = new TextBox();
            lblStock4 = new Label();
            btnAddCartMovie4 = new Button();
            rtxtMovie4 = new RichTextBox();
            pictureBox_Movie4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Movie4).BeginInit();
            SuspendLayout();
            // 
            // lblPrice4
            // 
            lblPrice4.AutoSize = true;
            lblPrice4.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice4.ImageAlign = ContentAlignment.TopCenter;
            lblPrice4.Location = new Point(617, 74);
            lblPrice4.Name = "lblPrice4";
            lblPrice4.Size = new Size(32, 37);
            lblPrice4.TabIndex = 18;
            lblPrice4.Text = "$";
            lblPrice4.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPrice4
            // 
            txtPrice4.BorderStyle = BorderStyle.None;
            txtPrice4.Enabled = false;
            txtPrice4.Location = new Point(655, 79);
            txtPrice4.Multiline = true;
            txtPrice4.Name = "txtPrice4";
            txtPrice4.Size = new Size(57, 32);
            txtPrice4.TabIndex = 17;
            // 
            // txtStock4
            // 
            txtStock4.BorderStyle = BorderStyle.None;
            txtStock4.Enabled = false;
            txtStock4.Location = new Point(676, 199);
            txtStock4.Multiline = true;
            txtStock4.Name = "txtStock4";
            txtStock4.Size = new Size(45, 23);
            txtStock4.TabIndex = 16;
            // 
            // lblStock4
            // 
            lblStock4.AutoSize = true;
            lblStock4.Location = new Point(618, 207);
            lblStock4.Name = "lblStock4";
            lblStock4.Size = new Size(52, 15);
            lblStock4.TabIndex = 15;
            lblStock4.Text = "Quedan:";
            // 
            // btnAddCartMovie4
            // 
            btnAddCartMovie4.BackColor = Color.DarkRed;
            btnAddCartMovie4.FlatAppearance.BorderSize = 0;
            btnAddCartMovie4.FlatAppearance.MouseDownBackColor = Color.White;
            btnAddCartMovie4.FlatAppearance.MouseOverBackColor = Color.Salmon;
            btnAddCartMovie4.FlatStyle = FlatStyle.Flat;
            btnAddCartMovie4.ForeColor = SystemColors.ControlLightLight;
            btnAddCartMovie4.Location = new Point(605, 242);
            btnAddCartMovie4.Name = "btnAddCartMovie4";
            btnAddCartMovie4.Size = new Size(132, 39);
            btnAddCartMovie4.TabIndex = 14;
            btnAddCartMovie4.Text = "Añadir al carrito";
            btnAddCartMovie4.UseVisualStyleBackColor = false;
            // 
            // rtxtMovie4
            // 
            rtxtMovie4.BackColor = Color.FromArgb(255, 224, 192);
            rtxtMovie4.BorderStyle = BorderStyle.None;
            rtxtMovie4.Enabled = false;
            rtxtMovie4.Location = new Point(227, 54);
            rtxtMovie4.Name = "rtxtMovie4";
            rtxtMovie4.ReadOnly = true;
            rtxtMovie4.Size = new Size(326, 240);
            rtxtMovie4.TabIndex = 13;
            rtxtMovie4.Text = "";
            // 
            // pictureBox_Movie4
            // 
            pictureBox_Movie4.Cursor = Cursors.Hand;
            pictureBox_Movie4.Image = WinFormsFinalProyect.Properties.Resources.lalaLand;
            pictureBox_Movie4.Location = new Point(32, 54);
            pictureBox_Movie4.Name = "pictureBox_Movie4";
            pictureBox_Movie4.Size = new Size(174, 236);
            pictureBox_Movie4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Movie4.TabIndex = 12;
            pictureBox_Movie4.TabStop = false;
            // 
            // FormMovie4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPrice4);
            Controls.Add(txtPrice4);
            Controls.Add(txtStock4);
            Controls.Add(lblStock4);
            Controls.Add(btnAddCartMovie4);
            Controls.Add(rtxtMovie4);
            Controls.Add(pictureBox_Movie4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMovie4";
            Text = "FormMovie4";
            ((System.ComponentModel.ISupportInitialize)pictureBox_Movie4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrice4;
        private TextBox txtPrice4;
        private TextBox txtStock4;
        private Label lblStock4;
        private Button btnAddCartMovie4;
        private RichTextBox rtxtMovie4;
        private PictureBox pictureBox_Movie4;
    }
}