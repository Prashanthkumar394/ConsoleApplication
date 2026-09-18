using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division");
            Console.Write("Choose an option from above: ");
            string option = Console.ReadLine();
            int first = 0, second = 0;
            Console.Write("Enter first no.: ");
            first = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second no.: ");
            second = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case "1": 
                    Console.Write("Enter first no.: ");
                    Console.WriteLine(first+second);
                    break;
                case "2":
                    Console.WriteLine(first-second);
                    break;
                case "3":
                    Console.WriteLine(first*second);
                    break;
                case "4":
                    if(second==0)
                        Console.WriteLine("cannot divide by zero");
                    else
                        Console.WriteLine(first/second);
                    break;
            }
        }
    }
}