using System;

namespace Task17
{
    class Program
    {
        static int Add(int a, int b)
        {
            return a+b;
        }
        static int Add(int a, int b, int c)
        {
            return a+b+c;
        }
        static void Main(String[] args)
        {
            bool flag = true;
            while(flag)
            {
                Console.Write("1. Addition of 2 nos.\n2. Addition of 3 nos.\n3. Exit app\nChoose an option: ");
                String option = Console.ReadLine();
                
                switch(option)
                {
                    case "1":
                        Console.Write("Enter first no.: ");
                        int first = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter second no.: ");
                        int second = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Add(first, second)+"\n");
                        break;
                    case "2":
                        Console.Write("Enter first no.: ");
                        first = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter second no.: ");
                        second = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter third no.: ");
                        int third = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Add(first, second, third)+"\n");
                        break;
                    case "3":
                        flag = false;
                        Console.WriteLine("Application Exited...");
                        break;
                }
            }
        }
    }
}