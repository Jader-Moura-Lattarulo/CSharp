using System.Globalization;

var person = new Person { Name = "Jader", YearOfBirth = 1989 };
Console.ReadKey();

class Person
{
    public string Name { get; set; }
    public int YearOfBirth { get; init; }

    
    
    //public Person(string name, int yearOfBirth)
    //{
    //    Name = name;
    //    YearOfBirth = yearOfBirth;
    //}
}