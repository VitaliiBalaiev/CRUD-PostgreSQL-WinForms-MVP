using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bd8.Models;
using bd8.Views;

namespace bd8.Presenters
{

    // TODO subject, performance
    public class StudentPresenter
    {
        private readonly IStudentView view;
        private readonly IStudentRepository repository;
        private readonly BindingSource studentsBindingSource;
        private IEnumerable<StudentModel> studentList;

        public StudentPresenter(IStudentView view, IStudentRepository repository)
        {
            this.studentsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchStudent;
            this.view.AddNewEvent += AddNewStudent;
            this.view.EditEvent += LoadSelectedStudentToEdit;
            this.view.DeleteEvent += DeleleSelectedStudent;
            this.view.SaveEvent += SaveStudent;
            this.view.CancelEvent += CancelAction;
            this.view.SortBySurname += SortBySurname;
            this.view.SortByName += SortByName;
            this.view.ResetFilters += ResetFilters;

            this.view.SetStudentListBindingSource(studentsBindingSource);

            // Calling method for loading student list in constructor
            LoadAllStudentList();

            this.view.Show();
        }

        

        public void LoadAllStudentList()
        {
            studentList = repository.GetAll();
            studentsBindingSource.DataSource = studentList;
        }
        private void SearchStudent(object sender, EventArgs e) 
        {
            // If search value (search text box) IS NOT null - get student by search value
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                studentList = repository.GetByValue(this.view.SearchValue);
            }
            // If search value is empty (search text box) - display all students
            else
            {
                studentList = repository.GetAll();
            }

            studentsBindingSource.DataSource = studentList; // Refresh datagridview
        }

        private void AddNewStudent(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void LoadSelectedStudentToEdit(object sender, EventArgs e)
        {
            var student = (StudentModel)studentsBindingSource.Current;
            view.Surname = student.Surname;
            view.StudentName = student.Name;
            view.Patronymic = student.Patronymic;
            view.DateOfBirth = student.DateOfBirth.ToString();
            view.Gender = student.Gender;
            view.IdForm = student.IdForm.ToString();
            view.IsEdit = true;

        }
        private void SaveStudent(object sender, EventArgs e)
        {
            var model = new StudentModel
            {
                Surname = view.Surname,
                Name = view.StudentName,
                Patronymic = view.Patronymic,
                DateOfBirth = Convert.ToDateTime(view.DateOfBirth),
                Gender = view.Gender,
                IdForm = Convert.ToInt32(view.IdForm)
            };

            if (view.IsEdit)
            {
                repository.Edit(model);
                view.Message = "Успішно редаговано!";
            }
            else
            {
                repository.Add(model);
                view.Message = "Успішно додано!";
            }
            view.IsSuccessful = true;
            LoadAllStudentList();
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.Surname = "";
            view.StudentName = "";
            view.Patronymic = "";
            view.DateOfBirth = "";
            view.Gender = "";
            view.IdForm = "";
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void DeleleSelectedStudent(object sender, EventArgs e)
        {
            try
            {
                var student = (StudentModel)studentsBindingSource.Current;
                repository.Delete(student);
                view.IsSuccessful = true;
                view.Message = "Успішно видалено!";
                LoadAllStudentList();
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "Сталась помилка, неможливо видалити студента";
            }
        }

        private void SortBySurname(object sender, EventArgs e)
        {
            studentList = repository.SortBySurname();
            studentsBindingSource.DataSource = studentList;
        }

        private void SortByName(object sender, EventArgs e)
        {
            studentList = repository.SortByName();
            studentsBindingSource.DataSource = studentList;
        }

        private void ResetFilters(object sender, EventArgs e)
        {
            studentList = repository.ResetFilters();
            studentsBindingSource.DataSource = studentList;
        }
    }
}

