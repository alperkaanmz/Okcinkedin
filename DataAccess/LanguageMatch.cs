using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class LanguageMatch
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
            "C:\\Users\\31766\\source\\repos\\Okcinkedin\\DataAccess\\MyDatabase.mdf;Integrated Security=True";
        public List<Employee> GetMatchingEmployees(List<string> selectedLanguages)
        {
            List<string> matchingUsernames = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string placeholders = string.Join(",", selectedLanguages.Select((lang, index) => $"@lang{index}"));
                string languagesParameter = string.Join(",", selectedLanguages.Select((lang, index) => $"'{lang}'"));
                string selectQuery = $"SELECT DISTINCT username FROM LanguageTable WHERE language IN ({placeholders})";

                using (SqlCommand command = new SqlCommand(selectQuery, connection))
                {
                    for (int i = 0; i < selectedLanguages.Count; i++)
                    {
                        command.Parameters.AddWithValue($"@lang{i}", selectedLanguages[i]);
                    }

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string username = (string)reader["username"];
                            matchingUsernames.Add(username);
                        }
                    }
                }
            }

            List<Employee> matchingEmployees = new List<Employee>();

            if (matchingUsernames.Count > 0)
            {
                string placeholders = string.Join(",", matchingUsernames.Select((name, index) => $"@username{index}"));
                string selectEmployeesQuery = $"SELECT * FROM Employees WHERE Username IN ({placeholders})";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(selectEmployeesQuery, connection))
                    {
                        for (int i = 0; i < matchingUsernames.Count; i++)
                        {
                            command.Parameters.AddWithValue($"@username{i}", matchingUsernames[i]);
                        }

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string username = (string)reader["Username"];
                                string university = reader["University"] != DBNull.Value ? (string)reader["University"] : "";

                                Employee employee = new Employee(username, university);
                                matchingEmployees.Add(employee);
                            }
                        }
                    }
                }
            }

            return matchingEmployees;
        }


    }
}
