using System;
using System.Collections.Generic;

namespace lab11_Yukhta_Maksym
{
    delegate void myDelegate(Product product);
    delegate bool StudentPredicateDelegate(Student student);

    class Program
    {
        public static void printListStudent(in List<Student> ls)
        {
            foreach(var student in ls)
            {
                Console.WriteLine($"Im'я - {student.FirstName}");
                Console.WriteLine($"Прiзвище - {student.LastName}");
                Console.WriteLine($"Вiк - {student.Age}");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {



            /* Завдання 1 Юхта Максим */



            Product product = new Product();
            Conveyor conveyor = new Conveyor();
            myDelegate my_Delegate = new myDelegate(conveyor.cutOff);
            my_Delegate += conveyor.cutThread;
            my_Delegate += conveyor.toPaint;
            my_Delegate(product);
            product.showInfo();
            Console.WriteLine(new string('/', 80));




            /* Завдання 2 Юхта Максим */



            List<Student> group = new List<Student>();
            group.Add(new Student("Данiель", "Бiлодiд", 19));
            group.Add(new Student("Максим", "Юхта", 18));
            group.Add(new Student("Вадим", "Михайленко", 20));
            group.Add(new Student("Дiана", "Мел", 17));
            group.Add(new Student("Геральд", "Рiвiйський", 15));
            group.Add(new Student("Вiталiй", "Кiбер", 18));
            group.Add(new Student("Артем", "Стопчук", 17));
            group.Add(new Student("Юлiя", "Велика", 15));
            group.Add(new Student("Андрiй", "Третiк", 13));
            group.Add(new Student("Дранiк", "Веселий", 24));


            List<Student> results = new List<Student>();
            StudentPredicateDelegate del;



            /* Завдання 2.8 Юхта Максим */



            Console.WriteLine();
            del = Student.isAge18;
            results =  group.FindStudent(del);
            printListStudent(in results);

            Console.WriteLine(new string('*', 50));
            results.Clear();
            del = Student.isFirstNameBeginFromA;
            results = group.FindStudent(del);
            printListStudent(in results);

            Console.WriteLine(new string('*', 50));
            results.Clear();
            del = Student.isLastNameLengthMoreThan3;
            results = group.FindStudent(del);
            printListStudent(in results);



            /* Завдання 2.9 Юхта Максим */



            Console.WriteLine(new string('/', 80));
            results.Clear();
            del = student => student.Age >= 18;
            results = group.FindStudent(del);
            printListStudent(in results);
            Console.WriteLine(new string('*', 50));
            results.Clear();
            del = student => student.FirstName.ToCharArray()[0] == 'A';
            results = group.FindStudent(del);
            printListStudent(in results);
            Console.WriteLine(new string('*', 50));
            results.Clear();
            del = student => student.FirstName.Length > 3;
            results = group.FindStudent(del);
            printListStudent(in results);



            /* Завдання 2.10 Юхта Максим */



            Console.WriteLine(new string('/', 80));
            results.Clear();
            del = student => student.Age >= 20 && student.Age <= 25;
            results = group.FindStudent(del);
            printListStudent(in results);



            /* Завдання 2.11 Юхта Максим */


            Console.WriteLine(new string('/', 80));
            results.Clear();
            del = student => student.FirstName == "Andrew";
            results = group.FindStudent(del);
            printListStudent(in results);



            /* Завдання 2.12 Юхта Максим */


            Console.WriteLine(new string('/', 80));
            results.Clear();
            del = student => student.LastName == "Troelsen";
            results = group.FindStudent(del);
            printListStudent(in results);
            Console.ReadKey();
        }
    }
    static class Extension
    {
        public static List<Student> FindStudent(this List<Student> ls, StudentPredicateDelegate del)
        {
            List<Student> tempList = new List<Student>();
            foreach (var student in ls)
            {
                if (del.Invoke(student))
                    tempList.Add(student);
            }
            return tempList;
        }
    }
}
