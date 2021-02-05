using System;
using System.Windows.Forms;

namespace TabelaJuros {
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {           
            Application.Run(new FrmMain());
        }
    }
}
