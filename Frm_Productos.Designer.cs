namespace WinFormsFinalProyect
{
    partial class Frm_Productos
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
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            Btn_Close_Page = new PictureBox();
            Contenedor_Peliculas = new FlowLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            pbMovie8 = new PictureBox();
            pbMovie7 = new PictureBox();
            pbMovie6 = new PictureBox();
            pbMovie5 = new PictureBox();
            pbMovie4 = new PictureBox();
            pbMovie3 = new PictureBox();
            pbMovie2 = new PictureBox();
            pbMovie1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Close_Page).BeginInit();
            Contenedor_Peliculas.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbMovie8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMovie7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMovie6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMovie5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMovie4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMovie3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMovie2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMovie1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(Btn_Close_Page, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(2);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(829, 60);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(5, 2);
            label4.Name = "label4";
            label4.Size = new Size(332, 56);
            label4.TabIndex = 5;
            label4.Text = "Peliculas Disponibles";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Btn_Close_Page
            // 
            Btn_Close_Page.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Close_Page.BackColor = Color.Transparent;
            Btn_Close_Page.Image = Properties.Resources.cerrar;
            Btn_Close_Page.Location = new Point(779, 5);
            Btn_Close_Page.Name = "Btn_Close_Page";
            Btn_Close_Page.Size = new Size(45, 43);
            Btn_Close_Page.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Close_Page.TabIndex = 19;
            Btn_Close_Page.TabStop = false;
            Btn_Close_Page.Click += Btn_Close_Page_Click;
            // 
            // Contenedor_Peliculas
            // 
            Contenedor_Peliculas.BackColor = SystemColors.Control;
            Contenedor_Peliculas.Controls.Add(tableLayoutPanel2);
            Contenedor_Peliculas.FlowDirection = FlowDirection.TopDown;
            Contenedor_Peliculas.Location = new Point(56, 77);
            Contenedor_Peliculas.Name = "Contenedor_Peliculas";
            Contenedor_Peliculas.Size = new Size(716, 511);
            Contenedor_Peliculas.TabIndex = 9;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 4;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(pbMovie8, 3, 1);
            tableLayoutPanel2.Controls.Add(pbMovie7, 2, 1);
            tableLayoutPanel2.Controls.Add(pbMovie6, 1, 1);
            tableLayoutPanel2.Controls.Add(pbMovie5, 0, 1);
            tableLayoutPanel2.Controls.Add(pbMovie4, 3, 0);
            tableLayoutPanel2.Controls.Add(pbMovie3, 2, 0);
            tableLayoutPanel2.Controls.Add(pbMovie2, 1, 0);
            tableLayoutPanel2.Controls.Add(pbMovie1, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(713, 508);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // pbMovie8
            // 
            pbMovie8.Location = new Point(537, 257);
            pbMovie8.Name = "pbMovie8";
            pbMovie8.Size = new Size(172, 248);
            pbMovie8.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMovie8.TabIndex = 7;
            pbMovie8.TabStop = false;
            // 
            // pbMovie7
            // 
            pbMovie7.Location = new Point(359, 257);
            pbMovie7.Name = "pbMovie7";
            pbMovie7.Size = new Size(172, 248);
            pbMovie7.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMovie7.TabIndex = 6;
            pbMovie7.TabStop = false;
            // 
            // pbMovie6
            // 
            pbMovie6.Location = new Point(181, 257);
            pbMovie6.Name = "pbMovie6";
            pbMovie6.Size = new Size(172, 248);
            pbMovie6.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMovie6.TabIndex = 5;
            pbMovie6.TabStop = false;
            // 
            // pbMovie5
            // 
            pbMovie5.Location = new Point(3, 257);
            pbMovie5.Name = "pbMovie5";
            pbMovie5.Size = new Size(172, 248);
            pbMovie5.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMovie5.TabIndex = 4;
            pbMovie5.TabStop = false;
            // 
            // pbMovie4
            // 
            pbMovie4.Location = new Point(537, 3);
            pbMovie4.Name = "pbMovie4";
            pbMovie4.Size = new Size(172, 248);
            pbMovie4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMovie4.TabIndex = 3;
            pbMovie4.TabStop = false;
            // 
            // pbMovie3
            // 
            pbMovie3.Location = new Point(359, 3);
            pbMovie3.Name = "pbMovie3";
            pbMovie3.Size = new Size(172, 248);
            pbMovie3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMovie3.TabIndex = 2;
            pbMovie3.TabStop = false;
            // 
            // pbMovie2
            // 
            pbMovie2.Location = new Point(181, 3);
            pbMovie2.Name = "pbMovie2";
            pbMovie2.Size = new Size(172, 248);
            pbMovie2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMovie2.TabIndex = 1;
            pbMovie2.TabStop = false;
            // 
            // pbMovie1
            // 
            pbMovie1.Location = new Point(3, 3);
            pbMovie1.Name = "pbMovie1";
            pbMovie1.Size = new Size(172, 248);
            pbMovie1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMovie1.TabIndex = 0;
            pbMovie1.TabStop = false;
            pbMovie1.Click += pictureBox1_Click_1;
            // 
            // Frm_Productos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 600);
            Controls.Add(Contenedor_Peliculas);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Productos";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Btn_Close_Page).EndInit();
            Contenedor_Peliculas.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbMovie8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMovie7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMovie6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMovie5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMovie4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMovie3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMovie2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMovie1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox Btn_Close_Page;
        private FlowLayoutPanel Contenedor_Peliculas;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pbMovie8;
        private PictureBox pbMovie7;
        private PictureBox pbMovie6;
        private PictureBox pbMovie5;
        private PictureBox pbMovie4;
        private PictureBox pbMovie3;
        private PictureBox pbMovie2;
        private PictureBox pbMovie1;
    }
}