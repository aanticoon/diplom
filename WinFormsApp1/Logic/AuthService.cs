using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Database;

namespace WinFormsApp1.Logic
{
	public class AuthService : IAuthService
	{
		private readonly IRepository _repository;
		public AuthService(IRepository repository)
		{
			_repository = repository;
		}

		public string AuthorizeUser(string login, string password)
		{
			return _repository.AuthorizeUser(login, password);
		}
	}
}
