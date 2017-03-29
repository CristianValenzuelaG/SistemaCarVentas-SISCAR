using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace SiSCar.Vista
{
    public partial class frmFotoCarro : Form
    {
        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;
        public string foto1;
        public frmFotoCarro()
        {
            InitializeComponent();
            BuscarDispositivos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cbxDispositivos.SelectedIndex].MonikerString);
            FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
            FuenteDeVideo.Start();
            button2.Visible = true;
            button1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            FuenteDeVideo.Stop();
                foto1 = "foto" + frmEntradaAutos.id + ".jpg";
                string ruta = Path.Combine(@"C:\foto\", foto1);
                picMostrar.Image.Save(ruta, System.Drawing.Imaging.ImageFormat.Jpeg);
            Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            picMostrar.Image = EspacioCamara.Image;
            button3.Visible = true;
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
    }
}
