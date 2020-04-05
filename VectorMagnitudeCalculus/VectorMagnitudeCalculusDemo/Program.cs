using System;
using VectorMagnitudeCalculusCore;

namespace VectorMagnitudeCalculusDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            var point = new Point() { X = 3, Y = 5};
            var result = point.CalculateMagnitudeFromOrigin();

            Console.WriteLine($"The vector magnitude of the Point ({point.X} , {point.Y}) is {result}");
      
        }
    }
}
