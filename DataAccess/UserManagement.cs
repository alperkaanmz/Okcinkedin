using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DataAccess
{
    
    public class UserManagement
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
            "C:\\Users\\31766\\source\\repos\\Okcinkedin\\DataAccess\\MyDatabase.mdf;Integrated Security=True";

        public bool RegisterEmployer(string username, string password)
        {
            if (!IsUsernameUnique("Employers", username))
            {
                // Kullanıcı adı zaten kullanılmış
                return false;
            }

            RegisterUser("Employers", username, password);
            return true;
        }

        public bool RegisterEmployee(string username, string password)
        {
            if (!IsUsernameUnique("Employees", username))
            {
                // Kullanıcı adı zaten kullanılmış
                return false;
            }

            RegisterUser("Employees", username, password);
            return true;
        }

        public bool LoginEmployer(string username, string password)
        {
            return LoginUser("Employers", username, password);
        }

        public bool LoginEmployee(string username, string password)
        {
            return LoginUser("Employees", username, password);
        }

        private void RegisterUser(string tableName, string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = $"INSERT INTO {tableName} (Username, Password) VALUES (@Username, @Password)";

                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int rowsAffected = command.ExecuteNonQuery();
                }
            }
        }

        private bool LoginUser(string tableName, string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = $"SELECT COUNT(*) FROM {tableName} WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }
        public bool UpdateUniversity(string username, string university)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string updateQuery = "UPDATE Employees SET university = @University WHERE username = @Username";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@University", university);
                    command.Parameters.AddWithValue("@Username", username);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

        }
        public bool SaveProgrammingLanguages(string username, List<string> languages)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string insertQuery = $"INSERT INTO LanguageTable (username, language) VALUES (@Username, @Language)";

                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        foreach (string language in languages)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@Username", username);
                            command.Parameters.AddWithValue("@Language", language);

                            command.ExecuteNonQuery();
                        }

                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
                return false;
            }
        }

        private bool IsUsernameUnique(string tableName, string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string selectQuery = $"SELECT COUNT(*) FROM {tableName} WHERE Username = @Username";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

                    int count = (int)command.ExecuteScalar();
                    return count == 0;
                }
            }
        }


    }
}
