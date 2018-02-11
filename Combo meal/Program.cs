using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace myapp
{
    class Program
    {
        static int profit(int b, int s, int c) {
            int total = b+s;
            int result = total - c;
            return result;
        }

        static void Main(String[] args) {
            int t = Convert.ToInt32(Console.ReadLine());
            for(int a0 = 0; a0 < t; a0++){
                string[] tokens_b = Console.ReadLine().Split(' ');
                int b = Convert.ToInt32(tokens_b[0]);
                int s = Convert.ToInt32(tokens_b[1]);
                int c = Convert.ToInt32(tokens_b[2]);
                int result = profit(b, s, c);
                Console.WriteLine(result);
            }
        }
    }
}
