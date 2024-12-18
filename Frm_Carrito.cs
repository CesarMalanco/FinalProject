using System;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;



using iText.Layout.Properties;
using iText.Kernel.Pdf.Canvas;
using WinFormsFinalProyect;

namespace Forms_individuales_proyecto
{
    public partial class Frm_Carrito : Form
    {
        private bool isOpening; // Controla si Pnl_Info se abre o cierra
        private bool openingID; // Controla si PnlAddData se abre o cierra
        private bool isIDPanelClosed = false; // Variable para controlar si se cierra el panel ID
        // Buy data
        private string customerName;
        private string date;
        private string creditCardNumber;
        private string CVV;

        public Frm_Carrito()
        {
            InitializeComponent();
        }

        private void Frm_Carrito_Load(object sender, EventArgs e)
        {
            // Configuración inicial de los paneles
            timer3.Interval = 10; // Velocidad del timer3
            timer2.Interval = 10; // Velocidad del timer2

            PnlAddData.Width = 1; // Ancho mínimo inicial para evitar ocultar controles
            PnlAddData.Visible = false; // Inicia oculto

            Pnl_Info.Width = 0; // Panel de Info inicia cerrado
            Pnl_Info.Visible = false;
        }

        private void ActualizarVisibilidad()
        {
            // Verificar si ambos paneles están completamente cerrados
            bool ambosCerrados = (PnlAddData.Width == 0 || !PnlAddData.Visible) &&
                                 (Pnl_Info.Width == 0 || !Pnl_Info.Visible);

            // Mostrar u ocultar elementos en función del estado de los paneles
            Pnl_Total.Visible = ambosCerrados;
            Pnl_Pagos.Visible = ambosCerrados;
            lbl_metodos.Visible = ambosCerrados;
            lbl_iva.Visible = ambosCerrados;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int panelSpeed = 30;
            int panelTargetWidth = 315;

            if (openingID)
            {
                // Abrir el panel
                if (PnlAddData.Width < panelTargetWidth)
                {
                    PnlAddData.Width += panelSpeed;
                    PnlAddData.Left -= panelSpeed;
                }
                else
                {
                    PnlAddData.Width = panelTargetWidth;
                    timer2.Stop();
                }
            }
            else
            {
                // Cerrar el panel
                if (PnlAddData.Width > 0)
                {
                    PnlAddData.Width -= panelSpeed;
                    PnlAddData.Left += panelSpeed;
                }
                else
                {
                    PnlAddData.Width = 0;
                    PnlAddData.Visible = false;
                    timer2.Stop();
                }
            }

            ActualizarVisibilidad(); // Actualizar visibilidad durante la animación
        }


        private void timer3_Tick(object sender, EventArgs e)
        {
            int panelSpeed = 30;
            int panelTargetWidth = 460;

            if (isOpening)
            {
                // Abrir el panel
                if (Pnl_Info.Width < panelTargetWidth)
                {
                    Pnl_Info.Width += panelSpeed;
                }
                else
                {
                    Pnl_Info.Width = panelTargetWidth;
                    timer3.Stop();
                }
            }
            else
            {
                // Cerrar el panel
                if (Pnl_Info.Width > 0)
                {
                    Pnl_Info.Width -= panelSpeed;
                }
                else
                {
                    Pnl_Info.Width = 0;
                    Pnl_Info.Visible = false;
                    timer3.Stop();
                }
            }

            ActualizarVisibilidad(); // Actualizar visibilidad durante la animación
        }


        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Pnl_Info.Visible && Pnl_Info.Width > 0)
            {
                isOpening = false;
                timer3.Start();
            }

            PnlAddData.Left = this.Width;
            PnlAddData.Width = 0;
            PnlAddData.Visible = true; // Mostrar panel
            openingID = true;
            timer2.Start();

            ActualizarVisibilidad(); // Actualizar visibilidad al abrir el panel
        }


        private void BtnTarjeta_Click(object sender, EventArgs e)
        {
            if (PnlAddData.Visible && PnlAddData.Width > 0)
            {
                openingID = false;
                timer2.Start();
            }

            Pnl_Info.Left = 0;
            Pnl_Info.Width = 0;
            Pnl_Info.Visible = true; // Mostrar panel
            isOpening = true;
            timer3.Start();

            ActualizarVisibilidad(); // Actualizar visibilidad al abrir el panel
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            isOpening = false; // Indica que se va a cerrar Pnl_Info
            timer3.Start(); // Iniciar animación
        }

        private void btn_cancel_id_Click(object sender, EventArgs e)
        {
            openingID = false;
            timer2.Start();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            customerName = textBoxName.Text;
            date = dateTimePickerNote.Text;
            creditCardNumber = textBoxCreditCard.Text;
            CVV = textBoxCVV.Text;
            // obtener el total y la lista de productos !!!!!!

            // Ruta de guardado (Desktop)
            FileStream filePath = new FileStream(@"C:\Users\Usuario\Documents\Nota.pdf", FileMode.Create); // Carpeta 
            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7); // Tipo de documento y margenes
            
            // CREATE PDF
            try
            {
                // Verificar si la carpeta existe
                if (!Directory.Exists(folderPath))
                {
                    MessageBox.Show("La carpeta especificada no existe.");
                    return;
                }

                using (var writer = new PdfWriter(filePath))
                {
                    using (var pdf = new PdfDocument(writer))
                    {
                        var document = new Document(pdf);

                        // Título del PDF
                        document.Add(new Paragraph("Nota de Compra").SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER).SetFontSize(18));

                        // Logo
                        string imagePath = @"C:\Users\darel\source\repos\FinalProject\Properties\ticketsIcon.png";  // Ruta
                                                                                                                    //if (File.Exists(imagePath))
                                                                                                                    //{
                                                                                                                    //    var image = iText.Layout.Element.ImageDataFactory.Create(imagePath);
                                                                                                                    //   document.Add(new Image(image).SetWidth(100).SetHeight(100).SetFixedPosition(450, 750)); // Puedes cambiar las coordenadas
                                                                                                                    //}

                        string slogan = "Lo bueno del cine es que durante dos horas los problemas son de otros";
                        document.Add(new Paragraph($"Cliente: {slogan}").SetFontSize(13)); // Eslogan

                        document.Add(new Paragraph($"Cliente: {date}").SetFontSize(12)); // Nombre del cliente
                        document.Add(new Paragraph($"Cliente: {customerName}").SetFontSize(12)); // Fecha de compra
                        document.Add(new Paragraph($"Cliente: {creditCardNumber}").SetFontSize(12)); // Número de tarjeta
                        document.Add(new Paragraph($"Cliente: {CVV}").SetFontSize(12));

                        // Agregar lista de productos
                        //foreach (var item in items)
                        //{
                        //    document.Add(new Paragraph(item.ToString()).SetFontSize(12));
                        //}

                        // Total 
                        //document.Add(new Paragraph($"Total: {total}").SetFontSize(12).SetBold());

                        //AUMENTAR 6% impuesto al total
                        //int impuesto = (total * 0.94);
                        //document.Add(new Paragraph($"Total con impuestos: {impuesto}").SetFontSize(12));
                        MessageBox.Show($"PDF generado exitosamente. Guardado en: {filePath}");
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error
                MessageBox.Show($"Ocurrió un error al generar el PDF: {ex.Message}");
            }       
        }
    }
}
