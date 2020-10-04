using System;

namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Line line1 = new Line();
            Line line2 = new Line();
            Console.WriteLine("Welcome to Line Comparison Computation Program\n");
            

            // Length calculation of first line
            Console.WriteLine("Enter the X and Y coordinates of end points of the first line");
            line1.calculateLength();

            // Length calculation of second line
            Console.WriteLine("\nEnter the X and Y coordinates of end points of the second line");
            line2.calculateLength();

            //Equality check of both lines
            Console.WriteLine("\nEquality check of both lines:");
            line1.checkEquality(line1, line2);

            //Line comparison
            Console.WriteLine("\nLine comparison:");
            line1.compareLines(line1, line2);

            Console.ReadKey();
        }
    }
}
