namespace M01A08a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é o seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Muito prazer em te conhecer, " + nome + "!");
            Console.ReadKey();
        }
    }
}