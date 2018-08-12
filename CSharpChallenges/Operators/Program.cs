using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = Convert.ToDouble(Console.ReadLine());
            int tip_percent = Convert.ToInt32(Console.ReadLine());
            int tax_percent = Convert.ToInt32(Console.ReadLine());

            double tip = meal_cost*tip_percent/100;
            double tax = meal_cost*tax_percent/100;

            double totalCost = meal_cost + tip + tax;
            int i  = (int)Math.Round(totalCost);

            Console.WriteLine("The total meal cost is " + i + " dollars.");
            Console.ReadKey();

        }
    }
}
