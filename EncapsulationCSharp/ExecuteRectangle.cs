using System;

namespace EncapsulationCSharp
{
    class ExecuteRectangle
    {
        public static void Main(string[] args)
        {
            Rectangle maxyee = new Rectangle();
            maxyee.length = 10.5;
            maxyee.width = 20.5;
            maxyee.Display();
            Console.ReadKey();
        }
    }
}
