using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumDraws
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int N = Convert.ToInt32(Console.ReadLine());
                int M = N + 1;
                Console.WriteLine(""+M);              
            }
        }
    }
}
