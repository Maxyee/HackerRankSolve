using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6LetsReview
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            for (int test = 0; test < n; test++)
            {
                string s = Console.ReadLine();

                //string test = "Hacker";


                for (int i = 0; i < s.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(s[i]);
                    }
                }

                for (int j = 0; j < s.Length; j++)
                {
                    if (j % 2 == 1)
                    {
                        Console.Write(s[j]);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
