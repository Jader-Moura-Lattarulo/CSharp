using System.Net.WebSockets;

namespace M01A13a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            Console.Write("Qual seu salário? ");
            float sal = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"Muito prazer em te conhecer, {nome,20}!!!");//pós qualquer var, ",números de espaços que eu quero depois"
            Console.WriteLine($"Seu salário é {sal,-50:C} por mês");
            Console.ReadKey();
            
            //Com números:
            /*
             * :C Monetário (currency)
             * :D Decimal (inteiro)
             * :N Número (real)
             * :E Científico
             * :X Hexadecimal
             */
        }
    }
}