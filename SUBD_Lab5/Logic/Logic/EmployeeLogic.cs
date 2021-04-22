using Logic.BindingModels;
using Logic.Interfaces;
using Logic.ViewModels;
using System;
using System.Collections.Generic;

namespace Logic.Logic
{
    public class EmployeeLogic
    {
        private readonly IEmployeeStorage _employeeStorage;
        public EmployeeLogic(IEmployeeStorage employeeStorage)
        {
            _employeeStorage= employeeStorage;
        }
        public List<EmployeeVM> Read(EmployeeBM model)
        {
            if (model == null)
            {
                return _employeeStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<EmployeeVM> { _employeeStorage.GetElement(model) };
            }
            return _employeeStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(EmployeeBM model)
        {
            if (model.Id.HasValue)
            {
                _employeeStorage.Update(model);
            }
            else
            {
                _employeeStorage.Insert(model);
            }
        }
        public void Delete(EmployeeBM model)

        {
            var element = _employeeStorage.GetElement(new EmployeeBM
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Сотрудник не найден");
            }
            _employeeStorage.Delete(model);
        }
    }
}
