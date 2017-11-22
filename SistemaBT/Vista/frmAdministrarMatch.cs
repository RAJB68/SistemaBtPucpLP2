using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Controlador;

namespace Vista
{
    public partial class frmAdministrarMatch : Form
    {
        private enum estado { INICIO, NUEVO }
        private ConsejeroBL cLogNeg;
        private AconsejadoBL aLogNeg;
        private MatchBL mLogNeg;
        public frmAdministrarMatch()
        {
            InitializeComponent();
            aLogNeg = new AconsejadoBL();
            cLogNeg = new ConsejeroBL();
            mLogNeg = new MatchBL();
        }

        private void modificarEstado(estado e)
        {
            if(e == estado.INICIO)
            {
                btnCrearMatch.Enabled = false;
                dtpFechaFin.Enabled = false;
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscarConsejero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (cmbBuscarConsejero.SelectedItem == null) { MessageBox.Show("Campo de búsqueda no seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                // BindingList<Consejero> listaC = cLogNeg.leerConsejeros();

            }
        }
    }
}
