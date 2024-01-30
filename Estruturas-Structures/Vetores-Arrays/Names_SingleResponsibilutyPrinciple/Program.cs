class Program
{
    static void Main()
    {
        var names = new Names();
        var path = new NamesFilePathBuilder().BuildFilePath();
        var stringsTextualRepository = new StringsTextualRepository();

        if (File.Exists(path))
        {
            Console.WriteLine("Names file already exists. Loading names.");
            var stringsFromFile = stringsTextualRepository.Read(path);
            names.AddNames(stringsFromFile);
        }
        else
        {
            Console.WriteLine("Names file does not yet exist.");

            names.AddName("Jader");
            names.AddName("not a valid name");
            names.AddName("Gabi");
            names.AddName("123 definitely not a valid name");

            Console.WriteLine("Saving names to a file.");
            stringsTextualRepository.Write(path, names.All);
        }

        Console.WriteLine(names.Format());
        Console.ReadKey();
    }
}
