using System;

namespace Task6
{
    class Program
    {
        static void Main(String[] args)
        {
            int i = 0;
            Console.WriteLine("Printing using while");
            while(i<10)
            {
                i++;
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Printing using do-while");
            i = 0;
            do
            {
                i++;
                Console.Write(i+" ");
            } while(i<10);
            i=0;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Printing using for");
            for(int j=1; j<=10; j++)
            {
                i++;
                Console.Write(i+" ");
            }
        }
    }
}