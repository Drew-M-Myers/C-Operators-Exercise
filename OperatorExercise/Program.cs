﻿namespace OperatorExcersice
{
    internal class Program
    {
        private static double areaOfCircle;

        public static void Main(string[] args)
        {

            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4) ;

            Console.WriteLine($"The answer of {a}/{b} is {quotient} with a remainder of {remainder}");

            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());

            double AreaOfCircle = (Math.PI * radius * radius);
            Console.WriteLine($"The area of a circle with {radius} is {AreaOfCircle}");
        }

        public static double AreaOfCircle(double radius)
        {
            double areaOfCircle = (Math.PI * radius * radius);

            return radius;

        }


    }


}






