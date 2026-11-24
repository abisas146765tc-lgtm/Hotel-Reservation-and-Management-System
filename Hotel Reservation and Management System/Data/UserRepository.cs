using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hotel_Reservation_and_Management_System.Models.User;
using Microsoft.Data.SqlClient;

namespace Hotel_Reservation_and_Management_System.Data
{
    public static class UserRepository
    {
        public static User? Authenticate(string username, string password)
        {
            using var connection = Database.GetConnection();
            using var command = new SqlCommand(
                "SELECT UserId, PasswordHash, Role FROM Users WHERE Username = @u AND  IsActive = 1", connection);
            command.Parameters.AddWithValue("@u", username);

            connection.Open();
            using var reader = command.ExecuteReader();

            if (!reader.Read()) return null;
            if(!BCrypt.Net.BCrypt.Verify(password, reader.GetString(1))) return null;

            return new User
            {
                UserId = reader.GetInt32(0),
                Username = username,
                Role = reader.GetString(2)
            };
        }

        public static void CreateUser(string username, string password, string role)
        {
            using var connection = Database.GetConnection();
            using var command = new SqlCommand(
                "INSERT INTO Users (Username, PasswordHash, Role) VALUES (@u, @p, @r)",connection);
            command.Parameters.AddWithValue("@u", username);
            command.Parameters.AddWithValue("@p", BCrypt.Net.BCrypt.HashPassword(password));
            command.Parameters.AddWithValue("@r", role);

            connection.Open();
            command.ExecuteNonQuery();
        }

        public static void EnsureDefaultAdmin()
        {
            using var connection = Database.GetConnection();
            connection.Open();
            using var check = new SqlCommand("SELECT COUNT(*) FROM Users", connection);
            if ((int)check.ExecuteScalar()! > 0) return;

            CreateUser("admin", "admin123", "Manager");
        }
    }
}
