﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnderstandingInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "BMW";
            myCar.Model = "745li";
            myCar.Color = "Black";
            myCar.Year = 2005;

            someMethod(myCar);
            
            //myCar.PrintMe();

            Console.ReadLine();
        }

        private static void someMethod(Car car)
        {
            Console.WriteLine("From someMethod: {0}", car.Make);
        }

    }

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public void PrintMe()
        {
            Console.WriteLine("{0} - {1}", this.Make, this.Model);
        }

    }

}
