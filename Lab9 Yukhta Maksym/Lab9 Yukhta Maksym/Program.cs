﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{

    interface IDraw
    {
        void Draw();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("Круг 1");
            Quadrate quadrate = new Quadrate("Квадрат 1", "Зелений", 25);
            Triangle triangle = new Triangle("Трикутник 1", 10, 15);
            Picture picture = new Picture();

            picture.Add(circle);
            picture.Add(quadrate);
            picture.Add(triangle);
            picture.Add(new Quadrate("Квадрат", "Червоний", 100));
            picture.Draw();

            Console.WriteLine("***********************************");

            picture.RemoveByName("Круг 1");
            picture.RemoveByArea(625);
            picture.RemoveByType(typeof(Circle));
            picture.Draw();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Painter.Draw(circle);
            Painter.Draw(quadrate);
            Painter.Draw(picture);
        }

    }

}