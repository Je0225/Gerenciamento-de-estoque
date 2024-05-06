using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GerenciamentoDeEstoque
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try {
                Repository.CriaArquivosEListas();
            } catch(Exception e) {
                MessageBox.Show($"{e.Message} \n Feche todos os processos que estejam ocupando o arquivo no diretório especificado e tente novamente", @"Erro na leitura dos dados");
                Environment.Exit(0);
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormPrincipal());
        }
    }
}
