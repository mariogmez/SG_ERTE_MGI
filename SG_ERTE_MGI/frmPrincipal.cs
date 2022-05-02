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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void empresasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0 && this.MdiChildren[0].Name != "frmEmpresas")
            {
                this.MdiChildren[0].Close();
            }
            frmEmpresas s = new frmEmpresas();
            s.MdiParent = this;
            s.Dock = DockStyle.Fill;
            s.Show();

        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eRTESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void iNFORMESToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("¿Esta seguro de querer salir de la aplicacion?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resp == DialogResult.Yes)
            {
                Application.Exit();
            }
                
        }
    }
}
