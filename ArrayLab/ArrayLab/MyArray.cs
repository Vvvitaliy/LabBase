using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayLab
{
    class MyArray
    {
        public static int[] Initialise(int length)
        {
            int[] array = new int[length];
            Random random = new Random();

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(0, 100);
            }

            return array;
        }

        public static void Sort(int[] array)
        {
            Array.Sort(array);
        }

        public static void Show(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("");
        }
    }
}
