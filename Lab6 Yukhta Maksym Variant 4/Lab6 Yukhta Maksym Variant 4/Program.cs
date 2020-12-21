using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_Yukhta_Maksym_Variant_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m, c;
            Console.WriteLine("Введiть розмiр числа:");
            n = int.Parse(Console.ReadLine());
            int[] a;
            a = new int[n];
            for (int i = 0; i < n; ++i)

            {
                Console.Write("Елемент числа № " + (i + 1));
                a[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Число сзадом наперед: ");

            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("Введiть розмiр: ");
            m = int.Parse(Console.ReadLine());
            char[] b;
            b = new char[m];

            for (int i = 0; i < m; ++i)
            {
                Console.WriteLine("n[" + i + "] =");
                b[i] = char.Parse(Console.ReadLine());
            }

            for (int i = m - 1; i >= 0; --i)
            {
                Console.Write(b[i] + " ");
            }
            Console.WriteLine("Введiть дроб");
            c = int.Parse(Console.ReadLine());
            char[] t;
            t = new char[c];

            for (int i = 0; i < c; ++i)
            {
                Console.WriteLine("n[" + i + "] = ");
                t[i] = char.Parse(Console.ReadLine());
            }

            for (int i = c - 1; i >= 0; --i)
            {
                Console.Write(t[i] + " ");
            }
            Console.ReadLine();

            Console.Write("\n Введiть рядок для перевороту:");
            string magString = Console.ReadLine();
            Console.Write("Який символ роздiлить ваш рядок:");
            char sign = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(sign);
            Console.ReadKey();


            if (magString.IndexOf(sign) != -1)
            {
                string[] splitedStr = magString.Split(sign);

                Console.Write("Ваа зворотний рядок: ");
                for (int j = splitedStr[0].Length - 1; j >= 0; j--)
                {
                    Console.Write(splitedStr[0][j]);
                }
                Console.Write(sign);
                for (int j = splitedStr[1].Length - 1; j >= 0; j--)
                {
                    Console.Write(splitedStr[1][j]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("У цьому рядку немає обраного знака: ");
            }
            static void rozmir(int a, int n)
            {
                Console.WriteLine("Введіть розмір числа");
                n = int.Parse(Console.ReadLine());
                int[] d;
                d = new int[n];
                for (int i = 0; i < n; ++i)
                {
                    Console.Write("Елемент числа № " + (i + 1));
                    d[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Число сзадом наперед");
                for (int i = n - 1; i >= 0; i--)
                {
                    Console.WriteLine(d[i]);
                }
                return;
            }
        }
    }
}