using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class frmAgregarActividad : Form
    {
        public frmAgregarActividad()
        {
            InitializeComponent();
            this.txtCodigo.Enabled = false;
            this.txtNombre.Enabled = false;
        }
    }
}
