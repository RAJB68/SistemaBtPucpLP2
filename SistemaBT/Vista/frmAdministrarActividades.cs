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
    public partial class frmAdministrarActividades : Form
    {
        private Consejero consejeroSeleccionado = new Consejero();
        private ActividadesBL LogNegActividades = new ActividadesBL();
        private BindingList<Actividad> actividades = new BindingList<Actividad>();
        public frmAdministrarActividades()
        {
            InitializeComponent();
            this.txtNombre.Enabled = false;
            dgvActividades.AutoGenerateColumns = false;
            dgvActividades.DataSource = actividades;
        }

        private void btAgregarActividad_Click(object sender, EventArgs e)
        {
            frmAgregarActividad fAgregarAct = new frmAgregarActividad(consejeroSeleccionado.Codigo, consejeroSeleccionado.NombreCompleto);

            if (fAgregarAct.ShowDialog() == DialogResult.OK)
            {
                fAgregarAct.Dispose();
                this.actualizarTablaActividades();
            }
        }

        private void btModificarActividad_Click(object sender, EventArgs e)
        {
            //frmAgregarActividad fAgregarAct = new frmAgregarActividad(consejeroSeleccionado.Codigo, consejeroSeleccionado.NombreCompleto);
            //if (fAgregarAct.ShowDialog() == DialogResult.OK)
            //{
            //    fAgregarAct.Dispose();
            //    this.actualizarTablaActividades();
            //}
        }

        private void btBuscarConsejero_Click(object sender, EventArgs e)
        {
            frmBuscarConsejero f = new frmBuscarConsejero();

            if (f.ShowDialog() == DialogResult.OK)
            {
                this.consejeroSeleccionado = f.ConsejeroSeleccionado;
                this.txtNombre.Text = this.consejeroSeleccionado.NombreCompleto;
                f.Dispose();
                this.actualizarTablaActividades();
            }
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            this.actualizarTablaActividades();
        }

        private void actualizarTablaActividades()
        {
            actividades = this.LogNegActividades.listarActividades(consejeroSeleccionado.Codigo);
            dgvActividades.DataSource = actividades;
            dgvActividades.Refresh();
        }

        private void btEliminarActividad_Click(object sender, EventArgs e)
        {
            int codActividadAEliminar = ((Actividad)dgvActividades.CurrentRow.DataBoundItem).IdActividad;
            this.LogNegActividades.eliminarActividad(codActividadAEliminar);
        }
    }
}
