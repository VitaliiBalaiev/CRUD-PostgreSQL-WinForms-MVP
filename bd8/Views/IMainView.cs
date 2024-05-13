using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd8.Views
{
    public interface IMainView
    {
        event EventHandler ShowStudentView;
        event EventHandler ShowTeacherView;
        event EventHandler ShowDegreeView;
    }
}
