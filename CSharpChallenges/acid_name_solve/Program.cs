using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace acid_name_solve
{
    class Program
    {
        static string acidNaming(string acid_name) 
        {
            if (acid_name.Substring(0, 5) == "hydro" && acid_name.Substring(acid_name.Length - 2) == "ic")
            {
                //Console.WriteLine("non-metal acid");
                return "non-metal acid";
            }
            else if (acid_name.Substring(acid_name.Length - 2) == "ic")
            {
                //Console.WriteLine("polyatomic acid");
                return "polyatomic acid";
            }
            else
            {
                //Console.WriteLine("not an acid");
                return "not an acid";
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < n; a0++)
            {
                string acid_name = Console.ReadLine();
                string result = acidNaming(acid_name);
                Console.WriteLine(result);
            }
        }
    }
}
