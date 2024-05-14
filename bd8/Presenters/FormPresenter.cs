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
    public class FormPresenter
    {
        private readonly IFormView view;
        private readonly IFormRepository repository;
        private readonly BindingSource formsBindingSource;
        private IEnumerable<FormModel> formList;

        public FormPresenter(IFormView view, IFormRepository repository)
        {
            this.formsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            this.view.SearchEvent += SearchForm;
            this.view.AddNewEvent += AddNewForm;
            this.view.EditEvent += LoadSelectedFormToEdit;
            this.view.DeleteEvent += DeleleSelectedForm;
            this.view.SaveEvent += SaveForm;
            this.view.CancelEvent += CancelAction;
            this.view.SortByStudentsNumber += SortByStudentsNumber;
            this.view.ResetFilters += ResetFilters;

            this.view.SetFormListBindingSource(formsBindingSource);

            // Calling method for loading student list in constructor
            LoadAllFormList();

            this.view.Show();
        }



        public void LoadAllFormList()
        {
            formList = repository.GetAll();
            formsBindingSource.DataSource = formList;
        }
        private void SearchForm(object sender, EventArgs e)
        {
            // If search value (search text box) IS NOT null - get form by search value
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if (emptyValue == false)
            {
                formList = repository.GetByValue(this.view.SearchValue);
            }
            // If search value is empty (search text box) - display all forms
            else
            {
                formList = repository.GetAll();
            }

            formsBindingSource.DataSource = formList; // Refresh datagridview
        }

        private void AddNewForm(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
        private void LoadSelectedFormToEdit(object sender, EventArgs e)
        {
            var form = (FormModel) formsBindingSource.Current;
            view.FormName = form.FormName;
            view.NumberOfStudents = form.NumberOfStudents.ToString();
            view.IdTeacher = form.IdTeacher.ToString();
            view.IsEdit = true;

        }
        private void SaveForm(object sender, EventArgs e)
        {
            var model = new FormModel
            {
                FormName = view.FormName,
                NumberOfStudents = Convert.ToInt32(view.NumberOfStudents),
                IdTeacher = Convert.ToInt32(view.IdTeacher)
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
            LoadAllFormList();
            CleanViewFields();
        }

        private void CleanViewFields()
        {
            view.FormName = "";
            view.NumberOfStudents = "";
            view.IdTeacher = "";
        }

        private void CancelAction(object sender, EventArgs e)
        {
            CleanViewFields();
        }
        private void DeleleSelectedForm(object sender, EventArgs e)
        {
            try
            {
                var form = (FormModel)formsBindingSource.Current;
                repository.Delete(form);
                view.IsSuccessful = true;
                view.Message = "Успішно видалено!";
                LoadAllFormList();
            }
            catch (Exception)
            {
                view.IsSuccessful = false;
                view.Message = "Сталась помилка, неможливо видалити клас";
            }
        }

        private void SortByStudentsNumber(object sender, EventArgs e)
        {
            formList = repository.SortByStudentsNumber();
            formsBindingSource.DataSource = formList;
        }

        private void ResetFilters(object sender, EventArgs e)
        {
            formList = repository.ResetFilters();
            formsBindingSource.DataSource = formList;
        }
    }
}
