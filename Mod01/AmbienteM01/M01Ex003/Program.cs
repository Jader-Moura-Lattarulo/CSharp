namespace M01Ex003
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite um número Real: ");
            float.TryParse(Console.ReadLine(), out float num);
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Você digitou o valor {num:N3}");
            Console.WriteLine($"A parte inteira do número é {(int)num}");
            Console.WriteLine($"Arredondando temos o número: {Convert.ToInt16(num)}");
        }
    }
}