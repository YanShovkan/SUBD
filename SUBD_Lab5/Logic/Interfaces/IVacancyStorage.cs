using Logic.BindingModels;
using Logic.ViewModels;
using System.Collections.Generic;

namespace Logic.Interfaces
{
    public interface IVacancyStorage
    {
        List<VacancyVM> GetFullList();
        List<VacancyVM> GetFilteredList(VacancyBM model);
        VacancyVM GetElement(VacancyBM model);
        void Insert(VacancyBM model);
        void Update(VacancyBM model);
        void Delete(VacancyBM model);
        void UpdateEmployment(VacancyBM model);
    }
}
