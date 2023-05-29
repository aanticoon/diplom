using Dapper;
using WinFormsApp1.Models;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace WinFormsApp1.Database
{
	public class Repository : BaseRepository, IRepository
	{
		public string AuthorizeUser(string login, string password)
		{
			using (var conn = Connection)
			{
                SqlConnection connection = new SqlConnection("server=DESKTOP-VG9G9E1;database=Journal;Integrated Security=True;");
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                conn.Open();
				var user = conn.QueryFirst<AuthModel>(
@$"select
	Fname {nameof(AuthModel.FName)},
	Patronymic {nameof(AuthModel.Patronymic)}
from users
where login = @login and password = @password",
new { login, password });

				return $"{user.FName} {user.Patronymic}";
			}

		}
	}
}
