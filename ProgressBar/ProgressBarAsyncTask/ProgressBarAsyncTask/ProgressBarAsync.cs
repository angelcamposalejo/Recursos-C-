using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarAsyncTask
{
    public partial class ProgressBarAsync : Form
    {
        public ProgressBarAsync()
        {
            InitializeComponent();
        }

        public void procesar(IProgress<int> progreso)
        {
            for(int i = 1; i <= 100; i++)
            {
                Thread.Sleep(100);
                if (progreso != null)
                    progreso.Report(i);
            }
        }

        private async void btnIniciar_Click(object sender, EventArgs e)
        {
            pBCarga.Value = 0;
            var progreso = new Progress<int>(porcentaje =>
            {
                pBCarga.Value = porcentaje;
            });
            await Task.Run(()=>procesar(progreso));
        }
    }
}
