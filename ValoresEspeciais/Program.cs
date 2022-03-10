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
            sbyte sb = sbyte.MaxValue;
            sbyte sa = sbyte.MinValue;
            ulong lu = ulong.MinValue;
            ulong ul = ulong.MaxValue;
            double x = double.PositiveInfinity;
            double y = double.NegativeInfinity;
            float z = float.NaN;

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(maxFloat);
            Console.WriteLine(minFloat);    
            Console.WriteLine(maxInt);
            Console.WriteLine(minInt);
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(sa);
            Console.WriteLine(sb);
            Console.WriteLine(lu);
            Console.WriteLine(ul);
        }
    }
}
