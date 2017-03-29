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
    public partial class frmEntradaAutos : Form
    {
        public static string id;
        public static int iD_Buscar = 0;
        List<Propietario> nLista = new List<Propietario>();
        List<Auto> nListaAuto = new List<Auto>();
        public static Boolean VALIDAR = true;
        public static int MODIFICARAUTO = 0;
        public static int MODIFICARPROPIETARIO = 0;
        public static Boolean VALIDARAUTO = true;
        public frmEntradaAutos()
        {
            VALIDAR = true;
            InitializeComponent();
        }

        #region ParaModificar

        public frmEntradaAutos(int IDMODIFICAR)
        {
            InitializeComponent();
            VALIDAR = false;
            VALIDARAUTO = true;
            MODIFICARAUTO = IDMODIFICAR;
            txtNombre.ReadOnly = true;
            txtDireccion.ReadOnly = true;
            txtTelefono.ReadOnly = true;
            txtEmail.ReadOnly = true;
            txtIne.ReadOnly = true;
            txtFotopro.ReadOnly = true;
            btnBuscarPro.Hide();
            btnFotoPropie.Hide();
            foreach (var item in Auto.BuscarporID(IDMODIFICAR))
            {
                nListaAuto.Add(item);
            }

            foreach (var value in nListaAuto)
            {

                txtMarca.Text = value.aMarca.ToString();
                txtModelo.Text = value.aModelo.ToString();
                cmbAño.Text = value.aAño.ToString();
                txtNPlaca.Text = value.aNPlaca.ToString();
                txtNSerie.Text = value.aNSerie.ToString();
                txtPrecio.Text = value.aPrecio.ToString();
                txtColor.Text = value.aColor.ToString().Trim();
                txtPrecio.Text = value.aPrecio.ToString();
                txtNacionalida.Text = value.aNacionalidad.ToString();
                txtObserva.Text = value.aComentario.ToString();
                txtFoto1.Text = value.aFoto1.ToString();
                txtfoto2.Text = value.aFoto2.ToString();
                txtFoto3.Text = value.aFoto3.ToString();




            }
        }
        public frmEntradaAutos(string IDMODIFICARPROPIETARIO)
        {
            InitializeComponent();
            VALIDAR = false;
            VALIDARAUTO = false;
            MODIFICARPROPIETARIO = Convert.ToInt32(IDMODIFICARPROPIETARIO);
            txtMarca.ReadOnly = true;
            txtModelo.ReadOnly = true;
            txtNSerie.ReadOnly = true;
            txtNPlaca.ReadOnly = true;
            txtColor.ReadOnly = true;
            txtNacionalida.ReadOnly = true;
            txtObserva.ReadOnly = true;
            txtPrecio.ReadOnly = true;
            txtFoto1.ReadOnly = true;
            txtfoto2.ReadOnly = true;
            txtFoto3.ReadOnly = true;
            cmbAño.Hide();
            btnf2.Hide();
            btnf3.Hide();
            btnFotoAuto.Hide();
            btnBuscarPro.Hide();
            if (MODIFICARPROPIETARIO != 0)
            {
                foreach (var item in Propietario.BuscarporID(MODIFICARPROPIETARIO))
                {
                    nLista.Add(item);
                }

                foreach (var value in nLista)
                {

                    lblID.Text = value.pkPropietario.ToString();
                    txtNombre.Text = value.pNombre.ToString();
                    txtDireccion.Text = value.pDireccion.ToString();
                    txtTelefono.Text = value.pTelefono.ToString();
                    txtEmail.Text = value.pCorreo.ToString();
                    txtIne.Text = value.pIfe.ToString();
                    txtFotopro.Text = value.pFoto.ToString().Trim();

                }
            }
        }

        #endregion
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            

                if (VALIDAR == true)
                {
                if (txtfoto2.Text == "" || txtColor.Text == "" || txtDireccion.Text == "" || txtEmail.Text == "" ||
                txtFoto1.Text == "" || txtFoto3.Text == "" || txtFotopro.Text == "" || txtIne.Text == "" ||
                txtMarca.Text == "" || txtModelo.Text == "" || txtDireccion.Text == "" || txtNPlaca.Text == "" ||
                txtNSerie.Text == "" || txtNacionalida.Text == "" || txtNombre.Text == "" || txtObserva.Text == "" ||
                txtPrecio.Text == "" || txtTelefono.Text == "")
                {
                    MessageBox.Show("Error", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult a = MessageBox.Show("Pago $200", "Advertencia", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);
                    if (a == DialogResult.Yes)
                    {
                        if (lblID.Text != "if")
                        {
                            Propietario nPropietario = new Propietario();

                            nPropietario.pNombre = txtNombre.Text;
                            nPropietario.pDireccion = txtDireccion.Text;
                            nPropietario.pTelefono = txtTelefono.Text;
                            nPropietario.pCorreo = txtEmail.Text;
                            nPropietario.pIfe = txtIne.Text;
                            nPropietario.pFoto = txtFotopro.Text;

                            nPropietario.Guardar(nPropietario);

                            Auto nAuto = new Auto();
                            nAuto.aMarca = txtMarca.Text;
                            nAuto.aModelo = txtModelo.Text;
                            nAuto.aAño = Convert.ToInt32(cmbAño.Text);
                            nAuto.aNSerie = Convert.ToInt32(txtNSerie.Text);
                            nAuto.aNPlaca = txtNPlaca.Text;
                            nAuto.aColor = txtColor.Text;
                            nAuto.aNacionalidad = txtNacionalida.Text;
                            nAuto.aComentario = txtObserva.Text;
                            nAuto.aPrecio = Convert.ToInt32(txtPrecio.Text);
                            nAuto.aFoto1 = txtFoto1.Text;
                            nAuto.aFoto2 = txtfoto2.Text;
                            nAuto.aFoto3 = txtFoto3.Text;

                            nAuto.Guardar(nAuto);
                        }
                        else
                        {
                            Propietario nPropietario = new Propietario();

                            nPropietario.pNombre = txtNombre.Text;
                            nPropietario.pDireccion = txtDireccion.Text;
                            nPropietario.pTelefono = txtTelefono.Text;
                            nPropietario.pCorreo = txtEmail.Text;
                            nPropietario.pIfe = txtIne.Text;
                            nPropietario.pFoto = txtFotopro.Text;

                            nPropietario.Guardar(nPropietario);

                            Auto nAuto = new Auto();
                            nAuto.aMarca = txtMarca.Text;
                            nAuto.aModelo = txtModelo.Text;
                            nAuto.aAño = Convert.ToInt32(cmbAño.Text);
                            nAuto.aNSerie = Convert.ToInt32(txtNSerie.Text);
                            nAuto.aNPlaca = txtNPlaca.Text;
                            nAuto.aColor = txtColor.Text;
                            nAuto.aNacionalidad = txtNacionalida.Text;
                            nAuto.aComentario = txtObserva.Text;
                            nAuto.aPrecio = Convert.ToInt32(txtPrecio.Text);
                            nAuto.aFoto1 = txtFoto1.Text;
                            nAuto.aFoto2 = txtfoto2.Text;
                            nAuto.aFoto3 = txtFoto3.Text;


                            nAuto.Guardar(nAuto);
                        }


                        this.Close();
                    }
                    else
                    {
                        if (lblID.Text != "if")
                        {
                            Propietario nPropietario = new Propietario();

                            nPropietario.pNombre = txtNombre.Text;
                            nPropietario.pDireccion = txtDireccion.Text;
                            nPropietario.pTelefono = txtTelefono.Text;
                            nPropietario.pCorreo = txtEmail.Text;
                            nPropietario.pIfe = txtIne.Text;
                            nPropietario.pFoto = txtFotopro.Text;


                            nPropietario.Guardar(nPropietario);

                            Auto nAuto = new Auto();
                            nAuto.aMarca = txtMarca.Text;
                            nAuto.aModelo = txtModelo.Text;
                            nAuto.aAño = Convert.ToInt32(cmbAño.Text);
                            nAuto.aNSerie = Convert.ToInt32(txtNSerie.Text);
                            nAuto.aNPlaca = txtNPlaca.Text;
                            nAuto.aColor = txtColor.Text;
                            nAuto.aNacionalidad = txtNacionalida.Text;
                            nAuto.aComentario = txtObserva.Text;
                            nAuto.aPrecio = Convert.ToInt32(txtPrecio.Text);
                            nAuto.aFoto1 = txtFoto1.Text;
                            nAuto.aFoto2 = txtfoto2.Text;
                            nAuto.aFoto3 = txtFoto3.Text;
                            nAuto.aStatus = false;


                            nAuto.Guardar(nAuto);
                        }
                        else
                        {
                            Propietario nPropietario = new Propietario();

                            nPropietario.pNombre = txtNombre.Text;
                            nPropietario.pDireccion = txtDireccion.Text;
                            nPropietario.pTelefono = txtTelefono.Text;
                            nPropietario.pCorreo = txtEmail.Text;
                            nPropietario.pIfe = txtIne.Text;
                            nPropietario.pFoto = txtFotopro.Text;
                            nPropietario.pStatus = false;

                            nPropietario.Guardar(nPropietario);

                            Auto nAuto = new Auto();
                            nAuto.aMarca = txtMarca.Text;
                            nAuto.aModelo = txtModelo.Text;
                            nAuto.aAño = Convert.ToInt32(cmbAño.Text);
                            nAuto.aNSerie = Convert.ToInt32(txtNSerie.Text);
                            nAuto.aNPlaca = txtNPlaca.Text;
                            nAuto.aColor = txtColor.Text;
                            nAuto.aNacionalidad = txtNacionalida.Text;
                            nAuto.aComentario = txtObserva.Text;
                            nAuto.aPrecio = Convert.ToInt32(txtPrecio.Text);
                            nAuto.aFoto1 = txtFoto1.Text;
                            nAuto.aFoto2 = txtfoto2.Text;
                            nAuto.aFoto3 = txtFoto3.Text;
                            nAuto.aStatus = false;

                            nAuto.Guardar(nAuto);
                        }

                    }
                }
                } else
                {
                    if (VALIDARAUTO == true)
                    {
                        Auto nAuto = new Auto();
                        nAuto.pkAuto = MODIFICARAUTO;
                        nAuto.aMarca = txtMarca.Text;
                        nAuto.aModelo = txtModelo.Text;
                        nAuto.aAño = Convert.ToInt32(cmbAño.Text);
                        nAuto.aNSerie = Convert.ToInt32(txtNSerie.Text);
                        nAuto.aNPlaca = txtNPlaca.Text;
                        nAuto.aColor = txtColor.Text;
                        nAuto.aNacionalidad = txtNacionalida.Text;
                        nAuto.aComentario = txtObserva.Text;
                        nAuto.aPrecio = Convert.ToDouble(txtPrecio.Text);
                        nAuto.aFoto1 = txtFoto1.Text;
                        nAuto.aFoto2 = txtfoto2.Text;
                        nAuto.aFoto3 = txtFoto3.Text;

                        nAuto.Guardar(nAuto);
                    }
                    else
                    {
                        Propietario nPropietario = new Propietario();
                        if (MODIFICARPROPIETARIO != 0)
                        {
                            nPropietario.pkPropietario = MODIFICARPROPIETARIO;
                        }
                        nPropietario.pNombre = txtNombre.Text;
                        nPropietario.pDireccion = txtDireccion.Text;
                        nPropietario.pTelefono = txtTelefono.Text;
                        nPropietario.pCorreo = txtEmail.Text;
                        nPropietario.pIfe = txtIne.Text;
                        nPropietario.pFoto = txtFotopro.Text;

                        nPropietario.Guardar(nPropietario);

                    }
                   
            }
            this.Close();

        }


        private void btnFotoPropie_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Trim() != "")
            {
                id = txtNombre.Text.Trim();
                frmFoto f1 = new frmFoto();
                f1.ShowDialog();
                txtFotopro.Text = f1.foto;
            }
        }

        private void txtFoto1_TextChanged(object sender, EventArgs e)
        {
            if (txtFoto1.Text.Trim() != "")
            {
                picAuto1.ImageLocation = @"C:\foto\" + txtFoto1.Text.Trim();
            }
        }

        private void txtfoto2_TextChanged(object sender, EventArgs e)
        {
            if (txtfoto2.Text.Trim() != "")
            {
                picAuto2.ImageLocation = @"C:\foto\" + txtfoto2.Text.Trim();
            }
        }

        private void txtFoto3_TextChanged(object sender, EventArgs e)
        {
            if (txtFoto3.Text.Trim() != "")
            {
                picAuto3.ImageLocation = @"C:\foto\" + txtFoto3.Text.Trim();
            }
        }


        private void btnFotoAuto_Click(object sender, EventArgs e)
        {

            if (txtNPlaca.Text.Trim() != "")
            {
                frmFotoCarro f1 = new frmFotoCarro();
                id = txtNPlaca.Text.Trim() + "fa1";
                f1.ShowDialog();
                txtFoto1.Text = f1.foto1;

            }
        }

        private void btnf2_Click(object sender, EventArgs e)
        {
            if (txtNPlaca.Text.Trim() != "")
            {
                    frmFotoCarro f1 = new frmFotoCarro();
                    id = txtNPlaca.Text.Trim() + "fa2";
                    f1.ShowDialog();
                txtfoto2.Text = f1.foto1;

            }
        }

        private void btnf3_Click(object sender, EventArgs e)
        {
            if (txtNPlaca.Text.Trim() != "")
            {
                frmFotoCarro f1 = new frmFotoCarro();
                id = txtNPlaca.Text.Trim() + "fa3";
                f1.ShowDialog();
                txtFoto3.Text = f1.foto1;
            }
        }

        private void txtFotopro_TextChanged(object sender, EventArgs e)
        {
            if (txtFotopro.Text.Trim() != "")
            {
                picPropie.ImageLocation = @"C:\foto\" + txtFotopro.Text.Trim();
            }
        }

        private void btnBuscarPro_Click(object sender, EventArgs e)
        {
            frmMainPropietario pro = new frmMainPropietario();
            pro.ShowDialog();
            Propietario prop = new Propietario();
            foreach (var item in Propietario.BuscarporID(iD_Buscar))
            {
                nLista.Add(item);
            }

            foreach (var value in nLista)
            {
                lblID.Text = value.pkPropietario.ToString();
                txtNombre.Text = value.pNombre.ToString();
                txtDireccion.Text = value.pDireccion.ToString();
                txtTelefono.Text = value.pTelefono.ToString();
                txtEmail.Text = value.pCorreo.ToString();
                txtIne.Text = value.pIfe.ToString();
                txtFotopro.Text = value.pFoto.ToString().Trim();

            }
        }
        ValidacionesTXT nu = new ValidacionesTXT();
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            nu.SoloLetra(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            nu.SoloNumeros(e);
        }

        private void txtNSerie_KeyPress(object sender, KeyPressEventArgs e)
        {
            nu.SoloNumeros(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            nu.SoloNumeros(e);
        }

        private void txtColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            nu.SoloLetra(e);
        }
    }
}
