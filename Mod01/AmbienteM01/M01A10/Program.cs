namespace M01A10
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;

            Console.Write("Hoje é dia ");
            Thread.Sleep(1000);
            Console.Write(dia);
            Thread.Sleep(1000);
            Console.Write(" do mês ");
            Thread.Sleep(1000);
            Console.Write(mes);
            Thread.Sleep(1000);
            Console.Write(" do ano ");
            Thread.Sleep(1000);
            Console.Write(ano);
            Thread.Sleep(4000);
        }
    }
}