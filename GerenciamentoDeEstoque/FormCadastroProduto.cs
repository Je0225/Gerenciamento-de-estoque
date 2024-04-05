using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormCadastroProduto: Form {

        public String Descricao => tbDescricao.Text;

        public Fornecedor Fornecedor { get; set; }

        public float Valor { get; set; }

        public Int32 QtdEstoque { get; set; }

        public FormCadastroProduto() {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {

        }

        private void btnSalvar_Click(object sender, EventArgs e) {

        }

        private void btnSelecionar_Click(object sender, EventArgs e) {
            FormSelecaoFornecedor formSelecaoFornecedor = new FormSelecaoFornecedor();
            if (formSelecaoFornecedor.DialogResult != DialogResult.OK) {
                return;
            }
            List<Fornecedor> Fornecedores = ArquivosJson.DesserializarListaFornecedor();
            foreach (Fornecedor forn in Fornecedores) {
                if (forn.Empresa == formSelecaoFornecedor.Selecionado.ToString()) {
                    Fornecedor = forn;
                    tbFornecedor.Text = forn.Empresa;
                    return;
                }
            }
        }

    }

}