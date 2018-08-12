using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureArraySum
{
    class Program
    {
        static int simpleArraySum(int n, int[] ar)
        {
            int res = ar.Sum();
            return res;
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = simpleArraySum(n, ar);
            Console.WriteLine(result);
            //Console.ReadKey();
        }
    }
}
