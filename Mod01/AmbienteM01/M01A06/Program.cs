namespace M01A06
{
    class Program
    {
        static void Main(string[] args) 
        {
            const string escola = "Estudonauta";
            const float PI = 3.1415f;

            //escola = "Curso em Vídeo"; comando dá erro!

            Console.WriteLine("Eu estudo no " + escola);
            Console.WriteLine("O valor de Pi é " + PI);
            Console.WriteLine("O valor OFICIAL de Pi é " + Math.PI); //Usando a biblioteca Math contida em system
            Console.WriteLine("Os tipos de Pi declarado por mim e o em Math são respectivamente " + PI.GetType() + " e " + Math.PI.GetType());
            Console.ReadKey();
        }
    }
}