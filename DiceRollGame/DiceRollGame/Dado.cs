namespace DiceRollGame
{
    internal class Dado
    {
        public static int RolarDado()
        {
            Random random = new Random();
            int dado = random.Next(1, 7);
            return dado;
        }

    }
}
