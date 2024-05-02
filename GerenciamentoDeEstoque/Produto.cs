using System;
using System.Security.Cryptography;

namespace GerenciamentoDeEstoque {

    public  class Produto: Model {

        public string Descricao { get; set; }

        public Fornecedor Fornecedor { get; set; }

        public Double Valor { get; set; }

        public Int32 QuantidadeEstoque { get; set; }

        public Produto(int id, string descricao, Fornecedor fornecedor, Double valor, int quantidadeEstoque) {
            Id = id;
            Descricao = descricao;
            Fornecedor = fornecedor;
            Valor = valor;
            QuantidadeEstoque = quantidadeEstoque;
        }

        public override String[] GetValues() {
            return new[] { Descricao, Fornecedor.Empresa, Valor.ToString("F2"), QuantidadeEstoque.ToString("D")};
        }

        public new static String[] GetColumnNames() {
            return new[] { "Descricao", "Fornecedor", "Valor", "Estoque"};
        }

    }

}