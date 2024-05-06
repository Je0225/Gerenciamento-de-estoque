using System;
using System.IO;
using Newtonsoft.Json;

namespace GerenciamentoDeEstoque {

    public static class Repository {

        public static Banco Banco { get; private set; }

        private static readonly String pathBanco = Environment.CurrentDirectory + "\\Banco.json";

        public static void CriaArquivosEListas() {
            if (File.Exists(pathBanco)) {
                DesserializaBanco();
            } else {
                Banco = new Banco();
                Banco.ModalidadesPagamento.Add("A Vista - Dinheiro");
                Banco.ModalidadesPagamento.Add("Parcelado");
                Banco.ModalidadesPagamento.Add("Cartão de Débito");
                Banco.ModalidadesPagamento.Add("Cartão de Crédito");
                Banco.ModalidadesPagamento.Add("Pix");
            }
        }

        public static void Save() {
            String bancoSerializado = JsonConvert.SerializeObject(Banco, Formatting.Indented);
            File.WriteAllText(pathBanco, bancoSerializado);
            DesserializaBanco();
        }

        private static void DesserializaBanco() {
            String text = File.ReadAllText(pathBanco);
            Banco = JsonConvert.DeserializeObject<Banco>(text) ?? new Banco();
        }
    }

}