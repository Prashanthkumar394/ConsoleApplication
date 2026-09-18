using System;

namespace Task10
{
    class Program
    {
        static void Main(String[] args)
        {
            int i = 1;
            Console.WriteLine("Printing using while ignoring 5");
            while(i<=10)
            {
                if(i==5)
                {
                    i++;
                    continue;
                }
                Console.Write(i+" ");
                i++;
            }
            Console.WriteLine("\n\nPrinting using do-while ignoring 5");
            i=1;
            do
            {
                if(i==5)
                {
                    i++;
                    continue;
                }
                Console.Write(i+" ");
                i++;
            } while(i<=10);
            Console.WriteLine("\n\nPrinting using for ignoring 5");
            i=1;
            for(int j=1; j<=10; j++)
            {
                if(j==5)
                {
                    i++;
                    continue;
                }
                Console.Write(i+" ");
                i++;
            }
        }
    }
}