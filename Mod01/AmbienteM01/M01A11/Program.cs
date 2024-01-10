namespace M01A10
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia = DateTime.Now.Day;
            int mes = DateTime.Now.Month;
            int ano = DateTime.Now.Year;

            Console.WriteLine("A data atual é dia " + dia + " mês " + mes + " ano " + ano);

            int hora = DateTime.Now.Hour;
            int min = DateTime.Now.Minute;
            int sec = DateTime.Now.Second;

            Console.WriteLine("A hora atual é " + hora + " horas " + min + " minutos " + sec + " segundos");

            Console.ReadKey();

        }
    }
}