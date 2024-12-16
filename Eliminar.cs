using System;
using System.Windows.Forms;

namespace WinFormsFinalProyect
{
    public partial class Eliminar : Form
    {
        private bool isOpening; // Para controlar si se está abriendo o cerrando el panel
        private bool openingID;

        public Eliminar()
        {
            InitializeComponent();
        }

        private void Frm_Eliminar_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10; //  mayor velocidad
            timer2.Interval = 10;
            PnlAddData.Width = 0; // El panel comienza cerrado
            PnlAddData.Visible = false;
            Pnl_Info.Width = 0; // El panel Pnl_Info comienza cerrado
            Pnl_Info.Visible = false; // Inicialmente oculto

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            int panelSpeed = 30; // Velocidad de cambio del ancho del panel

            if (openingID)
            {
                // Abrir el panel
                if (PnlAddData.Width < 300)
                {
                    PnlAddData.Width += panelSpeed; // Incrementar el ancho del panel
                    // El Contenedor_Peliculas no se ve afectado
                }
                else
                {
                    PnlAddData.Width = 300; // Fijar el tamaño final del panel
                    timer1.Stop(); // Detener la animación
                }
            }
            else
            {
                // Cerrar el panel
                if (PnlAddData.Width > 0)
                {
                    PnlAddData.Width -= panelSpeed; // Reducir gradualmente el ancho del panel
                    // El Contenedor_Peliculas no se ve afectado
                }
                else
                {
                    PnlAddData.Width = 0; // Fijar el tamaño final del panel
                    PnlAddData.Visible = false; // Ocultar el panel al terminar
                    timer1.Stop(); // Detener la animación
                }
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int panelSpeed = 30; // Velocidad de cambio del ancho del panel

            if (isOpening)
            {
                // Abrir el panel Pnl_Info
                if (Pnl_Info.Width < 300)
                {
                    Pnl_Info.Width += panelSpeed; // Incrementar el ancho del panel
                    PnlAddData.Visible = false; // Ocultar PnlAddData cuando se abre Pnl_Info
                    // El Contenedor_Peliculas no se ve afectado
                }
                else
                {
                    Pnl_Info.Width = 300; // Fijar el tamaño final del panel
                    timer1.Stop(); // Detener la animación
                }
            }
            else
            {
                // Cerrar el panel Pnl_Info
                if (Pnl_Info.Width > 0)
                {
                    Pnl_Info.Width -= panelSpeed; // Reducir gradualmente el ancho del panel
                    // El Contenedor_Peliculas no se ve afectado
                }
                else
                {
                    Pnl_Info.Width = 0; // Fijar el tamaño final del panel
                    Pnl_Info.Visible = false; // Ocultar el panel al terminar
                    PnlAddData.Visible = true; // Mostrar PnlAddData nuevamente
                    timer1.Stop(); // Detener la animación
                }
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            isOpening = true;
            PnlAddData.Visible = true;
            timer2.Start();
        }

        private void Btn_Buscar_Click(object sender, EventArgs e)
        {
            isOpening = true;
            PnlAddData.Visible = false; // Ocultar PnlAddData inmediatamente al presionar el botón
            Pnl_Info.Visible = true; // Mostrar Pnl_Info
            timer1.Start(); // Iniciar la animación de Pnl_Info
        }


        private void Btn_Close_Page_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            isOpening = false;
            timer1.Start();
        }

        private void Contenedor_Peliculas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
