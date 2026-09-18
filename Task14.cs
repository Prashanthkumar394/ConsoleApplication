using System;

namespace Task14
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Reactangle : Shape
    {
        double l;
        double b;
        public Reactangle(double l, double b)
        {
            this.l = l;
            this.b = b;
        }
        public override double CalculateArea()
        {
            return l*b;
        }
    }
    class Circle : Shape
    {
        double r;
        public Circle(double r)
        {
            this.r = r;
        }
        public override double CalculateArea()
        {
            return 3.14 * r * r;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("============================");
                Console.WriteLine("      Area Calculator       ");
                Console.WriteLine("============================");
                Console.Write("1. Circle\n2. Reactangle\n3. Exit app\nChoose an option to calculate area: ");
                String option = Console.ReadLine();
                switch(option)
                {
                    case "1":
                        Console.Write("Enter the radius: ");
                        double r = Convert.ToDouble(Console.ReadLine());
                        Shape shape = new Circle(r);
                        Console.WriteLine(shape.CalculateArea()+"\n");
                        break;
                    case "2": 
                        Console.Write("Enter length: ");
                        double l = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Enter breadth: ");
                        double b = Convert.ToDouble(Console.ReadLine());
                        shape = new Reactangle(l, b);
                        Console.WriteLine(shape.CalculateArea()+"\n");
                        break;
                    case "3":
                        Console.WriteLine("App exited...");
                        flag = false;
                        break;
                }
            }
        }
    }
}