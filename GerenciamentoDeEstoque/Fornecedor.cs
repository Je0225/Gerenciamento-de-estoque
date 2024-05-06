using System;
using System.Collections.Generic;
using System.Drawing;

namespace GerenciamentoDeEstoque {

    public class Fornecedor: Model {

        public String Empresa { get; set; }

        public String Marca { get; set; }

        public Fornecedor(){}

        public Fornecedor(Int32 id, String empresa, String marca) {
            Id = id;
            Empresa = empresa;
            Marca = marca;
        }

        public override String Proxy => Empresa;

        public override String[] GetValues() {
            return new[] {Empresa, Marca };
        }

        public new static String[] GetColumnNames() {
            return new[] { "Empresa", "Marca" };
        }

    }

}