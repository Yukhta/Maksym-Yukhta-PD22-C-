using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_Yukhta_Maksym_Variant_4
{
    /* 4.
     * Створити ліст інтових змінних, дозволити можливість заповнення з калвіатури. 
     * Вивести індекси змінних рівних перевірочній(теж ввести з клавіатури). 
     * Скопіювати ліст в масив. */
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listInt = new List<int>();
            Console.Write("Введiть розмiр лiста: ");
            int sizeList = int.Parse(Console.ReadLine());

            for (int i = 0; i < sizeList; i++)
            {
                Console.Write($"Введiть {i + 1}-ий елемента лiста: ");
                listInt.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("Введiть перовiрочну змiну: ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("Iндекс елементiв якi мають значення перевiрочной змiни: ");

            bool temp = false;

            for (int i = 0; i < sizeList; i++)
            {
                if (listInt[i] == k)
                {
                    Console.Write("{0 } ", i);
                    temp = true;
                }
            }
            if (!temp)
                Console.Write("!Такiх елементiв немае!");
            int[] ArrFromList = new int[sizeList];

            for (int i = 0; i < sizeList; i++)
                ArrFromList[i] = listInt[i];
            Console.WriteLine();
            Console.Write("Масив до вихiдного лісту: ");

            for (int i = 0; i < sizeList; i++)
                Console.Write($"{ArrFromList[i]} ");
            Console.WriteLine();
            Console.ReadKey();
        }

    }
}