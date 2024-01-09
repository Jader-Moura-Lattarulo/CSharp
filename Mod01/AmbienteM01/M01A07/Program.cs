namespace M01A07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversão implícita - Não dá trabalho nenhum:
            int a = 7; float b = a;
            Console.WriteLine("O valor de a é " + a + " do tipo " + a.GetType());
            Console.WriteLine("O valor de a é " + b + " do tipo " + b.GetType());
            //Existe uma conversão implícita de int para float

            /*
             * float a = 8; int b = a;
             * Console.WriteLine("O valor de a é " + a + " do tipo " + a.GetType());
             * Console.WriteLine("O valor de a é " + b + " do tipo " + b.GetType());
             * Ao tentar fazer float para int dá erro, ou seja, um número inteiro cabe dentro de um float,
             * mas um float não cabe dentro de um inteiro.
             */

            //Conversão explícita (typecast)

            float c = 8.95f; 
            int d = (int)c; //Por casting ele literalmente ira cortar o número e pegar a parte inteira
            Console.WriteLine("O valor de a é " + c + " do tipo " + c.GetType());
            Console.WriteLine("O valor de a é " + d + " do tipo " + d.GetType());

            //Conversão por classes auxiliares
            float e = 8.25f; float f = 8.9999f;
            int g = Convert.ToInt16(e); int h = Convert.ToInt16(f);
            Console.WriteLine("O valor de e é: " + e + " e o valor de f é: " + f + "\nUsando o comando Convert.ToInt16() os valores ficam respectivamente:");
            Console.WriteLine(g + " e " + h);
            //A conversão por classes traz um arredondamento para o valor float e não apenas corta como seria feito no casting.

        }
    }
}