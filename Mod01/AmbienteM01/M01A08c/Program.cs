namespace M01A08c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int n = Convert.ToInt32(Console.ReadLine()); //Para aceitar entrada de números inteiros.
            int d = n * 2;
            Console.WriteLine("O dobro de " + n + " é " + d);
            Console.ReadKey();
        }
    }
}