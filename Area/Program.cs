using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = Math.PI;

            Console.WriteLine("Enter a radius: ");
            double r = double.Parse(Console.ReadLine());
            //var r = Convert.ToInt32(Console.ReadLine());
            double a = pi * (r * r);

            Console.WriteLine($"The area of a circle with radius {r} is: {a}");
            Console.ReadLine();
        }
    }
}
