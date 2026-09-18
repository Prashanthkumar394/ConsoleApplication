using System;
using Npgsql;

class Program
{
    static string connectionString =
        "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres";

    static void Main()
    {
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
                    AddCountry();
                    break;

                case 2:
                    ViewCountries();
                    break;

                case 3:
                    UpdateCountry();
                    break;

                case 4:
                    DeleteCountry();
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

    static void AddCountry()
    {
        Console.Write("Enter country name: ");
        string name = Console.ReadLine();

        using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
        {
            con.Open();

            string query =
                "INSERT INTO country_master (country_name) " +
                "VALUES (@name)";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@name", name);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    Console.WriteLine("Country added successfully.");
            }
        }
    }

    static void ViewCountries()
    {
        using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
        {
            con.Open();

            string query =
                "SELECT country_id, country_name " +
                "FROM country_master ORDER BY country_id";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
            {
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    Console.WriteLine("\nID\tCountry");
                    Console.WriteLine("-----------------");

                    while (reader.Read())
                    {
                        Console.WriteLine(
                            reader["country_id"] + "\t" +
                            reader["country_name"]);
                    }
                }
            }
        }
    }

    static void UpdateCountry()
    {
        Console.Write("Enter country ID to update: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter new country name: ");
        string name = Console.ReadLine();

        using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
        {
            con.Open();

            string query =
                "UPDATE country_master " +
                "SET country_name = @name " +
                "WHERE country_id = @id";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@id", id);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    Console.WriteLine("Country updated successfully.");
                else
                    Console.WriteLine("Country ID not found.");
            }
        }
    }

    static void DeleteCountry()
    {
        Console.Write("Enter country ID to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());

        using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
        {
            con.Open();

            string query =
                "DELETE FROM country_master WHERE country_id = @id";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@id", id);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    Console.WriteLine("Country deleted successfully.");
                else
                    Console.WriteLine("Country ID not found.");
            }
        }
    }
}