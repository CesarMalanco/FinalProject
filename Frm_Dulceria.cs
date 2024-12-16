using System;
using System.Windows.Forms;

namespace WinFormsFinalProyect
{
    public partial class Frm_Dulceria : Form
    {
        private bool isOpening; // Para controlar si se está abriendo o cerrando el panel

        public Frm_Dulceria()
        {
            InitializeComponent();
        }

        private void Frm_Dulceria_Load(object sender, EventArgs e)
        {
            Timer1.Interval = 10; //  mayor velocidad
            PnlAddData.Width = 0; // El panel comienza cerrado
            PnlAddData.Visible = false;
            Grid_Dulceria.Width = 811; // Ancho total inicial del grid
        }



        private void Timer1_Tick(object sender, EventArgs e)
        {
            int panelSpeed = 30; // Velocidad de cambio del ancho del panel
            int gridSpeed = 30;  // Velocidad de ajuste del ancho del grid (coherente con panelSpeed)

            if (isOpening)
            {
                // Abrir el panel
                if (PnlAddData.Width < 300)
                {
                    PnlAddData.Width += panelSpeed; // Incrementar el ancho del panel
                    Grid_Dulceria.Width -= gridSpeed; // Reducir gradualmente el ancho del grid
                }
                else
                {
                    PnlAddData.Width = 300; // Fijar el tamaño final del panel
                    Grid_Dulceria.Width = 513; // Fijar el tamaño final del grid
                    Timer1.Stop(); // Detener la animación
                }
            }
            else
            {
                // Cerrar el panel
                if (PnlAddData.Width > 0)
                {
                    PnlAddData.Width -= panelSpeed; // Reducir gradualmente el ancho del panel
                    Grid_Dulceria.Width += gridSpeed; // Incrementar gradualmente el ancho del grid
                }
                else
                {
                    PnlAddData.Width = 0; // Fijar el tamaño final del panel
                    Grid_Dulceria.Width = 814; // Fijar el tamaño final del grid
                    PnlAddData.Visible = false; // Ocultar el panel al terminar
                    Timer1.Stop(); // Detener la animación
                }
            }
        }




        private void BtnCancel_Click(object sender, EventArgs e)
        {
            isOpening = false; 
            Timer1.Start();
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            isOpening = true;
            PnlAddData.Visible = true; // Hacer visible el panel
            PnlAddData.Update(); // Forzar la actualización gráfica
            Timer1.Start(); // Iniciar la animación
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            isOpening = true;
            PnlAddData.Visible = true;
            PnlAddData.Update(); // Forzar la actualización gráfica
            Timer1.Start();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            isOpening = true;
            PnlAddData.Visible = true;
            PnlAddData.Update(); // Forzar la actualización gráfica
            Timer1.Start();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            isOpening = true;
            PnlAddData.Visible = true;
            PnlAddData.Update(); // Forzar la actualización gráfica
            Timer1.Start();
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
