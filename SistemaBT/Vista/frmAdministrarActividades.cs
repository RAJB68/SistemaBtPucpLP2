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
    public partial class frmAdministrarActividades : Form
    {
        public frmAdministrarActividades()
        {
            InitializeComponent();
            this.txtNombre.Enabled = false;
            this.txtCodigo.Enabled = false;
        }

        private void btAgregarActividad_Click(object sender, EventArgs e)
        {
            frmAgregarActividad fAgregarAct = new frmAgregarActividad();
            fAgregarAct.Visible = true;
        }

        private void btModificarActividad_Click(object sender, EventArgs e)
        {
            frmAgregarActividad fAgregarAct = new frmAgregarActividad();
            fAgregarAct.Visible = true;
            
        }
    }
}
