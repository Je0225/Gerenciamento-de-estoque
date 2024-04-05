using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormListaFornecedores: Form {

        private List<Fornecedor> Fornecedores;
        private Int32 id;

        public FormListaFornecedores() {
            InitializeComponent();

            Fornecedores = ArquivosJson.DesserializarListaFornecedor();
            if (Fornecedores == null) {
                Fornecedores = new List<Fornecedor>();
                return;
            }
            id = Fornecedores.Count - 1;
            foreach (Fornecedor forn in Fornecedores) {
                lvFornecedores.Items.Add(new ListViewItem(new[] { forn.Empresa, forn.Marca, forn.ProdutosFornecidos.Count.ToString() }));
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            CadastroFornecedor cadastroFornecedor = new CadastroFornecedor();
            cadastroFornecedor.ShowDialog();
            if (cadastroFornecedor.DialogResult != DialogResult.OK) {
                return;
            }
            id++;
            Fornecedor fornecedor = new Fornecedor(id, cadastroFornecedor.Empresa, cadastroFornecedor.Marca);
            Fornecedores.Add(fornecedor);
            ArquivosJson.Serializar(Fornecedores);
            lvFornecedores.Items.Add(new ListViewItem(new[] { fornecedor.Empresa, fornecedor.Marca, fornecedor.ProdutosFornecidos.Count.ToString() }));
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection selecionado = lvFornecedores.SelectedItems;
            if (selecionado.Count == 0) {
                return;
            }
            foreach (Fornecedor forn in Fornecedores) {
                if (forn.Empresa.Equals(selecionado[0].Text)) {
                    CadastroFornecedor cadastroFornecedor = new CadastroFornecedor(forn.Empresa, forn.Marca, forn.ProdutosFornecidos);
                    cadastroFornecedor.ShowDialog();

                    if (cadastroFornecedor.DialogResult != DialogResult.OK) {
                        return;
                    }
                    forn.Empresa = cadastroFornecedor.Empresa;
                    forn.Marca = cadastroFornecedor.Marca;
                    ArquivosJson.Serializar(Fornecedores);
                    break;
                }
            }
            Fornecedores = ArquivosJson.DesserializarListaFornecedor();
            lvFornecedores.Items.Clear();
            foreach (Fornecedor f in Fornecedores) {
                lvFornecedores.Items.Add(new ListViewItem(new[] { f.Empresa, f.Marca, f.ProdutosFornecidos.Count.ToString() }));
            }
        }

    }

}