using System;
using System.Globalization;

namespace Condiconal
{
    class Program
    {
        static void Main(string[] args)
        {

            double n1, n2, nota;

            n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            nota= n1+ n2;  
            Console.WriteLine("NOTA FINAL = "+nota.ToString("F1", CultureInfo.InvariantCulture));

            if (nota <=60)
            {
                Console.WriteLine("REPROVADO");

            }
            else 
            {
                Console.WriteLine("APROVADO");
            }
        }
    }
}