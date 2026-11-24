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
        private const string ConnectionString = "Server=(localdb)\\MSSQLLocalDB;Database=HotelDB;Trusted_Connection=true;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
