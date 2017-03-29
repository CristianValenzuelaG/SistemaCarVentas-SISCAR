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
    public partial class frmMainUsuario : Form
    {

        public void cargarUsuarios(string idGrupo)
        {
            List<Usuario> nLista = new List<Usuario>();
            foreach (var item in Usuario.BuscarPorEmail(idGrupo, ckbSatus.Checked))
            {
                nLista.Add(item);
            }
            this.grDatos.DataSource = nLista;
        }

        public frmMainUsuario()
        {
            InitializeComponent();
            grDatos.AutoGenerateColumns = false;

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.cargarUsuarios(txtBuscar.Text);
        }

        private void ckbSatus_CheckedChanged(object sender, EventArgs e)
        {
            this.cargarUsuarios(txtBuscar.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmNuevoUsuario nuevousu = new frmNuevoUsuario();
            nuevousu.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            string value = grDatos.CurrentRow.Cells[0].Value.ToString();
            frmNuevoUsuario uusu = new frmNuevoUsuario(value);
            uusu.ShowDialog();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            string value = null;
            if (value !="")
            {
                value = grDatos.CurrentRow.Cells[0].Value.ToString();
                frmNuevoUsuario uusu = new frmNuevoUsuario(Convert.ToInt32(value));
                uusu.ShowDialog();

            }
            else
            {  
            
        }
       }
    }
}
