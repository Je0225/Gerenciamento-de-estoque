using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormListagemVendas: Form {

        private String Filtro => cbFiltro.SelectedItem.ToString();

        private Cliente Clienteselecionado { get; set; }

        private Produto ProdutoSelecionado { get; set; }

        public FormListagemVendas() {
            InitializeComponent();
            cbFiltro.Items.Add("Por cliente");
            cbFiltro.Items.Add("Por produto");
        }

        private void btnSelecionar_Click(object sender, EventArgs e) {
            if (cbFiltro.SelectedItem == null) {
                MessageBox.Show("Selecione um filtro do comboBox");
                return;
            }
            if (Filtro == cbFiltro.Items[0]) {
                FormSelecao<Cliente> formSelecao = new FormSelecao<Cliente>(FilesJson.Banco.Clientes, Cliente.GetColumnNames());
                formSelecao.ShowDialog();
                if (formSelecao.DialogResult != DialogResult.OK) {
                    return;
                }
                Clienteselecionado = formSelecao.Selecionado;
                tbNomeFiltro.Text = Clienteselecionado.GetValues()[0];
                formSelecao.Dispose();
            }
            if (Filtro == cbFiltro.Items[1]) {
                FormSelecao<Produto> formSelecao = new FormSelecao<Produto>(FilesJson.Banco.Produtos, Cliente.GetColumnNames());
                formSelecao.ShowDialog();
                if (formSelecao.DialogResult != DialogResult.OK) {
                    return;
                }
                ProdutoSelecionado = formSelecao.Selecionado;
                tbNomeFiltro.Text = ProdutoSelecionado.GetValues()[0];
                formSelecao.Dispose();
            }
        }

        private void btnListar_Click(object sender, EventArgs e) {
            lvVendas.Items.Clear();
            if (ProdutoSelecionado == null && Clienteselecionado == null) {
                MessageBox.Show("Selecione algum filtro para listar");
                return;
            }
            if (Filtro == cbFiltro.Items[0]) {
                foreach (Venda venda in FilesJson.Banco.Vendas.Where(v => v.Cliente.Id.Equals(Clienteselecionado.Id))) {
                    lvVendas.Items.Add(new ListViewItem(new[] {
                        venda.Cliente.Nome,
                        venda.PercentualDesconto.ToString(),
                        venda.ItensDaVenda.Count.ToString(),
                        venda.ValorItens.ToString("F2"),
                        venda.TotalVenda.ToString("F2")
                    }));
                }
            }
            if (Filtro == cbFiltro.Items[1]) {
                foreach (Venda venda in FilesJson.Banco.Vendas) {
                    foreach (KeyValuePair<Produto, Int32> kvp in venda.ItensDaVenda.Where(k => k.Key.Id.Equals(ProdutoSelecionado .Id))) {
                        lvVendas.Items.Add(new ListViewItem(new[] {
                            venda.Cliente.Nome,
                            venda.PercentualDesconto.ToString("P"),
                            venda.ItensDaVenda.Count.ToString("D"),
                            venda.ValorItens.ToString("F2"),
                            venda.TotalVenda.ToString("F2")
                        }));
                    }
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Retry;
            Close();
        }

        private void cbFiltro_SelectedIndexChanged(object sender, EventArgs e) {
            Clienteselecionado = null;
            ProdutoSelecionado = null;
            tbNomeFiltro.Text = null;
        }
    }

}