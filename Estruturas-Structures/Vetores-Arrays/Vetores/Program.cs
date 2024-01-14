using System.Diagnostics.CodeAnalysis;

int[] numeros = new int[] { 2, 6, 1, 6, 19 };

Console.WriteLine($"O elemento no índice 0 é {numeros[0]}");
Console.WriteLine($"O elemento no índice 1 é {numeros[1]}");
Console.WriteLine($"O elemento no índice 2 é {numeros[2]}");
Console.WriteLine($"O elemento no índice 3 é {numeros[3]}");
Console.WriteLine($"O elemento no índice 4 é {numeros[4]}");

Console.WriteLine();

var soma = 0;
for (var i = 0; i < numeros.Length; ++i)
{
    soma += numeros[i];
}
Console.WriteLine($"A soma dos elementos é {soma}");

Console.WriteLine();

var ultimoElemento = numeros[^1];
var penultimoElemento = numeros[^2];

Console.WriteLine($"O último elemento é {ultimoElemento}");
Console.WriteLine($"O penúltimo elemento é {penultimoElemento}");

//int[] numeros = new int[3];

//Console.WriteLine($"Elemento no índice 0 é {numeros[0]}");
//Console.WriteLine($"Elemento no índice 1 é {numeros[1]}");
//Console.WriteLine($"Elemento no índice 2 é {numeros[2]}");

//Console.WriteLine();

//numeros[0] = 5;
//numeros[1] = 6;
//numeros[2] = 7;

//Console.WriteLine($"Elemento no índice 0 é {numeros[0]}");
//Console.WriteLine($"Elemento no índice 1 é {numeros[1]}");
//Console.WriteLine($"Elemento no índice 2 é {numeros[2]}");

Console.ReadKey();
