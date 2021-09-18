using System;

namespace MilesperGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            double miles = double.Parse(Console.ReadLine());
            Console.WriteLine("How many gallons of gas did you use?");
            double gallons = double.Parse(Console.ReadLine());
            double mpg = miles/gallons;
            Console.WriteLine(mpg+ " miles per gallon");
        }
    }
}
