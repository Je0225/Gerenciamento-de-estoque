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
            FormSelecaoProdutoVenda frmSelecaoProdutoVenda = new FormSelecaoProdutoVenda();
            frmSelecaoProdutoVenda.ShowDialog();
            frmSelecaoProdutoVenda.Dispose();
            if (frmSelecaoProdutoVenda.DialogResult != DialogResult.OK) {
                tbProduto.Enabled = true;
                return;
            }
            ProdutoSelecionado = frmSelecaoProdutoVenda.ProdutoSelecionado;
            tbProduto.Text = ProdutoSelecionado.Descricao;
            tbProduto.Enabled = false;
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
            DialogResult = DialogResult.OK;
            Close();
        }
    }

}