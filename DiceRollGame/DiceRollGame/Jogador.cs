using DiceRollGame;

internal class Jogador
{
    private ValidacaoEntradaJogador validacaoEntradaJogador;

    public Jogador()
    {
        validacaoEntradaJogador = new ValidacaoEntradaJogador();
    }

    public int FazerPalpite()
    {

        string palpite = Console.ReadLine() ?? "0";

        if (palpite != null && validacaoEntradaJogador.ValidacaoPalpite(palpite, out int resposta))
        {
            return resposta;
        }
        else
        {
            Console.WriteLine("Entrada inválida. Digite um número inteiro entre 1 e 6.");
            return FazerPalpite();
        }
    }
}