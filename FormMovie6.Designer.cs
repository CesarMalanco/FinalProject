namespace WinFormsFinalProject
{
    partial class FormMovie6
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
            lblPrice6 = new Label();
            txtPrice6 = new TextBox();
            txtStock6 = new TextBox();
            lblStock6 = new Label();
            btnAddCartMovie6 = new Button();
            rtxtMovie6 = new RichTextBox();
            pictureBox_Movie6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Movie6).BeginInit();
            SuspendLayout();
            // 
            // lblPrice6
            // 
            lblPrice6.AutoSize = true;
            lblPrice6.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice6.ImageAlign = ContentAlignment.TopCenter;
            lblPrice6.Location = new Point(616, 68);
            lblPrice6.Name = "lblPrice6";
            lblPrice6.Size = new Size(32, 37);
            lblPrice6.TabIndex = 32;
            lblPrice6.Text = "$";
            lblPrice6.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPrice6
            // 
            txtPrice6.BorderStyle = BorderStyle.None;
            txtPrice6.Enabled = false;
            txtPrice6.Location = new Point(654, 73);
            txtPrice6.Multiline = true;
            txtPrice6.Name = "txtPrice6";
            txtPrice6.Size = new Size(57, 32);
            txtPrice6.TabIndex = 31;
            // 
            // txtStock6
            // 
            txtStock6.BorderStyle = BorderStyle.None;
            txtStock6.Enabled = false;
            txtStock6.Location = new Point(675, 193);
            txtStock6.Multiline = true;
            txtStock6.Name = "txtStock6";
            txtStock6.Size = new Size(45, 23);
            txtStock6.TabIndex = 30;
            // 
            // lblStock6
            // 
            lblStock6.AutoSize = true;
            lblStock6.Location = new Point(617, 201);
            lblStock6.Name = "lblStock6";
            lblStock6.Size = new Size(52, 15);
            lblStock6.TabIndex = 29;
            lblStock6.Text = "Quedan:";
            // 
            // btnAddCartMovie6
            // 
            btnAddCartMovie6.BackColor = Color.DarkRed;
            btnAddCartMovie6.FlatAppearance.BorderSize = 0;
            btnAddCartMovie6.FlatAppearance.MouseDownBackColor = Color.White;
            btnAddCartMovie6.FlatAppearance.MouseOverBackColor = Color.Salmon;
            btnAddCartMovie6.FlatStyle = FlatStyle.Flat;
            btnAddCartMovie6.ForeColor = SystemColors.ControlLightLight;
            btnAddCartMovie6.Location = new Point(604, 236);
            btnAddCartMovie6.Name = "btnAddCartMovie6";
            btnAddCartMovie6.Size = new Size(132, 39);
            btnAddCartMovie6.TabIndex = 28;
            btnAddCartMovie6.Text = "Añadir al carrito";
            btnAddCartMovie6.UseVisualStyleBackColor = false;
            // 
            // rtxtMovie6
            // 
            rtxtMovie6.BackColor = Color.FromArgb(255, 224, 192);
            rtxtMovie6.BorderStyle = BorderStyle.None;
            rtxtMovie6.Enabled = false;
            rtxtMovie6.Location = new Point(225, 52);
            rtxtMovie6.Name = "rtxtMovie6";
            rtxtMovie6.ReadOnly = true;
            rtxtMovie6.Size = new Size(326, 240);
            rtxtMovie6.TabIndex = 27;
            rtxtMovie6.Text = "";
            // 
            // pictureBox_Movie6
            // 
            pictureBox_Movie6.Cursor = Cursors.Hand;
            pictureBox_Movie6.Image =  WinFormsFinalProyect.Properties.Resources.shreck;
            pictureBox_Movie6.Location = new Point(34, 52);
            pictureBox_Movie6.Name = "pictureBox_Movie6";
            pictureBox_Movie6.Size = new Size(174, 236);
            pictureBox_Movie6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox_Movie6.TabIndex = 26;
            pictureBox_Movie6.TabStop = false;
            // 
            // FormMovie6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPrice6);
            Controls.Add(txtPrice6);
            Controls.Add(txtStock6);
            Controls.Add(lblStock6);
            Controls.Add(btnAddCartMovie6);
            Controls.Add(rtxtMovie6);
            Controls.Add(pictureBox_Movie6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMovie6";
            Text = "FormMovie6";
            ((System.ComponentModel.ISupportInitialize)pictureBox_Movie6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrice6;
        private TextBox txtPrice6;
        private TextBox txtStock6;
        private Label lblStock6;
        private Button btnAddCartMovie6;
        private RichTextBox rtxtMovie6;
        private PictureBox pictureBox_Movie6;
    }
}