﻿using System;

namespace Enums {
    class Program {
        static void Main(string[] args) {
            Day day = Day.Sun;
            int i = 3;
            Day day3 = (Day)i;
            Console.WriteLine(day3);
        }
    }
}
