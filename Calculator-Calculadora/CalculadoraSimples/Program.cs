Console.WriteLine("Olá!");

int primeiroNúmero; int segundoNúmero;

Console.Write("Por favor insira o primeiro número: ");
string entradaUsuário = Console.ReadLine();
int.TryParse(entradaUsuário, out primeiroNúmero);

Console.Write("Por favor insira o segundo número: ");
string entradaUsuário2 = Console.ReadLine();
int.TryParse(entradaUsuário2, out segundoNúmero);

Console.WriteLine("O que você quer fazer?\n[A]dicionar os números\n[S]ubtrair os números\n[M]ultiplicar os números");
string respostaUsuário = Console.ReadLine();

if (respostaUsuário == "A" || respostaUsuário == "a")
{
    Console.WriteLine($"{primeiroNúmero} + {segundoNúmero} = {primeiroNúmero + segundoNúmero}");
}
else if (respostaUsuário == "S" || respostaUsuário == "s")
{
    Console.WriteLine($"{primeiroNúmero} - {segundoNúmero} = {primeiroNúmero - segundoNúmero}");
}
else if (respostaUsuário == "M" || respostaUsuário == "m")
{
    Console.WriteLine($"{primeiroNúmero} * {segundoNúmero} = {primeiroNúmero * segundoNúmero}");
}
else
{
    Console.WriteLine("Escolha Inválida!");
}

Console.WriteLine("Pressione qualquer tecla para fechar.");
Console.ReadKey();