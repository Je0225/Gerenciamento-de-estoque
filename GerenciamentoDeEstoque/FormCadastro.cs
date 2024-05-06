using System;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque {

    public class FormCadastro: Form {

        public virtual void UpdateModel(Model model) {
            throw new NotImplementedException($"Faça a implementação do método UpdateModel na classe {this.GetType().FullName}");
        }
            
    }

}