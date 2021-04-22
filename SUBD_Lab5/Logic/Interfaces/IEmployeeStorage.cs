using Logic.BindingModels;
using Logic.ViewModels;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IEmployeeStorage
    {
        List<EmployeeVM> GetFullList();
        List<EmployeeVM> GetFilteredList(EmployeeBM model);
        EmployeeVM GetElement(EmployeeBM model);
        void Insert(EmployeeBM model);
        void Update(EmployeeBM model);
        void Delete(EmployeeBM model);
    }
}
