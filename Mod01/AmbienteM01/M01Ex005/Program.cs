using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M01Ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Em que ano você nasceu? ");
            int ano = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Estamos atualmente no ano de {DateTime.Now.Year}");
            Console.WriteLine($"Se você nasceu em {ano}, então você tem {DateTime.Now.Year - ano} anos de idade.");
            Console.ReadKey();
        }
    }
}
