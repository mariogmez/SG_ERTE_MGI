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
        /*
         * FUNCIONES
         */

        private void cargarCbx()
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var consultaSectores = from sec in objBD.SECTORES
                                       orderby sec.Descripcion
                                       select new { sec.Id_sector, sec.Descripcion };

                var lista = consultaSectores.ToList();

                for (int i = 0; i < lista.Count; i++)
                {
                    cbxSector.Items.Add(lista[i].Descripcion);
                }
            }
        }
        /*
         * FUNCIONES DEL FORM
         */
        public frmModificarAux(string nombreEmp, string nombreSec, string cif, string domicilio)
        {
            InitializeComponent();
            txtNombre.Text = nombreEmp;
            cbxSector.Text = nombreSec;
            txtDomicilio.Text = domicilio;
            txtCif.Text = cif;
        }

        private void frmModificarAux_Load(object sender, EventArgs e)
        {
            cargarCbx();

        
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
