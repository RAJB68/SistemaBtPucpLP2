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
        private AconsejadoBL aLogNeg;
        private ConsejeroBL cLogNeg;
        private MatchBL mLogNeg;

        public frmMostrarMatches()
        {
            InitializeComponent();
            aLogNeg = new AconsejadoBL();
            BindingList<Aconsejado> aconsejados = aLogNeg.listarAconsejados();
            dgvMatches.AutoGenerateColumns = false;
            cmbAconsejados.ValueMember = "NombreCompleto";
            foreach( Aconsejado a in aconsejados)
            {
                cmbAconsejados.Items.Add(a);
            }
        }

        private void btnBuscarMatches_Click(object sender, EventArgs e)
        {
            cLogNeg = new ConsejeroBL();
            BindingList<Consejero> consejeros = cLogNeg.leerConsejeros();
            mLogNeg = new MatchBL();
            Aconsejado a = (Aconsejado)cmbAconsejados.SelectedItem;
            BindingList<Match> matches = mLogNeg.listarMatches(a.Codigo);
            dgvMatches.AutoGenerateColumns = false;
            dgvMatches.DataSource = matches;
        }
    }
}
