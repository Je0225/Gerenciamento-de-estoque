using System;
using System.Globalization;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormCadastroProduto: FormCadastro {

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
            FormSelecao<Fornecedor> frmSelecao = new FormSelecao<Fornecedor>(Repository.Banco.Fornecedores, Fornecedor.GetColumnNames());
            frmSelecao.ShowDialog();
            if (frmSelecao.DialogResult != DialogResult.OK) {
                return;
            }
            Fornecedor = frmSelecao.SelecionadoCast;
            tbFornecedor.Text = Fornecedor.Empresa;
            frmSelecao.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public override void UpdateModel(Model model) {
            Produto produto = (Produto)model;
            produto.Fornecedor = Fornecedor;
            produto.Descricao = Descricao;
            produto.Valor = Valor;
            produto.QuantidadeEstoque = QtdEstoque;
        }
    }

}