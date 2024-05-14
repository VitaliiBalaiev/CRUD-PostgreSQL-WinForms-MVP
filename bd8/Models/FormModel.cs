using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd8.Models
{
    public class FormModel
    {
        private int id_form;
        private string form_name;
        private int number_of_students;
        private int id_teacher;
        private string teacher_surname;

        [DisplayName("ID")]
        public int IdForm { get => id_form; set => id_form = value; }


        [DisplayName("Name")]
        public string FormName { get => form_name; set => form_name = value; }

        [DisplayName("Number of Students")]
        public int NumberOfStudents { get => number_of_students; set => number_of_students = value; }


        [System.ComponentModel.Browsable(false)]
        [DisplayName("Teacher ID")]
        public int IdTeacher { get => id_teacher; set => id_teacher = value; }

        [DisplayName("Form Teacher")]
        public string TeacherSurname { get => teacher_surname; set => teacher_surname = value; }
    }
}
