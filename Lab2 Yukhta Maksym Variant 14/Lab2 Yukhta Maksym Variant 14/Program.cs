using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//YukhtaMaksym_PD-22
namespace Lab1_Yukhta_Maksym_Variant14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nn, nk;

            Console.WriteLine("nn=");
            nn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nk=");
            nk = Convert.ToInt32(Console.ReadLine());
            Console.ReadKey(); 

            if (nn >= 0 && nk >= nn)
            {
                n = nn / 2;
                int k = nn;
                int a = 1;
                for (int i = k; i < nk; i++)
                {

                    a = a * ((-1) ^ (k) * k + 8) / (2 * (k) ^ (2) + k + 7);
                }
                Console.WriteLine($"a={a}");
                Console.ReadKey();

            }
        }
    }
}