using System;

class Program
{
    static void Main()
    {
        string helloString = BuildHelloString();
        Console.WriteLine(helloString);

        Console.ReadKey();
    }

    static string BuildHelloString()
    {
        char[] letters = { 'H', 'e', 'l', 'l', 'o' };
        var result = "";
        for (int i = 0; i < letters.Length; i++)
        {
            result += letters[i];
        }
        return result;
    }

}


