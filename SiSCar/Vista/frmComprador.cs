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
using SiSCar.Modelo;

namespace SiSCar.Vista
{
    public partial class frmComprador : Form
    {
        public static int iD_Buscar_Propietario = 0;
        public static int iD_Buscar_Carro = 0;
        List<Propietario> nLista_Propietario = new List<Propietario>();
        List<Auto> nLista_Auto = new List<Auto>();

        public frmComprador()
        {
            InitializeComponent();
        }

        private void btnBuscaPropie_Click(object sender, EventArgs e)
        {
            frmMainPropietario pro = new frmMainPropietario();
            pro.ShowDialog();
            Propietario prop = new Propietario();
            foreach (var item in Propietario.BuscarporID_Comprar(iD_Buscar_Propietario))
            {
                nLista_Propietario.Add(item);
            }

            foreach (var value in nLista_Propietario)
            {
                txtNombre.Text = value.pNombre.ToString();
                txtDireccion.Text = value.pDireccion.ToString();
                lblCo.Text = value.pkPropietario.ToString();

            }
        }

        private void btnBuscarCar_Click(object sender, EventArgs e)
        {
            frmMainAuto auto = new frmMainAuto();
            auto.ShowDialog();
            Auto carro = new Auto();

            foreach (var item in Auto.BuscarporID(iD_Buscar_Carro))
            {
                nLista_Auto.Add(item);
            }

            foreach (var value in nLista_Auto)
            {
                txtMarca.Text = value.aMarca.ToString();
                txtModelo.Text = value.aModelo.ToString();
                txtColor.Text = value.aColor.ToString();
                lblCa.Text = value.pkAuto.ToString();
                textBox1.Text = value.aPrecio.ToString();
                double comision = Convert.ToDouble(textBox1.Text) * 0.20;
                double das = Convert.ToDouble(textBox1.Text) * 0.16;
                textBox2.Text = das.ToString();
                double nn = das + Convert.ToDouble(textBox1.Text);
                textBox3.Text = nn.ToString();
               
            }
        }


        private void btnPagar_Click(object sender, EventArgs e)
        {
            int lbco = Int32.Parse(lblCo.Text);
            int lblca = Int32.Parse(lblCa.Text);
            decimal To = decimal.Parse(textBox3.Text);
            DialogResult con = MessageBox .Show("Esta seguro de pagar","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (con == DialogResult.Yes)
            {
                Comprador nue = new Comprador();
               
                nue.cNombre = txtNombre.Text;
                nue.cDireccion = txtDireccion.Text;
                nue.cCiudad = txtCiudad.Text;
                nue.guardar(nue);

                frmPagarV nuev = new frmPagarV(lbco, lblca,To);
                nuev.Show();
               

            }
            else
            {
                
            }
        }
        ValidacionesTXT  nu = new ValidacionesTXT();
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            nu.SoloLetra(e);
        }

 
        private void txtCiudad_KeyPress(object sender, KeyPressEventArgs e)
        {
            nu.SoloLetra(e);
        }


        private void txtColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            nu.SoloLetra(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            nu.SoloNumeros(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            nu.SoloNumeros(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            nu.SoloNumeros(e);
        }
    }

}
