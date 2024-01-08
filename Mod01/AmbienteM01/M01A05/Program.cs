namespace M01A05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Se optarmos por colocar var n = 0 o proprio programa definirá o tipo da variavel
             * podendo escolher por exemplo um tipo Int para o número 0, ocupando assim um espaço na memória
             * muito maior do que o necessário.
             * Ao declararmos o tipo da variável, como foi feito abaixo economizamos memória no nosso código que 
             * é de suma importância para que seja um código leve e use apenas o espaço necessário.
             */

            byte n = 255;

            Console.WriteLine("A variável n possui " + n);

            //GetType pega o tipo da variável.
            
            Console.WriteLine("n é do tipo " + n.GetType());
            Console.ReadKey();
        }
    }
}