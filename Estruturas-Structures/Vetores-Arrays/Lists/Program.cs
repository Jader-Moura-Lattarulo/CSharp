//List<string> words = new List<string>();
//Console.WriteLine("Count of elements is " + words.Count);

//words.Add("hello");
//Console.WriteLine("Count of elements is " + words.Count);

using System.ComponentModel;

var words = new List<string>
{
    "one",
    "two",
};
Console.WriteLine("Count of elements is " + words.Count);

foreach (var word in words)
{
    Console.WriteLine(word);
}

Console.WriteLine("Removing an item");

//words.Remove("one");
words.RemoveAt(0);

//var moreWords = new[] { "three", "four", "five" };
//words.AddRange(moreWords);

words.AddRange(new[] { "three", "four", "five" });
Console.WriteLine("Index of element 'four' is" + words.IndexOf("four"));
Console.WriteLine("Index of element 'seven' is" + words.IndexOf("seven"));//Give back -1

Console.WriteLine("Contains 'five'?: " + words.Contains("five"));//Give back True
Console.WriteLine("Contains 'nine' ?: " + words.Contains("nine"));//Give back False

words.Clear();
Console.WriteLine("Count of elements after Clear: " + words.Count);

foreach (var word in words)
{
    Console.WriteLine(word);
}

Console.ReadKey();