using System;

namespace GerenciamentoDeEstoque {

    public class Cliente: Model {

        public String Nome { get; set; }

        public String Sobrenome { get; set; }

        public Cliente(Int32 id, String nome, String sobrenome) {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public override String[] GetValues() {
            return new[] { Nome, Sobrenome };
        }

        public new static String[] GetColumnNames() {
            return new[] { "Nome", "Sobrenome" };
        }

    }

}