using System;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormPrincipal: Form {

        public FormPrincipal() {
            InitializeComponent();
            FilesJson.CriaArquivosEListas();
        }

        private void tsmiClientes_Click(object sender, EventArgs e) {
            FormListaClientes formListaClientesClientes = new FormListaClientes();
            formListaClientesClientes.ShowDialog(this);
            formListaClientesClientes.Dispose();
        }

        private void tsmiFornecedores_Click(object sender, EventArgs e) {
            FormListaFornecedores formListaFornecedores = new FormListaFornecedores();
            formListaFornecedores.ShowDialog(this);
            formListaFornecedores.Dispose();
        }

        private void cadastroDeProdutoToolStripMenuItem_Click(object sender, EventArgs e) {
            FormListaProdutos formListaProdutos = new FormListaProdutos();
            formListaProdutos.ShowDialog(this);
            formListaProdutos.Dispose();
        }

        private void realizarVendaToolStripMenuItem_Click(object sender, EventArgs e) {
            FormRealizaVenda frmRealizaVenda = new FormRealizaVenda();
            frmRealizaVenda.ShowDialog(this);
            frmRealizaVenda.Dispose();
        }

        private void produtosPorFornecedorToolStripMenuItem_Click(object sender, EventArgs e) {
            FormListagemProdPorFornecedor formListProdPorFornecedor = new FormListagemProdPorFornecedor();
            formListProdPorFornecedor.ShowDialog(this);
            formListProdPorFornecedor.Dispose();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e) {
            FormListagemVendas formListagemVendas = new FormListagemVendas();
            formListagemVendas.ShowDialog();
        }
    }

}