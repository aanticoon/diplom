using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Logic;
using WinFormsApp1.Models;

namespace WinFormsApp1.Forms
{
    public partial class StudentCardForm : Form
    {
        private readonly IAuthService _authService;

        private BindingList<StudentCardModel> bindingList;

        int LastNewRowIndex = -1;
        int LastDeletingRowIndex = -11;

        public StudentCardForm(IAuthService authService)
        {
            InitializeComponent();

            _authService = authService;

            InitializeTableData();
        }
        private void studentsTable_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            LastNewRowIndex = e.Row.Index - 1;
        }

        private void studentsTable_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            if (LastDeletingRowIndex > -11)
            {
                _authService.DeleteStudentCard(LastDeletingRowIndex);
                LastDeletingRowIndex = -11;
            }
        }

        private void studentsTable_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (LastNewRowIndex > -1)
            {
                studentsTable.CommitEdit(DataGridViewDataErrorContexts.Commit);
                var newRowData = studentsTable.Rows[LastNewRowIndex];

                var studentCard = new StudentCardModel
                {
                    Fname = (string)newRowData.Cells[1].Value,
                    Sname = (string)newRowData.Cells[2].Value,
                    Lname = (string)newRowData.Cells[3].Value,
                    BDate = (string)newRowData.Cells[4].Value,
                    gender = (string)newRowData.Cells[5].Value,
                    Addres = (string)newRowData.Cells[6].Value,
                    Phone = (string)newRowData.Cells[7].Value,
                    Email = (string)newRowData.Cells[8].Value,
                    hometown = (string)newRowData.Cells[9].Value,
                    residence = (string)newRowData.Cells[10].Value,
                    Character = (string)newRowData.Cells[11].Value,
                };

                var newId = _authService.SaveStudentCard(studentCard);

                LastNewRowIndex = -1;
                RefreshTable();
            }
        }

        private void studentsTable_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            LastDeletingRowIndex = (int)e.Row.Cells[0].Value;
        }

        private void RefreshTable()
        {
            bindingList = new BindingList<StudentCardModel>(_authService.GetStudentCards());

            studentsTable.Update();
            studentsTable.Refresh();
        }

        private void InitializeTableData()
        {
            var studentCards = _authService.GetStudentCards();
            bindingList = new BindingList<StudentCardModel>(studentCards);
            var source = new BindingSource(bindingList, null);

            studentsTable.DataSource = source;
            studentsTable.ForeColor = Color.Black;
        }

        private void studentsTable_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var columnId = e.ColumnIndex;
            var rowId = e.RowIndex;
            var changedValue = studentsTable.Rows[rowId].Cells[columnId].Value;

            switch (columnId)
            {
                case 0: { break; }
                case 1:
                    {
                        var name = (string)changedValue;

                        break;
                    }
                case 2: { break; }
                case 3: { break; }
            }
        }
    }
}
