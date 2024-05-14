using bd8.Models;
using bd8.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bd8.Presenters
{
    public class TeacherPresenter
    {
        private readonly ITeacherView view;
        private readonly ITeacherRepository repository;
        private readonly BindingSource teachersBindingSource;
        private IEnumerable<TeacherModel> teacherList;

        public TeacherPresenter(ITeacherView view, ITeacherRepository repository)
        {
            this.teachersBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchTeacher;
            this.view.AddNewEvent += AddNewTeacher;
            this.view.EditEvent += LoadSelectedTeacherToEdit;
            this.view.DeleteEvent += DeleleSelectedTeacher;
            this.view.SaveEvent += SaveTeacher;
            this.view.CancelEvent += CancelAction;
            this.view.SortBySurnameTeacher += SortBySurnameTeacher;
            this.view.SortByNameTeacher += SortByNameTeacher;
            this.view.ResetFilters += ResetFilters;

            this.view.SetTeacherListBindingSource(teachersBindingSource);

            // Calling method for loading student list in constructor 
            LoadAllTeachersList();

            this.view.Show();
        }

        private void LoadAllTeachersList()
        {
            teacherList = repository.GetAll();
            teachersBindingSource.DataSource = teacherList;
        }
        private void SearchTeacher(object sender, EventArgs e) 
        {
            // If search value (search text box) IS NOT null - get teacher by search value
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                teacherList = repository.GetByValue(this.view.SearchValue);
            }
            // If search value is empty (search text box) - display all teachers
            else
            {
                teacherList = repository.GetAll();
            }

            teachersBindingSource.DataSource = teacherList; // Refresh datagridview
        }

        private void AddNewTeacher(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void LoadSelectedTeacherToEdit(object sender, EventArgs e)
        {
            var teacher = (TeacherModel)teachersBindingSource.Current;
            view.Surname = teacher.Surname;
            view.TeacherName = teacher.Name;
            view.Patronymic = teacher.Patronymic;
            view.DateOfBirth = teacher.DateOfBirth.ToString();
            view.Gender = teacher.Gender;
            view.IdDegree = teacher.IdDegree.ToString();
            view.IdSchool = teacher.IdSchool.ToString();
            view.IsEdit = true;

        }
        private void SaveTeacher(object sender, EventArgs e)
        {
            var model = new TeacherModel
            {
                Surname = view.Surname,
                Name = view.TeacherName,
                Patronymic = view.Patronymic,
                DateOfBirth = Convert.ToDateTime(view.DateOfBirth),
                Gender = view.Gender,
                IdDegree = Convert.ToInt32(view.IdDegree),
                IdSchool = Convert.ToInt32(view.IdSchool)
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
            LoadAllTeachersList();
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.Surname = "";
            view.TeacherName = "";
            view.Patronymic = "";
            view.DateOfBirth = "";
            view.Gender = "";
            view.IdDegree = "";
            view.IdSchool = "";
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void DeleleSelectedTeacher(object sender, EventArgs e)
        {
            try
            {
                var teacher = (TeacherModel)teachersBindingSource.Current;
                repository.Delete(teacher);
                view.IsSuccessful = true;
                view.Message = "Успішно видалено!";
                LoadAllTeachersList();
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "Сталась помилка, неможливо видалити вчителя";
            }
        }
        private void SortBySurnameTeacher(object sender, EventArgs e)
        {
            teacherList = repository.SortBySurnameTeacher();
            teachersBindingSource.DataSource = teacherList;
        }

        private void SortByNameTeacher(object sender, EventArgs e)
        {
            teacherList = repository.SortByNameTeacher();
            teachersBindingSource.DataSource = teacherList;
        }

        private void ResetFilters(object sender, EventArgs e)
        {
            teacherList = repository.ResetFilters();
            teachersBindingSource.DataSource = teacherList;
        }
    }
}
