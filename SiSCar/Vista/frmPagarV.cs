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
    public partial class frmPagarV : Form
    {
        private int id;
        int ida;

        public frmPagarV(int idco, int idAuto, decimal txtCa)
        {
            InitializeComponent();
            id = idco;
            ida = idAuto;
            txtCantidadTo.Text = txtCa.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            Venta ve = new Venta();
            ve.vFecha = DateTime.Now;
            ve.auto_fk = ida;
            ve.comprador_fk = id;
            ve.vTotal = Int32.Parse(txtCantidadTo.Text);
            ve.guardar(ve);

        }

        private decimal resta;
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            resta = Convert.ToDecimal(txtCantidadTo.Text) - Convert.ToDecimal(textBox2.Text);
            textBox3.Text = resta.ToString();
        }
    }
}
