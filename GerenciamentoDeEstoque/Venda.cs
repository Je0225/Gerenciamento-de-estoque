using System;
using System.Collections.Generic;

namespace GerenciamentoDeEstoque {

    public class Venda : Model{

        public Cliente Cliente { get; set; }

        public List<KeyValuePair<Produto, Int32>> ItensDaVenda { get; set; }

        public String Modalidade { get; set; }

        public Double  PercentualDesconto { get; set; }   

        public Double ValorItens { get; set; }

        public Double TotalVenda { get; set; }

        public Venda(Int32 id, Cliente cliente, List<KeyValuePair<Produto, Int32>> itensDaVenda, String modalidade, Double percentualDesconto, Double valorItens, Double totalVenda) {
            Id = id;
            Cliente = cliente;
            ItensDaVenda = itensDaVenda;
            Modalidade = modalidade;
            PercentualDesconto = percentualDesconto;
            ValorItens = valorItens;
            TotalVenda = totalVenda;
        }

        public override String[] GetValues() {
            return new String[] { Cliente.Nome, ItensDaVenda.Count.ToString(), Modalidade, PercentualDesconto.ToString(), ValorItens.ToString("F2"), TotalVenda.ToString("F2")};
        }

        public new static String[] GetColumnNames() {
            return new[] { "Cliente", "Qtd de Itens", "Modalidade", "Desconto(%)", "Total Itens", "Total Venda" };
        }

    }

}