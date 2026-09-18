using System;

class Program
{
    static void Main()
    {
        CountryRepository dal = new CountryRepository();

        while (true)
        {
            Console.WriteLine("\n===== COUNTRY MASTER =====");
            Console.WriteLine("1. Add Country");
            Console.WriteLine("2. View Countries");
            Console.WriteLine("3. Update Country");
            Console.WriteLine("4. Delete Country");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter country name: ");
                    string name = Console.ReadLine();

                    dal.AddCountry(name);
                    break;

                case 2:
                    dal.ViewCountries();
                    break;

                case 3:
                    Console.Write("Enter country ID to update: ");
                    int updateId = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Enter new country name: ");
                    string newName = Console.ReadLine();

                    dal.UpdateCountry(updateId, newName);
                    break;

                case 4:
                    Console.Write("Enter country ID to delete: ");
                    int deleteId = Convert.ToInt32(Console.ReadLine());

                    dal.DeleteCountry(deleteId);
                    break;

                case 5:
                    Console.WriteLine("Application closed.");
                    return;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}