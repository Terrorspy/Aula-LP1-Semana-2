using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            double max = double.MaxValue;
            double min = double.MinValue;
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            float maxFloat = float.MaxValue;
            float minFloat = float.MinValue;

            Console.WriteLine(maxFloat);
            Console.WriteLine(minFloat);
            Console.WriteLine(maxInt);
            Console.WriteLine(minInt);
            Console.WriteLine(max);
            Console.WriteLine(min);
        }
    }
}
