using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Database
{
    public class BaseRepository
    {
        private readonly string _connectionString = "Server=DESKTOP-VG9G9E1;database=Journal;Integrated Security=True;";

        protected BaseRepository()
        {
        }

        protected IDbConnection Connection => new SqlConnection(_connectionString);
    }
}
