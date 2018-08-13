using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecoundLargeValue
{
    class SecoundLarge
    {
        static void Main(string[] args)
        {
            int size;
            Console.WriteLine("Enter the size of the array");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];

            for (int i = 0; i<size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int length = arr.Length;

            SecoundLarge secound = new SecoundLarge();
            secound.SecoundlargeValue(arr, length);

            Console.ReadKey();

        }

        private void SecoundlargeValue(int[] arr, int length)
        {
            int maxValue = 0;
            int secondMaxValue = 0;

            for(int i = 0; i < length; i++)
            {
                if(arr[i] > maxValue)
                {
                    secondMaxValue = maxValue;
                    maxValue = arr[i];
                }
                else if(arr[i] > secondMaxValue)
                {
                    secondMaxValue = arr[i];
                }
            }
            Console.WriteLine("First Largest number :" + maxValue);
            Console.WriteLine("Second Largest number :" + secondMaxValue);
            Console.ReadLine();
        }
    }
}
