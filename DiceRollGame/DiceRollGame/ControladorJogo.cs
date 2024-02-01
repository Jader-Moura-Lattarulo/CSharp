using DiceRollGame;
internal class ControladorJogo
{
    private int dado;
    private Jogador jogador;
    private ValidacaoEntradaJogador validacaoEntradaJogador;

    public ControladorJogo()
    {
        dado = Dado.RolarDado();
        jogador = new Jogador();
        validacaoEntradaJogador = new ValidacaoEntradaJogador();
    }

    public void IniciarJogo()
    {
        Console.Write("O dado está sendo rolado");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.Write(".");
        Thread.Sleep(1000);
        Console.WriteLine(".");
        Dado.RolarDado();
        Console.WriteLine("Pronto, dado rolado!");
        Console.Write($"Você tem 3 tentativas, qual número tirei? ");

        for (int tentativa = 1; tentativa <= 3; tentativa++)
        {
            int palpite = jogador.FazerPalpite();

            if (palpite == dado)
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
                Console.Write($"Qual seu novo palpite? ");
            }
        }

        NovoJogo novoJogo = new NovoJogo();

    }
}