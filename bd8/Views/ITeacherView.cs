using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd8.Views
{
    public interface ITeacherView
    {
        string Surname { get; set; }
        string TeacherName { get; set; }
        string Patronymic { get; set; }
        string DateOfBirth { get; set; }

        string Gender { get; set; }
        string IdDegree { get; set; }
        string IdSchool { get; set; }

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
        event EventHandler SortBySurnameTeacher;
        event EventHandler SortByNameTeacher;
        event EventHandler ResetFilters;

        void SetTeacherListBindingSource(BindingSource teacherList);
        void Show();
    }
}
