namespace M01A09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random (classe) gerador (objeto) new (instanciador) Random() (chamada método construtor)
            Random gerador = new Random();
            int n = gerador.Next(100); 
            Console.WriteLine("Acabei de gerar o número: " + n);
        }
    }
}