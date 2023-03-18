using System;
namespace NumberLineJumpsKangaroo;
class Program
{
    static void Main(string[] args)
    {
        string[] x1V1X2V2 = Console.ReadLine().Split(' ');
        int x1 = int.Parse(x1V1X2V2[0]);
        int v1 = int.Parse(x1V1X2V2[1]);
        int x2 = int.Parse(x1V1X2V2[2]);
        int v2 = int.Parse(x1V1X2V2[3]);

        if (v1 == v2)
        {
            Console.WriteLine(x1 == x2 ? "YES" : "NO");
        }
        else
        {
            int jumps = (x2 - x1) % (v1 - v2) == 0 && (x2 - x1) / (v1 - v2) > 0 ? 1 : 0;
            Console.WriteLine(jumps == 1 ? "YES" : "NO");
        }
    }
}



