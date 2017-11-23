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
    public partial class frmAdministrarMatches : Form
    {
        private enum estado { INICIO, NUEVO }
        private ConsejeroBL cLogNeg;
        private AconsejadoBL aLogNeg;
        private MatchBL mLogNeg;
        private BindingList<Consejero> listaC;
        private BindingList<Aconsejado> listaA;

        public frmAdministrarMatches()
        {
            InitializeComponent();
            aLogNeg = new AconsejadoBL();
            cLogNeg = new ConsejeroBL();
            mLogNeg = new MatchBL();
            modificarEstado(estado.INICIO);
            listaA = null;
            listaC = null;
        }

        private void modificarEstado(estado e)
        {
            if (e == estado.INICIO)
            {
                btnCrearMatch.Enabled = false;
                dtpFechaFin.Enabled = false;
                txtBuscarAconsejado.Enabled = false;
                txtBuscarConsejero.Enabled = false;
                cmbBuscarAconsejado.Enabled = false;
                cmbBuscarConsejero.Enabled = false;
                btnCancelar.Enabled = false;
                btnCancelar.Visible = false;
            }
            else if(e == estado.NUEVO)
            {
                btnCrearMatch.Enabled = true;
                dtpFechaFin.Enabled = true;
                txtBuscarAconsejado.Enabled = true;
                txtBuscarConsejero.Enabled = true;
                cmbBuscarAconsejado.Enabled = true;
                cmbBuscarConsejero.Enabled = true;
                btnCancelar.Enabled = true;
                btnCancelar.Visible = true;
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarEstado(estado.NUEVO);
        }

        private void txtBuscarConsejero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (cmbBuscarConsejero.SelectedItem == null) { MessageBox.Show("Campo de búsqueda no seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                
                if (cmbBuscarConsejero.SelectedIndex == 0)
                {
                    try
                    {
                        Int32.Parse(txtBuscarConsejero.Text);
                    } catch(Exception exp)
                    {
                        MessageBox.Show("ID ingresado no valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                    }
                    listaC = cLogNeg.listarConsejerosPorId(Int32.Parse(txtBuscarConsejero.Text));
                } else if(cmbBuscarConsejero.SelectedIndex == 1)
                {
                    listaC = cLogNeg.listarConsejerosPorNombre(txtBuscarConsejero.Text);
                }
                dgvConsejeros.AutoGenerateColumns = false;
                dgvConsejeros.DataSource = listaC;
            }
        }

        private void txtBuscarAconsejado_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (cmbBuscarAconsejado.SelectedItem == null) { MessageBox.Show("Campo de búsqueda no seleccionado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                
                if (cmbBuscarAconsejado.SelectedIndex == 0)
                {
                    try
                    {
                        Int32.Parse(txtBuscarAconsejado.Text);
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show("ID ingresado no válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
                    }
                    listaA = aLogNeg.listarAconsejadosPorId(Int32.Parse(txtBuscarAconsejado.Text));
                }
                else if (cmbBuscarConsejero.SelectedIndex == 1)
                {
                    listaA = aLogNeg.listarAconsejadosPorNombre(txtBuscarAconsejado.Text);
                }
                dgvAconsejados.AutoGenerateColumns = false;
                dgvAconsejados.DataSource = listaA;
            }
        }

        private void btnCrearMatch_Click(object sender, EventArgs e)
        {
            if (dgvConsejeros.DataSource == null && dgvAconsejados.DataSource == null) { MessageBox.Show("No existen consejeros o aconsejados para elegir", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            else
            {
                if (dgvAconsejados.CurrentRow.DataBoundItem == null) { MessageBox.Show("No se eligió aconsejado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                if (dgvConsejeros.CurrentRow.DataBoundItem == null) { MessageBox.Show("No se eligió consejero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                Aconsejado a = (Aconsejado)dgvAconsejados.CurrentRow.DataBoundItem;
                Consejero c = (Consejero)dgvConsejeros.CurrentRow.DataBoundItem;
                if(a.Estado == "Inhabilitado") { MessageBox.Show("No se puede elegir un aconsejado inhabilitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                if (c.Estado == "Inhabilitado") { MessageBox.Show("No se puede elegir un consejero inhabilitado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                if((dtpFechaFin.Value.Day - dtpFechaInicio.Value.Day)==0) { MessageBox.Show("No se puede elegir la fecha de hoy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                if(dtpFechaFin.Value < dtpFechaInicio.Value) { MessageBox.Show("No se puede elegir una fecha anterior a hoy", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                Match m = new Match();
                m.IdAconsejado = a.Codigo;
                m.IdConsejero = c.Codigo;
                m.FechaAsignacion = DateTime.Today;
                m.FechaFin = dtpFechaFin.Value;
                m.Estado = "Activo";

                if (mLogNeg.registrarMatch(m))
                {
                    cLogNeg.modificarConsejero(c);
                    aLogNeg.modificarAconsejado(a);
                    MessageBox.Show("Se estableció el Match exitósamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarMatches frmMM = new frmMostrarMatches();
            frmMM.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            modificarEstado(estado.INICIO);
            dgvAconsejados.DataSource = null;
            dgvConsejeros.DataSource = null;
        }
    }
}
