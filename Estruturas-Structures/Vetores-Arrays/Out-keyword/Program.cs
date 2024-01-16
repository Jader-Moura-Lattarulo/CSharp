var numbers = new[] { 10, -8, 2, 12, -17 };

int nonPositiveCount;
var onlyPositive = GetOnlyPositive(numbers, out nonPositiveCount);
foreach(var positiveNumber in onlyPositive)
{
    Console.WriteLine(positiveNumber);
}
Console.WriteLine("Count of non positive: " + nonPositiveCount);
Console.ReadKey();

List<int> GetOnlyPositive(int[] numbers, out int countOfNonPositive)
{
    countOfNonPositive = 0;
    var result = new List<int>();

    foreach (int number in numbers)
    {
        if(number > 0)
        {
            result.Add(number);
        }
        else
        {
            countOfNonPositive++;
        }
    }
    return result;
}