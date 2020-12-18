using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3_Yukhta_Maksym_Variant_7
{
    class Program
    {
        /*   7.	Перевірити істинність вислову:
          "Серед трьох даних цілих чисел є хоч би одна пара співпадаючих".  */
        static void Main()
        {
            int[] arr = new int[3];
            string temp = "Чи знайшлась пара цiлих чисел якi спiвпадають? - ";

            for (int j = 0; j < 3; j++)
            {
                Console.Write("Введiть " + (j + 1) + " Цiле число: ");
                arr[j] = int.Parse(Console.ReadLine());
            }
            if (arr[0] == arr[1] || arr[0] == arr[2] || arr[1] == arr[2])
            {
                Console.WriteLine(temp + true);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine(temp + false);
                Console.ReadKey();
            }
        }
    }
}