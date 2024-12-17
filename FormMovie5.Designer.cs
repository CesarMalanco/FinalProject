namespace WinFormsFinalProject
{
    partial class FormMovie5
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
            lblPrice5 = new Label();
            txtPrice5 = new TextBox();
            txtStock5 = new TextBox();
            lblStock5 = new Label();
            btnAddCartMovie5 = new Button();
            rtxtMovie5 = new RichTextBox();
            pictureBox_Movie5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Movie5).BeginInit();
            SuspendLayout();
            // 
            // lblPrice5
            // 
            lblPrice5.AutoSize = true;
            lblPrice5.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice5.ImageAlign = ContentAlignment.TopCenter;
            lblPrice5.Location = new Point(619, 70);
            lblPrice5.Name = "lblPrice5";
            lblPrice5.Size = new Size(32, 37);
            lblPrice5.TabIndex = 25;
            lblPrice5.Text = "$";
            lblPrice5.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPrice5
            // 
            txtPrice5.BorderStyle = BorderStyle.None;
            txtPrice5.Enabled = false;
            txtPrice5.Location = new Point(657, 75);
            txtPrice5.Multiline = true;
            txtPrice5.Name = "txtPrice5";
            txtPrice5.Size = new Size(57, 32);
            txtPrice5.TabIndex = 24;
            // 
            // txtStock5
            // 
            txtStock5.BorderStyle = BorderStyle.None;
            txtStock5.Enabled = false;
            txtStock5.Location = new Point(678, 195);
            txtStock5.Multiline = true;
            txtStock5.Name = "txtStock5";
            txtStock5.Size = new Size(45, 23);
            txtStock5.TabIndex = 23;
            // 
            // lblStock5
            // 
            lblStock5.AutoSize = true;
            lblStock5.Location = new Point(620, 203);
            lblStock5.Name = "lblStock5";
            lblStock5.Size = new Size(52, 15);
            lblStock5.TabIndex = 22;
            lblStock5.Text = "Quedan:";
            // 
            // btnAddCartMovie5
            // 
            btnAddCartMovie5.BackColor = Color.DarkRed;
            btnAddCartMovie5.FlatAppearance.BorderSize = 0;
            btnAddCartMovie5.FlatAppearance.MouseDownBackColor = Color.White;
            btnAddCartMovie5.FlatAppearance.MouseOverBackColor = Color.Salmon;
            btnAddCartMovie5.FlatStyle = FlatStyle.Flat;
            btnAddCartMovie5.ForeColor = SystemColors.ControlLightLight;
            btnAddCartMovie5.Location = new Point(607, 238);
            btnAddCartMovie5.Name = "btnAddCartMovie5";
            btnAddCartMovie5.Size = new Size(132, 39);
            btnAddCartMovie5.TabIndex = 21;
            btnAddCartMovie5.Text = "Añadir al carrito";
            btnAddCartMovie5.UseVisualStyleBackColor = false;
            // 
            // rtxtMovie5
            // 
            rtxtMovie5.BackColor = Color.FromArgb(255, 224, 192);
            rtxtMovie5.BorderStyle = BorderStyle.None;
            rtxtMovie5.Enabled = false;
            rtxtMovie5.Location = new Point(228, 54);
            rtxtMovie5.Name = "rtxtMovie5";
            rtxtMovie5.ReadOnly = true;
            rtxtMovie5.Size = new Size(326, 240);
            rtxtMovie5.TabIndex = 20;
            rtxtMovie5.Text = "";
            // 
            // pictureBox_Movie5
            // 
            pictureBox_Movie5.Cursor = Cursors.Hand;
            pictureBox_Movie5.Image = Properties.Resources.goneGirl;
            pictureBox_Movie5.Location = new Point(32, 54);
            pictureBox_Movie5.Name = "pictureBox_Movie5";
            pictureBox_Movie5.Size = new Size(174, 236);
            pictureBox_Movie5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Movie5.TabIndex = 19;
            pictureBox_Movie5.TabStop = false;
            // 
            // FormMovie5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPrice5);
            Controls.Add(txtPrice5);
            Controls.Add(txtStock5);
            Controls.Add(lblStock5);
            Controls.Add(btnAddCartMovie5);
            Controls.Add(rtxtMovie5);
            Controls.Add(pictureBox_Movie5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMovie5";
            Text = "FormMovie5";
            ((System.ComponentModel.ISupportInitialize)pictureBox_Movie5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrice5;
        private TextBox txtPrice5;
        private TextBox txtStock5;
        private Label lblStock5;
        private Button btnAddCartMovie5;
        private RichTextBox rtxtMovie5;
        private PictureBox pictureBox_Movie5;
    }
}