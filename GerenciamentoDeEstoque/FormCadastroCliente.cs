using System;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormCadastroCliente: Form {

        public String Nome => tbNome.Text.Trim();

        public String Sobrenome => tbSobrenome.Text.Trim();

        public FormCadastroCliente(String nome, String sobrenome) {
            InitializeComponent();
            if (nome != null || sobrenome != null) {
                tbNome.Text = nome;
                tbSobrenome.Text = sobrenome;
            }
        }
         
        private void btnSalvar_Click(object sender, EventArgs e) {
            if (Nome.Length < 3 || Sobrenome.Length < 3) {
                MessageBox.Show(@"O campo 'Nome' e o campo 'Sobrenome' não podem ter menos que 3 letras");
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