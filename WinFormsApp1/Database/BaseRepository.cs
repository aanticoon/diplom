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
        private readonly string _connectionString = "Data Source=(localdb)\\LocalDB;Initial Catalog=dbName;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        protected BaseRepository()
        {
        }

        protected IDbConnection Connection => new SqlConnection(_connectionString);
    }
}
