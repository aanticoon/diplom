using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Linq;
using WinFormsApp1.Logic;
using WinFormsApp1.Models;
using static System.Windows.Forms.AxHost;

namespace WinFormsApp1.Forms
{
    public partial class StudentCardForm : Form
    {
        private const int DefaultNewRowIndex = -1;
        private const int DefaultDeletingRowIndex = -11;
        private const int DefaultUpdateRowIndex = -22;

        private readonly IAuthService _authService;

        private BindingList<StudentCardModel> bindingList;

        int LastNewRowIndex = DefaultNewRowIndex;
        int LastDeletingRowIndex = DefaultDeletingRowIndex;
        int CurrentlyChangingRow = DefaultUpdateRowIndex;


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
                    id = (int)(newRowData.Cells[0].Value),
                    Group_id = (int)newRowData.Cells[1].Value,
                    Fname = (string)(newRowData.Cells[2].Value),
                    Sname = (string)(newRowData.Cells[3].Value),
                    Lname = (string)(newRowData.Cells[4].Value),
                    gender = (string)(newRowData.Cells[5].Value),
                    Addres = (string)(newRowData.Cells[7].Value),
                    Phone = (int)(newRowData.Cells[8].Value),
                    Email = (string)(newRowData.Cells[9].Value),
                    hometown = (string)(newRowData.Cells[10].Value),
                    residence = (string)(newRowData.Cells[11].Value),
                    Character = (string)(newRowData.Cells[12].Value),
                    BDate = DateTime.Now
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


/*        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (LastNewRowIndex != DefaultNewRowIndex)
            {
                var newStudentCard = new StudentCardModel
                {
                    id = Convert.ToInt32(studentsTable.Rows[LastNewRowIndex].Cells[0].Value),
                    Fname = (string)studentsTable.Rows[LastNewRowIndex].Cells[1].Value,
                    Sname = (string)studentsTable.Rows[LastNewRowIndex].Cells[2].Value,
                    Lname = (string)studentsTable.Rows[LastNewRowIndex].Cells[3].Value,
                    gender = (string)studentsTable.Rows[LastNewRowIndex].Cells[5].Value,
                    Addres = (string)studentsTable.Rows[LastNewRowIndex].Cells[6].Value,
                    Phone = Convert.ToInt32(studentsTable.Rows[LastNewRowIndex].Cells[7].Value),
                    Email = (string)studentsTable.Rows[LastNewRowIndex].Cells[8].Value,
                    hometown = (string)studentsTable.Rows[LastNewRowIndex].Cells[9].Value,
                    residence = (string)studentsTable.Rows[LastNewRowIndex].Cells[10].Value,
                    Character = (string)studentsTable.Rows[LastNewRowIndex].Cells[11].Value,
                    BDate = DateTime.Now
                };

                _authService.SaveStudentCard(newStudentCard);
            }

            if (CurrentlyChangingRow != DefaultUpdateRowIndex)
            {
                var updatedStudentModel = new StudentCardModel
                {
                    id = Convert.ToInt32(studentsTable.Rows[CurrentlyChangingRow].Cells[0].Value),
                    Fname = (string)studentsTable.Rows[CurrentlyChangingRow].Cells[1].Value,
                    Sname = (string)studentsTable.Rows[CurrentlyChangingRow].Cells[2].Value,
                    Lname = (string)studentsTable.Rows[CurrentlyChangingRow].Cells[3].Value,
                    gender = (string)studentsTable.Rows[CurrentlyChangingRow].Cells[5].Value,
                    Addres = (string)studentsTable.Rows[CurrentlyChangingRow].Cells[6].Value,
                    Phone = Convert.ToInt32(studentsTable.Rows[CurrentlyChangingRow].Cells[7].Value),
                    Email = (string)studentsTable.Rows[CurrentlyChangingRow].Cells[8].Value,
                    hometown = (string)studentsTable.Rows[CurrentlyChangingRow].Cells[9].Value,
                    residence = (string)studentsTable.Rows[CurrentlyChangingRow].Cells[10].Value,
                    Character = (string)studentsTable.Rows[CurrentlyChangingRow].Cells[11].Value,
                    BDate = DateTime.Now
                };

                _authService.UpdateStudentCard(updatedStudentModel);
            }

            LastNewRowIndex = DefaultNewRowIndex;
            CurrentlyChangingRow = DefaultUpdateRowIndex;

            UnlockTableForEdit();
            RefreshTable();
        }*/
        private void DisableOtherRowsAndActivateButtons(int rowToEdit)
        {
            foreach (DataGridViewRow dataRow in studentsTable.Rows)
            {
                if (dataRow.Index != rowToEdit)
                {
                    dataRow.DefaultCellStyle.BackColor = Color.Gray;
                    dataRow.ReadOnly = true;
                }
            }
            SaveButton.Visible = true;
        }
    }
}
