using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd8.Models
{
    public class TeacherModel
    {
        private int id_teacher;
        private string surname;
        private string name;
        private string patronymic;
        private DateTime date_of_birth;
        private string gender;
        private int id_degree;
        private int id_school;

        [DisplayName("ID")]
        public int IdTeacher { get => id_teacher; set => id_teacher = value; }

        [DisplayName("Surname")]
        public string Surname { get => surname; set => surname = value; }


        [DisplayName("Name")]
        public string Name { get => name; set => name = value; }


        [DisplayName("Patronymic")]
        public string Patronymic { get => patronymic; set => patronymic = value; }


        [DisplayName("Date Of Birth")]
        public DateTime DateOfBirth { get => date_of_birth; set => date_of_birth = value; }

        [DisplayName("Gender")]
        public string Gender { get => gender; set => gender = value; }

        [DisplayName("Degree ID")]
        public int IdDegree { get => id_degree; set => id_degree = value; }

        [DisplayName("School ID")]
        public int IdSchool { get => id_school; set => id_school = value; }
    }
}
