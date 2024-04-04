using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public partial class FormPrincipal: Form {

        public FormPrincipal() {
            InitializeComponent();
            ArquivosJson.CriaArquivos();
        }

        public bool SerializacaoJson(object objeto, String path) {
            
            return true;
        }

        private void tsmiClientes_Click(object sender, EventArgs e) {
            FormLista formLista = new FormLista();
            formLista.ShowDialog(this);
            formLista.Dispose();
        }

        private void tsmiFornecedores_Click(object sender, EventArgs e) {
            FormListaFornecedores formListaFornecedores = new FormListaFornecedores();
            formListaFornecedores.ShowDialog(this);
            formListaFornecedores.Dispose();
        }

    }

}