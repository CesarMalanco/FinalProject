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
            ((System.ComponentModel.ISupportInitialize)pictureBoxLP_Title).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLP_Logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLP_Username).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLP_Password).BeginInit();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.ForeColor = SystemColors.WindowFrame;
            txtUsername.Location = new Point(507, 142);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(176, 23);
            txtUsername.TabIndex = 2;
            txtUsername.Text = "Username";
            txtUsername.Enter += txtUsername_Enter;
            txtUsername.Leave += txtUsername_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = SystemColors.WindowFrame;
            txtPassword.Location = new Point(507, 202);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(176, 16);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Password";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(460, 275);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(226, 28);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(707, 377);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(66, 61);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // pictureBoxLP_Title
            // 
            pictureBoxLP_Title.Location = new Point(86, 164);
            pictureBoxLP_Title.Name = "pictureBoxLP_Title";
            pictureBoxLP_Title.Size = new Size(245, 29);
            pictureBoxLP_Title.TabIndex = 6;
            pictureBoxLP_Title.TabStop = false;
            // 
            // lblSlogan
            // 
            lblSlogan.AutoSize = true;
            lblSlogan.Location = new Point(132, 228);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(42, 15);
            lblSlogan.TabIndex = 7;
            lblSlogan.Text = "slogan";
            // 
            // pictureBoxLP_Logo
            // 
            pictureBoxLP_Logo.Location = new Point(28, 153);
            pictureBoxLP_Logo.Name = "pictureBoxLP_Logo";
            pictureBoxLP_Logo.Size = new Size(52, 46);
            pictureBoxLP_Logo.TabIndex = 8;
            pictureBoxLP_Logo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(460, 164);
            panel1.Name = "panel1";
            panel1.Size = new Size(226, 1);
            panel1.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(460, 228);
            panel2.Name = "panel2";
            panel2.Size = new Size(226, 1);
            panel2.TabIndex = 10;
            // 
            // pictureBoxLP_Username
            // 
            pictureBoxLP_Username.Location = new Point(460, 125);
            pictureBoxLP_Username.Name = "pictureBoxLP_Username";
            pictureBoxLP_Username.Size = new Size(41, 37);
            pictureBoxLP_Username.TabIndex = 11;
            pictureBoxLP_Username.TabStop = false;
            // 
            // pictureBoxLP_Password
            // 
            pictureBoxLP_Password.Location = new Point(460, 189);
            pictureBoxLP_Password.Name = "pictureBoxLP_Password";
            pictureBoxLP_Password.Size = new Size(41, 37);
            pictureBoxLP_Password.TabIndex = 12;
            pictureBoxLP_Password.TabStop = false;
            // 
            // lblLP_Clear
            // 
            lblLP_Clear.AutoSize = true;
            lblLP_Clear.Location = new Point(619, 248);
            lblLP_Clear.Name = "lblLP_Clear";
            lblLP_Clear.Size = new Size(67, 15);
            lblLP_Clear.TabIndex = 13;
            lblLP_Clear.Text = "Clear Fields";
            lblLP_Clear.Click += lblLP_Clear_Click;
            // 
            // FormLoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLoginPage";
            Text = "Login Page";
            Load += FormLoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxLP_Title).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLP_Logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLP_Username).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLP_Password).EndInit();
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
    }
}