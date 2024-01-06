namespace M01A02d
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(20, 5);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Olá amigo(a)!");
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();
            Console.SetCursorPosition(10, 3);
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Tudo bem com você?");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
