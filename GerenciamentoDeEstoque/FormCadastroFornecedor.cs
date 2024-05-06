using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormCadastroFornecedor: FormCadastro {

        public String Empresa => tbEmpresa.Text;

        public String Marca => tbMarca.Text;

        public FormCadastroFornecedor(Fornecedor fornecedor) {
            InitializeComponent();
            if (fornecedor != null) {
                tbEmpresa.Text = fornecedor.Empresa;
                tbMarca.Text = fornecedor.Marca;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e) {
            if (tbMarca.Text.Length < 3 || tbEmpresa.Text.Length < 3) {
                MessageBox.Show(@"Os campos 'Empresa' e 'Marca' não podem ser nulos ou ter menos que 3 letras");
                return;
            } 
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        public override void UpdateModel(Model model) {
            Fornecedor fornecedor = (Fornecedor)model;
            fornecedor.Empresa = Empresa;
            fornecedor.Marca = Marca;
        }
    }

}