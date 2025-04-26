using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace GradingSys_SIA.Helpers
{
    public static class DatabaseHelper
    {
        private static readonly string cisDbConnStr = "server=localhost;user id=root;password=;database=cis_db";
        private static readonly string gradingDbConnStr = "server=localhost;user id=root;password=;database=grading_db";

       

        private static MySqlConnection GetCisDbConnection()
        {
            return new MySqlConnection(cisDbConnStr);
        }

        private static MySqlConnection GetGradingDbConnection()
        {
            return new MySqlConnection(gradingDbConnStr);
        }



        public static string GetCadetName(string cadetId)
        {
            using var conn = new MySqlConnection(cisDbConnStr);
            conn.Open();

            string query = "SELECT last_name, first_name, middle_name FROM cadet_info WHERE cadet_id = @cadetId";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cadetId", cadetId);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                string lastName = reader["last_name"].ToString();
                string firstName = reader["first_name"].ToString();
                string middleName = reader["middle_name"].ToString();
                return $"{lastName}, {firstName} {middleName}";
            }

            return string.Empty;
        }




        public static int GetAttendanceDays(string cadetId, string term)
        {
            using var conn = GetCisDbConnection();
            conn.Open();

            string query = "SELECT days_present FROM attendance WHERE cadet_id = @cadetId AND term = @term";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cadetId", cadetId);
            cmd.Parameters.AddWithValue("@term", term);

            object result = cmd.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : 0;
        }

        

        public static int GetAptitudeDemerits(string cadetId)
        {
            using var conn = GetGradingDbConnection();
            conn.Open();

            string query = "SELECT Total_Demerits FROM aptitude WHERE Student_ID = @cadetId";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cadetId", cadetId);

            object result = cmd.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : 0;
        }

        

        public static (int Score, int TotalItems) GetExamData(string cadetId, string term)
        {
            using var conn = GetCisDbConnection();
            conn.Open();

            string query = "SELECT score, total_items FROM exam WHERE cadet_id = @cadetId AND term = @term";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@cadetId", cadetId);
            cmd.Parameters.AddWithValue("@term", term);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return (reader.GetInt32(0), reader.GetInt32(1));
            }

            return (0, 0);
        }
    }
}
