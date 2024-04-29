using System;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormPrincipal: Form {

        public FormPrincipal() {
            InitializeComponent();
            FilesJson.CriaArquivosEListas();
        }

        private void tsmiClientes_Click(object sender, EventArgs e) {
            FormLista formListaClientes = new FormLista();
            formListaClientes.ShowDialog(this);
            formListaClientes.Dispose();
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
    }

}