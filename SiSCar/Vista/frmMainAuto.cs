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
    public partial class frmMainAuto : Form
    {
        public void cargarAutos(string idAuto)
        {
            List<Auto> nLista = new List<Auto>();
            foreach (var item in Auto.BuscarPorMarca(idAuto, ckbSatus.Checked))
            {
                nLista.Add(item);
            }
            this.grDatos.DataSource = nLista;
        }

        public frmMainAuto()
        {
            InitializeComponent();
            grDatos.AutoGenerateColumns = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.cargarAutos(txtBuscar.Text);
        }

        private void ckbSatus_CheckedChanged(object sender, EventArgs e)
        {
            this.cargarAutos(txtBuscar.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmEntradaAutos en = new frmEntradaAutos();
            en.Show();
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

                string a = Convert.ToString(selectedRow.Cells["pkAuto"].Value);
                frmComprador.iD_Buscar_Carro = Convert.ToInt32(a);
                this.Close();


            }
            else MessageBox.Show("No hay elementos ");
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string value = grDatos.CurrentRow.Cells[0].Value.ToString();
            frmEntradaAutos auto = new frmEntradaAutos(Convert.ToInt32(value));
            auto.ShowDialog();
        }

        private void frmMainAuto_Load(object sender, EventArgs e)
        {
            cargarAutos(txtBuscar.Text);
        }
    }
}
