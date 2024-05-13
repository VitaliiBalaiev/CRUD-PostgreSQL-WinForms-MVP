using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd8.Models
{
    public interface IStudentRepository
    {
        void Add(StudentModel studentModel);
        void Edit(StudentModel studentModel);
        void Delete(StudentModel studentModel);

        
        IEnumerable<StudentModel> GetAll();
        IEnumerable<StudentModel> GetByValue(string value);
        IEnumerable<StudentModel> SortBySurname();
        IEnumerable<StudentModel> SortByName();
        IEnumerable<StudentModel> ResetFilters();

    }
}
