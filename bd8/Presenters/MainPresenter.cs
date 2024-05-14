using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bd8.Views;
using bd8.Models;
using bd8._Repositories;
using System.Windows.Forms;

namespace bd8.Presenters
{
    public class MainPresenter
    {
        private IMainView mainView;
        private readonly string PostgreSQLConnectionString;

        public MainPresenter(IMainView mainView, string sqlConnectionString)
        {
            this.mainView = mainView;
            this.PostgreSQLConnectionString = sqlConnectionString;
            this.mainView.ShowStudentView += ShowStudentsView;
            this.mainView.ShowTeacherView += ShowTeachersView;
            this.mainView.ShowFormView += ShowFormsView;
        }

        private void ShowStudentsView(object sender, EventArgs e)
        {
            IStudentView view = StudentView.GetInstance((MainView) mainView);
            IStudentRepository repository = new StudentRepository(PostgreSQLConnectionString);
            new StudentPresenter(view, repository);
        }

        private void ShowTeachersView(object sender, EventArgs e)
        {
            ITeacherView view = TeacherView.GetInstance((MainView)mainView);
            ITeacherRepository repository = new TeacherRepository(PostgreSQLConnectionString);
            new TeacherPresenter(view, repository);
        }
        private void ShowFormsView(object sender, EventArgs e)
        {
            IFormView view = FormView.GetInstance((MainView)mainView);
            IFormRepository repository = new FormRepository(PostgreSQLConnectionString);
            new FormPresenter(view, repository);
        }
    }
}
