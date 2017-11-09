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
    public partial class frmBuscarAconsejado : Form
    {
        private Aconsejado aconsejadoSeleccionado;
        private AconsejadoBL aLogNeg;

        public frmBuscarAconsejado()
        {
            InitializeComponent();
            aLogNeg = new AconsejadoBL();
            dgvAconsejados.AutoGenerateColumns = false;
            BindingList<Aconsejado> aconsejados = aLogNeg.listarAconsejados();
            dgvAconsejados.DataSource = aconsejados;
        }

        public Aconsejado AconsejadoSeleccionado { get => aconsejadoSeleccionado; set => aconsejadoSeleccionado = value; }

        private void btnSeleccionarAconsejado_Click(object sender, EventArgs e)
        {
            aconsejadoSeleccionado = (Aconsejado) dgvAconsejados.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
