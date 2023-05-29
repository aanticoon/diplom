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
                conn.Open();
				var user = conn.QueryFirstOrDefault<AuthModel>(
@$"select
	FName {nameof(AuthModel.FName)},
	Patronymic {nameof(AuthModel.Patronymic)}
	from users
	where login = @login and password = @password",
	new { login, password });

                return user?.FName == null || user?.Patronymic == null ?  null : $"{user.FName} {user.Patronymic}";
            }
		}
	}
}
