using System;

namespace UC1LineComputation
{
    class Program
    {
        static void Main(String[] args)
        {


            Console.WriteLine("Enter the co ordinates of line");
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double l = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("lenth of of line =" + l);








        }
    }
}
