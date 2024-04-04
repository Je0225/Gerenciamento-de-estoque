using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormLista: Form {
        private List<Cliente> Clientes {get; set; }
        private Int32 id;

        public FormLista() {
            InitializeComponent();

            Clientes = ArquivosJson.DesserializarListaCliente();
            if (Clientes == null) {
                Clientes = new List<Cliente>();
                return;
            }
            id = Clientes[Clientes.Count - 1].Id;
            foreach (Cliente cliente in Clientes) {
                lvClientes.Items.Add(new ListViewItem(new[] { cliente.Nome, cliente.Sobrenome }));
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            FormCadastroCliente frmCadCliente = new FormCadastroCliente();
            frmCadCliente.ShowDialog();

            if (frmCadCliente.DialogResult != DialogResult.OK) {
                return;
            }
            id++;
            Cliente cliente = new Cliente(id, frmCadCliente.Nome, frmCadCliente.Sobrenome);
            Clientes.Add(cliente);
            ArquivosJson.Serializar(Clientes);
            lvClientes.Items.Add(new ListViewItem(new[] {cliente.Nome, cliente.Sobrenome }));
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection selecionado = lvClientes.SelectedItems;
            if (selecionado.Count.Equals(0)) {
                return;
            }
            foreach (Cliente cliente in Clientes) {
                if (cliente.Nome.ToString().Equals(selecionado[0].Text)) {
                    FormCadastroCliente frmCadCliente = new FormCadastroCliente(cliente.Nome, cliente.Sobrenome);
                    frmCadCliente.ShowDialog();

                    if (frmCadCliente.DialogResult != DialogResult.OK) {
                        return;
                    }
                    cliente.Nome = frmCadCliente.Nome;
                    cliente.Sobrenome = frmCadCliente.Sobrenome;
                    ArquivosJson.Serializar(Clientes);
                    break;
                }
            }
            Clientes = ArquivosJson.DesserializarListaCliente();
            lvClientes.Items.Clear();
            foreach (Cliente cli in Clientes) {
              lvClientes.Items.Add(new ListViewItem(new[] {cli.Nome, cli.Sobrenome }));
            }
        }
    }

}