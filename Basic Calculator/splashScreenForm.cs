using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Calculator
{
    public partial class splashScreenForm : Form
    {
        public splashScreenForm()
        {
            InitializeComponent();
        }

        private void closeScreen(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
