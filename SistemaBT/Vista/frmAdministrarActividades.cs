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
            this.Height = 750;
            this.txtNombre.Enabled = false;
            dgvActividades.AutoGenerateColumns = false;
            dgvActividades.Enabled = false;
            dgvActividades.DataSource = actividades;
        }

        private void btAgregarActividad_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text == "")
            {
                MessageBox.Show("Por favor seleccione un Consejero antes de agregar una actividad");
            }
            else
            {
                if (this.consejeroSeleccionado.Estado == "Inhabilitado")
                {
                    MessageBox.Show("No puede agregarle actividades a un Consejero Inhabilitado");
                }
                else
                {
                    frmAgregarActividad fAgregarAct = new frmAgregarActividad(consejeroSeleccionado.Codigo, consejeroSeleccionado.NombreCompleto);

                    if (fAgregarAct.ShowDialog() == DialogResult.OK)
                    {
                        fAgregarAct.Dispose();
                        this.actualizarTablaActividades();
                    }
                }
            }
        }

        private void btModificarActividad_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text == "")
            {
                MessageBox.Show("Por favor seleccione un Consejero antes de modificar una actividad");
            }
            else
            {
                Actividad a = ((Actividad)dgvActividades.CurrentRow.DataBoundItem);
                int codActividadAEliminar = ((Actividad)dgvActividades.CurrentRow.DataBoundItem).IdActividad;
                this.LogNegActividades.eliminarActividad(codActividadAEliminar);
                frmAgregarActividad fAgregarAct = new frmAgregarActividad(consejeroSeleccionado.Codigo, consejeroSeleccionado.NombreCompleto);
                fAgregarAct.cargarActividad(a);
                if (fAgregarAct.ShowDialog() == DialogResult.OK)
                {
                    fAgregarAct.Dispose();
                    this.actualizarTablaActividades();
                }
                else
                {
                    LogNegActividades.agregarActividad(consejeroSeleccionado.Codigo, a);
                }
            }
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
                this.dgvActividades.Enabled = true;
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
            if (this.txtNombre.Text != "")
            {
                int codActividadAEliminar = ((Actividad)dgvActividades.CurrentRow.DataBoundItem).IdActividad;
                this.LogNegActividades.eliminarActividad(codActividadAEliminar);
            }
            this.actualizarTablaActividades();
        }
    }
}
