using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmi
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengte;
            double gewicht;
            double bmi;
            double lengte2;

            Console.WriteLine("Voer u gewicht in:");
            gewicht = int.Parse(Console.ReadLine());

            Console.WriteLine("Voer u lengte in: (vul in cm!)");
            lengte = int.Parse(Console.ReadLine());

            lengte2 = lengte / 100;
            bmi = gewicht / (lengte2 * lengte2);

            Console.WriteLine($"U BMI is {Math.Round(bmi, 2)}");
            Console.ReadKey();
        }
    }
}
