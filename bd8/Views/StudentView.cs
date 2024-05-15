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
    public partial class StudentView : Form, IStudentView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public StudentView()
        {
            InitializeComponent();
            RaiseViewEvent();
            tabControl1.TabPages.Remove(tabStudentDetails);
        }

        private void RaiseViewEvent()
        {
            // Search button
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtStudentSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            // Add button
            btnAddNew.Click += delegate 
            { 
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabStudentList);
                tabControl1.TabPages.Add(tabStudentDetails);
                tabStudentDetails.Text = "Додати нового студента";
            };
            // Edit button
            btnEdit.Click += delegate 
            { 
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabStudentList);
                tabControl1.TabPages.Add(tabStudentDetails);
                tabStudentDetails.Text = "Редагувати дані";

            };
            // Delete button
            btnDelete.Click += delegate
            { 
                var result = MessageBox.Show("Ви дійсно хочете видалити цей запис?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result==DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            // Save button
            btnSaveChanges.Click += delegate 
            {
               SaveEvent?.Invoke(this, EventArgs.Empty);
               if (isSuccessful)
                {
                    tabControl1.TabPages.Remove(tabStudentDetails);
                    tabControl1.TabPages.Add(tabStudentList);
                }
                MessageBox.Show(Message);
            };
            // Cancel button
            btnCancel.Click += delegate 
            { 
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl1.TabPages.Remove(tabStudentDetails);
                tabControl1.TabPages.Add(tabStudentList);
            };
            // Sort by surname (A-Z)
            btnSortBySurname.Click += delegate
            {
                SortBySurname?.Invoke(this, EventArgs.Empty);
            };
            // Sort by name (A-Z)
            btnSortByName.Click += delegate
            {
                SortByName?.Invoke(this, EventArgs.Empty);
            };
            // Reset filters button
            btnResetFilters.Click += delegate
            {
                ResetFilters?.Invoke(this, EventArgs.Empty);
            };
        }

        public string IdStudent
        {
            get { return txtIdStudent.Text; }
            set { txtIdStudent.Text = value; }
        }

        public string Surname
        {
            get { return txtStudentSurname.Text; }
            set { txtStudentSurname.Text = value; }
        }
        public string StudentName
        {
            get { return txtStudentName.Text; }
            set { txtStudentName.Text = value; }
        }
        public string Patronymic
        {
            get { return txtStudentPatronymic.Text; }
            set { txtStudentPatronymic.Text = value; }
        }
        public string DateOfBirth
        {
            get { return dateStudentPicker.Text.ToString();  }
            set { dateStudentPicker.Text = value; }
        }
        public string Gender
        {
            get { return txtStudentGender.Text; }
            set { txtStudentGender.Text = value; }
        }

        public string IdForm
        {
            get { return txtStudentForm.Text; }
            set { txtStudentForm.Text = value; }
        }
        public string SearchValue
        {
            get { return txtStudentSearch.Text; }
            set { txtStudentSearch.Text=value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful 
        {   get { return isSuccessful; }
            set { isSuccessful = value; } 
        }
        public string Message
        { 
            get { return message; } 
            set { message = value; } 
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;
        public event EventHandler SortBySurname;
        public event EventHandler SortByName;
        public event EventHandler ResetFilters;

        public void SetStudentListBindingSource(BindingSource studentList)
        {
            dataGridView1.DataSource = studentList;
        }

        private static StudentView instance;
        public static StudentView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new StudentView
                {
                    MdiParent = parentContainer,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill
                };
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                {
                    instance.WindowState = FormWindowState.Normal; 
                }
                instance.BringToFront();
            }
            return instance;
        }

    }
}
