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

namespace SiSCar
{
    public partial class frmLogin : Form
    {
        ManejoSesion.SessiononHelper objsession;//se agrega
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            objsession = ManejoSesion.Login(txtUsuario.Text, txtContrasena.Text);

            if (!objsession.isValid)
            {
                errorProvider1.SetError(txtUsuario, objsession.msgError);
                txtUsuario.Focus();
            }
            else
            {
                frmPrincipal.SessionActiva = objsession;
                this.Close();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            if (frmPrincipal.SessionActiva.isValid)
            {
                this.Close();
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }
    }
}
