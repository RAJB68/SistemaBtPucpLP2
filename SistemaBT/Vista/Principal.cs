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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnAdminConsejeros_Click(object sender, EventArgs e)
        {
            frmAdministrarConsejeros fConsej = new frmAdministrarConsejeros();
            fConsej.Visible = true;

        }

        private void btnAdminAconsejados_Click(object sender, EventArgs e)
        {
            frmAdministrarAconsejados fAconsej = new frmAdministrarAconsejados();
            fAconsej.Visible = true;
        }

        private void btAdminActividades_Click(object sender, EventArgs e)
        {
            frmAdministrarActividades fActivi = new frmAdministrarActividades();
            fActivi.Visible = true;
        }
    }
}
