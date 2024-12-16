using System;
using System.Windows.Forms;

namespace WinFormsFinalProyect
{
    public partial class Frm_Consultas : Form
    {
        private bool isOpening; // Controla si el panel se está mostrando u ocultando
        private int gridOriginalTop = 66; // Posición original del grid (ajustado a 66)
        private int gridCurrentTop;  // La posición actual del grid

        public Frm_Consultas()
        {
            InitializeComponent();
        }

        private void Frm_Consultas_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10; // Velocidad del timer
            gridCurrentTop = gridOriginalTop; // La posición actual del grid también comienza en la posición original
            PnlAddData.Visible = false; // Panel no visible al inicio
            PnlAddData.Height = 300; // Fijar altura del panel (siempre estático)
        }

        private void Btn_Consultas_Click(object sender, EventArgs e)
        {
            isOpening = true; // Configurar para abrir el panel
            PnlAddData.Visible = true; // Mostrar el panel
            timer1.Start(); // Iniciar la animación
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            isOpening = false; // Configurar para cerrar el panel
            timer1.Start(); // Iniciar la animación de regreso
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int gridSpeed = 15; // Velocidad del desplazamiento del grid
            int additionalDrop = 20; // Incremento adicional para que el grid baje más (ajustar según sea necesario)

            if (isOpening)
            {
                // Desplazar el grid hacia abajo para mostrar el panel
                if (gridCurrentTop < gridOriginalTop + PnlAddData.Height + additionalDrop)
                {
                    gridCurrentTop += gridSpeed; // Mover el grid hacia abajo
                    Grid_Usuarios.Top = gridCurrentTop; // Actualizar la posición del grid
                }
                else
                {
                    Grid_Usuarios.Top = gridOriginalTop + PnlAddData.Height + additionalDrop; // Fijar posición final del grid
                    timer1.Stop(); // Detener la animación
                }
            }
            else
            {
                // Desplazar el grid hacia arriba para regresar a la posición original
                if (gridCurrentTop > gridOriginalTop)
                {
                    gridCurrentTop -= gridSpeed; // Mover el grid hacia arriba
                    Grid_Usuarios.Top = gridCurrentTop; // Actualizar la posición del grid
                }
                else
                {
                    // Al llegar a la posición original, detener la animación
                    gridCurrentTop = gridOriginalTop; // Asegurarse de que el grid quede exactamente en la posición original
                    Grid_Usuarios.Top = gridOriginalTop; // Restaurar posición original del grid
                    PnlAddData.Visible = false; // Ocultar el panel
                    timer1.Stop(); // Detener la animación
                }
            }
        }

        private void Btn_Close_Page_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar la ventana actual
        }
    }
}
