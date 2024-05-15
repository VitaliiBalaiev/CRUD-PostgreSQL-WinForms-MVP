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
    public partial class FormView : Form, IFormView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public FormView()
        {
            InitializeComponent();
            RaiseViewEvent();
            tabControl3.TabPages.Remove(tabFormDetails);
        }

        private void RaiseViewEvent()
        {
            // Search button
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtFormSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            // Add button
            btnAddNew.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl3.TabPages.Remove(tabFormList);
                tabControl3.TabPages.Add(tabFormDetails);
                tabFormDetails.Text = "Додати новий клас";
            };
            // Edit button
            btnEdit.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl3.TabPages.Remove(tabFormList);
                tabControl3.TabPages.Add(tabFormDetails);
                tabFormDetails.Text = "Редагувати дані";

            };
            // Delete button
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Ви дійсно хочете видалити цей запис?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
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
                    tabControl3.TabPages.Remove(tabFormDetails);
                    tabControl3.TabPages.Add(tabFormList);
                }
                MessageBox.Show(Message);
            };
            // Cancel button
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl3.TabPages.Remove(tabFormDetails);
                tabControl3.TabPages.Add(tabFormList);
            };
            // Sort by student number (1-9)
            btnSortByStudentNumber.Click += delegate
            {
                SortByStudentsNumber?.Invoke(this, EventArgs.Empty);
            };

            // Reset filters button
            btnResetFilters.Click += delegate
            {
                ResetFilters?.Invoke(this, EventArgs.Empty);
            };
        }

        public string IdForm
        {
            get { return txtIdForm.Text; }
            set { txtIdForm.Text = value; }
        }

        public string FormName
        {
            get { return txtFormName.Text; }
            set { txtFormName.Text = value; }
        }
        public string NumberOfStudents
        {
            get { return txtNumberOfStudents.Text; }
            set { txtNumberOfStudents.Text = value; }
        }
        public string IdTeacher
        {
            get { return txtIdTeacher.Text; }
            set { txtIdTeacher.Text = value; }
        }

        public string SearchValue
        {
            get { return txtFormSearch.Text; }
            set { txtFormSearch.Text = value; }
        }
        public bool IsEdit
        {
            get { return isEdit; }
            set { isEdit = value; }
        }
        public bool IsSuccessful
        {
            get { return isSuccessful; }
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
        public event EventHandler SortByStudentsNumber;
        public event EventHandler ResetFilters;

        public void SetFormListBindingSource(BindingSource formList)
        {
            dataGridView3.DataSource = formList;
        }

        private static FormView instance;
        public static FormView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new FormView
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
