using Dapper;
using WinFormsApp1.Models;
using System.Linq;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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

                return user?.FName == null || user?.Patronymic == null ? null : $"{user.FName} {user.Patronymic}";
            }
        }
        public List<StudentCardModel> GetStudentCards()
        {
            using (var conn = Connection)
            {
                conn.Open();
                var student_сard = conn.Query<StudentCardModel>($@"
select _id, Group_id, Sname, Fname, Lname, BDate, gender, Addres, Phone, Email, hometown, residence, Character 
from StudentCards");
                return student_сard.ToList();
            }
        }

        public int SaveStudentCard(StudentCardModel StudentCards)
        {
            using (var conn = Connection)
            {
                conn.Open();
                var query = $@"
insert into StudentCards (Group_id, Sname, Fname, Lname, BDate, gender, Addres, Phone, Email, hometown, residence, Character)
values (@Fname, @Sname, @Lname, @BDate, @gender, @Addres, @Phone, @Email, @hometown, @residence, @Character);
SELECT CAST(SCOPE_IDENTITY() as int)";

                return conn.QueryFirst<int>(query,
                    new
                    {
                        Fname = StudentCards.Fname,
                        Sname = StudentCards.Sname,
                        Lname = StudentCards.Lname,
                        BDate = StudentCards.BDate,
                        gender = StudentCards.gender,
                        Addres = StudentCards.Addres,
                        Phone = StudentCards.Phone,
                        Email = StudentCards.Email,
                        hometown = StudentCards.hometown,
                        residence = StudentCards.residence,
                        Character = StudentCards.Character
                    });
            }
        }

        public void DeleteStudentCard(int studentCardId)
        {
            using (var conn = Connection)
            {
                conn.Open();
                var query = $@"
delete from StudentCards
where Id = @id";

                conn.Execute(query, new { id = studentCardId });
            }

        }
    }
}