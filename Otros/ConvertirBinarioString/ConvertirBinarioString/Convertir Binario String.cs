using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertirBinarioString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string binarioAstring(string binario)
        {
            List<byte> bytes = new List<byte>();
            for (int i = 0; i < binario.Length; i += 8)
                bytes.Add(Convert.ToByte(binario.Substring(i, 8), 2));
            return Encoding.ASCII.GetString(bytes.ToArray());
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            tbxCadena.Text = binarioAstring(tbxBinario.Text);
        }
    }
}
