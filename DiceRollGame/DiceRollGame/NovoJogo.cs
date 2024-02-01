internal class NovoJogo
{
    public NovoJogo()
    {
        string novoJogo;

        do
        {
            Console.Write("Deseja começar um novo jogo? (s/n) ");
            novoJogo = Console.ReadLine()?.ToLower() ?? "";

            switch (novoJogo)
            {
                case "s":
                    Console.Write("Iniciando um novo jogo");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.Write(".");
                    Thread.Sleep(1000);
                    Console.WriteLine(".");
                    Thread.Sleep(1000);
                    Console.Clear();
                    ControladorJogo controladorJogo = new ControladorJogo();
                    controladorJogo.IniciarJogo();
                    break;

                case "n":
                    Console.Clear();
                    Console.WriteLine("Até a próxima!");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;

            }
        } while (novoJogo != "s" && novoJogo != "n");
    }
}