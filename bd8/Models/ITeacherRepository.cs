using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd8.Models
{
    public interface ITeacherRepository
    {
        void Add(TeacherModel teacherModel);
        void Edit(TeacherModel teacherModel);
        void Delete(TeacherModel teacherModel);


        IEnumerable<TeacherModel> GetAll();
        IEnumerable<TeacherModel> GetByValue(string value);
        IEnumerable<TeacherModel> SortBySurnameTeacher();
        IEnumerable<TeacherModel> SortByNameTeacher();
        IEnumerable<TeacherModel> ResetFilters();
    } 
}
