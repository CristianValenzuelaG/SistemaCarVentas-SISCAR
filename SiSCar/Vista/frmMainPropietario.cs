using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiSCar.Modelo;

namespace SiSCar.Vista
{
    public partial class frmMainPropietario : Form
    {
        public void cargarPropietarios(string idGrupo)
        {
            List<Propietario> nLista = new List<Propietario>();
            foreach (var item in Propietario.BuscarPorNombre(idGrupo, ckbSatus.Checked))
            {
                nLista.Add(item);
            }
            this.grDatos.DataSource = nLista;
        }

        public frmMainPropietario()
        {
            InitializeComponent();
            grDatos.AutoGenerateColumns = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmEntradaAutos pro = new frmEntradaAutos();
            pro.Show();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.cargarPropietarios(txtBuscar.Text);
        }

        private void ckbSatus_CheckedChanged(object sender, EventArgs e)
        {
            this.cargarPropietarios(txtBuscar.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grDatos.SelectedCells.Count > 0)
            {
                int selectedrowindex = grDatos.SelectedCells[0].RowIndex;

                DataGridViewRow selectedRow = grDatos.Rows[selectedrowindex];

                string a = Convert.ToString(selectedRow.Cells["pkPropietario"].Value);
                frmEntradaAutos.iD_Buscar = Convert.ToInt32(a);
                frmComprador.iD_Buscar_Propietario = Convert.ToInt32(a);
                this.Close();


            }
            else MessageBox.Show("No hay elementos ");
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            string value = grDatos.CurrentRow.Cells[0].Value.ToString();
            frmEntradaAutos auto = new frmEntradaAutos(value);
            auto.ShowDialog();
        }

        private void frmMainPropietario_Load(object sender, EventArgs e)
        {
            cargarPropietarios(txtBuscar.Text);
        }
    }
}
