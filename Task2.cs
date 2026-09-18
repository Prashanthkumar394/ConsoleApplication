using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option to perform the operation: ");
            int option = Convert.ToInt32(Console.ReadLine());
            if(option==5)
            {
                Console.WriteLine("Application exited");
                return;
            }
            Console.Write("Enter first number: ");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number: ");
            int second = Convert.ToInt32(Console.ReadLine());
            if(option == 1)
            {
                Console.WriteLine(first+second);
            }
            else if(option==2)
            {
                Console.WriteLine(first-second);
            }
            else if(option==3)
            {
                Console.WriteLine(first*second);
            }
            else if(option==4)
            {
                if(second==0)
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                else
                {
                    Console.WriteLine(first/second);
                }
            }
            else
            {
                Console.WriteLine("Invalid option selected.");
            }
            Console.Write("Press any key to exit... ");
            Console.ReadKey();
        }
    }
}