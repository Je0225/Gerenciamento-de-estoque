using System;
using System.Security.Cryptography;

namespace GerenciamentoDeEstoque {

    public  class Produto {

        public int Id { get; set; }

        public string Descricao { get; set; }

        public Fornecedor Fornecedor { get; set; }

        public Double Valor { get; set; }

        public Int32 QuantidadeEstoque { get; set; }

        public Double DescontoMaximo {
            get {
                if (Valor >= 50) {
                    return 0.10;
                } else {
                    return 0.05;
                }
            }
        }

        public Produto(int id, string descricao, Fornecedor fornecedor, Double valor, int quantidadeEstoque) {
            Id = id;
            Descricao = descricao;
            Fornecedor = fornecedor;
            Valor = valor;
            QuantidadeEstoque = quantidadeEstoque;
        }
    }

}