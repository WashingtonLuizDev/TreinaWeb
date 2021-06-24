using Exercicio_3.Domain;
using Exercicio_3.Models;
using Exercicio_3.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Exercicio_3
{
    public partial class frmEstoque : Form
    {
        #region Variáveis programa

        private OperacaoEnum acao;

        #endregion

        #region Procedimentos programa
        private void AlterarBotaoSalvar(bool estado) 
        {
            btnSalvar.Enabled = estado;
        }

        private void AlterarBotaoIncluirAlterarExcluir(bool estado) 
        {
            btnIncluir.Enabled = estado;
            btnAlterar.Enabled = estado;
            btnExcluir.Enabled = estado;
        }

        private void AlterarEstadoCamposProduto(bool estado)
        {
            txbProdutos.Enabled = estado;
            txbPreco.Enabled = estado;
            txbQuantidade.Enabled = estado;
        }

        private void CarregarListaProduto()
        {
            lsbProdutos.Items.Clear();
            lsbProdutos.Items.AddRange(ManipuladorArquivo.LerArquivo().ToArray());
        }

        private void LimparCamposProduto()
        {
            txbProdutos.Text = "";
            txbPreco.Text = "";
            txbQuantidade.Text = "";
        }
        
        #endregion

        public frmEstoque()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair do sistema?", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.No)
                return;
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto
            {
                Nome = txbProdutos.Text,
                Preco = Convert.ToDouble(txbPreco.Text),
                Quantidade = Convert.ToDouble(txbQuantidade.Text)
            };

            List<Produto> produtosList = new List<Produto>();
            foreach (Produto produtoDaLista in lsbProdutos.Items)
            {
                produtosList.Add(produtoDaLista);
            }

            if (acao == OperacaoEnum.INCLUIR)
            {
                produtosList.Add(produto);
            }
            else 
            {
                int indice = lsbProdutos.SelectedIndex;
                produtosList.RemoveAt(indice);
                produtosList.Insert(indice, produto);
            }

            ManipuladorArquivo.EscreverArquivo(produtosList);
            CarregarListaProduto();
            AlterarBotaoSalvar(false);
            AlterarBotaoIncluirAlterarExcluir(true);
            LimparCamposProduto();
            AlterarEstadoCamposProduto(false);
        }

        private void frmEstoque_Shown(object sender, EventArgs e)
        {
            AlterarBotaoIncluirAlterarExcluir(false);
            AlterarBotaoSalvar(false);
            AlterarEstadoCamposProduto(false);
            btnIncluir.Enabled = true;
            CarregarListaProduto();
        }

        private void lsbProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsbProdutos.SelectedIndex < 0)
            {
                return;
            }

            Produto produto = (Produto)lsbProdutos.Items[lsbProdutos.SelectedIndex];
            txbProdutos.Text = produto.Nome;
            txbPreco.Text = produto.Preco.ToString();
            txbQuantidade.Text = produto.Quantidade.ToString();

            AlterarBotaoIncluirAlterarExcluir(true);
            AlterarBotaoSalvar(true);
            AlterarEstadoCamposProduto(false);
            acao = OperacaoEnum.ALTERAR;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"Confirma a exclusão do produto {lsbProdutos.SelectedItem.ToString()}?", "Pergunta", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            int indiceExcluido = lsbProdutos.SelectedIndex;
            lsbProdutos.SelectedIndex = 0;
            lsbProdutos.Items.RemoveAt(indiceExcluido);
            List<Produto> produtosList = new List<Produto>();
            foreach (Produto produto in lsbProdutos.Items)
            {
                produtosList.Add(produto);
            }
            ManipuladorArquivo.EscreverArquivo(produtosList);
            CarregarListaProduto();
            LimparCamposProduto();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            AlterarBotaoSalvar(true);
            AlterarBotaoIncluirAlterarExcluir(false);
            AlterarEstadoCamposProduto(true);
            LimparCamposProduto();
            acao = OperacaoEnum.INCLUIR;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            AlterarBotaoSalvar(true);
            AlterarBotaoIncluirAlterarExcluir(false);
            AlterarEstadoCamposProduto(true);
            acao = OperacaoEnum.ALTERAR;
        }

    }
}
