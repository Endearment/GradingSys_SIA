using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace GradingSys_SIA.Helpers
{
    public static class DatabaseHelper
    {
        private static string connStr = "server=localhost;user id=root;password=;database=grade_sia";

        public static int GetAttendanceDays(int studentId, string term)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string query = "SELECT days_present FROM attendance WHERE student_id = @id AND term = @term";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", studentId);
            cmd.Parameters.AddWithValue("@term", term);

            object result = cmd.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public static int GetAptitudeDemerits(int studentId, string term)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string query = "SELECT demerits FROM aptitude WHERE student_id = @id AND term = @term";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", studentId);
            cmd.Parameters.AddWithValue("@term", term);

            object result = cmd.ExecuteScalar();
            return result != null ? Convert.ToInt32(result) : 0;
        }

        public static (int Score, int TotalItems) GetExamData(int studentId, string term)
        {
            using var conn = new MySqlConnection(connStr);
            conn.Open();

            string query = "SELECT score, total_items FROM exam WHERE student_id = @id AND term = @term";
            using var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", studentId);
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
