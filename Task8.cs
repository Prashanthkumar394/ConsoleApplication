using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 3, 4, 5};
            int sum = 0;
            for(int i=0; i<arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.Write("Sum and Average of these no.: ");
            for(int i=0; i<arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("\nSum: "+sum);
            Console.Write("Averge: "+sum/arr.Length);
        }
    }
}