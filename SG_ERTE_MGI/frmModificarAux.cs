using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG_ERTE_MGI
{
    public partial class frmModificarAux : Form
    {
        public frmModificarAux(string cif)
        {
            InitializeComponent();
            txtCif.Text = cif;
        }

        private void frmModificarAux_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
