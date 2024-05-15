using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd8.Views
{
    public interface IStudentView
    {
        string IdStudent { get; set; }
        string Surname { get; set; }
        string StudentName { get; set; }
        string Patronymic { get; set; }
        string DateOfBirth { get; set; }

        string Gender { get; set; }
        string IdForm { get; set; }

        string SearchValue { get; set; }
        bool IsEdit { get; set; }
        bool IsSuccessful { get; set; }
        string Message { get; set; }

        event EventHandler SearchEvent;
        event EventHandler AddNewEvent;
        event EventHandler EditEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler CancelEvent;
        event EventHandler SortBySurname;
        event EventHandler SortByName;
        event EventHandler ResetFilters;
        void SetStudentListBindingSource(BindingSource studentList);
        void Show();
    }
}
