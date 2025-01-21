using MySql.Data.MySqlClient;

namespace app_allenamenti
{
    public static class Database
    {
        private static string ConnectionString = "Server=localhost;Database=fitness_tracker;Uid=root;Pwd=;";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }


    }
}
