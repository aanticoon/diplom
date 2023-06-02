using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.Database
{
	public interface IRepository
	{
		string AuthorizeUser(string login, string password);
        List<StudentCardModel> GetStudentCards();

        int SaveStudentCard(StudentCardModel student_сard);

        void DeleteStudentCard(int studentCardId);

        void UpdateStudentCard(StudentCardModel student_card);
    }

}
