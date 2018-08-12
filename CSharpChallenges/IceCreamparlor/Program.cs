using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Hosting;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamparlor
{
    class Program
    {
        static int[] icecreamParlor(int m, int[] arr ,int n)
        {
            //int rock = arr[0];
            //int arektaresult = Array.IndexOf(arr, rock) + 1;
            //int game = 0;

            //int result = 0;

            //for (int i = 1; i < n; i++)
            //{
            //    game = rock + arr[i];

            //    if (game == m)
            //    {
            //        result = i + 1;
            //    }
            //}

            //int[] arr_temp;

            //if (arektaresult < result)
            //{
            //    arr_temp = new int[] { arektaresult, result };
            //}
            //else
            //{
            //    arr_temp = new int[] { result, arektaresult };
            //}
            //return arr_temp;

            int value1 = 0;

            int result = 0;
            int result2 = 0;

            int[] arrresult;
            for (int i = 1; i <= n; i++)
            {       
                for (int j = 1; j <= n; j++)
                {
                    //int check = arr[j - 1];

                    value1 = arr[i-1] + arr[j];

                    if (value1 == m)
                    {
                        result = j+1;
                        result2 = i;
                        break;
                    }
                }
                break;
            }

            if (result < result2)
            {
                arrresult = new[] {result, result2};
            }
            else
            {
                arrresult = new[] {result2, result};
            }

            return arrresult;
        }

        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                int n = Convert.ToInt32(Console.ReadLine());
                string[] arr_temp = Console.ReadLine().Split(' ');
                int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
                int[] result = icecreamParlor(m, arr, n);
                Console.WriteLine(String.Join(" ", result));
            }
        }
    }
}
