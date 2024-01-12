using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Lendo Produto 01
            Console.Write("Produto 01: ");
            String prod1 = Console.ReadLine().Trim();//".Trim()" -> Elimina os espaços no final da digitação
            Console.Write("Preço 01: R$");
            float prç01;
            float.TryParse(Console.ReadLine().Trim(), out prç01);

            // Lendo Produto 02
            Console.Write("Produto 02: ");
            String prod2 = Console.ReadLine();
            Console.Write("Preço 02: R$");
            float prç02;
            float.TryParse(Console.ReadLine(), out prç02);

            Console.SetCursorPosition(0,8);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{"Produto", -20}{"Preço",13}");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine($"{prod1,-20}{prç01,13:C}");
            Console.WriteLine($"{prod2,-20}{prç02,13:C}");


            Console.ReadKey();
        }
    }
}
