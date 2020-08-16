using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OperadoresAritmeticos
{
    public partial class frmCalculadora : Form
    {
        double numero1;
        double numero2;
        double resultado;
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void btnAdicao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txbNumero1.Text);
            numero2 = Convert.ToDouble(txbNumero2.Text);
            txbResultado.Text = Convert.ToString(Somar(numero1, numero2 ));
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txbNumero1.Text);
            numero2 = Convert.ToDouble(txbNumero2.Text);
            txbResultado.Text = Convert.ToString(Subtrair(numero1, numero2));
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txbNumero1.Text);
            numero2 = Convert.ToDouble(txbNumero2.Text);
            txbResultado.Text = Convert.ToString(Multiplicar(numero1,numero2));
        }

        private void btnDivicao_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToDouble(txbNumero1.Text);
            numero2 = Convert.ToDouble(txbNumero2.Text);
            txbResultado.Text = Convert.ToString(Divisao(numero1, numero2));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCalculadora.ActiveForm.Close();
        }

        double Somar(params double[] numeros) {
            resultado = 0;
            foreach (double numero in numeros)
            {
                resultado += numero;
            }
            return resultado;
        }

        double Subtrair(params double[] numeros)
        {
            resultado = 0;
            foreach (double numero in numeros)
            {
                resultado -= numero;
            }
            return resultado;
        }

        double Multiplicar(double numero1, double numero2)
        {
            return numero1 * numero2;
        }

        double Divisao(double numero1, double numero2) {
            return numero1 / numero2;
        }

    }
}
