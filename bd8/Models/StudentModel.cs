using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


namespace bd8.Models
{
    public class StudentModel
    {
        private int id_student;
        private string surname;
        private string name;
        private string patronymic;
        private DateTime date_of_birth;
        private string gender;
        private int id_form;

        [DisplayName("ID")]
        public int IdStudent { get => id_student; set => id_student = value; }

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

        [DisplayName("Form ID")]
        public int IdForm { get => id_form; set => id_form = value; }
    }
}
