using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_Yukhta_Maksym
{
    class Garage
{
    public List<Car> myCars = new List<Car>();

    public void AddNewCar()
    {
        string name;
        string color;
        int speed;
        int year;

        Console.Write("\nEnter the name of your car: ");
        name = Console.ReadLine();

        Console.Write("Enter the color of your car: ");
        color = Console.ReadLine();

        Console.Write("Enter the speed of your car:: ");

            /* якщо не правильна швидкість*/

            while (!int.TryParse(Console.ReadLine(), out speed) || speed <= 0)
        {
            Console.Write("Enter the correct speed value: ");
        }

        Console.Write("Enter the car`s year of issue: ");

            /* якщо не правильний рік випуску*/

            while (!int.TryParse(Console.ReadLine(), out year) || year > 2019 || year < 1900)
        {
            Console.Write("Enter the correct year: ");
        }

        Car newCar = new Car(name, color, speed, year);

        myCars.Add(newCar);
    }

    public void DisplayAllCars()
    {
        Console.WriteLine("\nIts a really nice garage!!");
        int i = 1;
        foreach (Car c in myCars)
        {
            DisplayInfoAboutCar(c);
            i++;
        }
    }

    public void RemoveCar()
    {
        int position;
        Console.Write("Chose the position you want to remove: ");
        while (!int.TryParse(Console.ReadLine(), out position) || position < 1 || position > myCars.Count)
        {
            Console.Write("There are no cars in this position! Position: ");
        }
        myCars.RemoveAt(position - 1);
        Console.WriteLine("The car in {0} position was removed!", position);
    }

    public void SearchByOneCharacteristic(char characteristic)
    {
        int i = 0;
        switch (characteristic)
        {
            case 'n':
                Console.Write("What car's name you would like to look for: ");
                string name = Console.ReadLine();

                foreach (Car c in myCars)
                {
                    if (c.Name == name)
                    {
                        DisplayInfoAboutCar(c);
                        i++;
                    }
                }
                    /*Додати випадок якщо нічого не знайдено*/
                    if (i == 0) Console.WriteLine("No matches found!");
                i = 0;
                break;

            case 'c':
                Console.Write("What car's color would you like to look for: ");
                string color = Console.ReadLine();
                foreach (Car c in myCars)
                {
                    if (c.Color == color)
                    {
                        DisplayInfoAboutCar(c);
                        i++;
                    }
                }
                    /*Додати випадок якщо нічого не знайдено*/
                    if (i == 0) Console.WriteLine("No matches found!");
                i = 0;
                break;

            case 's':
                Console.Write("What car's name would you like to look for: ");
                int speed = Convert.ToInt32(Console.ReadLine());
                foreach (Car c in myCars)
                {
                    if (c.Speed == speed)
                    {
                        DisplayInfoAboutCar(c);
                        i++;
                    }
                }
                    /*Додати випадок якщо нічого не знайдено*/
                    if (i == 0) Console.WriteLine("No matches found!");
                i = 0;
                break;

            case 'y':
                Console.Write("What car's name would you like to look for: ");
                int year = Convert.ToInt32(Console.ReadLine());
                foreach (Car c in myCars)
                {
                    if (c.YearOfIssue == year)
                    {
                        DisplayInfoAboutCar(c);
                        i++;
                    }
                }
                if (i == 0) Console.WriteLine("No matches found!");
                i = 0;
                break;

            default:
                Console.WriteLine("No such characteristic!");
                break;
        }

    }

    public void DisplayInfoAboutCar(Car car)
    {
        Console.Clear();
        Console.WriteLine("---Properties---");
        Console.WriteLine("\nName  : {0}\nColor  : {1}\nSpeed  : {2}\nYear  : {3}", car.Name, car.Color, car.Speed, car.YearOfIssue);
    }
}



class Car
{
    public string Name { get; }
    public string Color { get; }
    public int Speed { get; }
    public int YearOfIssue { get; }

    public Car() { }
    public Car(string name, string color, int speed, int yearOfIssue)
    {
        Name = name;
        Color = color;
        Speed = speed;
        YearOfIssue = yearOfIssue;
    }
}
class Program
{
        static void Main(string[] args)
        {
            Garage myGarage = new Garage();
            Console.WriteLine("Sheihk's garage");
            int choice;

            do
            {

                Console.WriteLine();
                if (myGarage.myCars.Count == 0)
                {
                    Console.WriteLine("[1] - add a new car");
                    Console.WriteLine("[0] - close your garage");
                }
                else
                {

                    Console.WriteLine("[1] - add a new car");
                    Console.WriteLine("[2] - show all your cars");
                    Console.WriteLine("[3] - delete your car");
                    Console.WriteLine("[4] - find your cars by one characteristic");
                    Console.WriteLine("[0] - close your garage");

                }
                Console.Write("Choose an option:");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Enter the correct option: ");
                }
                switch (choice)
                {
                    case 1:
                        myGarage.AddNewCar();
                        Console.Clear();
                        Console.WriteLine("Car was added in garage: " + myGarage.myCars.Count);
                        break;
                    case 2:
                        myGarage.DisplayAllCars();
                        break;
                    case 3:
                        myGarage.RemoveCar();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("What characteristic would you like to look for?");
                        char characteristic;
                        Console.WriteLine("[n] - name");
                        Console.WriteLine("[c] - color");
                        Console.WriteLine("[s] - speed");
                        Console.WriteLine("[y] - year of issue");
                        characteristic = Convert.ToChar(Console.ReadLine());
                        myGarage.SearchByOneCharacteristic(characteristic);
                        break;
                    case 0:
                        Console.WriteLine("Garage closed.");
                        return;
                    default:
                        Console.WriteLine("!Incorect option!");
                        break;

                }






            } while (choice != 0);
        }
    }
}