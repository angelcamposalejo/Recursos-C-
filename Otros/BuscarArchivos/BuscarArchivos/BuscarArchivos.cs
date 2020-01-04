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

namespace BuscarArchivos
{
    public partial class BuscarArchivos : Form
    {
        public BuscarArchivos()
        {
            InitializeComponent();
        }

        public void agregarElementoLista(string file)
        {
            FileInfo fi = new FileInfo(file);
            dataGridView1.Invoke((Action)(() =>
            {
                var icon = Icon.ExtractAssociatedIcon(file);
                string key = Path.GetExtension(file);
                dataGridView1.Rows.Add(fi.Name, fi.DirectoryName, Math.Ceiling(fi.Length / 1024f).ToString("0 KB"));
            }));
        }

        public void escanearDirectorio(string directorio,string busqueda)
        {
            foreach(var file in Directory.GetFiles(directorio))
            {
                if (bwBusqueda.CancellationPending)
                    return;
                lbPorcentaje.Invoke((Action)(() => lbEstatus.Text = file));
                if (file.Contains(busqueda))
                    agregarElementoLista(file);

            }

            foreach (var dir in Directory.GetDirectories(directorio))
                escanearDirectorio(dir, busqueda);
        }

        private void btnRuta_Click(object sender, EventArgs e)
        {
            using(FolderBrowserDialog fbd=new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                    tbxRuta.Text = fbd.SelectedPath;
            }
        }

        private void bwBusqueda_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] directorio = Directory.GetDirectories(tbxRuta.Text);
            float length = directorio.Length;
            pbCarga.Invoke((Action)(() => pbCarga.Maximum = directorio.Length));
            escanearDirectorio(tbxRuta.Text, tbxBusqueda.Text);
            for (int i = 0; i < directorio.Length; i++)
            {
                bwBusqueda.ReportProgress((int)(i / length * 100));
                escanearDirectorio(directorio[i], tbxBusqueda.Text);
            }
            bwBusqueda.ReportProgress(100);
        }

        private void bwBusqueda_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (!bwBusqueda.CancellationPending)
            {
                lbPorcentaje.Text = e.ProgressPercentage + "%";
                pbCarga.PerformStep();
            }
        }

        private void bwBusqueda_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbEstatus.Text = String.Format("Found {0} item.", dataGridView1.RowCount);
            if (pbCarga.Value < pbCarga.Maximum)
                lbEstatus.Text = "Busqueda finalizada...";
            btnBusqueda.Text = "Buscar";
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            if (bwBusqueda.IsBusy)
                bwBusqueda.CancelAsync();
            else
            {
                pbCarga.Value = pbCarga.Minimum;
                btnBusqueda.Text = "Detener";
                dataGridView1.Rows.Clear();
                bwBusqueda.RunWorkerAsync();
            }
        }
    }
}
