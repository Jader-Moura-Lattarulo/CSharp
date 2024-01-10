namespace M01Ex001
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.Sleep(1000);
            Console.SetCursorPosition(10,5);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(" MEU ");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor= ConsoleColor.Yellow;
            Console.Write(" BRASIL ");
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor= ConsoleColor.Green;
            Console.Write(" BRASILEIRO ");
            Thread.Sleep(2000);
            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();
        }
    }
}