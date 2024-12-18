using System;
using System.Windows.Forms;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using System.IO;
using System;
using System.IO;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;



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
            string customerName = textBoxName.Text;
            string date = dateTimePickerNote.Text;
            string creditCardNumber = textBoxCreditCard.Text;
            string CVV = textBoxCVV.Text;

            // Ruta de guardado (Escritorio)
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Nota.pdf");

            try
            {
                // Crear el escritor de PDF
                using (PdfWriter writer = new PdfWriter(filePath))
                {
                    // Crear el documento PDF
                    using (PdfDocument pdfDoc = new PdfDocument(writer))
                    {
                        Document doc = new Document(pdfDoc);

                        // Agregar contenido al documento
                        doc.Add(new Paragraph("Nombre del cliente: " + customerName));
                        doc.Add(new Paragraph("Fecha: " + date));
                        doc.Add(new Paragraph("Número de tarjeta de crédito: " + creditCardNumber));
                        doc.Add(new Paragraph("CVV: " + CVV));
                        doc.Add(new Paragraph("Total: $XXX.XX")); // Ajusta según tu lógica para obtener el total
                        doc.Add(new Paragraph("Lista de productos:")); // Ajusta según tu lógica para obtener los productos
                    }
                }

                MessageBox.Show("PDF creado exitosamente en: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al generar el PDF: " + ex.Message);
            }
            /*
            customerName = textBoxName.Text;
            date = dateTimePickerNote.Text;
            creditCardNumber = textBoxCreditCard.Text;
            CVV = textBoxCVV.Text;
            // obtener el total y la lista de productos !!!!!!

            // Ruta de guardado (Desktop)
            FileStream fs = new FileStream(@"C:\Users\Usuario\Documents\Nota.pdf", FileMode.Create); // Carpeta 
            Document doc = new Document(PageSize.LETTER, 5, 5, 7, 7); // Tipo de documento y margenes
            PdfWriter pw = new PdfWriter.getInstance(doc, fs);

            doc.Open();

            // CREATE PDF
            
            // Definir fuente
            iTextSharp.text.Font standarFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            
            //LOGOTIPO
            // Eslogan
            string slogan = "Lo bueno del cine es que durante dos horas los problemas son de otros";
            doc.Add(new Paragraph(slogan));
            doc.Add(Chunk.NEWLINE);

            // Título
            doc.Add(new Paragraph("NOTA DE COMPRA"));
            doc.Add(Chunk.NEWLINE);

            // Fecha
            doc.Add(new Paragraph($"Fecha: {date}"));
            doc.Add(Chunk.NEWLINE);
            
            // Nombre
            doc.Add(new Paragraph($"Cliente: {customerName}"));
            doc.Add(Chunk.NEWLINE);

            // Tabla
            doc.Add(new Paragraph("Productos adquiridos"));
            doc.Add(Chunk.NEWLINE);

            // Agregar lista de productos

            //TABLA EJEMPLO

            //ENcabezado de columnas
            
            PdfPTable table = new PdfPTable(3); // NUMERO DE COLUMNAS
            table.WidthPercentage = 100;

            //Columnas
            PdfPCell nameCell = new PdfPCell(new Phrase("Nombre", standarFont);
            nameCell.BorderWidth = 0;
            nameCell.BorderWidthBottom = 0.75f;

            PdfPCell Grado = new PdfPCell(new Phrase("Grado", standarFont));
            nameCell.BorderWidth = 0;
            nameCell.BorderWidthBottom = 0.75f;

            PdfPCell Age = new PdfPCell(new Phrase("Edad", standarFont));
            nameCell.BorderWidth = 0;
            nameCell.BorderWidthBottom = 0.75f;

            //Agregar datos en una TABLA
            //foreach (var estudiante in lista)
            {
                nameCell = new PdfPCell(new Phrase(estudiante.nombre, standarFont));
                nameCell.BorderWidth = 0;

                Grado = new PdfPCell(new Phrase(estudiante.grado.ToString(), standarFont));
                Grado.BorderWidth = 0;

                Age = new PdfPCell(new Phrase(estudiante.edad, standarFont));
                nameCell.BorderWidth = 0;

                table.AddCell(nameCell);
                table.AddCell(Grado);
                table.AddCell(Age); 
            }
            //doc.Add(table);
            //doc.Add(Chunk.NEWLINE);

            // Total
            //doc.Add(new Paragraph($"Total sin IVA: {total}"));
            

            // Iva
            //string impuesto = ToString(total * 0.94);
            //doc.Add(new Paragraph($"Total con IVA: {impuesto})";
            
            doc.Close();
            pw.Close();

            MessageBox.Show($"PDF generado exitosamente. Guardado en: {fs}");
             */
        }
    }
}
