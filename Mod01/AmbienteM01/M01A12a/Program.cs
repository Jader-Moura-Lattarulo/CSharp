using System.Data;

namespace M01A12a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}! Tudo bem?");

            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;

            Console.WriteLine($"Hoje é {dia} do mês {mes} do ano de {ano}");

            float sal = 0;
            Console.Write("Qual é seu salário? ");
            float.TryParse(Console.ReadLine(), out sal);
            Console.WriteLine($"Você ganha {sal:C} por mês!");

            Console.ReadKey();
        }
    }
}