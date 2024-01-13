using System.Collections.Generic;

int firstNumber; int secondNumber;

Console.WriteLine("Hello!");
Console.Write("Please input the first number: ");
string userInputFirstNumber = Console.ReadLine();
int.TryParse(userInputFirstNumber, out firstNumber);

Console.Write("Please input the secound number: ");
string userInputSecoundNumber = Console.ReadLine();
int.TryParse(userInputSecoundNumber, out secondNumber);

Console.WriteLine("What do want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");

string userInputAnswer = Console.ReadLine();

if (userInputAnswer == "A" || userInputAnswer == "a")
{
    Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
}
else if (userInputAnswer == "S" || userInputAnswer == "s")
{
    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
}
else if (userInputAnswer == "M" || userInputAnswer == "m")
{
    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
}
else
{
    Console.WriteLine("Invalid choice!");
}

Console.WriteLine("Press any key to close.");

Console.ReadKey();