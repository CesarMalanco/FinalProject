namespace WinFormsFinalProject
{
    partial class FormMainPage
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
            panelHead = new Panel();
            txtMP_User = new TextBox();
            btnMP_Movies = new Button();
            btnMP_Food = new Button();
            btnMP_Home = new Button();
            panelMP = new Panel();
            btnLogOut = new Button();
            panelHead.SuspendLayout();
            SuspendLayout();
            // 
            // panelHead
            // 
            panelHead.BackColor = Color.FromArgb(205, 10, 29);
            panelHead.Controls.Add(btnLogOut);
            panelHead.Controls.Add(txtMP_User);
            panelHead.Controls.Add(btnMP_Movies);
            panelHead.Controls.Add(btnMP_Food);
            panelHead.Controls.Add(btnMP_Home);
            panelHead.Location = new Point(0, 0);
            panelHead.Name = "panelHead";
            panelHead.Size = new Size(800, 79);
            panelHead.TabIndex = 0;
            // 
            // txtMP_User
            // 
            txtMP_User.BackColor = Color.Brown;
            txtMP_User.BorderStyle = BorderStyle.None;
            txtMP_User.Enabled = false;
            txtMP_User.ForeColor = SystemColors.WindowText;
            txtMP_User.Location = new Point(654, 34);
            txtMP_User.Name = "txtMP_User";
            txtMP_User.ReadOnly = true;
            txtMP_User.Size = new Size(69, 16);
            txtMP_User.TabIndex = 4;
            // 
            // btnMP_Movies
            // 
            btnMP_Movies.FlatAppearance.BorderSize = 0;
            btnMP_Movies.FlatStyle = FlatStyle.Flat;
            btnMP_Movies.Location = new Point(196, 44);
            btnMP_Movies.Name = "btnMP_Movies";
            btnMP_Movies.Size = new Size(75, 23);
            btnMP_Movies.TabIndex = 3;
            btnMP_Movies.Text = "Cartelera";
            btnMP_Movies.UseVisualStyleBackColor = true;
            btnMP_Movies.Click += btnMP_Movies_Click;
            // 
            // btnMP_Food
            // 
            btnMP_Food.FlatAppearance.BorderSize = 0;
            btnMP_Food.FlatStyle = FlatStyle.Flat;
            btnMP_Food.Location = new Point(345, 44);
            btnMP_Food.Name = "btnMP_Food";
            btnMP_Food.Size = new Size(75, 23);
            btnMP_Food.TabIndex = 2;
            btnMP_Food.Text = "Dulcería";
            btnMP_Food.UseVisualStyleBackColor = true;
            btnMP_Food.Click += btnMP_Food_Click;
            // 
            // btnMP_Home
            // 
            btnMP_Home.FlatAppearance.BorderSize = 0;
            btnMP_Home.FlatStyle = FlatStyle.Flat;
            btnMP_Home.Location = new Point(52, 44);
            btnMP_Home.Name = "btnMP_Home";
            btnMP_Home.Size = new Size(75, 23);
            btnMP_Home.TabIndex = 1;
            btnMP_Home.Text = "Inicio";
            btnMP_Home.UseVisualStyleBackColor = true;
            btnMP_Home.Click += btnMP_Home_Click;
            // 
            // panelMP
            // 
            panelMP.AutoScroll = true;
            panelMP.Dock = DockStyle.Bottom;
            panelMP.Location = new Point(0, 73);
            panelMP.Name = "panelMP";
            panelMP.Size = new Size(800, 377);
            panelMP.TabIndex = 1;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(729, 27);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(59, 29);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // FormMainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMP);
            Controls.Add(panelHead);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMainPage";
            panelHead.ResumeLayout(false);
            panelHead.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelHead;
        private Button btnMP_Home;
        private Button btnMP_Food;
        private Button btnMP_Movies;
        public Panel panelMP;
        private TextBox txtMP_User;
        private Button btnLogOut;
    }
}