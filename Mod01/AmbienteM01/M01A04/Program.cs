namespace M01A04
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("O tipo byte vai de " + byte.MinValue + " até " + byte.MaxValue);
            //O tipo byte não aceita números negativos
            Console.ReadKey();
            //Para armazenarmos números negativos em byte utilizamos sbyte
            Console.WriteLine("O tipo sbyte vai de " + sbyte.MinValue + " até " + sbyte.MaxValue);
            Console.ReadKey();
            /*O único tipo primitivo numérico que inicia em números positivos e add s para negativos é o byte
             *O restante dos tipos vão sempre iniciar nos negativos e tendo "u" na frente de unsigned para números inteiros.
            */
            Console.WriteLine("O tipo short vai de " + short.MinValue + " até " + short.MaxValue);
            Console.WriteLine("O tipo ushort vai de " + ushort.MinValue + " até " + ushort.MaxValue);
            Console.ReadKey();
            Console.WriteLine("O tipo int vai de " + int.MinValue + " até " +  int.MaxValue);
            Console.WriteLine("O tipo uint vai de " + uint.MinValue + " até " + uint.MaxValue);
            Console.ReadKey();
            Console.WriteLine("O tipo long vai de " + long.MinValue + " até " + long.MaxValue);
            Console.WriteLine("O tipo ulong vai de " + ulong.MinValue + " até " + ulong.MaxValue);
            Console.ReadKey();
            Console.WriteLine("O tipo float vai de " + float.MinValue + " até " + float.MaxValue);
            Console.WriteLine("O tipo double vai de " + double.MinValue + " até " + double.MaxValue);
            Console.WriteLine("O tipo decimal vai de " + decimal.MinValue + " até " + decimal.MaxValue);
            Console.ReadKey();
            // Valores Lógicos
            Console.WriteLine("O tipo bool aceita " + bool.FalseString + " ou " + bool.TrueString);
        }
    }
}