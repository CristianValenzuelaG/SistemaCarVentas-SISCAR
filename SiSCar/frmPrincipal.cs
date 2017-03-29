using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiSCar.Controlador;
using SiSCar.Vista;

namespace SiSCar
{
    public partial class frmPrincipal : Form
    {
        public static ManejoSesion.SessiononHelper SessionActiva;

        public void procesarPermisos()
        {
            int permiso = 0;
            foreach (object obj in this.groupBox1.Controls)
            {
                if (obj is Button)
                {
                    Button btn = (Button)obj;
                    permiso = Convert.ToInt32(btn.Tag);
                    btn.Enabled = SessionActiva.tienepermiso(permiso);
                }
            }
        }

        public frmPrincipal()
        {
            InitializeComponent();
            SessionActiva = new ManejoSesion.SessiononHelper();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            if (!frmPrincipal.SessionActiva.isValid)
            {
                frmLogin nVentana = new frmLogin();
                nVentana.ShowDialog();
                int x = 0;
            }
        }

        private void frmPrincipal_Activated(object sender, EventArgs e)
        {
            procesarPermisos();
        }


private void btnVentas_Click(object sender, EventArgs e)
        {
            frmMainVenta nu = new frmMainVenta();
            nu.Show();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmMainUsuario nu = new frmMainUsuario();
            nu.Show();
        }

        private void btnPropietario_Click(object sender, EventArgs e)
        {
            frmMainPropietario nu = new frmMainPropietario();
            nu.Show();
        }

        private void btnComprador_Click(object sender, EventArgs e)
        {
            frmMainVenta nue = new frmMainVenta();
            nue.Show();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            frmMainAuto nue = new frmMainAuto();
            nue.Show();
        }
    }
}
