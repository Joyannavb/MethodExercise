using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    
    internal class Program
    {
        public static double AreaOfCircle(double r)
        {
            return Math.PI * (r * r);
        }
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;

            var quotient = a / b;
            var remainder = a % b;
            Console.WriteLine( $"{a}/{b} is {quotient} remainder {remainder}");

            Console.WriteLine("What is the radius of your circle?");
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine($"The are of a circle with a radius of {r} is {AreaOfCircle(r)}");


        
        
        }


    }
}
