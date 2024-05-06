using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormListagemVendas: Form {

        private String Filtro => cbFiltro.SelectedItem.ToString();

        private Model Selecionado { get; set; }

        public FormListagemVendas() {
            InitializeComponent();
            cbFiltro.Items.Add("Por cliente");
            cbFiltro.Items.Add("Por produto");

            foreach (String coluna in Venda.GetColumnNames()) {
                lvVendas.Columns.Add(coluna);
            }
        }

        private void btnSelecionar_Click(object sender, EventArgs e) {
            if (cbFiltro.SelectedItem == null) {
                MessageBox.Show(@"Selecione um filtro do comboBox");
                return;
            }

            Form frmSelecao = null;
            if (Filtro.Equals(cbFiltro.Items[0])) {
                frmSelecao = new FormSelecao<Cliente>(Repository.Banco.Clientes, Cliente.GetColumnNames());
            } else {
                frmSelecao = new FormSelecao<Produto>(Repository.Banco.Produtos, Produto.GetColumnNames());
            }
            if (frmSelecao.ShowDialog() != DialogResult.OK) {
                return;
            }
            Selecionado = ((ISelecionavel)frmSelecao).Selecionado;
            tbNomeFiltro.Text = Selecionado.Proxy;
            frmSelecao.Dispose();
        }

        private void btnListar_Click(object sender, EventArgs e) {
            lvVendas.Items.Clear();
            if (Selecionado == null) {
                MessageBox.Show(@"Selecione algum filtro para listar");
                return;
            }
            if (Filtro == cbFiltro.Items[0]) {
                foreach (Venda venda in Repository.Banco.Vendas.Where(v => v.Cliente.Id.Equals(Selecionado.Id))) {
                    lvVendas.Items.Add(new ListViewItem(venda.GetValues()));
                }
            }
            if (Filtro == cbFiltro.Items[1]) {
                foreach (Venda venda in Repository.Banco.Vendas) {
                    foreach (KeyValuePair<Produto, Int32> kvp in venda.ItensDaVenda.Where(k => k.Key.Id.Equals(Selecionado.Id))) {
                        lvVendas.Items.Add(new ListViewItem(kvp.Key.GetValues()));
                    }
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Retry;
            Close();
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e) {
            Selecionado = null;
            tbNomeFiltro.Text = null;
        }

    }

}