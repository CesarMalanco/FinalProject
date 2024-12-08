using System;
using System.Windows.Forms;

namespace WinFormsFinalProyect
{
    public partial class Frm_Agregar : Form
    {
        private bool isOpening; // Para controlar si se está abriendo o cerrando el panel

        public Frm_Agregar()
        {
            InitializeComponent();
        }

        private void Frm_Agregar_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10; //  mayor velocidad
            PnlAddData.Width = 0; // El panel comienza cerrado
            PnlAddData.Visible = false;
            Contenedor_Peliculas.Width = 819; // Ancho total inicial del grid
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            int panelSpeed = 30; // Velocidad de cambio del ancho del panel
            int gridSpeed = 30;  // Velocidad de ajuste del ancho del grid (coherente con panelSpeed)

            if (isOpening)
            {
                // Abrir el panel
                if (PnlAddData.Width < 300)
                {
                    PnlAddData.Width += panelSpeed; // Incrementar el ancho del panel
                    Contenedor_Peliculas.Width -= gridSpeed; // Reducir gradualmente el ancho del grid
                }
                else
                {
                    PnlAddData.Width = 300; // Fijar el tamaño final del panel
                    Contenedor_Peliculas.Width = 513; // Fijar el tamaño final del grid
                    timer1.Stop(); // Detener la animación
                }
            }
            else
            {
                // Cerrar el panel
                if (PnlAddData.Width > 0)
                {
                    PnlAddData.Width -= panelSpeed; // Reducir gradualmente el ancho del panel
                    Contenedor_Peliculas.Width += gridSpeed; // Incrementar gradualmente el ancho del grid
                }
                else
                {
                    PnlAddData.Width = 0; // Fijar el tamaño final del panel
                    Contenedor_Peliculas.Width = 814; // Fijar el tamaño final del grid
                    PnlAddData.Visible = false; // Ocultar el panel al terminar
                    timer1.Stop(); // Detener la animación
                }
            }
        }




        private void BtnCancel_Click(object sender, EventArgs e)
        {
            isOpening = false;
            timer1.Start();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            isOpening = true;
            PnlAddData.Visible = true; // Asegurarse de que el panel sea visible
            timer1.Start();
        }


        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            Pic_photo.Image = null;
        }

        private void Btn_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Pic_photo.ImageLocation = openFileDialog.FileName;
            }
        }

        private void Btn_Close_Page_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
