namespace WinFormsFinalProject
{
    partial class FormMovie2
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
            pictureBoxMovie2 = new PictureBox();
            rtxtMovie2 = new RichTextBox();
            lblPrice2 = new Label();
            txtPrice2 = new TextBox();
            txtStock2 = new TextBox();
            lblStock2 = new Label();
            btnAddCartMovie2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMovie2).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxMovie2
            // 
            pictureBoxMovie2.Cursor = Cursors.Hand;
            pictureBoxMovie2.Image = WinFormsFinalProyect.Properties.Resources.emma;
            pictureBoxMovie2.Location = new Point(34, 52);
            pictureBoxMovie2.Name = "pictureBoxMovie2";
            pictureBoxMovie2.Size = new Size(174, 236);
            pictureBoxMovie2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxMovie2.TabIndex = 9;
            pictureBoxMovie2.TabStop = false;
            // 
            // rtxtMovie2
            // 
            rtxtMovie2.BackColor = Color.FromArgb(255, 224, 192);
            rtxtMovie2.BorderStyle = BorderStyle.None;
            rtxtMovie2.Enabled = false;
            rtxtMovie2.Location = new Point(235, 52);
            rtxtMovie2.Name = "rtxtMovie2";
            rtxtMovie2.ReadOnly = true;
            rtxtMovie2.Size = new Size(326, 240);
            rtxtMovie2.TabIndex = 10;
            rtxtMovie2.Text = "";
            // 
            // lblPrice2
            // 
            lblPrice2.AutoSize = true;
            lblPrice2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice2.ImageAlign = ContentAlignment.TopCenter;
            lblPrice2.Location = new Point(620, 72);
            lblPrice2.Name = "lblPrice2";
            lblPrice2.Size = new Size(32, 37);
            lblPrice2.TabIndex = 16;
            lblPrice2.Text = "$";
            lblPrice2.TextAlign = ContentAlignment.TopRight;
            // 
            // txtPrice2
            // 
            txtPrice2.BorderStyle = BorderStyle.None;
            txtPrice2.Enabled = false;
            txtPrice2.Location = new Point(658, 77);
            txtPrice2.Multiline = true;
            txtPrice2.Name = "txtPrice2";
            txtPrice2.Size = new Size(57, 32);
            txtPrice2.TabIndex = 15;
            // 
            // txtStock2
            // 
            txtStock2.BorderStyle = BorderStyle.None;
            txtStock2.Enabled = false;
            txtStock2.Location = new Point(679, 197);
            txtStock2.Multiline = true;
            txtStock2.Name = "txtStock2";
            txtStock2.Size = new Size(45, 23);
            txtStock2.TabIndex = 14;
            // 
            // lblStock2
            // 
            lblStock2.AutoSize = true;
            lblStock2.Location = new Point(621, 205);
            lblStock2.Name = "lblStock2";
            lblStock2.Size = new Size(52, 15);
            lblStock2.TabIndex = 13;
            lblStock2.Text = "Quedan:";
            // 
            // btnAddCartMovie2
            // 
            btnAddCartMovie2.BackColor = Color.DarkRed;
            btnAddCartMovie2.FlatAppearance.BorderSize = 0;
            btnAddCartMovie2.FlatAppearance.MouseDownBackColor = Color.White;
            btnAddCartMovie2.FlatAppearance.MouseOverBackColor = Color.Salmon;
            btnAddCartMovie2.FlatStyle = FlatStyle.Flat;
            btnAddCartMovie2.ForeColor = SystemColors.ControlLightLight;
            btnAddCartMovie2.Location = new Point(608, 240);
            btnAddCartMovie2.Name = "btnAddCartMovie2";
            btnAddCartMovie2.Size = new Size(132, 39);
            btnAddCartMovie2.TabIndex = 12;
            btnAddCartMovie2.Text = "Añadir al carrito";
            btnAddCartMovie2.UseVisualStyleBackColor = false;
            // 
            // FormMovie2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 491);
            Controls.Add(lblPrice2);
            Controls.Add(txtPrice2);
            Controls.Add(txtStock2);
            Controls.Add(lblStock2);
            Controls.Add(btnAddCartMovie2);
            Controls.Add(rtxtMovie2);
            Controls.Add(pictureBoxMovie2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMovie2";
            Text = "FormMovie2";
            ((System.ComponentModel.ISupportInitialize)pictureBoxMovie2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxMovie2;
        private RichTextBox rtxtMovie2;
        private Label lblPrice2;
        private TextBox txtPrice2;
        private TextBox txtStock2;
        private Label lblStock2;
        private Button btnAddCartMovie2;
    }
}