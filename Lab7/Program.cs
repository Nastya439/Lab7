using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = 1;

            for (int a = 1; a < 4; a++)
            {
                double s = 0;

                for (int b = 1; b < 11; b++)
                {
                    s += Math.Log10(a) + b / 2;
                }
                p *= s;
            }

            Console.WriteLine(p);
        }
    }
}