using System;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormInformaProdutoVenda: Form {

        public Produto ProdutoSelecionado { get; private set; }

        public Int32 Quantidade { get; private set; }

        public FormInformaProdutoVenda(Produto produto, Int32 quantidade) {
            InitializeComponent();
            if (produto != null) {
                ProdutoSelecionado = produto;
                Quantidade = quantidade;
                tbProduto.Text = produto.Descricao;
            }
            tbQuantidade.Text = quantidade.ToString();
        }

        private void btnSelecionar_Click(object sender, EventArgs e) {
            FormSelecao<Produto> frmSelecao = new FormSelecao<Produto>(Repository.Banco.Produtos, Produto.GetColumnNames());
            frmSelecao.ShowDialog();
            if (frmSelecao.DialogResult != DialogResult.OK) {
                tbProduto.Enabled = true;
                return;
            }
            ProdutoSelecionado = frmSelecao.SelecionadoCast;
            tbProduto.Text = ProdutoSelecionado.Descricao;
            tbProduto.Enabled = false;
            frmSelecao.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (tbQuantidade.Text.Trim().Equals("")) {
                MessageBox.Show(@"Informe a quantidade do produto");
                return;
            }
            if (Convert.ToInt32(tbQuantidade.Text) <= 0) {
                MessageBox.Show(@"A quantidade do produto deve ser maior que zero");
                return;
            }
            if (tbProduto.Text.Trim().Equals("")) {
                MessageBox.Show(@"Informe um produto");
                return;
            }
            Quantidade = Convert.ToInt32(tbQuantidade.Text);
            if (!VerificaEstoque()) {
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private Boolean VerificaEstoque() {
            Int32 index = Repository.Banco.Produtos.IndexOf(ProdutoSelecionado);

            if (ProdutoSelecionado.QuantidadeEstoque.Equals(0)) {
                MessageBox.Show($"Este produto não está disponível no estoque \n Quantidade de estoque: {ProdutoSelecionado.QuantidadeEstoque}");
                return false;
            }
            Int32 qtd = Repository.Banco.Produtos[index].QuantidadeEstoque - Quantidade;
            if (qtd >= 0) {
                return true;
            }
            MessageBox.Show($"A quantidade informada não pode ser maior que a quantidade disponível do produto no estoque \n Quantidade de estoque: {ProdutoSelecionado.QuantidadeEstoque}");
            return false;
        }

    }

}