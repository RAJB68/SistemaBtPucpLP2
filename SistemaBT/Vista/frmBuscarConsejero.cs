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
    public partial class frmBuscarConsejero : Form
    {
        private Consejero _consejeroSeleccionado;
        public frmBuscarConsejero()
        {
            InitializeComponent();
            ConsejeroBL consejeroLogNeg = new ConsejeroBL();
            BindingList<Consejero> consejeros = consejeroLogNeg.leerConsejeros();
            
            dgvConsejeros.AutoGenerateColumns = false;
            dgvConsejeros.DataSource = consejeros;
         

        }

        public Consejero ConsejeroSeleccionado { get => _consejeroSeleccionado; set => _consejeroSeleccionado = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            //Seleccionar el consejero
            _consejeroSeleccionado = (Consejero)dgvConsejeros.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
        }
    }
}
