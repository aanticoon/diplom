using Dapper;
using WinFormsApp1.Models;

namespace WinFormsApp1.Database
{
	public class Repository : BaseRepository, IRepository
	{
		public string AuthorizeUser(string login, string password)
		{
//			using (var conn = Connection)
//			{
//				conn.Open();
//				var authorizedUser = conn.QueryFirst<AuthModel>(
//@$"select
//	name {nameof(AuthModel.Name)},
//	surname {nameof(AuthModel.Surname)},
//from qwe
//where login = @login and password = @password",
//new { login, password });

//				return $"{authorizedUser.Name} {authorizedUser.Surname}";
//			}

			var random = new Random();
			if (random.NextInt64() % 2 != 0)
			{
				throw new Exception("Введены неверные логин/пароль!");
			}
			return "Василий";
		}
	}
}
