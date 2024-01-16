using System;
using System.Collections.Generic;

class Program
{
    static List <string> todos = new List<string>();

    static void Main()
    {
        string[] validChoices = { "s", "S", "a", "A", "r", "R", "e", "E" };

        bool validInput = false;
        string userChoice = "";

        Console.WriteLine("Hello!");

        do
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine();
            Console.WriteLine("[S]ee all TODOs");
            Console.WriteLine("[A]dd a TODO");
            Console.WriteLine("[R]emove a TODO");
            Console.WriteLine("[E]xit");

            userChoice = Console.ReadLine();
            Console.WriteLine();

            if (Array.Exists(validChoices, choice => choice.Equals(userChoice)))
            {
                validInput = true;
            }
            else
            {
                Console.WriteLine("Invalid choice!");
                Console.WriteLine("Please input a valid choice:");
                Console.WriteLine();
            }
        } while (!validInput);

        switch (userChoice.ToLower())
        {
            case "s":
                PrintSelectedOption("See all TODOs");
                SeeAllTodos();
                break;
            case "a":
                PrintSelectedOption("Add a TODO");
                break;
            case "r":
            PrintSelectedOption("Remove a TODO");
                break;
            case "e":
                PrintSelectedOption("Exit");
                break;
        }

        Console.ReadKey();

        static void PrintSelectedOption(string selectedOption)
        {
            Console.WriteLine("Selected option: " + selectedOption);
        }

        static void SeeAllTodos()
        {
            if (todos.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet.");
            }
            else
            {
                Console.WriteLine("List of all TODOs:");

                for (int i = 0; i < todos.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {todos[i]}");
                }
            }

            Console.WriteLine("What do you want to do?");
        }
    }
}


