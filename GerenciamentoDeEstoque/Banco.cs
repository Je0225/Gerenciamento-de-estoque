using System;
using System.Collections.Generic;

namespace GerenciamentoDeEstoque {

    public class Banco {

        public List<Cliente> Clientes { get; set; }

        public List<Produto> Produtos { get; set; }

        public List<Fornecedor> Fornecedores { get; set; }

        public List<Venda> Vendas { get; set; }

        public  List<String> ModalidadesPagamento { get; set; }

        public Banco() {
            Clientes = new List<Cliente>();
            Produtos = new List<Produto>();
            Fornecedores = new List<Fornecedor>();
            Vendas = new List<Venda>();
            ModalidadesPagamento = new List<String>();
        }
    }

}