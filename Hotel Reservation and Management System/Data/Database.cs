using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;


namespace Hotel_Reservation_and_Management_System.Data
{
    public static class Database
    {
        private const string ConnectionString = "Server=DESKTOP-RMHDDFB\\SQLEXPRESS;Database=HotelDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
