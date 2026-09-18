using System;
using Npgsql;

class CountryRepository
{
    private string connectionString =
        "Host=localhost;Port=5432;Database=postgres;Username=postgres;Password=postgres";

    // CREATE
    public void AddCountry(string name)
    {
        using (NpgsqlConnection con = new NpgsqlConnection(connectionString))
        {
            con.Open();

            string query =
                "INSERT INTO country_master (country_name) VALUES (@name)";

            using (NpgsqlCommand cmd = new NpgsqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@name", name);

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                    Console.WriteLine("Country added successfully.");
            }
        }
    }

    // READ
    public void ViewCountries()
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

    // UPDATE
    public void UpdateCountry(int id, string name)
    {
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

    // DELETE
    public void DeleteCountry(int id)
    {
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