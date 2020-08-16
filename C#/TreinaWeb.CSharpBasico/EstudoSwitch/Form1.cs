using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoSwitch
{
    public partial class frmSwitch : Form
    {
        public frmSwitch()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVerificarNumero_Click(object sender, EventArgs e)
        {
            int numeroDigitado = Convert.ToInt32(txbNumero.Text);
            // 0 ~3: número baixo

        }
    }
}
