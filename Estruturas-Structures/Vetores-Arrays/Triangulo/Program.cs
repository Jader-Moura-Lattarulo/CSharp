using System.Threading.Channels;

class Program
{
    
    static void Main()
    {
        Triangulo triangulo = new Triangulo();

        Console.WriteLine("Qual será a base do seu triângulo?");
        double baseTriangulo = triangulo.RespostaValidada();
        Console.WriteLine("Qual será a altura do seu triângulo? ");
        double alturaTriangulo = triangulo.RespostaValidada();

        Console.WriteLine();

        triangulo.DefinirBaseAltura(baseTriangulo, alturaTriangulo);

        Console.WriteLine($"{triangulo.Resposta()}");

        Console.ReadKey();
    }
}

public class Triangulo
{
    private double _base;
    private double _altura;

    public void DefinirBaseAltura(double @base, double altura)
    {
        _base = @base;
        _altura = altura;
    }

    public double CalcularArea() => ((double)_base * _altura) / 2;
    

    public string Resposta()
    {
        return $"O resultado é {CalcularArea()}";
    }

    public double RespostaValidada()
    {
        double numero;

        while (true)
        {
            Console.Write("Digite um número: ");

            if (double.TryParse(Console.ReadLine(), out numero))
            {
                return numero;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número.");
            }
        }
    }
}