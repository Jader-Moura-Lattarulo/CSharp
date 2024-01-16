using System;
using System.Collections.Generic;

class Program
{
    static List<string> todos = new List<string>();

    static void Main()
    {
        string[] validChoices = {"s", "a", "r", "e"};
        string userChoice;

        Console.WriteLine("Hello!");

        do
        {
            PrintMenu();
            userChoice = Console.ReadLine().ToLower();
            Console.Clear();

            if (Array.Exists(validChoices, choice => choice.Equals(userChoice)))
            {
                ProcessUserChoice(userChoice);
            }
            else
            {
                Console.WriteLine("Invalid choice! Please input a valid choice:\n");
            }

        } while (userChoice != "e");

        static void PrintMenu()
        {
            Console.WriteLine("What do you want to do?\n");
            Console.WriteLine("[S]ee all TODOs");
            Console.WriteLine("[A]dd a TODO");
            Console.WriteLine("[R]emove a TODO");
            Console.WriteLine("[E]xit");
        }

        static void ProcessUserChoice(string choice)
        {
            switch (choice)
            {
                case "s":
                    PrintSelectedOption("See all TODOs");
                    SeeAllTodos();
                    break;
                case "a":
                    PrintSelectedOption("Add a TODO");
                    AddTodo();
                    break;
                case "r":
                    PrintSelectedOption("Remove a TODO");
                    RemoveTodo();
                    break;
                case "e":
                    PrintSelectedOption("Exit");
                    Console.WriteLine("Press any key to close.");
                    Console.ReadKey();
                    break;
            }
        }

        static void PrintSelectedOption(string selectedOption)
        {
            Console.WriteLine($"Selected option: {selectedOption}\n");
        }

        static void SeeAllTodos()
        {
            if(todos.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet.");
                Console.WriteLine("Please add a TODO before check all TODOs.");
            }
            else
            {
                Console.WriteLine("List of all TODOs:\n");

                for (int i = 0; i < todos.Count; i++)
                {
                    Console.WriteLine($"{i + 1} {todos[i]}");
                }
            }
            Console.WriteLine();
        }

        static void AddTodo()
        {
            Console.WriteLine("Enter the TODO description:");
            string newTodo = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(newTodo))
            {
                Console.WriteLine("The description cannot be empty.\n");
            }
            else if (todos.Contains(newTodo))
            {
                Console.WriteLine("You already have this on the list.\n");
            }
            else
            {
                todos.Add(newTodo);
                Console.WriteLine($"TODO successfully added: {newTodo}\n");
            }
        }

        static void RemoveTodo()
        {
            if (todos.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet.");
                return;
            }
            else
            {
                Console.WriteLine("Select the index of the TODO you want to remove:\n");

                for(int i = 0;i < todos.Count;i++)
                {
                    Console.WriteLine($"{i + 1}. {todos[i]}");
                }
            }
            Console.WriteLine();

            if (int.TryParse(Console.ReadLine(), out int index) && index <= todos.Count) 
            {
                string removedTodo = todos[index - 1];
                todos.RemoveAt(index - 1);
                Console.WriteLine($"TODO removed: {removedTodo}\n");
            }
            else
            {
                Console.WriteLine("The given index is not valid.\n");
            }
        }
             
    }
}