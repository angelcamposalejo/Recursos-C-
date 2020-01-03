using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertImagenEscalaGrises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofdAbrirImagen=new OpenFileDialog() { Filter="Images|*.jpg"})
            {
                if (ofdAbrirImagen.ShowDialog() == DialogResult.OK)
                    pbCargaImagen.Image = Image.FromFile(ofdAbrirImagen.FileName);
            }
        }

        public Bitmap convertirEscalaGrises(Bitmap origen)
        {
            Bitmap nuevaBitMap = new Bitmap(origen.Width, origen.Height);
            Graphics g = Graphics.FromImage(nuevaBitMap);
            ColorMatrix colorMatrix = new ColorMatrix(
                new float[][]
                {
                    new float[] {.3f,.3f,.3f,0,0},
                    new float[] {.59f, .59f, .59f, 0, 0},
                    new float[] {.11f, .11f, .11f, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {0, 0, 0, 0, 1}
                }
                );
            ImageAttributes img = new ImageAttributes();
            img.SetColorMatrix(colorMatrix);
            g.DrawImage(origen, new Rectangle(0,0,origen.Width,origen.Height), 0, 0, origen.Width, origen.Height, GraphicsUnit.Pixel, img);
            g.Dispose();
            return nuevaBitMap;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            pbConversion.Image = convertirEscalaGrises((Bitmap)pbCargaImagen.Image);
        }
    }
}
