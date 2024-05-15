using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd8.Views
{
    public interface IFormView
    {
        string IdForm { get; set; }
        string FormName { get; set; }
        string NumberOfStudents { get; set; }
        string IdTeacher { get; set; }

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
        event EventHandler SortByStudentsNumber;
        event EventHandler ResetFilters;
        void SetFormListBindingSource(BindingSource formList);
        void Show();
    }
}
