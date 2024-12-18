namespace WinFormsFinalProyect
{
    partial class Frm_Grafica
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            Btn_Close_Page = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            panel6 = new Panel();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            label9 = new Label();
            panel7 = new Panel();
            label10 = new Label();
            pictureBox5 = new PictureBox();
            label11 = new Label();
            panel8 = new Panel();
            label12 = new Label();
            pictureBox6 = new PictureBox();
            label13 = new Label();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Btn_Close_Page).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
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
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(2);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(819, 52);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Left;
            label4.Font = new Font("Microsoft YaHei UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ActiveCaptionText;
            label4.Location = new Point(5, 2);
            label4.Name = "label4";
            label4.Size = new Size(332, 48);
            label4.TabIndex = 5;
            label4.Text = "Gráficas";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Btn_Close_Page
            // 
            Btn_Close_Page.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Btn_Close_Page.BackColor = Color.Transparent;
            Btn_Close_Page.Image = Properties.Resources.icon_ejemplo;
            Btn_Close_Page.Location = new Point(769, 5);
            Btn_Close_Page.Name = "Btn_Close_Page";
            Btn_Close_Page.Size = new Size(45, 42);
            Btn_Close_Page.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Close_Page.TabIndex = 19;
            Btn_Close_Page.TabStop = false;
            Btn_Close_Page.Click += Btn_Close_Page_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Location = new Point(12, 239);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 340);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Control;
            panel2.Location = new Point(479, 239);
            panel2.Name = "panel2";
            panel2.Size = new Size(331, 340);
            panel2.TabIndex = 11;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(255, 128, 128);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(12, 63);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(128, 153);
            panel3.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(53, 122);
            label2.Name = "label2";
            label2.Size = new Size(17, 18);
            label2.TabIndex = 21;
            label2.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.icon_ejemplo;
            pictureBox1.Location = new Point(37, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Banner", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(8, 92);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 0;
            label1.Text = "Boletos Vendidos";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(255, 192, 192);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(146, 63);
            panel4.Name = "panel4";
            panel4.Padding = new Padding(5);
            panel4.Size = new Size(128, 153);
            panel4.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(58, 127);
            label3.Name = "label3";
            label3.Size = new Size(17, 18);
            label3.TabIndex = 21;
            label3.Text = "0";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.icon_ejemplo;
            pictureBox2.Location = new Point(39, 24);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Banner", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(8, 92);
            label5.Name = "label5";
            label5.Size = new Size(114, 21);
            label5.TabIndex = 0;
            label5.Text = "Boletos Vendidos";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(255, 128, 128);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label7);
            panel5.Location = new Point(280, 63);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(5);
            panel5.Size = new Size(128, 153);
            panel5.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(58, 127);
            label6.Name = "label6";
            label6.Size = new Size(17, 18);
            label6.TabIndex = 21;
            label6.Text = "0";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.icon_ejemplo;
            pictureBox3.Location = new Point(41, 24);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 20;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sitka Banner", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(6, 92);
            label7.Name = "label7";
            label7.Size = new Size(114, 21);
            label7.TabIndex = 0;
            label7.Text = "Boletos Vendidos";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(255, 128, 128);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(pictureBox4);
            panel6.Controls.Add(label9);
            panel6.Location = new Point(548, 63);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(5);
            panel6.Size = new Size(128, 153);
            panel6.TabIndex = 24;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(58, 127);
            label8.Name = "label8";
            label8.Size = new Size(17, 18);
            label8.TabIndex = 21;
            label8.Text = "0";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.icon_ejemplo;
            pictureBox4.Location = new Point(38, 24);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 20;
            pictureBox4.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Sitka Banner", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(6, 92);
            label9.Name = "label9";
            label9.Size = new Size(114, 21);
            label9.TabIndex = 0;
            label9.Text = "Boletos Vendidos";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(255, 192, 192);
            panel7.Controls.Add(label10);
            panel7.Controls.Add(pictureBox5);
            panel7.Controls.Add(label11);
            panel7.Location = new Point(682, 63);
            panel7.Name = "panel7";
            panel7.Padding = new Padding(5);
            panel7.Size = new Size(128, 153);
            panel7.TabIndex = 25;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(58, 127);
            label10.Name = "label10";
            label10.Size = new Size(17, 18);
            label10.TabIndex = 21;
            label10.Text = "0";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources.icon_ejemplo;
            pictureBox5.Location = new Point(39, 24);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(50, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Sitka Banner", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(8, 92);
            label11.Name = "label11";
            label11.Size = new Size(114, 21);
            label11.TabIndex = 0;
            label11.Text = "Boletos Vendidos";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(255, 192, 192);
            panel8.Controls.Add(label12);
            panel8.Controls.Add(pictureBox6);
            panel8.Controls.Add(label13);
            panel8.Location = new Point(414, 63);
            panel8.Name = "panel8";
            panel8.Padding = new Padding(5);
            panel8.Size = new Size(128, 153);
            panel8.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Imprint MT Shadow", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(63, 132);
            label12.Name = "label12";
            label12.Size = new Size(17, 18);
            label12.TabIndex = 21;
            label12.Text = "0";
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox6.BackColor = Color.Transparent;
            pictureBox6.Image = Properties.Resources.icon_ejemplo;
            pictureBox6.Location = new Point(40, 24);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(50, 54);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 20;
            pictureBox6.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Sitka Banner", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(6, 92);
            label13.Name = "label13";
            label13.Size = new Size(114, 21);
            label13.TabIndex = 0;
            label13.Text = "Boletos Vendidos";
            // 
            // Frm_Grafica
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(829, 600);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Grafica";
            Padding = new Padding(5);
            Text = "Frm_Grafica";
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Btn_Close_Page).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label4;
        private PictureBox Btn_Close_Page;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel4;
        private Label label3;
        private PictureBox pictureBox2;
        private Label label5;
        private Panel panel5;
        private Label label6;
        private PictureBox pictureBox3;
        private Label label7;
        private Panel panel6;
        private Label label8;
        private PictureBox pictureBox4;
        private Label label9;
        private Panel panel7;
        private Label label10;
        private PictureBox pictureBox5;
        private Label label11;
        private Panel panel8;
        private Label label12;
        private PictureBox pictureBox6;
        private Label label13;
    }
}