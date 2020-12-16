//YukhtaMaksym_PD-22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab1_Yukhta_Maksym_Variant13

{
    class Program
    {
        static void Main(string[] args)
        {
Console.WriteLine("Обчислення периметру заданого n-кутника, описаного навколо кола радиусом R");
            Console.Write("Кiлькiсть сторiн:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Радiус кола:");
            double r = Convert.ToDouble(Console.ReadLine());
            double P = n * (2 * r * Math.Sqrt(3));
            Console.WriteLine($"Периметер {n} кутника дорвiнюе: {P}");
            Console.ReadKey();
        }
    }
}
