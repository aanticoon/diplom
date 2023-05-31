using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Database;
using WinFormsApp1.Models;

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
            var result = _repository.AuthorizeUser(login, password);
            if (string.IsNullOrEmpty(result))
            {
                throw new Exception("Неправильные данные авторизации");
            }
            return result;
        }
        public List<StudentCardModel> GetStudentCards()
        {
            return _repository.GetStudentCards();
        }

        public int SaveStudentCard(StudentCardModel StudentCards)
        {
            return _repository.SaveStudentCard(StudentCards);
        }

        public void DeleteStudentCard(int studentCardId)
        {
            _repository.DeleteStudentCard(studentCardId);
        }
    }
}

