using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public  partial class FormListaFornecedores: Form {

        private readonly List<Fornecedor> listaFornecedores;
        private Int32 id;
        public FormListaFornecedores() {
            InitializeComponent();
            FormPrincipal frmPrincipal = new FormPrincipal();

            foreach (Fornecedor forn in listaFornecedores) {
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
            listaFornecedores.Add(fornecedor);
            lvFornecedores.Items.Add(new ListViewItem(new[] { fornecedor.Empresa, fornecedor.Marca, fornecedor.ProdutosFornecidos.Count.ToString() }));
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection selecionado = lvFornecedores.SelectedItems;

            if (selecionado.Count == 0) {
                return;
            }
            foreach (Fornecedor forn in listaFornecedores) {
                if (forn.Empresa.Equals(selecionado[0].Text)) {
                    CadastroFornecedor cadastroFornecedor = new CadastroFornecedor(forn.Empresa, forn.Marca, forn.ProdutosFornecidos);
                    cadastroFornecedor.ShowDialog();

                    if (cadastroFornecedor.DialogResult != DialogResult.OK) {
                        return;
                    }
                    forn.Empresa = cadastroFornecedor.Empresa;
                    forn.Marca = cadastroFornecedor.Marca;

                    lvFornecedores.Items.Clear();
                    foreach (Fornecedor f in listaFornecedores) {
                        lvFornecedores.Items.Add(new ListViewItem(new[] { f.Empresa, f.Marca, f.ProdutosFornecidos.Count.ToString() }));
                    }
                    break;
                }
            }
        }

    }

}