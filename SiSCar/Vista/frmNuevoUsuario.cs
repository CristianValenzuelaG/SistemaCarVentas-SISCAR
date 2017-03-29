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
    public partial class frmNuevoUsuario : Form
    {
        private int indexRol = 0;
        List<Usuario> nListausu = new List<Usuario>();
        public static Boolean VALIDAR = true;
        public static int ModifiarUSU = 0;
        public static int bajaUSU = 0;
        public static Boolean VALIDARbaja = true;

        public frmNuevoUsuario()
        {
            InitializeComponent();
        }

        public frmNuevoUsuario(string modifiausu)
        {
            InitializeComponent();
            VALIDAR = true;
            VALIDARbaja = false;
            
            ModifiarUSU = Convert.ToInt32(modifiausu);
           
            if (ModifiarUSU != 0)
            {
                foreach (var item in Usuario.BuscarporID(ModifiarUSU))
                {
                    nListausu.Add(item);
                }

                foreach (var value in nListausu)
                {
                    txtEmail.Text = value.sEmail.ToString();
                    txtContrasena.Text = value.sPassword.ToString();
                  //  cmbRol.Text= value.rol.ToString();

                }
            }
        }
        public frmNuevoUsuario(int bajausu)
        {
            InitializeComponent();
            VALIDARbaja = true;
            VALIDAR = false;
            txtContrasena.ReadOnly = true;
            txtEmail.ReadOnly = true;

            bajaUSU = Convert.ToInt32(bajausu);

            if (bajaUSU != 0)
            {
                foreach (var item in Usuario.BuscarporID(bajaUSU))
                {
                    nListausu.Add(item);
                }

                foreach (var value in nListausu)
                {
                    txtEmail.Text = value.sEmail.ToString();
                    txtContrasena.Text = value.sPassword.ToString();
                    //  cmbRol.Text= value.rol.ToString();

                }
            }
        }

        private void frmNuevoUsuario_Load(object sender, EventArgs e)
        {
            cmbRol.DataSource = Rol.getAll(true);
            cmbRol.DisplayMember = "sNombre";
            cmbRol.ValueMember = "pkRol";

            cmbRol.SelectedIndex = indexRol;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (VALIDAR == true)
            {
                Usuario nUsu = new Usuario();
                nUsu.pkUsuario = ModifiarUSU;
                nUsu.sEmail = txtEmail.Text;
                nUsu.sPassword = txtContrasena.Text;
                //nUsu.rol = Convert.ToInt32(cmbRol.Text);
                nUsu.Guardar(nUsu);
            }
            else
            {


                if (VALIDARbaja == true)
                {
                    Usuario nUsu = new Usuario();
                    nUsu.pkUsuario = bajaUSU;
                    nUsu.sEmail = txtEmail.Text;
                    nUsu.sPassword = txtContrasena.Text;
                    //nUsu.rol = Convert.ToInt32(cmbRol.Text);
                    nUsu.bStatus = false;

                    nUsu.Guardar(nUsu);
                }

                else
                {
                    Usuario nUsuario = new Usuario();

                    nUsuario.sEmail = txtEmail.Text;
                    nUsuario.sPassword = txtContrasena.Text;
                    int de = cmbRol.SelectedIndex;

                    // nUsuario.rol =indexRol;

                    nUsuario.Guardar(nUsuario);
                }
            }
            this.Close();
        }
    }
}
