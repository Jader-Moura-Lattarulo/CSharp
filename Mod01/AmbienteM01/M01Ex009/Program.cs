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
            Console.Write("Produto 01: ");
            String prod1 = Console.ReadLine();
            Console.Write("Preço 01: R$");
            int prç01;
            int.TryParse(Console.ReadLine(), out prç01);

            Console.Write("Produto 02: ");
            String prod2 = Console.ReadLine();
            Console.Write("Preço 02: R$");
            int prç02;
            int.TryParse(Console.ReadLine(), out prç02);

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(" Produto                    Preço ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.WriteLine($"{prod1}");


            Console.ReadKey();
        }
    }
}
