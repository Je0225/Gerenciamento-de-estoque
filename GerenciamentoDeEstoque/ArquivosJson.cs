using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GerenciamentoDeEstoque {

    public static class ArquivosJson {

        private static FileStream ClientesJson { get; set; }

        private static FileStream FornecedoresJson { get; set; }

        private static FileStream ProdutosJson { get; set; }

        private static readonly String pathClientes = Environment.CurrentDirectory + "\\Clientes.json";

        private static readonly String pathFornecedores = Environment.CurrentDirectory + "\\Fornecedores.json";

        private static readonly String pathProdutos = Environment.CurrentDirectory + "\\Produtos.json";

        public static void CriaArquivos() {
            if (!File.Exists(pathFornecedores) && !File.Exists(pathClientes) && !File.Exists(pathProdutos)) {
                ClientesJson = File.Create(pathClientes);
                FornecedoresJson = File.Create(pathFornecedores);
                ProdutosJson = File.Create(pathProdutos);
            }
        }

        public static void Serializar(Object lista) {
            String listaSerializada = JsonConvert.SerializeObject(lista, Formatting.Indented);
            if (lista.GetType().ToString().Contains("Cliente")) {
                File.WriteAllText(pathClientes, listaSerializada);
            } else if (lista.GetType().ToString().Contains("Fornecedor")) {
                File.WriteAllText(pathFornecedores, listaSerializada);
            } else if (lista.GetType().ToString().Contains("Produto")) {
                File.WriteAllText(pathProdutos, listaSerializada);
            }
        }

        public static List<Cliente> DesserializarListaCliente() {
            String text;
            try {
                text = File.ReadAllText(pathClientes);
            } catch(Exception e) {
                MessageBox.Show($@"Feche todos os processos que estejam ocupando o arquivo {ClientesJson} e tente novamente", e.Message);
                throw;
            }
            List<Cliente> listaDesserializada = JsonConvert.DeserializeObject<List<Cliente>>(text);
            return listaDesserializada;
        }

        public static List<Fornecedor> DesserializarListaFornecedor() {
            String text;
            try {
                text = File.ReadAllText(pathFornecedores);
            } catch(Exception e) {
                MessageBox.Show($@"Feche todos os processos que estejam ocupando o arquivo {FornecedoresJson} e tente novamente", e.Message);
                throw;
            }
            List<Fornecedor> listaDesserializada = JsonConvert.DeserializeObject<List<Fornecedor>>(text);
            return listaDesserializada;
        }

        public static List<Produto> DesserializarListaProduto() {
            String text;
            try {
                text = File.ReadAllText(pathProdutos);
            } catch(Exception e) {
                MessageBox.Show($@"Feche todos os processos que estejam ocupando o arquivo {ProdutosJson} e tente novamente", e.Message);
                throw;
            }
            List<Produto> listaDesserializada = JsonConvert.DeserializeObject<List<Produto>>(text);
            return listaDesserializada;
        }
    }

}