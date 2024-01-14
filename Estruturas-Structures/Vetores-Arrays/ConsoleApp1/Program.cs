using System.Diagnostics.CodeAnalysis;

int[] numbers = new int[] { 2, 6, 1, 6, 19 };

Console.WriteLine($"element at index 0 is {numbers[0]}");
Console.WriteLine($"element at index 1 is {numbers[1]}");
Console.WriteLine($"element at index 2 is {numbers[2]}");
Console.WriteLine($"element at index 3 is {numbers[3]}");
Console.WriteLine($"element at index 4 is {numbers[4]}");

Console.WriteLine();

var sum = 0;
for (var i = 0; i < numbers.Length; ++i)
{
    sum += numbers[i];
}
Console.WriteLine($"sum of elements is {sum}");

Console.WriteLine();

var firstFromEnd = numbers[^1];
var secondFromEnd = numbers[^2];

Console.WriteLine($"the last one element is {firstFromEnd}");
Console.WriteLine($"the penultimate element is {secondFromEnd}");

//int[] numbers = new int[3];

//Console.WriteLine($"Element at index 0 is {numbers[0]}");
//Console.WriteLine($"Element at index 1 is {numbers[1]}");
//Console.WriteLine($"Element at index 2 is {numbers[2]}");

//Console.WriteLine();

//numbers[0] = 5;
//numbers[1] = 6;
//numbers[2] = 7;

//Console.WriteLine($"Element at index 0 is {numbers[0]}");
//Console.WriteLine($"Element at index 1 is {numbers[1]}");
//Console.WriteLine($"Element at index 2 is {numbers[2]}");

Console.ReadKey();