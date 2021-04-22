using Logic.BindingModels;
using Logic.Interfaces;
using Logic.ViewModels;
using Implements.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Implements.Implements
{
    public class EmployeeStorage : IEmployeeStorage
    {
        public List<EmployeeVM> GetFullList()
        {
            using (var context = new DataBaseContext())
            {
                return context.Employees
                .Select(CreateModel).ToList();
            }
        }

        public List<EmployeeVM> GetFilteredList(EmployeeBM model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                return context.Employees
                    .Where(rec => rec.Birthday >= model.Birthday)
                    .Select(CreateModel).ToList();
            }
        }

        public EmployeeVM GetElement(EmployeeBM model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new DataBaseContext())
            {
                var employee = context.Employees
                .FirstOrDefault(rec => rec.Id == model.Id);
                return employee != null ?
                CreateModel(employee) : null;
            }
        }

        public void Insert(EmployeeBM model)
        {
            using (var context = new DataBaseContext())
            {
                context.Employees.Add(CreateModel(model, new Employee()));
                context.SaveChanges();
            }
        }

        public void Update(EmployeeBM model)
        {
            using (var context = new DataBaseContext())
            {
                Employee element = context.Employees.FirstOrDefault(rec => rec.Id == model.Id);
                if (element == null)
                {
                    throw new Exception("Сотрудник не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(EmployeeBM model)
        {
            using (var context = new DataBaseContext())
            {
                Employee element = context.Employees.FirstOrDefault(rec => rec.Id == model.Id);
                if (element != null)
                {
                    context.Employees.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Сотрудник не найден");
                }
            }
        }

        private Employee CreateModel(EmployeeBM model, Employee employee)
        {
            employee.Name = model.Name;
            employee.Surname = model.Surname;
            employee.Patronymic = model.Patronymic;
            employee.Birthday = model.Birthday;
            employee.Position = model.Position;
            employee.Salary = model.Salary;
            return employee;
        }

        private EmployeeVM CreateModel(Employee employee)
        {
            return new EmployeeVM
            {
                Id = employee.Id,
                Name = employee.Name,
                Surname = employee.Surname,
                Patronymic = employee.Patronymic,
                Birthday = employee.Birthday,
                Position = employee.Position,
                Salary = employee.Salary
            };
        }
    }
}
