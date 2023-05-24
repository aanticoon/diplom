using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.Database
{
	public interface IRepository
	{
		string AuthorizeUser(string login, string password);
	}
}
