using System;

namespace Task5
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.Write("Enter total no. of inputs: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int a = 0;
            for(int i=0; i<arr.Length; i++)
            {
                if(arr[i]>a)
                    a =  arr[i];
            }
            Console.Write("The largest no. is: "+a);
        }
    }
}