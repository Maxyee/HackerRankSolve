using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautifulDay
{
    class Program
    {
        static int beautifulDays(int i, int j, int k)
        {

            //int finalresult = 0;
            //for (int l = i; l < j; l++)
            //{
            //    int rev = 0;

            //    int remind = l % 10;
            //    rev = (rev * 10) + remind;
            //    int zzz = l / 10;


            //    int beautiful = Math.Abs(l - zzz);

            //    if (beautiful % k == 0)
            //    {
            //        finalresult++;
            //        //l = firstvalue;
            //        rev = 0;
            //    }
            //    else
            //    {
            //        rev = 0;
            //    }
            //}
            //return finalresult;

            int finalresult = 0;
            for (int l = i; l < j; l++)
            {
                int left = l;
                int rev = 0;
                while (left>0)
                {
                    int r = left%10;
                    rev = (rev * 10) + r;
                    left = left / 10;
                }
                int reversevalue = rev;

                int beautiful = Math.Abs(l - reversevalue);

                if (beautiful % k == 0)
                {
                    finalresult++;
                }
            }
            return finalresult;
        }

        static void Main(string[] args)
        {
            string[] tokens_i = Console.ReadLine().Split(' ');
            int i = Convert.ToInt32(tokens_i[0]);
            int j = Convert.ToInt32(tokens_i[1]);
            int k = Convert.ToInt32(tokens_i[2]);
            int result = beautifulDays(i, j, k);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        
    }
}
