namespace WinFormsFinalProject
{
    partial class FormLoadingScreen
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
            progressBarLoadingScreen = new ProgressBar();
            timer1 = new System.Windows.Forms.Timer(components);
            labelLoading = new Label();
            labelPercentage = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // progressBarLoadingScreen
            // 
            progressBarLoadingScreen.BackColor = Color.WhiteSmoke;
            progressBarLoadingScreen.ForeColor = Color.Firebrick;
            progressBarLoadingScreen.Location = new Point(115, 236);
            progressBarLoadingScreen.Name = "progressBarLoadingScreen";
            progressBarLoadingScreen.Size = new Size(283, 29);
            progressBarLoadingScreen.Style = ProgressBarStyle.Continuous;
            progressBarLoadingScreen.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 40;
            timer1.Tick += timer1_Tick;
            // 
            // labelLoading
            // 
            labelLoading.AutoSize = true;
            labelLoading.BackColor = Color.Transparent;
            labelLoading.Font = new Font("Myanmar Text", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLoading.Location = new Point(115, 188);
            labelLoading.Name = "labelLoading";
            labelLoading.Size = new Size(112, 37);
            labelLoading.TabIndex = 1;
            labelLoading.Text = "Loading ...";
            // 
            // labelPercentage
            // 
            labelPercentage.AutoSize = true;
            labelPercentage.BackColor = Color.Transparent;
            labelPercentage.Font = new Font("Myanmar Text", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPercentage.Location = new Point(404, 242);
            labelPercentage.Name = "labelPercentage";
            labelPercentage.Size = new Size(17, 21);
            labelPercentage.TabIndex = 2;
            labelPercentage.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = WinFormsFinalProyect.Properties.Resources.popcorn;
            pictureBox1.Location = new Point(326, 148);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 74);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // FormLoadingScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(529, 324);
            Controls.Add(pictureBox1);
            Controls.Add(labelPercentage);
            Controls.Add(labelLoading);
            Controls.Add(progressBarLoadingScreen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLoadingScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading Screen";
            Load += FormLoadingScreen_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBarLoadingScreen;
        private System.Windows.Forms.Timer timer1;
        private Label labelLoading;
        private Label labelPercentage;
        private PictureBox pictureBox1;
    }
}
