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
    public partial class TeacherView : Form, ITeacherView
    {
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public TeacherView()
        {
            InitializeComponent();
            RaiseViewEvent();
            tabControl2.TabPages.Remove(tabTeacherDetails);
        }

        private void RaiseViewEvent()
        {
            // Search button
            btnTeacherSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txtTeacherSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };
            // Add button
            btnAddNewTeacher.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl2.TabPages.Remove(tabTeacherList);
                tabControl2.TabPages.Add(tabTeacherDetails);
                tabTeacherDetails.Text = "Додати нового вчителя";
            };
            // Edit button
            btnEditTeacher.Click += delegate
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
                tabControl2.TabPages.Remove(tabTeacherList);
                tabControl2.TabPages.Add(tabTeacherDetails);
                tabTeacherDetails.Text = "Редагувати дані";

            };
            // Delete button
            btnDeleteTeacher.Click += delegate
            {
                var result = MessageBox.Show("Ви дійсно хочете видалити цей запис?", "Увага!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(Message);
                }
            };
            // Save button
            btnSaveChangesTeacher.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (isSuccessful)
                {
                    tabControl2.TabPages.Remove(tabTeacherDetails);
                    tabControl2.TabPages.Add(tabTeacherList);
                }
                MessageBox.Show(Message);
            };
            // Cancel button
            btnCancelTeacher.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl2.TabPages.Remove(tabTeacherDetails);
                tabControl2.TabPages.Add(tabTeacherList);
            };
            // Sort by surname (A-Z) button
            btnSortBySurnameTeacher.Click += delegate
            {
                SortBySurnameTeacher?.Invoke(this, EventArgs.Empty);
            };
            // Sort by name (A-Z) button
            btnSortByNameTeacher.Click += delegate
            {
                SortByNameTeacher?.Invoke(this, EventArgs.Empty);
            };
            // Reset filters button
            btnResetFilters.Click += delegate
            {
                ResetFilters?.Invoke(this, EventArgs.Empty);
            };
        }

        public string IdTeacher
        {
            get { return txtTeacherID.Text; }
            set { txtTeacherID.Text = value; }
        }
        public string Surname
        {
            get { return txtTeacherSurname.Text; }
            set { txtTeacherSurname.Text = value; }
        }
        public string Name
        {
            get { return txtTeacherName.Text; }
            set { txtTeacherName.Text = value; }
        }
        public string Patronymic
        {
            get { return txtTeacherPatronymic.Text; }
            set { txtTeacherPatronymic.Text = value; }
        }
        public string DateOfBirth
        {
            get { return dateTeacherPicker.Text.ToString(); }
            set { dateTeacherPicker.Text = value; }
        }
        public string Gender
        {
            get { return txtTeacherGender.Text; }
            set { txtTeacherGender.Text = value; }
        }

        public string IdDegree
        {
            get { return txtTeacherDegree.Text; }
            set { txtTeacherDegree.Text = value; }
        }
        public string IdSchool
        {
            get { return txtTeacherIDSchool.Text; }
            set { txtTeacherIDSchool.Text = value; }
        }
        public string SearchValue
        {
            get { return txtTeacherSearch.Text; }
            set { txtTeacherSearch.Text = value; }
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
        public event EventHandler SortBySurnameTeacher;
        public event EventHandler SortByNameTeacher;
        public event EventHandler ResetFilters;

        public void SetTeacherListBindingSource(BindingSource teacherList)
        {
            dataGridView2.DataSource = teacherList;
        }

        private static TeacherView instance;
        public static TeacherView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new TeacherView
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
