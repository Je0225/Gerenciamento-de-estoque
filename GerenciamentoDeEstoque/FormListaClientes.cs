using System;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormListaClientes: Form {

        private Int32 Id { get; set; }

        public FormListaClientes() {
            InitializeComponent();
            Id = FilesJson.Banco.Clientes.Count > 0? FilesJson.Banco.Clientes.Count: 1;
            AddItemsListView(); 
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            FormCadastroCliente frmCadCliente = new FormCadastroCliente(null, null);
            frmCadCliente.ShowDialog();

            if (frmCadCliente.DialogResult != DialogResult.OK) {
                return;
            }
            Cliente cliente = new Cliente(Id, frmCadCliente.Nome, frmCadCliente.Sobrenome);
            FilesJson.Banco.Clientes.Add(cliente);
            Id++;
            FilesJson.Serializar();
            AddItemsListView();
            frmCadCliente.Dispose();
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            ListView.SelectedListViewItemCollection selecionado = lvClientes.SelectedItems;
            if (selecionado.Count.Equals(0)) {
                return;
            }
            foreach (Cliente cliente in FilesJson.Banco.Clientes) {
                if (cliente.Equals(selecionado[0].Tag)) {
                    FormCadastroCliente frmCadCliente = new FormCadastroCliente(cliente.Nome, cliente.Sobrenome);
                    frmCadCliente.ShowDialog();
                    if (frmCadCliente.DialogResult != DialogResult.OK) {
                        return;
                    }
                    cliente.Nome = frmCadCliente.Nome;
                    cliente.Sobrenome = frmCadCliente.Sobrenome;
                    FilesJson.Serializar();
                    AddItemsListView();
                    break;
                }
            }
        }

        private void AddItemsListView() {
            if (lvClientes.Items.Count > 0) {
                lvClientes.Items.Clear();
            }
            foreach (Cliente cliente in FilesJson.Banco.Clientes) {
                lvClientes.Items.Add(new ListViewItem(new[] { cliente.Nome, cliente.Sobrenome }) { Tag = cliente});
            }
        }
    }

}