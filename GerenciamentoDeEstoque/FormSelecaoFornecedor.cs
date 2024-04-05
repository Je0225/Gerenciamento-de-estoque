using System;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormSelecaoFornecedor: Form {

        public ListView.SelectedListViewItemCollection Selecionado => lvFornecedores.SelectedItems;

        public FormSelecaoFornecedor() {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            if (Selecionado.Count > 0) {
                MessageBox.Show($@"Selecione um item da lista antes de salvar");
                return;
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }

}