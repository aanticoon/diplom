using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Models;

namespace WinFormsApp1.Forms
{
    public partial class StudentCardForm : Form
    {
        private List<StudentCardModel> studentCards = new List<StudentCardModel>
        {
            new StudentCardModel
            {
                Id = 1,
                Name = "Егор",
                Description = "qweqweqwe",
                Email = "qwe@qwe.com"
            },
            new StudentCardModel
            {
                Id = 2,
                Name = "Василий",
                Description = "asdasdasd",
                Email = "qw111e@qwe.com"
            },
            new StudentCardModel
            {
                Id = 3,
                Name = "Глеб",
                Description = "zxczxczxc",
                Email = "qweаааа@qwe.com"
            }
        };

        private BindingList<StudentCardModel> bindingList;

        public StudentCardForm()
        {
            InitializeComponent();

            bindingList = new BindingList<StudentCardModel>(studentCards);
            var source = new BindingSource(bindingList, null);

            studentsTable.DataSource = source;
            studentsTable.ForeColor = Color.Black;
        }

        private void studentsTable_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            bindingList.Add(new StudentCardModel
            {
                Id = (int)e.Row.Cells[0].Value,
                Name = (string)e.Row.Cells[1].Value,
                Description = (string)e.Row.Cells[2].Value,
                Email = (string)e.Row.Cells[3].Value
            });
        }

        private void studentsTable_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

        }
    }
}
