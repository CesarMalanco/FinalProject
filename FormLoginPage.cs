using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFinalProject
{
    public partial class FormLoginPage : Form
    {
        private string username = "";
        private string password = "";

        public FormLoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Store textBox's content in a class attribute
            this.username = txtUsername.Text;
            this.password = txtPassword.Text;

            // FormAdminPage adminPage = new FormAdminPage();
            // this.Hide();
            // adminPage.ShowDialog();

            // ESTA PARTE ESTA EN EDICION 
            //if (this.username == "" || this.password == "") // If user tries to login without typing an account
            //MessageBox.Show("Enter username and password");
            //else
            // MessageBox.Show("Welcome, " + username + "!"); // Welcome message
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLP_Clear_Click(object sender, EventArgs e)
        {
            // Resets username
            txtUsername.Text = "Username"; // Clears username field by reseting it
            txtUsername.ForeColor = Color.Gray; // Sets color gray back

            // Resets password
            txtPassword.UseSystemPasswordChar = false; // Turns off '*'
            txtPassword.Text = "Password"; // Clears username field by reseting it
            txtPassword.ForeColor = Color.Gray; // Sets color gray back

            this.ActiveControl = null; // Turns off focus so the cursor doesnt stay on the field

        }

        private void FormLoginPage_Load(object sender, EventArgs e)
        {

        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Username")
            {
                txtUsername.Text = "";  // Clears default text
                txtUsername.ForeColor = Color.Black;  // From gray to black
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                txtUsername.Text = "Username";  // Resets the textBox 
                txtUsername.ForeColor = Color.Gray;  // Puts it back to gray
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";  // Clears default text
                txtPassword.ForeColor = Color.Black;  // Changes from gray to black
                txtPassword.UseSystemPasswordChar = true;  // Turns on '*'
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.UseSystemPasswordChar = false;  // Turns off '*'
                txtPassword.Text = "Password";  // Resets default text
                txtPassword.ForeColor = Color.Gray;  // From black to gray
            }
        }

        private void btnGuest_Click(object sender, EventArgs e) // Guest account
        {
            this.username = "GUEST";
            FormMainPage mainPage = new FormMainPage(username); // Create an instance for Main Page
            this.Hide(); // Hide Login Page
            mainPage.ShowDialog(); // Show Main Page   
        }
    }
}
