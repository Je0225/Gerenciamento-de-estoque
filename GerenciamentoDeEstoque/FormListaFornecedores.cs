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
            FormCadastroFornecedor formCadastroFornecedor = new FormCadastroFornecedor(null, null);
            formCadastroFornecedor.ShowDialog();
            if (formCadastroFornecedor.DialogResult != DialogResult.OK) {
                return;
            }
            Fornecedor fornecedor = new Fornecedor(Id, formCadastroFornecedor.Empresa, formCadastroFornecedor.Marca);
            FilesJson.Banco.Fornecedores.Add(fornecedor);
            Id++;
            FilesJson.Serializar();
            AddItendListView();
            formCadastroFornecedor.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection selecionado = lvFornecedores.SelectedItems;
            if (selecionado.Count == 0) {
                return;
            }
            foreach (Fornecedor forn in FilesJson.Banco.Fornecedores) {
                if (forn.Equals(selecionado[0].Tag)) {
                    FormCadastroFornecedor formCadastroFornecedor = new FormCadastroFornecedor(forn.Empresa, forn.Marca);
                    formCadastroFornecedor.ShowDialog();

                    if (formCadastroFornecedor.DialogResult != DialogResult.OK) {
                        return;
                    }
                    forn.Empresa = formCadastroFornecedor.Empresa;
                    forn.Marca = formCadastroFornecedor.Marca;
                    FilesJson.Serializar();
                    AddItendListView();
                    formCadastroFornecedor.Dispose();
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