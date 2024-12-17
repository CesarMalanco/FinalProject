namespace Forms_individuales_proyecto
{
    partial class Frm_Carrito
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            label9 = new Label();
            Btn_Eliminar = new Button();
            PnlAddData = new Panel();
            PnlAddPage = new Panel();
            panelContenedor = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            Pic_photo = new PictureBox();
            TextBoxID = new TextBox();
            panel2 = new Panel();
            Btn_Buscar = new Button();
            PnlAddTop = new Panel();
            btn_cancel_id = new Button();
            label1 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            grid_productos = new DataGridView();
            tableLayoutPanel4 = new TableLayoutPanel();
            BtnTarjeta = new Button();
            Pnl_Info = new Panel();
            panel3 = new Panel();
            tableLayoutPanel5 = new TableLayoutPanel();
            panel4 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label7 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            panel5 = new Panel();
            BtnOK = new Button();
            label4 = new Label();
            Btn_Cancel = new Button();
            timer2 = new System.Windows.Forms.Timer(components);
            timer3 = new System.Windows.Forms.Timer(components);
            Pnl_Total = new TableLayoutPanel();
            pictureBox2 = new PictureBox();
            label8 = new Label();
            Pnl_Pagos = new TableLayoutPanel();
            button2 = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            lbl_metodos = new Label();
            lbl_iva = new Label();
            tableLayoutPanel1.SuspendLayout();
            PnlAddData.SuspendLayout();
            PnlAddPage.SuspendLayout();
            panelContenedor.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_photo).BeginInit();
            PnlAddTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid_productos).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            Pnl_Info.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            Pnl_Total.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Pnl_Pagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 79F));
            tableLayoutPanel1.Controls.Add(label9, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(9, 8);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(2);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 64F));
            tableLayoutPanel1.Size = new Size(1048, 68);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Dock = DockStyle.Fill;
            label9.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(5, 2);
            label9.Name = "label9";
            label9.Size = new Size(959, 64);
            label9.TabIndex = 17;
            label9.Text = "Carrito";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Btn_Eliminar
            // 
            Btn_Eliminar.BackColor = Color.Black;
            Btn_Eliminar.FlatAppearance.BorderSize = 0;
            Btn_Eliminar.FlatStyle = FlatStyle.Flat;
            Btn_Eliminar.Font = new Font("Impact", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Eliminar.ForeColor = SystemColors.Control;
            Btn_Eliminar.Location = new Point(5, 4);
            Btn_Eliminar.Margin = new Padding(3, 2, 3, 2);
            Btn_Eliminar.Name = "Btn_Eliminar";
            Btn_Eliminar.Size = new Size(227, 60);
            Btn_Eliminar.TabIndex = 21;
            Btn_Eliminar.Text = "Eliminar Producto";
            Btn_Eliminar.UseVisualStyleBackColor = false;
            Btn_Eliminar.Click += Btn_Eliminar_Click;
            // 
            // PnlAddData
            // 
            PnlAddData.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PnlAddData.BackColor = Color.DarkRed;
            PnlAddData.Controls.Add(PnlAddPage);
            PnlAddData.Location = new Point(781, 105);
            PnlAddData.Margin = new Padding(3, 2, 3, 2);
            PnlAddData.Name = "PnlAddData";
            PnlAddData.Size = new Size(276, 141);
            PnlAddData.TabIndex = 9;
            PnlAddData.Visible = false;
            // 
            // PnlAddPage
            // 
            PnlAddPage.AutoScroll = true;
            PnlAddPage.Controls.Add(panelContenedor);
            PnlAddPage.Controls.Add(PnlAddTop);
            PnlAddPage.Location = new Point(16, 0);
            PnlAddPage.Margin = new Padding(0);
            PnlAddPage.Name = "PnlAddPage";
            PnlAddPage.Padding = new Padding(9, 4, 9, 4);
            PnlAddPage.Size = new Size(260, 141);
            PnlAddPage.TabIndex = 3;
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(tableLayoutPanel2);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(9, 43);
            panelContenedor.Margin = new Padding(3, 2, 3, 2);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(242, 94);
            panelContenedor.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(Pic_photo, 2, 0);
            tableLayoutPanel2.Controls.Add(TextBoxID, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 2, 3);
            tableLayoutPanel2.Controls.Add(Btn_Buscar, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(4, 4, 4, 4);
            tableLayoutPanel2.RowCount = 17;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 75F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel2.Size = new Size(242, 94);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(7, 4);
            label2.Name = "label2";
            label2.Size = new Size(71, 22);
            label2.TabIndex = 8;
            label2.Text = "ID";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Pic_photo
            // 
            Pic_photo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pic_photo.BackColor = Color.Transparent;
            Pic_photo.Location = new Point(172, 6);
            Pic_photo.Margin = new Padding(3, 2, 3, 2);
            Pic_photo.Name = "Pic_photo";
            tableLayoutPanel2.SetRowSpan(Pic_photo, 3);
            Pic_photo.Size = new Size(63, 62);
            Pic_photo.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_photo.TabIndex = 7;
            Pic_photo.TabStop = false;
            // 
            // TextBoxID
            // 
            TextBoxID.BorderStyle = BorderStyle.None;
            tableLayoutPanel2.SetColumnSpan(TextBoxID, 2);
            TextBoxID.Dock = DockStyle.Fill;
            TextBoxID.Location = new Point(7, 28);
            TextBoxID.Margin = new Padding(3, 2, 3, 2);
            TextBoxID.Multiline = true;
            TextBoxID.Name = "TextBoxID";
            TextBoxID.Size = new Size(149, 18);
            TextBoxID.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(159, 70);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(79, 22);
            panel2.TabIndex = 10;
            // 
            // Btn_Buscar
            // 
            Btn_Buscar.BackColor = Color.MistyRose;
            Btn_Buscar.Dock = DockStyle.Fill;
            Btn_Buscar.FlatAppearance.BorderSize = 0;
            Btn_Buscar.FlatStyle = FlatStyle.Flat;
            Btn_Buscar.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Buscar.ForeColor = SystemColors.ActiveCaptionText;
            Btn_Buscar.Location = new Point(7, 50);
            Btn_Buscar.Margin = new Padding(3, 2, 3, 2);
            Btn_Buscar.Name = "Btn_Buscar";
            Btn_Buscar.Size = new Size(71, 18);
            Btn_Buscar.TabIndex = 21;
            Btn_Buscar.Text = "Eliminar";
            Btn_Buscar.UseVisualStyleBackColor = false;
            // 
            // PnlAddTop
            // 
            PnlAddTop.Controls.Add(btn_cancel_id);
            PnlAddTop.Controls.Add(label1);
            PnlAddTop.Dock = DockStyle.Top;
            PnlAddTop.Location = new Point(9, 4);
            PnlAddTop.Margin = new Padding(3, 2, 3, 2);
            PnlAddTop.Name = "PnlAddTop";
            PnlAddTop.Size = new Size(242, 39);
            PnlAddTop.TabIndex = 2;
            // 
            // btn_cancel_id
            // 
            btn_cancel_id.BackColor = Color.DarkRed;
            btn_cancel_id.Dock = DockStyle.Right;
            btn_cancel_id.FlatAppearance.BorderSize = 0;
            btn_cancel_id.FlatStyle = FlatStyle.Flat;
            btn_cancel_id.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancel_id.ForeColor = SystemColors.Control;
            btn_cancel_id.Location = new Point(194, 0);
            btn_cancel_id.Margin = new Padding(3, 2, 3, 2);
            btn_cancel_id.Name = "btn_cancel_id";
            btn_cancel_id.Size = new Size(48, 39);
            btn_cancel_id.TabIndex = 5;
            btn_cancel_id.Text = "x";
            btn_cancel_id.UseVisualStyleBackColor = false;
            btn_cancel_id.Click += btn_cancel_id_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(7, 10);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 4;
            label1.Text = "Buscar ID";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 79F));
            tableLayoutPanel3.Dock = DockStyle.Top;
            tableLayoutPanel3.Location = new Point(9, 76);
            tableLayoutPanel3.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(2);
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 19F));
            tableLayoutPanel3.Size = new Size(1048, 22);
            tableLayoutPanel3.TabIndex = 10;
            // 
            // grid_productos
            // 
            grid_productos.BackgroundColor = SystemColors.Info;
            grid_productos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid_productos.Location = new Point(9, 97);
            grid_productos.Margin = new Padding(4, 4, 4, 4);
            grid_productos.Name = "grid_productos";
            grid_productos.RowHeadersWidth = 51;
            grid_productos.RowTemplate.Height = 29;
            grid_productos.Size = new Size(601, 346);
            grid_productos.TabIndex = 11;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 79F));
            tableLayoutPanel4.Controls.Add(Btn_Eliminar, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(9, 448);
            tableLayoutPanel4.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(2);
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 71F));
            tableLayoutPanel4.Size = new Size(1048, 74);
            tableLayoutPanel4.TabIndex = 12;
            // 
            // BtnTarjeta
            // 
            BtnTarjeta.BackColor = Color.DarkRed;
            BtnTarjeta.Dock = DockStyle.Fill;
            BtnTarjeta.FlatAppearance.BorderSize = 0;
            BtnTarjeta.FlatStyle = FlatStyle.Flat;
            BtnTarjeta.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            BtnTarjeta.ForeColor = SystemColors.Control;
            BtnTarjeta.Location = new Point(91, 97);
            BtnTarjeta.Margin = new Padding(3, 2, 3, 2);
            BtnTarjeta.Name = "BtnTarjeta";
            BtnTarjeta.Size = new Size(344, 91);
            BtnTarjeta.TabIndex = 22;
            BtnTarjeta.Text = "Tarjeta";
            BtnTarjeta.TextAlign = ContentAlignment.MiddleLeft;
            BtnTarjeta.UseVisualStyleBackColor = false;
            BtnTarjeta.Click += BtnTarjeta_Click;
            // 
            // Pnl_Info
            // 
            Pnl_Info.AutoScroll = true;
            Pnl_Info.BackColor = Color.DarkRed;
            Pnl_Info.Controls.Add(panel3);
            Pnl_Info.Controls.Add(panel5);
            Pnl_Info.Dock = DockStyle.Right;
            Pnl_Info.Location = new Point(655, 98);
            Pnl_Info.Margin = new Padding(3, 2, 3, 2);
            Pnl_Info.Name = "Pnl_Info";
            Pnl_Info.Size = new Size(402, 350);
            Pnl_Info.TabIndex = 13;
            Pnl_Info.Visible = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(tableLayoutPanel5);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 39);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(9, 4, 9, 4);
            panel3.Size = new Size(402, 311);
            panel3.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.AutoScroll = true;
            tableLayoutPanel5.ColumnCount = 4;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel5.Controls.Add(panel4, 2, 3);
            tableLayoutPanel5.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel5.Controls.Add(textBox2, 0, 5);
            tableLayoutPanel5.Controls.Add(dateTimePicker1, 0, 11);
            tableLayoutPanel5.Controls.Add(label7, 0, 10);
            tableLayoutPanel5.Controls.Add(textBox1, 2, 11);
            tableLayoutPanel5.Controls.Add(label3, 2, 10);
            tableLayoutPanel5.Controls.Add(label5, 0, 7);
            tableLayoutPanel5.Controls.Add(textBox3, 0, 8);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(9, 4);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.Padding = new Padding(4, 4, 4, 4);
            tableLayoutPanel5.RowCount = 13;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 22F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tableLayoutPanel5.Size = new Size(384, 303);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(label6);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(4, 92);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(94, 22);
            panel4.TabIndex = 10;
            // 
            // label6
            // 
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(18, 0);
            label6.Name = "label6";
            label6.Size = new Size(81, 22);
            label6.TabIndex = 13;
            label6.Text = "Nombre:";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.White;
            tableLayoutPanel5.SetColumnSpan(pictureBox1, 4);
            pictureBox1.Location = new Point(69, 6);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            tableLayoutPanel5.SetRowSpan(pictureBox1, 4);
            pictureBox1.Size = new Size(246, 84);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            tableLayoutPanel5.SetColumnSpan(textBox2, 4);
            textBox2.Location = new Point(22, 116);
            textBox2.Margin = new Padding(18, 2, 18, 2);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(289, 18);
            textBox2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            tableLayoutPanel5.SetColumnSpan(dateTimePicker1, 2);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(22, 248);
            dateTimePicker1.Margin = new Padding(18, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(141, 23);
            dateTimePicker1.TabIndex = 15;
            // 
            // label7
            // 
            tableLayoutPanel5.SetColumnSpan(label7, 2);
            label7.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(22, 224);
            label7.Margin = new Padding(18, 0, 3, 0);
            label7.Name = "label7";
            label7.Size = new Size(99, 22);
            label7.TabIndex = 14;
            label7.Text = "Vencimiento:";
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            tableLayoutPanel5.SetColumnSpan(textBox1, 2);
            textBox1.Location = new Point(210, 248);
            textBox1.Margin = new Padding(18, 2, 18, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(128, 18);
            textBox1.TabIndex = 17;
            // 
            // label3
            // 
            tableLayoutPanel5.SetColumnSpan(label3, 2);
            label3.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(210, 224);
            label3.Margin = new Padding(18, 0, 3, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 22);
            label3.TabIndex = 16;
            label3.Text = "CVV:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            tableLayoutPanel5.SetColumnSpan(label5, 2);
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(22, 158);
            label5.Margin = new Padding(18, 0, 3, 0);
            label5.Name = "label5";
            label5.Size = new Size(141, 22);
            label5.TabIndex = 11;
            label5.Text = "No. de Tarjeta:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            tableLayoutPanel5.SetColumnSpan(textBox3, 4);
            textBox3.Location = new Point(22, 182);
            textBox3.Margin = new Padding(18, 2, 18, 2);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(289, 18);
            textBox3.TabIndex = 18;
            // 
            // panel5
            // 
            panel5.Controls.Add(BtnOK);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(Btn_Cancel);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(402, 39);
            panel5.TabIndex = 2;
            // 
            // BtnOK
            // 
            BtnOK.BackColor = Color.DarkRed;
            BtnOK.Dock = DockStyle.Left;
            BtnOK.FlatAppearance.BorderSize = 0;
            BtnOK.FlatStyle = FlatStyle.Flat;
            BtnOK.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOK.ForeColor = SystemColors.Control;
            BtnOK.Location = new Point(48, 0);
            BtnOK.Margin = new Padding(3, 2, 3, 2);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(48, 39);
            BtnOK.TabIndex = 5;
            BtnOK.Text = "ok";
            BtnOK.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(172, 10);
            label4.Name = "label4";
            label4.Size = new Size(215, 20);
            label4.TabIndex = 4;
            label4.Text = "Información de Pago";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.BackColor = Color.DarkRed;
            Btn_Cancel.Dock = DockStyle.Left;
            Btn_Cancel.FlatAppearance.BorderSize = 0;
            Btn_Cancel.FlatStyle = FlatStyle.Flat;
            Btn_Cancel.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Cancel.ForeColor = SystemColors.Control;
            Btn_Cancel.Location = new Point(0, 0);
            Btn_Cancel.Margin = new Padding(3, 2, 3, 2);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(48, 39);
            Btn_Cancel.TabIndex = 2;
            Btn_Cancel.Text = "x";
            Btn_Cancel.UseVisualStyleBackColor = false;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // timer2
            // 
            timer2.Interval = 50;
            timer2.Tick += timer2_Tick;
            // 
            // timer3
            // 
            timer3.Interval = 50;
            timer3.Tick += timer3_Tick;
            // 
            // Pnl_Total
            // 
            Pnl_Total.BackColor = Color.DarkRed;
            Pnl_Total.ColumnCount = 2;
            Pnl_Total.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            Pnl_Total.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Pnl_Total.Controls.Add(pictureBox2, 0, 0);
            Pnl_Total.Controls.Add(label8, 1, 0);
            Pnl_Total.Location = new Point(620, 97);
            Pnl_Total.Margin = new Padding(3, 2, 3, 2);
            Pnl_Total.Name = "Pnl_Total";
            Pnl_Total.RowCount = 1;
            Pnl_Total.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            Pnl_Total.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            Pnl_Total.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            Pnl_Total.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            Pnl_Total.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            Pnl_Total.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            Pnl_Total.RowStyles.Add(new RowStyle(SizeType.Absolute, 68F));
            Pnl_Total.Size = new Size(438, 68);
            Pnl_Total.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.White;
            pictureBox2.Location = new Point(18, 15);
            pictureBox2.Margin = new Padding(18, 15, 18, 15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 38);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(91, 0);
            label8.Name = "label8";
            label8.Size = new Size(344, 68);
            label8.TabIndex = 1;
            label8.Text = "$0.00";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Pnl_Pagos
            // 
            Pnl_Pagos.BackColor = Color.DarkRed;
            Pnl_Pagos.ColumnCount = 2;
            Pnl_Pagos.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 88F));
            Pnl_Pagos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            Pnl_Pagos.Controls.Add(button2, 1, 0);
            Pnl_Pagos.Controls.Add(BtnTarjeta, 1, 1);
            Pnl_Pagos.Controls.Add(pictureBox4, 0, 1);
            Pnl_Pagos.Controls.Add(pictureBox3, 0, 0);
            Pnl_Pagos.Location = new Point(620, 250);
            Pnl_Pagos.Margin = new Padding(3, 2, 3, 2);
            Pnl_Pagos.Name = "Pnl_Pagos";
            Pnl_Pagos.RowCount = 2;
            Pnl_Pagos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Pnl_Pagos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Pnl_Pagos.Size = new Size(438, 190);
            Pnl_Pagos.TabIndex = 15;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkRed;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(91, 2);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(344, 91);
            button2.TabIndex = 23;
            button2.Text = "Efectivo";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.White;
            pictureBox4.Location = new Point(18, 117);
            pictureBox4.Margin = new Padding(18, 22, 18, 22);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 45);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.White;
            pictureBox3.Location = new Point(18, 22);
            pictureBox3.Margin = new Padding(18, 22, 18, 22);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 50);
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // lbl_metodos
            // 
            lbl_metodos.AutoSize = true;
            lbl_metodos.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_metodos.ForeColor = Color.Black;
            lbl_metodos.Location = new Point(617, 196);
            lbl_metodos.Name = "lbl_metodos";
            lbl_metodos.Size = new Size(176, 29);
            lbl_metodos.TabIndex = 16;
            lbl_metodos.Text = "Métodos de Pago";
            lbl_metodos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbl_iva
            // 
            lbl_iva.Font = new Font("Franklin Gothic Book", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_iva.ForeColor = Color.Black;
            lbl_iva.Location = new Point(637, 224);
            lbl_iva.Name = "lbl_iva";
            lbl_iva.Size = new Size(184, 22);
            lbl_iva.TabIndex = 17;
            lbl_iva.Text = "IVA incluido";
            lbl_iva.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Frm_Carrito
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 530);
            Controls.Add(Pnl_Info);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(grid_productos);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(PnlAddData);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Pnl_Total);
            Controls.Add(lbl_metodos);
            Controls.Add(lbl_iva);
            Controls.Add(Pnl_Pagos);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Frm_Carrito";
            Padding = new Padding(9, 8, 9, 8);
            Text = "Frm_Carrito";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            PnlAddData.ResumeLayout(false);
            PnlAddPage.ResumeLayout(false);
            panelContenedor.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_photo).EndInit();
            PnlAddTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grid_productos).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            Pnl_Info.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            Pnl_Total.ResumeLayout(false);
            Pnl_Total.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Pnl_Pagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button Btn_Eliminar;
        private Panel PnlAddData;
        private Panel PnlAddPage;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private PictureBox Pic_photo;
        private TextBox TextBoxID;
        private Panel panel2;
        private Button Btn_Buscar;
        private Panel PnlAddTop;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel3;
        private DataGridView grid_productos;
        private TableLayoutPanel tableLayoutPanel4;
        private Panel Pnl_Info;
        private Panel panel3;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label7;
        private TextBox textBox2;
        private PictureBox pictureBox1;
        private Panel panel4;
        private Label label6;
        private Label label5;
        private Panel panel5;
        private Label label4;
        private Button Btn_Cancel;
        
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private Button BtnTarjeta;
        private Panel panelContenedor;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox3;
        private Button btn_cancel_id;
        private Button BtnOK;
        private TableLayoutPanel Pnl_Total;
        private PictureBox pictureBox2;
        private Label label8;
        private TableLayoutPanel Pnl_Pagos;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private Label lbl_metodos;
        private Button button2;
        private Label lbl_iva;
        private Label label9;
    }
}