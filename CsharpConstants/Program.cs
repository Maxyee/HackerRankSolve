using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConstants
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1416;

            double r;
            Console.WriteLine("Enter Radius value: ");
            r = Convert.ToDouble(Console.ReadLine());
            double areaCircle = pi*r*r;

            Console.WriteLine("Radius: {0}, Area:{1}", r, areaCircle);
            Console.ReadKey();
        }
    }
}
