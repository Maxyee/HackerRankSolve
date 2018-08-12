using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String");
            string str = Console.ReadLine();

            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (result == string.Empty)
                {
                    result = result + str[i];
                }
                else
                {
                    for (int j = 0; j < result.Length ; j++)
                    {
                        if (str[i] != str[j])
                        {
                            result = result + str[i];
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
