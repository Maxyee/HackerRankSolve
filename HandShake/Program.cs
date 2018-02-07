using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandShake
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < T; a0++)
            {
                int N = Convert.ToInt32(Console.ReadLine());
                int result = N*(N - 1)/2;

                Console.WriteLine("" +result);  
            }
            Console.ReadKey();
        }
    }
}
