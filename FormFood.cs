using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsFinalProject
{
    public partial class FormFood : Form
    {
        private FormMainPage MainPage;
        public FormFood()
        {
            InitializeComponent();
        }

        public FormFood(FormMainPage mainPage)
        {
            InitializeComponent();
            MainPage = mainPage;
        }
    }
}
