using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class CadastroFornecedor: Form {

        public String Empresa => tbEmpresa.Text;

        public String Marca => tbMarca.Text;

        public List<Produto> ProdutosFornecidos;

        // construtor usado para a edição do cadastro
        public CadastroFornecedor(String empresa, String marca, List<Produto> produtosFornecidos) {
            InitializeComponent();
            tbEmpresa.Text = empresa;
            tbMarca.Text = marca;
            ProdutosFornecidos = produtosFornecidos;
        }
        
        public CadastroFornecedor() {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (tbMarca.Text.Length < 3 || tbEmpresa.Text.Length < 3) {
                MessageBox.Show("Os campos 'Empresa' e 'Marca' não podem ser nulos ou ter menos que 3 letras");
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