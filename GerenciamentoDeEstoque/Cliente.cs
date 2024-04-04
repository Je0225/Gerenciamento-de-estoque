using System;

namespace GerenciamentoDeEstoque {

    public class Cliente {

        public Int32 Id { get; set; }

        public String Nome { get; set; }

        public String Sobrenome { get; set; }

        public Cliente(Int32 id, String nome, String sobrenome) {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
        }

    }

}