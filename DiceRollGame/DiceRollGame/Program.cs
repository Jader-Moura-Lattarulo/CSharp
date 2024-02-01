class Programa
{
    static void Main()
    {
        Console.WriteLine("Bem vindo ao jogo de adivinhação!");
        ControladorJogo controladorJogo = new ControladorJogo();
        controladorJogo.IniciarJogo();
    }
}