namespace WinFormsFinalProyect
{
    partial class Frm_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            IconRestaurar = new PictureBox();
            Btn_Minimizar = new PictureBox();
            label1 = new Label();
            Btn_Maximizar = new PictureBox();
            pictureBox1 = new PictureBox();
            Btn_Cerrar = new PictureBox();
            panel2 = new Panel();
            button6 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            Pic_photo = new PictureBox();
            panel3 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            Btn_Dulceria = new Button();
            Btn_Productos = new Button();
            PanelContenedor = new Panel();
            PanelPrincipal = new Panel();
            Timer_Hora = new System.Windows.Forms.Timer(components);
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Minimizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Maximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Cerrar).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_photo).BeginInit();
            panel3.SuspendLayout();
            PanelContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(IconRestaurar);
            panel1.Controls.Add(Btn_Minimizar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Btn_Maximizar);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(Btn_Cerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(221, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(829, 50);
            panel1.TabIndex = 0;
            // 
            // IconRestaurar
            // 
            IconRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            IconRestaurar.BackColor = Color.WhiteSmoke;
            IconRestaurar.Image = Properties.Resources.icon_ejemplo;
            IconRestaurar.Location = new Point(761, 12);
            IconRestaurar.Name = "IconRestaurar";
            IconRestaurar.Size = new Size(25, 25);
            IconRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            IconRestaurar.TabIndex = 6;
            IconRestaurar.TabStop = false;
            IconRestaurar.Visible = false;
            // 
            // Btn_Minimizar
            // 
            Btn_Minimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Minimizar.BackColor = Color.WhiteSmoke;
            Btn_Minimizar.Image = Properties.Resources.icon_ejemplo;
            Btn_Minimizar.Location = new Point(730, 12);
            Btn_Minimizar.Name = "Btn_Minimizar";
            Btn_Minimizar.Size = new Size(25, 25);
            Btn_Minimizar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Minimizar.TabIndex = 5;
            Btn_Minimizar.TabStop = false;
            Btn_Minimizar.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DimGray;
            label1.Location = new Point(54, 13);
            label1.Name = "label1";
            label1.Size = new Size(264, 24);
            label1.TabIndex = 2;
            label1.Text = "GrandTheatre - Administrator";
            // 
            // Btn_Maximizar
            // 
            Btn_Maximizar.BackColor = Color.WhiteSmoke;
            Btn_Maximizar.Image = Properties.Resources.icon_ejemplo;
            Btn_Maximizar.Location = new Point(761, 13);
            Btn_Maximizar.Name = "Btn_Maximizar";
            Btn_Maximizar.Size = new Size(25, 25);
            Btn_Maximizar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Maximizar.TabIndex = 4;
            Btn_Maximizar.TabStop = false;
            Btn_Maximizar.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.WhiteSmoke;
            pictureBox1.Image = Properties.Resources.loguitoxd;
            pictureBox1.Location = new Point(23, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Btn_Cerrar
            // 
            Btn_Cerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Cerrar.BackColor = Color.WhiteSmoke;
            Btn_Cerrar.Image = Properties.Resources.icon_ejemplo;
            Btn_Cerrar.Location = new Point(792, 13);
            Btn_Cerrar.Name = "Btn_Cerrar";
            Btn_Cerrar.Size = new Size(25, 25);
            Btn_Cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Cerrar.TabIndex = 3;
            Btn_Cerrar.TabStop = false;
            Btn_Cerrar.Visible = false;
            Btn_Cerrar.Click += Btn_Cerrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkRed;
            panel2.Controls.Add(button6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Pic_photo);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(221, 650);
            panel2.TabIndex = 1;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button6.BackColor = Color.DarkRed;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaptionText;
            button6.FlatAppearance.MouseOverBackColor = Color.Crimson;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Franklin Gothic Demi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Image = Properties.Resources.star_icon_novo_32;
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 595);
            button6.Name = "button6";
            button6.Padding = new Padding(20, 0, 0, 0);
            button6.Size = new Size(220, 52);
            button6.TabIndex = 8;
            button6.Text = "           Salir";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.LightPink;
            label5.Location = new Point(90, 64);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 8;
            label5.Text = "Administrator";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(90, 40);
            label4.Name = "label4";
            label4.Size = new Size(48, 24);
            label4.TabIndex = 6;
            label4.Text = "User";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.BackColor = Color.Black;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.RosyBrown;
            label3.Location = new Point(12, 579);
            label3.Name = "label3";
            label3.Size = new Size(200, 2);
            label3.TabIndex = 7;
            label3.Text = "LLLLLLLLL";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Black;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Microsoft YaHei UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.RosyBrown;
            label2.Location = new Point(12, 115);
            label2.Name = "label2";
            label2.Size = new Size(200, 2);
            label2.TabIndex = 6;
            label2.Text = "LLLLLLLLL";
            // 
            // Pic_photo
            // 
            Pic_photo.BackColor = Color.Transparent;
            Pic_photo.Image = Properties.Resources.admin_logo;
            Pic_photo.Location = new Point(12, 23);
            Pic_photo.Name = "Pic_photo";
            Pic_photo.Size = new Size(72, 74);
            Pic_photo.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_photo.TabIndex = 6;
            Pic_photo.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(button5);
            panel3.Controls.Add(button4);
            panel3.Controls.Add(button3);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(Btn_Dulceria);
            panel3.Controls.Add(Btn_Productos);
            panel3.Location = new Point(3, 129);
            panel3.Name = "panel3";
            panel3.Size = new Size(214, 437);
            panel3.TabIndex = 9;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkRed;
            button5.Cursor = Cursors.Hand;
            button5.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaptionText;
            button5.FlatAppearance.MouseOverBackColor = Color.Crimson;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Franklin Gothic Demi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Image = Properties.Resources.star_icon_novo_32;
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(-3, 350);
            button5.Name = "button5";
            button5.Padding = new Padding(20, 0, 0, 0);
            button5.Size = new Size(220, 73);
            button5.TabIndex = 7;
            button5.Text = "           Gráfica";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkRed;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaptionText;
            button4.FlatAppearance.MouseOverBackColor = Color.Crimson;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Franklin Gothic Demi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Image = Properties.Resources.star_icon_novo_32;
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(-3, 281);
            button4.Name = "button4";
            button4.Padding = new Padding(20, 0, 0, 0);
            button4.Size = new Size(220, 73);
            button4.TabIndex = 6;
            button4.Text = "           Consultas";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkRed;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaptionText;
            button3.FlatAppearance.MouseOverBackColor = Color.Crimson;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Franklin Gothic Demi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Image = Properties.Resources.star_icon_novo_32;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(-3, 212);
            button3.Name = "button3";
            button3.Padding = new Padding(20, 0, 0, 0);
            button3.Size = new Size(220, 73);
            button3.TabIndex = 5;
            button3.Text = "           Bajas";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkRed;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaptionText;
            button2.FlatAppearance.MouseOverBackColor = Color.Crimson;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Franklin Gothic Demi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Image = Properties.Resources.star_icon_novo_32;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(-3, 143);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(220, 73);
            button2.TabIndex = 4;
            button2.Text = "           Altas";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Btn_Dulceria
            // 
            Btn_Dulceria.BackColor = Color.DarkRed;
            Btn_Dulceria.Cursor = Cursors.Hand;
            Btn_Dulceria.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            Btn_Dulceria.FlatAppearance.BorderSize = 0;
            Btn_Dulceria.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaptionText;
            Btn_Dulceria.FlatAppearance.MouseOverBackColor = Color.Crimson;
            Btn_Dulceria.FlatStyle = FlatStyle.Flat;
            Btn_Dulceria.Font = new Font("Franklin Gothic Demi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Dulceria.ForeColor = Color.White;
            Btn_Dulceria.Image = Properties.Resources.star_icon_novo_32;
            Btn_Dulceria.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Dulceria.Location = new Point(-3, 73);
            Btn_Dulceria.Name = "Btn_Dulceria";
            Btn_Dulceria.Padding = new Padding(20, 0, 0, 0);
            Btn_Dulceria.Size = new Size(220, 73);
            Btn_Dulceria.TabIndex = 3;
            Btn_Dulceria.Text = "           Dulcería";
            Btn_Dulceria.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Dulceria.UseVisualStyleBackColor = false;
            Btn_Dulceria.Click += BtnDulceria_Click;
            // 
            // Btn_Productos
            // 
            Btn_Productos.BackColor = Color.DarkRed;
            Btn_Productos.Cursor = Cursors.Hand;
            Btn_Productos.FlatAppearance.BorderColor = SystemColors.ActiveCaptionText;
            Btn_Productos.FlatAppearance.BorderSize = 0;
            Btn_Productos.FlatAppearance.MouseDownBackColor = SystemColors.ActiveCaptionText;
            Btn_Productos.FlatAppearance.MouseOverBackColor = Color.Crimson;
            Btn_Productos.FlatStyle = FlatStyle.Flat;
            Btn_Productos.Font = new Font("Franklin Gothic Demi", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Btn_Productos.ForeColor = Color.White;
            Btn_Productos.Image = Properties.Resources.star_icon_novo_32;
            Btn_Productos.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Productos.Location = new Point(-3, 3);
            Btn_Productos.Name = "Btn_Productos";
            Btn_Productos.Padding = new Padding(20, 0, 0, 0);
            Btn_Productos.Size = new Size(224, 73);
            Btn_Productos.TabIndex = 2;
            Btn_Productos.Text = "          Productos";
            Btn_Productos.TextAlign = ContentAlignment.MiddleLeft;
            Btn_Productos.UseVisualStyleBackColor = false;
            Btn_Productos.Click += Btn_Productos_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PanelContenedor.Controls.Add(PanelPrincipal);
            PanelContenedor.Location = new Point(221, 50);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(829, 600);
            PanelContenedor.TabIndex = 2;
            // 
            // PanelPrincipal
            // 
            PanelPrincipal.Dock = DockStyle.Fill;
            PanelPrincipal.Location = new Point(0, 0);
            PanelPrincipal.Name = "PanelPrincipal";
            PanelPrincipal.Size = new Size(829, 600);
            PanelPrincipal.TabIndex = 13;
            PanelPrincipal.Paint += PanelPrincipal_Paint;
            // 
            // Timer_Hora
            // 
            Timer_Hora.Enabled = true;
            Timer_Hora.Interval = 1000;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 650);
            Controls.Add(PanelContenedor);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IconRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Minimizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Maximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Cerrar).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_photo).EndInit();
            panel3.ResumeLayout(false);
            PanelContenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox Btn_Minimizar;
        private PictureBox Btn_Maximizar;
        private PictureBox Btn_Cerrar;
        private Panel panel2;
        private PictureBox Pic_photo;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel3;
        private Button Btn_Productos;
        private Button Btn_Dulceria;
        private Button button3;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Panel PanelContenedor;
        private System.Windows.Forms.Timer Timer_Hora;
        private Panel PanelPrincipal;
        private PictureBox IconRestaurar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
    }
