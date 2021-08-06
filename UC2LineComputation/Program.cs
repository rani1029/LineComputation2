using System;

namespace UC2LineComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the co ordinates of line one");
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            Console.WriteLine("enter the co ordinates of second line");
            double x3 = double.Parse(Console.ReadLine());
            double x4 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double y4 = double.Parse(Console.ReadLine());
            double l1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double l2 = Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2));
            Console.WriteLine("lenth of of first line =" + l1);

            Console.WriteLine("lenth of of second line =" + l2);
            Console.WriteLine("is lenth of two lines equal " + l1.Equals(l2));


        }
    }
}
