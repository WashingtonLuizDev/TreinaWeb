using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoEnumeradores
{
    public partial class frmEstudoEnumeradores : Form
    {
        public frmEstudoEnumeradores()
        {
            InitializeComponent();
        }

        private void frmEstudoEnumeradores_Shown(object sender, EventArgs e)
        {
            cmbDias.DataSource = Enum.GetNames(typeof(DiasEnum));
        }

        private void btnExibirDia_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dia Escolhido: " + Enum.GetName(typeof(DiasEnum),cmbDias.SelectedIndex));
        }
    }
}
