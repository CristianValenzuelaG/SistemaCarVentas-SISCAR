﻿using System;
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
    public partial class frmMainVenta : Form
    {
        public void cargarVentas(int venta)
        {
            List<Venta> nLista = new List<Venta>();
            foreach (var item in Venta.BuscarporFecha(venta))
            {
                nLista.Add(item);
            }
            this.grDatos.DataSource = nLista;
        }
        public frmMainVenta()
        {
            InitializeComponent();
            grDatos.AutoGenerateColumns = false;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {

            }
            else
            {
                this.cargarVentas(Int32.Parse(txtBuscar.Text));
                //grDatos.DataSource = Venta.BuscarporFecha(Convert.ToDateTime(txtBuscar.Text));
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmComprador we = new frmComprador();
            we.Show();

        }
    }
}
