using System;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormListaFornecedores: Form {

        private Int32 Id { get; set; }

        public FormListaFornecedores() {
            InitializeComponent();
            Id = FilesJson.Banco.Fornecedores.Count > 0 ? FilesJson.Banco.Fornecedores.Count : 1;
            AddItendListView();
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            CadastroFornecedor cadastroFornecedor = new CadastroFornecedor(null, null);
            cadastroFornecedor.ShowDialog();
            if (cadastroFornecedor.DialogResult != DialogResult.OK) {
                return;
            }
            Fornecedor fornecedor = new Fornecedor(Id, cadastroFornecedor.Empresa, cadastroFornecedor.Marca);
            Id++;
            FilesJson.Banco.Fornecedores.Add(fornecedor);
            FilesJson.Serializar();
            AddItendListView();
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection selecionado = lvFornecedores.SelectedItems;
            if (selecionado.Count == 0) {
                return;
            }
            foreach (Fornecedor forn in FilesJson.Banco.Fornecedores) {
                if (forn.Equals(selecionado[0].Tag)) {
                    CadastroFornecedor cadastroFornecedor = new CadastroFornecedor(forn.Empresa, forn.Marca);
                    cadastroFornecedor.ShowDialog();

                    if (cadastroFornecedor.DialogResult != DialogResult.OK) {
                        return;
                    }
                    forn.Empresa = cadastroFornecedor.Empresa;
                    forn.Marca = cadastroFornecedor.Marca;
                    FilesJson.Serializar();
                    AddItendListView();
                    break;
                }
            }
        }

        private void AddItendListView() {
            if (lvFornecedores.Items.Count > 0) {
                lvFornecedores.Items.Clear();
            }
            foreach (Fornecedor forn in FilesJson.Banco.Fornecedores) {
                lvFornecedores.Items.Add(new ListViewItem(new[] { forn.Empresa, forn.Marca }) {Tag = forn});
            }
        }

    }

}