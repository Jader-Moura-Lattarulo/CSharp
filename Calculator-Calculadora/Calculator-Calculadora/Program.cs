using System.Collections.Generic;

int firstNumber; int secoundNumber;

Console.WriteLine("Hello!");
Console.Write("Please input the first number: ");
string firstNumerAsText = Console.ReadLine();
int.TryParse(firstNumerAsText, out firstNumber);

Console.Write("Please input the secound number: ");
string secoundNumerAsText = Console.ReadLine();
int.TryParse(secoundNumerAsText, out secoundNumber);

Console.WriteLine("What do want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");

string userChoice = Console.ReadLine();

if (EqualCaseInsensitive(userChoice,"A"))
{
    int sum = firstNumber + secoundNumber;
    PrintFinalEquation(firstNumber, secoundNumber, sum, "+");
}
else if (EqualCaseInsensitive(userChoice, "S"))
{
    int  difference = firstNumber - secoundNumber;
    PrintFinalEquation(firstNumber, secoundNumber, difference, "-");
}
else if (EqualCaseInsensitive(userChoice, "M"))
{
    int multiplied = firstNumber * secoundNumber;
    PrintFinalEquation(firstNumber, secoundNumber,multiplied, "*");
}
else
{
    Console.WriteLine("Invalid choice!");
}

void PrintFinalEquation(int firstNumber, int secoundNumber, int result, string @operator)
{
    Console.WriteLine($"{firstNumber } {@operator} { secoundNumber} = {result}");
}
bool EqualCaseInsensitive (string right, string left)
{
    return right.ToUpper() == left.ToUpper();
}

Console.WriteLine("Press any key to close.");

Console.ReadKey();