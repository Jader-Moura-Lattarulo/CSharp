class Program
{
    static void Main()
    {
        IniciarJogo();

        static void IniciarJogo()
        {
            int dado = RolarDado();
            Console.WriteLine("Bem vindo ao jogo de adivinhação!");
            Console.Write("O dado está sendo rolado");
            //Thread.Sleep(1000);
            Console.Write(".");
            //Thread.Sleep(1000);
            Console.Write(".");
            //Thread.Sleep(1000);
            Console.WriteLine(".");
            RolarDado();
            Console.WriteLine("Pronto, dado rolado!");
            Console.Write("Você tem 3 tentativas, qual número tirei? ");

            string palpite = Console.ReadLine();
            if  (ValidacaoPalpite(palpite, out int resposta))
            {
                
                for (int tentativa = 1; tentativa <= 3; tentativa++)
                {
                    if (resposta == dado)
                    {
                        Console.WriteLine("Parabéns, você acertou!");
                        break;
                    } 
                    else if (tentativa == 3)
                    {
                        Console.WriteLine($"Suas chances acabaram, a resposta certa era: {dado}");
                        Console.WriteLine("Tente novamente.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Sua resposta está errada, você tem mais {3 - tentativa} tentativas.");
                        palpite = Console.ReadLine();
                        ValidacaoPalpite(palpite, out resposta);
                    }
                }

                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Entrada inválida.");
            }
            Console.ReadKey();
        }
    }


    private static int RolarDado()
    {
        Random random = new Random();
        int dado = random.Next(1, 7);
        return dado;
    }

    private static bool ValidacaoPalpite(string palpite, out int resposta)
    {
        if (int.TryParse(palpite, out resposta))
        {
            if (resposta >= 1 && resposta <= 6)
            {
                return true;
            }
        }
        return false;
    }
}
             
