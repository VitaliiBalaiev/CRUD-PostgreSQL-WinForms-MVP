using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd8.Views
{
    public partial class MainView : Form, IMainView
    {
        public MainView()
        {
            InitializeComponent();
            btnStudents.Click += delegate { ShowStudentView?.Invoke(this, EventArgs.Empty); };
            btnTeachers.Click += delegate { ShowTeacherView?.Invoke(this, EventArgs.Empty); };
            btnForms.Click += delegate { ShowFormView?.Invoke(this, EventArgs.Empty); };
        }

        public event EventHandler ShowStudentView;
        public event EventHandler ShowTeacherView;
        public event EventHandler ShowFormView;
    }
}
