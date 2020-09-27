using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation Program"+"\n");
            Console.WriteLine("Enter the X and Y coordinates of end points of the line");
            double pointX1= Convert.ToDouble(Console.ReadLine());
            double pointY1= Convert.ToDouble(Console.ReadLine());
            double pointX2= Convert.ToDouble(Console.ReadLine());
            double pointY2 = Convert.ToDouble(Console.ReadLine());

            double powerX = Math.Pow(pointX2 - pointX1, 2);
            double powerY= Math.Pow(pointY2 - pointY1, 2);
            double lineLength = Math.Sqrt(powerX + powerY);
            Console.WriteLine("Length of line= "+lineLength);
        }
    }
}
