using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Altura do Cilindro:");
            double Altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Raio do Cilindro:");
            double Raio = Convert.ToDouble(Console.ReadLine());

            double Volume = Math.PI * (Raio * Raio) * Altura;
            Console.WriteLine("Volume do Cilindro: " + Volume);

            double ÁreaDeSuperfície = 2 * Math.PI * Raio * (Altura + Raio);

            Console.WriteLine("Área de Superfície do Cilindro:" + ÁreaDeSuperfície);


        }
    }
}
