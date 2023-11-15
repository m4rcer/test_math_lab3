using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace math_lab3
{
   
    class Program
    {
         static void Main(string[] args)
        {
            /*double[] xs1 = new double[] { 1, 3, 6, 8 };
            double[] ys1 = new double[] { 2, 4, 1, 6 };*/
            var points = new List<MyPoint> { new MyPoint(1, 2), new MyPoint(2, 3), new MyPoint(4, 1), new MyPoint(7, 4) };

            var result = Cubic.InterpolateXY(points.ToArray(), 100);

            Console.WriteLine("");
        }
    }
}