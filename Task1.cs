using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "vinith";
            DateOnly dob = new DateOnly(2004, 4, 20);
            int age = 22;
            string country = "India";
            string state = "Tamil nadu";
            string city = "Chennai";
            int mark = 460;
            bool status = true;
            Console.WriteLine("=================================");
            Console.WriteLine("       STUDENT DETAILS          ");
            Console.WriteLine("=================================");
            Console.WriteLine("Name:    "+ name);
            Console.WriteLine("DOB:     "+ dob);
            Console.WriteLine("Age:     "+ age);
            Console.WriteLine("Country: "+ country);
            Console.WriteLine("State    "+ state);
            Console.WriteLine("City:    "+ city);
            Console.WriteLine("Mark:    "+ mark);
            Console.WriteLine("Status:  "+ status);
            Console.WriteLine("=================================");
            Console.Write("Press any key to exit... ");
            Console.ReadKey();
        }
    }
}