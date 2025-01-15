using System;
using System.Collections.Generic;
using System.Text;

namespace NortonBank.CLI
{
    internal class Utilitarios
    {
        public static void MostrarIntroducao(string mensagem)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("================================");
            Console.WriteLine($"===== {mensagem} =====");
            Console.WriteLine("================================");

            Console.ResetColor();
        }
    }
}
