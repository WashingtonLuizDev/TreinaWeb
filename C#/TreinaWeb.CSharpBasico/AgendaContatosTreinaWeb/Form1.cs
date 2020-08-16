using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaContatosTreinaWeb
{
    public partial class frmAgendaContatos : Form
    {
        private OperacaoEnum acao;
        public frmAgendaContatos()
        {
            InitializeComponent();
        }

        private void frmAgendaContatos_Shown(object sender, EventArgs e)
        {
            AlterarBotoesSalvareCancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            CarregarListaContatos();
            AlterarEstadoCampos(false);
        }

        private void AlterarBotoesSalvareCancelar(bool estado) {
            btnSalvar.Enabled = estado;
            btnCancelar.Enabled = estado;
            AlterarEstadoCampos(false);
        }

        private void AlterarBotoesIncluirAlterarExcluir(bool estado) {
            btnIncluir.Enabled = estado;
            btnAlterar.Enabled = estado;
            btnExcluir.Enabled = estado;

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            AlterarBotoesIncluirAlterarExcluir(false);
            AlterarBotoesSalvareCancelar(true);
            AlterarEstadoCampos(true);
            acao = OperacaoEnum.INCLUIR;
            LimparCampos();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarBotoesIncluirAlterarExcluir(false);
            AlterarBotoesSalvareCancelar(true);
            AlterarEstadoCampos(true);
            acao = OperacaoEnum.ALTERAR;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvareCancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            AlterarEstadoCampos(false);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvareCancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);

            Contato contato = new Contato
            {
                Nome = txbNome.Text,
                Email = txbEmail.Text,
                NumeroTelefone = txbNumeroTelefone.Text
            };
            List<Contato> contatosList = new List<Contato>();

            foreach (Contato contatoDaLista in lbxContatos.Items)
            {
                contatosList.Add(contatoDaLista);
            }

            if (acao == OperacaoEnum.INCLUIR)
            {
                contatosList.Add(contato);
            }
            else {
                int indice = lbxContatos.SelectedIndex;
                contatosList.RemoveAt(indice);
                contatosList.Insert(indice, contato);
            }

            ManipuladorArquivos.EscreverArquivo(contatosList);
            CarregarListaContatos();
            LimparCampos();
        }

        private void CarregarListaContatos() {
            lbxContatos.Items.Clear();
            lbxContatos.Items.AddRange(ManipuladorArquivos.LerArquivo().ToArray());
            if (lbxContatos.Items.Count> 0) {
                lbxContatos.SelectedIndex = 0;
            }
        }
        private void LimparCampos() {
            txbNumeroTelefone.Text = "";
            txbNome.Text = "";
            txbEmail.Text = "";
        }

        private void AlterarEstadoCampos(bool estado) {
            txbNome.Enabled = estado;
            txbEmail.Enabled = estado;
            txbNumeroTelefone.Enabled= estado;
        }

        private void lbxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxContatos.SelectedIndex >= 0) {
                Contato contato = (Contato)lbxContatos.Items[lbxContatos.SelectedIndex];

                txbNome.Text = contato.Nome;
                txbEmail.Text = contato.Email;
                txbNumeroTelefone.Text = contato.NumeroTelefone;
           }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o contato?","Pergunta",MessageBoxButtons.YesNo) == DialogResult.Yes) {
                lbxContatos.Items.RemoveAt(lbxContatos.SelectedIndex);

                List<Contato> contatosList = new List<Contato>();

                foreach (Contato contato in lbxContatos.Items)
                {
                    contatosList.Add(contato);
                }
                ManipuladorArquivos.EscreverArquivo(contatosList);
                CarregarListaContatos();
                LimparCampos();
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema?", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                frmAgendaContatos.ActiveForm.Close();
            }
            
        }
    }
}
