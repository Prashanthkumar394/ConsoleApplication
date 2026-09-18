using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Console.WriteLine("Printing using while");
            while(i>0)
            {
                Console.Write(i+" ");
                i--;
            }
            Console.WriteLine("\n\nPriting using do-while");
            i = 10;
            do
            {
                Console.Write(i+" ");
                i--;
            } while(i>0);
            Console.WriteLine("\n\nPrinting using for");
            i=1;
            for(int j=1; j<=10; j++)
            {
                Console.Write(i+" ");
                i++;
            }
        }
    }
}