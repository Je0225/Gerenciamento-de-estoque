using System;
using System.Globalization;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormCadastroProduto: Form {

        public String Descricao => tbDescricao.Text;

        public Fornecedor Fornecedor { get; private set; }

        public Double Valor => tbValor.Text.Trim().Equals("") ? 0: Convert.ToDouble(tbValor.Text);
       
        public Int32 QtdEstoque => tbQtdEstoque.Text.Trim().Equals("") ? 0 : Convert.ToInt32(tbQtdEstoque.Text);

        public FormCadastroProduto(Produto produto) {
            InitializeComponent();
            if (produto != null) {
                Fornecedor = produto.Fornecedor;

                tbDescricao.Text = produto.Descricao;
                tbFornecedor.Text = produto.Fornecedor.Empresa;
                tbValor.Text = produto.Valor.ToString(CultureInfo.CurrentCulture);
                tbQtdEstoque.Text = produto.QuantidadeEstoque.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (Descricao.Trim().Length < 3) {
                MessageBox.Show(@"O campo 'Descrição' deve conter mais que 3 letras");
                return;
            }
            if (Valor < 1 || QtdEstoque < 1 || Fornecedor == null) {
                MessageBox.Show(@"Todos os campos devem estar preenchidos");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnSelecionar_Click(object sender, EventArgs e) {
            FormSelecaoFornecedor formSelecaoFornecedor = new FormSelecaoFornecedor();
            formSelecaoFornecedor.ShowDialog();
            if (formSelecaoFornecedor.DialogResult != DialogResult.OK) {
                return;
            }
            Fornecedor = formSelecaoFornecedor.FornecedorSelecionado;
            tbFornecedor.Text = Fornecedor.Empresa;
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }

}