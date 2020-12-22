﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab9
{
    abstract class Shape
    {
        public abstract string Name { get; }
        public abstract string FigureColor { get; set; }
        public abstract int NumOfVertices { get; }
        public abstract double Square();
        public abstract double Perimeter();
        public static class RandomColor
        {
            private static Random rand = new Random();

            private static string[] colors = { "Красний", "Зелений", "Синiй", "Жовтий", "Фiолетовий" };
            public static int randomLeght() => rand.Next(1, 10);
            public static string randomColor() => colors[rand.Next(0, 4)];

        }

    }

    }
