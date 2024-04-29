using System;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormSelecaoFornecedor: Form {

        public Fornecedor FornecedorSelecionado { get; set; }

        public FormSelecaoFornecedor() {
            InitializeComponent();
            foreach (Fornecedor forn in FilesJson.Banco.Fornecedores) {
                lvFornecedores.Items.Add(new ListViewItem(new[] { forn.Empresa, forn.Marca }) { Tag = forn});
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e) {
            FornecedorSelecionado = ProcuraProdutoSelecionado();
            if (FornecedorSelecionado == null) {
                MessageBox.Show(@"Selecione um item da lista");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private Fornecedor ProcuraProdutoSelecionado() {
            Fornecedor fornecedor = null;
            if (lvFornecedores.SelectedItems.Count > 0) {
                foreach (Fornecedor forn in FilesJson.Banco.Fornecedores) {
                    if (lvFornecedores.SelectedItems[0].Tag.Equals(forn)) {
                        fornecedor = forn;
                    }
                }
            }
            return fornecedor;
        }
    }
}