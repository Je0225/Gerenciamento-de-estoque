using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciamentoDeEstoque
{
    public static class Registro {

        private static Dictionary<String, Type> registros = new Dictionary<String, Type>();

        public static void Add(String name, Type type) {
            registros.Add(name, type);
        }

        public static Type GetRegistro(String name) {
            Type registro = null; 
            registros.TryGetValue(name, out registro);
            return registro;
        }

    }
}
