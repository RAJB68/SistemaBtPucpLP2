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
    public enum estado { INICIO, NUEVO, GUARDAR, MODIFICAR_ELIMINAR, VINCULAR, ACTIVIDAD }
    public partial class frmAdministrarAconsejados : Form
    {
        private Aconsejado a;

        private AconsejadoBL aLogicaNeg;
        private MatchBL mLogicaNeg;
        //private EspecialidadBL eLogicaNeg; 
        public frmAdministrarAconsejados()
        {
            InitializeComponent();
            modificarEstado(estado.INICIO);
            aLogicaNeg = new AconsejadoBL();
            mLogicaNeg = new MatchBL();
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
                txtEspecialidad.Text = "";
                txtEspecialidad.Enabled = false;
                numUDCiclo.Value = 1;
                numUDCiclo.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                radHabilitado.Visible = false;
                radHabilitado.Enabled = false;
                radInhabilitado.Visible = false;
                radInhabilitado.Enabled = false;
                lblEstado.Visible = false;

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
            } else if (e == estado.MODIFICAR_ELIMINAR)    //manda a un formulario a buscar el aconsejado a modificar y llena los campos con el seleccionado
            {
                txtNombreCompleto.Enabled = true;
                txtNumeroTelefono.Enabled = true;
                ftpFechaNacimiento.Enabled = true;
                txtDireccion.Enabled = true;
                txtCodAlumno.Enabled = false;
                txtCorreo.Enabled = true;
                txtObservaciones.Enabled = true;
                btnAgregar.Enabled = false;
                btnCancelar.Enabled = true;
                txtEspecialidad.Enabled = true;
                numUDCiclo.Enabled = true;
                btnModificar.Enabled = true;
                btnEliminar.Enabled = true;
                radHabilitado.Visible = true;
                radHabilitado.Enabled = true;
                radInhabilitado.Visible = true;
                radInhabilitado.Enabled = true;
                lblEstado.Visible = true;

                nuevoToolStripMenuItem.Enabled = false;
                modificarToolStripMenuItem.Enabled = true;
                vincularToolStripMenuItem.Enabled = true;
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
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            modificarEstado(estado.INICIO);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txtNombreCompleto.Text == "")
            {
                MessageBox.Show("No se ingresó nombre del Aconsejado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            else if (txtNombreCompleto.Text.Length > 60)
            {
                MessageBox.Show("Límite del campo excedido", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (16 > (DateTime.Today.Year - ftpFechaNacimiento.Value.Year))
            {
                MessageBox.Show("La fecha de nacimiento introducida no válida", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            try
            {
                Int32.Parse(txtNumeroTelefono.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show("No se ingresó número de teléfono correcto", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (txtNumeroTelefono.Text.Length > 9)
            {
                MessageBox.Show("Límite del campo excedido", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (txtDireccion.Text == "")
            {
                MessageBox.Show("No se ingresó dirección del Aconsejado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            else if (txtDireccion.Text.Length > 50)
            {
                MessageBox.Show("Límite del campo excedido", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            try
            {
                Int32.Parse(txtCodAlumno.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Código del Aconsejado mal ingresado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if ((Int32.Parse(txtCodAlumno.Text) < 19900000) || (Int32.Parse(txtCodAlumno.Text) > ((DateTime.Today.Year + 1) * 10000)))
            { MessageBox.Show("Código ingresado no válido", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            if (txtEspecialidad.Text == "")
            {
                MessageBox.Show("No se ingresó especialidad del Aconsejado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            else if (txtEspecialidad.Text.Length > 50)
            {
                MessageBox.Show("Límite del campo excedido", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (txtObservaciones.Text == "")
            {
                MessageBox.Show("No existen observaciones del Aconsejado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; 
            }

            if (txtCorreo.Text == "")
            {
                MessageBox.Show("No se ingresó correo del Aconsejado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; 
            }
            else if (txtCorreo.Text.Length > 50)
            {
                MessageBox.Show("Límite del campo excedido", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if ((numUDCiclo.Value < 1) & (numUDCiclo.Value > 10))
            { MessageBox.Show("Ciclo elegido no válido", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }


            a = new Aconsejado();
            a.Codigo = Int32.Parse(txtCodAlumno.Text);
            a.NombreCompleto = txtNombreCompleto.Text;
            a.FechaNacimiento = ftpFechaNacimiento.Value;
            a.Telefono = Int32.Parse(txtNumeroTelefono.Text);
            a.Correo = txtCorreo.Text;
            a.Direccion = txtDireccion.Text;
            a.Especialidad = txtEspecialidad.Text;
            a.Ciclo = (int)numUDCiclo.Value;
            a.Observaciones = txtObservaciones.Text;

            if (aLogicaNeg.registrarAconsejado(a))
            {
                MessageBox.Show("Aconsejado registrado con éxito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else return;

            modificarEstado(estado.GUARDAR);
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarAconsejado frmBA = new frmBuscarAconsejado();
            if (frmBA.ShowDialog() == DialogResult.OK)
            {
                modificarEstado(estado.MODIFICAR_ELIMINAR);
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
                if (a.Estado == "Habilitado") radHabilitado.Checked = true;
                else radInhabilitado.Checked = true;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtNombreCompleto.Text == "")
            {
                MessageBox.Show("No se ingresó nombre del Aconsejado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            else if (txtNombreCompleto.Text.Length > 60)
            {
                MessageBox.Show("Límite del campo excedido", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (16 > (DateTime.Today.Year - ftpFechaNacimiento.Value.Year))
            {
                MessageBox.Show("La fecha de nacimiento introducida no es válida", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            try
            {
                Int32.Parse(txtNumeroTelefono.Text);
            }
            catch (Exception exp)
            {
                MessageBox.Show("No se ingresó número de teléfono correcto", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            if (txtNumeroTelefono.Text.Length > 9)
            {
                MessageBox.Show("Límite del campo excedido", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (txtDireccion.Text == "")
            {
                MessageBox.Show("No se ingresó dirección del Aconsejado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            else if (txtDireccion.Text.Length > 50)
            {
                MessageBox.Show("Límite del campo excedido", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (txtEspecialidad.Text == "")
            {
                MessageBox.Show("No se ingresó especialidad del Aconsejado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            else if (txtEspecialidad.Text.Length > 50)
            {
                MessageBox.Show("Límite del campo excedido", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if (txtObservaciones.Text == "")
            {
                MessageBox.Show("No existen observaciones del Aconsejado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; //////////////////////////////////////////////
            }

            if (txtCorreo.Text == "")
            {
                MessageBox.Show("No se ingresó el correo del Aconsejado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; //////////////////////////////////////////////
            }
            else if (txtCorreo.Text.Length > 50)
            {
                MessageBox.Show("Límite del campo excedido", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }

            if ((numUDCiclo.Value < 1) & (numUDCiclo.Value > 10))
            { MessageBox.Show("Ciclo elegido no válido", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            a.Codigo = Int32.Parse(txtCodAlumno.Text);
            a.NombreCompleto = txtNombreCompleto.Text;
            a.FechaNacimiento = ftpFechaNacimiento.Value;
            a.Telefono = Int32.Parse(txtNumeroTelefono.Text);
            a.Correo = txtCorreo.Text;
            a.Direccion = txtDireccion.Text;
            a.Especialidad = txtEspecialidad.Text;
            a.Ciclo = (int)numUDCiclo.Value;
            a.Observaciones = txtObservaciones.Text;
            if (radHabilitado.Checked) a.Estado = "Habilitado";
            else a.Estado = "Inhabilitado";

            if (aLogicaNeg.modificarAconsejado(a))
            {
                MessageBox.Show("Aconsejado modificado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else return;

            modificarEstado(estado.INICIO);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(txtCodAlumno.Text == "") { MessageBox.Show("Aconsejado no escogido", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            else
            {
                if (aLogicaNeg.eliminarAconsejado(Int32.Parse(txtCodAlumno.Text)))
                {
                    MessageBox.Show("Aconsejado eliminado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else return;
                modificarEstado(estado.INICIO);
            }
        }

        private void establecerMatchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtCodAlumno.Text == "") { MessageBox.Show("No se eligió el alumno con el cual vincular", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            if (radInhabilitado.Checked) { MessageBox.Show("Solo se puede elegir Aconsejado habilitado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
            frmBuscarConsejero frmBC = new frmBuscarConsejero();
            if (frmBC.ShowDialog() == DialogResult.OK)
            {
                if (frmBC.ConsejeroSeleccionado.Estado == "Inhabilitado") { MessageBox.Show("Solo se puede elegir Consejero habilitado", "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                Match m = new Match();
                m.IdAconsejado = Int32.Parse(txtCodAlumno.Text);
                m.IdConsejero = frmBC.ConsejeroSeleccionado.Codigo;
                m.FechaAsignacion = DateTime.Today;
                m.Estado = "Bueno";
                frmBC.ConsejeroSeleccionado.Estado = "Inhabilitado";
                ConsejeroBL conBL = new ConsejeroBL();
                conBL.modificarConsejero(frmBC.ConsejeroSeleccionado);

                if (mLogicaNeg.registrarMatch(m))
                    MessageBox.Show("Se estableció el Match exitósamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else return;
                modificarEstado(estado.GUARDAR);
            }
        }

        private void verMatchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMostrarMatches fMM = new frmMostrarMatches();
            fMM.Visible = true;
        }
    }
}
