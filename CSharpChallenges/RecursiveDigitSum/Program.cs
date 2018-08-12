using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveDigitSum
{
    class Program
    {
        static int digitSum(string n, int k)
        {
            int value = 0;
            for (int i = 0; i < n.Length ; i++)
            {
                value = n[i];
            }
            return value;
        }

        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            string n = tokens_n[0];
            int k = Convert.ToInt32(tokens_n[1]);
            int result = digitSum(n, k);
            Console.WriteLine(result);
        }


        
    }
}
