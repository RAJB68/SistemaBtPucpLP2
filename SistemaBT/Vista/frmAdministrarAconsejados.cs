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
    public enum estado { INICIO, NUEVO, GUARDAR, MODIFICAR, VINCULAR, ACTIVIDAD }
    public partial class frmAdministrarAconsejados : Form
    {
        private Aconsejado a;
        private AconsejadoBL aLogicaNeg;
        //private EspecialidadBL eLogicaNeg; 
        public frmAdministrarAconsejados()
        {
            InitializeComponent();
            modificarEstado(estado.INICIO);
            aLogicaNeg = new AconsejadoBL();
            //BindingList<Especialidad> listaEsp = new BindingList<Especialidad>();
            //listaEsp = eLogicaNeg.devolverLista();
            //cmbEspecialidad.ValueMember = "Nombre";
            //foreach (Especialidad e in listaEsp)
            //{
            //    cmbEspecialidad.Items.Add(e);
            //}
        }

        private void modificarEstado(estado e)   //faltan establecer detalles
        {
            if (e == estado.INICIO)     //entrar por primera vez a la ventana
            {
                txtNombreCompleto.Text = "";
                txtNombreCompleto.Enabled = false;
                txtNumeroTelefono.Text = "";
                txtNumeroTelefono.Enabled = false;
                ftpFechaNacimiento.Value = DateTime.Today;
                ftpFechaNacimiento.Enabled = false;
                txtDireccion.Text = "";
                txtDireccion.Enabled = false;
                txtCodAlumno.Text = "";
                txtCodAlumno.Enabled = false;
                txtCorreo.Text = "";
                txtCorreo.Enabled = false;
                txtObservaciones.Text = "";
                txtObservaciones.Enabled = false;
                btnAgregar.Enabled = false;
                btnCancelar.Enabled = false;
                txtEspecialidad.Enabled = false;
                numUDCiclo.Value = 1;
                numUDCiclo.Enabled = false;

                nuevoToolStripMenuItem.Enabled = true;
                modificarToolStripMenuItem.Enabled = true;
                vincularToolStripMenuItem.Enabled = false;
                actividadToolStripMenuItem.Enabled = false;
            } else if (e == estado.NUEVO)     //elige crear un nuevo aconsejado
            {
                txtNombreCompleto.Enabled = true;
                txtNumeroTelefono.Enabled = true;
                ftpFechaNacimiento.Enabled = true;
                txtDireccion.Enabled = true;
                txtCodAlumno.Enabled = true;
                txtCorreo.Enabled = true;
                txtObservaciones.Enabled = true;
                btnAgregar.Enabled = true;
                btnCancelar.Enabled = true;
                txtEspecialidad.Enabled = true;
                numUDCiclo.Enabled = true;

                nuevoToolStripMenuItem.Enabled = false;
                modificarToolStripMenuItem.Enabled = false;
                vincularToolStripMenuItem.Enabled = false;
                actividadToolStripMenuItem.Enabled = false;
            } else if (e == estado.GUARDAR)    //presiona el boton guardar, deja los campos con los datos ingresados
            {
                txtNombreCompleto.Enabled = false;
                txtNumeroTelefono.Enabled = false;
                ftpFechaNacimiento.Enabled = false;
                txtDireccion.Enabled = false;
                txtCodAlumno.Enabled = false;
                txtCorreo.Enabled = false;
                txtObservaciones.Enabled = false;
                btnAgregar.Enabled = false;
                btnCancelar.Enabled = false;
                txtEspecialidad.Enabled = false;
                numUDCiclo.Enabled = false;

                nuevoToolStripMenuItem.Enabled = true;
                modificarToolStripMenuItem.Enabled = true;
                vincularToolStripMenuItem.Enabled = false;
                actividadToolStripMenuItem.Enabled = false;
            } else if (e == estado.MODIFICAR)    //manda a un formulario a buscar el aconsejado a modificar y llena los campos con el seleccionado
            {
                //txtNombreCompleto.Text = a.NombreCompleto;
                txtNombreCompleto.Enabled = true;
                //txtNumeroTelefono.Text = a.Telefono.ToString();
                txtNumeroTelefono.Enabled = true;
                //ftpFechaNacimiento.Value = a.FechaNacimiento;
                ftpFechaNacimiento.Enabled = true;
                //txtDireccion.Text = a.Direccion;
                txtDireccion.Enabled = true;
                //txtCodAlumno.Text = a.Codigo.ToString();
                txtCodAlumno.Enabled = true;
                //txtCorreo.Text = a.Correo;
                txtCorreo.Enabled = true;
                //txtObservaciones.Text = a.Observaciones;
                txtObservaciones.Enabled = true;
                btnAgregar.Enabled = false;
                btnCancelar.Enabled = false;
                // cmbEspecialidad.SelectedItem = ;        falta decidir como manejar la especialidad
                txtEspecialidad.Enabled = true;
                //numUDCiclo.Value = a.Ciclo;
                numUDCiclo.Enabled = true;

                nuevoToolStripMenuItem.Enabled = true;
                modificarToolStripMenuItem.Enabled = true;
                vincularToolStripMenuItem.Enabled = false;
                actividadToolStripMenuItem.Enabled = false;
            }
        }

        private void actividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrarActividades fActivi = new frmAdministrarActividades();
            fActivi.Visible = true;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modificarEstado(estado.NUEVO);
        }

        private void vincularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /////REALIZAR MATCH
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            modificarEstado(estado.INICIO);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            a = new Aconsejado();

            if (txtNombreCompleto.Text == null)
            {
                MessageBox.Show("No se ingresó nombre del Aconsejado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            } else a.NombreCompleto = txtNombreCompleto.Text;

            if (16 > (DateTime.Today.Year - ftpFechaNacimiento.Value.Year))
            {
                MessageBox.Show("La fecha de nacimiento no ha sido elegida", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            } else a.FechaNacimiento = ftpFechaNacimiento.Value;

            try
            {
                a.Telefono = Int32.Parse(txtNumeroTelefono.Text);
            } catch (Exception exp)
            {
                MessageBox.Show("No se ingresó número de teléfono correcto", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (txtDireccion.Text == null)
            {
                MessageBox.Show("No se ingresó dirección del Aconsejado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            else a.Direccion = txtDireccion.Text;

            try
            {
                Int32.Parse(txtCodAlumno.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Codigo del Aconsejado mal ingresado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if ((Int32.Parse(txtCodAlumno.Text) > 19900000) & (Int32.Parse(txtCodAlumno.Text) < (DateTime.Today.Year * 10000)))
                a.Codigo = Int32.Parse(txtCodAlumno.Text);
            else { MessageBox.Show("Codigo ingresado no válido", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            //////////////ESPECIALIDAD
            if (txtEspecialidad.Text == null)
            {
                MessageBox.Show("No se ingresó especialidad del Aconsejado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            else a.Especialidad = txtEspecialidad.Text;

            if (txtObservaciones.Text == null)
            {
                MessageBox.Show("No existen observaciones del Aconsejado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; //////////////////////////////////////////////
            }
            else a.Observaciones = txtObservaciones.Text;

            if (txtCorreo.Text == null)
            {
                MessageBox.Show("No se ingresó correo del Aconsejado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; //////////////////////////////////////////////
            }
            else a.Correo = txtCorreo.Text;


            if ((numUDCiclo.Value > 0) & (numUDCiclo.Value <= 10)) a.Ciclo = (int)numUDCiclo.Value;
            else { MessageBox.Show("Ciclo elegido no válido", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            //////MOSTRAR MENSAJE DE CONFIRMACION
            ////
            //
            //
            //
            //
            //
            //
            //

            if (aLogicaNeg.registrarAconsejado(a))
            {
                MessageBox.Show("Se ha registrado con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else return;

            modificarEstado(estado.GUARDAR);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarAconsejado frmBA = new frmBuscarAconsejado();
            if (frmBA.ShowDialog() == DialogResult.OK)
            {
                modificarEstado(estado.MODIFICAR);
                a = frmBA.AconsejadoSeleccionado;
                txtNombreCompleto.Text = a.NombreCompleto;
                ftpFechaNacimiento.Value = a.FechaNacimiento;
                txtNumeroTelefono.Text = a.Telefono.ToString();
                txtDireccion.Text = a.Direccion;
                txtCodAlumno.Text = a.Codigo.ToString();
                txtEspecialidad.Text = a.Especialidad;
                numUDCiclo.Value = a.Ciclo;
                txtCorreo.Text = a.Correo;
                txtObservaciones.Text = a.Observaciones;
            }
        }

        //private void btnModificar_Click(object sender, EventArgs e)
        //{ }
    }
}
