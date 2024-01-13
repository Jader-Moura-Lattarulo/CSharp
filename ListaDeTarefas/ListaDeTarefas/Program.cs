Console.WriteLine("Olá!");
Console.WriteLine("O que você quer fazer?");
Console.WriteLine("[V]er todas tarefas");
Console.WriteLine("[A]dd uma tarefa");
Console.WriteLine("[R]emover uma tarefa");
Console.WriteLine("[S]air");

var escolhadoUsuário = Console.ReadLine();

if (escolhadoUsuário == "V")
{
    PrintOpçãoSelecionada("Ver todas tarefas");
}
else if (escolhadoUsuário == "A")
{
    PrintOpçãoSelecionada("Add uma tarefa");
}
else if (escolhadoUsuário == "R")
{
    PrintOpçãoSelecionada("Remover uma tarefa");
}
else if (escolhadoUsuário == "S")
{
    PrintOpçãoSelecionada("Sair");
}

void PrintOpçãoSelecionada(string opçãoSelecionada)
{
    Console.WriteLine("Opção selecionada: " + opçãoSelecionada);
}

Console.ReadKey();
