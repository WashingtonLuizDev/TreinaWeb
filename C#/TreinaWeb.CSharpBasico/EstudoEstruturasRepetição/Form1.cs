using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoEstruturasRepetição
{
    public partial class frmEstruturasRepeticao : Form
    {
        public frmEstruturasRepeticao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txbNumero.Text);

            for (int i = 0; i <= 10; i++)
            {
                lstTabuada.Items.Add(String.Format("{0} * {1} = {2}", numero, i, numero * i));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txbNumero.Text);
            int i = 0;
            while (i <= 10) {
                lstTabuada.Items.Add(String.Format("{0} * {1} = {2}", numero, i,numero * i));
                i++;
            }
        }
    }
}
