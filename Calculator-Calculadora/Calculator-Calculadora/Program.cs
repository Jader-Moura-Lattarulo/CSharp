using System.Collections.Generic;

int firstNumber; int secondNumber;

Console.WriteLine("Hello!");
Console.Write("Please input the first number: ");
string firstNumerAsText = Console.ReadLine();
int.TryParse(firstNumerAsText, out firstNumber);

Console.Write("Please input the secound number: ");
string secoundNumerAsText = Console.ReadLine();
int.TryParse(secoundNumerAsText, out secondNumber);

Console.WriteLine("What do want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");

string userChoice = Console.ReadLine();

if (EqualCaseInsensitive(userChoice,"A"))
{
    int sum = firstNumber + secondNumber;
    PrintFinalEquation(firstNumber, secondNumber, sum, "+");
}
else if (EqualCaseInsensitive(userChoice, "S"))
{
    int  difference = firstNumber - secondNumber;
    PrintFinalEquation(firstNumber, difference, difference, "-");
}
else if (EqualCaseInsensitive(userChoice, "M"))
{
    int multiplied = firstNumber * secondNumber;
    PrintFinalEquation(firstNumber, secondNumber,multiplied, "*");
}
else
{
    Console.WriteLine("Invalid choice!");
}

void PrintFinalEquation(int firstNumber, int secondNumber, int result, string @operator)
{
    Console.WriteLine($"{firstNumber } {@operator} { secondNumber} = {result}");
}
bool EqualCaseInsensitive (string right, string left)
{
    return right.ToUpper() == left.ToUpper();
}

Console.WriteLine("Press any key to close.");

Console.ReadKey();