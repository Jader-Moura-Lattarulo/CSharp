Console.WriteLine("Olá!");

int primeiroNúmero; int segundoNúmero;

Console.Write("Por favor insira o primeiro número: ");
string primeiroNúmeroTexto = Console.ReadLine();
int.TryParse(primeiroNúmeroTexto, out primeiroNúmero);

Console.Write("Por favor insira o segundo número: ");
string segundoNúmeroTexto = Console.ReadLine();
int.TryParse(segundoNúmeroTexto, out segundoNúmero);

Console.WriteLine("O que você quer fazer?");
Console.WriteLine("[A]dicionar os números");
Console.WriteLine("[S]ubtrair os números");
Console.WriteLine("[M]ultiplicar os números");

string respostaUsuário = Console.ReadLine();

if (CompararMaiúsculasMinusculas(respostaUsuário,"A"))
{
    int soma = primeiroNúmero + segundoNúmero;
    ImprimirEquaçãoFinal(primeiroNúmero, segundoNúmero, soma, "+");
}
else if (CompararMaiúsculasMinusculas(respostaUsuário, "S"))
{
    int subtração = primeiroNúmero - segundoNúmero;
    ImprimirEquaçãoFinal(primeiroNúmero, segundoNúmero, subtração, "-");
}
else if (CompararMaiúsculasMinusculas(respostaUsuário, "M"))
{
    int multiplicação = primeiroNúmero * segundoNúmero;
    ImprimirEquaçãoFinal(primeiroNúmero, segundoNúmero, multiplicação, "*");
}
else
{
    Console.WriteLine("Escolha Inválida!");
}

void ImprimirEquaçãoFinal(int primeiroNúmero, int segundoNúmero, int resultado, string operador)
{
    Console.WriteLine($"{primeiroNúmero } {operador} { segundoNúmero} = {resultado}");
}
bool CompararMaiúsculasMinusculas (string direita, string esquerda)
{
    return direita.ToUpper() == esquerda.ToUpper();
}

Console.WriteLine("Pressione qualquer tecla para fechar.");

Console.ReadKey();