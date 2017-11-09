﻿using System;
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
    public partial class frmAdministrarConsejeros : Form
    {

        Consejero consejero = new Consejero();
        ConsejeroBL LogNegConsejero = new ConsejeroBL();
        public frmAdministrarConsejeros()
        {
            InitializeComponent();
            this.Height = 800;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarConsejero f = new frmBuscarConsejero();
            
            if (f.ShowDialog() == DialogResult.OK)
            {

                f.Dispose();
            }
            consejero = f.ConsejeroSeleccionado;
            btnAgregarConsejero.Enabled = false;
            guardarToolStripMenuItem.Enabled = true;

            txtNombreConsejero.Text = consejero.NombreCompleto;
            txtAreasIntConsej.Text = consejero.AreasInteres1;
            txtCargoConsej.Text = consejero.Cargo;
            txtCodigoConsej.Text = consejero.Codigo.ToString();
            txtCorreoConsej.Text = consejero.Correo;
            txtDireccConsej.Text = consejero.Direccion;
            txtEmpresaConsej.Text = consejero.Empresa;
            txtObsConsej.Text = consejero.Observaciones;
            txtSectorConsej.Text = consejero.Sector;
            txtTelefConsej.Text = consejero.Telefono.ToString();

            try
            {
                dtpFechaNacConsej.Text = consejero.FechaNacimiento.ToString();
            }
            catch (Exception ex) { }
            txtEspecialidad.Text = consejero.Especialidad;
            txtGradoConsej.Text = consejero.Grado;



            txtNombreConsejero.Enabled = true;
            txtAreasIntConsej.Enabled = true;
            txtCargoConsej.Enabled = true;
            txtCodigoConsej.Enabled = true;
            txtCorreoConsej.Enabled = true;
            txtDireccConsej.Enabled = true;
            txtEmpresaConsej.Enabled = true;
            txtObsConsej.Enabled = true;
            txtSectorConsej.Enabled = true;
            txtTelefConsej.Enabled = true;

        }

        private void actividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdministrarActividades fActivi = new frmAdministrarActividades();
            fActivi.Visible = true;
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtNombreConsejero.Enabled = true;
            txtAreasIntConsej.Enabled = true;
            txtCargoConsej.Enabled = true;
            txtCodigoConsej.Enabled = true;
            txtCorreoConsej.Enabled = true;
            txtDireccConsej.Enabled = true;
            txtEmpresaConsej.Enabled = true;
            txtObsConsej.Enabled = true;
            txtSectorConsej.Enabled = true;
            txtTelefConsej.Enabled = true;

            dtpFechaNacConsej.Enabled = true;
            txtEspecialidad.Enabled = true;
            txtGradoConsej.Enabled = true;

            txtNombreConsejero.Text = "";
            txtAreasIntConsej.Text = "";
            txtCargoConsej.Text = "";
            txtCodigoConsej.Text = "";
            txtCorreoConsej.Text = "";
            txtDireccConsej.Text = "";
            txtEmpresaConsej.Text = "";
            txtObsConsej.Text = "";
            txtSectorConsej.Text = "";
            txtTelefConsej.Text = "";

            try
            {
                dtpFechaNacConsej.Text = "";
            }
            catch (Exception ex) { }
            txtEspecialidad.Text = "";
            txtGradoConsej.Text = "";

            guardarToolStripMenuItem.Enabled = true;
        }

        private void btnCancelarConsejero_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancelarConsejero_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAgregarConsejero_Click(object sender, EventArgs e)
        {
            //Mandar registro a la logica del negocio
            consejero.NombreCompleto = txtNombreConsejero.Text;
            consejero.AreasInteres1 = txtAreasIntConsej.Text;
            consejero.Especialidad = txtEspecialidad.Text;
            consejero.Grado = txtGradoConsej.Text;
            consejero.Cargo = txtCargoConsej.Text;
            consejero.Codigo = Int32.Parse(txtCodigoConsej.Text);
            consejero.Correo = txtCorreoConsej.Text;
            consejero.Direccion = txtDireccConsej.Text;
            consejero.Empresa = txtEmpresaConsej.Text;
            consejero.Observaciones = txtObsConsej.Text;
            consejero.Sector = txtSectorConsej.Text;
            consejero.Telefono = Int32.Parse(txtTelefConsej.Text);
            consejero.Especialidad = txtEspecialidad.Text;
            consejero.Grado = txtGradoConsej.Text;
            consejero.Estado = "Habilitado";
            LogNegConsejero.registrarConsejero(this.consejero);
            
            MessageBox.Show("Consejero Agregado");
        }

        private void frmAdministrarConsejeros_Load(object sender, EventArgs e)
        {

        }
    }
}
