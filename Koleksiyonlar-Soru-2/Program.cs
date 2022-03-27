using System;

namespace koleksiyonlar_soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[20];

            for (int i = 0; i < 20; i++)
                arr[i] = int.Parse(Console.ReadLine()!);

            Array.Sort(arr);

            int[] arr_min = new int[3];
            int[] arr_max = new int[3];

            for(int i = 0; i < 3; i++)
            {
                arr_min[i] = arr[(arr.Count()-1) - i];
                arr_max[i] = arr[i];
            }

            Console.WriteLine("Average of minimum 3 numbers of array: {0}", arr_min.Average());
            Console.WriteLine("Average of maximum 3 numbers of array: {0}", arr_max.Average());
            Console.WriteLine("Sum of these average values {0}", arr_min.Average() + arr_max.Average());
        }
    }
}