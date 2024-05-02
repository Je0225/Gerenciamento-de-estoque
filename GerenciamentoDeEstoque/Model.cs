using System;

namespace GerenciamentoDeEstoque {

    public abstract class Model {

        public Int32 Id { get; set; }

        public abstract String[] GetValues();

        public static String[] GetColumnNames() {
            return new[] { "Id" };
        }
    }

}