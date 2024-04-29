using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormSelecaoProdutoVenda: Form {

        public Produto ProdutoSelecionado { get; private set; }

        public FormSelecaoProdutoVenda() {
            InitializeComponent();
            foreach (Produto prod in FilesJson.Banco.Produtos) {
                lvSelecaoProdutos.Items.Add(new ListViewItem(new[] {
                    prod.Id.ToString(),
                    prod.Descricao,
                    prod.Valor.ToString("F2"),
                    prod.QuantidadeEstoque.ToString(),
                    prod.Fornecedor.Empresa
                }));
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            ProdutoSelecionado = ProcuraProdutoSelecionado();
            if (ProdutoSelecionado == null) {
                MessageBox.Show(@"Selecione algum ítem da lista");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private Produto ProcuraProdutoSelecionado() {
            Produto produtos = null;
            if (lvSelecaoProdutos.SelectedItems.Count > 0) {
                foreach (Produto prod in FilesJson.Banco.Produtos) {
                    if (lvSelecaoProdutos.SelectedItems[0].Text.Equals(prod.Id.ToString())) {
                        produtos = prod;
                    }
                }
            }
            return produtos;
        }

    }

}