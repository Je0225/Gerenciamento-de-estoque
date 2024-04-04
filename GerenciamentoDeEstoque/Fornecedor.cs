using System;
using System.Collections.Generic;

namespace GerenciamentoDeEstoque {

    public class Fornecedor {

        public Int32 Id { get; set; }

        public String Empresa { get; set; }

        public String Marca { get; set; }

        public List<Produto> ProdutosFornecidos { get; set; }

        public Fornecedor(Int32 id, String empresa, String marca) {
            Id = id;
            Empresa = empresa;
            Marca = marca;
            ProdutosFornecidos = new List<Produto>();
        }

    }

}