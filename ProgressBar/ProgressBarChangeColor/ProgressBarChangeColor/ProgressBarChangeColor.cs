using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ProgressBarChangeColor
{
    public partial class ProgressBarChangeColor : Form
    {
        public ProgressBarChangeColor()
        {
            InitializeComponent();
        }

        private void ProgressBarChangeColor_Load(object sender, EventArgs e)
        {
            ProgressBarColor.SetState(pbUno, 2);
            ProgressBarColor.SetState(pbDos, 1);
            ProgressBarColor.SetState(pbTres, 3);
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            for(int i = 0; i <= 100; i++)
            {
                pbUno.Value = i;
                pbDos.Value = i;
                pbTres.Value = i;
                Thread.Sleep(100);
            }
        }
    }
}
