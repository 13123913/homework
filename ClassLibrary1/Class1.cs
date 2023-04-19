using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunc
{
    public class Class1
    {
        public static void SumFunc(double x, double y)
        {
            double Cul = x * y + 2 * x;
            double Sum = x + y;
            double Mult = x * y;
            Console.WriteLine("Amount = {0} Multiply = {1} Cult = {2}", Sum, Mult, Cul);
            Console.ReadLine();
        }
    }
}
