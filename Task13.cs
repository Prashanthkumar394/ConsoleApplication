using System;

namespace Task3
{
    class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. Swap two Integers using Generic Function\n6. Swap two Decimals using Generic Function");
            Console.Write("Choose an option from above: ");
            string option = Console.ReadLine();
            int first = 0, second = 0;
            if(option!="6")
            {
                Console.Write("Enter first no.: ");
                first = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second no.: ");
                second = Convert.ToInt32(Console.ReadLine());
            }
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
                        Console.WriteLine("Division with zero is not allowed");
                    else
                        Console.WriteLine(first/second);
                    break;
                case "5":
                    Swap<int>(ref first, ref second);
                    Console.WriteLine(first+" "+second);
                    break;
                case "6":
                    Console.Write("Enter first no.: ");
                    decimal x = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Enter second no.: ");
                    decimal y = Convert.ToDecimal(Console.ReadLine());
                    Swap<decimal>(ref x, ref y);
                    Console.WriteLine(x+" "+y);
                    break;
            }
        }
    }
}