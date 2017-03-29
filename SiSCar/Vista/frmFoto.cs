using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO;

namespace SiSCar.Vista
{
    public partial class frmFoto : Form
    {
        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        public string foto;
        public frmFoto()
        {
            InitializeComponent();
            BuscarDispositivos();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            EspacioCamara.Image = Imagen;


        }

        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++) ;

            cbxDispositivos.Items.Add(Dispositivos[0].Name.ToString());
            cbxDispositivos.Text = cbxDispositivos.Items[0].ToString();

        }

        public void BuscarDispositivos()
        {
            DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivoDeVideo.Count == 0)
            {
                ExisteDispositivo = false;
            }

            else
            {
                ExisteDispositivo = true;
                CargarDispositivos(DispositivoDeVideo);

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            picMostrar.Image = EspacioCamara.Image;
            button3.Visible = true;
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FuenteDeVideo.Stop();
            foto = "foto" + frmEntradaAutos.id + ".jpg";
            string ruta = Path.Combine(@"C:\foto\", foto);
            picMostrar.Image.Save(ruta, System.Drawing.Imaging.ImageFormat.Png);
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cbxDispositivos.SelectedIndex = 0;
            FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cbxDispositivos.SelectedIndex].MonikerString);
            FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
            FuenteDeVideo.Start();
            button2.Visible = true;
            button1.Visible = false;
        }
    }
}
