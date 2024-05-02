using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormSelecao<T>: Form where T: Model {

        public T Selecionado { get; private set; }

        private List<T> Lista { get; }

        public FormSelecao(List<T> lista, String[] columns) {
            InitializeComponent();
            Lista = lista;
            for (Int32 i = 0; i < columns.Length; i++) {
                ListView.Columns.Add(new ColumnHeader { DisplayIndex = i, Text = columns[i] });
            }
            foreach (T item in lista) {
                ListView.Items.Add(new ListViewItem(item.GetValues()) {Tag = item});
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (ListView.SelectedItems.Count > 0) {
                foreach (T item in Lista) {
                    if (ListView.SelectedItems[0].Tag.Equals(item)) {
                        Selecionado = item;
                    }
                }
            }
            if (Selecionado == null) {
                MessageBox.Show(@"Selecione um item da lista");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
    }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }

}