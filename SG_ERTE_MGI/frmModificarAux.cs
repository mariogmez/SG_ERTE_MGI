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
        private void cargarDatos()
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var consultaEmpresas = from soc in objBD.EMPRESAS
                                       orderby soc.Nombre
                                       select new { soc.Nombre, soc.Domicilio, soc.Sector };

                var lista = consultaEmpresas.ToList();

                txtNombre.Text = lista[0].Nombre;
                txtDomicilio.Text = lista[0].Domicilio;
            }


        }

        private void cargarCbx()
        {

        }
        /*
         * FUNCIONES DEL FORM
         */
        public frmModificarAux(string cif)
        {
            InitializeComponent();
            txtCif.Text = cif;
        }

        private void frmModificarAux_Load(object sender, EventArgs e)
        {
            cargarDatos();
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
