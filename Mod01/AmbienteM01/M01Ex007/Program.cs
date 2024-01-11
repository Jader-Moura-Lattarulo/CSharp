using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M01Ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("SORTEADOR DE NÚMERO");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
            Console.Write("Início: ");
            int start = Convert.ToInt16(Console.ReadLine());
            Console.Write("Fim: ");
            int end = Convert.ToInt16(Console.ReadLine());
            Random gerador = new Random();
            int sort = gerador.Next(start, end+1);
            Console.WriteLine("- - - - - - - - - - - - -  - - - - - -");
            Console.Write("SORTEANDO");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(1500);
            Console.Clear();
            Console.WriteLine("SORTEADOR DE NÚMERO");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - -");
            Console.WriteLine($"Início: {start:D}");
            Console.WriteLine($"Fim: {end:D}");
            Console.WriteLine("- - - - - - - - - - - - -  - - - - - -");
            Console.WriteLine($"Entre {start:D} e {end:D} sorteei o valor {sort:D}.");
            Console.ReadKey();
        }
    }
}
