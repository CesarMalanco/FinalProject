using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFinalProyect
{
    public partial class Frm_Productos : Form
    {
        public Frm_Productos()
        {
            InitializeComponent();
            //this.pbMovie1.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "ferris.jpg"));
            /*AdmonDB obj = new AdmonDB();
            List<string> movieList = obj.consultarPeliculas();
            for (int i = 0; i < movieList.Count; i++)
            {
                switch (i)
                {
                    case 0:
                        this.pbMovie1.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", movieList[0]));
                        break;
                    case 1:
                        this.pbMovie2.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", movieList[1]));
                        break;
                    case 2:
                        this.pbMovie3.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", movieList[2]));
                        break;
                    case 3:
                        this.pbMovie4.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", movieList[3]));
                        break;
                    case 4:
                        this.pbMovie5.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", movieList[4]));
                        break;
                    case 5:
                        this.pbMovie6.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", movieList[5]));
                        break;
                    case 6:
                        this.pbMovie7.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", movieList[6]));
                        break;
                    case 7:
                        this.pbMovie8.Image = System.Drawing.Image.FromFile(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", movieList[7]));
                        break;
                }

            }*/
        }

        private void Btn_Close_Page_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
