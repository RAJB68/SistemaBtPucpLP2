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
    public partial class frmMostrarMatches : Form
    {
        private MatchBL mLogNeg;
        private AconsejadoBL aLogNeg;

        public frmMostrarMatches()
        {
            InitializeComponent();
            mLogNeg = new MatchBL();
            aLogNeg = new AconsejadoBL();
            BindingList<Match> matches = mLogNeg.listarMatches(0);
            dgvMatches.AutoGenerateColumns = false;
            dgvMatches.DataSource = matches;
        }

        private void btnBuscarMatches_Click(object sender, EventArgs e)
        {
        }

        private void btnFinMatch_Click(object sender, EventArgs e)
        {
            if (dgvMatches.CurrentRow.DataBoundItem == null) { MessageBox.Show("No se eligió un Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            else {
                Match m = (Match)dgvMatches.CurrentRow.DataBoundItem;
                m.FechaFin = DateTime.Today;
                m.Estado = "Finalizado";
                if (mLogNeg.finalizarMatch(m))
                {
                    if (aLogNeg.habilitarAconsejado(m.IdAconsejado))
                    {
                        MessageBox.Show("Match finalizado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                    MessageBox.Show("Match no se pudo finalizar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
