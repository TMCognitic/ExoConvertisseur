using System;

namespace ExoConvertisseur
{
    public class Program
    {
        static void Main(string[] args)
        {
            long value;

            Console.Write("Entrez le nombre à convertir : ");
            while (!long.TryParse(Console.ReadLine(), out value))
            {
                Console.Clear();
                Console.Write("Entrez le nombre à convertir : ");
            }

            for (int i = 2; i < 37; i++)
            {
                Console.WriteLine($"base {i:D2} : {Convert(value, i)}");
            }
        }

        static string Convert(long value, int baseToConvert)
        {
            if (baseToConvert < 2 || baseToConvert > 36)
                return null;

            string baseValues = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";            
            string result = "";

            long modulo = 0;

            while (value >= baseToConvert)
            {
                modulo = value % baseToConvert;
                value /= baseToConvert;
                result = baseValues[(int)modulo] + result;
            }

            result = baseValues[(int)value] + result;

            return result;
        }
    }

}