using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace WinFormsFinalProject
{
    public partial class FormMainPage : Form
    {
        private string User;
        public FormMainPage()
        {
            InitializeComponent();

        }

        public FormMainPage(string user)
        {
            InitializeComponent();
            User = user;
            txtMP_User.Text = user;
        }

        private void btnMP_Home_Click(object sender, EventArgs e)
        {
            panelMP.Controls.Clear(); // Clean controls
            btnMP_Home.ForeColor = Color.White;
            btnMP_Movies.ForeColor = Color.Black;
            btnMP_Food.ForeColor = Color.Black;

            // Instance of FormHome
            FormHome formHome = new FormHome();

            formHome.TopLevel = false;
            formHome.FormBorderStyle = FormBorderStyle.None;

            panelMP.Controls.Add(formHome);//panelMP_Movies.Update();
            formHome.Show();
        }

        private void btnMP_Movies_Click(object sender, EventArgs e)
        {

            panelMP.Controls.Clear(); // Clean controls

            btnMP_Home.ForeColor = Color.Black;
            btnMP_Movies.ForeColor = Color.White;
            btnMP_Food.ForeColor = Color.Black;

            // Instance of FormMovies
            FormMovies formMovies = new FormMovies(this);

            formMovies.TopLevel = false; // Set it as control (for panel)
            formMovies.FormBorderStyle = FormBorderStyle.None; // No border style

            // Add FormMovies to PanelMovies
            panelMP.Controls.Add(formMovies);

            formMovies.Show(); // Show form in panel
        }
        private void btnMP_Food_Click(object sender, EventArgs e)
        {
            panelMP.Controls.Clear(); // Clean controls

            btnMP_Home.ForeColor = Color.Black;
            btnMP_Movies.ForeColor = Color.Black;
            btnMP_Food.ForeColor = Color.White;

            // Instance of FormMovies
            FormFood food = new FormFood(this);

            food.TopLevel = false; // Set it as control (for panel)
            food.FormBorderStyle = FormBorderStyle.None; // No border style

            // Add FormMovies to PanelMovies
            panelMP.Controls.Add(food);

            food.Show();
        }

        private void pictureBoxMovie1_Click(object sender, EventArgs e)
        {
            panelMP.Controls.Clear(); // Clean controls

            FormMovie1 movie1 = new FormMovie1();

            movie1.TopLevel = false; // Set it as control (for panel)
            movie1.FormBorderStyle = FormBorderStyle.None; // No border style
            movie1.Dock = DockStyle.Fill;

            // Add movie1 to PanelMovies
            panelMP.Controls.Add(movie1);

            movie1.Show(); // Show form in panel
        }

        private void pictureBoxMovie2_Click(object sender, EventArgs e)
        {
            panelMP.Controls.Clear(); // Clean controls

            FormMovie2 movie2 = new FormMovie2();

            movie2.TopLevel = false; // Set it as control (for panel)
            movie2.FormBorderStyle = FormBorderStyle.None; // No border style
            movie2.Dock = DockStyle.Fill;

            // Add movie1 to PanelMovies
            panelMP.Controls.Add(movie2);

            movie2.Show(); // Show form in panel
        }

        private void pictureBoxMovie3_Click(object sender, EventArgs e)
        {
            panelMP.Controls.Clear();

            FormMovie3 movie3 = new FormMovie3();

            movie3.TopLevel = false;
            movie3.FormBorderStyle = FormBorderStyle.None;
            movie3.Dock = DockStyle.Fill;


            panelMP.Controls.Add(movie3);

            movie3.Show();
        }

        private void pictureBoxMovie4_Click(object sender, EventArgs e)
        {
            panelMP.Controls.Clear();

            FormMovie4 movie4 = new FormMovie4();

            movie4.TopLevel = false;
            movie4.FormBorderStyle = FormBorderStyle.None;
            movie4.Dock = DockStyle.Fill;


            panelMP.Controls.Add(movie4);

            movie4.Show();
        }

        private void pictureBoxMovie5_Click(object sender, EventArgs e)
        {
            panelMP.Controls.Clear();

            FormMovie5 movie5 = new FormMovie5();

            movie5.TopLevel = false;
            movie5.FormBorderStyle = FormBorderStyle.None;
            movie5.Dock = DockStyle.Fill;


            panelMP.Controls.Add(movie5);

            movie5.Show();
        }

        private void pictureBoxMovie6_Click(object sender, EventArgs e)
        {
            panelMP.Controls.Clear();

            FormMovie6 movie6 = new FormMovie6();

            movie6.TopLevel = false;
            movie6.FormBorderStyle = FormBorderStyle.None;
            movie6.Dock = DockStyle.Fill;


            panelMP.Controls.Add(movie6);

            movie6.Show();
        }

        private void pictureBoxMovie7_Click(object sender, EventArgs e)
        {
            panelMP.Controls.Clear();

            FormMovie7 movie7 = new FormMovie7();

            movie7.TopLevel = false;
            movie7.FormBorderStyle = FormBorderStyle.None;
            movie7.Dock = DockStyle.Fill;


            panelMP.Controls.Add(movie7);

            movie7.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            FormLoginPage loginPage = new FormLoginPage();// Crete instance for Login Page
            this.Hide(); // Hide this
            loginPage.ShowDialog(); // Show Login Page
        }
    }
}
