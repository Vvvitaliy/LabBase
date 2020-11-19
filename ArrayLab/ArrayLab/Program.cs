using System;

namespace ArrayLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = MyArray.Initialise(10);
            MyArray.Show(array);

            MyArray.Sort(array);
            MyArray.Show(array);
        }
    }
}
