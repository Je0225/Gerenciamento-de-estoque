using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormListaProdutos: Form {

        private Int32 Id { get; set; }

        public FormListaProdutos() {
            InitializeComponent();
            Id = FilesJson.Banco.Produtos.Count > 0 ? FilesJson.Banco.Produtos.Count + 1 : 1;
            AddListViewItem();
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            FormCadastroProduto frmCadProduto = new FormCadastroProduto(null);
            frmCadProduto.ShowDialog();
            if (frmCadProduto.DialogResult != DialogResult.OK) {
                return;
            }
            Produto produto = new Produto(Id, 
                frmCadProduto.Descricao,
                frmCadProduto.Fornecedor,
                frmCadProduto.Valor,
                frmCadProduto.QtdEstoque);
            FilesJson.Banco.Produtos.Add(produto);
            Id++;
            FilesJson.Serializar();
           AddListViewItem();
           frmCadProduto.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            if (lvProdutos.SelectedItems.Count == 0) {
                return;
            }
            foreach (Produto prod in FilesJson.Banco.Produtos) {
                if (prod.Equals(lvProdutos.SelectedItems[0].Tag)) {
                    FormCadastroProduto frmCadastroProduto = new FormCadastroProduto(prod);
                    frmCadastroProduto.ShowDialog();
                    if (frmCadastroProduto.DialogResult != DialogResult.OK) {
                        return;
                    }
                    prod.Descricao = frmCadastroProduto.Descricao;
                    prod.Fornecedor = frmCadastroProduto.Fornecedor;
                    prod.Valor = frmCadastroProduto.Valor;
                    prod.QuantidadeEstoque = frmCadastroProduto.QtdEstoque;
                    FilesJson.Serializar();
                    AddListViewItem();
                    frmCadastroProduto.Dispose();
                    break;
                }
            }
        }

        private void AddListViewItem() {
            if (lvProdutos.Items.Count > 0) {
                lvProdutos.Items.Clear();
            } 
            foreach (Produto prod in FilesJson.Banco.Produtos) {
                lvProdutos.Items.Add(new ListViewItem(new[] {
                    prod.Descricao,
                    prod.Fornecedor.Empresa,
                    prod.Valor.ToString(CultureInfo.CurrentCulture),
                    prod.QuantidadeEstoque.ToString()}) {Tag = prod});
            }
        }
    }
}