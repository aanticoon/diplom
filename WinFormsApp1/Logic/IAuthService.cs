using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Logic
{
	public interface IAuthService
	{
        string AuthorizeUser(string login, string password);
        List<StudentCardModel> GetStudentCards();
        int SaveStudentCard(StudentCardModel studentCard);
        void DeleteStudentCard(int studentCardId);
    }
}
