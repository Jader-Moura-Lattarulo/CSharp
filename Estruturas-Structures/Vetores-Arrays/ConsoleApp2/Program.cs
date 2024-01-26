using System.Net.Cache;

var lucky = new Dog("Lucky");
public class Dog
{
    public string Name;
    public int Age;

    public Dog()
    {
    }

    public Dog(string name)
    {
        Name = name;
    }

    public Dog(string name, int age)
    {
        Name = name;
        Age = age;
    }
}