﻿namespace WinFormsFinalProyect
{
    partial class Frm_Agregar
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
            Btn_Close_Page = new PictureBox();
            Btn_Agregar = new Button();
            PnlAddData = new Panel();
            PnlAddPage = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            Pic_photo = new PictureBox();
            TextBoxID = new TextBox();
            panel2 = new Panel();
            Btn_Delete = new Button();
            Btn_Open = new Button();
            PnlAddTop = new Panel();
            label1 = new Label();
            button2 = new Button();
            BtnCancel = new Button();
            Contenedor_Peliculas = new FlowLayoutPanel();
            timer1 = new System.Windows.Forms.Timer(components);
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Close_Page).BeginInit();
            PnlAddData.SuspendLayout();
            PnlAddPage.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_photo).BeginInit();
            panel2.SuspendLayout();
            PnlAddTop.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 90F));
            tableLayoutPanel1.Controls.Add(Btn_Close_Page, 1, 0);
            tableLayoutPanel1.Controls.Add(Btn_Agregar, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(2);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(824, 60);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // Btn_Close_Page
            // 
            Btn_Close_Page.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Close_Page.BackColor = Color.Transparent;
            Btn_Close_Page.Image = Properties.Resources.icon_ejemplo;
            Btn_Close_Page.Location = new Point(774, 5);
            Btn_Close_Page.Name = "Btn_Close_Page";
            Btn_Close_Page.Size = new Size(45, 43);
            Btn_Close_Page.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Close_Page.TabIndex = 19;
            Btn_Close_Page.TabStop = false;
            Btn_Close_Page.Click += Btn_Close_Page_Click;
            // 
            // Btn_Agregar
            // 
            Btn_Agregar.BackColor = Color.DarkRed;
            Btn_Agregar.Dock = DockStyle.Left;
            Btn_Agregar.FlatAppearance.BorderSize = 0;
            Btn_Agregar.FlatStyle = FlatStyle.Flat;
            Btn_Agregar.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Agregar.ForeColor = SystemColors.Control;
            Btn_Agregar.Location = new Point(5, 5);
            Btn_Agregar.Name = "Btn_Agregar";
            Btn_Agregar.Size = new Size(170, 50);
            Btn_Agregar.TabIndex = 20;
            Btn_Agregar.Text = "Agregar";
            Btn_Agregar.UseVisualStyleBackColor = false;
            Btn_Agregar.Click += Btn_Agregar_Click;
            // 
            // PnlAddData
            // 
            PnlAddData.BackColor = Color.DarkRed;
            PnlAddData.Controls.Add(PnlAddPage);
            PnlAddData.Controls.Add(PnlAddTop);
            PnlAddData.Dock = DockStyle.Right;
            PnlAddData.Location = new Point(529, 65);
            PnlAddData.Name = "PnlAddData";
            PnlAddData.Size = new Size(300, 530);
            PnlAddData.TabIndex = 4;
            PnlAddData.Visible = false;
            // 
            // PnlAddPage
            // 
            PnlAddPage.AutoScroll = true;
            PnlAddPage.Controls.Add(tableLayoutPanel2);
            PnlAddPage.Dock = DockStyle.Fill;
            PnlAddPage.Location = new Point(0, 52);
            PnlAddPage.Margin = new Padding(0);
            PnlAddPage.Name = "PnlAddPage";
            PnlAddPage.Padding = new Padding(10, 5, 10, 5);
            PnlAddPage.Size = new Size(300, 478);
            PnlAddPage.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333359F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            tableLayoutPanel2.Controls.Add(textBox4, 0, 11);
            tableLayoutPanel2.Controls.Add(label6, 0, 10);
            tableLayoutPanel2.Controls.Add(textBox3, 0, 9);
            tableLayoutPanel2.Controls.Add(label5, 0, 8);
            tableLayoutPanel2.Controls.Add(textBox2, 0, 7);
            tableLayoutPanel2.Controls.Add(label4, 0, 6);
            tableLayoutPanel2.Controls.Add(textBox1, 0, 5);
            tableLayoutPanel2.Controls.Add(label3, 0, 4);
            tableLayoutPanel2.Controls.Add(label2, 0, 0);
            tableLayoutPanel2.Controls.Add(Pic_photo, 2, 0);
            tableLayoutPanel2.Controls.Add(TextBoxID, 0, 1);
            tableLayoutPanel2.Controls.Add(panel2, 2, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(10, 5);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(5);
            tableLayoutPanel2.RowCount = 17;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel2.Size = new Size(280, 468);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            tableLayoutPanel2.SetColumnSpan(textBox4, 3);
            textBox4.Dock = DockStyle.Fill;
            textBox4.Location = new Point(10, 335);
            textBox4.Margin = new Padding(5, 0, 5, 0);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(260, 100);
            textBox4.TabIndex = 18;
            // 
            // label6
            // 
            tableLayoutPanel2.SetColumnSpan(label6, 2);
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(10, 305);
            label6.Margin = new Padding(5, 0, 0, 0);
            label6.Name = "label6";
            label6.Size = new Size(174, 30);
            label6.TabIndex = 17;
            label6.Text = "Descripción";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            tableLayoutPanel2.SetColumnSpan(textBox3, 3);
            textBox3.Dock = DockStyle.Fill;
            textBox3.Location = new Point(10, 275);
            textBox3.Margin = new Padding(5, 0, 5, 0);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(260, 30);
            textBox3.TabIndex = 16;
            // 
            // label5
            // 
            tableLayoutPanel2.SetColumnSpan(label5, 2);
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(10, 245);
            label5.Margin = new Padding(5, 0, 0, 0);
            label5.Name = "label5";
            label5.Size = new Size(174, 30);
            label5.TabIndex = 15;
            label5.Text = "Existencias";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            tableLayoutPanel2.SetColumnSpan(textBox2, 3);
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(10, 215);
            textBox2.Margin = new Padding(5, 0, 5, 0);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(260, 30);
            textBox2.TabIndex = 14;
            // 
            // label4
            // 
            tableLayoutPanel2.SetColumnSpan(label4, 2);
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(10, 185);
            label4.Margin = new Padding(5, 0, 0, 0);
            label4.Name = "label4";
            label4.Size = new Size(174, 30);
            label4.TabIndex = 13;
            label4.Text = "Precio";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            tableLayoutPanel2.SetColumnSpan(textBox1, 3);
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(10, 155);
            textBox1.Margin = new Padding(5, 0, 5, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(260, 30);
            textBox1.TabIndex = 12;
            // 
            // label3
            // 
            tableLayoutPanel2.SetColumnSpan(label3, 2);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(10, 125);
            label3.Margin = new Padding(5, 0, 0, 0);
            label3.Name = "label3";
            label3.Size = new Size(174, 30);
            label3.TabIndex = 11;
            label3.Text = "Imagen";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(8, 5);
            label2.Name = "label2";
            label2.Size = new Size(83, 30);
            label2.TabIndex = 8;
            label2.Text = "ID";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Pic_photo
            // 
            Pic_photo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Pic_photo.BackColor = Color.Transparent;
            Pic_photo.Image = Properties.Resources.icon_ejemplo;
            Pic_photo.Location = new Point(196, 8);
            Pic_photo.Name = "Pic_photo";
            tableLayoutPanel2.SetRowSpan(Pic_photo, 3);
            Pic_photo.Size = new Size(76, 84);
            Pic_photo.SizeMode = PictureBoxSizeMode.Zoom;
            Pic_photo.TabIndex = 7;
            Pic_photo.TabStop = false;
            // 
            // TextBoxID
            // 
            TextBoxID.BorderStyle = BorderStyle.None;
            TextBoxID.Dock = DockStyle.Fill;
            TextBoxID.Location = new Point(8, 38);
            TextBoxID.Multiline = true;
            TextBoxID.Name = "TextBoxID";
            TextBoxID.Size = new Size(83, 24);
            TextBoxID.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.Controls.Add(Btn_Delete);
            panel2.Controls.Add(Btn_Open);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(184, 95);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(91, 30);
            panel2.TabIndex = 10;
            // 
            // Btn_Delete
            // 
            Btn_Delete.BackColor = Color.DarkRed;
            Btn_Delete.FlatAppearance.BorderSize = 0;
            Btn_Delete.FlatStyle = FlatStyle.Flat;
            Btn_Delete.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Delete.ForeColor = SystemColors.Control;
            Btn_Delete.Location = new Point(0, 0);
            Btn_Delete.Name = "Btn_Delete";
            Btn_Delete.Size = new Size(32, 30);
            Btn_Delete.TabIndex = 5;
            Btn_Delete.Text = "X";
            Btn_Delete.UseVisualStyleBackColor = false;
            Btn_Delete.Click += Btn_Delete_Click;
            // 
            // Btn_Open
            // 
            Btn_Open.BackColor = Color.DarkRed;
            Btn_Open.Dock = DockStyle.Right;
            Btn_Open.FlatAppearance.BorderSize = 0;
            Btn_Open.FlatStyle = FlatStyle.Flat;
            Btn_Open.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_Open.ForeColor = SystemColors.Control;
            Btn_Open.Location = new Point(38, 0);
            Btn_Open.Name = "Btn_Open";
            Btn_Open.Size = new Size(53, 30);
            Btn_Open.TabIndex = 4;
            Btn_Open.Text = "File";
            Btn_Open.UseVisualStyleBackColor = false;
            Btn_Open.Click += Btn_Open_Click;
            // 
            // PnlAddTop
            // 
            PnlAddTop.Controls.Add(label1);
            PnlAddTop.Controls.Add(button2);
            PnlAddTop.Controls.Add(BtnCancel);
            PnlAddTop.Dock = DockStyle.Top;
            PnlAddTop.Location = new Point(0, 0);
            PnlAddTop.Name = "PnlAddTop";
            PnlAddTop.Size = new Size(300, 52);
            PnlAddTop.TabIndex = 2;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(145, 14);
            label1.Name = "label1";
            label1.Size = new Size(143, 26);
            label1.TabIndex = 4;
            label1.Text = "Ingreso de Datos";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkRed;
            button2.Dock = DockStyle.Left;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(55, 0);
            button2.Name = "button2";
            button2.Size = new Size(55, 52);
            button2.TabIndex = 3;
            button2.Text = "ok";
            button2.UseVisualStyleBackColor = false;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.DarkRed;
            BtnCancel.Dock = DockStyle.Left;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Font = new Font("Nirmala UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancel.ForeColor = SystemColors.Control;
            BtnCancel.Location = new Point(0, 0);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(55, 52);
            BtnCancel.TabIndex = 2;
            BtnCancel.Text = "x";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // Contenedor_Peliculas
            // 
            Contenedor_Peliculas.BackColor = SystemColors.Info;
            Contenedor_Peliculas.Location = new Point(5, 71);
            Contenedor_Peliculas.Name = "Contenedor_Peliculas";
            Contenedor_Peliculas.Size = new Size(819, 519);
            Contenedor_Peliculas.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // Frm_Agregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 600);
            Controls.Add(PnlAddData);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(Contenedor_Peliculas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Agregar";
            Padding = new Padding(5, 5, 0, 5);
            Text = "Frm_Agregar";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Btn_Close_Page).EndInit();
            PnlAddData.ResumeLayout(false);
            PnlAddPage.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_photo).EndInit();
            panel2.ResumeLayout(false);
            PnlAddTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel PnlAddData;
        private Panel PnlAddPage;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private PictureBox Pic_photo;
        private TextBox TextBoxID;
        private Panel panel2;
        private Button Btn_Delete;
        private Button Btn_Open;
        private Panel PnlAddTop;
        private Label label1;
        private Button button2;
        private Button BtnCancel;
        private FlowLayoutPanel Contenedor_Peliculas;
        private System.Windows.Forms.Timer timer1;
        private PictureBox Btn_Close_Page;
        private Button Btn_Agregar;
    }
}