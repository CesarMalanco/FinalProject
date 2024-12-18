namespace WinFormsFinalProject
{
    partial class FormLoginPage
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnExit = new Button();
            pictureBoxLP_Title = new PictureBox();
            lblSlogan = new Label();
            pictureBoxLP_Logo = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBoxLP_Username = new PictureBox();
            pictureBoxLP_Password = new PictureBox();
            lblLP_Clear = new Label();
            btnGuest = new Button();
            panel3 = new Panel();
            pictureBoxGuestPic = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLP_Title).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLP_Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLP_Username).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLP_Password).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGuestPic).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.ForeColor = SystemColors.WindowFrame;
            txtUsername.Location = new Point(579, 189);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(201, 31);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "Username";
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = SystemColors.WindowFrame;
            txtPassword.Location = new Point(579, 269);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(201, 20);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Password";
            txtPassword.TextChanged += txtPassword_TextChanged;
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(526, 367);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(258, 37);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Location = new Point(808, 503);
            btnExit.Margin = new Padding(3, 4, 3, 4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 81);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBoxLP_Title
            // 
            pictureBoxLP_Title.Location = new Point(98, 219);
            pictureBoxLP_Title.Margin = new Padding(3, 4, 3, 4);
            pictureBoxLP_Title.Name = "pictureBoxLP_Title";
            pictureBoxLP_Title.Size = new Size(280, 39);
            pictureBoxLP_Title.TabIndex = 6;
            pictureBoxLP_Title.TabStop = false;
            // 
            // lblSlogan
            // 
            lblSlogan.AutoSize = true;
            lblSlogan.Location = new Point(151, 304);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(53, 20);
            lblSlogan.TabIndex = 7;
            lblSlogan.Text = "slogan";
            // 
            // pictureBoxLP_Logo
            // 
            pictureBoxLP_Logo.Location = new Point(32, 204);
            pictureBoxLP_Logo.Margin = new Padding(3, 4, 3, 4);
            pictureBoxLP_Logo.Name = "pictureBoxLP_Logo";
            pictureBoxLP_Logo.Size = new Size(59, 61);
            pictureBoxLP_Logo.TabIndex = 8;
            pictureBoxLP_Logo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(526, 219);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(258, 1);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(526, 304);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(258, 1);
            panel2.TabIndex = 10;
            // 
            // pictureBoxLP_Username
            // 
            pictureBoxLP_Username.Image = WinFormsFinalProyect.Properties.Resources.userIcon;
            pictureBoxLP_Username.Location = new Point(526, 167);
            pictureBoxLP_Username.Margin = new Padding(3, 4, 3, 4);
            pictureBoxLP_Username.Name = "pictureBoxLP_Username";
            pictureBoxLP_Username.Size = new Size(47, 49);
            pictureBoxLP_Username.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxLP_Username.TabIndex = 11;
            pictureBoxLP_Username.TabStop = false;
            // 
            // pictureBoxLP_Password
            // 
            pictureBoxLP_Password.Location = new Point(526, 252);
            pictureBoxLP_Password.Margin = new Padding(3, 4, 3, 4);
            pictureBoxLP_Password.Name = "pictureBoxLP_Password";
            pictureBoxLP_Password.Size = new Size(47, 49);
            pictureBoxLP_Password.TabIndex = 12;
            pictureBoxLP_Password.TabStop = false;
            // 
            // lblLP_Clear
            // 
            lblLP_Clear.AutoSize = true;
            lblLP_Clear.Location = new Point(707, 331);
            lblLP_Clear.Name = "lblLP_Clear";
            lblLP_Clear.Size = new Size(85, 20);
            lblLP_Clear.TabIndex = 13;
            lblLP_Clear.Text = "Clear Fields";
            lblLP_Clear.Click += lblLP_Clear_Click;
            // 
            // btnGuest
            // 
            btnGuest.Location = new Point(621, 432);
            btnGuest.Margin = new Padding(3, 4, 3, 4);
            btnGuest.Name = "btnGuest";
            btnGuest.Size = new Size(121, 31);
            btnGuest.TabIndex = 14;
            btnGuest.Text = "Enter as guest";
            btnGuest.UseVisualStyleBackColor = true;
            btnGuest.Click += btnGuest_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Crimson;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(442, 600);
            panel3.TabIndex = 15;
            panel3.Paint += panel3_Paint;
            // 
            // pictureBoxGuestPic
            // 
            pictureBoxGuestPic.Location = new Point(579, 429);
            pictureBoxGuestPic.Margin = new Padding(3, 4, 3, 4);
            pictureBoxGuestPic.Name = "pictureBoxGuestPic";
            pictureBoxGuestPic.Size = new Size(34, 37);
            pictureBoxGuestPic.TabIndex = 16;
            pictureBoxGuestPic.TabStop = false;
            // 
            // FormLoginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBoxGuestPic);
            Controls.Add(btnGuest);
            Controls.Add(lblLP_Clear);
            Controls.Add(pictureBoxLP_Password);
            Controls.Add(pictureBoxLP_Username);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBoxLP_Logo);
            Controls.Add(lblSlogan);
            Controls.Add(pictureBoxLP_Title);
            Controls.Add(btnExit);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormLoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login Page";
            Load += FormLoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLP_Title).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLP_Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLP_Username).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLP_Password).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGuestPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnExit;
        private PictureBox pictureBoxLP_Title;
        private Label lblSlogan;
        private PictureBox pictureBoxLP_Logo;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBoxLP_Username;
        private PictureBox pictureBoxLP_Password;
        private Label lblLP_Clear;
        private Button btnGuest;
        private Panel panel3;
        private PictureBox pictureBoxGuestPic;
    }
}