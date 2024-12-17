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
    public partial class FormMovies : Form
    {
        private FormMainPage MainPage;
        public FormMovies()
        {
            InitializeComponent();
        }

        public FormMovies(FormMainPage mainPage)
        {
            InitializeComponent();
            MainPage = mainPage;
        }

        private void pictureBoxMovie1_Click(object sender, EventArgs e)
        {
            // Verificar si el panel ya contiene FormMovie1 para evitar agregarlo múltiples veces
            foreach (Control control in MainPage.panelMP.Controls)
            {
                if (control is FormMovie1)
                {
                    // Si ya contiene FormMovie1, no hacer nada
                    return;
                }
            }

            // Crear otro panel para mostrar dentro del panel de FormMainPage
            Panel nuevoPanel = new Panel();
            nuevoPanel.Dock = DockStyle.Fill;
            nuevoPanel.BackColor = Color.LightBlue; // Un color para diferenciar el nuevo panel

            // Crear una nueva instancia del formulario FormMovie1
            FormMovie1 movie1 = new FormMovie1();
            movie1.TopLevel = false; // Asegurar que FormMovie1 se maneje como un control y no como un formulario independiente
            movie1.FormBorderStyle = FormBorderStyle.None; // Quitar bordes
            movie1.Dock = DockStyle.Fill; // Hacer que FormMovie1 ocupe todo el espacio del panel

            // Limpiar el panelMP antes de agregar el nuevo contenido
            if (MainPage != null)
            {
                MainPage.panelMP.Controls.Clear(); // Limpiar el panelMP de cualquier control previo
                MainPage.panelMP.Controls.Add(nuevoPanel); // Añadir el nuevo panel a panelMP
                nuevoPanel.Controls.Add(movie1); // Añadir FormMovie1 dentro del nuevo panel
                movie1.Show(); // Mostrar FormMovie1 dentro del panel
            }
        }
        private void pictureBoxMovie2_Click(object sender, EventArgs e)
        {
            foreach (Control control in MainPage.panelMP.Controls)
            {
                if (control is FormMovie2)
                {
                    return;
                }
            }


            Panel nuevoPanel = new Panel();
            nuevoPanel.Dock = DockStyle.Fill;
            nuevoPanel.BackColor = Color.LightBlue;


            FormMovie2 movie2 = new FormMovie2();
            movie2.TopLevel = false;
            movie2.FormBorderStyle = FormBorderStyle.None;
            movie2.Dock = DockStyle.Fill;


            if (MainPage != null)
            {
                MainPage.panelMP.Controls.Clear();
                MainPage.panelMP.Controls.Add(nuevoPanel);
                nuevoPanel.Controls.Add(movie2);
                movie2.Show();
            }
        }

        private void pictureBoxMovie3_Click(object sender, EventArgs e)
        {
            foreach (Control control in MainPage.panelMP.Controls)
            {
                if (control is FormMovie3)
                {
                    return;
                }
            }

            Panel nuevoPanel = new Panel();
            nuevoPanel.Dock = DockStyle.Fill;
            nuevoPanel.BackColor = Color.LightBlue;

            FormMovie3 movie3 = new FormMovie3();
            movie3.TopLevel = false;
            movie3.FormBorderStyle = FormBorderStyle.None;
            movie3.Dock = DockStyle.Fill;

            if (MainPage != null)
            {
                MainPage.panelMP.Controls.Clear();
                MainPage.panelMP.Controls.Add(nuevoPanel);
                nuevoPanel.Controls.Add(movie3);
                movie3.Show();
            }
        }

        private void pictureBoxMovie4_Click(object sender, EventArgs e)
        {
            foreach (Control control in MainPage.panelMP.Controls)
            {
                if (control is FormMovie4)
                {
                    return;
                }
            }

            Panel nuevoPanel = new Panel();
            nuevoPanel.Dock = DockStyle.Fill;
            nuevoPanel.BackColor = Color.LightBlue;

            FormMovie4 movie4 = new FormMovie4();
            movie4.TopLevel = false;
            movie4.FormBorderStyle = FormBorderStyle.None;
            movie4.Dock = DockStyle.Fill;

            if (MainPage != null)
            {
                MainPage.panelMP.Controls.Clear();
                MainPage.panelMP.Controls.Add(nuevoPanel);
                nuevoPanel.Controls.Add(movie4);
                movie4.Show();
            }
        }

        private void pictureBoxMovie5_Click(object sender, EventArgs e)
        {
            foreach (Control control in MainPage.panelMP.Controls)
            {
                if (control is FormMovie3)
                {
                    return;
                }
            }

            Panel nuevoPanel = new Panel();
            nuevoPanel.Dock = DockStyle.Fill;
            nuevoPanel.BackColor = Color.LightBlue;

            FormMovie5 movie5 = new FormMovie5();
            movie5.TopLevel = false;
            movie5.FormBorderStyle = FormBorderStyle.None;
            movie5.Dock = DockStyle.Fill;

            if (MainPage != null)
            {
                MainPage.panelMP.Controls.Clear();
                MainPage.panelMP.Controls.Add(nuevoPanel);
                nuevoPanel.Controls.Add(movie5);
                movie5.Show();
            }
        }

        private void pictureBoxMovie6_Click(object sender, EventArgs e)
        {
            foreach (Control control in MainPage.panelMP.Controls)
            {
                if (control is FormMovie6)
                {
                    return;
                }
            }

            Panel nuevoPanel = new Panel();
            nuevoPanel.Dock = DockStyle.Fill;
            nuevoPanel.BackColor = Color.LightBlue;

            FormMovie6 movie6 = new FormMovie6();
            movie6.TopLevel = false;
            movie6.FormBorderStyle = FormBorderStyle.None;
            movie6.Dock = DockStyle.Fill;

            if (MainPage != null)
            {
                MainPage.panelMP.Controls.Clear();
                MainPage.panelMP.Controls.Add(nuevoPanel);
                nuevoPanel.Controls.Add(movie6);
                movie6.Show();
            }
        }

        private void pictureBoxMovie7_Click(object sender, EventArgs e)
        {
            foreach (Control control in MainPage.panelMP.Controls)
            {
                if (control is FormMovie3)
                {
                    return;
                }
            }

            Panel nuevoPanel = new Panel();
            nuevoPanel.Dock = DockStyle.Fill;
            nuevoPanel.BackColor = Color.LightBlue;

            FormMovie7 movie7 = new FormMovie7();
            movie7.TopLevel = false;
            movie7.FormBorderStyle = FormBorderStyle.None;
            movie7.Dock = DockStyle.Fill;

            if (MainPage != null)
            {
                MainPage.panelMP.Controls.Clear();
                MainPage.panelMP.Controls.Add(nuevoPanel);
                nuevoPanel.Controls.Add(movie7);
                movie7.Show();
            }
        }
    }
}
