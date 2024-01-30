class JogoAdivinhacao
{
    public void IniciarJogo()
    {
        Console.WriteLine("Bem vindo ao jogo de adivinhação!");
        Console.Write("O dado está sendo rolado");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        Console.WriteLine("Pronto, dado rolado!");

        Console.Write("Você tem 3 tentativas, qual número tirei? ");
        Console.ReadLine();

        int resposta;
        bool respostaValidada = false;

        for(int tentativa = 1; tentativa <= 3; tentativa++)
        {
            Console.WriteLine($"Tentativa {tentativa}");
            string palpite = Console.ReadLine();

            if(ValidarResposta(palpite, out resposta))
            {
                respostaValidada = true;
                break;
            }

            Console.WriteLine("Resposta inválida, digite um número inteiro entre 1 e 6.");
        }

        if(respostaValidada)
        {
            Console.WriteLine($"Você escolheu o número {resposta}");
        }
        else
        {
            Console.WriteLine("Você excedeu o número de tentativas. O jogo terminou.");
        }
    }

    private static bool ValidarResposta(string palpite, out int resposta)
    {
        return int.TryParse(palpite,out resposta) 
            && resposta >= 1
            && resposta <= 6;
    }

    private void NumeroDado()
    {
        Random random = new Random();
        int dado = random.Next(1, 7);
    }
}

class Program
{
    static void Main()
    {
        JogoAdivinhacao jogo = new JogoAdivinhacao();
        jogo.IniciarJogo();
        Console.ReadKey();
    }
}