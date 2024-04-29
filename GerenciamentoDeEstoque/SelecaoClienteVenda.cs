using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class SelecaoClienteVenda: Form {

        public Cliente ClienteSelecionado { get; private set; }

        public SelecaoClienteVenda() {
            InitializeComponent();
            foreach (Cliente cliente in FilesJson.Banco.Clientes) {
                lvSelecaoCliente.Items.Add(new ListViewItem(new[] { cliente.Nome, cliente.Sobrenome }));
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            ClienteSelecionado = ProcuraClienteSelecionado();
            if (ClienteSelecionado == null) {
                MessageBox.Show(@"Selecione um ítem da lista");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public Cliente ProcuraClienteSelecionado() {
            Cliente cliente = null;
            if (lvSelecaoCliente.SelectedItems.Count > 0) {
                foreach (Cliente cli in FilesJson.Banco.Clientes) {
                    if (lvSelecaoCliente.SelectedItems[0].Text == cli.Nome) {
                        cliente = cli;
                    }
                }
            }
            return cliente;
        }
    }
}