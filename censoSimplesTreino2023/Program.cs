using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace censoSimplesTreino2023
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        public static void ApenasTexto(KeyPressEventArgs e)
        {
            // Impedindo que o usuário digite números.
            // Se o caractere digitado for um número não será permitido.
            if (char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
         }
        public static void ApenasNumero(KeyPressEventArgs e)
        {
            //Impedindo que o usuário digite letras.
            //Se o caractere digitado for letra não será permitido.
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
          
            
        }
    }
}
