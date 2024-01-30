
class StringsTextualRepository
{
    private static readonly string Separator = Environment.NewLine;

    public List<string> Read(string filePath)
    {
        try
        {
            var fileContents = File.ReadAllText(filePath);
            return fileContents.Split(Separator).ToList();
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
            return new List<string>();
        }
    }

    public void Write(string filePath, List<string> strings)
    {
        try
        {
            File.WriteAllText(filePath, string.Join(Separator, strings));
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Error writing to file: {ex.Message}");
        }
    }
}
