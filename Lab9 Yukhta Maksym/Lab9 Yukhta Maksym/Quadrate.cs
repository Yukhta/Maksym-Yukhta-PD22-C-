﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Quadrate : Shape, IDraw
    {
        private double sideA;
        private string name;
        public double Side
        {

            get { return sideA; }
            set
            {
                if (value <= 0)
                {
                    sideA = 1;
                }
                else
                {
                    sideA = value;
                }
            }
        }

        public override int NumOfVertices { get { return 4; } }
        public override string Name { get { return name; } }
        public override string FigureColor { get; set; }
        public Quadrate(string name, string color, double side)
        {
            this.name = name;
            FigureColor = color;
            Side = side;
        }
        public Quadrate(string name, double side)
        {
            this.name = name;
            Side = side;
            FigureColor = RandomColor.randomColor();
        }

        public Quadrate(string name)
        {
            this.name = name;
            FigureColor = RandomColor.randomColor();
            Random r = new Random();
            Side = r.Next(100);
        }

        public override double Square()
        {
            return Side * Side;
        }

        public override double Perimeter()
        {
            return 2 * (Side + Side);
        }

        public void Draw()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("Iм'я: {0}\nКолір: {1}\nСторона: {2}\nПлоща: {3}\nПериметр: {4}",
                Name, FigureColor, Side, Square(), Perimeter());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Це справді квадрат");
            Console.WriteLine("***********************************");
        }
    
}