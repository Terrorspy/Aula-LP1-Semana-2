using System;

namespace IncDec
{
    class Program
    {
        static void Main(string[] args)
        {
           int a = 5, b = -7, c;
           c = ++a + b++;

           int d = 9, e = 2, f;
           f = --d + --e;

           Console.WriteLine(f);
           Console.WriteLine(c);

        }
    }
}
