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

namespace ConversionImagenBase64
{
    public partial class ConversionImagen : Form
    {
        public ConversionImagen()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofdAbrirImagen = new OpenFileDialog() { Filter = "Images|*.jpg" })
            {
                if (ofdAbrirImagen.ShowDialog() == DialogResult.OK)
                    pbOrigen.Image = Image.FromFile(ofdAbrirImagen.FileName);
            }
        }

        public string convertirImagenAbase64(Image origen)
        {
            using(MemoryStream memoryStream=new MemoryStream())
            {
                origen.Save(memoryStream, origen.RawFormat);
                byte[] imagenBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imagenBytes);
            }
        }

        public Image convertirBase64Aimagen(string base64)
        {
            byte[] imagenBytes = Convert.FromBase64String(base64);
            using (MemoryStream ms= new MemoryStream(imagenBytes,0,imagenBytes.Length))
            {
                ms.Write(imagenBytes, 0, imagenBytes.Length);
                return Image.FromStream(ms, true);
            }
        }

        private void btnBase_Click(object sender, EventArgs e)
        {
            using(Image imagen=pbOrigen.Image.Clone() as Image)
            {
                txtBase.Text = convertirImagenAbase64(imagen);
            }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            pbConversion.Image = convertirBase64Aimagen(txtBase.Text);
        }
    }
}
