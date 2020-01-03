using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertirStringBinario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string convertirStringBinario(string origen)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in origen.ToCharArray())
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            return sb.ToString();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            tbxBinary.Text = convertirStringBinario(tbxString.Text);
        }
    }
}
