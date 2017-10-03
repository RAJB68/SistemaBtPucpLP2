using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmAdministrarConsejeros : Form
    {
        public frmAdministrarConsejeros()
        {
            InitializeComponent();
            this.Height = 800;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarConsejero f = new frmBuscarConsejero();
           
            f.Visible = true;
        }
    }
}
