Console.WriteLine("Hello!");
Console.WriteLine("What do you want to do?");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

string userChoice = Console.ReadLine();

switch (userChoice)
{
    case "s":
    case "S":
        PrintSelectedOption("See all TODOs");
        break;
    case "a":
    case "A":
        PrintSelectedOption("Add a TODO");
        break;
    case "r":
    case "R":
        PrintSelectedOption("Remove a TODO");
        break;
    case "e":
    case "E":
        PrintSelectedOption("Exit");
        break;
    default:
        Console.WriteLine("Invalid choice");
        break;
}

//if(userChoice == "S")
//{
//    PrintSelectedOption("See all TODOs");
//}
//else if (userChoice == "A")
//{
//    PrintSelectedOption("Add a TODO");
//}
//else if (userChoice == "R")
//{
//    PrintSelectedOption("Remove a TODO");
//}
//else if (userChoice == "E")
//{
//    PrintSelectedOption("Exit");
//}

Console.ReadKey();

void PrintSelectedOption(string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}
