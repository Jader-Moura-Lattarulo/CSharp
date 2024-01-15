using System;

class Program
{
    static void Main()
    {
        string oláString = ConstruaOlaString();
        Console.WriteLine(oláString);

        Console.ReadKey();
    }

    static string ConstruaOlaString()
    {
        char[] letras = { 'O', 'l', 'á' };
        var result = "";
        for (int i = 0; i < letras.Length; i++)
        {
            result += letras[i];
        }
        return result;
    }

}
