using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd8.Models
{
    public interface IFormRepository
    {
        void Add(FormModel formModel);
        void Edit(FormModel formModel);
        void Delete(FormModel formModel);


        IEnumerable<FormModel> GetAll();
        IEnumerable<FormModel> GetByValue(string value);
        IEnumerable<FormModel> SortByStudentsNumber();
        IEnumerable<FormModel> ResetFilters();

    }
}
