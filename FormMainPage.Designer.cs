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
            btnLogOut = new Button();
            txtMP_User = new TextBox();
            btnMP_Movies = new Button();
            btnMP_Food = new Button();
            btnMP_Home = new Button();
            panelMP = new Panel();
            panelCartButton = new Panel();
            btnSeeCart = new Button();
            panelHead.SuspendLayout();
            panelMP.SuspendLayout();
            panelCartButton.SuspendLayout();
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
            panelHead.Margin = new Padding(3, 4, 3, 4);
            panelHead.Name = "panelHead";
            panelHead.Size = new Size(914, 105);
            panelHead.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(833, 36);
            btnLogOut.Margin = new Padding(3, 4, 3, 4);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(67, 39);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Log out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // txtMP_User
            // 
            txtMP_User.BackColor = Color.Brown;
            txtMP_User.BorderStyle = BorderStyle.None;
            txtMP_User.Enabled = false;
            txtMP_User.ForeColor = SystemColors.ButtonHighlight;
            txtMP_User.Location = new Point(747, 45);
            txtMP_User.Margin = new Padding(3, 4, 3, 4);
            txtMP_User.Name = "txtMP_User";
            txtMP_User.ReadOnly = true;
            txtMP_User.Size = new Size(79, 20);
            txtMP_User.TabIndex = 4;
            txtMP_User.TextChanged += txtMP_User_TextChanged;
            // 
            // btnMP_Movies
            // 
            btnMP_Movies.FlatAppearance.BorderSize = 0;
            btnMP_Movies.FlatStyle = FlatStyle.Flat;
            btnMP_Movies.Location = new Point(224, 59);
            btnMP_Movies.Margin = new Padding(3, 4, 3, 4);
            btnMP_Movies.Name = "btnMP_Movies";
            btnMP_Movies.Size = new Size(86, 31);
            btnMP_Movies.TabIndex = 3;
            btnMP_Movies.Text = "Cartelera";
            btnMP_Movies.UseVisualStyleBackColor = true;
            btnMP_Movies.Click += btnMP_Movies_Click;
            // 
            // btnMP_Food
            // 
            btnMP_Food.FlatAppearance.BorderSize = 0;
            btnMP_Food.FlatStyle = FlatStyle.Flat;
            btnMP_Food.Location = new Point(394, 59);
            btnMP_Food.Margin = new Padding(3, 4, 3, 4);
            btnMP_Food.Name = "btnMP_Food";
            btnMP_Food.Size = new Size(86, 31);
            btnMP_Food.TabIndex = 2;
            btnMP_Food.Text = "Dulcería";
            btnMP_Food.UseVisualStyleBackColor = true;
            btnMP_Food.Click += btnMP_Food_Click;
            // 
            // btnMP_Home
            // 
            btnMP_Home.FlatAppearance.BorderSize = 0;
            btnMP_Home.FlatStyle = FlatStyle.Flat;
            btnMP_Home.Location = new Point(59, 59);
            btnMP_Home.Margin = new Padding(3, 4, 3, 4);
            btnMP_Home.Name = "btnMP_Home";
            btnMP_Home.Size = new Size(86, 31);
            btnMP_Home.TabIndex = 1;
            btnMP_Home.Text = "Inicio";
            btnMP_Home.UseVisualStyleBackColor = true;
            btnMP_Home.Click += btnMP_Home_Click;
            // 
            // panelMP
            // 
            panelMP.AutoScroll = true;
            panelMP.Controls.Add(panelCartButton);
            panelMP.Dock = DockStyle.Bottom;
            panelMP.Location = new Point(0, 97);
            panelMP.Margin = new Padding(3, 4, 3, 4);
            panelMP.Name = "panelMP";
            panelMP.Size = new Size(914, 503);
            panelMP.TabIndex = 1;
            // 
            // panelCartButton
            // 
            panelCartButton.BackColor = SystemColors.ActiveCaption;
            panelCartButton.Controls.Add(btnSeeCart);
            panelCartButton.Location = new Point(760, 412);
            panelCartButton.Margin = new Padding(3, 4, 3, 4);
            panelCartButton.Name = "panelCartButton";
            panelCartButton.Size = new Size(131, 75);
            panelCartButton.TabIndex = 0;
            // 
            // btnSeeCart
            // 
            btnSeeCart.Location = new Point(22, 21);
            btnSeeCart.Margin = new Padding(3, 4, 3, 4);
            btnSeeCart.Name = "btnSeeCart";
            btnSeeCart.Size = new Size(88, 49);
            btnSeeCart.TabIndex = 0;
            btnSeeCart.Text = "btnSeeCart";
            btnSeeCart.UseVisualStyleBackColor = true;
            btnSeeCart.Click += btnSeeCart_Click;
            // 
            // FormMainPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panelMP);
            Controls.Add(panelHead);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormMainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMainPage";
            panelHead.ResumeLayout(false);
            panelHead.PerformLayout();
            panelMP.ResumeLayout(false);
            panelCartButton.ResumeLayout(false);
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
        private Panel panelCartButton;
        private Button btnSeeCart;
    }
}