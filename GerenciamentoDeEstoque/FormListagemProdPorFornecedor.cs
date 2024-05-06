using System;
using System.Linq;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormListagemProdPorFornecedor: Form {

        private Fornecedor fornecedor { get; set; }

        public FormListagemProdPorFornecedor() {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e) {
            FormSelecao<Fornecedor> FormSelecao = new FormSelecao<Fornecedor>(Repository.Banco.Fornecedores, Fornecedor.GetColumnNames());
            FormSelecao.ShowDialog();
            if (FormSelecao.DialogResult != DialogResult.OK) {
                return;
            }
            fornecedor = FormSelecao.SelecionadoCast;
            tbFornecedor.Text = fornecedor.Empresa;
            FormSelecao.Dispose();
        }

        private void btnListar_Click(object sender, EventArgs e) {
            lvListagem.Items.Clear();
            if (fornecedor == null) {
                MessageBox.Show("Selecione um fornecedor");
                return;
            }
            foreach (Produto prod in Repository.Banco.Produtos.Where(p => p.Fornecedor.Id.Equals(fornecedor.Id))) {
                lvListagem.Items.Add(new ListViewItem(new[] { prod.Fornecedor.Empresa, prod.Fornecedor.Marca, prod.Descricao, prod.QuantidadeEstoque.ToString("D"), prod.Valor.ToString("F2") }) { Tag = prod });
            }
        }

        private void btnSair_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.None;
            Close();
        }

    }

}