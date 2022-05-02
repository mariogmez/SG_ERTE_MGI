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
    public partial class frmEmpresas : Form
    {
        /*
         * FUNCIONES
         */

        private void mostrarEmpresas()
        {
            using (bd_ertesEntities objBD = new bd_ertesEntities())
            {
                var consultaEmpresas = from emp in objBD.EMPRESAS
                                       from sec in objBD.SECTORES
                                       where emp.Sector == sec.Id_sector
                                       orderby emp.Nombre
                                       select new { emp.Nombre, sec.Descripcion, emp.Cif, emp.Domicilio };

                var lista = consultaEmpresas.ToList();
                dgvEmpresas.DataSource = lista;
                dgvEmpresas.Columns[3].Visible = false;
            }
        }

        private void accionModificar()
        {

            if (dgvEmpresas.SelectedRows.Count > 0)
            {
                string nombreEmp = dgvEmpresas.SelectedRows[0].Cells[0].Value.ToString();
                string nombreSec = dgvEmpresas.SelectedRows[0].Cells[1].Value.ToString();
                string cif = dgvEmpresas.SelectedRows[0].Cells[2].Value.ToString();
                string domicilio = dgvEmpresas.SelectedRows[0].Cells[3].Value.ToString();
                frmModificarAux form = new frmModificarAux(nombreEmp, nombreSec, cif, domicilio);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay ninguna fila seleccionada");
            }

        }

        /*
         * FUNCIONES DEL FORM
         */
        public frmEmpresas()
        {
            InitializeComponent();
        }

        
        //ONLOAD
        private void frmEmpresas_Load(object sender, EventArgs e)
        {
            mostrarEmpresas();
        }

        


        private void btnModificar_Click(object sender, EventArgs e)
        {
            accionModificar();
        }

        

        private void dgvEmpresas_DoubleClick(object sender, EventArgs e)
        {
            accionModificar();
        }
    }
}
