using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
namespace QUANLYKHACHSAN
{
    public class Database
    {
        private string connectionString =
           "Server=localhost\\SQLEXPRESS;" +
           "Database=QuanLyKhachSan;" +
           "Trusted_Connection=True;" +
           "TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
