﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    static class Painter
    {
        public static void Draw(IDraw shape)
        {
            shape.Draw();
        }
    }
}