namespace WinFormsFinalProject
{
    partial class FormCover
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
            lblCover_Subject = new Label();
            lblCover_TeamMembers = new Label();
            lblCover_Teacher = new Label();
            lblCover_Date = new Label();
            btnContinue = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCover_Subject
            // 
            lblCover_Subject.AutoSize = true;
            lblCover_Subject.Font = new Font("Sitka Banner", 12F);
            lblCover_Subject.Location = new Point(312, 59);
            lblCover_Subject.Name = "lblCover_Subject";
            lblCover_Subject.Size = new Size(107, 23);
            lblCover_Subject.TabIndex = 0;
            lblCover_Subject.Text = "Programación II";
            // 
            // lblCover_TeamMembers
            // 
            lblCover_TeamMembers.Font = new Font("Sitka Banner", 12F);
            lblCover_TeamMembers.Location = new Point(312, 161);
            lblCover_TeamMembers.Name = "lblCover_TeamMembers";
            lblCover_TeamMembers.Size = new Size(223, 153);
            lblCover_TeamMembers.TabIndex = 2;
            lblCover_TeamMembers.Text = "Integrantes:\nMariana Isabel Alvarado de la Huerta.\nDanna Cristina Castro Hernández.\nDarely Quezada Guerrero\nCelia Fernanda Vela Uribe.\nCésar Andrés Zuleta Malanco.";
            // 
            // lblCover_Teacher
            // 
            lblCover_Teacher.Font = new Font("Sitka Banner", 12F);
            lblCover_Teacher.Location = new Point(312, 105);
            lblCover_Teacher.Name = "lblCover_Teacher";
            lblCover_Teacher.Size = new Size(196, 46);
            lblCover_Teacher.TabIndex = 3;
            lblCover_Teacher.Text = "PROF: Dr. Georgina Salazar Partida";
            // 
            // lblCover_Date
            // 
            lblCover_Date.AutoSize = true;
            lblCover_Date.Font = new Font("Sitka Banner", 12F);
            lblCover_Date.Location = new Point(321, 340);
            lblCover_Date.Name = "lblCover_Date";
            lblCover_Date.Size = new Size(169, 23);
            lblCover_Date.TabIndex = 4;
            lblCover_Date.Text = "17 de Diciembre del 2024";
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(668, 384);
            btnContinue.Name = "btnContinue";
            btnContinue.RightToLeft = RightToLeft.No;
            btnContinue.Size = new Size(96, 34);
            btnContinue.TabIndex = 5;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += btnContinue_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoUAA;
            pictureBox1.Location = new Point(22, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 97);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // FormCover
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnContinue);
            Controls.Add(lblCover_Date);
            Controls.Add(lblCover_Teacher);
            Controls.Add(lblCover_TeamMembers);
            Controls.Add(lblCover_Subject);
            Name = "FormCover";
            Text = "Cover";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCover_Subject;
        private Label lblCover_TeamMembers;
        private Label lblCover_Teacher;
        private Label lblCover_Date;
        private Button btnContinue;
        private PictureBox pictureBox1;
    }
}