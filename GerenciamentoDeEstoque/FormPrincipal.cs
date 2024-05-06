using System;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormPrincipal: Form {

        public FormPrincipal() {
            InitializeComponent();
            Registro.Add(nameof(Fornecedor) , typeof(FormCadastroFornecedor));
            Registro.Add(nameof(Cliente), typeof(FormCadastroCliente));
            Registro.Add(nameof(Produto), typeof(FormCadastroProduto));
            Repository.CriaArquivosEListas();
        }

        private void tsmiClientes_Click(object sender, EventArgs e) {
            FormLista<Cliente> frmClientes = new FormLista<Cliente>(Repository.Banco.Clientes, Cliente.GetColumnNames());
            frmClientes.ShowDialog();
            frmClientes.Dispose();
        }

        private void tsmiFornecedores_Click(object sender, EventArgs e) {
            FormLista<Fornecedor> frmFornecedor = new FormLista<Fornecedor>(Repository.Banco.Fornecedores, Fornecedor.GetColumnNames());
            frmFornecedor.ShowDialog(this);
            frmFornecedor.Dispose();
        }

        private void cadastroDeProdutoToolStripMenuItem_Click(object sender, EventArgs e) {
            FormLista<Produto> frmProduto = new FormLista<Produto>(Repository.Banco.Produtos, Produto.GetColumnNames());
            frmProduto.ShowDialog(this);
            frmProduto.Dispose();
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
            formListagemVendas.Dispose();
        }
    }

}