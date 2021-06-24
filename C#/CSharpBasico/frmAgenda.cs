using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpBasico
{
    public partial class frmAgenda : Form
    {
        private OperacaoEnum acao;
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void frmAgenda_Shown(object sender, EventArgs e)
        {
            AlterarBotoesSalvarCancelar(false);
            AlterarEstadoCampos(false);
            CarregarListaContatos();
        }
        #region Ações do form
        private void btnIncluir_Click(object sender, EventArgs e)
        {
            acao = OperacaoEnum.INCLUIR;
            AlterarBotoesSalvarCancelar(true);
            AlterarBotoesIncluirAlterarExcluir(false);
            AlterarEstadoCampos(true);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            acao = OperacaoEnum.ALTERAR;
            AlterarBotoesSalvarCancelar(true);
            AlterarBotoesIncluirAlterarExcluir(false);
            AlterarEstadoCampos(true);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o contato?","Confirmar Exclusão",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                int indice = lbxContatos.SelectedIndex;
                lbxContatos.SelectedIndex = 0;
                lbxContatos.Items.RemoveAt(indice);
                List<Contato> contatosList = new List<Contato>();

                foreach (Contato contato in lbxContatos.Items)
                {
                    contatosList.Add(contato);
                }

                ManipuladorArquivos.EscreverArquivo(contatosList);
                CarregarListaContatos();
                LimparCampos();
                AlterarBotoesSalvarCancelar(true);
                AlterarBotoesIncluirAlterarExcluir(false);
            }
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato(
                        txbNome.Text,
                        txbEmail.Text,
                        txbTelefone.Text
                        );
            List<Contato> contatoList = new List<Contato>();

            foreach (Contato contatoDaLista in lbxContatos.Items)
            {
                contatoList.Add(contatoDaLista);
            }

            if (acao.Equals(OperacaoEnum.INCLUIR))
            {
                contatoList.Add(contato);
            }
            else
            {
                int indice = lbxContatos.SelectedIndex;
                contatoList.RemoveAt(indice);
                contatoList.Insert(indice, contato);
            }

            ManipuladorArquivos.EscreverArquivo(contatoList);
            CarregarListaContatos();
            AlterarBotoesSalvarCancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            LimparCampos();
            AlterarEstadoCampos(false);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AlterarBotoesSalvarCancelar(false);
            AlterarBotoesIncluirAlterarExcluir(true);
            AlterarEstadoCampos(false);
            LimparCampos();
        }

        private void lbxContatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contato contato = (Contato)lbxContatos.Items[lbxContatos.SelectedIndex];
            txbNome.Text = contato.Nome;
            txbEmail.Text = contato.Email;
            txbTelefone.Text = contato.NumeroTelefone;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema?", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ActiveForm.Close();
            }
        }

        //Exibe a ação do botão Sair
        private void btnSair_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int VisibleTime = 1000;
            ToolTip toolTip = new ToolTip();
            toolTip.Show("Sair", button, 40, 30, VisibleTime);
        }

        private void btnCancelar_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int VisibleTime = 1000;
            ToolTip toolTip = new ToolTip();
            toolTip.Show("Cancelar", button, 25, 25, VisibleTime);
        }

        private void btnSalvar_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int VisibleTime = 1000;
            ToolTip toolTip = new ToolTip();
            toolTip.Show("Salvar", button, 25, 25, VisibleTime);
        }

        private void btnExcluir_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int VisibleTime = 1000;
            ToolTip toolTip = new ToolTip();
            toolTip.Show("Excluir", button, 25, 25, VisibleTime);
        }

        private void btnAlterar_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int VisibleTime = 1000;
            ToolTip toolTip = new ToolTip();
            toolTip.Show("Alterar", button, 25, 25, VisibleTime);
        }

        private void btnIncluir_MouseHover(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int VisibleTime = 1000;
            ToolTip toolTip = new ToolTip();
            toolTip.Show("Incluir", button, 25, 25, VisibleTime);
        }

        #endregion

        #region Métodos Auxiliares
        /// <summary>
        /// Método para controlar o estado dos botões Salvar e Cancelar
        /// </summary>
        /// <param name="estado">Define se os botões ficaram habilitados ou não</param>
        private void AlterarBotoesSalvarCancelar(bool estado)
        {
            btnSalvar.Enabled = estado;
            btnCancelar.Enabled = estado;
        }
        /// <summary>
        /// Método para controlar o estado dos botões Incluir/Alterar e Excluir
        /// </summary>
        /// <param name="estado"></param>
        private void AlterarBotoesIncluirAlterarExcluir(bool estado)
        {
            btnAlterar.Enabled = estado;
            btnIncluir.Enabled = estado;
            btnExcluir.Enabled = estado;
        }

        /// <summary>
        /// Método responsável por carregar a lista de contatos na lbxContatos
        /// </summary>
        private void CarregarListaContatos()
        {
            lbxContatos.Items.Clear();
            lbxContatos.Items.AddRange(ManipuladorArquivos.LerArquivo().ToArray());
            lbxContatos.SelectedIndex = 0;
        }

        /// <summary>
        /// Método responsável por limpar os campos do form
        /// </summary>
        private void LimparCampos()
        {
            txbEmail.Text = "";
            txbNome.Text = "";
            txbTelefone.Text = "";
        }

        /// <summary>
        /// Método responsável por alterar o estado dos campos 
        /// </summary>
        /// <param name="estado">Habilita ou desabilita os campos no form</param>
        private void AlterarEstadoCampos(bool estado)
        {
            txbNome.Enabled = estado;
            txbEmail.Enabled = estado;
            txbTelefone.Enabled = estado;
        }


        #endregion

    }
}
