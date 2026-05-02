using System.Data;
using Microsoft.Data.SqlClient;
using Pokemon_Connection;


Console.WriteLine("This is a connection to my Pokedatabase");
Console.WriteLine("Let's start");
string connectionString = @"Data Source=localhost\SQLEXPRESS05;Initial Catalog=POKEMON;Persist Security Info=True;User ID=sa;Password=911896;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;Packet Size=4096;Command Timeout=0";

List<Pokemon> pokemons = new List<Pokemon>();

try
{
    using (SqlConnection connection = new SqlConnection(connectionString))
    {

        SqlCommand command = connection.CreateCommand();

        command.CommandText = "SELECT * FROM Pokemon";

        connection.Open();

        using (SqlDataReader reader = command.ExecuteReader())
        {
            while (reader.Read())
            {
               Console.WriteLine(@"{0}, {1}, {2}, {3}, {4}, {5}, {6}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);

               Pokemon pokemon = new Pokemon
               {
                   id = reader.GetInt32(0),
                   name = reader.GetString(1),
                   base_experience = reader.GetInt32(2),
                   height = reader.GetInt32(3),
                   is_default = reader.GetBoolean(4),
                   order = reader.GetInt32(5),
                   weight = reader.GetInt32(6)

               };

               pokemons.Add(pokemon);
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}