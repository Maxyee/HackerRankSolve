using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDs
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            Array.Reverse(arr);
            //Console.WriteLine(string.Join(" ", arr));
            for (int i = 0; i < n; i++)
            {
                //Console.WriteLine(arr[i]);
                //Console.WriteLine(string.Join(" ", arr));
                //Console.Write("{0}", arr[i]);
                Console.Write(arr[i] + " ");
            }
            //Console.WriteLine(arr);
            Console.ReadKey();
        }
    }
}
