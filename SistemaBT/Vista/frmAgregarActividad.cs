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
    public partial class frmAgregarActividad : Form
    {
        private Actividad actividad = new Actividad();
        private ActividadesBL LogNegActividades = new ActividadesBL();
        public int codConsejero = 0;
        public string nombreConsejero="";

        public void cargarActividad(Actividad a)
        {
            if (a.TipoActividad == "Cumpleanios")
            {
                this.txtDedicatoria.Text = a.Comentario;
                this.tabActividad.SelectTab(0);
            }
            if (a.TipoActividad == "Presentacion")
            {
                this.txtResultado.Text = a.Comentario;
                this.tabActividad.SelectTab(1);
            }
            this.txtTitulo.Text = a.Titulo;
            this.txtDestinatario.Text = a.Destinatario;
            this.txtDescripcion.Text = a.Descripcion;
            this.dtpFechaProg.Value = a.FechaProgramada;
            this.cbEstado.Text = a.Estado;
        }
        public frmAgregarActividad(int codConsej, string nombreConsej)
        {
            InitializeComponent();
            this.txtCodigo.Enabled = false;
            this.txtNombre.Enabled = false;
            codConsejero = codConsej;
            nombreConsejero = nombreConsej;
            this.txtNombre.Text = nombreConsej;
            this.txtCodigo.Text = codConsej.ToString();
            BindingList<string> estados = new BindingList<string>();
            estados.Add("Programado");
            estados.Add("Pendiente");
            estados.Add("Realizado");
            this.cbEstado.DataSource = estados;
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {

            if (this.tabActividad.SelectedIndex == 0)
            {
                actividad.TipoActividad = "Cumpleanios";
                actividad.Comentario = this.txtDedicatoria.Text;

            }
            else
            {
                actividad.TipoActividad = "Presentacion";
                actividad.Comentario = this.txtResultado.Text;

            }
            actividad.Titulo = this.txtTitulo.Text;
            actividad.Destinatario = this.txtDestinatario.Text;
            actividad.Descripcion = this.txtDescripcion.Text;
            actividad.FechaProgramada = this.dtpFechaProg.Value;
            actividad.Estado = this.cbEstado.Text;
            LogNegActividades.agregarActividad(codConsejero,actividad);
            DialogResult = DialogResult.OK;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbEstado.Text == "Programado")
            {
                DateTime d = this.dtpFechaProg.Value;
                if (d < DateTime.Today)
                {
                    MessageBox.Show("Cambiar la fecha de la actividad a una fecha futura");
                    this.cbEstado.Text = "Realizado";
                }
            }
            if (this.cbEstado.Text == "Realizado")
            {
                DateTime d = this.dtpFechaProg.Value;
                if (d > DateTime.Today)
                {
                    MessageBox.Show("Cambiar la fecha de la actividad a una fecha pasada");
                    this.cbEstado.Text = "Programado";
                }
            }
        }
    }
}
