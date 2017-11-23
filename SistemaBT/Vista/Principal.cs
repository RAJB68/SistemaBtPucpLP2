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
            this.Height = 750;
        }

        private void btnAdminConsejeros_Click_1(object sender, EventArgs e)
        {
            frmAdministrarConsejeros fConsej = new frmAdministrarConsejeros();
            fConsej.Visible = true;
        }

        private void btAdminAconsejados_Click(object sender, EventArgs e)
        {
            frmAdministrarAconsejados fAconsej = new frmAdministrarAconsejados();
            fAconsej.Visible = true;
        }

        private void btAdminActividades_Click_1(object sender, EventArgs e)
        {
            frmAdministrarActividades fActivi = new frmAdministrarActividades();
            fActivi.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAdministrarMatches fMatches = new frmAdministrarMatches();
            fMatches.Visible = true;
        }
    }
}
